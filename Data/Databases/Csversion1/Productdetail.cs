namespace Data.Databases.Csversion1;

public partial class Productdetail : BaseModel
{
    public long ProdetailId { get; set; }

    public long ProId { get; set; }

    public string? Prodetailcode { get; set; }

    public string? Internalcode { get; set; }

    public string? Tpfname { get; set; }

    public decimal? Prodetailweight { get; set; }

    public string? Prodetailsize { get; set; }

    public string? Othersize { get; set; }

    public double? Prodetailstock { get; set; }

    public string? Prodetailstatus { get; set; }

    public string? Inventorystatus { get; set; }

    public string? Reorderqty { get; set; }

    public long? Qtyonreorder { get; set; }

    public long? Custorder { get; set; }

    public long ReserveQty { get; set; }

    public long? Backorderqty { get; set; }

    public string? BoStatus { get; set; }

    public double? Rebatepercent { get; set; }

    public int? Disporder { get; set; }

    public double? Landedcost { get; set; }

    public int? Reorderlevel { get; set; }

    public string? ReportStatus { get; set; }

    public int? ReportGroup { get; set; }

    public decimal? MinGuarantee { get; set; }

    public string? RoyalPercent { get; set; }

    public long? VirtualRefId { get; set; }

    public long? Qtysoldmonth0 { get; set; }

    public long? Qtysoldmonth1 { get; set; }

    public long? Qtysoldmonth2 { get; set; }

    public long? Qtysoldmonth3 { get; set; }

    public long? Qtysoldmonth4 { get; set; }

    public long? Qtysoldmonth5 { get; set; }

    public long? Qtysold6month { get; set; }

    public double? LeadTime { get; set; }

    public int? MinReorderQty { get; set; }

    public long? GroupNumber { get; set; }

    public long? LevelNumber { get; set; }

    public long? Substitute { get; set; }

    public string? Unspc { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreateBy { get; set; }

    public int? Whid { get; set; }

    public int? Wh1 { get; set; }

    public int? Wh2 { get; set; }

    public int? Wh3 { get; set; }

    public int? Wh4 { get; set; }

    public int? Wh5 { get; set; }

    public int? Wh6 { get; set; }

    public int? Wh7 { get; set; }

    public int? Wh8 { get; set; }

    public int? Wh9 { get; set; }

    public int? Opt0 { get; set; }

    public int? Opt1 { get; set; }

    public int? Opt2 { get; set; }

    public int? Opt3 { get; set; }

    public int? Opt4 { get; set; }

    public int? Opt5 { get; set; }

    public int? Opt6 { get; set; }

    public int? Opt7 { get; set; }

    public int? Opt8 { get; set; }

    public int? Opt9 { get; set; }

    public double? CartonQty { get; set; }

    public double? PalletQty { get; set; }

    public string? Financeref { get; set; }

    public long? Custorder1 { get; set; }

    public long? Custorder2 { get; set; }

    public long? Custorder3 { get; set; }

    public long? Custorder4 { get; set; }

    public long? Custorder5 { get; set; }

    public long? Custorder6 { get; set; }

    public long? Custorder7 { get; set; }

    public long? Custorder8 { get; set; }

    public long? Custorder9 { get; set; }

    public long? Custorder10 { get; set; }

    public string? Barcode { get; set; }

    public DateTime? Lastupdate { get; set; }

    public DateTime Lastmodified { get; set; }

    public int? DtPriority { get; set; }

    public bool? ToSync { get; set; }

    public short? ApprovalStatus { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public long? ApprovedBy { get; set; }

    public DateTime? Lastturnontosync { get; set; }

    public string? Sku { get; set; }

    public long? Skuid { get; set; }

    /// <summary>
    /// Real stock code from TPF Inventory System - For reporting use
    /// </summary>
    public string? Skucode { get; set; }

    public bool? IsSecond { get; set; }

    public long? KitSize { get; set; }

    public string? KitOptionsName { get; set; }

    public string? KeysPrPd { get; set; }

    public bool? IsAvailableStock { get; set; }

    public bool? IsPackStock { get; set; }

    public bool? IsShippingFee { get; set; }
}

