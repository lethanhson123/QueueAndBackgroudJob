namespace Data.Databases.Csversion1;

public partial class CaSchoolOrgContactBakDelete : BaseModel
{
    public int Id { get; set; }

    public int? TransId { get; set; }

    public string? SchoolUser { get; set; }

    public string? OrgId { get; set; }

    public DateTime? CreateDate { get; set; }
}

