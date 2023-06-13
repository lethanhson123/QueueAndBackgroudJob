namespace Data.Databases.TPFServices;

public partial class ImportTransaction : BaseModel
{
    public int Id { get; set; }

    public string? ImportType { get; set; }

    public string? FileName { get; set; }

    public int? RunningSeason { get; set; }

    public int? ClientId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool? IsActive { get; set; }

    public int? TotalRecord { get; set; }

    public int? TotalValid { get; set; }

    public int? TotalRejected { get; set; }

    public int? ParentKey { get; set; }

    public string? Status { get; set; }
}

