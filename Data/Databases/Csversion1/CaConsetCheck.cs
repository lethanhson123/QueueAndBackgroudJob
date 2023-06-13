namespace Data.Databases.Csversion1;

public partial class CaConsetCheck : BaseModel
{
    public int Id { get; set; }

    public int? IsPkProid { get; set; }

    public bool? IsConset { get; set; }

    public int? Qty { get; set; }
}

