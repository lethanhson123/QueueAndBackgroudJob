namespace Data.Databases.Csversion1;

public partial class ProductdetailReference : BaseModel
{
    public int Id { get; set; }

    public int? ProId { get; set; }

    public int? ProdetailiD { get; set; }

    public string? ProdetailCode { get; set; }

    public string? ProdetailName { get; set; }
}

