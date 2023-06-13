namespace Data.Databases.Csversion1;

public partial class FinanceCurrency : BaseModel
{
    public int Id { get; set; }

    public int EntityId { get; set; }

    public int CurrencyId { get; set; }

    public string? Currency { get; set; }

    public double Exchangerate { get; set; }

    public string? UnicodeSymbol { get; set; }

    public string? Remarks { get; set; }

    public DateTime? Lastupdate { get; set; }

    public int? Updateby { get; set; }

    /// <summary>
    /// Client Site Use ONLY
    /// </summary>
    public string? Currency2 { get; set; }

    /// <summary>
    /// Client Site Use ONLY
    /// </summary>
    public double Webrate { get; set; }

    /// <summary>
    /// Client Site Use ONLY
    /// </summary>
    public DateTime? WebUpdate { get; set; }

    public string Status { get; set; } = null!;
}

