namespace Data.Databases.Tpfsystem;

public partial class OrdersLog : BaseModel
{
    public int Id { get; set; }

    public int Ocid { get; set; }

    public DateTime Date { get; set; }

    public int Who2blame { get; set; }

    public string Reason { get; set; } = null!;
}

