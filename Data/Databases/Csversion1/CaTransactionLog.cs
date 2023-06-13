namespace Data.Databases.Csversion1;

public partial class CaTransactionLog : BaseModel
{
    public int Id { get; set; }

    public int? CreateByWebAccountId { get; set; }

    public int? DeliveryCentreId { get; set; }

    public int? ParticipantId { get; set; }

    public int OrderId { get; set; }

    public string? OrderType { get; set; }

    public string? OrderStatus { get; set; }

    public long? OrderDetailId { get; set; }

    public DateTime? CreateDate { get; set; }
}

