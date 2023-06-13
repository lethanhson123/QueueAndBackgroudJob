namespace Data.Databases.Csversion1;

public partial class CaDeleteUserLog : BaseModel
{
    public int Id { get; set; }

    public int? WebAccId { get; set; }

    public string? UserDelete { get; set; }

    public DateTime? DeleteDate { get; set; }

    public DateTime? UpdateDate { get; set; }
}

