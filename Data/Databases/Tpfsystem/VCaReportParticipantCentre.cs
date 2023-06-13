namespace Data.Databases.Tpfsystem;

public partial class VCaReportParticipantCentre : BaseModel
{
    public string? EntityId { get; set; }

    public string? EntityName { get; set; }

    public string? EntityState { get; set; }

    public string? ProgramId { get; set; }

    public DateTime? ProgramStartDate { get; set; }

    public DateTime? DeliveryDate1 { get; set; }

    public DateTime? DeliveryDate2 { get; set; }

    public int? Participants { get; set; }

    public int? BatsSent { get; set; }

    public string NextSend { get; set; } = null!;

    public int? BatsToSend { get; set; }

    public string Date1Order { get; set; } = null!;

    public long? Date1OrderChecking { get; set; }

    public long? Date2Order { get; set; }

    public int Direct { get; set; }

    public int? Bulk { get; set; }

    public string Date1Tracking { get; set; } = null!;

    public string TrackingNo { get; set; } = null!;
}

