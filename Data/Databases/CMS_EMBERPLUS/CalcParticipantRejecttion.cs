namespace Data.Databases.CMS_EMBERPLUS;

public partial class CalcParticipantRejecttion : BaseModel
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public int? Status { get; set; }

    public string? Description { get; set; }

    public string? CreateBy { get; set; }

    public string? CreatebyName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? ParticipantId { get; set; }

    public string? ParticipantType { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? ErrorCode { get; set; }

    public long? RawId { get; set; }

    public long? TemplateId { get; set; }

    public int? CompanyId { get; set; }

    public long? UploadId { get; set; }

    public string? ProgramId { get; set; }

    public string? ProgramType { get; set; }

    public string? ProgramName { get; set; }

    public string? OrgId { get; set; }

    public string? OrgName { get; set; }

    public string? EntityId { get; set; }

    public string? EntityName { get; set; }

    public string? RawData { get; set; }
}
