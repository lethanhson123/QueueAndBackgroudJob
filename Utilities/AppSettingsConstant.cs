using Utilities.Models.Settings.Base;

namespace Utilities
{

	public static class AppSettingsConstant
	{
		public static void Init(BaseSetting appSettings)
		{
			AppSettings = appSettings;
			Application = appSettings.Application;
			ENV = appSettings.Application.Environment.ToUpper();
			if (AppSettings.Config != null)
			{
				Config = appSettings.Config;
			}
		}
		public static BaseApplication Application { get; set; }
		public static BaseSetting AppSettings { get; set; }
		public static BaseConfig Config { get; set; }
		public static string ENV { get; set; }
	}
}
