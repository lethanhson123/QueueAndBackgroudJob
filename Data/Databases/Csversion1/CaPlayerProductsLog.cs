namespace Data.Databases.Csversion1;

public partial class CaPlayerProductsLog : BaseModel
{
    public int Id { get; set; }

    public string? TpfprodId { get; set; }

    public string? Colours { get; set; }

    public string? Size { get; set; }

    public string? Input { get; set; }

    public string? ProgramRefId { get; set; }

    public string? PlayerId { get; set; }

    public string? CaEntityId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? Status { get; set; }

    public int? TransId { get; set; }

    public bool? IsUpdate { get; set; }

    public string? ManualReg { get; set; }

    public bool? IsSend { get; set; }

    public bool? IsUpdateLog { get; set; }

    public bool? IsNewllogs { get; set; }

    public int? TransIdlogs { get; set; }
}

