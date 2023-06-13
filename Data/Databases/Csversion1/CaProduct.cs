namespace Data.Databases.Csversion1;

public partial class CaProduct : BaseModel
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

    public int? IsProducType { get; set; }

    public short Type { get; set; }

    public int? CaProductType { get; set; }

    public int? CaproductTysub { get; set; }

    public int? CaBblclub { get; set; }

    public bool? Bblimg { get; set; }

    public bool? IsCheckQty { get; set; }

    public bool? IsShow { get; set; }

    public bool? IsSendF { get; set; }

    public bool? IsShowProId { get; set; }
}

