namespace Data.Databases.Csversion1;

public partial class CaAdjustMentCreditPointEntityLog : BaseModel
{
    public int AdjustmentId { get; set; }

    public decimal? AdjustmentAmount { get; set; }

    public string? EntityId { get; set; }

    public int? AddBy { get; set; }

    public DateTime? AddDate { get; set; }

    public int? TransId { get; set; }

    public decimal? AvailableCredit { get; set; }

    public decimal? AssignedCredit { get; set; }

    public decimal? UsedCredit { get; set; }

    public decimal? AdjustedCredit { get; set; }

    public decimal? TotalCredit { get; set; }
}

