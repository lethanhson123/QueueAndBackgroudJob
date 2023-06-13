namespace Data.Databases.Tpfsystem;

public partial class VSyncStockHistory : BaseModel
{
    public long Id { get; set; }

    public long TransactionId { get; set; }

    public string? InternalCode { get; set; }

    public long? InternalId { get; set; }

    public long ProdetailId { get; set; }

    public int? Whid { get; set; }

    public int Available { get; set; }

    public string Status { get; set; } = null!;

    public bool IsGlobal { get; set; }

    public string? RawData { get; set; }

    public string? Reason { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? FinishedDate { get; set; }
}

