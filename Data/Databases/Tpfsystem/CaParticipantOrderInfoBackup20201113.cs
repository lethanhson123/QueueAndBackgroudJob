namespace Data.Databases.Tpfsystem;

public partial class CaParticipantOrderInfoBackup20201113 : BaseModel
{
    public long Id { get; set; }

    public string ParticipantKey { get; set; } = null!;

    public string ProgramRefId { get; set; } = null!;

    public string PlayerId { get; set; } = null!;

    public int TransId { get; set; }

    public long? ParticipantOrderId { get; set; }

    public string? TrackingNo { get; set; }

    public string? CarrierName { get; set; }

    public string? CarrierUrl { get; set; }

    public string? RefNo { get; set; }

    public string? RecordStatus { get; set; }

    public string? RecordStatusNotes { get; set; }

    public string? OrderStatus { get; set; }

    public string? OrderStatusNote { get; set; }

    public DateTime? SubmitDate { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public DateTime? OrderCreatedDate { get; set; }

    public DateTime? OrderSendDate { get; set; }

    public DateTime? FfestArrivalDate { get; set; }

    public DateTime? OrderEtadate { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }
}

