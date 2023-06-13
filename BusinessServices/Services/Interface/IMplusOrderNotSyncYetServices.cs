using BusinessServices.Models.MessageQueueModel;

namespace BusinessServices.Services.Interface
{
    public interface IMplusOrderNotSyncYetServices
    {
        Task<List<SyncOrderMplusToFFQueueModel>> LoadUnSyncOrderFromMPlus();
        Dictionary<string, object> subcriberSyncOrder(SyncOrderMplusToFFQueueModel data);
    }
}
