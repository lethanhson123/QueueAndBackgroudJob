namespace Data.Databases.CMS_EMBERPLUS;

public partial class ImageWidget : BaseModel
{
    public string Id { get; set; } = null!;

    public string? ImageUrl { get; set; }

    public int? Width { get; set; }

    public int? Height { get; set; }

    public string? AltText { get; set; }

    public string? Link { get; set; }
}

