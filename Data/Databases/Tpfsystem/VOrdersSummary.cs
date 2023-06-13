namespace Data.Databases.Tpfsystem;

public partial class VOrdersSummary : BaseModel
{
    public int? WebAccId { get; set; }

    public long? ClientId { get; set; }

    public string? Username { get; set; }

    public long OrderNumber { get; set; }

    public long? TpforderId { get; set; }

    public string? DelStatus { get; set; }

    public long? Catalogueid { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? Email { get; set; }

    public string OrderStatus { get; set; } = null!;

    public double? Total { get; set; }

    public string? PaymentMethod { get; set; }

    public DateTime? LastModified { get; set; }

    public string? ContactFirstname { get; set; }

    public string? ContactLastname { get; set; }

    public string? ContactEmail { get; set; }

    public string? ContactPhone { get; set; }

    public string? DeliveryFullName { get; set; }

    public string? DeliveryAddress { get; set; }

    public string? DeliverySuburb { get; set; }

    public string? DeliveryState { get; set; }

    public string? DeliveryPostcode { get; set; }

    public string? DeliveryCountry { get; set; }

    public string? BillingFullName { get; set; }

    public string? BillingAddress { get; set; }

    public string? BillingSuburb { get; set; }

    public string? BillingState { get; set; }

    public string? BillingPostcode { get; set; }

    public string? BillingCountry { get; set; }

    public string? CarrierName { get; set; }

    public string? CarrierUrl { get; set; }

    public string? TrackingNo { get; set; }

    public string? UserType { get; set; }

    public string EntityId { get; set; } = null!;

    public string? EntityName { get; set; }

    public string? PaymentStatus { get; set; }
}

