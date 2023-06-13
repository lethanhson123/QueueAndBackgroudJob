namespace Data.Databases.CMS_EMBERPLUS;

public partial class CheckoutShipping : BaseModel
{
    public long Id { get; set; }

    public string? ShippingCalculator { get; set; }

    public int? ShippingType { get; set; }

    public string? WidgetId { get; set; }

    public int? Status { get; set; }

    public string? CreateBy { get; set; }

    public string? CreatebyName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? Description { get; set; }

    public string? Title { get; set; }

    public decimal? Price { get; set; }

    public bool? IsDefault { get; set; }

    public int? Index { get; set; }
}
