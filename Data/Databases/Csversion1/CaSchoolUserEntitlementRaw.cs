namespace Data.Databases.Csversion1;

public partial class CaSchoolUserEntitlementRaw : BaseModel
{
    public int Id { get; set; }

    public int? TransId { get; set; }

    public string? Type { get; set; }

    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? Suburb { get; set; }

    public string? State { get; set; }

    public string? Country { get; set; }

    public string? Postcode { get; set; }

    public string? Bblteam { get; set; }

    public string? ContactName { get; set; }

    public string? ContactEmail { get; set; }

    public string? ContactPhone { get; set; }

    public string? Organisation { get; set; }

    public string? OrgansationId { get; set; }

    public string? ActivityId { get; set; }

    public string? NoClasses { get; set; }

    public string? NoParticipants { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? Status { get; set; }

    public int? UploadedWebAccId { get; set; }

    public bool? IsCalculated { get; set; }

    public bool? NeedSendEmail { get; set; }

    public string? EmailTemplate { get; set; }

    public bool? SentEmail { get; set; }

    public DateTime? SendDate { get; set; }

    public long? TpforderId { get; set; }

    public string? GigyaId { get; set; }

    public bool? IsHpe { get; set; }

    public string? FulfilmentId { get; set; }
}

