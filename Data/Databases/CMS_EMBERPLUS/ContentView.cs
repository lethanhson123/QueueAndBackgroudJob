namespace Data.Databases.CMS_EMBERPLUS;

public partial class ContentView : BaseModel
{
    public string Id { get; set; } = null!;

    public string? Title { get; set; }

    public int? Status { get; set; }

    public string? CreateBy { get; set; }

    public string? CreatebyName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? Description { get; set; }

    public string? Target { get; set; }

    public int? TargetType { get; set; }

    public string? Query { get; set; }

    public int? CompanyId { get; set; }
}

