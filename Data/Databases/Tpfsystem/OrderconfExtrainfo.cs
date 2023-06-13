namespace Data.Databases.Tpfsystem;

public partial class OrderconfExtrainfo : BaseModel
{
    public int Id { get; set; }

    public int Ordernumber { get; set; }

    public string Field { get; set; } = null!;

    public string Value { get; set; } = null!;
}

