using Utilities.Models.Settings.Base;
using Microsoft.Extensions.Configuration;

namespace Utilities.Helpers
{
    public class ProgramHelper
    {
        public static void Init()
        {
            var appSettings = new BaseSetting();
            AppSettingsHelper.GetAppSettings("appsettings.json");
            IConfigurationRoot appjson = AppSettingsHelper.BuildApplicationSettings();
            appjson.Bind(appSettings);
            AppSettingsConstant.Init(appSettings);
        }
    }
}
