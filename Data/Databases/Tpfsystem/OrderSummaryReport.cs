namespace Data.Databases.Tpfsystem;

public partial class OrderSummaryReport : BaseModel
{
    public long Id { get; set; }

    public long JobId { get; set; }

    /// <summary>
    /// AUD
    /// </summary>
    public double? Ordertotal { get; set; }

    /// <summary>
    /// AUD
    /// </summary>
    public double? Ordertotalexc { get; set; }

    /// <summary>
    /// AUD
    /// </summary>
    public double? Invoicetotal { get; set; }

    /// <summary>
    /// AUD
    /// </summary>
    public double? Invoicetotalexc { get; set; }

    /// <summary>
    /// AUD
    /// </summary>
    public double? Credittotal { get; set; }

    /// <summary>
    /// AUD
    /// </summary>
    public double? Credittotalexc { get; set; }

    /// <summary>
    /// AUD - Payment received from client
    /// </summary>
    public double? ReceiptTotal { get; set; }

    /// <summary>
    /// AUD
    /// </summary>
    public double? Pototal { get; set; }

    /// <summary>
    /// AUD
    /// </summary>
    public double? Pototalexc { get; set; }

    /// <summary>
    /// AUD
    /// </summary>
    public double? SupInvoicetotal { get; set; }

    /// <summary>
    /// AUD
    /// </summary>
    public double? SupInvoicetotalexc { get; set; }

    /// <summary>
    /// AUD
    /// </summary>
    public double? SupCredittotal { get; set; }

    /// <summary>
    /// AUD
    /// </summary>
    public double? SupCredittotalexc { get; set; }

    /// <summary>
    /// AUD
    /// </summary>
    public double? Freightcost { get; set; }

    /// <summary>
    /// AUD
    /// </summary>
    public double? Freightcostexc { get; set; }

    /// <summary>
    /// AUD
    /// </summary>
    public double? Studiocost { get; set; }

    /// <summary>
    /// AUD
    /// </summary>
    public double? CompletedStudioCost { get; set; }

    /// <summary>
    /// AUD
    /// </summary>
    public double? OrderAdjexc { get; set; }

    /// <summary>
    /// AUD
    /// </summary>
    public double? InvoiceAdjexc { get; set; }

    /// <summary>
    /// AUD
    /// </summary>
    public double? PoAdjexc { get; set; }

    /// <summary>
    /// AUD
    /// </summary>
    public double? SupInvoiceAdjexc { get; set; }

    public string? Systemnote { get; set; }
}

