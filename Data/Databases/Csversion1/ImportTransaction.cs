namespace Data.Databases.Csversion1;

public partial class ImportTransaction : BaseModel
{
    public int TransId { get; set; }

    public string? TransType { get; set; }

    public string? FileName { get; set; }

    public int? TotalRecords { get; set; }

    public DateTime? ImportDate { get; set; }

    public int? ImportBy { get; set; }

    public string? Status { get; set; }
}

