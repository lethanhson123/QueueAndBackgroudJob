namespace Data.Databases.Tpfsystem;

public partial class ClientBilling : BaseModel
{
    public long Id { get; set; }

    /// <summary>
    /// AccountID of Client
    /// </summary>
    public long? AccId { get; set; }

    /// <summary>
    /// Account ID of HK Client
    /// </summary>
    public long? HkaccId { get; set; }

    public long? OldAccId { get; set; }

    public long? ClientId { get; set; }

    public string? Position { get; set; }

    /// <summary>
    /// Client Name to send bill
    /// </summary>
    public string? Attention { get; set; }

    /// <summary>
    /// Client Contact First Name
    /// </summary>
    public string? Fname { get; set; }

    /// <summary>
    /// Client Contact Last Name
    /// </summary>
    public string? Lname { get; set; }

    public string? Department { get; set; }

    /// <summary>
    /// Address to send the bill
    /// </summary>
    public string? Addr1 { get; set; }

    public string? OptAddress1 { get; set; }

    /// <summary>
    /// City to send the bill
    /// </summary>
    public string? Addr2 { get; set; }

    /// <summary>
    /// State to send the bill
    /// </summary>
    public string? Addr3 { get; set; }

    /// <summary>
    /// Postcode to send the bill
    /// </summary>
    public string? Postcode { get; set; }

    /// <summary>
    /// Country to send the bill
    /// </summary>
    public string? Country { get; set; }

    /// <summary>
    /// Client Company Name
    /// </summary>
    public string? Companyname { get; set; }

    /// <summary>
    /// Email
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// Phone
    /// </summary>
    public string? Phone { get; set; }

    /// <summary>
    /// Mobile phone to contact 
    /// </summary>
    public string? Mobile { get; set; }

    public string? Fax { get; set; }

    public string? Abn { get; set; }

    public string? Currency { get; set; }

    public string? VendorNumber { get; set; }

    public string? Notes { get; set; }

    public DateTime? Lastupdate { get; set; }

    public string? Updateby { get; set; }

    /// <summary>
    /// Client Status: current, cancelled, inactive, 
    /// </summary>
    public string? Status { get; set; }

    public virtual PartnerAccount? Acc { get; set; }
}

