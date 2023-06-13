namespace Data.Databases.CMS_EMBERPLUS;

public partial class ImpLookupTable : BaseModel
{
    public long Id { get; set; }

    public string? ProgramId { get; set; }

    public long? CompanyId { get; set; }

    public string? Type { get; set; }

    public string? ItemSets { get; set; }

    public decimal? Credit { get; set; }

    public string? Ecard { get; set; }

    public string? Ecertificate { get; set; }

    public string? CardDirects { get; set; }

    public string? RedeemOnlyItems { get; set; }

    public string? RedeemOptOutItems { get; set; }

    public byte? Status { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}

