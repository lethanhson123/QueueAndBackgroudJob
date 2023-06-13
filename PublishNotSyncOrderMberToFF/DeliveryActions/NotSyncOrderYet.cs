using BusinessServices.Models.MessageQueueModel;
using BusinessServices.Services.Interface;
using QueueEngine;
using QueueEngine.Behaviors;
using QueueEngine.Models.QueueSetting;
using Utilities;

namespace PublishNotSyncOrderMberToFF.DeliveryActions
{
    public class NotSyncOrderYet
    {
        private readonly ILogger<PublishNotSyncOrderMberToFFWorker> _loggerWindows;
        private readonly List<IQueuePublisher<SyncOrderMplusToFFQueueModel>> _publishers;
        private readonly IMplusOrderNotSyncYetServices _service;

        public NotSyncOrderYet(
            ILogger<PublishNotSyncOrderMberToFFWorker> loggerWindows,
            IMplusOrderNotSyncYetServices service)
        {
            _loggerWindows = loggerWindows;
            _publishers = CreatePublisher();
            _service = service;
        }

        public async Task SendToSQS()
        {
            try
            {
                var inQueueItems = await _service.LoadUnSyncOrderFromMPlus();
                _loggerWindows.LogWarning("Load {inQueueItems} inQueueItems successful!!!", inQueueItems.Count);

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

        private List<IQueuePublisher<SyncOrderMplusToFFQueueModel>> CreatePublisher()
        {
            try
            {
                _loggerWindows.LogInformation("Create SyncMPlusOrderQueue Publisher.");
                List<IQueuePublisher<SyncOrderMplusToFFQueueModel>> queuePublishers = new List<IQueuePublisher<SyncOrderMplusToFFQueueModel>>();
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

                        queuePublishers.Add(QueueEngineFactory.CreatePublisher<SyncOrderMplusToFFQueueModel>(provider, amazonSetting, ""));
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
