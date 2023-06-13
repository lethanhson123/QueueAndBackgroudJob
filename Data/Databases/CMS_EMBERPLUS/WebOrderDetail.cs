namespace Data.Databases.CMS_EMBERPLUS;

public partial class WebOrderDetail : BaseModel
{
    public long Id { get; set; }

    public long? OrderId { get; set; }

    public decimal? Total { get; set; }

    public decimal? SubTotal { get; set; }

    public decimal? Gst { get; set; }

    public decimal? TotalGst { get; set; }

    public decimal? Discount { get; set; }

    public decimal? TotalDiscount { get; set; }

    public int? DiscountType { get; set; }

    public int? Quantity { get; set; }

    public decimal? Price { get; set; }

    public string? Sku { get; set; }

    public long? ProductId { get; set; }

    public decimal? Weight { get; set; }

    public decimal? Height { get; set; }

    public decimal? Width { get; set; }

    public decimal? Length { get; set; }

    public decimal? ShippingPrice { get; set; }

    public decimal? ShippingSubTotalPrice { get; set; }

    public decimal? ShippingTotalPrice { get; set; }

    public string? Image { get; set; }

    public string? Name { get; set; }

    public string? TargetView { get; set; }

    public bool? ReturnQty { get; set; }

    public string? PathQuery { get; set; }

    public int? ProductType { get; set; }

    public int? PrimaryWh { get; set; }

    public string? PersonalizedLetter { get; set; }

    public string? PersonalizedData { get; set; }

    public bool? IsPackItem { get; set; }

    public string? Group { get; set; }

    public bool? IsRedeem { get; set; }

    public decimal? RedeemValue { get; set; }

    public long? RedeemId { get; set; }

    public string? RedeemRawData { get; set; }
}

