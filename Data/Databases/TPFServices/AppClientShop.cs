namespace Data.Databases.TPFServices;

public partial class AppClientShop : BaseModel
{
    public int Id { get; set; }

    public string? ClientName { get; set; }

    public int? RunningSeason { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool? IsActive { get; set; }

    public int? ShopId { get; set; }
}

