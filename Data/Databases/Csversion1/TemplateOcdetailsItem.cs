namespace Data.Databases.Csversion1;

public partial class TemplateOcdetailsItem : BaseModel
{
    public long OcdIdTemplate { get; set; }

    public long? Ocid { get; set; }

    public string? Ocdetailcode { get; set; }

    public string? Ocdetailname { get; set; }

    public string? Ocdetailimage { get; set; }

    public double? Ocdetailqty { get; set; }

    public double? Ocdetailprice { get; set; }

    public double? Ocdetailgst { get; set; }

    public string? Occomments { get; set; }

    public string? Detailstatus { get; set; }

    public string? Itemgroup { get; set; }

    public int? Cpcprodetailcode { get; set; }

    public string? SalesWipStatus { get; set; }

    public DateTime? SalesCheckedDate { get; set; }

    public string? SalesWipNote { get; set; }

    public string? WipArtApproved { get; set; }

    public DateTime? WipArtApprovedDate { get; set; }

    public string? Imagepath { get; set; }

    public int? Itemid { get; set; }

    public int? Pricebreakid { get; set; }

    public int? Listposition { get; set; }

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

    public long? JcItemId { get; set; }

    public int? Whid { get; set; }

    public int? Fromlocationid { get; set; }

    public string? AflType { get; set; }

    public int? AflTypeId { get; set; }

    public long? RawId { get; set; }

    public string? Ref1 { get; set; }

    public string? Ref2 { get; set; }

    public int? Ref3 { get; set; }

    public int Qtynotmet { get; set; }

    public int Qtydifference { get; set; }

    public double? Qtyreceived { get; set; }

    public int? Bsitem { get; set; }

    public int? IsCustom { get; set; }

    public int? Voucherid { get; set; }

    public double? TaxRate { get; set; }

    public int? ShippingClass { get; set; }

    public double? IPriceExc { get; set; }

    public double? IPriceTax { get; set; }

    public double? PriceInTax { get; set; }

    public double? PriceExTax { get; set; }

    public bool? IsSubItem { get; set; }

    public int? Refocdetailid { get; set; }

    public long? SkuId { get; set; }

    public long? Ocdetailid { get; set; }
}

