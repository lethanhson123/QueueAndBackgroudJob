namespace Data.Databases.Tpfsystem;

public partial class Ocdetail : BaseModel
{
    public long Ocdetailid { get; set; }

    public long? Ocid { get; set; }

    public string? Ocdetailcode { get; set; }

    public string? Ocdetailname { get; set; }

    public string? Ocdetailimage { get; set; }

    public double? Ocdetailqty { get; set; }

    public double? Ocdetailprice { get; set; }

    public double? Ocdetailgst { get; set; }

    public string? Occomments { get; set; }

    public string? Detailstatus { get; set; }

    /// <summary>
    /// CPC or Adhoc item
    /// </summary>
    public string? Itemgroup { get; set; }

    /// <summary>
    /// prodetailid in productdetail
    /// </summary>
    public int? Cpcprodetailcode { get; set; }

    public string? SalesWipStatus { get; set; }

    public DateTime? SalesCheckedDate { get; set; }

    public string? SalesWipNote { get; set; }

    public string? WipArtApproved { get; set; }

    public DateTime? WipArtApprovedDate { get; set; }

    public string? Imagepath { get; set; }

    /// <summary>
    /// itemid corresponds to itemid in Csversion1.dbo.myItems
    /// </summary>
    public int? Itemid { get; set; }

    /// <summary>
    /// stores the id of the pricebreak from csversion1.dbo.myPricebreaks that was used to create this ocdetail
    /// </summary>
    public int? Pricebreakid { get; set; }

    /// <summary>
    /// Quotes/orders can have the position of their items reordered. The first item has listposition 0, the second 1, etc.
    /// </summary>
    public int? Listposition { get; set; }

    /// <summary>
    /// The suffix of the quantity and fields relating to prices of myDecoration records. Has 5 possible values: nothing/blank, 2 or 3 or 4 or 5
    /// </summary>
    public string? Suffix { get; set; }

    public long? RoyaltyRef { get; set; }

    public long? Linenumber { get; set; }

    public string? Itemtype { get; set; }

    public string? PackItem { get; set; }

    public long? ItemCatalogueId { get; set; }

    public double? QtyBackOrder { get; set; }

    public double? QtyAvailable { get; set; }

    public string? TpfCode { get; set; }

    public DateTime? DelWipLastChecked { get; set; }

    public long? DelWipUpdateby { get; set; }

    public string? DelWipStatus { get; set; }

    public double? Qtyreserved { get; set; }

    public long? Totalrequest { get; set; }

    public long? Qtysent { get; set; }

    public double? Returnrequest { get; set; }

    public double? Returnreceive { get; set; }

    public string? CancelNotes { get; set; }

    /// <summary>
    /// reference for Job Card ID
    /// </summary>
    public long? JcItemId { get; set; }

    public int? Whid { get; set; }

    public int? Fromlocationid { get; set; }

    public string? AflType { get; set; }

    public int? AflTypeId { get; set; }

    public long? RawId { get; set; }

    public string? Ref1 { get; set; }

    public string? Ref2 { get; set; }

    public int? Ref3 { get; set; }

    /// <summary>
    /// 0/1 determines if the order could not be fulfilled as requested. Either some items had to be moved to back ordered or the item qty fell short.
    /// </summary>
    public int Qtynotmet { get; set; }

    /// <summary>
    /// In the event that an order could not be met at the desired quantity, qtydifferent will tell you how much this particular item fell short (if at all). If qtynotmet = 0 then it means this item could be back ordered, and this field records how many were moved onto back order. If the item cannot be backordered, this should be the difference between ocdetailqty and stockavailable.
    /// </summary>
    public int Qtydifference { get; set; }

    public double? Qtyreceived { get; set; }

    public int? Bsitem { get; set; }

    public int? IsCustom { get; set; }

    public int? Voucherid { get; set; }

    public double? TaxRate { get; set; }

    /// <summary>
    /// Refer to ShippingClass (id matches this int) . AFL_CourierMethods table will contain this ID against the shipping method
    /// </summary>
    public int? ShippingClass { get; set; }

    public double? IPriceExc { get; set; }

    public double? IPriceTax { get; set; }

    public double? PriceInTax { get; set; }

    public double? PriceExTax { get; set; }

    public bool? IsSubItem { get; set; }

    public int? Refocdetailid { get; set; }

    public long? SkuId { get; set; }

    public bool? IsSentToFf { get; set; }
}

