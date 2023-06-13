using System.Collections.Generic;

namespace dotnet.core.lib.utils.Models.Settings.AWS
{
    public class BaseAWSAccount
    {
        public string IAM { get; set; }
        public string RegionEndpoint { get; set; }
        //public Dictionary<string, string> Buckets { get; set; }
    }
}
