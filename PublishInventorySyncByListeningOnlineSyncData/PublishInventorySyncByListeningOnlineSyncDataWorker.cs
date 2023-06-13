

using System.Data.SqlTypes;

namespace PublishInventorySyncByListeningOnlineSyncData
{
	public class PublishInventorySyncByListeningOnlineSyncDataWorker : BackgroundService
	{
		private readonly ILogger<PublishInventorySyncByListeningOnlineSyncDataWorker> _loggerWindows;
		private readonly SyncInventorySyncByListeningOnlineSyncData _syncInventorySyncByListeningOnlineSyncData;

		public string connectionString = @"";
		public delegate void EventListening();
		public event EventListening EventListeningReal;
		public PublishInventorySyncByListeningOnlineSyncDataWorker(ILogger<PublishInventorySyncByListeningOnlineSyncDataWorker> loggerWindows
			, SyncInventorySyncByListeningOnlineSyncData syncInventorySyncByListeningOnlineSyncData
			)
		{
			_loggerWindows = loggerWindows;
			_syncInventorySyncByListeningOnlineSyncData = syncInventorySyncByListeningOnlineSyncData;
			if (AppSettingsConstant.ENV.Equals("PROD"))
			{
				connectionString = AppSettingsConstant.Config.Dbs.ConnectionString["10.0.2.44"]["OnlineSyncDataDatabase"].DecodeFrom64();
			}
			else
			{
				connectionString = AppSettingsConstant.Config.Dbs.ConnectionString["10.0.2.44"]["OnlineSyncDataDatabase"];
			}
			SqlDependency.Stop(connectionString);
			SqlDependency.Start(connectionString);
		}

		protected override async Task ExecuteAsync(CancellationToken stoppingToken)
		{
			try
			{
				EventListeningReal += new EventListening(EventListeningRealInitialization);
				await LoadDataAsync();
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
		private async Task<int> LoadDataAsync()
		{
			using (var connection = new SqlConnection(connectionString))
			{
				if (connection.State == ConnectionState.Closed)
				{
					await connection.OpenAsync();
				}
				string sql = "SELECT [ID], [InternalCode], [ProdetailID], [StoreID], [SyncStatus] FROM [dbo].[InventorySync] WHERE [SyncStatus]=0";
				using (var command = new SqlCommand(sql, connection))
				{
					command.Notification = null;
					SqlDependency sqlDependency = new SqlDependency(command);
					sqlDependency.OnChange += new OnChangeEventHandler(SqlDependency_OnChange);
					await command.ExecuteReaderAsync(CommandBehavior.CloseConnection);				
				}
			}
			return 0;
		}
		private void SqlDependency_OnChange(object sender, SqlNotificationEventArgs e)
		{
			SqlDependency sqlDependency = sender as SqlDependency;
			sqlDependency.OnChange -= SqlDependency_OnChange;

			if (e.Type == SqlNotificationType.Change)
			{
				_loggerWindows.LogInformation("SQL: {time}", DateTimeOffset.Now);
			}
			if (EventListeningReal != null)
			{
				EventListeningReal();
			}
		}
		private void EventListeningRealInitialization()
		{
			LoadDataAsync();
		}
	}
}
