namespace Data.Databases.Csversion1;

public partial class ProductTemplate : BaseModel
{
    public int Id { get; set; }

    public int CatalogueId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? Imagename { get; set; }

    public string? Simpletag { get; set; }

    public string Status { get; set; } = null!;

    public DateTime Lastmodified { get; set; }
}

