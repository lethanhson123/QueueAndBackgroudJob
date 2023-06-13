namespace Data.Databases.Tpfsystem;

public partial class VCaReportParticipantSentPlayer : BaseModel
{
    public string ParticipantKey { get; set; } = null!;

    public string? EntityId { get; set; }

    public string? EntityName { get; set; }

    public string? EntityState { get; set; }

    public string? ProgramId { get; set; }

    public string? ProgramStartDate { get; set; }

    public string? PlayerId { get; set; }

    public string? PlayerFirstName { get; set; }

    public string? PlayerLastName { get; set; }

    public string? BatSize { get; set; }

    public string? OrderNumber { get; set; }

    public long? TpforderId { get; set; }

    public string? TrackingNo { get; set; }

    public string? CarrierName { get; set; }

    public string? CarrierUrl { get; set; }

    public string OrderStatus { get; set; } = null!;

    public DateTime? OrderSendDate { get; set; }

    public DateTime? OrderEtadate { get; set; }

    public string? PlayerCategory { get; set; }

    public string? FirstTime { get; set; }

    public string? Bblclub { get; set; }

    public string? PackChoice { get; set; }

    public string? ShirtSize { get; set; }

    public string? ShirtName { get; set; }

    public string? TextToSearch { get; set; }
}

