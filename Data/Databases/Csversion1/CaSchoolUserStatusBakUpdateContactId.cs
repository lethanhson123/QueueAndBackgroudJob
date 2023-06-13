namespace Data.Databases.Csversion1;

public partial class CaSchoolUserStatusBakUpdateContactId : BaseModel
{
    public int Id { get; set; }

    public int? TransId { get; set; }

    public string? ContactId { get; set; }

    public string? ContactEmail { get; set; }

    public string? ContactName { get; set; }

    public string? ContactPhone { get; set; }

    public string? AccountStatus { get; set; }

    public int? EntityId { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public bool? CreatedOrder { get; set; }

    public DateTime? CreatedOrderDate { get; set; }

    public string? DefaultBbl { get; set; }

    public string? GigyaId { get; set; }

    public string? LegacyId { get; set; }
}

