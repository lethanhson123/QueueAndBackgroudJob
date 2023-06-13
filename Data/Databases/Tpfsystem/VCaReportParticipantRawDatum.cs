namespace Data.Databases.Tpfsystem;

public partial class VCaReportParticipantRawDatum : BaseModel
{
    public long RawRefId { get; set; }

    public string? TpfuniqueId { get; set; }

    public int? TransId { get; set; }

    public string EntityId { get; set; } = null!;

    public string? EntityName { get; set; }

    public string? ProgramId { get; set; }

    public string? PlayerId { get; set; }

    public string? PlayerFirstName { get; set; }

    public string? PlayerLastName { get; set; }

    public string? DeliveryPostcode { get; set; }

    public string? Bblteam { get; set; }

    public string? PlayerCategory { get; set; }

    public string? ShirtSize { get; set; }

    public string? PackType { get; set; }

    public string? PackChoice { get; set; }

    public string? BatSize { get; set; }

    public string? ShirtName { get; set; }

    public string? FirstTime { get; set; }

    public string? ManualReg { get; set; }

    public string? IsExpressDelivery { get; set; }

    public string? TpfprodId { get; set; }

    public string? TpfprodDesc { get; set; }

    public string? Colours { get; set; }

    public string? Size { get; set; }

    public string? Input { get; set; }

    public string? RegistrationDate { get; set; }

    public string? TpfreceivedDate { get; set; }

    public string? RejectionNote { get; set; }

    public string? SubmitDate { get; set; }

    public string? ApprovedDate { get; set; }

    public string? ProcessedDate { get; set; }

    public string? InTransitDate { get; set; }

    public string? DispatchDate { get; set; }

    public string? CarrierName { get; set; }

    public string? TrackingNo { get; set; }

    public string? OrderStatus { get; set; }

    public string TextToSearch { get; set; } = null!;
}

