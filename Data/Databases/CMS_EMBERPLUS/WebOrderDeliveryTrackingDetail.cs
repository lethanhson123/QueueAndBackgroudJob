namespace Data.Databases.CMS_EMBERPLUS;

public partial class WebOrderDeliveryTrackingDetail : BaseModel
{
    public long Id { get; set; }

    public long OcDelTrackingId { get; set; }

    public long DelDetailId { get; set; }

    public long ProdetailId { get; set; }

    public int DelQty { get; set; }

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
}

