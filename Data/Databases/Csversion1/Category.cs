namespace Data.Databases.Csversion1;

public partial class Category : BaseModel
{
    public long CategoryId { get; set; }

    public int? CatalogueId { get; set; }

    public string? Categoryname { get; set; }

    public string? Description { get; set; }

    public short? Discatpriority { get; set; }

    public string? Catestatus { get; set; }

    public DateTime Lastmodified { get; set; }

    public string? Imagename { get; set; }
}

