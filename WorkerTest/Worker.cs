using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace TestWorker
{
	public class Worker : BackgroundService
	{
		private readonly ILogger<Worker> _logger;
		public string m_connect = @"Server=SOHU-LE-PC;Database=BackgroundTask;user id=sa;password=@Sonheo123;MultipleActiveResultSets=True;Encrypt=False;TrustServerCertificate=False;";
		SqlConnection con = null;
		public delegate void NewHome();
		public event NewHome OnNewHome;
		public Worker(ILogger<Worker> logger)
		{
			_logger = logger;
			SqlDependency.Stop(m_connect);
			SqlDependency.Start(m_connect);
			con = new SqlConnection(m_connect);
		}

		protected override async Task ExecuteAsync(CancellationToken stoppingToken)
		{		
			OnNewHome += new NewHome(Form1_OnNewHome);
			LoadData();
		}
		private void Form1_OnNewHome()
		{		
			LoadData();
		}
		void LoadData()
		{			
			if (con.State == ConnectionState.Closed)
			{
				con.Open();
			}
			SqlCommand cmd = new SqlCommand("select [ID], [Action] from [dbo].[PushQueue]", con);
			cmd.Notification = null;

			SqlDependency de = new SqlDependency(cmd);
			de.OnChange += new OnChangeEventHandler(de_OnChange);

			cmd.ExecuteReader(CommandBehavior.CloseConnection);

			_logger.LogInformation("SQL: {time}", DateTimeOffset.Now);
		}
		private void de_OnChange(object sender, SqlNotificationEventArgs e)
		{
			SqlDependency de = sender as SqlDependency;
			de.OnChange -= de_OnChange;
			if (OnNewHome != null)
			{
				OnNewHome();
			}
		}
	}
}