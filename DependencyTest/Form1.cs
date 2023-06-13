using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DependencyTest
{
	public partial class Form1 : Form
	{
		public string m_connect = @"Server=SOHU-LE-PC;Database=BackgroundTask;user id=sa;password=@Sonheo123;MultipleActiveResultSets=True;Encrypt=False;TrustServerCertificate=False;";
		SqlConnection con = null;
		public delegate void NewHome();
		public event NewHome OnNewHome;
		public Form1()
		{
			InitializeComponent();
			SqlDependency.Stop(m_connect);
			SqlDependency.Start(m_connect);
			con = new SqlConnection(m_connect);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			OnNewHome += new NewHome(Form1_OnNewHome);//tab
													  //load data vao datagrid
			LoadData();
		}
		public void Form1_OnNewHome()
		{
			ISynchronizeInvoke i = (ISynchronizeInvoke)this;
			if (i.InvokeRequired)//tab
			{
				NewHome dd = new NewHome(Form1_OnNewHome);
				i.BeginInvoke(dd, null);
				return;
			}
			LoadData();

		}
		void LoadData()
		{
			DataTable dt = new DataTable();
			if (con.State == ConnectionState.Closed)
			{
				con.Open();
			}

			SqlCommand cmd = new SqlCommand("select [ID], [Action] from [dbo].[PushQueue]", con);
			cmd.Notification = null;

			SqlDependency de = new SqlDependency(cmd);
			de.OnChange += new OnChangeEventHandler(de_OnChange);

			cmd.ExecuteReader(CommandBehavior.CloseConnection);
			listBox1.Items.Add("SQL: " + DateTime.Now);
		}
		public void de_OnChange(object sender, SqlNotificationEventArgs e)
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