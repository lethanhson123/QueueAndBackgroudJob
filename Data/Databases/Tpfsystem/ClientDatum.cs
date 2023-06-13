namespace Data.Databases.Tpfsystem;

public partial class ClientDatum : BaseModel
{
    public long ClientId { get; set; }

    public string? ClientRefId { get; set; }

    public long? AccId { get; set; }

    public long? HkaccId { get; set; }

    public int? OldAccId { get; set; }

    public long? TnId { get; set; }

    public string? Fname { get; set; }

    public string? Lname { get; set; }

    public string? Companyname { get; set; }

    public string? Position { get; set; }

    public string? Abn { get; set; }

    public string? Addr1 { get; set; }

    public string? OptAddress1 { get; set; }

    public string? Addr2 { get; set; }

    public string? Addr3 { get; set; }

    public string? Postcode { get; set; }

    public string? Sortcode { get; set; }

    public string? Email { get; set; }

    public string? Mobile { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public string? Lastchange { get; set; }

    public string? Done { get; set; }

    public DateTime? ModDate { get; set; }

    public string Currency { get; set; } = null!;

    public string? Country { get; set; }

    public string? Accounttype { get; set; }

    public string? Department { get; set; }

    public string? ClientNumber { get; set; }

    public string? Approval { get; set; }

    public DateTime? Dob { get; set; }

    public string? Notes { get; set; }

    public string? Costcentre { get; set; }

    public string? Dealername { get; set; }

    public string? Dealercode { get; set; }

    public string? OktoSpam { get; set; }

    public int? DefaultBillingId { get; set; }

    public int? DefaultDelId { get; set; }

    public int? StatusUpdateBy { get; set; }

    public DateTime? StatusUpdateOn { get; set; }

    public long? AuthorisedAddressId { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? Createby { get; set; }

    public string? Status { get; set; }

    public DateTime? AccLastTransferred { get; set; }

    public int? AccTransferredBy { get; set; }

    public string? CatalogueClient { get; set; }

    /// <summary>
    /// userid from custdata
    /// </summary>
    public long? Custid { get; set; }

    public long? ContactAddrId { get; set; }

    public long? BillingAddrId { get; set; }

    public string? BillingCompanyname { get; set; }

    public string? BillingAttention { get; set; }

    public string? BillingPhone { get; set; }

    public string? BillingFax { get; set; }

    public string? BillingMobile { get; set; }

    public string? BillingEmail { get; set; }

    public long? DelAddrId { get; set; }

    public string? DelCompanyname { get; set; }

    public string? DelAttention { get; set; }

    public string? DelPhone { get; set; }

    public string? DelFax { get; set; }

    public string? DelMobile { get; set; }

    public string? DelEmail { get; set; }

    public string? DelSpecialinstructions { get; set; }

    public string? TempAbn { get; set; }

    public bool? Emarketing { get; set; }
}

