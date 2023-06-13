namespace Data.Databases.Tpfsystem;

public partial class VCaReportParticipantItemDetail : BaseModel
{
    public long RefId { get; set; }

    public string TpfuniqueId { get; set; } = null!;

    public int TransId { get; set; }

    public string EntityId { get; set; } = null!;

    public string ProgramId { get; set; } = null!;

    public string PlayerId { get; set; } = null!;

    public string? PlayerFirstName { get; set; }

    public string? PlayerCategory { get; set; }

    public string? FirstTime { get; set; }

    public string? DeliveryPostcode { get; set; }

    public long ParticipantOrderId { get; set; }

    public string? DispatchDate { get; set; }

    public string? CarrierName { get; set; }

    public string? TrackingNo { get; set; }

    public string ProductCode { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public int Quantity { get; set; }

    public string? BblTeam { get; set; }

    public string? ShirtSize { get; set; }

    public string? BatSize { get; set; }
}

