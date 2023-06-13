namespace Data.Databases.CMS_EMBERPLUS;
public partial class WebOrder : BaseModel
{
    public long Id { get; set; }

    public decimal? Gst { get; set; }

    public decimal? Total { get; set; }

    public decimal? SubTotal { get; set; }

    public decimal? TotalGst { get; set; }

    public decimal? Discount { get; set; }

    public decimal? SubTotalDiscount { get; set; }

    public decimal? TotalDiscount { get; set; }

    public int? DiscountType { get; set; }

    public string? Voucher { get; set; }

    public decimal? ShippingSubTotalPrice { get; set; }

    public decimal? ShippingTotalPrice { get; set; }

    public string? ShippingType { get; set; }

    public string? Currency { get; set; }

    public string? UserId { get; set; }

    public DateTime? OrderDate { get; set; }

    public string? OrderType { get; set; }

    public string? SubOrderType { get; set; }

    public string? OrderStatus { get; set; }

    public string? PaymentType { get; set; }

    public string? PaymentStatus { get; set; }

    public string? Notes { get; set; }

    public string? CanceledBy { get; set; }

    public DateTime? CanceledAt { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public int? Status { get; set; }

    public string? CreateBy { get; set; }

    public string? CreatebyName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public decimal? CreditSubTotal { get; set; }

    public decimal? CreditGst { get; set; }

    public decimal? Credit { get; set; }

    public string? TransationRef { get; set; }

    public long? TpforderId { get; set; }

    public DateTime? TpforderSyncDate { get; set; }

    public string? DebtorCode { get; set; }

    public bool? ReturnCredit { get; set; }

    public string? CounterCode { get; set; }

    public int? CompanyId { get; set; }

    public string? SyncStatus { get; set; }

    public bool? SyncEnable { get; set; }

    public long? SeasonId { get; set; }

    public bool? DeliveryRequestCreated { get; set; }

	public List<WebOrderDetail> Details { get; set; }
}

