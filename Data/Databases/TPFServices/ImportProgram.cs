namespace Data.Databases.TPFServices;

public partial class ImportProgram : BaseModel
{
    public int Id { get; set; }

    public int? TransId { get; set; }

    public string? ProgramId { get; set; }

    public string? ProgramType { get; set; }

    public string? ProgramName { get; set; }

    public string? EntityId { get; set; }

    public string? ProgramTerm { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public string? CoordinatorId { get; set; }

    public string? CoordinatorFirstName { get; set; }

    public string? CoordinatorLastName { get; set; }

    public string? VenueAddressLine1 { get; set; }

    public string? VenueAddressLine2 { get; set; }

    public string? VenueAddressLine3 { get; set; }

    public string? VenueSuburb { get; set; }

    public string? VenueState { get; set; }

    public string? VenuePostcode { get; set; }

    public string? VenueCountry { get; set; }

    public string? DeliveryFirstName { get; set; }

    public string? DeliveryLastName { get; set; }

    public string? DeliveryCompanyName { get; set; }

    public string? DeliveryPhone { get; set; }

    public string? DeliveryEmail { get; set; }

    public string? DeliveryAddressLine1 { get; set; }

    public string? DeliveryAddressLine2 { get; set; }

    public string? DeliveryAddressLine3 { get; set; }

    public string? DeliverySuburb { get; set; }

    public string? DeliveryState { get; set; }

    public string? DeliveryPostcode { get; set; }

    public string? DeliveryCountry { get; set; }

    public string? OtherInfo1 { get; set; }

    public string? OtherInfo2 { get; set; }

    public string? OtherInfo3 { get; set; }

    public string? OtherInfo4 { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? LastUpdatedDate { get; set; }

    public int? LastUpdatedBy { get; set; }

    public bool? IsActive { get; set; }

    public bool? Approved { get; set; }
}

