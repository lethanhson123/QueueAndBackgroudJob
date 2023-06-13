namespace Data.Databases.CMS_EMBERPLUS;

public partial class ImpMappingSetting : BaseModel
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

    public string TableGroup { get; set; } = null!;

    public int? Order { get; set; }

    public string? DbcolumnName { get; set; }

    public string? DataType { get; set; }

    public string? Len { get; set; }

    public string? Prefix { get; set; }

    public string? ExcelColumnName { get; set; }

    public int? TemplateId { get; set; }
}

