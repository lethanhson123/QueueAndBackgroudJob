namespace Data.Databases.Tpfsystem;

public partial class VSyncHistory : BaseModel
{
    public long TransactionId { get; set; }

    public string SyncType { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public DateTime? FinishedDate { get; set; }

    public int TotalItem { get; set; }

    public int TotalError { get; set; }
}

