namespace Data.Databases.OnlineSyncData;

public partial class StoreWebsite : BaseModel
{
    public int Id { get; set; }

    public string? StoreName { get; set; }

    public int CatalogueId { get; set; }

    public string ApiId { get; set; } = null!;

    public string ApiKey { get; set; } = null!;

    public string StoreApiurl { get; set; } = null!;

    public string? Url { get; set; }

    /// <summary>
    /// NA=&gt;0
    /// Magento=&gt;1
    /// Magento2=&gt;2
    /// CA=&gt;3
    /// NetSetGo=&gt;4
    /// </summary>
    public int Type { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    /// <summary>
    /// NA = 0,
    /// InventorySync = 1,
    /// OrderSync = 2,
    /// ClientSync = 3,
    /// TurnOffStockSync = 4,
    /// OrderPaid = 5,
    /// TurnOffOrderSync = 6,
    /// RequestSyncStock = 7,
    /// DeliveryAddressSync = 8,
    /// </summary>
    public string? Roles { get; set; }

    /// <summary>
    /// use Primary Warehouse to be default
    /// </summary>
    public int IsPrimaryWarehouse { get; set; }

    public string? StoreStatus { get; set; }

    public string? Ftpuser { get; set; }

    public string? Ftppassword { get; set; }

    public string? Ftplink { get; set; }
}

