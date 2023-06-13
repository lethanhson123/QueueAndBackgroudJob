namespace Data.Databases.Csversion1;

public partial class ImportTransactionService : BaseModel
{
    public int TransId { get; set; }

    public string? TransType { get; set; }

    public int? TotalRecords { get; set; }

    public DateTime? ImportDate { get; set; }

    public int? ImportBy { get; set; }

    public string? Status { get; set; }

    public int? TransIdservices { get; set; }

    public int? CaTransId { get; set; }

    public DateTime? CreateDate { get; set; }
}

