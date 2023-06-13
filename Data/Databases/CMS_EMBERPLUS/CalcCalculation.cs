namespace Data.Databases.CMS_EMBERPLUS;

public partial class CalcCalculation : BaseModel
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public int Status { get; set; }

    public DateTime LastUpdateDate { get; set; }

    public string? Description { get; set; }

    public int Redemp1Assigned { get; set; }

    public bool IsEligibility { get; set; }

    public long CalcEntityId { get; set; }

    public decimal? CreditTenure { get; set; }

    public decimal CreditRegistration { get; set; }

    public decimal? CreditDiversity { get; set; }

    public string? RawData { get; set; }
}
