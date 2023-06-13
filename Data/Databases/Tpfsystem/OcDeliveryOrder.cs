namespace Data.Databases.Tpfsystem;

public partial class OcDeliveryOrder : BaseModel
{
    public long DelorderId { get; set; }

    public int? Catalogueid { get; set; }

    public long? Whid { get; set; }

    public long? Ocid { get; set; }

    public int? ClientId { get; set; }

    public DateTime? Orderdate { get; set; }

    public int? Processedby { get; set; }

    public DateTime? Reqdeldate { get; set; }

    public string? Totalprice { get; set; }

    public string? Companyname { get; set; }

    public string? Fname { get; set; }

    public string? Lname { get; set; }

    public string? Addr1 { get; set; }

    public string? Addr2 { get; set; }

    public string? Addr3 { get; set; }

    public string? Postcode { get; set; }

    public string? Country { get; set; }

    public string? Email { get; set; }

    public string? Mobile { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public string? Specialinstructions { get; set; }

    public int? Pack { get; set; }

    public string? Status { get; set; }

    public string? Tpfemail { get; set; }

    public short? CancelledBy { get; set; }

    public int IsTransfer { get; set; }

    public string? Source { get; set; }

    public string? Notes { get; set; }

    public string? NotestoVisaNz { get; set; }

    public long? UploadRef { get; set; }

    public int? DefaultCourierId { get; set; }

    public int? OrderType { get; set; }

    public string? PromotionName { get; set; }

    public int? ClubId { get; set; }

    public string? WhOrderNo { get; set; }

    public int? SentCount { get; set; }

    public virtual ICollection<OcDeliveryDetail> OcDeliveryDetails { get; } = new List<OcDeliveryDetail>();
}

