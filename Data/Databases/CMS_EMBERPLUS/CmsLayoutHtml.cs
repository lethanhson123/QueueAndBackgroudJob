namespace Data.Databases.CMS_EMBERPLUS;

public partial class CmsLayoutHtml : BaseModel
{
    public int LayoutHtmlId { get; set; }

    public string LayoutId { get; set; } = null!;

    public string? Html { get; set; }

    public string? CreateBy { get; set; }

    public string? CreatebyName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime? LastUpdateDate { get; set; }
}
