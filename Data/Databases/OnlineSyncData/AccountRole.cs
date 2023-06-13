namespace Data.Databases.OnlineSyncData;

public partial class AccountRole : BaseModel
{
    public long AccountId { get; set; }

    public long RoleId { get; set; }

    public virtual Account Account { get; set; } = null!;
}

