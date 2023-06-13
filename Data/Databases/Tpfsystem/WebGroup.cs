namespace Data.Databases.Tpfsystem;

public partial class WebGroup : BaseModel
{
    public int Id { get; set; }

    public int CatalogueId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? Sign { get; set; }

    public int? DefaultPriceId { get; set; }

    public int? RrppriceId { get; set; }

    public bool ShowProductOnHome { get; set; }
}

