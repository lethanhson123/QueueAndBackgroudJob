namespace Data.Databases.TestDB;

public partial class Customer: BaseModel
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Age { get; set; }

    public string? Address { get; set; }
}
