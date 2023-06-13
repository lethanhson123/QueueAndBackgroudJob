namespace Data.Databases.Csversion1;

public partial class VCaDetailsPackpl : BaseModel
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Code { get; set; } = null!;

    public int? ProCode { get; set; }

    public int? ProDetailCode { get; set; }

    public string? ProductType { get; set; }

    public string? Size { get; set; }

    public double Price { get; set; }

    public double? Weight { get; set; }

    public string? Descriptions { get; set; }

    public string? Image { get; set; }

    public string? Status { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? StatusProduct { get; set; }

    public string? VirtualCode { get; set; }

    public string? PackType { get; set; }

    public string? BblclubCode { get; set; }

    public int? PPriority { get; set; }

    public short Type { get; set; }

    public int? CaProductType { get; set; }

    public int? CaproductTysub { get; set; }

    public int? CaBblclub { get; set; }

    public int IdBblclub { get; set; }

    public string? Bblname { get; set; }

    public string? BblclunName { get; set; }

    public long ProdetailId { get; set; }

    public long ProId { get; set; }

    public string? Expr3 { get; set; }

    public string? Internalcode { get; set; }

    public string? Tpfname { get; set; }

    public decimal? Prodetailweight { get; set; }

    public string? Prodetailsize { get; set; }

    public double? Prodetailstock { get; set; }

    public string? Prodetailstatus { get; set; }

    public string? Inventorystatus { get; set; }

    public string? Reorderqty { get; set; }

    public long? Qtyonreorder { get; set; }

    public long? Custorder { get; set; }

    public long ReserveQty { get; set; }

    public long? Backorderqty { get; set; }

    public string? BoStatus { get; set; }

    public DateTime? Lastturnontosync { get; set; }

    public string? Sku { get; set; }

    public long? Skuid { get; set; }
}

