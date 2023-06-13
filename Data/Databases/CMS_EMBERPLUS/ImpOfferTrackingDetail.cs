namespace Data.Databases.CMS_EMBERPLUS;

public partial class ImpOfferTrackingDetail : BaseModel
{
    public long Id { get; set; }

    public long OfferId { get; set; }

    public string? UserId { get; set; }

    public DateTime? Clicked { get; set; }

    public string? Ipclient { get; set; }
}

