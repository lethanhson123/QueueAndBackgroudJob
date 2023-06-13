namespace Data.Databases.Csversion1;

public partial class CaPlayerProgram : BaseModel
{
    public int Id { get; set; }

    public string? ProgramId { get; set; }

    public string? PlayerId { get; set; }

    public string? EntityId { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }
}

