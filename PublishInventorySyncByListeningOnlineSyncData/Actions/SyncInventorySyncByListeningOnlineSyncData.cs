namespace PublishInventorySyncByListeningOnlineSyncData.Actions
{
	public class SyncInventorySyncByListeningOnlineSyncData
	{
		private readonly ILogger<PublishInventorySyncByListeningOnlineSyncDataWorker> _loggerWindows;
		private readonly List<IQueuePublisher<MemberPlusOrderDeliveryNotDispatchQueueModel>> _publishers;


		public SyncInventorySyncByListeningOnlineSyncData(ILogger<PublishInventorySyncByListeningOnlineSyncDataWorker> loggerWindows
			, IMemberPlusOrderDeliveryNotDispatchServices memberPlusOrderDeliveryNotDispatchServices
		   )
		{
			_loggerWindows = loggerWindows;
			_publishers = CreatePublisher();

		}
		public async void SendToSQS()
		{
			try
			{				
			}
			catch (Exception e)
			{
				_loggerWindows.LogError(e, "{Message}", e.Message);
				Console.WriteLine(e.Message);
			}
		}

		private List<IQueuePublisher<MemberPlusOrderDeliveryNotDispatchQueueModel>> CreatePublisher()
		{
			try
			{
				_loggerWindows.LogInformation("Create Sync MemberPlusOrderDeliveryNotDispatchQueueModel Publisher.");
				List<IQueuePublisher<MemberPlusOrderDeliveryNotDispatchQueueModel>> queuePublishers = new List<IQueuePublisher<MemberPlusOrderDeliveryNotDispatchQueueModel>>();
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

						queuePublishers.Add(QueueEngineFactory.CreatePublisher<MemberPlusOrderDeliveryNotDispatchQueueModel>(provider, amazonSetting, ""));
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
