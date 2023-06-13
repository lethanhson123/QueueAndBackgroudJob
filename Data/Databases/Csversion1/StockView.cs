namespace Data.Databases.Csversion1;

public partial class StockView : BaseModel
{
    public bool? IsSendPack { get; set; }

    public bool? IsAutoweight { get; set; }

    public decimal? Prodetailweight { get; set; }

    public int? IsPrepack { get; set; }

    public int? Prodetailid { get; set; }

    public int? Proid { get; set; }

    public int? Categoryid { get; set; }

    public short? Discatpriority { get; set; }

    public int? CatalogueId { get; set; }

    public int Profileid { get; set; }

    public string? Catstatus { get; set; }

    public int IsEvent { get; set; }

    public string Cataloguegroup { get; set; } = null!;

    public string? Tpfcode { get; set; }

    public string? Internalcode { get; set; }

    public string? Barcode { get; set; }

    public string? Prodetailcode { get; set; }

    public string Nondim { get; set; } = null!;

    public int IsPersonalised { get; set; }

    public short ProductionexportId { get; set; }

    public int GenerateVoucherCode { get; set; }

    public string Type { get; set; } = null!;

    public string? Name { get; set; }

    public string? VirtualName { get; set; }

    public string PackedItem { get; set; } = null!;

    public string? Proname { get; set; }

    public string Websafename { get; set; } = null!;

    public string? Prodetailsize { get; set; }

    public string? Prodescription { get; set; }

    public string? Nismessage { get; set; }

    public decimal Weight { get; set; }

    public string Imagename { get; set; } = null!;

    public int DsmsetRevision { get; set; }

    public string? DsmsetName { get; set; }

    public string? Pronew { get; set; }

    public string Prospecial { get; set; } = null!;

    public string Discount { get; set; } = null!;

    public string? Subcategory { get; set; }

    public string? Status { get; set; }

    public string? Prodetailstatus { get; set; }

    public string? Online { get; set; }

    public string PReportstatus { get; set; } = null!;

    public int PReportgroup { get; set; }

    public double PRebatepercent { get; set; }

    public string? Urladdress { get; set; }

    public string? Cataloguename { get; set; }

    public string? Categoryname { get; set; }

    public int Ispack { get; set; }

    public int Iskit { get; set; }

    public string? Ownedby { get; set; }

    public string? Subcatdesc { get; set; }

    public int Defaultprofile { get; set; }

    public string Profilename { get; set; } = null!;

    public string Legacyfield { get; set; } = null!;

    public int? Taxexclusive { get; set; }

    public string? Currency { get; set; }

    public double? Currentprice { get; set; }

    public double? Wasprice { get; set; }

    public double? Gstrate { get; set; }

    public string Hasgst { get; set; } = null!;

    public double? DefaultCurrentprice { get; set; }

    public double? DefaultWasprice { get; set; }

    public double? Proprice { get; set; }

    public double? Propriceexc { get; set; }

    public string? Pricef { get; set; }

    public string? Priceft { get; set; }

    public string? Nzdprice { get; set; }

    public string? Pricepub { get; set; }

    public string? Prodiscprice { get; set; }

    public double PLandedcost { get; set; }

    public decimal? RebatePercentage { get; set; }

    public string? Inventorystatus { get; set; }

    public string? Inventorystatustext { get; set; }

    public double? Prodetailstock { get; set; }

    public long? Custorder { get; set; }

    public double? Available { get; set; }

    public long Qtyonreorder { get; set; }

    public long Backorderqty { get; set; }

    public string Reorderqty { get; set; } = null!;

    public int Reorderlevel { get; set; }

    public double Palletqty { get; set; }

    public double Cartonqty { get; set; }

    public string? BoStatus { get; set; }

    public long Virtualrefid { get; set; }

    public string Unspsc { get; set; } = null!;

    public double Leadtime { get; set; }

    public int Moq { get; set; }

    public int Disporder { get; set; }

    public short Dispriority { get; set; }

    public int TotalRating { get; set; }

    public int Votes { get; set; }

    public int PdWhid { get; set; }

    public int? AvgRating { get; set; }

    public string SeoTitle { get; set; } = null!;

    public string SeoKeywords { get; set; } = null!;

    public string SeoDescription { get; set; } = null!;

    public string SeoImgalt { get; set; } = null!;

    public string SeoImgtitle { get; set; } = null!;

    public string? KitOptionsName { get; set; }
}

