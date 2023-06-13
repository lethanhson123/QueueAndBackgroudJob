namespace Data.Databases.CMS_EMBERPLUS;

public partial class ContentMenu : BaseModel
{
    public string Id { get; set; } = null!;

    public string? Filter { get; set; }

    public string? AssemblyName { get; set; }

    public int? Limit { get; set; }

    public string? OrderBy { get; set; }

    public string? HeaderTemplate { get; set; }

    public string? FooterTemplate { get; set; }

    public string? SpaceTemplate { get; set; }

    public string? RepeaterTemplate { get; set; }

    public string? NoDataTemplate { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public int? Status { get; set; }

    public string? CreateBy { get; set; }

    public string? CreatebyName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? Includes { get; set; }

    public int? DesignType { get; set; }

    public int? CompanyId { get; set; }
}

