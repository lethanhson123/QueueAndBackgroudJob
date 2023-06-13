namespace Data.Databases.OnlineSyncData;

public partial class Role : BaseModel
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }
}

