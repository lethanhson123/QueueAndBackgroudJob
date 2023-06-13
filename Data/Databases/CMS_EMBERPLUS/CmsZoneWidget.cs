namespace Data.Databases.CMS_EMBERPLUS;

public partial class CmsZoneWidget : BaseModel
{
    public string Id { get; set; } = null!;

    public string? WidgetName { get; set; }

    public string? Title { get; set; }

    public int? Position { get; set; }

    public string? LayoutId { get; set; }

    public string? PageId { get; set; }

    public string? ZoneId { get; set; }

    public string? PartialView { get; set; }

    public string? AssemblyName { get; set; }

    public string? ServiceTypeName { get; set; }

    public string? ViewModelTypeName { get; set; }

    public string? FormView { get; set; }

    public string? StyleClass { get; set; }

    public string? CreateBy { get; set; }

    public string? CreatebyName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? Description { get; set; }

    public int? Status { get; set; }

    public string? Thumbnail { get; set; }

    public string? ExtendData { get; set; }

    public string? ReferenceId { get; set; }
}
