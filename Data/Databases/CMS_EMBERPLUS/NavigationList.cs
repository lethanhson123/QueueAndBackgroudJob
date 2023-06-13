namespace Data.Databases.CMS_EMBERPLUS;

public partial class NavigationList : BaseModel
{
    public string Id { get; set; } = null!;

    public string? Url { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public int? Status { get; set; }

    public int? DisplayOrder { get; set; }

    public string? CreateBy { get; set; }

    public string? CreatebyName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? Icon { get; set; }

    public string? MappingPage { get; set; }

    public int? CompanyId { get; set; }
}

