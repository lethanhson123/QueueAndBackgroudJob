namespace Data.Databases.OnlineSyncData;

public partial class ShopifyMembershipInfoTmp : BaseModel
{
    public int Id { get; set; }

    public string? PoNumber { get; set; }

    public string? Sku { get; set; }

    public int? Qty { get; set; }

    public string? DiscountCode { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Address { get; set; }

    public string? PhoneNumber { get; set; }

    public int? Status { get; set; }

    public int? RefId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? Note { get; set; }

    public string? RefNote { get; set; }
}

