namespace Data.Databases.CMS_EMBERPLUS;

public partial class ImpOfferTracking : BaseModel
{
    public long Id { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public int? Status { get; set; }

    public string? CreateBy { get; set; }

    public string? CreatebyName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public int CompanyId { get; set; }

    public string? BanerSize { get; set; }

    public bool? Display { get; set; }

    public string? Image { get; set; }

    public string? Ctalink { get; set; }

    public bool? Ctatracking { get; set; }

    public string? TrackingCall { get; set; }

    public int? Click { get; set; }

    public int? Priority { get; set; }
}

