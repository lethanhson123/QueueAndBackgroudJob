namespace Data.Databases.Csversion1;

public partial class VCaOrder : BaseModel
{
    public int SystemEntityId { get; set; }

    public string EntityId { get; set; } = null!;

    public string EntityName { get; set; } = null!;

    public string EntityType { get; set; } = null!;

    public long Ocid { get; set; }

    public string? PoNumber { get; set; }

    public string? Fname { get; set; }

    public string? Lname { get; set; }

    public string? Position { get; set; }

    public string? Companyname { get; set; }

    public string? Tradingname { get; set; }

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

    public double? Ordertotal { get; set; }

    public double? Ordertotalexc { get; set; }

    public string? Totalcost { get; set; }

    public string? Productionstaff { get; set; }

    public string? Status { get; set; }

    public DateTime? Joblastchanged { get; set; }

    public string? Jobstatus { get; set; }

    public string? Currency { get; set; }

    public double? Exchangerate { get; set; }

    public int? ProfileId { get; set; }

    public double? AudtoHkdrate { get; set; }

    public double? UsdtoHkdrate { get; set; }

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

    public string? ActionStatus { get; set; }

    public DateTime? ActionCheckedDate { get; set; }

    public int? ActionCheckedBy { get; set; }

    public int? WipFlag { get; set; }

    public string? WipComment { get; set; }

    public int? OsNoteCheck { get; set; }

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

    public double? Invoicetotalexcgst { get; set; }

    public double? Credittotalexcgst { get; set; }

    public string? Hkjobstatus { get; set; }

    public int HkJobClosedBy { get; set; }

    public DateTime? HkJobClosingDate { get; set; }

    public long? RoyaltyContract { get; set; }

    public long? CancelledBy { get; set; }

    public DateTime? CancelledDate { get; set; }

    public string? DelStatus { get; set; }

    public long? DelStatusClosedBy { get; set; }

    public DateTime? DelStatusClosedDate { get; set; }

    public double? OrgOrderTotal { get; set; }

    public string? CostingNotes { get; set; }

    public int? PlGroup { get; set; }

    public int? Onhold { get; set; }

    public long? Singleinvoice { get; set; }

    public int? Whid { get; set; }

    public string? Source { get; set; }

    public int? Ocupdatedby { get; set; }

    public DateTime? Oclastupdated { get; set; }

    public string? Notes { get; set; }

    public string? Completionstatus { get; set; }

    public DateTime? Reportdate { get; set; }

    public int? AlreadyNotified { get; set; }

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
}

