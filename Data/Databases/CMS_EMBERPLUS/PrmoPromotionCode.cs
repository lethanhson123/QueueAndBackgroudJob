namespace Data.Databases.CMS_EMBERPLUS;

public partial class PrmoPromotionCode : BaseModel
{
    /// <summary>
    /// Promo code name 
    /// </summary>
    public long Id { get; set; }

    public long PromoId { get; set; }

    /// <summary>
    /// Promo code name 
    /// </summary>
    public string? Title { get; set; }

    public string? Description { get; set; }

    public int? Status { get; set; }

    public string? Createby { get; set; }

    public string? CreateByName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime LastUpdateDate { get; set; }

    public int? CompanyId { get; set; }
}

