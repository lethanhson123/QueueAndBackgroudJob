namespace Data.Databases.Csversion1;

public partial class CataloguePaymentMethod : BaseModel
{
    public int Id { get; set; }

    public int Catalogueid { get; set; }

    public string Type { get; set; } = null!;

    public int Country { get; set; }
}

