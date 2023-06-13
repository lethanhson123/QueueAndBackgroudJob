namespace Data.Databases.Tpfsystem;

public partial class VCaReminderEmail : BaseModel
{
    public int? EntityId { get; set; }

    public string? Email { get; set; }

    public string? ClubName { get; set; }

    public int EntityType { get; set; }
}

