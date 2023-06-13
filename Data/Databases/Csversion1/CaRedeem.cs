namespace Data.Databases.Csversion1;

public partial class CaRedeem : BaseModel
{
    public long Id { get; set; }

    public int? EntityId { get; set; }

    public int? ProDetailId { get; set; }

    public int? Redeemed { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }
}

