namespace Data.Databases.Tpfsystem;

public partial class CaParticipantOrderDetailBackup20201113 : BaseModel
{
    public long Id { get; set; }

    public long ParticipantOrderId { get; set; }

    public string ProductCode { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public int Quantity { get; set; }

    public int WarehouseId { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }
}

