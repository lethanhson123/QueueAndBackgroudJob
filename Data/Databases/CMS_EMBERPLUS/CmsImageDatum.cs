namespace Data.Databases.CMS_EMBERPLUS;

public partial class CmsImageDatum : BaseModel
{
    public int Id { get; set; }

    public int? RefId { get; set; }

    public string? RefModule { get; set; }

    public string? ImageUrl { get; set; }

    public string? ImageThumbUrl { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public int? Status { get; set; }

    public string? CreateBy { get; set; }

    public string? CreatebyName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime? LastUpdateDate { get; set; }
}
