namespace Data.Databases.CMS_EMBERPLUS;

public partial class ProductPriceBak : BaseModel
{
    public int Id { get; set; }

    public long ProId { get; set; }

    public int? UserTypeId { get; set; }

    public double CurrentPrice { get; set; }

    public double? WasPrice { get; set; }

    public string? Currency { get; set; }

    public double? TaxRate { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public int? Status { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public string? CreateByName { get; set; }

    public DateTime LastUpdateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }
}

