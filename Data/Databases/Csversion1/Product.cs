namespace Data.Databases.Csversion1;

public partial class Product : BaseModel
{
    public long ProId { get; set; }

    public long? CategoryId { get; set; }

    public string? Code1 { get; set; }

    public string? Code2 { get; set; }

    public string? Proname { get; set; }

    public string? Websafename { get; set; }

    public string? Prodescription { get; set; }

    public string? Pronew { get; set; }

    public string? Prospecial { get; set; }

    public string? Subcategory { get; set; }

    public string? Subcatdesc { get; set; }

    public string? Hasgst { get; set; }

    public double? Proprice { get; set; }

    public double? Propriceexc { get; set; }

    public string? Pricedesc { get; set; }

    public string? Nzdprice { get; set; }

    public string? Discount { get; set; }

    public string? Prodiscprice { get; set; }

    public int? IsPack { get; set; }

    public int IsPersonalised { get; set; }

    public int GenerateVoucherCode { get; set; }

    public int? Moq { get; set; }

    public string? Imagename { get; set; }

    public int? DsmsetRevision { get; set; }

    public string? Duedate { get; set; }

    public short? Dispriority { get; set; }

    public string? Status { get; set; }

    public string? Nismessage { get; set; }

    public string? Buy { get; set; }

    public string? Priceft { get; set; }

    public string? Pricef { get; set; }

    public string? Pricepub { get; set; }

    public double? PLandedcost { get; set; }

    public double? PMinguarantee { get; set; }

    public double? PRoypercent { get; set; }

    public string? Royaltykey { get; set; }

    public double? PRebatepercent { get; set; }

    public string? NonDim { get; set; }

    public string? Lastupdate { get; set; }

    public int? Buffer { get; set; }

    public string? Licencee { get; set; }

    public string? Ownedby { get; set; }

    public string? HiResImg { get; set; }

    public int? VariationId { get; set; }

    public string? ProductionProductColour { get; set; }

    public string? ProductionProductNotes { get; set; }

    public string? OrderNumber { get; set; }

    public long? Pgid { get; set; }

    public string? PReportstatus { get; set; }

    public string? PBostatus { get; set; }

    public string? PInventorystatus { get; set; }

    public int? PReportgroup { get; set; }

    public decimal? PProweight { get; set; }

    public string? LandedcostRef { get; set; }

    public string? FinanceNote { get; set; }

    public double? Newlandedcost { get; set; }

    public string? Financestatus { get; set; }

    public string? Financenotes { get; set; }

    public int? WhId { get; set; }

    public string? DeclarationName { get; set; }

    public decimal? DimLength { get; set; }

    public decimal? DimWidth { get; set; }

    public decimal? DimHeight { get; set; }

    public decimal? DimVolume { get; set; }

    public int? PackedItem { get; set; }

    public decimal? CustomDeclarationValue { get; set; }

    public short ProductionexportId { get; set; }

    public DateTime? Createdate { get; set; }

    public DateTime? Lastupdatedate { get; set; }

    public DateTime Lastmodified { get; set; }

    public int? Createby { get; set; }

    public int? Updateby { get; set; }

    public bool? IsStockable { get; set; }

    public bool IsOpenJob { get; set; }

    public long? ProIdTpf { get; set; }

    public int? IsPrepack { get; set; }

    public bool? IsAutoweight { get; set; }

    public string? VirtualName { get; set; }

    public string? KeysPrid { get; set; }

    public decimal? ProIdOgr { get; set; }

    public bool? IsSendPack { get; set; }

    public bool? IsMultiproId { get; set; }

    public bool? IsClockQty { get; set; }
}

