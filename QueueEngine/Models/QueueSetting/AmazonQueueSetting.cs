namespace QueueEngine.Models.QueueSetting
{
    public class AmazonQueueSetting: QueueSetting
    {
        public string AccessKey { get; set; }
        public string SecretKey { get; set; }
        public string RegionEndpoint { get; set; }
        public string QueueUrl { get; set; }
    }
}