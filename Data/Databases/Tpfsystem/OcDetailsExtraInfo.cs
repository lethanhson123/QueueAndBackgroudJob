namespace Data.Databases.Tpfsystem;

public partial class OcDetailsExtraInfo : BaseModel
{
    public int Id { get; set; }

    public int? OcdetailId { get; set; }

    public string? Title { get; set; }

    public string? Companyname { get; set; }

    public string? Fname { get; set; }

    public string? Lname { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Postcode { get; set; }

    public string? Phone { get; set; }

    public string? Mobile { get; set; }

    public string? Email { get; set; }

    public DateTime? Dob { get; set; }

    public string? Gender { get; set; }

    public string? Emergencycontact { get; set; }

    public string? Emergencycontact2 { get; set; }

    public string? Emergencyphone { get; set; }

    public string? Travelmode { get; set; }

    public string? Itemcode { get; set; }

    public DateTime? DownloadedDate { get; set; }

    public int? DownloadedBy { get; set; }

    public int? DownloadCount { get; set; }

    public string? DietaryReq { get; set; }

    public string? Physicalcon { get; set; }

    public string? Event { get; set; }

    public string? Allergies { get; set; }

    public bool ReportToClub { get; set; }

    public string Status { get; set; } = null!;

    public string? StoreNumberOrCustomerNumber { get; set; }

    public DateTime? PromotionStart { get; set; }

    public DateTime? PromotionEnd { get; set; }

    public string? BrandAwareness { get; set; }

    public int? Growth { get; set; }

    public string? PriorPeriod { get; set; }

    public string? IncreaseRangingFrom { get; set; }

    public string? IncreaseRangingTo { get; set; }

    public string? Acquisition { get; set; }

    public string? AcquisitionDescription { get; set; }

    public int? Catalogue { get; set; }
}

