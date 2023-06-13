namespace Data.Databases.CMS_EMBERPLUS;

public partial class ProductCombineMap : BaseModel
{
    public long Id { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public int? Status { get; set; }

    public string? CreateBy { get; set; }

    public string? CreatebyName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime LastUpdateDate { get; set; }

    public long? ProductCombineId { get; set; }

    public string? Value { get; set; }

    public string? ParentTitle { get; set; }

    public long? Sku { get; set; }

    public long? ProductId { get; set; }
}

