namespace Data.Databases.OnlineSyncData;

public partial class OrderSyncLog : BaseModel
{
    public long Id { get; set; }

    public long OrderSyncId { get; set; }

    public long TpfOrderId { get; set; }

    public string PoNumber { get; set; } = null!;

    public int StoreId { get; set; }

    public string? LogContent { get; set; }

    public string LogType { get; set; } = null!;

    public DateTime CreatedDate { get; set; }
}

