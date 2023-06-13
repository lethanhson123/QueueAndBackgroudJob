namespace Data.Databases.Csversion1;

public partial class CaAdjustMentCreditPoint : BaseModel
{
    public int AdjustmentId { get; set; }

    public decimal? AdjustmentAmount { get; set; }

    public int? WebAccId { get; set; }

    public int? AddBy { get; set; }

    public DateTime? AddDate { get; set; }

    public int? TransId { get; set; }
}

