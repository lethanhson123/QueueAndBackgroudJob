namespace Data.Databases.Csversion1;

public partial class CatalogueLiveHelpSetting : BaseModel
{
    public int Id { get; set; }

    public int CatalogueId { get; set; }

    public int ButtonId { get; set; }

    public string Custom1 { get; set; } = null!;

    public string? Custom2 { get; set; }

    public string? Custom3 { get; set; }
}

