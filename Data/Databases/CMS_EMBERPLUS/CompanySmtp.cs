namespace Data.Databases.CMS_EMBERPLUS;

public partial class CompanySmtp : BaseModel
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public int? Status { get; set; }

    public string? CreateBy { get; set; }

    public string? CreatebyName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public int? CompanyReferId { get; set; }

    public string? Smtp { get; set; }

    public int? Port { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? Bcc { get; set; }

    public string? Cc { get; set; }
}

