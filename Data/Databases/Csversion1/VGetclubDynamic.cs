namespace Data.Databases.Csversion1;

public partial class VGetclubDynamic : BaseModel
{
    public int Id { get; set; }

    public int? IdCaTypes { get; set; }

    public int? IdCaBbl { get; set; }

    public int? IdCaSub { get; set; }

    public bool? IsDisplay { get; set; }

    public int IdproductType { get; set; }

    public string? NameType { get; set; }

    public int Idbblclub { get; set; }

    public string? Name { get; set; }

    public string? ClubCode { get; set; }
}

