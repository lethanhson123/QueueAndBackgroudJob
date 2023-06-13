namespace Data.Databases.CMS_EMBERPLUS;

public partial class QrtzSchedulerState : BaseModel
{
    public string SchedName { get; set; } = null!;

    public string InstanceName { get; set; } = null!;

    public long LastCheckinTime { get; set; }

    public long CheckinInterval { get; set; }
}

