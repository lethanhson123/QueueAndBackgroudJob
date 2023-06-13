namespace Data.Databases.TPFServices;

public partial class TestTable : BaseModel
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Usertype { get; set; } = null!;
}

