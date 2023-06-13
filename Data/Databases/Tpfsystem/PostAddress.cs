namespace Data.Databases.Tpfsystem;

public partial class PostAddress : BaseModel
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

    public bool? IsMfwzone { get; set; }

    public string? Region { get; set; }

    public string? RegionCode { get; set; }
}

