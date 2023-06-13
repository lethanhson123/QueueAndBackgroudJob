namespace Data.Databases.OnlineSyncData;

public partial class Account : BaseModel
{
    public long Id { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int StoreId { get; set; }

    public DateTime? ApprovalDate { get; set; }

    public DateTime? LastLoginDate { get; set; }

    public bool IsLocked { get; set; }

    public string? PasswordQuestion { get; set; }

    public string? PasswordAnswer { get; set; }

    public string? ActivationToken { get; set; }

    public bool EmailConfirmed { get; set; }

    public string? SecurityStamp { get; set; }

    public string? PhoneNumber { get; set; }

    public bool PhoneNumberConfirmed { get; set; }

    public bool TwoFactorEnabled { get; set; }

    public DateTime? LockoutEndDateUtc { get; set; }

    public bool LockoutEnabled { get; set; }

    public int AccessFailedCount { get; set; }

    public long CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public long UpdatedBy { get; set; }

    public DateTime UpdatedDate { get; set; }

    public int Status { get; set; }

    public virtual ICollection<AccountLogin> AccountLogins { get; } = new List<AccountLogin>();

    public virtual ICollection<AccountRole> AccountRoles { get; } = new List<AccountRole>();
}

