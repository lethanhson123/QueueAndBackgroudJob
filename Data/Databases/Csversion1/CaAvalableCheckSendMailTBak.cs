namespace Data.Databases.Csversion1;

public partial class CaAvalableCheckSendMailTBak : BaseModel
{
    public int Id { get; set; }

    public int? EntityId { get; set; }

    public string? Code { get; set; }

    public int? Avalable { get; set; }

    public int? Unavalable { get; set; }

    public string? EntityType { get; set; }

    public string? CalColumnName { get; set; }

    public int? AmountUpdate { get; set; }

    public bool? CheckSendMail { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }
}

