namespace Data.Databases.Tpfsystem;

public partial class VEcomOrder : BaseModel
{
    public long OrderNumber { get; set; }

    public string? Ponumber { get; set; }

    public long? TpfOrderId { get; set; }

    public long? CatalogueId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? CompanyName { get; set; }

    public string? PromotionName { get; set; }

    public int? Whid { get; set; }

    public int? Onhold { get; set; }

    public string? TxnRef { get; set; }

    public string? HoldOrder { get; set; }

    public string? IsOnlineOrder { get; set; }

    public string? OrderGroup { get; set; }

    public string? PayOption { get; set; }

    public long? ClientId { get; set; }

    public double? OrderTotal { get; set; }

    public double? OrderTotalExc { get; set; }

    public double? IOrderTotalExc { get; set; }

    public double? IOrderTotal { get; set; }

    public double? TotalPriceInTax { get; set; }

    public double? TotalPriceExTax { get; set; }

    public bool? IsSynced { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedDate { get; set; }
}

