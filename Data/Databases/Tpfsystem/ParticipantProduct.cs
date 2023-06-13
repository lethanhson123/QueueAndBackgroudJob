namespace Data.Databases.Tpfsystem;

public partial class ParticipantProduct : BaseModel
{
    public int Id { get; set; }

    public string? ProductId { get; set; }

    public string? ProductName { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public bool? Status { get; set; }
}

