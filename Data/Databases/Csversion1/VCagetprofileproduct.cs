namespace Data.Databases.Csversion1;

public partial class VCagetprofileproduct : BaseModel
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

    public int Expr1 { get; set; }

    public string? Name { get; set; }

    public int? Catalogueid { get; set; }

    public string? Expr2 { get; set; }

    public DateTime Created { get; set; }

    public int Isdefault { get; set; }

    public string? Status { get; set; }

    public string? Notes { get; set; }

    public int? Taxexclusive { get; set; }

    public string? Expr3 { get; set; }

    public DateTime Expr4 { get; set; }
}

