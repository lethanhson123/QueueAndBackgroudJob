namespace Data.Databases.Tpfsystem;

public partial class WebGroupCategory : BaseModel
{
    public int Id { get; set; }

    public int WebGroupId { get; set; }

    public int CategoryId { get; set; }

    public string? ExcludeWebAccId { get; set; }

    public bool IsInactive { get; set; }

    public string? Sign { get; set; }

    public int? DefaultPriceId { get; set; }

    public int? RrppriceId { get; set; }

    public string? Description { get; set; }
}

