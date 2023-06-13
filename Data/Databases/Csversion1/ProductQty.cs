namespace Data.Databases.Csversion1;

public partial class ProductQty : BaseModel
{
    public int Id { get; set; }

    public int Prodetailid { get; set; }

    public int Whid { get; set; }

    public long Available { get; set; }

    public long Onhand { get; set; }

    public long Onorder { get; set; }

    public long Oncustorder { get; set; }

    public long Onbackorder { get; set; }

    public long Onreorder { get; set; }

    public long Onreturns { get; set; }

    public DateTime? Lastupdate { get; set; }

    public int? LastLocationStockId { get; set; }

    public DateTime? Createdate { get; set; }
}

