namespace Data.Databases.Csversion1;

public partial class ParticipantOrderCompare : BaseModel
{
    public string? UniqueId { get; set; }

    public double? OrderId { get; set; }

    public DateTime? DispatchedDate { get; set; }

    public double? UploadId { get; set; }

    public DateTime? Uploaddate { get; set; }

    public string? FileName { get; set; }
}

