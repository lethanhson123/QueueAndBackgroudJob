namespace Data.Databases.OnlineSyncData;

public partial class VOrderSyncTracking : BaseModel
{
    public long Id { get; set; }

    public string DelStatus { get; set; } = null!;

    public string? OrderStatus { get; set; }

    public string? PoNumber { get; set; }

    public int StoreId { get; set; }

    public long? TpfOrderId { get; set; }

    public int SyncStatus { get; set; }

    public int PendingDuration { get; set; }

    public DateTime? LastSyncDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public DateTime CreatedDate { get; set; }

    public string Status { get; set; } = null!;
}

