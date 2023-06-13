namespace Data.Databases.OnlineSyncData;

public partial class AccountRegistrationToken : BaseModel
{
    public long Id { get; set; }

    public long? AccountId { get; set; }

    public string Token { get; set; } = null!;
}

