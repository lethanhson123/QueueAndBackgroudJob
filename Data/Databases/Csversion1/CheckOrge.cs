namespace Data.Databases.Csversion1;

public partial class CheckOrge : BaseModel
{
    public int Id { get; set; }

    public string? NewIds { get; set; }

    public string? OrganisationName { get; set; }

    public string? LegacyId { get; set; }
}

