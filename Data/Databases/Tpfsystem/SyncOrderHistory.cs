namespace Data.Databases.Tpfsystem;

public partial class SyncOrderHistory : BaseModel
{
    public long Id { get; set; }

    public long SyncTransactionId { get; set; }

    /// <summary>
    /// Order Number or ocid
    /// </summary>
    public long OrderId { get; set; }

    public long TpforderId { get; set; }

    public string Status { get; set; } = null!;
}

