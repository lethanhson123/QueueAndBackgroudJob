namespace Data.Databases.CMS_EMBERPLUS;

public partial class CmsConfigurationUiScreenElement : BaseModel
{
    public string Id { get; set; } = null!;

    public int? CompanyId { get; set; }

    public string? Element { get; set; }

    public int? Size { get; set; }

    public string? Style { get; set; }

    public int? Weight { get; set; }

    public string? Color { get; set; }

    public string? Background { get; set; }

    public string? BackgroundHover { get; set; }

    public string? Createby { get; set; }

    public string? CreateByName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? ConfigId { get; set; }

    public string? FontName { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public int? Status { get; set; }    
}
