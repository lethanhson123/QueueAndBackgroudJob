namespace Data.Databases.Tpfsystem;

public partial class PostAddressBack : BaseModel
{
    public int Id { get; set; }

    public string Postcode { get; set; } = null!;

    public string Suburb { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string? Comments { get; set; }

    public string? Category { get; set; }

    public DateTime? Created { get; set; }

    public string FullSuburb { get; set; } = null!;
}

