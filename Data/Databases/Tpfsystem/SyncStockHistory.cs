namespace Data.Databases.Tpfsystem;

public partial class SyncStockHistory : BaseModel
{
    public long Id { get; set; }

    public long SyncTransactionId { get; set; }

    public string? InternalCode { get; set; }

    public long? InternalId { get; set; }

    public long ProdetailId { get; set; }

    public int? Whid { get; set; }

    public int Available { get; set; }

    public string Status { get; set; } = null!;

    public bool IsGlobal { get; set; }

    /// <summary>
    /// Raw data from tpf inventory service
    /// </summary>
    public string? RawData { get; set; }

    public string? Reason { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? FinishedDate { get; set; }
}

