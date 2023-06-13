namespace Data.Databases.Csversion1;

public partial class ProductTemplateMap : BaseModel
{
    public int TemplateId { get; set; }

    public int ProductId { get; set; }

    public DateTime? Lastmodified { get; set; }
}

