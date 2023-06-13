namespace Data.Databases.Tpfsystem;

public partial class VCaReportRejectionPlayer : BaseModel
{
    public int Id { get; set; }

    public string NumberId { get; set; } = null!;

    public string RejectionType { get; set; } = null!;

    public string? ErrorReason { get; set; }

    public string? RejectionStatus { get; set; }

    public DateTime? LastModified { get; set; }

    public string TextToSearch { get; set; } = null!;
}

