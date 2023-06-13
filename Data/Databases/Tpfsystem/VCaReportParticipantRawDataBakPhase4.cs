namespace Data.Databases.Tpfsystem;

public partial class VCaReportParticipantRawDataBakPhase4 : BaseModel
{
    public long RawRefId { get; set; }

    public string TpfuniqueId { get; set; } = null!;

    public int? TransId { get; set; }

    public long EntityId { get; set; }

    public string? EntityName { get; set; }

    public string? ProgramId { get; set; }

    public string? PlayerId { get; set; }

    public string? PlayerFirstName { get; set; }

    public string? PlayerLastName { get; set; }

    public string? DeliveryPostcode { get; set; }

    public string? Bblteam { get; set; }

    public string? PlayerCategory { get; set; }

    public string? ShirtSize { get; set; }

    public string PackType { get; set; } = null!;

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

    public DateTime? TpfreceivedDate { get; set; }

    public string? RejectionNote { get; set; }

    public DateTime? SubmitDate { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public DateTime? ProcessedDate { get; set; }

    public DateTime? InTransitDate { get; set; }

    public DateTime? DispatchDate { get; set; }

    public string? CarrierName { get; set; }

    public string? TrackingNo { get; set; }

    public string TextToSearch { get; set; } = null!;
}

