namespace Data.Databases.Tpfsystem;

public partial class VCaReportRedemptionJunior : BaseModel
{
    public string EntityId { get; set; } = null!;

    public string? EntityName { get; set; }

    public string? EntityType { get; set; }

    public string? UserName { get; set; }

    public string? EntityState { get; set; }

    public int? JnrcricketStumpsAssigned { get; set; }

    public int? JnrcricketStumpsRedeemed { get; set; }

    public int? JnrcricketTapemesAssigned { get; set; }

    public int? JnrcricketTapemesRedeemed { get; set; }

    public string Stumps { get; set; } = null!;

    public string TapeMasure { get; set; } = null!;

    public string? RedemStatus { get; set; }

    public string? TextToSearch { get; set; }
}

