using System;

namespace BusinessServices.Models.MessageQueueModel
{
    public class SendMailQueueModel : CommonModel
    {
        public SendMailModel mailModel { get; set; }
    }
    public class SendMailModel
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}