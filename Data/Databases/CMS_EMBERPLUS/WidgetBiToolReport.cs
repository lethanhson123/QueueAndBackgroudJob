namespace Data.Databases.CMS_EMBERPLUS;

public partial class WidgetBiToolReport : BaseModel
{
    public string Id { get; set; } = null!;

    public string? ConfigReport { get; set; }

    public string? QueryReport { get; set; }

    public int? ReportType { get; set; }

    public string? FilterReport { get; set; }
}

