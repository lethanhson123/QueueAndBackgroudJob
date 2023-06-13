namespace Data.Databases.CMS_EMBERPLUS;

public partial class UserAccount : BaseModel
{
    public string AccountId { get; set; } = null!;

    public string? UserName { get; set; }

    public string? PassWord { get; set; }

    public string? Email { get; set; }

    public string? CreateBy { get; set; }

    public string? CreatebyName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public int? Status { get; set; }

    public string? Description { get; set; }
}

