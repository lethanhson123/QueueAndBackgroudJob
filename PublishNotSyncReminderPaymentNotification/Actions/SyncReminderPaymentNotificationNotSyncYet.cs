

namespace PublishNotSyncReminderPaymentNotification.Actions
{
    public class SyncReminderPaymentNotificationNotSyncYet
	{
		private readonly ILogger<PublishNotSyncReminderPaymentNotificationWorker> _loggerWindows;
		private readonly List<IQueuePublisher<MemberPlusReminderPaymentNotificationQueueModel>> _publishers;
		private readonly IMemberPlusReminderPaymentNotificationServices _memberPlusReminderPaymentNotificationServices;
		public SyncReminderPaymentNotificationNotSyncYet(ILogger<PublishNotSyncReminderPaymentNotificationWorker> loggerWindows
			, IMemberPlusReminderPaymentNotificationServices memberPlusReminderPaymentNotificationServices
		   )
		{
			_loggerWindows = loggerWindows;
			_publishers = CreatePublisher();
			_memberPlusReminderPaymentNotificationServices = memberPlusReminderPaymentNotificationServices;
		}
		public async void SendToSQS()
		{
			try
			{
				var inQueueItems = await _memberPlusReminderPaymentNotificationServices.PublishAsync();
				_loggerWindows.LogWarning("Load {inQueueItems} MemberPlusReminderPaymentNotificationQueueModel(s) successful!!!", inQueueItems.Count);

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

		private List<IQueuePublisher<MemberPlusReminderPaymentNotificationQueueModel>> CreatePublisher()
		{
			try
			{
				_loggerWindows.LogInformation("Create Sync MemberPlusReminderPaymentNotificationQueueModel Publisher.");
				List<IQueuePublisher<MemberPlusReminderPaymentNotificationQueueModel>> queuePublishers = new List<IQueuePublisher<MemberPlusReminderPaymentNotificationQueueModel>>();
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

						queuePublishers.Add(QueueEngineFactory.CreatePublisher<MemberPlusReminderPaymentNotificationQueueModel>(provider, amazonSetting, ""));
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
