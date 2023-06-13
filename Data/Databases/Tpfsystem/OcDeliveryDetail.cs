namespace Data.Databases.Tpfsystem;

public partial class OcDeliveryDetail : BaseModel
{
    public long DelDetailId { get; set; }

    public long DelorderId { get; set; }

    public long? Ocid { get; set; }

    public long? Spid { get; set; }

    public long? Ocdetailid { get; set; }

    public long? SizeId { get; set; }

    public string? Delproname { get; set; }

    public double? Delqty { get; set; }

    public double? Unitprice { get; set; }

    public string? Note { get; set; }

    public string? Modtrack { get; set; }

    public long? Prodetailid { get; set; }

    public string? Invcode { get; set; }

    public string? Itemtype { get; set; }

    public long? Itemcatalogueid { get; set; }

    public string? Tpfcode { get; set; }

    /// <summary>
    /// sum up ocdeltrandetails.delqty
    /// </summary>
    public double? Qtysent { get; set; }

    /// <summary>
    /// for partly-packed to fully-packed
    /// </summary>
    public double? OrgDelqty { get; set; }

    public double? Unitgst { get; set; }

    public double? ItemWeight { get; set; }

    public int? StockReservingId { get; set; }

    public virtual OcDeliveryOrder Delorder { get; set; } = null!;
}

