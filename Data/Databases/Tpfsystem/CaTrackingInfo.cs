namespace Data.Databases.Tpfsystem;

public partial class CaTrackingInfo : BaseModel
{
    public int Id { get; set; }

    public string TrackingNo { get; set; } = null!;

    public string CarrierName { get; set; } = null!;

    public string CarrierUrl { get; set; } = null!;

    public long Ocid { get; set; }

    /// <summary>
    /// deltranId from Internal System (4000xxx)
    /// </summary>
    public string RefNo { get; set; } = null!;

    public DateTime ProcessDate { get; set; }

    public DateTime CreateDate { get; set; }

    public int? Whid { get; set; }

    public bool? IsSent { get; set; }

    public DateTime? SentDate { get; set; }

    public virtual Orderconf Oc { get; set; } = null!;
}

