namespace Data.Databases.CMS_EMBERPLUS;

public partial class CmsPage : BaseModel
{
    public string Id { get; set; } = null!;

    public string? ReferencePageId { get; set; }

    public string? ParentId { get; set; }

    public string? LayoutId { get; set; }

    public string? PageName { get; set; }

    public bool IsHomePage { get; set; }

    public string? Url { get; set; }

    public string? Title { get; set; }

    public int? DisplayOrder { get; set; }

    public string? Description { get; set; }

    public int? Status { get; set; }

    public string? MetaKeyWords { get; set; }

    public string? MetaDescription { get; set; }

    public string? Script { get; set; }

    public string? Style { get; set; }

    public string? CreateBy { get; set; }

    public string? CreatebyName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? Theme { get; set; }

    public int? CompanyId { get; set; }
}
