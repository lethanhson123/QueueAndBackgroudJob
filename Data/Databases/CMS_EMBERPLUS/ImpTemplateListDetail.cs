namespace Data.Databases.CMS_EMBERPLUS;

public partial class ImpTemplateListDetail : BaseModel
{
    public long IdDetail { get; set; }

    public long IdTemplateList { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? Createby { get; set; }

    public string? CreateByName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string ExcelColumnName { get; set; } = null!;

    public string DbcolumnName { get; set; } = null!;

    public string? ApiColumnName { get; set; }

    public string DataType { get; set; } = null!;

    public int? Status { get; set; }

    public int? DisplayOrder { get; set; }

    public bool? IsRequired { get; set; }

    public string? RegexRule { get; set; }

    public virtual ImpTemplateList IdTemplateListNavigation { get; set; } = null!;
}

