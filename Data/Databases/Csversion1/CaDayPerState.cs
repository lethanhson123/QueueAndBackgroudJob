namespace Data.Databases.Csversion1;

public partial class CaDayPerState : BaseModel
{
    public int Id { get; set; }

    public string? State { get; set; }

    public int? Days { get; set; }
}

