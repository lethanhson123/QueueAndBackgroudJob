namespace Data.Databases.Tpfsystem;

public partial class WebPermission : BaseModel
{
    public int AccId { get; set; }

    public int ModuleId { get; set; }

    public bool BeCreated { get; set; }

    public bool BeUpdated { get; set; }

    public bool BeDeleted { get; set; }

    public bool ViewDetail { get; set; }

    public bool IsActived { get; set; }
}

