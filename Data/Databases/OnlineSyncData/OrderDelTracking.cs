namespace Data.Databases.OnlineSyncData;

public partial class OrderDelTracking : BaseModel
{
    public long Id { get; set; }

    public long RefNo { get; set; }

    public string TrackingNo { get; set; } = null!;

    public string CarrierName { get; set; } = null!;

    public string CarrierUrl { get; set; } = null!;

    public long Ocid { get; set; }

    public string PoNumber { get; set; } = null!;

    public DateTime ProcessedDate { get; set; }

    public int? Whid { get; set; }

    public bool? IsSent { get; set; }

    public DateTime? SentDate { get; set; }

    public int Status { get; set; }

    public DateTime CreatedDate { get; set; }
}

