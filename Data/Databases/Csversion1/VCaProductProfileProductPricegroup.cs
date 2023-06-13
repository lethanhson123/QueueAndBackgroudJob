namespace Data.Databases.Csversion1;

public partial class VCaProductProfileProductPricegroup : BaseModel
{
    public int Expr1 { get; set; }

    public int Expr2 { get; set; }

    public int? Expr3 { get; set; }

    public double Expr4 { get; set; }

    public double? Expr5 { get; set; }

    public string? Expr6 { get; set; }

    public string? Expr7 { get; set; }

    public double? Expr8 { get; set; }

    public decimal Expr9 { get; set; }

    public DateTime Expr10 { get; set; }

    public long Expr11 { get; set; }

    public long Proid { get; set; }

    public int CatalogueId { get; set; }

    public string? ProfileName { get; set; }

    public string? ItemDesc { get; set; }

    public string? ItemSizeType { get; set; }

    public string? ItemColour { get; set; }

    public string? Jobbagid { get; set; }

    public string? ItemNotes { get; set; }

    public string? SpLocation { get; set; }

    public string? InnerQty { get; set; }

    public string? OuterQty { get; set; }

    public string? TickPackRequired { get; set; }

    public int? PackQty { get; set; }

    public string? PackType { get; set; }

    public string? CartonMark { get; set; }

    public string? AddNotes { get; set; }

    public string? Qareport { get; set; }

    public string? ProfileNotes { get; set; }

    public string DefaultProfile { get; set; } = null!;

    public string Plocation { get; set; } = null!;

    public long? MainStockProfileid { get; set; }

    public DateTime? LastUpdate { get; set; }

    public int? Updateby { get; set; }

    public DateTime? Cancelledon { get; set; }

    public int? Cancelledby { get; set; }

    public string Pstatus { get; set; } = null!;

    public long? EventProfileId { get; set; }
}

