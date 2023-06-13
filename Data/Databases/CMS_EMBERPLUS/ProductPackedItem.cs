namespace Data.Databases.CMS_EMBERPLUS;

public partial class ProductPackedItem : BaseModel
{
    public long Id { get; set; }

    public string? Title { get; set; }

    public int? Status { get; set; }

    public string? CreateBy { get; set; }

    public string? CreatebyName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? Description { get; set; }

    public long? ProductId { get; set; }

    public long? ProductItemId { get; set; }

    public double? Quantity { get; set; }

    public int? ProductType { get; set; }

    public int? Index { get; set; }

    public bool? IsShowText { get; set; }

    public bool? IsOptOut { get; set; }

    public bool? IsNameDisplay { get; set; }
}

