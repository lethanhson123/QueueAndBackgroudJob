namespace Data.Databases.Csversion1;

public partial class CaConset : BaseModel
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Proid { get; set; }

    public int? ProdetailCode { get; set; }

    public string? Code { get; set; }

    public string? VitualCodeAcalable { get; set; }

    public string? VitualCodeConCenAcalable { get; set; }
}

