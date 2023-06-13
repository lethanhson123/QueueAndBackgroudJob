namespace Data.Databases.Csversion1;

public partial class VCaFindCaEntity : BaseModel
{
    public string RoleName { get; set; } = null!;

    public string EntityId { get; set; } = null!;

    public string? EntityName { get; set; }

    public int WebAccId { get; set; }

    public long ClientId { get; set; }

    public string? DelCompanyname { get; set; }
}

