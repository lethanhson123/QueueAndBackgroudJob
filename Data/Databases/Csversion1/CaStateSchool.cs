namespace Data.Databases.Csversion1;

public partial class CaStateSchool : BaseModel
{
    public int Id { get; set; }

    public string? StateId { get; set; }

    public string? StateName { get; set; }

    public DateTime? StartDay { get; set; }

    public DateTime? EndDay { get; set; }

    public string? Status { get; set; }
}

