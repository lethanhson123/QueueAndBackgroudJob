namespace Data.Databases.OnlineSyncData;

public partial class VStockSyncLog : BaseModel
{
    public long Id { get; set; }

    public string InternalCode { get; set; } = null!;

    public long StockId { get; set; }

    public string? LogContent { get; set; }

    public string LogType { get; set; } = null!;

    public DateTime CreatedDate { get; set; }
}

