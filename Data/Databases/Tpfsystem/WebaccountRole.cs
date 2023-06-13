namespace Data.Databases.Tpfsystem;

public partial class WebaccountRole : BaseModel
{
    public int WebAccId { get; set; }

    public int WebRoleId { get; set; }

    public bool IsInactive { get; set; }
}

