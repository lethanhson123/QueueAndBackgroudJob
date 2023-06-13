namespace Data.Databases.Tpfsystem;

public partial class WebRole : BaseModel
{
    public int Id { get; set; }

    public int CatalogueId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }
}

