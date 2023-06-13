namespace Data.Databases.TPFServices;

public partial class FfApiclient : BaseModel
{
    public int ClientId { get; set; }

    public string? ClientName { get; set; }

    public string? Email { get; set; }

    public int? FormatId { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? CreateBy { get; set; }
}

