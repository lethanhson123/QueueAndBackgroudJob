namespace Data.Databases.Csversion1;

public partial class CaPlayerProductLog : BaseModel
{
    public int Id { get; set; }

    public string? TpfprodId { get; set; }

    public string? Colours { get; set; }

    public string? Size { get; set; }

    public string? Input { get; set; }

    public string? ProgramRefId { get; set; }

    public string? PlayerId { get; set; }

    public string? CaEntityId { get; set; }

    public string? Status { get; set; }

    public string? Descriptions { get; set; }

    public string? Sources { get; set; }

    public string? Action { get; set; }

    public DateTime? CreatedDate { get; set; }
}

