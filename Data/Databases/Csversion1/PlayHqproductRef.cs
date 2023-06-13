namespace Data.Databases.Csversion1;

public partial class PlayHqproductRef : BaseModel
{
    public string? ProductId { get; set; }

    public string? ParentProductId { get; set; }

    public string? Name { get; set; }

    public string? OrganisationId { get; set; }

    public string? Description { get; set; }
}

