namespace Data.Databases.Csversion1;

public partial class ProPackDynamic : BaseModel
{
    public int Id { get; set; }

    public int ProId { get; set; }

    public int Type { get; set; }

    public int IdtypeSub { get; set; }

    public int Qty { get; set; }

    public bool? IsActive { get; set; }

    public DateTime CreateDate { get; set; }
}

