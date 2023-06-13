namespace Data.Databases.CMS_EMBERPLUS;

public partial class Language : BaseModel
{
    public string LanKey { get; set; } = null!;

    public int LanId { get; set; }

    public string? LanValue { get; set; }

    public string? Module { get; set; }

    public string? LanType { get; set; }
}

