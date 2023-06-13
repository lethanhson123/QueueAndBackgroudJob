namespace Data.Databases.ExternalServices;

public partial class User : BaseModel
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? SecretKey { get; set; }

    public string? Name { get; set; }

    public int? ClientId { get; set; }

    public int? RoleId { get; set; }

    public string? Status { get; set; }

    public virtual Role? Role { get; set; }

    public virtual ICollection<Token> Tokens { get; } = new List<Token>();
}

