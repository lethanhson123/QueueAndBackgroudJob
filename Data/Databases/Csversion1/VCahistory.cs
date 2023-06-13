namespace Data.Databases.Csversion1;

public partial class VCahistory : BaseModel
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? ContactFirstname { get; set; }

    public string? ContactLastname { get; set; }

    public string? ContactAddress { get; set; }

    public string? ContactAddress2 { get; set; }

    public string? ContactSuburb { get; set; }

    public string? ContactState { get; set; }

    public string? ContactPostcode { get; set; }

    public string? ContactEmail { get; set; }

    public string? ContactCountry { get; set; }

    public string? ContactPhone { get; set; }

    public string? DeliveryFirstname { get; set; }

    public string? DeliveryLastname { get; set; }

    public string? DeliveryAddress { get; set; }

    public string? DeliveryAddress2 { get; set; }

    public string? DeliverySuburb { get; set; }

    public string? DeliveryState { get; set; }

    public string? DeliveryPostcode { get; set; }

    public string? DeliveryCountry { get; set; }

    public string BillingFirstname { get; set; } = null!;

    public string BillingLastname { get; set; } = null!;

    public string? BillingAddress { get; set; }

    public string? BillingAddress2 { get; set; }

    public string? BillingSuburb { get; set; }

    public string? BillingState { get; set; }

    public string? BillingPostcode { get; set; }

    public string? BillingCountry { get; set; }

    public string Status { get; set; } = null!;

    public int WebAccId { get; set; }

    public string RoleName { get; set; } = null!;

    public int RoleId { get; set; }

    public string? RoleDescription { get; set; }

    public int? Updateby { get; set; }

    public string? UpdateByName { get; set; }

    public string? Createby { get; set; }

    public string? CreateByName { get; set; }

    public DateTime? Createdate { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string AccessStatus { get; set; } = null!;

    public long ClientId { get; set; }

    public int Catalogueid { get; set; }

    public int Expr1 { get; set; }

    public long Expr2 { get; set; }

    public string? Expr3 { get; set; }

    public long Ordernumber { get; set; }

    public long? TpforderId { get; set; }

    public string? DelStatus { get; set; }

    public long? Expr4 { get; set; }

    public DateTime? Date { get; set; }

    public string? Email { get; set; }

    public string? Expr5 { get; set; }

    public double? Total { get; set; }

    public string? PaymentMethod { get; set; }

    public DateTime? Lastmodified { get; set; }

    public string? Fname { get; set; }

    public string? Lname { get; set; }

    public string? Expr6 { get; set; }

    public string? Phone { get; set; }

    public string? DeliveryFullName { get; set; }

    public string? DAddr1 { get; set; }

    public string? DAddr2 { get; set; }

    public string? DAddr3 { get; set; }

    public string? DPostcode { get; set; }

    public string? DCountry { get; set; }

    public string? BillingFullName { get; set; }

    public string? BAddr1 { get; set; }

    public string? BAddr2 { get; set; }

    public string? BAddr3 { get; set; }

    public string? BPostcode { get; set; }

    public string? BCountry { get; set; }

    public string? CarrierName { get; set; }

    public string? CarrierUrl { get; set; }

    public string? TrackingNo { get; set; }
}

