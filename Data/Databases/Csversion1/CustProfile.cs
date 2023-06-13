namespace Data.Databases.Csversion1;

public partial class CustProfile : BaseModel
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Catalogueid { get; set; }

    public string? Legacyfield { get; set; }

    public DateTime Created { get; set; }

    public int Isdefault { get; set; }

    public string? Status { get; set; }

    public string? Notes { get; set; }

    public int? Taxexclusive { get; set; }

    public string? Currency { get; set; }

    public DateTime Lastmodified { get; set; }
}

