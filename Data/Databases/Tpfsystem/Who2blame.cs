namespace Data.Databases.Tpfsystem;

public partial class Who2blame : BaseModel
{
    public int Id { get; set; }

    public int Staffid { get; set; }

    public DateTime Date { get; set; }

    public string What { get; set; } = null!;

    public string? Details { get; set; }
}

