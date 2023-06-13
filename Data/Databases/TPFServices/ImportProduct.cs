namespace Data.Databases.TPFServices;

public partial class ImportProduct : BaseModel
{
    public int Id { get; set; }

    public int? TransId { get; set; }

    public string? ProductId { get; set; }

    public string? ProductName { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? LastUpdatedDate { get; set; }

    public int? LastUpdatedBy { get; set; }

    public bool? IsActive { get; set; }

    public bool? Approved { get; set; }
}

