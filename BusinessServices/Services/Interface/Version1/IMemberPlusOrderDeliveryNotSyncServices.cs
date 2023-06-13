namespace BusinessServices.Services.Interface.Version1
{
    public interface IMemberPlusOrderDeliveryNotSyncServices
	{
		public Task<List<MemberPlusOrderDeliveryNotSyncQueueModel>> PublishAsync();
		public Task<Dictionary<string, object>> SubcriberAsync(MemberPlusOrderDeliveryNotSyncQueueModel data);

	}
}
