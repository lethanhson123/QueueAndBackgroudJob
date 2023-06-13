namespace Data.Databases.CMS_EMBERPLUS;

public partial class PrmoPromotionCodeAssignUser : BaseModel
{
    public long PromoCodeId { get; set; }

    public string UserId { get; set; } = null!;

    /// <summary>
    /// NULL: NOT SEND
    /// 
    /// 1: SEND
    /// 
    /// 0: NOT YET SEND
    /// </summary>
    public bool SendEmail { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public int? Status { get; set; }

    public string? Createby { get; set; }

    public string? CreateByName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime LastUpdateDate { get; set; }

    public int? UserTypeId { get; set; }
}

