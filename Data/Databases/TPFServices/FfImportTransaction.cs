namespace Data.Databases.TPFServices;
public partial class FfImportTransaction : BaseModel
{
    public int Id { get; set; }

    public int ClientId { get; set; }

    public int? Season { get; set; }

    public string? Recordtype { get; set; }

    public string? Filename { get; set; }

    public int? FormatId { get; set; }

    public int? TotalRecords { get; set; }

    public DateTime? InsertDate { get; set; }

    public int? InsertBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public string Status { get; set; } = null!;
}

