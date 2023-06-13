namespace Data.Databases.Csversion1;

public partial class LogCancelParticipantOrder : BaseModel
{
    public int Id { get; set; }

    public string? EntityId { get; set; }

    public string? ProgramId { get; set; }

    public string? ParticipantId { get; set; }

    public string? Code { get; set; }

    public string? ReturnMessage { get; set; }

    public string? UnitKeySubmit { get; set; }

    public string? UnitKeyInDb { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? TranId { get; set; }

    public string? KeyTranId { get; set; }

    public string? StatusCode { get; set; }
}

