namespace BusinessServices.Services.Interface
{
    public interface ISignalRServices
    {
        IEnumerable<SiteStoreInfo> GetSiteStores();
        long GetTPFOrderNumber(string poNumber);
        bool AddOrderTrackingExtent(IEnumerable<OrderSyncTrackingSignalR> orders);
        long CreateOrderForWLB(SyncOrderRepo syncOrder, SiteStoreInfo storeInfo, bool isTesting, out List<string> errorNotifications);
        OrderStatusTracking GetOrderStatusTracking(string poNumber);
    }
}
