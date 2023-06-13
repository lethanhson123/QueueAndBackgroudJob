namespace Data.Databases.CMS_EMBERPLUS;

public partial class QrtzCalendar : BaseModel
{
    public string SchedName { get; set; } = null!;

    public string CalendarName { get; set; } = null!;

    public byte[] Calendar { get; set; } = null!;
}

