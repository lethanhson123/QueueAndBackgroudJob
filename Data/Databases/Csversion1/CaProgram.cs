namespace Data.Databases.Csversion1;

public partial class CaProgram : BaseModel
{
    public int Id { get; set; }

    public string? ProgramId { get; set; }

    public string? SeasonId { get; set; }

    public string? EntityId { get; set; }

    public string? ProgramType { get; set; }

    public string? ProgramStartDate { get; set; }

    public string? ProgramCoordName { get; set; }

    public string? ProgramCoordPhone { get; set; }

    public string? ProgrameCoordEmail { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateTime? DeliveryDate1 { get; set; }

    public DateTime? DeliveryDate2 { get; set; }

    public string? ProgramName { get; set; }
}

