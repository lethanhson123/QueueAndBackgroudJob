namespace Data.Databases.CMS_EMBERPLUS;

public partial class CalcSeasonCreditHistory : BaseModel
{
    public string UserId { get; set; } = null!;

    public long SeasonId { get; set; }

    public long CompanyId { get; set; }

    public decimal? Credit { get; set; }

    public byte? Status { get; set; }
}
