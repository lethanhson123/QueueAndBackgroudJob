namespace Data.Databases.Csversion1;

public partial class UserSchoolCheck : BaseModel
{
    public int Id { get; set; }

    public string? NewIds { get; set; }

    public string? Email { get; set; }

    public string? LegacyId { get; set; }

    public string? GigyaId { get; set; }
}

