namespace Data.Databases.CMS_EMBERPLUS;

public partial class QrtzPausedTriggerGrp : BaseModel
{
    public string SchedName { get; set; } = null!;

    public string TriggerGroup { get; set; } = null!;
}

