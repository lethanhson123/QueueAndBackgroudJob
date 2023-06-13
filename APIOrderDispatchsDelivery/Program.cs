using APIOrderDispatchsDelivery;
using BusinessServices;
using Microsoft.Extensions.Logging.Configuration;
using Microsoft.Extensions.Logging.EventLog;
using Utilities;
using Utilities.Helpers;

ProgramHelper.Init();
IHost host = Host.CreateDefaultBuilder(args)
    .UseWindowsService(options =>
    {
        options.ServiceName = AppSettingsConstant.Application.Name.ToString();
    })
    .ConfigureServices(services =>
    {
        LoggerProviderOptions.RegisterProviderOptions<EventLogSettings, EventLogLoggerProvider>(services);

        services.AddBusinessService();
        services.AddHostedService<APIOrderDispatchsDeliveryWorker>();
    })
    .ConfigureLogging((context, logging) =>
    {
        // See: https://github.com/dotnet/runtime/issues/47303
        logging.AddConfiguration(
            context.Configuration.GetSection("Logging"));
    })
    .UseDefaultServiceProvider(options => options.ValidateScopes = false)
    .Build();

await host.RunAsync();
