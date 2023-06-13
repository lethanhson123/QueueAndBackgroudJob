namespace Data.Databases.Tpfsystem;

public partial class WebaccountGroup : BaseModel
{
    public int WebAccId { get; set; }

    public int WebGroupId { get; set; }

    public bool IsInactive { get; set; }
}

