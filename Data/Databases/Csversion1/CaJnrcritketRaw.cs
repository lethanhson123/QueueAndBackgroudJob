namespace Data.Databases.Csversion1;

public partial class CaJnrcritketRaw : BaseModel
{
    public int Id { get; set; }

    public int? TransactionId { get; set; }

    public string? ClubId { get; set; }

    public string? ClubName { get; set; }

    public string? TeamId { get; set; }

    public string? TeamName { get; set; }

    public string? State { get; set; }

    public string? GradeId { get; set; }

    public string? Grade { get; set; }

    public string? GradeType { get; set; }

    public string? GradeStandard { get; set; }

    public string? GradeTypeId { get; set; }

    public string? JuniorFormat { get; set; }

    public string? Gradeformatid { get; set; }

    public string? AssociationId { get; set; }

    public string? AssociationName { get; set; }

    public string? ClubPrimaryContactName { get; set; }

    public string? ClubPrimaryContactEmail { get; set; }

    public string? OrganisationEmail { get; set; }

    public string? OrganisationPhone { get; set; }

    public int? NumberOfMatchFixtured { get; set; }

    public string? Rcmemail { get; set; }

    public string? EntryDate { get; set; }

    public string? Status { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public bool? StatusUsed { get; set; }

    public int? UploadedWebAccId { get; set; }

    public bool? IsCalculated { get; set; }

    public bool? NeedSendEmail { get; set; }

    public string? EmailTemplate { get; set; }

    public bool? SentEmail { get; set; }

    public DateTime? SendDate { get; set; }
}

