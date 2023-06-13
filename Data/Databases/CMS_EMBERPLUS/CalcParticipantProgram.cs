namespace Data.Databases.CMS_EMBERPLUS;

public partial class CalcParticipantProgram : BaseModel
{
    public long Id { get; set; }

    public long CalcParticipantId { get; set; }

    public long CalcProgramId { get; set; }

    public int? TranId { get; set; }

    public long? TpforderId { get; set; }

    public DateTime? TpforderSyncDate { get; set; }

    public string? TpftrackingNumber { get; set; }

    public string? Tpfcarrier { get; set; }

    public DateTime? TpforderDate { get; set; }

    public string? TpforderBy { get; set; }

    public string? TpforderStatus { get; set; }

    public string? TpfrejectStatus { get; set; }

    public string? TpfrejectNotes { get; set; }

    public string? TpfrejectUpdatedStatus { get; set; }

    public int? Status { get; set; }
}
