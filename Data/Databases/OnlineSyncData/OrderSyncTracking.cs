namespace Data.Databases.OnlineSyncData;

public partial class OrderSyncTracking : BaseModel
{
    public long Id { get; set; }

    public long? TpfOrderId { get; set; }

    public int StoreId { get; set; }

    public string? PoNumber { get; set; }

    public int PendingDuration { get; set; }

    public string? OrderStatus { get; set; }

    public string DelStatus { get; set; } = null!;

    public int SyncStatus { get; set; }

    public int SyncDelStatus { get; set; }

    public int RejectType { get; set; }

    public string? RejectNote { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public DateTime? LastSyncDate { get; set; }

    public Guid? Rguid { get; set; }

    public string? RawData { get; set; }

    public DateTime? ClosedOrderDate { get; set; }

    public string? Notes { get; set; }
}

