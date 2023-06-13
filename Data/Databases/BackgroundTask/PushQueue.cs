
namespace Data.Databases.BackgroundTask;

public partial class PushQueue : BaseModel
{
    public long Id { get; set; }

    public string Action { get; set; } = null!;

    public DateTime? Created { get; set; }

    public string Queue { get; set; } = null!;
}
