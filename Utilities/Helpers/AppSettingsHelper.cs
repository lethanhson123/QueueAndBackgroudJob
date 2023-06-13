using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace Utilities.Helpers
{
    public class AppSettingsHelper
    {
        private static string ConfFile { get; set; }
        public static IConfigurationRoot GetAppSettings(string filename)
        {
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);

            var appsettings = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(filename, optional: false)
                .Build();
            ConfFile = appsettings.GetSection("ConfigFile").Value;
            return appsettings;
        }
        public static IConfigurationRoot BuildSettings(string filename)
        {
            var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile(filename, optional: false).Build();
            return config;
        }
        public static IConfigurationRoot BuildApplicationSettings()
        {
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);

            if (StringHelper.IsNull(ConfFile)) 
            { 
                ConfFile = "Settings/dev.json"; 
            }
            var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile(ConfFile, optional: false).Build();
            return config;
        }
    }
}
