namespace Data.Databases.Csversion1;

public partial class CheckNewPrice : BaseModel
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public double? CaPrice { get; set; }

    public double? StatePrice { get; set; }

    public double? CentrePrice { get; set; }
}

