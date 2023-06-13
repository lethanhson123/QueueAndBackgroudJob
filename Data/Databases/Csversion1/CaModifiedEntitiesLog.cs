namespace Data.Databases.Csversion1;

public partial class CaModifiedEntitiesLog : BaseModel
{
    public int LogId { get; set; }

    public string? Xml { get; set; }

    public string? ModifiedType { get; set; }

    public DateTime? CreatedDate { get; set; }
}

