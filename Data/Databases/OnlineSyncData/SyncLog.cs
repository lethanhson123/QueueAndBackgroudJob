namespace Data.Databases.OnlineSyncData;

public partial class SyncLog : BaseModel
{
    public int Id { get; set; }

    public string? MachineName { get; set; }

    public DateTime Logged { get; set; }

    public string Level { get; set; } = null!;

    public string Message { get; set; } = null!;

    public string? Logger { get; set; }

    public string GroupLog { get; set; } = null!;

    public string? RefKey { get; set; }

    public long? AccountId { get; set; }

    public string? Properties { get; set; }

    public string? Callsite { get; set; }

    public string? Exception { get; set; }

    public bool IsSent { get; set; }

    public int? StoreId { get; set; }
}

