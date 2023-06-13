namespace Data.Databases.CMS_EMBERPLUS;

public partial class ProductLetterPersonalize : BaseModel
{
    public long Id { get; set; }

    public string? Title { get; set; }

    public int? Status { get; set; }

    public string? CreateBy { get; set; }

    public string? CreatebyName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? Description { get; set; }

    public long? ProductId { get; set; }

    public int? Index { get; set; }

    public string? ImageUrl { get; set; }

    public string? ImageThumbUrl { get; set; }

    public double? Width { get; set; }

    public double? Height { get; set; }

    public string? Letter { get; set; }

    public double? Xaxis { get; set; }

    public double? Yaxis { get; set; }

    public double? Rotate { get; set; }

    public double? FontSize { get; set; }

    public string? FontName { get; set; }

    public string? FontColor { get; set; }

    public int? MaxLength { get; set; }

    public double? BoxWidth { get; set; }

    public double? BoxHeight { get; set; }

    public bool? AllowInputText { get; set; }
}

