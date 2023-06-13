namespace Data.Databases.CMS_EMBERPLUS;

public partial class Warehouse : BaseModel
{
    public string Id { get; set; } = null!;

    public int? Whid { get; set; }

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

    public bool? IsStockSync { get; set; }

    public bool? IsDispatchedSync { get; set; }

    public bool? IsProviderSync { get; set; }

    public string? Whurl { get; set; }

    public int? Whstatus { get; set; }

    public string? WhType { get; set; }

    public string? Tpfwhid { get; set; }

    public string? TpfcatalogueId { get; set; }

    public string? Addr1 { get; set; }

    public string? Addr2 { get; set; }
}

