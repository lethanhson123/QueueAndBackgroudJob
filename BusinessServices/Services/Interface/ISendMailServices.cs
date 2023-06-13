using BusinessServices.Models.MessageQueueModel;

namespace BusinessServices.Services.Interface
{
    public interface ISendMailServices
    {
        Task<List<SendMailQueueModel>> loadDemoData();
        Dictionary<string, object> sendMail(SendMailQueueModel data);
        public Task<bool> SendMailAsync(string from, string[] to, string subject, string body);
    }
}
