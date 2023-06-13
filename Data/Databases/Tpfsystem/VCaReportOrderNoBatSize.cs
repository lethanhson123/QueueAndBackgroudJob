namespace Data.Databases.Tpfsystem;

public partial class VCaReportOrderNoBatSize : BaseModel
{
    public long? TpforderId { get; set; }

    public string EntityId { get; set; } = null!;

    public string? EntityName { get; set; }

    public string? ProgramRefId { get; set; }

    public string? PlayerId { get; set; }

    public string? PlayerFirstName { get; set; }

    public string? PlayerLastName { get; set; }

    public string? PlayerCategory { get; set; }

    public string? BatSize { get; set; }
}

