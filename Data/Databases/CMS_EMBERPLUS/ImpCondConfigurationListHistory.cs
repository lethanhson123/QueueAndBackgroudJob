namespace Data.Databases.CMS_EMBERPLUS;

public partial class ImpCondConfigurationListHistory : BaseModel
{
    public int Id { get; set; }

    public long CompanyId { get; set; }

    public int Status { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public string? Valuescheme { get; set; }

    public string? Createby { get; set; }

    public string? CreateByName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime? LastUpdateDate { get; set; }
}

