namespace Data.Databases.Csversion1;

public partial class ParticipantReportOrderSeason : BaseModel
{
    public int Id { get; set; }

    public int? Pending { get; set; }

    public int? Dispatched { get; set; }

    public int? Rejected { get; set; }

    public int? Total { get; set; }

    public int? SeasonId { get; set; }

    public DateTime? CreateDate { get; set; }
}

