namespace Data.Databases.Csversion1;

public partial class Matching : BaseModel
{
    public double? Order { get; set; }

    public DateTime? DateOrdered { get; set; }

    public double? TpfOrderId { get; set; }

    public string? OrderStatus { get; set; }

    public string? UserType { get; set; }

    public double? UserId { get; set; }

    public string? Username { get; set; }

    public string? PaymentType { get; set; }

    public string? PaymentReference { get; set; }

    public string? ReasonCodes { get; set; }

    public string? BillingName { get; set; }

    public string? DeliveryName { get; set; }

    public string? DeliveryCompanyName { get; set; }

    public string? DeliveryStreet1 { get; set; }

    public string? DeliveryStreet2 { get; set; }

    public string? DeliverySuburb { get; set; }

    public string? DeliveryState { get; set; }

    public string? DeliveryPostcode { get; set; }

    public string? DeliveryPhone { get; set; }

    public DateTime? DispatchDate { get; set; }

    public string? Connote { get; set; }

    public string? Carrier { get; set; }

    public double? Classes { get; set; }

    public double? Participants { get; set; }

    public string? Key1 { get; set; }

    public string? Key2 { get; set; }

    public string? FulfilmentId { get; set; }

    public double? DupeCheck { get; set; }
}

