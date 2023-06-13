namespace Data.Databases.CMS_EMBERPLUS;

public partial class Company : BaseModel
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

    public string? Host { get; set; }

    public string? Port { get; set; }

    public string? ImageUrl { get; set; }

    public int? CatalogueId { get; set; }

    public int? ClientId { get; set; }

    public decimal? TaxRate { get; set; }

    public int? CompanyId { get; set; }

    public string? Email { get; set; }

    public int? EmailType { get; set; }

    public string? EmailSender { get; set; }

    public bool? IsEmailSend { get; set; }

    public string? Currency { get; set; }

    public bool? LockForCalculating { get; set; }
}
