namespace Data.Databases.Csversion1;

public partial class CaPropackDetail : BaseModel
{
    public int Id { get; set; }

    public int? ProDetailCode { get; set; }

    public int? IdProductTypes { get; set; }

    public int? IdSubType { get; set; }
}

