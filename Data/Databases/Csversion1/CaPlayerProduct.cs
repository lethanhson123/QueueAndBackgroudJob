namespace Data.Databases.Csversion1;

public partial class CaPlayerProduct : BaseModel
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

    public string? OrderId { get; set; }

    public string? OrderLineItem { get; set; }

    public int? OrderLineItemQty { get; set; }

    public string? ProcessMethod { get; set; }

    public string? ProgramType { get; set; }

    public bool? IsSendProid { get; set; }

    public int? StatusCode { get; set; }

    public bool? IsHold { get; set; }

    public int? GroupTrainId { get; set; }
}

