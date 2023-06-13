namespace Data.Databases.CMS_EMBERPLUS;

public partial class VRedemption : BaseModel
{
    public int UniqueId { get; set; }

    public string EntityId { get; set; } = null!;

    public string EntityName { get; set; } = null!;

    public string EntityState { get; set; } = null!;

    public decimal CreditTenure { get; set; }

    public decimal ParticipantCredit { get; set; }

    public decimal DiversityCredit { get; set; }

    public decimal? AssignedCredit { get; set; }

    public decimal UpdateCredit { get; set; }

    public decimal? UsedCredit { get; set; }

    public decimal AvailableCredit { get; set; }

    public int PacksAssigned { get; set; }

    public int PacksRedeemed { get; set; }

    public int PacksAvailable { get; set; }

    public string? PackStatus { get; set; }

    public string? OrgId { get; set; }

    public long? UserTypeId { get; set; }

    public string UserId { get; set; } = null!;
}

