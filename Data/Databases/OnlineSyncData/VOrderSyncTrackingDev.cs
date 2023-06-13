namespace Data.Databases.OnlineSyncData;

public partial class VOrderSyncTrackingDev : BaseModel
{
    public long Id { get; set; }

    public long TpfOrderId { get; set; }

    public int StoreId { get; set; }

    public string PoNumber { get; set; } = null!;

    public string OrderStatus { get; set; } = null!;

    public string DeliveryStatus { get; set; } = null!;

    public int StoreType { get; set; }

    public int CatalogueId { get; set; }

    public int SyncStatus { get; set; }

    public int SyncDelStatus { get; set; }

    public Guid? Rguid { get; set; }

    public string RawData { get; set; } = null!;

    public string Status { get; set; } = null!;
}

