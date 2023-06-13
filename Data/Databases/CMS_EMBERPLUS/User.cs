namespace Data.Databases.CMS_EMBERPLUS;

public partial class User : BaseModel
{
    public string UserId { get; set; } = null!;

    public string? AccountId { get; set; }

    public string? PassWord { get; set; }

    public string? LoginToken { get; set; }

    public DateTime? LastLoginDate { get; set; }

    public string? LoginIp { get; set; }

    public long? Timestamp { get; set; }

    public string? UserName { get; set; }

    public string? NickName { get; set; }

    public string? PhotoUrl { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public int? Sex { get; set; }

    public int? Age { get; set; }

    public DateTime? Birthday { get; set; }

    public string? Address { get; set; }

    public string? ZipCode { get; set; }

    public string? CreateBy { get; set; }

    public string? CreatebyName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public int? Status { get; set; }

    public string? Description { get; set; }

    public long? UserTypeId { get; set; }

    public decimal? Credit { get; set; }

    public string? ResetPasswordToken { get; set; }

    public DateTime? LastResetPasswordDate { get; set; }

    public int? AccountStatus { get; set; }

    public int? CountError { get; set; }

    public int? CompanyId { get; set; }

    public string? OrgId { get; set; }

    public string? Test { get; set; }

    public string? TreeId { get; set; }

    public string? ParentId { get; set; }

	public IEnumerable<Data.Databases.CMS_EMBERPLUS.UserRoleRelation> Roles { get; set; }	
}

