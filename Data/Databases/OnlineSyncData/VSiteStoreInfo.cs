namespace Data.Databases.OnlineSyncData;

public partial class VSiteStoreInfo : BaseModel
{
    public int StoreSiteId { get; set; }

    public string StoreName { get; set; } = null!;

    public int CatalogueId { get; set; }

    public string? CatalogueName { get; set; }

    public string? MagentoKey { get; set; }

    public bool? Active { get; set; }

    public long? CashClientId { get; set; }

    public long? HandledBy { get; set; }

    public int? TaxRate { get; set; }

    public string Currency { get; set; } = null!;

    public string ApiId { get; set; } = null!;

    public string ApiKey { get; set; } = null!;

    public int StoreType { get; set; }

    public string? Url { get; set; }

    public string StoreApiurl { get; set; } = null!;

    public string? Roles { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? UsedPrimaryWh { get; set; }

    public string? StoreStatus { get; set; }

    public string? Ftpuser { get; set; }

    public string? Ftppassword { get; set; }

    public string? Ftplink { get; set; }
}

