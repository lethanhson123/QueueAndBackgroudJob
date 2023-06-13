namespace Data.Databases.Csversion1;

public partial class CaImgSub : BaseModel
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Image { get; set; }

    public bool? IsDisplay { get; set; }
}

