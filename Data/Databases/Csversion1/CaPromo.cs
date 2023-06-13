namespace Data.Databases.Csversion1;

public partial class CaPromo : BaseModel
{
    public int Id { get; set; }

    public string? PromoName { get; set; }

    public double? DiscountAmount { get; set; }

    public string? Type { get; set; }

    public string? ApplyFor { get; set; }

    public string? ProductCode { get; set; }

    public string? Status { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }
}

