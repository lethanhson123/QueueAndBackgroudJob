namespace Data.Databases.OnlineSyncData;

public partial class AccountClaim : BaseModel
{
    public long Id { get; set; }

    public long AccountId { get; set; }

    public string? ClaimType { get; set; }

    public string? ClaimValue { get; set; }
}

