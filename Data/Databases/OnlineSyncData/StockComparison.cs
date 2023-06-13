namespace Data.Databases.OnlineSyncData;

public partial class StockComparison : BaseModel
{
    public long Id { get; set; }

    public string ExternalCode { get; set; } = null!;

    public string InternalCode { get; set; } = null!;

    public int CatalogueId { get; set; }

    public string StoreId { get; set; } = null!;

    public bool IsVirtualProduct { get; set; }

    public int ChoosePrimaryWh { get; set; }

    public int ExternalAvailable { get; set; }

    public int Available { get; set; }

    public bool? IsChecked { get; set; }

    /// <summary>
    /// Stock Status or Status in the Inventory System
    /// </summary>
    public string? StockStatus { get; set; }

    /// <summary>
    /// Item could be in backorder
    /// </summary>
    public bool? IsBackOrder { get; set; }

    public string? Reason { get; set; }

    public DateTime? LastSyncDate { get; set; }

    public DateTime CreatedDate { get; set; }
}

