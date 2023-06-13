namespace Data.Databases.Csversion1;

public partial class CaCalculate : BaseModel
{
    public int Id { get; set; }

    public int? EntityId { get; set; }

    public int? JnrOld { get; set; }

    public int? JnrNew { get; set; }

    public int? MstrOld { get; set; }

    public int? MstrNew { get; set; }

    public int? ParticipantTotal { get; set; }

    public int? JnrCredit { get; set; }

    public int? MstrCredit { get; set; }

    public decimal? TotalCredit { get; set; }

    public decimal? UsedCredit { get; set; }

    public int? GrndMkrAssigned { get; set; }

    public int? GrndMkrRedeemed { get; set; }

    public int? GrndMkrAvailable { get; set; }

    public int? JnrCertAssigned { get; set; }

    public int? JnrCertRedeemed { get; set; }

    public int? JnrCertAvailable { get; set; }

    public int? CoordPackAssigned { get; set; }

    public int? CoordPackRedeemed { get; set; }

    public int? CoordPackAvailable { get; set; }

    public string? CoordPackBblteam { get; set; }

    public int? VolPackAssigned { get; set; }

    public int? VolPackRedeemed { get; set; }

    public int? VolPackAvailable { get; set; }

    public int? JnrMainAssigned { get; set; }

    public int? JnrMainRedeemed { get; set; }

    public int? JnrMainAvailable { get; set; }

    public int? JnrMainConeStart { get; set; }

    public string? MainSet1 { get; set; }

    public string? MainSet2 { get; set; }

    public string? MainSet3 { get; set; }

    public string? MainSet4 { get; set; }

    public int? JnrTopUpAssigned { get; set; }

    public int? JnrTopUpRedeemed { get; set; }

    public int? JnrTopUpAvailable { get; set; }

    public string? JnrTopupConeStart { get; set; }

    public string? TupSet1 { get; set; }

    public string? TupSet2 { get; set; }

    public string? TupSet3 { get; set; }

    public string? TupSet4 { get; set; }

    public int? TearDropFlagAssigned { get; set; }

    public int? TearDropFlagRedeemed { get; set; }

    public int? TearDropFlagAvailable { get; set; }

    public int? SchlCupAssigned { get; set; }

    public int? SchlCupRedeemed { get; set; }

    public int? SchlCupAvailable { get; set; }

    public int? SchlHpeAssigned { get; set; }

    public int? SchlHpeRedeemed { get; set; }

    public int? SchlHpeAvailable { get; set; }

    public int? JnrcricketStumpsAssigned { get; set; }

    public int? JnrcricketStumpsRedeemed { get; set; }

    public int? JnrcricketStumpsAvailable { get; set; }

    public int? JnrcricketTapemesAssigned { get; set; }

    public int? JnrcricketTapemesRedeemed { get; set; }

    public int? JnrcricketTapemesAvailable { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public bool? IsEntitlement { get; set; }

    public string? Notes { get; set; }

    public DateTime? SentDate1 { get; set; }

    public DateTime? SentDate2 { get; set; }

    public decimal? AdjCredit { get; set; }
}

