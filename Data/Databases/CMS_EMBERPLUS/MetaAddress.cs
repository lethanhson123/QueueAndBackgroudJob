namespace Data.Databases.CMS_EMBERPLUS;

public partial class MetaAddress : BaseModel
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? OwnerModule { get; set; }

    public string? OwnerId { get; set; }

    public int? Status { get; set; }

    public string? CreateBy { get; set; }

    public string? CreatebyName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateByName { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? Description { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? CompanyName { get; set; }

    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? AddressLine3 { get; set; }

    public string? Suburb { get; set; }

    public string? State { get; set; }

    public string? PostCode { get; set; }

    public string? Country { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public bool? IsDefault { get; set; }

    public long? CompanyId { get; set; }
}

