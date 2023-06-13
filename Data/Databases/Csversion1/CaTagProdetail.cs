namespace Data.Databases.Csversion1;

public partial class CaTagProdetail : BaseModel
{
    public long Id { get; set; }

    public string? ProdetailCode { get; set; }

    public long? TagId { get; set; }
}

