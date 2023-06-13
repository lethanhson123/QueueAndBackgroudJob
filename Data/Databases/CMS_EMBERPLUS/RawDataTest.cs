namespace Data.Databases.CMS_EMBERPLUS;

public partial class RawDataTest : BaseModel
{
    public string Id { get; set; } = null!;

    public long? UploadId { get; set; }

    public string? EmpGroupId { get; set; }

    public string? EmpUserId { get; set; }

    public string? Test { get; set; }
}

