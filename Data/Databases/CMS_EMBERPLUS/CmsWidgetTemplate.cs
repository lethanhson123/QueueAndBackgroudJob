namespace Data.Databases.CMS_EMBERPLUS;

public partial class CmsWidgetTemplate : BaseModel
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? GroupName { get; set; }

    public string? PartialView { get; set; }

    public string? AssemblyName { get; set; }

    public string? ServiceTypeName { get; set; }

    public string? ViewModelTypeName { get; set; }

    public string? Thumbnail { get; set; }

    public int? Order { get; set; }

    public string? Description { get; set; }

    public int? Status { get; set; }

    public string? FormView { get; set; }

    public string? StyleClass { get; set; }

    public string? CreateBy { get; set; }

    public string? CreatebyName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime? LastUpdateDate { get; set; }
}
