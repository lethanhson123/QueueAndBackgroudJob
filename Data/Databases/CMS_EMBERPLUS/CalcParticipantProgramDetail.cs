namespace Data.Databases.CMS_EMBERPLUS;

public partial class CalcParticipantProgramDetail : BaseModel
{
    public long Id { get; set; }

    public long? TpforderId { get; set; }

    public string? TpfproductCode { get; set; }

    public string? TpfproductName { get; set; }

    public int? Tpfquantity { get; set; }

    public int? TpfwarehouseId { get; set; }

    public bool? IsRedeem { get; set; }

    public string? OrderId { get; set; }

    public string? OrderItemLine { get; set; }

    public string? ProductId { get; set; }

    public string? ProductCode { get; set; }

    public string? ProductName { get; set; }

    public int? Quantity { get; set; }

    public string? OtherInfo1 { get; set; }

    public string? OtherInfo2 { get; set; }

    public string? OtherInfo3 { get; set; }

    public string? OtherInfo4 { get; set; }
}
