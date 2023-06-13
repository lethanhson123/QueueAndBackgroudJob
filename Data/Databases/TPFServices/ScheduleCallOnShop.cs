namespace Data.Databases.TPFServices;

public partial class ScheduleCallOnShop : BaseModel
{
    public int Id { get; set; }

    public string? TypeData { get; set; }

    public string? LinkSubmit { get; set; }

    public DateTime? TimeCall { get; set; }

    public string? StatusData { get; set; }

    public bool? IsCall { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateTime? CreateDate { get; set; }
}

