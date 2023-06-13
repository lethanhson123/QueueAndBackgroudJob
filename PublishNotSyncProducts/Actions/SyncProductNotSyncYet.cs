
namespace PublishNotSyncProducts.Actions
{
    public class SyncProductNotSyncYet
	{
        private readonly ILogger<PublishNotSyncProductsWorker> _loggerWindows;
        private readonly List<IQueuePublisher<MemberPlusProductNotSyncYetQueueModel>> _publishers;
        private readonly IMemberPlusProductNotSyncYetServices _memberPlusProductNotSyncYetServices;

        public SyncProductNotSyncYet(
            ILogger<PublishNotSyncProductsWorker> loggerWindows,
			IMemberPlusProductNotSyncYetServices memberPlusProductNotSyncYetServices)
        {
            _loggerWindows = loggerWindows;
            _publishers = CreatePublisher();
			_memberPlusProductNotSyncYetServices = memberPlusProductNotSyncYetServices;
        }

        public async void SendToSQS()
        {
            try
            {
                var inQueueItems = await _memberPlusProductNotSyncYetServices.PublishAsync();
                _loggerWindows.LogWarning("Load {inQueueItems} MemberPlusProductNotSyncYetQueueModel(s) successful!!!", inQueueItems.Count);

                if (inQueueItems.Any())
                {
                    Parallel.ForEach(_publishers, async publisher => { await publisher.SendMessages(inQueueItems); });
                }
            }
            catch (Exception e)
            {
                _loggerWindows.LogError(e, "{Message}", e.Message);
                Console.WriteLine(e.Message);
            }
        }

        private List<IQueuePublisher<MemberPlusProductNotSyncYetQueueModel>> CreatePublisher()
        {
            try
            {
                _loggerWindows.LogInformation("Create Sync MemberPlusProductNotSyncYetQueueModel Publisher.");
                List<IQueuePublisher<MemberPlusProductNotSyncYetQueueModel>> queuePublishers = new List<IQueuePublisher<MemberPlusProductNotSyncYetQueueModel>>();
                var providerSetting = AppSettingsConstant.Application.Services["awsSQS"]["Provider"];
                var provider = Common.ParseEnum<QueueProvider>(providerSetting);
                switch (provider)
                {
                    case QueueProvider.AWS:

                        var amazonSetting = new AmazonQueueSetting();
                        amazonSetting.RegionEndpoint = AppSettingsConstant.Application.Services["awsSQS"]["RegionEndpoint"];
                        amazonSetting.AccessKey = AppSettingsConstant.Application.Services["awsSQS"]["AccessKey"];
                        amazonSetting.SecretKey = AppSettingsConstant.Application.Services["awsSQS"]["SecretKey"];
                        amazonSetting.QueueUrl = AppSettingsConstant.Application.Services["awsSQS"]["QueueUrl"];

                        queuePublishers.Add(QueueEngineFactory.CreatePublisher<MemberPlusProductNotSyncYetQueueModel>(provider, amazonSetting, ""));
                        break;
                }

                return queuePublishers;
            }
            catch (Exception ex)
            {
                _loggerWindows.LogError(ex, ex.Message);
            }

            return default;
        }
    }
}
