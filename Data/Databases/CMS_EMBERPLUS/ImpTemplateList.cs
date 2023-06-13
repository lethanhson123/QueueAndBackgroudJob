namespace Data.Databases.CMS_EMBERPLUS;

public partial class ImpTemplateList : BaseModel
{
    public long Id { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public int? Status { get; set; }

    public string? Createby { get; set; }

    public string? CreateByName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? TableName { get; set; }

    public int? CompanyId { get; set; }

    public virtual ICollection<ImpMapping> ImpMappings { get; } = new List<ImpMapping>();

    public virtual ICollection<ImpTemplateListDetail> ImpTemplateListDetails { get; } = new List<ImpTemplateListDetail>();

    public virtual ICollection<ImpUploadFileLog> ImpUploadFileLogs { get; } = new List<ImpUploadFileLog>();
}

