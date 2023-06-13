namespace Data.Databases.CMS_EMBERPLUS;

public partial class ProductWaveHouse : BaseModel
{
    public long Id { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public int? Status { get; set; }

    public string? CreateBy { get; set; }

    public string? CreatebyName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public long? ProductId { get; set; }

    public long? Skuid { get; set; }

    public int? WaveHouse { get; set; }

    public int? OnStock { get; set; }

    public int? Available { get; set; }

    public int? OnOrder { get; set; }
}

