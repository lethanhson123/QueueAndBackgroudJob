namespace Data.Databases.Csversion1;

public partial class CatVoucher : BaseModel
{
    public int Id { get; set; }

    public int? CatId { get; set; }

    public string? Type { get; set; }

    public string? RecordMatch { get; set; }

    public string? Displayname { get; set; }

    public double? RecordValue { get; set; }

    public DateTime? RecordActive { get; set; }

    public DateTime? RecordExpiry { get; set; }

    public string? Units { get; set; }

    public int? UserId { get; set; }

    public int? Accesslevel { get; set; }

    public decimal Minspend { get; set; }

    public bool NeedsToActivate { get; set; }

    public bool Deactivate { get; set; }

    public string? Status { get; set; }

    public bool Autoset { get; set; }
}

