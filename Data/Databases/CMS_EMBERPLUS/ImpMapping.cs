namespace Data.Databases.CMS_EMBERPLUS;

public partial class ImpMapping : BaseModel
{
    public int Id { get; set; }

    public long IdTemplateList { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? Createby { get; set; }

    public string? CreateByName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? StoredMapping { get; set; }

    public int? Status { get; set; }

    public virtual ImpTemplateList IdTemplateListNavigation { get; set; } = null!;
}

