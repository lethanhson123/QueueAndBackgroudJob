namespace BusinessServices.Services.Interface.Version1
{
    public interface IMemberPlusProductNotSyncYetServices
    {
        public Task<List<MemberPlusProductNotSyncYetQueueModel>> PublishAsync();
        public Task<Dictionary<string, object>> SubcriberAsync(MemberPlusProductNotSyncYetQueueModel data);
    }
}
