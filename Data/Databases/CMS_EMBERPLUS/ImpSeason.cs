namespace Data.Databases.CMS_EMBERPLUS;

public partial class ImpSeason : BaseModel
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public int? Status { get; set; }

    public long? CompanyId { get; set; }

    public string? ShopName { get; set; }

    public string? CreateBy { get; set; }

    public string? CreatebyName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? Description { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsReset { get; set; }

    public string? SeasonName { get; set; }
}

