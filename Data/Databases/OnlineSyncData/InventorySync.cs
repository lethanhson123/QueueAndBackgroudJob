namespace Data.Databases.OnlineSyncData;

public partial class InventorySync : BaseModel
{
    public long Id { get; set; }

    public string InternalCode { get; set; } = null!;

    public string ExternalCode { get; set; } = null!;

    public long ProdetailId { get; set; }

    public int StoreId { get; set; }

    /// <summary>
    /// 0 - Pending
    /// 1 - Synced 
    /// 2 - Warning
    /// 3 - Error
    /// 4 - Apply
    /// 5 - NA
    /// 6 - Testing
    /// 7 - Processing
    /// 8 - Sent
    /// </summary>
    public int SyncStatus { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public DateTime? LastSyncDate { get; set; }
}

