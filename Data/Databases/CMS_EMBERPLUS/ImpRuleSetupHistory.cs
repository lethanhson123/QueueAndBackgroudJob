namespace Data.Databases.CMS_EMBERPLUS;

public partial class ImpRuleSetupHistory : BaseModel
{
    public long Id { get; set; }

    public string? CreateBy { get; set; }

    public string? CreatebyName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? RuleSetting { get; set; }

    public long? RuleSetupId { get; set; }
}

