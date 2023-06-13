namespace Data.Databases.Csversion1;

public partial class CaSchoolOrganisationStatusBakup20201203 : BaseModel
{
    public int Id { get; set; }

    public int? IdRoot { get; set; }

    public int? TransId { get; set; }

    public string? SchoolUserId { get; set; }

    public string? OrganisationId { get; set; }

    public string? Organisation { get; set; }

    public string? DefaultBbl { get; set; }

    public string? Status { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? LegacyId { get; set; }
}

