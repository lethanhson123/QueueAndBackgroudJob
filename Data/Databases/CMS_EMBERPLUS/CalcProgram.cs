namespace Data.Databases.CMS_EMBERPLUS;

public partial class CalcProgram : BaseModel
{
    public long Id { get; set; }

    public string ProgramId { get; set; } = null!;

    public string? ProgramType { get; set; }

    public string? ProgramName { get; set; }

    public string? ProgramTerm { get; set; }

    public string? CoordinatorFirstName { get; set; }

    public string? CoordinatorLastName { get; set; }

    public bool? IsActive { get; set; }

    public long? CaclEntityId { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public bool? Approved { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }
}
