namespace Data.Databases.CMS_EMBERPLUS;

public partial class QrtzSimpleTrigger : BaseModel
{
    public string SchedName { get; set; } = null!;

    public string TriggerName { get; set; } = null!;

    public string TriggerGroup { get; set; } = null!;

    public int RepeatCount { get; set; }

    public long RepeatInterval { get; set; }

    public int TimesTriggered { get; set; }

    public virtual QrtzTrigger QrtzTrigger { get; set; } = null!;
}

