namespace Data.Databases.Csversion1;

public partial class ComSyncLog : BaseModel
{
    public long Id { get; set; }

    public string? Params { get; set; }

    public string? Ref { get; set; }

    public string? MessErg { get; set; }

    public DateTime CreateDate { get; set; }
}

