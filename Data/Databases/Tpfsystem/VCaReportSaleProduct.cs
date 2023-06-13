namespace Data.Databases.Tpfsystem;
public partial class VCaReportSaleProduct : BaseModel
{
    public string? ProductName { get; set; }

    public string? InventoryCode { get; set; }

    public int? Qty { get; set; }

    public double? Sale { get; set; }

    public string OrderType { get; set; } = null!;
}

