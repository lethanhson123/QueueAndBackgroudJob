namespace Data.Databases.Tpfsystem;

public partial class VCaReportOrderAddressIssue : BaseModel
{
    public long OrderNumber { get; set; }

    public long? TpforderId { get; set; }

    public string? OrderGroup { get; set; }

    public string? OrderStatus { get; set; }

    public string? EntityId { get; set; }

    public string? EntityName { get; set; }

    public string? EntityState { get; set; }

    public string? EntityType { get; set; }

    public string? PlayerId { get; set; }

    public string PlayerName { get; set; } = null!;

    public string? DFname { get; set; }

    public string? DLname { get; set; }

    public string? DAttention { get; set; }

    public string? DAddr1 { get; set; }

    public string? DAddr2 { get; set; }

    public string? DAddr { get; set; }

    public string? DPostcode { get; set; }

    public string? DCountry { get; set; }

    public string? DEmail { get; set; }
}

