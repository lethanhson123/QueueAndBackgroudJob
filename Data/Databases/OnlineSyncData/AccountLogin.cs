namespace Data.Databases.OnlineSyncData;

public partial class AccountLogin : BaseModel
{
    public long AccountId { get; set; }

    public string LoginProvider { get; set; } = null!;

    public string ProviderKey { get; set; } = null!;

    public virtual Account Account { get; set; } = null!;
}

