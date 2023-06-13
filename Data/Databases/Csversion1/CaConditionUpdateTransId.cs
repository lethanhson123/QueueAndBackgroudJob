namespace Data.Databases.Csversion1;

public partial class CaConditionUpdateTransId : BaseModel
{
    public int Id { get; set; }

    public int? IdCaProductPlayer { get; set; }

    public int? TranLogFulfilmentId { get; set; }

    public DateTime? SendDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public bool? IsUpdate { get; set; }

    public int? StatusCode { get; set; }

    public int? GroupTrainId { get; set; }
}

