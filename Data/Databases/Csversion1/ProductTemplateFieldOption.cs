namespace Data.Databases.Csversion1;

public partial class ProductTemplateFieldOption : BaseModel
{
    public int Id { get; set; }

    public int TemplatefieldId { get; set; }

    public string Value { get; set; } = null!;

    public int Position { get; set; }

    public DateTime? Lastmodified { get; set; }
}

