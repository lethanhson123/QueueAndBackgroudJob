namespace Data.Databases.CMS_EMBERPLUS;

public partial class OrderNotification : BaseModel
{
    public string ID { get; set; }

    public long? OrderID { get; set; }

    public DateTime? DateSend { get; set; }

    public string? TypeNotification { get; set; }

    public string? Description { get; set; }
	public int? CompanyID { get; set; }
}
