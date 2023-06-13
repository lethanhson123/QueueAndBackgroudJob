namespace Data.Databases.Csversion1;

public partial class CaTag : BaseModel
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public int? CatalogueId { get; set; }

    public string? Status { get; set; }
}

