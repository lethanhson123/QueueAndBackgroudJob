using PublishNotSyncOrderMberToFF.DeliveryActions;
using Utilities;

namespace PublishNotSyncOrderMberToFF
{
    public class PublishNotSyncOrderMberToFFWorker : BackgroundService
    {
        private readonly NotSyncOrderYet _notSyncOrderYet;
        private readonly ILogger<PublishNotSyncOrderMberToFFWorker> _loggerWindows;

        public PublishNotSyncOrderMberToFFWorker(
            NotSyncOrderYet notSyncOrderYet,
            ILogger<PublishNotSyncOrderMberToFFWorker> loggerWindows)
        {
            _notSyncOrderYet = notSyncOrderYet;
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
                        _loggerWindows.LogWarning("Begin _notSyncOrderYet.SendToSQS()");
                        await _notSyncOrderYet.SendToSQS();

                        await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
                    }
                    else
                    {
                        var currentTime = DateTime.Now;
                        if (currentTime.Hour == AppSettingsConstant.Application.RunHour
                            && currentTime.Minute == AppSettingsConstant.Application.RunMinute
                            && currentTime.Second == 0 && currentTime.Millisecond == 0)
                        {
                            _loggerWindows.LogWarning("Begin _notSyncOrderYet.SendToSQS()");
                            _notSyncOrderYet.SendToSQS();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _loggerWindows.LogError(ex, "{Message}", ex.Message);

                // Terminates this process and returns an exit code to the operating system.
                // This is required to avoid the 'BackgroundServiceExceptionBehavior', which
                // performs one of two scenarios:
                // 1. When set to "Ignore": will do nothing at all, errors cause zombie services.
                // 2. When set to "StopHost": will cleanly stop the host, and log errors.
                //
                // In order for the Windows Service Management system to leverage configured
                // recovery options, we need to terminate the process with a non-zero exit code.
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