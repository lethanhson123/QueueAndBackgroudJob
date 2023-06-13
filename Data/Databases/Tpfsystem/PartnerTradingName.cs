namespace Data.Databases.Tpfsystem;

public partial class PartnerTradingName : BaseModel
{
    public long TnId { get; set; }

    public long AccId { get; set; }

    public string Tradingname { get; set; } = null!;

    public DateTime? Createddate { get; set; }

    public int? Createby { get; set; }

    public DateTime? Updatedate { get; set; }

    public int? Updateby { get; set; }

    public string Status { get; set; } = null!;
}

