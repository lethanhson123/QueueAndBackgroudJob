namespace Data.Databases.CMS_EMBERPLUS;

public partial class CheckoutWidget : BaseModel
{
    public string Id { get; set; } = null!;

    public string? Template { get; set; }

    public bool? IsPaypal { get; set; }

    public bool? IsCreditCard { get; set; }

    public string? SucessUrl { get; set; }

    public string? CancelUrl { get; set; }

    public string? ErrorUrl { get; set; }

    public string? EmailUrl { get; set; }

    public bool? IsInvoice { get; set; }

    public bool? IsCod { get; set; }
}
