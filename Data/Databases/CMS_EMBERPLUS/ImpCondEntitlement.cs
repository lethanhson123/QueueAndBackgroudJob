namespace Data.Databases.CMS_EMBERPLUS;

public partial class ImpCondEntitlement : BaseModel
{
    public int Id { get; set; }

    public int SeqId { get; set; }

    public long CompanyId { get; set; }

    public int Status { get; set; }

    public string? Description { get; set; }

    public string? Json { get; set; }

    public string? NoteTitle { get; set; }

    public string? SqlSentence { get; set; }

    public string? ErrorCode { get; set; }

    public string? ErrorMessage { get; set; }

    public decimal? Credit { get; set; }

    public string? Products { get; set; }

    public string? SendDirect { get; set; }

    public string? SendEcard { get; set; }

    public string? CreateAcount { get; set; }

    public string? Condition { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? LastUpdateDate { get; set; }
}

