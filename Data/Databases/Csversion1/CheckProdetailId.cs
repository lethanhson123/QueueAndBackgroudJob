namespace Data.Databases.Csversion1;

public partial class CheckProdetailId : BaseModel
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Descriptions { get; set; }

    public string? Colours { get; set; }

    public string? Size { get; set; }

    public string ProdetailId { get; set; } = null!;
}

