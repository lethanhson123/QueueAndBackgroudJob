namespace Data.Databases.Tpf2003;

public partial class Paypalclient : BaseModel
{
    public long Id { get; set; }

    public string Payerid { get; set; } = null!;

    public string? Companyname { get; set; }

    public string? Fname { get; set; }

    public string? Lname { get; set; }

    public string? Attention { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Postcode { get; set; }

    public string? Countrycode { get; set; }

    public string? Country { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Payerstatus { get; set; }

    public string? Addressstatus { get; set; }

    public string? Status { get; set; }

    public DateTime? Lastupdated { get; set; }
}

