namespace Data.Databases.Tpfsystem;

public partial class InvoiceDetail : BaseModel
{
    public long Id { get; set; }

    /// <summary>
    /// Invoice Number
    /// </summary>
    public long Invoicenumber { get; set; }

    /// <summary>
    /// Order Number
    /// </summary>
    public long? Ordernumber { get; set; }

    /// <summary>
    /// Order Details Id
    /// </summary>
    public long? Ocdetailid { get; set; }

    /// <summary>
    /// Product Detail ID
    /// </summary>
    public string? Prodetailid { get; set; }

    public double Qty { get; set; }

    public string? Invcode { get; set; }

    /// <summary>
    /// Price: including GST
    /// </summary>
    public double? Price { get; set; }

    /// <summary>
    /// Item Name
    /// </summary>
    public string? Itemname { get; set; }

    public string? Deldetails { get; set; }

    /// <summary>
    /// Price exc GST 
    /// </summary>
    public double? Priceexc { get; set; }

    /// <summary>
    /// Price gst
    /// </summary>
    public double? Pricegst { get; set; }

    /// <summary>
    /// Default GST 10%
    /// </summary>
    public double? Gstratio { get; set; }

    public int? Bsitem { get; set; }

    public string? Tpfcode { get; set; }

    public long? RoyaltyContract { get; set; }

    public double? IPriceTax { get; set; }

    public double? IPriceExc { get; set; }

    public double? PriceInTax { get; set; }

    public double? PriceExTax { get; set; }
}

