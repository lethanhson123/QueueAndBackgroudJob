using System.Collections.Generic;

namespace dotnet.core.lib.utils.Models.Settings.AWS
{
    public class BaseAWSSetting
    {
        public string DocumentDbCert { get; set; }
        public List<BaseAWSBucket> Buckets { get; set; }
        public List<BaseAWSAccount> Accounts { get; set; }
        public List<BaseCloudfrontSetting> Cloudfront { get; set; }
    }
}
