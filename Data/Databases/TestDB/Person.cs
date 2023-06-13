namespace Data.Databases.TestDB;

public partial class Person: BaseModel
{
    public int? PersonId { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }
}
