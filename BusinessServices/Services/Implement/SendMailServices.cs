using BusinessServices.Constants;
using BusinessServices.Models.MessageQueueModel;
using BusinessServices.Services.Interface;
using System.Net;
using System.Net.Mail;
using Utilities;

namespace BusinessServices.Services.Implement
{
    public partial class SendMailServices : ISendMailServices
    {
        public SendMailServices()
        {
        }

        #region Publisher
        public async Task<List<SendMailQueueModel>> loadDemoData()
        {
            List<SendMailQueueModel> inQueueItems = new List<SendMailQueueModel>();
            for (int i = 1; i <= 10; i++)
            {
                SendMailModel tempNew = new SendMailModel();
                tempNew.From = AppSettingsConstant.Application.Emails["DefaultFrom"];
                tempNew.To = AppSettingsConstant.Application.Emails["DefaultTo"];
                tempNew.Subject = AppSettingsConstant.Application.Name + " - Demo auto up to AWS SQS " + i;
                tempNew.Body = "BODY: Demo auto up to AWS SQS " + i;

                SendMailQueueModel tempSendMailQueueModel = new SendMailQueueModel();
                tempSendMailQueueModel.create = DateTime.UtcNow;
                tempSendMailQueueModel.action = ActionTypes.SEND_MAIL_DELIVERY.ToString().ToUpper();
                tempSendMailQueueModel.status = ActionStatus.NEW.ToString().ToUpper();
                tempSendMailQueueModel.mailModel = tempNew;

                inQueueItems.Add(tempSendMailQueueModel);
            }

            return inQueueItems;
        }
        #endregion

        #region Subscriber
        public Dictionary<string, object> sendMail(SendMailQueueModel data)
        {
            Dictionary<string, object> rs = new Dictionary<string, object>();

            string to = data.mailModel.To;
            string from = data.mailModel.From;
            string smtpUsername = AppSettingsConstant.Config.Email.UserName;
            string smtpPassword = AppSettingsConstant.Config.Email.Password;
            string smtpHost = AppSettingsConstant.Config.Email.Host;
            int smtpPort = AppSettingsConstant.Config.Email.Port;
            string subject = AppSettingsConstant.Application.Name + " - " + data.mailModel.Subject;
            string bodySMTP = data.mailModel.Body;

            MailMessage message = new MailMessage(from, to, subject, bodySMTP);
            message.IsBodyHtml = true;

            using (var client = new SmtpClient(smtpHost, smtpPort))
            {
                client.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
                client.EnableSsl = true;

                client.Send(message);
            }

            rs["c"] = ConstantCode.SUCCESSFULL;
            rs["m"] = ConstantMessage.SUCCESSFULL;
            return rs;
        }
        public async Task<bool> SendMailAsync(string mailFrom, string[] mailToList, string subject, string body)
        {
            bool result = false;
            try
            {
                string mailTo = string.Join(",", mailToList);
                string smtpUsername = AppSettingsConstant.Config.Email.UserName;
                string smtpPassword = AppSettingsConstant.Config.Email.Password;
                string smtpHost = AppSettingsConstant.Config.Email.Host;
                int smtpPort = AppSettingsConstant.Config.Email.Port;

                MailMessage message = new MailMessage(mailFrom, mailTo, subject, body);
                message.IsBodyHtml = true;

                using (var client = new SmtpClient(smtpHost, smtpPort))
                {
                    client.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
                    client.EnableSsl = true;

                    await client.SendMailAsync(message);
                }
                result = true;
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            return result;
        }
        #endregion
    }
}
