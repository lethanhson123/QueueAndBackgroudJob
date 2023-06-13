namespace Data.Databases.Csversion1;

public partial class StockCheckpl : BaseModel
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public long ProdetailId { get; set; }

    public int Whid { get; set; }

    public long Onhand { get; set; }

    public double UnsyncedQty { get; set; }

    public double? OnlineAvailable { get; set; }
}

