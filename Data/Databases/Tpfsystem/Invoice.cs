namespace Data.Databases.Tpfsystem;

public partial class Invoice : BaseModel
{
    public long Invoicenumber { get; set; }

    /// <summary>
    /// CPC for catalogue
    /// </summary>
    public string Type { get; set; } = null!;

    public DateTime Invoicedate { get; set; }

    public long? Ordernumber { get; set; }

    public string? Ponumber { get; set; }

    public string? Vendorno { get; set; }

    /// <summary>
    /// First Name to send the invoice
    /// </summary>
    public string? SendTofname { get; set; }

    /// <summary>
    /// Last Name to send the invoice
    /// </summary>
    public string? SendTolname { get; set; }

    /// <summary>
    /// for corperate address
    /// </summary>
    public string? Companyname { get; set; }

    /// <summary>
    /// the address to send invoice
    /// </summary>
    public string? Sendtoaddress { get; set; }

    /// <summary>
    /// city to send the invoice
    /// </summary>
    public string? Sendtocity { get; set; }

    public string? Sendstate { get; set; }

    public string? Sendtopostcode { get; set; }

    public string? Sendtocountry { get; set; }

    /// <summary>
    /// staff who processed the invoice
    /// </summary>
    public string? Processedby { get; set; }

    public double? GstTotal { get; set; }

    /// <summary>
    /// total -&gt; inc freight
    /// </summary>
    public double? Invoicetotal { get; set; }

    public long? Catalogueid { get; set; }

    public double? Freight { get; set; }

    /// <summary>
    /// invoice sent date
    /// </summary>
    public DateTime? Invoicesent { get; set; }

    /// <summary>
    /// invoice sent by - staff id
    /// </summary>
    public int? Invoicesentby { get; set; }

    public string? Invoicetype { get; set; }

    /// <summary>
    /// number of time email sent by invoice
    /// </summary>
    public int? Emailsent { get; set; }

    /// <summary>
    /// date that invoice last sent by email
    /// </summary>
    public DateTime? Emailinvoicelastsent { get; set; }

    /// <summary>
    /// staff who last sent email - staff id
    /// </summary>
    public int? Emaillastsentby { get; set; }

    /// <summary>
    /// 0 outstanding / 1 paid / 3 is for cancel invoice
    /// </summary>
    public long? InvStatus { get; set; }

    /// <summary>
    /// email invoice
    /// </summary>
    public string? ClientEmail { get; set; }

    public long? ClientId { get; set; }

    public string? Abn { get; set; }

    public DateTime? Lastreminderemail { get; set; }

    /// <summary>
    /// TPF Contact Name 
    /// </summary>
    public string? Tpfcontactname { get; set; }

    /// <summary>
    /// Delivery First Name
    /// </summary>
    public string? DelFname { get; set; }

    /// <summary>
    /// Delivery Last Name
    /// </summary>
    public string? DelLname { get; set; }

    /// <summary>
    /// Delivery Company Name
    /// </summary>
    public string? DelCompanyname { get; set; }

    public string? DelAbn { get; set; }

    /// <summary>
    /// Delivery Address
    /// </summary>
    public string? DelAddr1 { get; set; }

    /// <summary>
    /// Delivery Suburb
    /// </summary>
    public string? DelAddr2 { get; set; }

    /// <summary>
    /// Delivery State
    /// </summary>
    public string? DelAddr3 { get; set; }

    /// <summary>
    /// Delivery Post Code
    /// </summary>
    public string? DelPostcode { get; set; }

    /// <summary>
    /// Delivery Client ID
    /// </summary>
    public int? DelClientId { get; set; }

    /// <summary>
    /// Invoice Currency
    /// </summary>
    public string? InvCurrency { get; set; }

    /// <summary>
    /// Invoice Trade Terms: PREPAYMENT/ Cash/ COD/ 7 days/ 14 days/ 30 days/ 45 days/ 60 days
    /// </summary>
    public string? InvTradeterms { get; set; }

    /// <summary>
    /// General Notes
    /// </summary>
    public string? Generalnotes { get; set; }

    public string? StaffPhone { get; set; }

    public int? StaffId { get; set; }

    public double? Exchangerate { get; set; }

    /// <summary>
    /// internal/external
    /// </summary>
    public string? InvGroup { get; set; }

    public string? Raisedby { get; set; }

    public string? HistoryChange { get; set; }

    public long? OldCustId { get; set; }

    public DateTime? InvTransferredDate { get; set; }

    /// <summary>
    /// Finance Notes
    /// </summary>
    public string? FinanceNotes { get; set; }

    /// <summary>
    /// 0-sent / 1- unsent
    /// </summary>
    public int? SendInvStatus { get; set; }

    /// <summary>
    /// 0 - sent / 1 - unsent
    /// </summary>
    public int? SendRemStatus { get; set; }

    public string? ReminderEmail { get; set; }

    /// <summary>
    /// Invoice Total not including GST
    /// </summary>
    public double? Invoicetotalexc { get; set; }

    public string? Paymethod { get; set; }

    /// <summary>
    /// Send email invoice status - 0=sent, 1=unsent
    /// </summary>
    public int? SendEmailStatus { get; set; }

    /// <summary>
    /// AUD - Amount paid by client
    /// </summary>
    public double? PaidAmount { get; set; }

    public string? RoyaltyContract { get; set; }

    public string? Aribasendlog { get; set; }

    public string? Isource { get; set; }

    public long? Cid { get; set; }

    public string? Basecurrency { get; set; }

    public short? Tracking { get; set; }

    public double? RateEntityToAud { get; set; }

    public double? RateToEntity { get; set; }

    public double? IInvoiceTotal { get; set; }

    public double? IInvoiceTotalExc { get; set; }

    public double? TotalPriceInTax { get; set; }

    public double? TotalPriceExTax { get; set; }

    public string? DelCountry { get; set; }
}

