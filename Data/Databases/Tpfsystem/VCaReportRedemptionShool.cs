namespace Data.Databases.Tpfsystem;

public partial class VCaReportRedemptionShool : BaseModel
{
    public string EntityId { get; set; } = null!;

    public string? EntityName { get; set; }

    public string? EntityType { get; set; }

    public string? UserName { get; set; }

    public string? Bblclub { get; set; }

    public string? EntityState { get; set; }

    public int? SchlCupAssigned { get; set; }

    public int? SchlCupRedeemed { get; set; }

    public int? SchlHpeAssigned { get; set; }

    public int? SchlHpeRedeemed { get; set; }

    public string SchoolCup { get; set; } = null!;

    public string HealthPe { get; set; } = null!;

    public string? GigyaId { get; set; }

    public string? RoleStatus { get; set; }

    public string? RedemStatus { get; set; }

    public string? TextToSearch { get; set; }
}

