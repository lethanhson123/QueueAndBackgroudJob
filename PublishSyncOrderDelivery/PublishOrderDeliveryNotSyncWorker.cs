

namespace PublishOrderDeliveryNotSync
{
	public class PublishOrderDeliveryNotSyncWorker : BackgroundService
	{
		private readonly ILogger<PublishOrderDeliveryNotSyncWorker> _loggerWindows;

		private readonly SyncOrderDeliveryNotSyncYet _syncOrderDeliveryNotSyncYet;

		public PublishOrderDeliveryNotSyncWorker(ILogger<PublishOrderDeliveryNotSyncWorker> loggerWindows
			, SyncOrderDeliveryNotSyncYet syncOrderDeliveryNotSyncYet
			)
		{
			_loggerWindows = loggerWindows;
			_syncOrderDeliveryNotSyncYet = syncOrderDeliveryNotSyncYet;
		}

		protected override async Task ExecuteAsync(CancellationToken stoppingToken)
		{
			try
			{
				while (!stoppingToken.IsCancellationRequested)
				{
					if (AppSettingsConstant.Application.AlwayRunSchedule)
					{
						_loggerWindows.LogWarning("Begin _syncSyncOrderDeliveryNotSyncYet.SendToSQS()");
						_syncOrderDeliveryNotSyncYet.SendToSQS();

						await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
					}
					else
					{
						var currentTime = DateTime.Now;
						if (currentTime.Hour == AppSettingsConstant.Application.RunHour
							&& currentTime.Minute == AppSettingsConstant.Application.RunMinute
							&& currentTime.Second == 0 && currentTime.Millisecond == 0)
						{
							_loggerWindows.LogWarning("Begin _syncSyncOrderDeliveryNotSyncYet.SendToSQS()");
							_syncOrderDeliveryNotSyncYet.SendToSQS();
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