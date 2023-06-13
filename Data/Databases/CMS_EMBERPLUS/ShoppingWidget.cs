namespace Data.Databases.CMS_EMBERPLUS;

public partial class ShoppingWidget : BaseModel
{
    public string Id { get; set; } = null!;

    public string? Template { get; set; }

    public int? ShippingType { get; set; }

    public string? ShippingCalculator { get; set; }
	public List<Data.Databases.CMS_EMBERPLUS.WidgetTemplateMode> TemplateModes { get; set; }
}

