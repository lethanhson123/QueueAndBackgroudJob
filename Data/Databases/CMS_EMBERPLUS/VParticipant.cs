namespace Data.Databases.CMS_EMBERPLUS;

public partial class VParticipant : BaseModel
{
    public long UniqueId { get; set; }

    public string ParticipantId { get; set; } = null!;

    public string Fname { get; set; } = null!;

    public string Lname { get; set; } = null!;

    public string PlayerCategory { get; set; } = null!;

    public string FirstTime { get; set; } = null!;

    public string Ssnclub { get; set; } = null!;

    public string ShirtSize { get; set; } = null!;

    public string ShirtName { get; set; } = null!;

    public string? EntId { get; set; }

    public string? EntName { get; set; }

    public string? EntState { get; set; }

    public string OrderId { get; set; } = null!;

    public string OrderStatus { get; set; } = null!;

    public DateTime OrderSendDate { get; set; }

    public DateTime OrderEtadate { get; set; }

    public int? CompanyId { get; set; }
}

