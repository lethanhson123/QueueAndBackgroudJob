namespace Data.Databases.Tpfsystem;

public partial class VCaReportValidationPlayerProduct : BaseModel
{
    public string? PlayerId { get; set; }

    public string? CaEntityId { get; set; }

    public string? ProgramRefId { get; set; }

    public string? ErrorReason { get; set; }
}

