namespace Data.Databases.Tpfsystem;

public partial class VCaReportOrderSummary : BaseModel
{
    public long OrderNumber { get; set; }

    public string? Name { get; set; }

    public string? OrderDate { get; set; }

    public long? TpforderId { get; set; }

    public long? ClientId { get; set; }

    public string ClubEntityId { get; set; } = null!;

    public decimal? GrandTotalInc { get; set; }

    public string? ClubEntityName { get; set; }

    public string? UserType { get; set; }

    public string PaymentStatus { get; set; } = null!;

    public string? TrackingNo { get; set; }

    public string? CarrierUrl { get; set; }

    public string OrderStatus { get; set; } = null!;

    public string? BillingName { get; set; }

    public string? DeliveryAddress { get; set; }

    public string? DeliveryName { get; set; }

    public string? DeliveryCompanyName { get; set; }

    public string? DeliveryStreet1 { get; set; }

    public string DeliveryStreet2 { get; set; } = null!;

    public string? DeliverySuburb { get; set; }

    public string? DeliveryState { get; set; }

    public string? DeliveryPostcode { get; set; }

    public string? DeliveryPhone { get; set; }

    public double Amount { get; set; }

    public decimal? GrandTotalOrderInc { get; set; }

    public string? Email { get; set; }

    public string? UserName { get; set; }

    public string? CarrierName { get; set; }

    public string? ProcessDate { get; set; }

    public string PaymentType { get; set; } = null!;

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string PoCostCentre { get; set; } = null!;

    public string ReasonCode { get; set; } = null!;

    public string? UserNameOrId { get; set; }

    public string? TextToSearch { get; set; }
}

