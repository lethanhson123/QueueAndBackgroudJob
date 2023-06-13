namespace Data.Databases.OnlineSyncData;

public partial class ClientChecking : BaseModel
{
    public int Id { get; set; }

    public string? Client { get; set; }

    public string? Fullname { get; set; }

    public string? Email { get; set; }

    public string? AccountId { get; set; }
}

