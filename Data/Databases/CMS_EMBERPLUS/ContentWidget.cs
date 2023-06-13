namespace Data.Databases.CMS_EMBERPLUS;

public partial class ContentWidget : BaseModel
{
    public string Id { get; set; } = null!;

    public string? Html { get; set; }

    public bool? IsDetail { get; set; }

    public string? AssemblyName { get; set; }

    public string? Includes { get; set; }
}

