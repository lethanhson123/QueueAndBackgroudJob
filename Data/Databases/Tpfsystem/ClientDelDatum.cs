namespace Data.Databases.Tpfsystem;

public partial class ClientDelDatum : BaseModel
{
    public long Id { get; set; }

    /// <summary>
    /// Account ID
    /// </summary>
    public long? AccId { get; set; }

    /// <summary>
    /// Hong Kong Account ID
    /// </summary>
    public long? HkaccId { get; set; }

    /// <summary>
    /// link to client id to display client information details
    /// </summary>
    public long? ClientId { get; set; }

    /// <summary>
    /// client company name
    /// </summary>
    public string? Companyname { get; set; }

    /// <summary>
    /// Attention name for delivery
    /// </summary>
    public string? Attention { get; set; }

    /// <summary>
    /// First Name
    /// </summary>
    public string? Fname { get; set; }

    /// <summary>
    /// Last Name
    /// </summary>
    public string? Lname { get; set; }

    /// <summary>
    /// Client Delivery Address
    /// </summary>
    public string? Addr1 { get; set; }

    public string? OptAddress1 { get; set; }

    /// <summary>
    /// Delivery Suburb
    /// </summary>
    public string? Addr2 { get; set; }

    /// <summary>
    /// Delivery State
    /// </summary>
    public string? Addr3 { get; set; }

    /// <summary>
    /// Delivery Post Code
    /// </summary>
    public string? Postcode { get; set; }

    /// <summary>
    /// Delivery Country
    /// </summary>
    public string? Country { get; set; }

    /// <summary>
    /// email to contact for delivery
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// mobile phone to contact for delivery
    /// </summary>
    public string? Mobile { get; set; }

    /// <summary>
    /// phone to contact for delivery
    /// </summary>
    public string? Phone { get; set; }

    /// <summary>
    /// fax to contact for delivery
    /// </summary>
    public string? Fax { get; set; }

    /// <summary>
    /// Special Instructions
    /// </summary>
    public string? Specialinstructions { get; set; }

    /// <summary>
    /// modify Date
    /// </summary>
    public DateTime? ModDate { get; set; }

    /// <summary>
    /// modify by staffID
    /// </summary>
    public string? Modby { get; set; }

    /// <summary>
    /// client ABN Number
    /// </summary>
    public string? Abn { get; set; }

    public string? Position { get; set; }

    public string? Currency { get; set; }

    /// <summary>
    /// Client Delivery Status: current, inactive, removed,  cancelled, yes
    /// </summary>
    public string? Status { get; set; }

    public virtual PartnerAccount? Acc { get; set; }
}

