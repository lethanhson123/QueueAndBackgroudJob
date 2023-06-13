using System.Collections.Generic;

namespace Utilities.Models.Settings.Base
{
    public class BaseApplication
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Version { get; set; }
        public string Environment { get; set; }
        public string Hostname { get; set; }
        public bool AlwayRunSchedule { get; set; }
        public int RunHour { get; set; }
        public int RunMinute { get; set; }
        public Dictionary<string,string> Emails { get; set; }
        public Dictionary<string, Dictionary<string, string>> Services { get; set; }
        public Dictionary<string, string> ApiSyncOrder { get; set; }

        // Schedule call api SignalR
        public string ApiUrl { get; set; }
        public string ApiSecToken { get; set; }
        public int DelayHour { get; set; }

        public BaseApplication()
        {
            Name = string.Empty;
            Description = string.Empty;
            Version = string.Empty;
            Environment = string.Empty;
            Hostname = string.Empty;
            AlwayRunSchedule = false;
            RunHour = 0;
            RunMinute = 0;
            Emails = new Dictionary<string, string>();
            Services = new Dictionary<string, Dictionary<string, string>>();
            ApiSyncOrder = new Dictionary<string, string>();
            ApiUrl = string.Empty;
            ApiSecToken = string.Empty;
            DelayHour = 0;
        }
    }
}
