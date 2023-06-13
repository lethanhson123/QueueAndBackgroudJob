namespace Data.Databases.Tpfsystem;

public partial class Orderconf : BaseModel
{
    /// <summary>
    /// order confirmation id
    /// </summary>
    public long Ocid { get; set; }

    public string? PoNumber { get; set; }

    public string? Fname { get; set; }

    public string? Lname { get; set; }

    public string? Position { get; set; }

    public string? Companyname { get; set; }

    /// <summary>
    /// Trading Name
    /// </summary>
    public string? Tradingname { get; set; }

    /// <summary>
    /// Promotion Name
    /// </summary>
    public string? PromotionName { get; set; }

    public string? Abn { get; set; }

    public string? Addr1 { get; set; }

    public string? Addr2 { get; set; }

    public string? Addr3 { get; set; }

    public string? Postcode { get; set; }

    public string? Mobile { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Country { get; set; }

    public string? Showsubtotal { get; set; }

    public long? ClientId { get; set; }

    public string? Enteredby { get; set; }

    public int? Handledby { get; set; }

    /// <summary>
    /// Processed by staffID
    /// </summary>
    public string? Processedby { get; set; }

    public DateTime? SubmitDate { get; set; }

    public DateTime DeliveryDate { get; set; }

    public DateTime? ProcessDate { get; set; }

    public DateTime? Lastupdate { get; set; }

    public string? Visible { get; set; }

    public string? Tradeterms { get; set; }

    public string? FrcstMargin { get; set; }

    public string? Disclaimer { get; set; }

    public string? Deldetails { get; set; }

    /// <summary>
    /// Order Total including GST
    /// </summary>
    public double? Ordertotal { get; set; }

    /// <summary>
    /// Order Total Exc GST
    /// </summary>
    public double? Ordertotalexc { get; set; }

    public string? Totalcost { get; set; }

    public string? Productionstaff { get; set; }

    /// <summary>
    /// Invoice Status: full-invoiced, part-invoiced, processed, pending,  Awaiting Payment, cancelled, closed
    /// </summary>
    public string? Status { get; set; }

    public DateTime? Joblastchanged { get; set; }

    /// <summary>
    /// Job status : opened, closed.
    /// </summary>
    public string? Jobstatus { get; set; }

    public string? Currency { get; set; }

    public double? Exchangerate { get; set; }

    public int? ProfileId { get; set; }

    public double? AudtoHkdrate { get; set; }

    public double? UsdtoHkdrate { get; set; }

    /// <summary>
    /// Hong Kong Order Status: Processed, pending, full-invoiced, part-invoiced, cancelled
    /// </summary>
    public string? Hkorderstatus { get; set; }

    public string? Lastchangenote { get; set; }

    public DateTime? OpenedDate { get; set; }

    public int? OpenedBy { get; set; }

    public DateTime? ClosedDate { get; set; }

    public int? Closedby { get; set; }

    public string? Fob { get; set; }

    public string? WipNote { get; set; }

    public string? SalesWipStatus { get; set; }

    public DateTime? SalesCheckedDate { get; set; }

    /// <summary>
    /// Sales WIP status - &apos;current&apos; or &apos;checked&apos;
    /// </summary>
    public string? ActionStatus { get; set; }

    /// <summary>
    /// Date that action was checked on
    /// </summary>
    public DateTime? ActionCheckedDate { get; set; }

    /// <summary>
    /// staff id that action was checked by
    /// </summary>
    public int? ActionCheckedBy { get; set; }

    public int? WipFlag { get; set; }

    /// <summary>
    /// sales WIP comments
    /// </summary>
    public string? WipComment { get; set; }

    /// <summary>
    /// OS WIP note check - 1 new note, 0 no note
    /// </summary>
    public int? OsNoteCheck { get; set; }

    /// <summary>
    /// The myProjectid from myProject
    /// </summary>
    public string? Projectid { get; set; }

    public string? ReportDisplay { get; set; }

    public string? DAttention { get; set; }

    public string? DFname { get; set; }

    public string? DLname { get; set; }

    public string? DAddr1 { get; set; }

    public string? DAddr2 { get; set; }

    public string? DAddr3 { get; set; }

    public string? DPostcode { get; set; }

    public string? DCompanyname { get; set; }

    public string? DCountry { get; set; }

    public string? DEmail { get; set; }

    public string? DMobile { get; set; }

    public string? DPhone { get; set; }

    public string? DFax { get; set; }

    public string? DNotes { get; set; }

    public long? DAddrid { get; set; }

    public long? Catalogueid { get; set; }

    public string? Payoption { get; set; }

    public string? Costcentre { get; set; }

    public string? Tobeinvoiced { get; set; }

    public string? Vendorno { get; set; }

    public string? Sendwithgoods { get; set; }

    public string? Ariba { get; set; }

    public string? TxnRef { get; set; }

    public string? HoldOrder { get; set; }

    public string? OnlineOrder { get; set; }

    /// <summary>
    /// For general ledger - Internal or External
    /// </summary>
    public string? OrderGroup { get; set; }

    public long? GlId { get; set; }

    public string? GlOption { get; set; }

    public string? GlSubgroup { get; set; }

    public string? GlCategory { get; set; }

    public long? GlOrderIndex { get; set; }

    public string? FinanceJobComment { get; set; }

    public string? DStatus { get; set; }

    public string? BAttention { get; set; }

    public string? BFname { get; set; }

    public string? BLname { get; set; }

    public string? BCompanyname { get; set; }

    public string? BAbn { get; set; }

    public string? BAddr1 { get; set; }

    public string? BAddr2 { get; set; }

    public string? BAddr3 { get; set; }

    public string? BPostcode { get; set; }

    public string? BCountry { get; set; }

    public string? BMobile { get; set; }

    public string? BPhone { get; set; }

    public string? BFax { get; set; }

    public string? BEmail { get; set; }

    public long? BAddrid { get; set; }

    public double? Invoicetotal { get; set; }

    /// <summary>
    /// created on 05082008
    /// </summary>
    public double? Invoicetotalexcgst { get; set; }

    /// <summary>
    /// created on 05082008
    /// </summary>
    public double? Credittotalexcgst { get; set; }

    public string? Hkjobstatus { get; set; }

    public int HkJobClosedBy { get; set; }

    public DateTime? HkJobClosingDate { get; set; }

    public long? RoyaltyContract { get; set; }

    public long? CancelledBy { get; set; }

    public DateTime? CancelledDate { get; set; }

    /// <summary>
    /// Delivery Status: Fully Delivered, Partly Delivered, New
    /// </summary>
    public string? DelStatus { get; set; }

    public long? DelStatusClosedBy { get; set; }

    public DateTime? DelStatusClosedDate { get; set; }

    public double? OrgOrderTotal { get; set; }

    public string? CostingNotes { get; set; }

    public int? PlGroup { get; set; }

    /// <summary>
    /// onhold =1 normal=0
    /// </summary>
    public int? Onhold { get; set; }

    public long? Singleinvoice { get; set; }

    public int? Whid { get; set; }

    public string? Source { get; set; }

    public int? Ocupdatedby { get; set; }

    public DateTime? Oclastupdated { get; set; }

    public string? Notes { get; set; }

    public string? Completionstatus { get; set; }

    public DateTime? Reportdate { get; set; }

    /// <summary>
    /// idea is we only want to send orderconfirmation once (and send/save sales stats once) so if value changes to 1 after we save it the first time.
    /// </summary>
    public int? AlreadyNotified { get; set; }

    /// <summary>
    /// Company ID: 1-TPF AUS, 2- TPF UK, 3-TPF New Zealand
    /// </summary>
    public int? Cid { get; set; }

    public decimal? Gstrate { get; set; }

    public decimal? ITotal { get; set; }

    public decimal? CTotal { get; set; }

    public decimal? ITotalExc { get; set; }

    public decimal? CTotalExc { get; set; }

    public string? Importref { get; set; }

    public int? OrderCategoryId { get; set; }

    public int? DWhid { get; set; }

    public double? FinanceMargin { get; set; }

    public int? Assignedto { get; set; }

    public int? RawId { get; set; }

    public string? Trackingcode { get; set; }

    public DateTime? Lastdeliverydate { get; set; }

    public string? IsDuplicate { get; set; }

    public int? ClubId { get; set; }

    public string? Webstoreno { get; set; }

    public string? MembershipNumber { get; set; }

    public bool? IsMagento { get; set; }

    /// <summary>
    /// 0: null
    /// 1: Sponsors
    /// 2: Dealers
    /// 3:  Partners
    /// 4: Holden HQ
    /// </summary>
    public int? SaleType { get; set; }

    public double? RateEntityToAud { get; set; }

    public double? RateToEntity { get; set; }

    public double? IOrderTotal { get; set; }

    public double? IOrderTotalExc { get; set; }

    public double? TotalPriceInTax { get; set; }

    public double? TotalPriceExTax { get; set; }

    public short? ErrorCount { get; set; }

    public int? ProgramId { get; set; }

    public string? ClientReference { get; set; }

    public int? ProMarketId { get; set; }

    public bool? IsSynced { get; set; }

    public long? TpforderId { get; set; }

    public DateTime? SyncDate { get; set; }

    /// <summary>
    /// 1 : Normal,2 : Part Returned , 3 : Full Returned,  4 : Error Delivery Addess 
    /// </summary>
    public int? OrderStatus { get; set; }

    public string? OrderStatusNote { get; set; }

    public int? SeasonId { get; set; }

    public long? PkOcid { get; set; }

    public string? PoCostCentre { get; set; }

    public string? ReasonCode { get; set; }

    public string? OrderdRole { get; set; }

    public string? FulfilmentId { get; set; }

    public virtual ICollection<CaTrackingInfo> CaTrackingInfos { get; } = new List<CaTrackingInfo>();
}

