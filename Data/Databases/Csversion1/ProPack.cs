namespace Data.Databases.Csversion1;

public partial class ProPack : BaseModel
{
    public int PkId { get; set; }

    public int PkProId { get; set; }

    public int PkProdetailId { get; set; }

    public int Pkqty { get; set; }

    public string? Pkstatus { get; set; }

    public int? Groupid { get; set; }

    /// <summary>
    /// 1: display on Cart
    /// 0: not display on Cart
    /// </summary>
    public bool? IsDisplay { get; set; }

    /// <summary>
    /// 0 : conset (allow edit qty)
    /// 1: Kit item normal
    /// </summary>
    public bool? IsFix { get; set; }

    public bool? IsSecond { get; set; }
}

