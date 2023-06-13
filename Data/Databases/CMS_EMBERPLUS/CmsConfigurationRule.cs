namespace Data.Databases.CMS_EMBERPLUS;

public partial class CmsConfigurationRule : BaseModel
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public int Status { get; set; }

    public string? CreateBy { get; set; }

    public string? CreatebyName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? Description { get; set; }

    public int? CompanyId { get; set; }

    public int? ConfigId { get; set; }

    public string? AssemblyName { get; set; }

    public string? Action { get; set; }

    public int? Position { get; set; }

    public string? RuleAction { get; set; }
}
