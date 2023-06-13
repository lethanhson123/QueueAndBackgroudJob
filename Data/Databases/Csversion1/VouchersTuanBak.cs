namespace Data.Databases.Csversion1;

public partial class VouchersTuanBak : BaseModel
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Sequence { get; set; }

    public double? Creditvalue { get; set; }

    public int? Prodetailid { get; set; }

    public string Status { get; set; } = null!;

    public int? CatalogueId { get; set; }

    public double? Originalvalue { get; set; }

    public string? Currency { get; set; }

    public DateTime Created { get; set; }

    public DateTime Expiry { get; set; }

    public decimal MinimumSpend { get; set; }

    public int RequiresActivation { get; set; }

    public string? Orderno { get; set; }

    public string? Notes { get; set; }

    public bool Deactivate { get; set; }
}

