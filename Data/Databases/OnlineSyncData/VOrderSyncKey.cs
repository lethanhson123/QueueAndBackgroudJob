namespace Data.Databases.OnlineSyncData;

public partial class VOrderSyncKey : BaseModel
{
    public string? Ponumber { get; set; }

    public Guid? Rguid { get; set; }

    public long TpfOrderId { get; set; }
}

