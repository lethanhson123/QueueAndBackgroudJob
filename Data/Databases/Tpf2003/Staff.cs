namespace Data.Databases.Tpf2003;

public partial class Staff : BaseModel
{
    public int StaffId { get; set; }

    public string Fname { get; set; } = null!;

    public string? Lname { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? Psentence { get; set; }

    public string? Dob { get; set; }

    public string? Address { get; set; }

    public string? Suburb { get; set; }

    public string? Postcode { get; set; }

    public string? State { get; set; }

    public string? Country { get; set; }

    public bool? Companyphone { get; set; }

    public string? PhoneNo { get; set; }

    public string? MobNo { get; set; }

    public string? HkNo { get; set; }

    public string? ExtensionNo { get; set; }

    public string? DirectNo { get; set; }

    public string? FaxNo { get; set; }

    public string? Email { get; set; }

    public int? DepartId { get; set; }

    public string? Location { get; set; }

    public string? Startdate { get; set; }

    public string? Enddate { get; set; }

    public string? Staffposition { get; set; }

    public string? Sortcode { get; set; }

    public string? SalesNo { get; set; }

    public string? Bdcno { get; set; }

    public string? Jobtype { get; set; }

    public float? Payrate { get; set; }

    public string? Signon { get; set; }

    public string? Kitchenduty { get; set; }

    public string? Jobdescription { get; set; }

    public string? Interest { get; set; }

    public string? Photo { get; set; }

    public string? Status { get; set; }

    public string? Psallocate { get; set; }

    public string? Quotpermission { get; set; }

    public int? Groupnumber { get; set; }

    public int? PlGroupId { get; set; }

    public string? Contactperson { get; set; }

    public string? Contactphone { get; set; }

    public int? Alapproval { get; set; }

    public string? Manager { get; set; }

    public string? Almngr { get; set; }

    public string? Alaccrued { get; set; }

    public string? Stafflisting { get; set; }

    public int? Companyid { get; set; }

    public string? Skype { get; set; }

    public int? Admin { get; set; }

    public string? Roll { get; set; }

    public DateTime? StartDateLsl { get; set; }
}

