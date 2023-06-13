namespace Data.Databases.Csversion1;

public partial class CheckPriceCa : BaseModel
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? CaPrice { get; set; }

    public string? StatePrice { get; set; }

    public string? CentrePrice { get; set; }

    public string? SchoolPrice { get; set; }

    public string? JuniorPrice { get; set; }

    public string? PublicPrice { get; set; }

    public string? Category { get; set; }
}

