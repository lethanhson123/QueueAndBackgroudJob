namespace Data.Databases.Tpf2003;

public partial class PayTransLog : BaseModel
{
    public int Id { get; set; }

    public long? Ocid { get; set; }

    public string? TypeCards { get; set; }

    public bool? Status { get; set; }

    public string? SubmitContent { get; set; }

    public string? ReturnContent { get; set; }

    public DateTime? SubmitDate { get; set; }

    public DateTime? ReturnDate { get; set; }

    public string? SearchText { get; set; }

    public bool? IsReturn { get; set; }
}

