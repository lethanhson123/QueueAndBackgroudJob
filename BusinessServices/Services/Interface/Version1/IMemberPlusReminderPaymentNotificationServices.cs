namespace BusinessServices.Services.Interface.Version1
{
    public interface IMemberPlusReminderPaymentNotificationServices
    {
        public Task<List<MemberPlusReminderPaymentNotificationQueueModel>> PublishAsync();
        public Task<Dictionary<string, object>> SubcriberAsync(MemberPlusReminderPaymentNotificationQueueModel data);
    }
}
