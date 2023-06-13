namespace Data.Databases.Csversion1;

public partial class CaAvalable : BaseModel
{
    public int Id { get; set; }

    public int? EntityId { get; set; }

    public string? Code { get; set; }

    public int? Avalable { get; set; }

    public int? Unavalable { get; set; }

    public string? EntityType { get; set; }

    public string? CalColumnName { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }
}

