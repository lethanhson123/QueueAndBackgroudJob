namespace Data.Databases.Csversion1;

public partial class CaProductProfilePreview : BaseModel
{
    public double? Id { get; set; }

    public double? Proid { get; set; }

    public double? Profileid { get; set; }

    public double? Currentprice { get; set; }

    public double? Wasprice { get; set; }

    public string? Legacyfield { get; set; }

    public string? Currency { get; set; }

    public double? Taxrate { get; set; }

    public double? RebatePercentage { get; set; }

    public DateTime? Lastmodified { get; set; }
}

