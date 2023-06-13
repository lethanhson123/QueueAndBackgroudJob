namespace Data.Databases.CMS_EMBERPLUS;

public partial class CmsEmailSample : BaseModel
{
    public string Id { get; set; } = null!;

    public string? Key { get; set; }

    public string? Template { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public int? Status { get; set; }

    public string CreateBy { get; set; } = null!;

    public string? CreatebyName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public int? CompanyId { get; set; }
}
