namespace Data.Databases.Csversion1;

public partial class ProductSeo : BaseModel
{
    public int ProId { get; set; }

    public string? Title { get; set; }

    public string? Keywords { get; set; }

    public string? Description { get; set; }

    public string? ImgAlt { get; set; }

    public string? ImgTitle { get; set; }
}

