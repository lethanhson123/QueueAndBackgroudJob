namespace Data.Databases.CMS_EMBERPLUS;
public partial class ImpMappingSettingHistory : BaseModel
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

    public long? MappingId { get; set; }

    public string? Prefix { get; set; }

    public string? ExcelColumnName { get; set; }

    public int? TemplateId { get; set; }

    public int? CompanyId { get; set; }
}

