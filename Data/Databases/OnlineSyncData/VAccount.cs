namespace Data.Databases.OnlineSyncData;

public partial class VAccount : BaseModel
{
    public string UserName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int Status { get; set; }

    public DateTime? ApprovalDate { get; set; }

    public DateTime? LastLoginDate { get; set; }

    public bool IsLocked { get; set; }

    public string? PasswordQuestion { get; set; }

    public string? PasswordAnswer { get; set; }

    public string? ActivationToken { get; set; }

    public string? SecurityStamp { get; set; }

    public string? PhoneNumber { get; set; }

    public bool PhoneNumberConfirmed { get; set; }

    public bool TwoFactorEnabled { get; set; }

    public DateTime? LockoutEndDateUtc { get; set; }

    public bool LockoutEnabled { get; set; }

    public int AccessFailedCount { get; set; }

    public long CreatedById { get; set; }

    public string CreatedBy { get; set; } = null!;

    public long ModeifiedById { get; set; }

    public DateTime CreatedDate { get; set; }

    public string ModeifiedBy { get; set; } = null!;

    public DateTime ModeifiedDate { get; set; }

    public string TextToSearch { get; set; } = null!;
}

