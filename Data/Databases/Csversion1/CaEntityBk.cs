namespace Data.Databases.Csversion1;

public partial class CaEntityBk : BaseModel
{
    public int Id { get; set; }

    public string EntityId { get; set; } = null!;

    public string? EntityName { get; set; }

    public string? EntityPostcode { get; set; }

    public string? EntityType { get; set; }

    public string? JuniorBprogramOneStartDate { get; set; }

    public string? JuniorBprogramTwoStartDate { get; set; }

    public string? MasterBprogramStartDate { get; set; }

    public string? JuniorBcoordinatorName { get; set; }

    public string? JuniorBcoordinatorEmail { get; set; }

    public string? JuniorBcoordinatorPhone { get; set; }

    public string? MasterBcoordinatorName { get; set; }

    public string? MasterBcoordinatorEmail { get; set; }

    public string? MasterBcoordinatorPhone { get; set; }

    public string? JuniorBdeliveryAddress1 { get; set; }

    public string? JuniorBdeliveryAddress2 { get; set; }

    public string? JuniorBdeliverySuburb { get; set; }

    public string? JuniorBdeliveryPostcode { get; set; }

    public string? JuniorBdeliveryState { get; set; }

    public string? MasterBdeliveryAddress1 { get; set; }

    public string? MasterBdeliveryAddress2 { get; set; }

    public string? MasterBdeliverySuburb { get; set; }

    public string? MasterBdeliveryPostcode { get; set; }

    public string? MasterBdeliveryState { get; set; }

    public string? CentreTypeDescription { get; set; }

    public int? CoordPackAvailable { get; set; }

    public int? CoordPackRedempted { get; set; }

    public string? CoordPackCode { get; set; }

    public string? CoorPackTeam { get; set; }

    public int? VolPackAvailable { get; set; }

    public int? VolPackRedempted { get; set; }

    public int? JuniorTopUpAvailable { get; set; }

    public int? JuniorTopUpRedempted { get; set; }

    public string? JuniorTopupCode { get; set; }

    public int? JuniorMainAvalaible { get; set; }

    public int? JuniorMainRedempted { get; set; }

    public string? JuniorMainCode { get; set; }

    public int? Master2Gavailable { get; set; }

    public int? Master2Gredempted { get; set; }

    public string? Master2Gcode { get; set; }

    public int? Master4Gavailable { get; set; }

    public int? Master4Gredempted { get; set; }

    public string? Master4Gcode { get; set; }

    public int? Cone1 { get; set; }

    public string? Con1Code { get; set; }

    public int? Cone2 { get; set; }

    public string? Cone2Code { get; set; }

    public int? Cone3 { get; set; }

    public string? Con3Code { get; set; }

    public int? Cone4 { get; set; }

    public string? Con4Code { get; set; }

    public int? SchoolIncentiveAvailable { get; set; }

    public int? SchoolIncentiveRedempted { get; set; }

    public string? SchoolIncentiveCode { get; set; }

    public int? SchoolSportAvailable { get; set; }

    public int? SchoolSportRedempted { get; set; }

    public string? SchoolSportCode { get; set; }

    public int? SchoolPack3Available { get; set; }

    public int? SchoolPack3Redempted { get; set; }

    public string? SchoolPackCode { get; set; }

    public int? CertificateBlastAvalable { get; set; }

    public int? CertificateBlastRedempted { get; set; }

    public string? CertificateBlastCode { get; set; }

    public int? CapAdultVolavalable { get; set; }

    public int? CapAdultVolredempted { get; set; }

    public string? CapAdultVolcode { get; set; }

    public int? CblteardropBannerAvalable { get; set; }

    public int? CblteardropBannerRedempted { get; set; }

    public string? CblteardropBannerCode { get; set; }

    public int? Old { get; set; }

    public int? New { get; set; }

    public int? Jcredit { get; set; }

    public int? Mcredit { get; set; }

    public string? State { get; set; }

    public int? ClientWebAccountId { get; set; }

    public string? Status { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? EntityState { get; set; }

    public bool? IsAddMore { get; set; }

    public DateTime? InsertDate { get; set; }

    public string? FirstSeason { get; set; }

    public string? DeliveryCountry { get; set; }

    public string? GetSourceFrom { get; set; }

    public int? IsSync { get; set; }

    public string? EnTypeExt { get; set; }

    public string? FirstYear { get; set; }

    public string? FirstActiveSeason { get; set; }

    public string? LegacyId { get; set; }
}

