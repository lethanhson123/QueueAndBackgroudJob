namespace Data.Databases.CMS_EMBERPLUS;

public partial class CalcCalculationParticipant : BaseModel
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public int Status { get; set; }

    public DateTime LastUpdateDate { get; set; }

    public string Description { get; set; } = null!;

    public int Redemp1Assigned { get; set; }

    public bool IsEligibility { get; set; }

    public long CalcParticipantId { get; set; }

    public decimal Credit { get; set; }

    public string? RawData { get; set; }
}
