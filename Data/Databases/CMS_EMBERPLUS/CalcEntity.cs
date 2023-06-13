namespace Data.Databases.CMS_EMBERPLUS;

public partial class CalcEntity : BaseModel
{
    public long Id { get; set; }

    public string UserId { get; set; } = null!;

    public string EntityId { get; set; } = null!;

    public string EntityType { get; set; } = null!;

    public string EntityName { get; set; } = null!;

    public string OrgId { get; set; } = null!;

    public string EntityTenure { get; set; } = null!;

    public string DeliveryFirstName { get; set; } = null!;

    public string DeliveryLastName { get; set; } = null!;

    public string DeliveryCompanyName { get; set; } = null!;

    public string DeliveryPhone { get; set; } = null!;

    public string DeliveryEmail { get; set; } = null!;

    public string DeliveryAddressLine1 { get; set; } = null!;

    public string DeliveryAddressLine2 { get; set; } = null!;

    public string DeliverySuburb { get; set; } = null!;

    public string DeliveryState { get; set; } = null!;

    public string DeliveryPostcode { get; set; } = null!;

    public string DeliveryCountry { get; set; } = null!;

    public bool? IsActive { get; set; }

    public bool? Approved { get; set; }

    public int CompanyId { get; set; }

    public DateTime LastUpdateDate { get; set; }

    public DateTime? EntityCreatedDate { get; set; }

    public string? RegionId { get; set; }

    public string? RegionName { get; set; }

    public int? PrevYearParticipants { get; set; }

    public string? FirstActiveSeason { get; set; }
}
