using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace PublishDeliveryNotDispatch
{
	public class PublishOrderDeliveryNotDispatchWorker : BackgroundService
	{
		private readonly ILogger<PublishOrderDeliveryNotDispatchWorker> _loggerWindows;
		private readonly SyncOrderDeliveryNotDispatch _syncOrderDeliveryNotDispatch;
		public PublishOrderDeliveryNotDispatchWorker(ILogger<PublishOrderDeliveryNotDispatchWorker> loggerWindows
			, SyncOrderDeliveryNotDispatch syncOrderDeliveryNotDispatch
			)
		{
			_loggerWindows = loggerWindows;
			_syncOrderDeliveryNotDispatch = syncOrderDeliveryNotDispatch;
		}

		protected override async Task ExecuteAsync(CancellationToken stoppingToken)
		{
			try
			{
				while (!stoppingToken.IsCancellationRequested)
				{
					if (AppSettingsConstant.Application.AlwayRunSchedule)
					{
						await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
					}
					else
					{
						var currentTime = DateTime.Now;

						if (currentTime.Hour == AppSettingsConstant.Application.RunHour
							&& currentTime.Minute == AppSettingsConstant.Application.RunMinute
							&& currentTime.Second == 0 && currentTime.Millisecond == 0)
						{
							_loggerWindows.LogWarning("Begin _syncOrderDeliveryNotDispatch.SendToSQS()");
							_syncOrderDeliveryNotDispatch.SendToSQS();
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