namespace Data.Databases.Csversion1;

public partial class VSwiWebAccount : BaseModel
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? ContactFirstname { get; set; }

    public string? ContactLastname { get; set; }

    public string? ContactAddress { get; set; }

    public string? ContactAddress2 { get; set; }

    public string? ContactSuburb { get; set; }

    public string? ContactState { get; set; }

    public string? ContactPostcode { get; set; }

    public string? ContactEmail { get; set; }

    public string? ContactCountry { get; set; }

    public string? ContactPhone { get; set; }

    public string? DeliveryFirstname { get; set; }

    public string? DeliveryLastname { get; set; }

    public string? DeliveryAddress { get; set; }

    public string? DeliveryAddress2 { get; set; }

    public string? DeliverySuburb { get; set; }

    public string? DeliveryState { get; set; }

    public string? DeliveryPostcode { get; set; }

    public string? DeliveryCountry { get; set; }

    public string BillingFirstname { get; set; } = null!;

    public string BillingLastname { get; set; } = null!;

    public string? BillingAddress { get; set; }

    public string? BillingAddress2 { get; set; }

    public string? BillingSuburb { get; set; }

    public string? BillingState { get; set; }

    public string? BillingPostcode { get; set; }

    public string? BillingCountry { get; set; }

    public string Status { get; set; } = null!;

    public int WebAccId { get; set; }

    public string RoleName { get; set; } = null!;

    public int RoleId { get; set; }

    public string? RoleDescription { get; set; }

    public int? Updateby { get; set; }

    public string? UpdateByName { get; set; }

    public string? Createby { get; set; }

    public string? CreateByName { get; set; }

    public DateTime? Createdate { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string AccessStatus { get; set; } = null!;

    public long ClientId { get; set; }

    public int Catalogueid { get; set; }
}

