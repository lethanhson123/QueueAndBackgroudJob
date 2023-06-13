namespace Data.Databases.Csversion1;

public partial class Tagmap : BaseModel
{
    public int Id { get; set; }

    public int? Proid { get; set; }

    public int Tagid { get; set; }

    public int? Priority { get; set; }

    public DateTime Lastmodified { get; set; }
}

