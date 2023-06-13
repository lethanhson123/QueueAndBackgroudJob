namespace Data.Databases.Tpfsystem;

public partial class ZRosaCaPlayer : BaseModel
{
    public int Id { get; set; }

    public int? EntityId { get; set; }

    public string? PlayerId { get; set; }

    public string? Status { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? ProgramRefId { get; set; }

    public string? ProgramStartDate { get; set; }

    public string? UpdateStatus { get; set; }

    public string? RejectionStatus { get; set; }

    public string? RejectionNote { get; set; }

    public string? RecordStatusNotes { get; set; }
}

