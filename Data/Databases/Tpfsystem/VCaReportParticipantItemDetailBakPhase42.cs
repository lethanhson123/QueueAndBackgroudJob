namespace Data.Databases.Tpfsystem;

public partial class VCaReportParticipantItemDetailBakPhase42 : BaseModel
{
    public long? RefId { get; set; }

    public string TpfuniqueId { get; set; } = null!;

    public int? TransId { get; set; }

    public long? EntityId { get; set; }

    public string? ProgramId { get; set; }

    public string? PlayerId { get; set; }

    public string? PlayerFirstName { get; set; }

    public string? PlayerLastName { get; set; }

    public string? DeliveryPostcode { get; set; }

    public long? ParticipantOrderId { get; set; }

    public DateTime? DispatchDate { get; set; }

    public string? CarrierName { get; set; }

    public string? TrackingNo { get; set; }

    public string? ProductCode { get; set; }

    public string? ProductName { get; set; }

    public int? Quantity { get; set; }
}

