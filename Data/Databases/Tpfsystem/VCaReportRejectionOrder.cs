namespace Data.Databases.Tpfsystem;

public partial class VCaReportRejectionOrder : BaseModel
{
    public long Id { get; set; }

    public string? NumberId { get; set; }

    public string RejectionType { get; set; } = null!;

    public string? ErrorReason { get; set; }

    public DateTime? LastModified { get; set; }

    public string RejectionStatus { get; set; } = null!;

    public string? TextToSearch { get; set; }
}

