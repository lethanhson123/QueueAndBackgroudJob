namespace Data.Databases.Csversion1;

public partial class ZTbCheckDataEveryday : BaseModel
{
    public int Ixd { get; set; }

    public string? SchType { get; set; }

    public int? SchCupSeq { get; set; }

    public int? SchCupUnique { get; set; }

    public int? Id { get; set; }

    public int? TransId { get; set; }

    public int? EntityId { get; set; }

    public string? OrgansationId { get; set; }

    public string? GigyaId { get; set; }

    public string? Code { get; set; }

    public int? SchlAssigned { get; set; }

    public int? SchlRedeemed { get; set; }

    public int? Avalable { get; set; }

    public int? Unavalable { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? CheckDate { get; set; }
}

