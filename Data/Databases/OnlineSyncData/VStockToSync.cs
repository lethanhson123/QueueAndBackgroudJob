namespace Data.Databases.OnlineSyncData;

public partial class VStockToSync : BaseModel
{
    public long Id { get; set; }

    public string InternalCode { get; set; } = null!;

    public string ExternalCode { get; set; } = null!;

    public long ProdetailId { get; set; }

    public int StoreId { get; set; }

    public int SyncStatus { get; set; }

    public int StoreType { get; set; }

    public DateTime? LastSyncDate { get; set; }
}

