namespace Data.Databases.CMS_EMBERPLUS;

public partial class UserType : BaseModel
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

    public decimal? Discount { get; set; }

    public int? DiscountType { get; set; }

    public int? Level { get; set; }

    public string? TreeId { get; set; }

    public long? ParentId { get; set; }

    public bool? IsDefault { get; set; }

    public bool? IsCreate { get; set; }

    public bool? IsOrder { get; set; }

    public bool? IsUseCredit { get; set; }

    public bool? IsSupperAdmin { get; set; }

    public string? OrgId { get; set; }

    public int? CompanyId { get; set; }

    public string? Permissions { get; set; }

    public int? DisplayOrder { get; set; }

    public bool? IsFreeShipping { get; set; }
}

