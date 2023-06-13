namespace Data.Databases.CMS_EMBERPLUS;

public partial class CalcRegion : BaseModel
{
    public int Id { get; set; }

    public string RegionId { get; set; } = null!;

    public string? RegionName { get; set; }

    public string? OrgId { get; set; }

    public string? Title { get; set; }

    public int Status { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? LastUpdatedDate { get; set; }

    public string? LastUpdatedBy { get; set; }

    public bool? IsActive { get; set; }

    public long? CompanyId { get; set; }
}
