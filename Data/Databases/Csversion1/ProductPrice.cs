namespace Data.Databases.Csversion1;

public partial class ProductPrice : BaseModel
{
    public int Id { get; set; }

    public int Proid { get; set; }

    public int? Profileid { get; set; }

    public double Currentprice { get; set; }

    public double? Wasprice { get; set; }

    public string? Legacyfield { get; set; }

    public string? Currency { get; set; }

    public double? Taxrate { get; set; }

    public decimal RebatePercentage { get; set; }

    public DateTime Lastmodified { get; set; }
}

