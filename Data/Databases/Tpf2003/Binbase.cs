namespace Data.Databases.Tpf2003;
public partial class Binbase : BaseModel
{
    public string Bin { get; set; } = null!;

    public string? Cardbrand { get; set; }

    public string? Issuingbank { get; set; }

    public string? Typeofcard { get; set; }

    public string? Cardcategory { get; set; }

    public string? Isocountryname { get; set; }

    public string? Isocodea2 { get; set; }

    public string? Isocodea3 { get; set; }

    public int? Isocountrynumber { get; set; }

    public string? Opt1 { get; set; }

    public string? Opt2 { get; set; }

    public DateTime? Date { get; set; }
}

