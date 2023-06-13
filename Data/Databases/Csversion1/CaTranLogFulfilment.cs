namespace Data.Databases.Csversion1;

public partial class CaTranLogFulfilment : BaseModel
{
    public int TranLogFulfilmentId { get; set; }

    public DateTime? Transdate { get; set; }

    public int? TransId { get; set; }
}

