namespace Data.Databases.Csversion1;

public partial class GroupTransactionFf : BaseModel
{
    public int TransId { get; set; }

    public string? TransType { get; set; }

    public int? TotalRecords { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? Status { get; set; }
}

