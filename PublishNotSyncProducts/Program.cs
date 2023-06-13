

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
        services.AddContextsService();
		services.AddRepositoriesService();


		if (AppSettingsConstant.Application.Services["awsSQS"]["Enabled"] == "true")
        {
            services.AddSingleton<SyncProductNotSyncYet>();

            if (AppSettingsConstant.Application.Services["awsSQS"]["EnablePublisher"] == "true")
            {
                services.AddHostedService<PublishNotSyncProductsWorker>();
            }
        }
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
