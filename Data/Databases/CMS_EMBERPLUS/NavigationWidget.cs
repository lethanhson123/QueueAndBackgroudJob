namespace Data.Databases.CMS_EMBERPLUS;

public partial class NavigationWidget : BaseModel
{
    public string Id { get; set; } = null!;

    public string? Source { get; set; }

    public string? Type { get; set; }

    public string? Template { get; set; }
}

