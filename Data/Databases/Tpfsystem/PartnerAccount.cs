namespace Data.Databases.Tpfsystem;

public partial class PartnerAccount : BaseModel
{
    public long AccId { get; set; }

    /// <summary>
    /// Account Code of Client
    /// </summary>
    public string Acccode { get; set; } = null!;

    /// <summary>
    /// client&apos;s tag name
    /// </summary>
    public string TagName { get; set; } = null!;

    /// <summary>
    /// Account Location: domestic/overseas
    /// </summary>
    public string? AccLocation { get; set; }

    /// <summary>
    /// Partner Account ABN Number
    /// </summary>
    public string Abn { get; set; } = null!;

    public string Companyname { get; set; } = null!;

    public string? Tradingname { get; set; }

    /// <summary>
    /// Type of Customer: END USER/RESELLER
    /// </summary>
    public string? Customertype { get; set; }

    /// <summary>
    /// Trading Tems: PREPAYMENT/7 days/14 days/30 days/60 days/lc/TT
    /// </summary>
    public string? TradingTerms { get; set; }

    public string Currency { get; set; } = null!;

    public string? Website { get; set; }

    public string? Shippingtype { get; set; }

    public string? Password { get; set; }

    /// <summary>
    /// company sales person - id
    /// </summary>
    public int? Contactperson { get; set; }

    /// <summary>
    /// Send Statement: Yes/No
    /// </summary>
    public string? SendStatement { get; set; }

    public string? Remarks { get; set; }

    /// <summary>
    /// Account Note
    /// </summary>
    public string? Accnote { get; set; }

    public string? ApprovalComment { get; set; }

    public int? ActiveStatusUpdateBy { get; set; }

    public DateTime? ActiveStatusUpdateDate { get; set; }

    public int? CreditholdUpdateBy { get; set; }

    public DateTime? CreditholdUpdateDate { get; set; }

    public string? StStreet { get; set; }

    public string? StSuburb { get; set; }

    public string? StState { get; set; }

    public string? StPostcode { get; set; }

    public string? StCountry { get; set; }

    public string? StEmail { get; set; }

    /// <summary>
    /// Email where invoices to be sent
    /// </summary>
    public string? InvEmail { get; set; }

    public string? RemEmail { get; set; }

    public string? Vendorno { get; set; }

    /// <summary>
    /// PO Required: Yes/No
    /// </summary>
    public string? PoRequired { get; set; }

    /// <summary>
    /// date for last update in the partner account
    /// </summary>
    public DateTime? Lastupdate { get; set; }

    public int? Lastupdateby { get; set; }

    public DateTime? Createdate { get; set; }

    public int? Createby { get; set; }

    public string? Credithold { get; set; }

    public double? CreditLimits { get; set; }

    public string? CreditLimitsBypass { get; set; }

    /// <summary>
    /// Active Status: approved/declined/pending
    /// </summary>
    public string? Activestatus { get; set; }

    /// <summary>
    /// Status: current/cancelled/removed
    /// </summary>
    public string Status { get; set; } = null!;

    public string? SendInvoiceReminder { get; set; }

    public int Companycode { get; set; }

    public string? StatementEmail { get; set; }

    public string? Lastsentstatement { get; set; }

    public int? StatementsentBy { get; set; }

    public bool? SendInvToPurchaser { get; set; }

    public bool? SendRemToPurchaser { get; set; }

    public virtual ICollection<ClientBilling> ClientBillings { get; } = new List<ClientBilling>();

    public virtual ICollection<ClientDelDatum> ClientDelData { get; } = new List<ClientDelDatum>();
}

