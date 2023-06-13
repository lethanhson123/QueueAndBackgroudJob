namespace PublishDeliveryNotDispatch.Actions
{
	public class SyncOrderDeliveryNotDispatch
	{
		private readonly ILogger<PublishOrderDeliveryNotDispatchWorker> _loggerWindows;
		private readonly List<IQueuePublisher<MemberPlusOrderDeliveryNotDispatchQueueModel>> _publishers;
		private readonly IMemberPlusOrderDeliveryNotDispatchServices _memberPlusOrderDeliveryNotDispatchServices;

		public SyncOrderDeliveryNotDispatch(ILogger<PublishOrderDeliveryNotDispatchWorker> loggerWindows
			, IMemberPlusOrderDeliveryNotDispatchServices memberPlusOrderDeliveryNotDispatchServices
		   )
		{
			_loggerWindows = loggerWindows;
			_publishers = CreatePublisher();
			_memberPlusOrderDeliveryNotDispatchServices = memberPlusOrderDeliveryNotDispatchServices;
		}
		public async void SendToSQS()
		{
			try
			{
				var inQueueItems = await _memberPlusOrderDeliveryNotDispatchServices.PublishAsync();
				_loggerWindows.LogWarning("Load {inQueueItems} MemberPlusOrderDeliveryNotDispatchQueueModel(s) successful!!!", inQueueItems.Count);

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
