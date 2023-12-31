namespace Data.Databases.CMS_EMBERPLUS;

public partial class WidgetGroupTemplate : BaseModel
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public int? Status { get; set; }

    public string? CreateBy { get; set; }

    public string? CreatebyName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? Description { get; set; }

    public string? WidgetId { get; set; }

    public int? IndexView { get; set; }

    public bool? IsShow { get; set; }

	public List<WidgetGroupTemplateItem> Items { get; set; }
}

