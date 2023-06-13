namespace Data.Databases.Csversion1;

public partial class VCablastCentreDayPerStateStateSchool : BaseModel
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }

    public double? Value { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int Cadayid { get; set; }

    public string? State { get; set; }

    public int? Days { get; set; }

    public int Castateid { get; set; }

    public string? StateSchoolName { get; set; }

    public DateTime? StartDay { get; set; }

    public DateTime? EndDay { get; set; }
}

