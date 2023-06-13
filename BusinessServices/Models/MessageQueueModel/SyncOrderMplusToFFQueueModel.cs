namespace BusinessServices.Models.MessageQueueModel
{
    public class SyncOrderMplusToFFQueueModel : CommonModel
    {
        public MplusOrderNotSyncYetModel item { get; set; }
    }
    public class MplusOrderNotSyncYetModel
    {
        public long WebOrderId { get; set; }
        public int CompanyID { get; set; }
    }

    public class MplusDeliveryNotSyncYetQueueModel : CommonModel
    {
        public MplusDeliveryNotSyncYetModel item { get; set; }
    }
    public class MplusDeliveryNotSyncYetModel
    {
        public long WebOrderId { get; set; }
        public long DeliveryId { get; set; }
        public int CompanyID { get; set; }
    }
}