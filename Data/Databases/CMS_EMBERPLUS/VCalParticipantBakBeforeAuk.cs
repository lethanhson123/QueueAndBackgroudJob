namespace Data.Databases.CMS_EMBERPLUS;

public partial class VCalParticipantBakBeforeAuk : BaseModel
{
    public int? PackgeAvailable { get; set; }

    public int? PackgeRedemed { get; set; }

    public int? PackgeRedem { get; set; }

    public int CompanyId { get; set; }

    public long Id { get; set; }

    public decimal TotalCredit { get; set; }

    public decimal TotalUsedCredit { get; set; }

    public decimal TotalAvailableCredit { get; set; }

    public decimal TotalAdjustCredit { get; set; }
}

