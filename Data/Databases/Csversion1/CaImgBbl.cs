namespace Data.Databases.Csversion1;

public partial class CaImgBbl : BaseModel
{
    public int Id { get; set; }

    public int? PkProId { get; set; }

    public string? Bblcode { get; set; }

    public string? Img { get; set; }
}

