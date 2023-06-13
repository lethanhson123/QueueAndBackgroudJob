namespace PublishOrderDeliveryNotSync.Actions
{
    public class SyncOrderDeliveryNotSyncYet
	{
		private readonly ILogger<PublishOrderDeliveryNotSyncWorker> _loggerWindows;
		private readonly List<IQueuePublisher<MemberPlusOrderDeliveryNotSyncQueueModel>> _publishers;
		private readonly IMemberPlusOrderDeliveryNotSyncServices _memberPlusOrderDeliveryServices;

		public SyncOrderDeliveryNotSyncYet(ILogger<PublishOrderDeliveryNotSyncWorker> loggerWindows
			, IMemberPlusOrderDeliveryNotSyncServices memberPlusOrderDeliveryServices
		   )
		{
			_loggerWindows = loggerWindows;
			_publishers = CreatePublisher();
			_memberPlusOrderDeliveryServices = memberPlusOrderDeliveryServices;
		}
		public async void SendToSQS()
		{
			try
			{
				var inQueueItems = await _memberPlusOrderDeliveryServices.PublishAsync();
				_loggerWindows.LogWarning("Load {inQueueItems} MemberPlusOrderDeliveryNotSyncQueueModel(s) successful!!!", inQueueItems.Count);

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

		private List<IQueuePublisher<MemberPlusOrderDeliveryNotSyncQueueModel>> CreatePublisher()
		{
			try
			{
				_loggerWindows.LogInformation("Create Sync MemberPlusOrderDeliveryNotSyncQueueModel Publisher.");
				List<IQueuePublisher<MemberPlusOrderDeliveryNotSyncQueueModel>> queuePublishers = new List<IQueuePublisher<MemberPlusOrderDeliveryNotSyncQueueModel>>();
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

						queuePublishers.Add(QueueEngineFactory.CreatePublisher<MemberPlusOrderDeliveryNotSyncQueueModel>(provider, amazonSetting, ""));
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
