namespace PublishNotSyncReminderPaymentNotification
{
	public class PublishNotSyncReminderPaymentNotificationWorker : BackgroundService
	{
		private readonly ILogger<PublishNotSyncReminderPaymentNotificationWorker> _loggerWindows;

		private readonly SyncReminderPaymentNotificationNotSyncYet _syncReminderPaymentNotificationNotSyncYet;

		public PublishNotSyncReminderPaymentNotificationWorker(ILogger<PublishNotSyncReminderPaymentNotificationWorker> loggerWindows
			, SyncReminderPaymentNotificationNotSyncYet syncReminderPaymentNotificationNotSyncYet
			)
		{
			_loggerWindows = loggerWindows;
			_syncReminderPaymentNotificationNotSyncYet = syncReminderPaymentNotificationNotSyncYet;
		}

		protected override async Task ExecuteAsync(CancellationToken stoppingToken)
		{
			try
			{
				while (!stoppingToken.IsCancellationRequested)
				{
					if (AppSettingsConstant.Application.AlwayRunSchedule)
					{
						_loggerWindows.LogWarning("Begin _syncReminderPaymentNotificationNotSyncYet.SendToSQS()");
						_syncReminderPaymentNotificationNotSyncYet.SendToSQS();

						await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
					}
					else
					{
						var currentTime = DateTime.Now;
						if (currentTime.Hour == AppSettingsConstant.Application.RunHour
							&& currentTime.Minute == AppSettingsConstant.Application.RunMinute
							&& currentTime.Second == 0 && currentTime.Millisecond == 0)
						{
							_loggerWindows.LogWarning("Begin _syncReminderPaymentNotificationNotSyncYet.SendToSQS()");
							_syncReminderPaymentNotificationNotSyncYet.SendToSQS();
						}
					}
				}
			}
			catch (Exception ex)
			{
				_loggerWindows.LogError(ex, "{Message}", ex.Message);

				Environment.Exit(1);
			}
		}

		public override Task StartAsync(CancellationToken cancellationToken)
		{
			_loggerWindows.LogWarning(this.GetType().Name + " STARTING: {time}", DateTimeOffset.Now);
			return base.StartAsync(cancellationToken);
		}

		public override Task StopAsync(CancellationToken cancellationToken)
		{
			_loggerWindows.LogCritical(this.GetType().Name + " STOPPING: {time}", DateTimeOffset.Now);
			return base.StopAsync(cancellationToken);
		}
	}
}