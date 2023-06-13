namespace Data.Databases.CMS_EMBERPLUS;

public partial class ImpUploadFileLog : BaseModel
{
    public long Id { get; set; }

    public long IdTemplateList { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? Createby { get; set; }

    public string? CreateByName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string FileName { get; set; } = null!;

    public int Status { get; set; }

    public string Url { get; set; } = null!;

    public int? CompanyId { get; set; }

    public long? SeasonId { get; set; }

    public int? TotalRaw { get; set; }

    public int? TotalNewMainUserCreated { get; set; }

    public int? TotalWelcomeEmailSended { get; set; }

    public virtual ImpTemplateList IdTemplateListNavigation { get; set; } = null!;
}

