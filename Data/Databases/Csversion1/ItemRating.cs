namespace Data.Databases.Csversion1;

public partial class ItemRating : BaseModel
{
    public int Id { get; set; }

    public int Catalogueid { get; set; }

    public int Proid { get; set; }

    public int? TotalRating { get; set; }

    public int? Votes { get; set; }
}

