namespace Data.Databases.Csversion1;

public partial class Zexcel : BaseModel
{
    public string? Source { get; set; }

    public string? TpfprodId { get; set; }

    public string? Name { get; set; }

    public string? Environment { get; set; }

    public double? ReqPackChoice { get; set; }

    public double? ReqShirtSize { get; set; }

    public double? ReqFirstTime { get; set; }

    public double? ReqBatSize { get; set; }

    public double? ReqColour { get; set; }

    public double? ReqSize { get; set; }

    public double? ReqInput { get; set; }

    public double? Prod { get; set; }

    public double? Reg { get; set; }

    public string? RegType { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }
}

