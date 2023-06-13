namespace Data.Databases.CMS_EMBERPLUS;

public partial class ProductCategory : BaseModel
{
    public long Id { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public int? Status { get; set; }

    public DateTime LastUpdateDate { get; set; }

    public string? CreateBy { get; set; }

    public string? CreatebyName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public int? CompanyId { get; set; }

    public int? DisplayOrder { get; set; }

    public string? ImageUrl { get; set; }

    public string? ImageThumbUrl { get; set; }

    public long? ParentId { get; set; }

    public string? TreeId { get; set; }
}

