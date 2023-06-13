namespace BusinessServices.Services.Interface.Version1
{
    public interface IMemberPlusOrderDeliveryNotDispatchServices
	{
		public Task<List<MemberPlusOrderDeliveryNotDispatchQueueModel>> PublishAsync();
		public Task<Dictionary<string, object>> SubcriberAsync(MemberPlusOrderDeliveryNotDispatchQueueModel data);
	}
}
