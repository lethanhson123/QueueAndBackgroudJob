using BusinessServices.Constants;
using BusinessServices.Services.Interface;
using Utilities;

namespace APIOrderDispatchsDelivery
{
    public class APIOrderDispatchsDeliveryWorker : BackgroundService
    {
        private readonly IAPIOrderDispatchsServices _service;
        private readonly ILogger<APIOrderDispatchsDeliveryWorker> _loggerWindows;

        public APIOrderDispatchsDeliveryWorker(
            IAPIOrderDispatchsServices service, 
            ILogger<APIOrderDispatchsDeliveryWorker> logger)
        {
            _service = service;
            _loggerWindows = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            try
            {
                while (!stoppingToken.IsCancellationRequested)
                {
                    _loggerWindows.LogInformation("Run APIOrderDispatchs start at: {time}", DateTimeOffset.Now);
                    Task<Dictionary<string, object>> _re = _service.CallAPIOrderDispatchs();
                    if (_re.Result["c"].ToString() != ConstantCode.SUCCESSFULL.ToString())
                    {
                        _loggerWindows.LogCritical("Run APIOrderDispatchs error: Message={message} . Response={response} . At time: {time}",
                            _re.Result["m"].ToString(), _re.Result["d"].ToString(), DateTimeOffset.Now);
                    }
                    else
                    {
                        _loggerWindows.LogWarning("Run APIOrderDispatchs successfull at time: {time}", DateTimeOffset.Now);
                    }
                    await Task.Delay(TimeSpan.FromHours(AppSettingsConstant.Application.DelayHour), stoppingToken);
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
            _loggerWindows.LogWarning("APIOrderDispatchsDeliveryWorker STARTING: {time}", DateTimeOffset.Now);
            return base.StartAsync(cancellationToken);
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            _loggerWindows.LogCritical("APIOrderDispatchsDeliveryWorker STOPPING: {time}", DateTimeOffset.Now);
            return base.StopAsync(cancellationToken);
        }
    }
}