namespace Data.Databases.Csversion1;

public partial class ProductTemplateField : BaseModel
{
    public int Id { get; set; }

    public int TemplateId { get; set; }

    public string Type { get; set; } = null!;

    public string Htmltype { get; set; } = null!;

    public string Label { get; set; } = null!;

    public string Caption { get; set; } = null!;

    public string Defaultvalue { get; set; } = null!;

    public string Placeholder { get; set; } = null!;

    public int Maxlength { get; set; }

    public bool Mandatory { get; set; }

    public string? Capitalisation { get; set; }

    public DateTime Lastmodified { get; set; }
}

