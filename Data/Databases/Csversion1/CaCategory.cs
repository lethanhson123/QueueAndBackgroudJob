namespace Data.Databases.Csversion1;

public partial class CaCategory : BaseModel
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public bool? IsDisplay { get; set; }
}

