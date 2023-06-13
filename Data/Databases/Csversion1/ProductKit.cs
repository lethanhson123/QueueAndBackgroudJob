namespace Data.Databases.Csversion1;

public partial class ProductKit : BaseModel
{
    public int Id { get; set; }

    public string? ProductType { get; set; }

    public string? ProductCode { get; set; }

    public int? ProId { get; set; }

    public int? ProdetailId { get; set; }

    public string? SubItemList { get; set; }
}

