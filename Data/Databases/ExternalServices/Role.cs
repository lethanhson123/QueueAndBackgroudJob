namespace Data.Databases.ExternalServices;

public partial class Role : BaseModel
{
    public int Id { get; set; }

    public string? RoleName { get; set; }

    public virtual ICollection<User> Users { get; } = new List<User>();
}

