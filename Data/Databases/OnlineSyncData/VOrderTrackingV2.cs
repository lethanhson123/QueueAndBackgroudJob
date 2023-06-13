namespace Data.Databases.OnlineSyncData;

public partial class VOrderTrackingV2 : BaseModel
{
    public long Id { get; set; }

    public long TpfOrderId { get; set; }

    public int StoreId { get; set; }

    public int StoreType { get; set; }

    public int CatalogueId { get; set; }

    public string? CatalogueName { get; set; }

    public string ApiId { get; set; } = null!;

    public string? PoNumber { get; set; }

    public int PendingDuration { get; set; }

    public string DelStatus { get; set; } = null!;

    public string? OrderStatus { get; set; }

    public int SyncStatus { get; set; }

    public string Status { get; set; } = null!;

    public int SyncDelStatus { get; set; }

    public DateTime? LastSyncDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public DateTime CreatedDate { get; set; }

    public long? DelId { get; set; }

    public long? DelRefNo { get; set; }

    public string? TrackingNo { get; set; }

    public string? CarrierName { get; set; }

    public string? CarrierUrl { get; set; }

    public DateTime? ProcessedDate { get; set; }

    public int? Whid { get; set; }

    public Guid? Rguid { get; set; }
}

