namespace Data.Databases.Csversion1;

public partial class CaSchoolUpdateChangeAccount : BaseModel
{
    public int Id { get; set; }

    public string? GyId { get; set; }

    public string? ContactId { get; set; }

    public string? ContactEmail { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? OldAccount { get; set; }

    public string? Type { get; set; }
}

