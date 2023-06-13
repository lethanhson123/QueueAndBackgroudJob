namespace Data.Databases.CMS_EMBERPLUS;

public partial class PrmoPromotion : BaseModel
{
    public long Id { get; set; }

    /// <summary>
    /// PromotionName
    /// </summary>
    public string? Title { get; set; }

    public string? Description { get; set; }

    /// <summary>
    /// 1: TRUE
    /// 
    /// 0: FALSE
    /// (Active field)
    /// </summary>
    public int? Status { get; set; }

    public string? Createby { get; set; }

    public string? CreateByName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime LastUpdateDate { get; set; }

    public int? CompanyId { get; set; }

    /// <summary>
    /// SV: Static Value
    /// 
    /// UP: Unique Per Instance (User/Email)
    /// </summary>
    public string CodeApplyFor { get; set; } = null!;

    public int TypeId { get; set; }

    public decimal? PromoTypeValue { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    /// <summary>
    /// 1: TRUE
    /// 
    /// 0: FALSE
    /// </summary>
    public bool MinSpendStatus { get; set; }

    public decimal? MinSpendValue { get; set; }

    /// <summary>
    /// SU:  SingleUser
    /// 
    /// 1C:Once per Customer
    /// 
    /// LA: LimitAmount
    /// </summary>
    public string UsageLimit { get; set; } = null!;

    public int? UsageLimitValue { get; set; }

    /// <summary>
    /// A: All Orders 
    /// 
    /// P: Products
    /// U: Users
    /// </summary>
    public string AppType { get; set; } = null!;

    public int? AllType { get; set; }

    public string? AllTypeId { get; set; }

    public bool? CheckEndDate { get; set; }
}

