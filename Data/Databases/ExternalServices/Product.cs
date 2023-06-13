namespace Data.Databases.ExternalServices;

public partial class Product : BaseModel
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public string? ProductType { get; set; }

    public byte[]? Name2 { get; set; }

    public string? Description { get; set; }
}

