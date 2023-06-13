namespace Data.Databases.CMS_EMBERPLUS;

public partial class NewsCategory : BaseModel
{
    public int Id { get; set; }

    public int? CatalogueId { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public short? DisCatPriority { get; set; }

    public int? Status { get; set; }

    public DateTime LastUpdateDate { get; set; }

    public string? ImageName { get; set; }

    public string? CreateBy { get; set; }

    public string? CreatebyName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public int? CompanyId { get; set; }
}

