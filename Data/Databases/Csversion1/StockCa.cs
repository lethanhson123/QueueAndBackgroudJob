namespace Data.Databases.Csversion1;

public partial class StockCa : BaseModel
{
    public int CaId { get; set; }

    public string CaName { get; set; } = null!;

    public string CaCode { get; set; } = null!;

    public int? CaProCode { get; set; }

    public int? CaProDetailCode { get; set; }

    public string? CaProductType { get; set; }

    public string? CaSize { get; set; }

    public double CaPrice { get; set; }

    public double? CaWeight { get; set; }

    public string? CaDescriptions { get; set; }

    public string? CaImage { get; set; }

    public string? CaStatus { get; set; }

    public DateTime? CaCreateDate { get; set; }

    public DateTime? CaLastUpdateDate { get; set; }

    public string? CaStatusProduct { get; set; }

    public string? CaVirtualCode { get; set; }

    public long ProfileId { get; set; }

    public long Proid { get; set; }

    public int CatalogueId { get; set; }

    public string? ProfileName { get; set; }

    public int Id { get; set; }

    public int Propriceproid { get; set; }

    public int? Propriceprofileid { get; set; }

    public double Currentprice { get; set; }

    public double? Wasprice { get; set; }

    public string? Legacyfield { get; set; }

    public string? Currency { get; set; }
}

