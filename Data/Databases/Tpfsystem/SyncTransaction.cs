namespace Data.Databases.Tpfsystem;
public partial class SyncTransaction : BaseModel
{
    public long Id { get; set; }

    public string SyncType { get; set; } = null!;

    public string Status { get; set; } = null!;

    public int TotalItem { get; set; }

    public int TotalError { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? FinishedDate { get; set; }
}

