namespace Data.Databases.CMS_EMBERPLUS;

public partial class CustomerService : BaseModel
{
    public long Id { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public int? Status { get; set; }

    public string? CreateBy { get; set; }

    public string? CreatebyName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime LastUpdateDate { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? OrderNumber { get; set; }

    public string? State { get; set; }

    public string? Category { get; set; }
}

