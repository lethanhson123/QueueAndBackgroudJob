namespace Data.Databases.CMS_EMBERPLUS;

public partial class WhOcDeliveryDetail : BaseModel
{
    public long Id { get; set; }

    public long OcDelId { get; set; }

    public long OcDetailId { get; set; }

    public long ProdetailId { get; set; }

    public string ProName { get; set; } = null!;

    public int DelQty { get; set; }

    public int SentQty { get; set; }

    public int? CompanyId { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    /// <summary>
    /// 1: New, 2:Partly, 3: Fully
    /// </summary>
    public int? Status { get; set; }

    public string? CreateBy { get; set; }

    public string? CreatebyName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? PrintName { get; set; }

    public string? PrintImage { get; set; }

    public string? ProCode { get; set; }

    public string? RawData { get; set; }
}

