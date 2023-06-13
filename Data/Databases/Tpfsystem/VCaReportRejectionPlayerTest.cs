namespace Data.Databases.Tpfsystem;

public partial class VCaReportRejectionPlayerTest : BaseModel
{
    public int Id { get; set; }

    public int Postcode { get; set; }

    public string Suburb { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string? Comments { get; set; }

    public string? Category { get; set; }

    public DateTime Created { get; set; }

    public string? FullSuburb { get; set; }
}

