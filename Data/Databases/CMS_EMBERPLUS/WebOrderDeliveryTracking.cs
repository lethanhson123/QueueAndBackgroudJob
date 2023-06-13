namespace Data.Databases.CMS_EMBERPLUS;

public partial class WebOrderDeliveryTracking : BaseModel
{
    public long Id { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public int? Status { get; set; }

    public string? CreateBy { get; set; }

    public string? CreatebyName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public long? OrderId { get; set; }

    public long? OcDelId { get; set; }

    public string? TrackingNo { get; set; }

    public string? CarrierName { get; set; }

    public string? CarrierUrl { get; set; }

    public DateTime? ProcessedDate { get; set; }

    public int? WhId { get; set; }

    public bool? IsSendMail { get; set; }

    public int? CompanyId { get; set; }
}

