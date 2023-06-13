namespace Data.Databases.CMS_EMBERPLUS;

public partial class QrtzBlobTrigger : BaseModel
{
    public string SchedName { get; set; } = null!;

    public string TriggerName { get; set; } = null!;

    public string TriggerGroup { get; set; } = null!;

    public byte[]? BlobData { get; set; }
}

