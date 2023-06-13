namespace Data.Databases.Tpf2003;

public partial class Paypaltran : BaseModel
{
    public long Id { get; set; }

    public string Token { get; set; } = null!;

    public int Ocid { get; set; }

    public string? Transactionid { get; set; }

    public string? Payerid { get; set; }

    public double Amt { get; set; }

    public double? Fee { get; set; }

    public DateTime Created { get; set; }

    public string? Timestamp { get; set; }

    public double? Amountrecv { get; set; }

    public double? Exchangerate { get; set; }

    public string? Paymenttype { get; set; }

    public string? Paymentstatus { get; set; }

    public string? Pendingreason { get; set; }

    public string? Reasoncode { get; set; }

    public string? Verifysign { get; set; }

    public string Status { get; set; } = null!;

    public string? Txnprocessed { get; set; }

    public string? Copy2order { get; set; }
}

