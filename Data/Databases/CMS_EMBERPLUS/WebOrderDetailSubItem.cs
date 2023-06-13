namespace Data.Databases.CMS_EMBERPLUS;

public partial class WebOrderDetailSubItem : BaseModel
{
    public long Id { get; set; }

    public long? OrderDetailId { get; set; }

    public int? Quantity { get; set; }

    public string? Sku { get; set; }

    public long? ProductId { get; set; }

    public decimal? Weight { get; set; }

    public decimal? TotalWeight { get; set; }

    public int? ProductType { get; set; }

    public string? Name { get; set; }

    public string? TargetView { get; set; }

    public int? PrimaryWh { get; set; }
}

