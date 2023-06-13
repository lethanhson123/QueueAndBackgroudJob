namespace Data.Databases.Csversion1;

public partial class CaPlayer : BaseModel
{
    public int Id { get; set; }

    public int? EntityId { get; set; }

    public string? PlayerId { get; set; }

    public string? PlayerFirstName { get; set; }

    public string? PlayerLastName { get; set; }

    public string? DeliveryName { get; set; }

    public string? DeliveryAddress { get; set; }

    public string? DeliverySuburb { get; set; }

    public string? DeliveryState { get; set; }

    public string? DeliveryPostcode { get; set; }

    public string? DeliveryContactNumber { get; set; }

    public string? DeliveryContactEmail { get; set; }

    public string? BblTeam { get; set; }

    public string? PlayerCategory { get; set; }

    public string? ShirtSize { get; set; }

    public string? PackType { get; set; }

    public string? PinkShirt { get; set; }

    public string? PaymentMethod { get; set; }

    public string? PaymentStatus { get; set; }

    public string? ParticipantRegistered { get; set; }

    public string? ParticipantPaid { get; set; }

    public string? RegistrationDate { get; set; }

    public string? Address1 { get; set; }

    public string? Suburb { get; set; }

    public string? Postcode { get; set; }

    public string? State { get; set; }

    public string? ProgramTypeOptionFlags { get; set; }

    public string? BatSize { get; set; }

    public string? ShirtName { get; set; }

    public string? PlayerType { get; set; }

    public string? Country { get; set; }

    public string? BatSenddate { get; set; }

    public string? BatSendconnote { get; set; }

    public string? BatSendaddtype { get; set; }

    public string? IsCounted { get; set; }

    public string? Status { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? ProgramRefId { get; set; }

    public string? ProgramStartDate { get; set; }

    public long? TpforderId { get; set; }

    public string? Notes { get; set; }

    public string? PackChoice { get; set; }

    public string? ParentFirstName { get; set; }

    public string? ParentLastName { get; set; }

    public string? DeliveryCountry { get; set; }

    public string? FirstTime { get; set; }

    public string? UpdateStatus { get; set; }

    public string? RejectionStatus { get; set; }

    public string? RejectionNote { get; set; }

    public string? CodeSeason { get; set; }

    public string? ManualReg { get; set; }

    public string? IsExpressDelivery { get; set; }

    public string? AccountId { get; set; }

    public string? DeliveryAddress2 { get; set; }

    public string? OrderId { get; set; }

    public string? OrderDate { get; set; }

    public bool? IsActive { get; set; }

    public bool? Approved { get; set; }

    public string? CreateBy { get; set; }
}

