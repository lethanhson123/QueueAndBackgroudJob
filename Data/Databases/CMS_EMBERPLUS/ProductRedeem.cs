namespace Data.Databases.CMS_EMBERPLUS;

public partial class ProductRedeem : BaseModel
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public int? Status { get; set; }

    public string? CreateBy { get; set; }

    public string? CreatebyName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? Description { get; set; }

    public string? UserId { get; set; }

    public long? ProductId { get; set; }

    public long? ProductId1 { get; set; }

    public long? ProductId2 { get; set; }

    public int? Redeemed { get; set; }

    public int? Redeem { get; set; }

    public int? RedeemAvailable { get; set; }

    public int? RedeemValue { get; set; }

    public string? RedeemRawData { get; set; }

    public DateTime? RedeemAutoDeadLine { get; set; }

    public bool? RedeemReject { get; set; }

    public bool? RedeemHidden { get; set; }

    public bool? IsNotOptOut { get; set; }

    public string? DefaultItemSelection { get; set; }
}

