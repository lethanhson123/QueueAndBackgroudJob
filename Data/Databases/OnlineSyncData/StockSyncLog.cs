namespace Data.Databases.OnlineSyncData;

public partial class StockSyncLog : BaseModel
{
    public long Id { get; set; }

    public long StockId { get; set; }

    public string InternalCode { get; set; } = null!;

    public int StoreId { get; set; }

    public string? LogContent { get; set; }

    public string LogType { get; set; } = null!;

    public DateTime CreatedDate { get; set; }
}

