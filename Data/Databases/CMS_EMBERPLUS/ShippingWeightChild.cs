namespace Data.Databases.CMS_EMBERPLUS;

public partial class ShippingWeightChild : BaseModel
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

    public decimal? FromWeight { get; set; }

    public decimal? ToWeight { get; set; }

    public decimal? Price { get; set; }

    public long? ShippingCalculatorId { get; set; }

    public string? Country { get; set; }

    public string? State { get; set; }

    public string? PostCode { get; set; }
}

