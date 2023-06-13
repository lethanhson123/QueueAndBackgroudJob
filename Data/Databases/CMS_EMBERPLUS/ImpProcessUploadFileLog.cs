namespace Data.Databases.CMS_EMBERPLUS;

public partial class ImpProcessUploadFileLog : BaseModel
{
    public long Id { get; set; }

    public string? Title { get; set; }

    public long? UploadId { get; set; }

    public long? CompanyId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? EmailType { get; set; }

    public string? Emid { get; set; }

    public string? GroupId { get; set; }

    public string? Usernme { get; set; }

    public bool? HasCard { get; set; }

    public string? Email { get; set; }

    public int? Status { get; set; }

    public string? Template { get; set; }

    public string? TemplateJson { get; set; }
}

