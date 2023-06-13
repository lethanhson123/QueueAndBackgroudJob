
namespace PublishNotSyncProducts
{
    public class PublishNotSyncProductsWorker : BackgroundService
    {
        private readonly SyncProductNotSyncYet _syncProductNotSyncYet;
        private readonly ILogger<PublishNotSyncProductsWorker> _loggerWindows;

        public PublishNotSyncProductsWorker(
            ILogger<PublishNotSyncProductsWorker> loggerWindows, 
            SyncProductNotSyncYet syncProductNotSyncYet)
        {
			_syncProductNotSyncYet = syncProductNotSyncYet;
            _loggerWindows = loggerWindows;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            try
            {
                while (!stoppingToken.IsCancellationRequested)
                {
                    if (AppSettingsConstant.Application.AlwayRunSchedule)
                    {
                        _loggerWindows.LogWarning("Begin _syncProductNotSyncYet.SendToSQS()");
						_syncProductNotSyncYet.SendToSQS();

                        await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
                    }
                    else
                    {
                        var currentTime = DateTime.Now;
                        if (currentTime.Hour == AppSettingsConstant.Application.RunHour
                            && currentTime.Minute == AppSettingsConstant.Application.RunMinute
                            && currentTime.Second == 0 && currentTime.Millisecond == 0)
                        {
                            _loggerWindows.LogWarning("Begin _syncProductNotSyncYet.SendToSQS()");
							_syncProductNotSyncYet.SendToSQS();
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