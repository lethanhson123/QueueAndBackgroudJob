namespace Data.Databases.Csversion1;

public partial class CatalogueSeo : BaseModel
{
    public int CatalogueId { get; set; }

    public string? Title { get; set; }

    public string? Keywords { get; set; }

    public string? Description { get; set; }

    public string? Author { get; set; }

    public string? Language { get; set; }
}

