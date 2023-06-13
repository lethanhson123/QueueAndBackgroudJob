namespace Data.Databases.Csversion1;

public partial class Catalogue : BaseModel
{
    public int CatalogueId { get; set; }

    public string? Cataloguename { get; set; }

    public string? Urladdress { get; set; }

    public string? Emailcat { get; set; }

    public string? Emailrec { get; set; }

    public string? Stocknotification { get; set; }

    public string? Catstatus { get; set; }

    /// <summary>
    /// Display is used for inventory access
    /// </summary>
    public string? Display { get; set; }

    public int IsEvent { get; set; }

    public string? Cataloguegroup { get; set; }

    public string? Folder { get; set; }

    public string? FreeNumber { get; set; }

    public string? TpfcontactName { get; set; }

    public string? Login { get; set; }

    public string? Freightcat { get; set; }

    public string? Payoptions { get; set; }

    public string? Sellcurrency { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? Code { get; set; }

    public long? Staffid { get; set; }

    public long? ClientId { get; set; }

    public string? SendwithGoods { get; set; }

    public string? ToBeInvoiced { get; set; }

    public long? BdcNo { get; set; }

    public int? OrderingSystem { get; set; }

    public string? Googleid { get; set; }

    public int? DefaultEntityId { get; set; }

    public bool? AutoDeliveryRequest { get; set; }

    public string? Assetsfolder { get; set; }

    public bool? PartofReportingSystem { get; set; }

    public bool? UsingDotNet { get; set; }

    public int? LivehelpId { get; set; }

    /// <summary>
    /// If catalogue shares inventory of another cataogue as base stock, then refer to this u.. used by Personalisation REPORTING SP
    /// </summary>
    public int? InvCatalogueId { get; set; }

    public string? Magentokey { get; set; }

    public DateTime Lastmodified { get; set; }

    public long? ReorderNo { get; set; }

    public bool IsAutoApproved { get; set; }

    public long? CreateBy { get; set; }
}

