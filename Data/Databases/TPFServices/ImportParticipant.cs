namespace Data.Databases.TPFServices;

public partial class ImportParticipant : BaseModel
{
    public int Id { get; set; }

    public int? TransId { get; set; }

    public string? ParticipantId { get; set; }

    public string? ParticipantType { get; set; }

    public string? ProgramId { get; set; }

    public string? Title { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Category { get; set; }

    public DateTime? BirthDate { get; set; }

    public int? Age { get; set; }

    public string? Gender { get; set; }

    public string? AccountId { get; set; }

    public string? AccountType { get; set; }

    public string? ParentFirstName { get; set; }

    public string? ParentLastName { get; set; }

    public string? Notes { get; set; }

    public string? MemberId { get; set; }

    public string? MemberSinceFirst { get; set; }

    public string? MemberSinceConsecutive { get; set; }

    public string? MemberYearsTotal { get; set; }

    public string? MemberYearsConsecutive { get; set; }

    public string? MemberYearsUpdated { get; set; }

    public string? ExternalLinkId { get; set; }

    public string? ExternalLinkType { get; set; }

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

    public string? RtsFullname { get; set; }

    public string? RtsCompanyname { get; set; }

    public string? RtsAddressline1 { get; set; }

    public string? RtsAddressline2 { get; set; }

    public string? RtsSuburb { get; set; }

    public string? RtsPostcode { get; set; }

    public string? RtsState { get; set; }

    public string? RtsCountry { get; set; }

    public string? OrderId { get; set; }

    public string? OrderLineItem { get; set; }

    public int? OrderLineItemQty { get; set; }

    public string? OrderOnplan { get; set; }

    public string? OrderPlantype { get; set; }

    public string? OrderDiscount { get; set; }

    public string? OrderComplimentary { get; set; }

    public string? OrderDate { get; set; }

    public string? OrderDeliveryHistory { get; set; }

    public string? OrderDeliveryNote { get; set; }

    public string? ProductId { get; set; }

    public string? ProductPackage { get; set; }

    public string? ProductName { get; set; }

    public string? ProductDescription { get; set; }

    public string? ProductCategory { get; set; }

    public string? ProductPrintvalue { get; set; }

    public string? ProductPricetype { get; set; }

    public string? ProductTickettype { get; set; }

    public string? ProductSpecialtext { get; set; }

    public string? ProductChoice1 { get; set; }

    public string? ProductChoice2 { get; set; }

    public string? BarcodeValue { get; set; }

    public string? BarcodeAdditional { get; set; }

    public string? BarcodePrintCount { get; set; }

    public string? BarcodePrintDate { get; set; }

    public string? BarcodeAdditional2 { get; set; }

    public string? Venue1Name { get; set; }

    public string? Venue1Fulldetail { get; set; }

    public string? Venue1Gate { get; set; }

    public string? Venue1Stand { get; set; }

    public string? Venue1Aisle { get; set; }

    public string? Venue1Section { get; set; }

    public string? Venue1Row { get; set; }

    public string? Venue1Seat { get; set; }

    public string? Venue2Name { get; set; }

    public string? Venue2Fulldetail { get; set; }

    public string? Venue2Gate { get; set; }

    public string? Venue2Stand { get; set; }

    public string? Venue2Aisle { get; set; }

    public string? Venue2Section { get; set; }

    public string? Venue2Row { get; set; }

    public string? Venue2Seat { get; set; }

    public string? Venue3Name { get; set; }

    public string? Venue3Fulldetail { get; set; }

    public string? Venue3Gate { get; set; }

    public string? Venue3Stand { get; set; }

    public string? Venue3Aisle { get; set; }

    public string? Venue3Section { get; set; }

    public string? Venue3Row { get; set; }

    public string? Venue3Seat { get; set; }

    public string? Venue4Name { get; set; }

    public string? Venue4Fulldetail { get; set; }

    public string? Venue4Gate { get; set; }

    public string? Venue4Stand { get; set; }

    public string? Venue4Aisle { get; set; }

    public string? Venue4Section { get; set; }

    public string? Venue4Row { get; set; }

    public string? Venue4Seat { get; set; }

    public string? OtherInfo1 { get; set; }

    public string? OtherInfo2 { get; set; }

    public string? OtherInfo3 { get; set; }

    public string? OtherInfo4 { get; set; }

    public string? OtherInfo5 { get; set; }

    public string? OtherInfo6 { get; set; }

    public string? OtherInfo7 { get; set; }

    public string? OtherInfo8 { get; set; }

    public string? OtherInfo9 { get; set; }

    public string? OtherInfo10 { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? LastUpdatedDate { get; set; }

    public int? LastUpdatedBy { get; set; }

    public bool? IsActive { get; set; }

    public bool? Approved { get; set; }
}

