namespace Data.Databases.Tpfsystem;

public partial class CaLog : BaseModel
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Description { get; set; }

    public string? Source { get; set; }

    public string? RefId { get; set; }

    public DateTime? Createdate { get; set; }
}

