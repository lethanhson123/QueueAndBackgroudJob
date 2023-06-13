namespace Data.Databases.CMS_EMBERPLUS;
public partial class Product : BaseModel
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

	public DateTime? LastUpdateDate { get; set; }

	public int? CompanyId { get; set; }

	public long CategoryId { get; set; }

	public long? ProductId { get; set; }

	public long? Skuid { get; set; }

	public long? VirtualId { get; set; }

	public string? VirtualCode { get; set; }

	public string? InternalCode { get; set; }

	public string? InventoryCode { get; set; }

	public bool? IsView { get; set; }

	public bool? IsNew { get; set; }

	public bool? IsGst { get; set; }

	public bool? IsPreOrder { get; set; }

	public int? PreOrderLimit { get; set; }

	public int? Index { get; set; }

	public string? ProductStatus { get; set; }

	public int? ProductType { get; set; }

	public decimal? Weight { get; set; }

	public decimal? Width { get; set; }

	public decimal? Height { get; set; }

	public decimal? Length { get; set; }

	public int? Available { get; set; }

	public int? OnStock { get; set; }

	public int? OnOrder { get; set; }

	public int? PrimaryWh { get; set; }

	public bool? IsSync { get; set; }

	public bool? IsSyncWeight { get; set; }

	public bool? IsSyncDimension { get; set; }

	public bool? IsSyncStock { get; set; }

	public bool? IsRedeem { get; set; }

	public decimal? CreditValue { get; set; }

	public DateTime? FromDate { get; set; }

	public DateTime? ToDate { get; set; }

	public string? BaseCode { get; set; }

	public int? TypeSelect { get; set; }

	public bool? IsDynamicPrice { get; set; }
}



