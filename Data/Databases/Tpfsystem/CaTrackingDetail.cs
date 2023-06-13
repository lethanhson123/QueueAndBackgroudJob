namespace Data.Databases.Tpfsystem;

public partial class CaTrackingDetail : BaseModel
{
    public long Id { get; set; }

    public int TrackingId { get; set; }

    public decimal ProdetailId { get; set; }

    public string InvCode { get; set; } = null!;

    public int Qty { get; set; }

    public string? TrackingNo { get; set; }
}

