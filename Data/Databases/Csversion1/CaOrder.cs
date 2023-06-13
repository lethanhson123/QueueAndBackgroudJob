namespace Data.Databases.Csversion1;

public partial class CaOrder : BaseModel
{
    public long Id { get; set; }

    public long OrderId { get; set; }

    public double OrderTotal { get; set; }

    public string Status { get; set; } = null!;

    public int? UpdateStatusBy { get; set; }

    public DateTime? DateUpdateStatus { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }
}

