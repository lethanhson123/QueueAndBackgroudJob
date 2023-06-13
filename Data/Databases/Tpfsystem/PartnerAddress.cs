namespace Data.Databases.Tpfsystem;

public partial class PartnerAddress : BaseModel
{
    public long AddrId { get; set; }

    public long AccId { get; set; }

    public string? Type { get; set; }

    public string? Street { get; set; }

    public string? Suburb { get; set; }

    public string? State { get; set; }

    public string? Postcode { get; set; }

    public string? Country { get; set; }

    public DateTime? Createdate { get; set; }

    public int? Createby { get; set; }

    public string Status { get; set; } = null!;
}

