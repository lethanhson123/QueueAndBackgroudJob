namespace Data.Databases.CMS_EMBERPLUS;

public partial class PaymentTransation : BaseModel
{
    public long Id { get; set; }

    public string? Token { get; set; }

    public long? OrderId { get; set; }

    public string? TransationId { get; set; }

    public string? PaypalId { get; set; }

    public decimal? Amount { get; set; }

    public decimal? Fee { get; set; }

    public decimal? AmountReceive { get; set; }

    public string? PayFrom { get; set; }

    public DateTime? PayRequest { get; set; }

    public DateTime? PayResponse { get; set; }

    public string? PayType { get; set; }

    public string? ResponseCode { get; set; }

    public string? Currency { get; set; }

    public string? Response { get; set; }

    public string? PaymentStatus { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public int? Status { get; set; }

    public string? CreateBy { get; set; }

    public string? CreatebyName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? PaypalDate { get; set; }

    public string? PaypalStatus { get; set; }

    public string? PaypalPendingReason { get; set; }

    public string? PaypalCode { get; set; }

    public string? PaypalDataRecheck { get; set; }

    public string? PaypalType { get; set; }

    public string? PayUrl { get; set; }
}

