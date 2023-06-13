namespace Data.Databases.Csversion1;

public partial class CaTypeDetail : BaseModel
{
    public int Id { get; set; }

    public int? IdCaTypes { get; set; }

    public int? IdCaBbl { get; set; }

    public int? IdCaSub { get; set; }

    public bool? IsDisplay { get; set; }
}

