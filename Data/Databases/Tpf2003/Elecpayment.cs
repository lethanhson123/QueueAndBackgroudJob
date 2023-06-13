namespace Data.Databases.Tpf2003;

public partial class Elecpayment : BaseModel
{
    public long PayId { get; set; }

    public DateTime? Paydate { get; set; }

    public string? Payfrom { get; set; }

    public string? Custname { get; set; }

    public string? Custno { get; set; }

    public string? Custemail { get; set; }

    public int? OccNo { get; set; }

    public string? Trantype { get; set; }

    public string? Cardtype { get; set; }

    public string? Mmexp { get; set; }

    public string? Yyexp { get; set; }

    public decimal? Amount { get; set; }

    public string? Currency { get; set; }

    public string? Responsecode { get; set; }

    public string? Responsetext { get; set; }

    public string? TxnReference { get; set; }

    public string? Processedby { get; set; }

    /// <summary>
    /// event or tpf
    /// </summary>
    public string? Company { get; set; }

    public string? Source { get; set; }

    /// <summary>
    /// last 4 digits of card number
    /// </summary>
    public string? Cardno { get; set; }

    public string? Bank { get; set; }

    public string? Status { get; set; }
}

