namespace Data.Databases.Tpfsystem;

public partial class OnlineAccountsList : BaseModel
{
    public int WebAccId { get; set; }

    public long ClientId { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? Encryptedpw { get; set; }

    public bool? UseEncryption { get; set; }

    public int? Accesslevel { get; set; }

    public string? Field1 { get; set; }

    public string? Field2 { get; set; }

    public string? Field3 { get; set; }

    public string? Field4 { get; set; }

    public string? Oktospam { get; set; }

    public string AccessStatus { get; set; } = null!;

    public int PriceProfileId { get; set; }

    public string Priceprofile { get; set; } = null!;

    public int Catalogueid { get; set; }

    public int Caninvoice { get; set; }

    public string? ContactFname { get; set; }

    public string? ContactLname { get; set; }

    public string ContactCompany { get; set; } = null!;

    public string? Position { get; set; }

    public string? ContactAddress { get; set; }

    public string? ContactOptAddress1 { get; set; }

    public string? ContactSuburb { get; set; }

    public string? ContactState { get; set; }

    public string? ContactPostcode { get; set; }

    public string? ContactCountry { get; set; }

    public string? ContactPhone { get; set; }

    public string? ContactFax { get; set; }

    public string? ContactEmail { get; set; }

    public long BillingId { get; set; }

    public string? BillingAttention { get; set; }

    public string? BillingAddress { get; set; }

    public string? BillingSuburb { get; set; }

    public string? BillingState { get; set; }

    public string? BillingPostcode { get; set; }

    public string? BillingCountry { get; set; }

    public string? BillingEmail { get; set; }

    public string? BillingPhone { get; set; }

    public long? DeliveryId { get; set; }

    public string? DeliveryAttention { get; set; }

    public string? DeliveryCompany { get; set; }

    public string? DeliveryAddress { get; set; }

    public string? DeliverySuburb { get; set; }

    public string? DeliveryState { get; set; }

    public string? DeliveryPostcode { get; set; }

    public string? DeliveryCountry { get; set; }

    public string? DeliveryPhone { get; set; }

    public string? DeliveryEmail { get; set; }

    public long AccId { get; set; }

    public string Acccode { get; set; } = null!;

    public string Companyname { get; set; } = null!;

    public string? Tradingname { get; set; }

    public string? TradingTerms { get; set; }

    public string Currency { get; set; } = null!;

    public string? Activestatus { get; set; }

    public string PartnerStatus { get; set; } = null!;

    public string? Credithold { get; set; }

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }
}

