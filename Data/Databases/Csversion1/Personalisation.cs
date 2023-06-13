namespace Data.Databases.Csversion1;

public partial class Personalisation : BaseModel
{
    public int PersonalisationId { get; set; }

    public int? Uploaddataid { get; set; }

    public int OrderDetailId { get; set; }

    public string? Type { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string? Notes { get; set; }

    public string? Style { get; set; }

    public string? String0 { get; set; }

    public string? String1 { get; set; }

    public string? String2 { get; set; }

    public string? String3 { get; set; }

    public string? String4 { get; set; }

    public string? String5 { get; set; }
}

