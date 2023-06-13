namespace Data.Databases.Csversion1;

public partial class VCagetpropackdynamic : BaseModel
{
    public int Id { get; set; }

    public int ProId { get; set; }

    public int Type { get; set; }

    public int Qty { get; set; }

    public int Expr1 { get; set; }

    public string? NameType { get; set; }

    public int Expr2 { get; set; }

    public int? IdCaTypes { get; set; }

    public int? IdCaBbl { get; set; }

    public bool? IsDisplay { get; set; }

    public int Expr3 { get; set; }

    public string? Name { get; set; }

    public string? ClubCode { get; set; }

    public int Expr4 { get; set; }

    public int Expr5 { get; set; }

    public int Expr6 { get; set; }

    public int IdtypeSub { get; set; }

    public int Expr7 { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreateDate { get; set; }
}

