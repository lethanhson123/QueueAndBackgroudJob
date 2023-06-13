namespace Data.Databases.ExternalServices;

public partial class WebDomain : BaseModel
{
    public int Id { get; set; }

    public int? Userid { get; set; }

    public string? DomainLink { get; set; }

    public string? Path { get; set; }

    public string? Action { get; set; }
}

