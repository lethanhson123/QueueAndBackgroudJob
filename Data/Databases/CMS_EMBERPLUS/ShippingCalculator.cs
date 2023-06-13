namespace Data.Databases.CMS_EMBERPLUS;

public partial class ShippingCalculator : BaseModel
{
    public long Id { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public int? Status { get; set; }

    public string? CreateBy { get; set; }

    public string? CreatebyName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public int? CompanyId { get; set; }

    public int? WaveHouseId { get; set; }

    public string? ToCountry { get; set; }

    public string? ToState { get; set; }

    public decimal? Init { get; set; }

    public decimal? Price { get; set; }

    public decimal? ExtInit { get; set; }

    public decimal? ExtPrice { get; set; }

    public string? Calculator { get; set; }

    public int? TypeCalculator { get; set; }

    public bool? IsMinShippingHasRedeemItem { get; set; }

    public decimal? MinShippingHasRedeemItem { get; set; }

    public decimal? DefaultPrice { get; set; }
}

