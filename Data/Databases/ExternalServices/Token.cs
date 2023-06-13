namespace Data.Databases.ExternalServices;

public partial class Token : BaseModel
{
    public int TokenId { get; set; }

    public int UserId { get; set; }

    public string AuthToken { get; set; } = null!;

    public DateTime IssuedOn { get; set; }

    public DateTime? ExpiresOn { get; set; }

    public virtual User User { get; set; } = null!;
}

