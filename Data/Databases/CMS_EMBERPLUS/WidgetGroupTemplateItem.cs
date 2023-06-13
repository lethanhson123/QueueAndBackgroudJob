namespace Data.Databases.CMS_EMBERPLUS;

public partial class WidgetGroupTemplateItem : BaseModel
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

    public string? Mapping { get; set; }

    public int? IndexView { get; set; }

    public bool? IsShow { get; set; }

    public string? ContentType { get; set; }

    public string? DefaultValue { get; set; }

    public string? Name { get; set; }

    public bool? IsRequired { get; set; }

    public int? GroupId { get; set; }
	public List<ExtendField> Values { get; set; }
}

