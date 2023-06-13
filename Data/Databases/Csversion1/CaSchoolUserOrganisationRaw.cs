namespace Data.Databases.Csversion1;

public partial class CaSchoolUserOrganisationRaw : BaseModel
{
    public int Id { get; set; }

    public string? ContactId { get; set; }

    public string? ContactEmail { get; set; }

    public string? ContactName { get; set; }

    public string? ContactPhone { get; set; }

    public string? DefaultBbl { get; set; }

    public string? Organisation { get; set; }

    public string? OrganisationId { get; set; }

    public string? RelationshipId { get; set; }

    public string? Action { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? Status { get; set; }

    public int? UploadedWebAccId { get; set; }

    public int? TransactionId { get; set; }

    public bool? NeedSendEmail { get; set; }

    public string? EmailTemplate { get; set; }

    public bool? SentEmail { get; set; }

    public DateTime? SendDate { get; set; }

    public string? GigyaId { get; set; }
}

