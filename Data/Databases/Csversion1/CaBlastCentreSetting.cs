namespace Data.Databases.Csversion1;

public partial class CaBlastCentreSetting : BaseModel
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }

    public double? ValueJunior { get; set; }

    public double? ValueMaster { get; set; }

    public int? Deliveryday { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? Status { get; set; }
}

