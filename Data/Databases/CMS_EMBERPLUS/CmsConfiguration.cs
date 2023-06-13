namespace Data.Databases.CMS_EMBERPLUS;

public partial class CmsConfiguration : BaseModel
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public int Status { get; set; }

    public string? CreateBy { get; set; }

    public string? CreatebyName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? Description { get; set; }

    public int? CompanyId { get; set; }

    public string? BackEnd404Url { get; set; }

    public string? BackEnd403Url { get; set; }

    public string? BackEnd500Url { get; set; }

    public string? BackEndAfterLogin { get; set; }

    public string? BackEndLogin { get; set; }

    public string? BackEndFavicon { get; set; }

    public string? FrontEnd404Url { get; set; }

    public string? FrontEnd403Url { get; set; }

    public string? FrontEnd500Url { get; set; }

    public string? FrontEndAfterLogin { get; set; }

    public string? FrontEndLogin { get; set; }

    public string? BackEndHome { get; set; }

    public string? FrontEndHome { get; set; }

    public string? GoogleAnalyticKey { get; set; }

    public string? GoogleApiToken { get; set; }

    public string? GoogleTagManagerKey { get; set; }

    public string? GoogleCapcha2Key { get; set; }

    public string? GoogleIdviewReport { get; set; }

    public int? OrderSyncType { get; set; }

    public string? OrderSyncCronExpression { get; set; }

    public string? OrderSyncCronJob { get; set; }

    public string? OrderPrefix { get; set; }

    public string? LogSeqApiKey { get; set; }

    public int? SeasonChange { get; set; }

    public bool? UsedCreditFreight { get; set; }

    public int? ApplyCreditType { get; set; }

    public bool? ProductAssignedEntilement { get; set; }

    public bool? AllChoices { get; set; }

    public bool? ShowOffer { get; set; }

    public int? BanerDisplayOffer { get; set; }

    public bool? CategoryDisplayOffer { get; set; }

    public bool? IsAllowNameInput { get; set; }

    public bool? CreditAssignedEntilement { get; set; }

    public bool? FreightExcludedEntilement { get; set; }
}
