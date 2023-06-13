namespace Data.Databases.Csversion1;

public partial class VoucherHistoryTuanBak : BaseModel
{
    public int Id { get; set; }

    public int VoucherId { get; set; }

    public decimal Amount { get; set; }

    public string Transactiontype { get; set; } = null!;

    public DateTime Transactiondate { get; set; }

    public int Who2blame { get; set; }

    public int? ReferenceId { get; set; }

    public string? Referencetype { get; set; }

    public string? Notes { get; set; }

    public bool Active { get; set; }
}

