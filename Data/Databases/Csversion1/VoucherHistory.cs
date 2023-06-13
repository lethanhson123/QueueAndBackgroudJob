namespace Data.Databases.Csversion1;

public partial class VoucherHistory : BaseModel
{
    public int Id { get; set; }

    public int VoucherId { get; set; }

    public decimal Amount { get; set; }

    public string Transactiontype { get; set; } = null!;

    public DateTime Transactiondate { get; set; }

    public int Who2blame { get; set; }

    /// <summary>
    /// An order/credit/etc. number ID
    /// </summary>
    public int? ReferenceId { get; set; }

    /// <summary>
    /// What the referenceID refers to (order, credit, invoice etc.)
    /// </summary>
    public string? Referencetype { get; set; }

    public string? Notes { get; set; }

    public bool? Active { get; set; }
}

