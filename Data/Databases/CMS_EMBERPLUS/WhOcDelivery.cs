namespace Data.Databases.CMS_EMBERPLUS;

public partial class WhOcDelivery : BaseModel
{
	public long Id { get; set; }

	public string? WhRefNo { get; set; }

	public int WhId { get; set; }

	public long WebOrderId { get; set; }

	public string? Fname { get; set; }

	public string? Lname { get; set; }	

	public string? Addr1 { get; set; }

	public string? Addr2 { get; set; }

	public string? Addr3 { get; set; }

	public string? CompanyName { get; set; }

	public string? Postcode { get; set; }

	public string? Suburb { get; set; }

	public string? State { get; set; }

	public string? Country { get; set; }

	public string? Email { get; set; }

	public string? Phone { get; set; }

	public string? Specialinstructions { get; set; }

	public int? CompanyId { get; set; }

	public string ClubCode { get; set; }

	public string? Title { get; set; }

	public string? Description { get; set; }

	/// <summary>
	/// 1: New, 2:Partly, 3: Fully
	/// </summary>
	public int? Status { get; set; }

	public string? CreateBy { get; set; }

	public string? CreatebyName { get; set; }

	public DateTime? CreateDate { get; set; }

	public string? LastUpdateBy { get; set; }

	public string? LastUpdateByName { get; set; }

	public DateTime? LastUpdateDate { get; set; }

	public string? ShippingType { get; set; }

	public string? OrderType { get; set; }

	public string? MemberId { get; set; }

	public bool? IsSyncToWh { get; set; }

	public string? DeliveryStatus { get; set; }

	public string? UserName { get; set; }

	public DateTime? OrderDate { get; set; }
	public List<WhOcDeliveryDetail> Details { get; set; }
}

