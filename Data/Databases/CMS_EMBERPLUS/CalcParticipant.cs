namespace Data.Databases.CMS_EMBERPLUS;

public partial class CalcParticipant : BaseModel
{
    public long Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? ParentFirstName { get; set; }

    public string? ParentLastName { get; set; }

    public string DeliveryFirstName { get; set; } = null!;

    public string DeliveryLastName { get; set; } = null!;

    public string? DeliveryPhone { get; set; }

    public string DeliveryEmail { get; set; } = null!;

    public string DeliveryAddressLine1 { get; set; } = null!;

    public string DeliveryAddressLine2 { get; set; } = null!;

    public string DeliverySuburb { get; set; } = null!;

    public string DeliveryState { get; set; } = null!;

    public string DeliveryPostcode { get; set; } = null!;

    public string DeliveryCountry { get; set; } = null!;

    public string? OtherInfo1 { get; set; }

    public string? OtherInfo2 { get; set; }

    public string? OtherInfo3 { get; set; }

    public string? OtherInfo4 { get; set; }

    public bool? IsActive { get; set; }

    public long CaclEntityId { get; set; }

    public string ParticipantId { get; set; } = null!;

    public string ParticipantType { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public bool? Approved { get; set; }

    public string? Category { get; set; }

    public DateTime? BirthDate { get; set; }

    public int? Age { get; set; }

    public string? Gender { get; set; }

    public string? AccountId { get; set; }

    public string? AccountType { get; set; }

    public string? MemberId { get; set; }

    public string? MemberType { get; set; }

    public string? MemberSinceFirst { get; set; }

    public string? MemberSinceConsecutive { get; set; }

    public string? MemberYearsTotal { get; set; }

    public string? MemberYearsConsecutive { get; set; }

    public string? MemberYearsUpdated { get; set; }

    public string? ExternalLinkId { get; set; }

    public string? ExternalLinkType { get; set; }

    public string? Note { get; set; }

    public long? ParentId { get; set; }

    public string? UserId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? DisplayOrder { get; set; }

    public long? CompanyId { get; set; }

    public string? Notes { get; set; }
}
