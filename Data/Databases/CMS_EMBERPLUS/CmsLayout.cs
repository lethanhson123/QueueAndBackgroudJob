namespace Data.Databases.CMS_EMBERPLUS;

public partial class CmsLayout : BaseModel
{
    public string Id { get; set; } = null!;

    public string? LayoutName { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? Script { get; set; }

    public string? Style { get; set; }

    public string? ImageUrl { get; set; }

    public string? ImageThumbUrl { get; set; }

    public string? CreateBy { get; set; }

    public string? CreatebyName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public int? Status { get; set; }

    public int? CompanyId { get; set; }
}
