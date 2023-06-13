namespace Data.Databases.Tpfsystem;

public partial class VCaReportRedemptionCentre : BaseModel
{
    public string EntityId { get; set; } = null!;

    public string? EntityName { get; set; }

    public string? UserName { get; set; }

    public string? EntityState { get; set; }

    public int? JnrOld { get; set; }

    public int? JnrNew { get; set; }

    public int? MstrNew { get; set; }

    public int? JnrCredit { get; set; }

    public int? MstrCredit { get; set; }

    public decimal? TotalCredit { get; set; }

    public decimal? UsedCredit { get; set; }

    public decimal? AdjCredit { get; set; }

    public decimal? AvailCredit { get; set; }

    public int? JnrMainAssigned { get; set; }

    public int? JnrMainRedeemed { get; set; }

    public int? JnrTopUpAssigned { get; set; }

    public int? JnrTopUpRedeemed { get; set; }

    public int? JnrCertAssigned { get; set; }

    public int? JnrCertRedeemed { get; set; }

    public int? CoordPackAssigned { get; set; }

    public int? CoordPackRedeemed { get; set; }

    public int? VolPackAssigned { get; set; }

    public int? VolPackRedeemed { get; set; }

    public int? TearDropFlagAssigned { get; set; }

    public int? TearDropFlagRedeemed { get; set; }

    public string Main { get; set; } = null!;

    public string TopUp { get; set; } = null!;

    public string Certificate { get; set; } = null!;

    public string CoordPack { get; set; } = null!;

    public string VolCap { get; set; } = null!;

    public string Tdbanner { get; set; } = null!;

    public string? RedemStatus { get; set; }

    public string? TextToSearch { get; set; }
}

