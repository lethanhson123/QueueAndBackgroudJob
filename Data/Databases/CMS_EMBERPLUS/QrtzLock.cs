namespace Data.Databases.CMS_EMBERPLUS;

public partial class QrtzLock : BaseModel
{
    public string SchedName { get; set; } = null!;

    public string LockName { get; set; } = null!;
}

