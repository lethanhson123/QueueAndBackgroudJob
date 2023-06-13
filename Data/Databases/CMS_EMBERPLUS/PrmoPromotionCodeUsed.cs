namespace Data.Databases.CMS_EMBERPLUS;

public partial class PrmoPromotionCodeUsed : BaseModel
{
    public long Id { get; set; }

    public long PromoId { get; set; }

    public long? PromoCodeId { get; set; }

    public string? UserId { get; set; }

    public string? EmailUser { get; set; }

    public long OrderId { get; set; }

    public decimal? PromoTypeValue { get; set; }

    public decimal? PromoValue { get; set; }

    public decimal? TotalGst { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public int? Status { get; set; }

    public string? Createby { get; set; }

    public string? CreateByName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime LastUpdateDate { get; set; }
}

