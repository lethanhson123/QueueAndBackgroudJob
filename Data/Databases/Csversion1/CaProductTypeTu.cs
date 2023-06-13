namespace Data.Databases.Csversion1;

public partial class CaProductTypeTu : BaseModel
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? ProductType { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? LastUpdateDate { get; set; }
}

