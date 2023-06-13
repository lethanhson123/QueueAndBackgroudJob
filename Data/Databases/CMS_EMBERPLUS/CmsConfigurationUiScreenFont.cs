namespace Data.Databases.CMS_EMBERPLUS;

public partial class CmsConfigurationUiScreenFont : BaseModel
{
    public string Id { get; set; } = null!;

    public int? CompanyId { get; set; }

    public string? Generated { get; set; }

    public string? Name { get; set; }

    public string? Value { get; set; }

    public string? Createby { get; set; }

    public string? CreateByName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? ConfigId { get; set; }

    public string? FileUrl { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public int? Status { get; set; }

    public int Type { get; set; }
}
