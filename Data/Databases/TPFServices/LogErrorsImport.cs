namespace Data.Databases.TPFServices;

public partial class LogErrorsImport : BaseModel
{
    public int Id { get; set; }

    public int? ClientId { get; set; }

    public string? ReferenceNo { get; set; }

    public string? Type { get; set; }

    public string? Code { get; set; }

    public string? ReturnMessage { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? TransationId { get; set; }
}

