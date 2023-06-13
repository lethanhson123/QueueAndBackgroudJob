namespace Data.Databases.CMS_EMBERPLUS;

public partial class UserCreditHistory : BaseModel
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public int? Status { get; set; }

    public string? CreateBy { get; set; }

    public string? CreatebyName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? Description { get; set; }

    public string? UserId { get; set; }

    public decimal? InCredit { get; set; }

    public decimal? OutCredit { get; set; }

    public decimal? AfterCredit { get; set; }

    public decimal? BeforeCredit { get; set; }

    public string? InRef { get; set; }

    public string? OutRef { get; set; }
}

