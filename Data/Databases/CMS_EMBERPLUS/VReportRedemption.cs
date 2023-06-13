namespace Data.Databases.CMS_EMBERPLUS;
public partial class VReportRedemption : BaseModel
{
    public int CompanyId { get; set; }

    public string ParticipantId { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? UserId { get; set; }

    public string? UserName { get; set; }

    public int CountNum { get; set; }

    public int? Redeem { get; set; }

    public int? Redeemed { get; set; }

    public decimal CreditUpdated { get; set; }

    public decimal? CreditAvailable { get; set; }

    public decimal? CreditAssigned { get; set; }

    public decimal? CreditUsed { get; set; }

    public string? CreditUsage { get; set; }

    public string? ItemSelecttion { get; set; }
}

