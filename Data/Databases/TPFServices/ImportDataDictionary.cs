namespace Data.Databases.TPFServices;

public partial class ImportDataDictionary : BaseModel
{
    public int Id { get; set; }

    public int ClientId { get; set; }

    public string Type { get; set; } = null!;

    public string Value { get; set; } = null!;

    public DateTime? InsertDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }
}

