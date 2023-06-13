namespace Data.Databases.CMS_EMBERPLUS;

public partial class VReportRedemptionExport : BaseModel
{
    public string Redeem { get; set; } = null!;

    public string Redeemed { get; set; } = null!;

    public string CreditAccount { get; set; } = null!;

    public int CompanyId { get; set; }

    public string? WebAcctId { get; set; }

    public string? WebAcctType { get; set; }

    public int? CountNum { get; set; }

    public string UserId { get; set; } = null!;

    public string? UserName { get; set; }

    public int GroupMain { get; set; }

    public int? RecordCount { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string OrgId { get; set; } = null!;

    public string OrgName { get; set; } = null!;

    public string EntityId { get; set; } = null!;

    public string EntityName { get; set; } = null!;

    public string ProgramId { get; set; } = null!;

    public string? ProgramName { get; set; }

    public string? ProgramType { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string ParticipantId { get; set; } = null!;

    public string? Item { get; set; }

    public string ItemType { get; set; } = null!;

    public decimal? ItemAmount { get; set; }

    public string ItemSelecttion { get; set; } = null!;

    public string SelectionDesign { get; set; } = null!;

    public string SelectionSize { get; set; } = null!;

    public string SelectionInput { get; set; } = null!;

    public string SelectionOther { get; set; } = null!;

    public DateTime? SelectionDeadline { get; set; }

    public DateTime? SelectionDate { get; set; }

    public string SelectionType { get; set; } = null!;

    public long? OrderId { get; set; }

    public string? OrderStatus { get; set; }

    public decimal? CreditUsage { get; set; }

    public int CreditLacy { get; set; }

    public decimal? CreditAdjust { get; set; }

    public decimal? CreditAssigned { get; set; }

    public decimal? CreditUsed { get; set; }

    public decimal? CreditAvailable { get; set; }
}

