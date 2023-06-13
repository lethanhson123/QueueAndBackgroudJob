using BusinessServices.Models.MPlusSyncOrderAPI;
using Newtonsoft.Json;

namespace BusinessServices.Models.MessageQueueModel
{
    public class SyncOrderIDQueueModel : CommonModel
    {
        public int companyID { get; set; }
        public List<long> orderIDs { get; set; }
    }
    public class CreateSyncOrderIDQueueModel
    {
        public int companyID { get; set; }
        public List<long> orderIDs { get; set; }
    }
    public class RequestDeliveryInfoModel
    {
        public RequestDeliveryInfoModel()
        {
            ListDelivery = new List<Delivery>();
        }

        [JsonProperty("ClubCode")]
        public string ClubCode { get; set; }

        [JsonProperty("Orders")]
        public List<Delivery> ListDelivery { get; set; }
    }
    public class WarehouseOrderDeliveryModel : EditorEntity
    {
        public long ID { get; set; }
        public string WhRefNo { get; set; }
        public long WhId { get; set; }
        public long WebOrderId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string Addr3 { get; set; }
        public string CompanyName { get; set; }
        public string Postcode { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int? Status { get; set; }
        public string ShippingType { get; set; }
        public string MemberID { get; set; }
        public string OrderType { get; set; }
        public string ClubCode { get; set; }
        public int CompanyID { get; set; }
        public bool IsSyncToWh { get; set; }
        public string DeliveryStatus { get; set; }
        public List<WarehouseOrderDeliveryDetailModel> Details { get; set; }
    }
    public class WarehouseOrderDeliveryDetailModel : EditorEntity
    {
        public long ID { get; set; }
        public long OcDelId { get; set; }
        public long OcDetailId { get; set; }
        public long ProdetailId { get; set; }
        public string ProCode { get; set; }
        public string ProName { get; set; }
        public int DelQty { get; set; }
        public int SentQty { get; set; }
        public string PrintName { get; set; }
        public string PrintImage { get; set; }
        public string RawData { get; set; }
        public int CompanyID { get; set; }
    }
    public partial class Delivery
    {
        [JsonProperty("UniqueRefId")]
        public string ReferenceId { get; set; }

        [JsonProperty("ShippingType")]
        public string ShippingType { get; set; }

        [JsonProperty("OrderID")]
        public string OrderId { get; set; }

        [JsonProperty("MemberId")]
        public string MemberId { get; set; }

        [JsonProperty("Fname")]
        public string Fname { get; set; }

        [JsonProperty("DelLname")]
        public string DelLname { get; set; }

        [JsonProperty("CompanyName")]
        public string CompanyName { get; set; }

        [JsonProperty("Street")]
        public string Street { get; set; }

        [JsonProperty("Suburb")]
        public string Suburb { get; set; }

        [JsonProperty("State")]
        public string State { get; set; }

        [JsonProperty("Postcode")]
        public string Postcode { get; set; }

        [JsonProperty("Country")]
        public string Country { get; set; }

        [JsonProperty("Email")]
        public string Email { get; set; }

        [JsonProperty("Phone")]
        public string Phone { get; set; }

        [JsonProperty("OrderType")]
        public string OrderType { get; set; }

		[JsonProperty("WhID")]
		public string WhID { get; set; }

		[JsonProperty("OrderDetail")]
        public List<DeliveryDetailModel> DeliveryDetails { get; set; }
    }
    public partial class DeliveryDetailModel
    {
		[JsonProperty("RedeemID")]
		public string RedeemId { get; set; }

		[JsonProperty("OrderDetailID")]
        public string OrderDetailId { get; set; }

        [JsonProperty("ItemCode")]
        public string ItemCode { get; set; }

        [JsonProperty("ItemName")]
        public string ItemName { get; set; }

        [JsonProperty("ItemQTY")]
        public int ItemQty { get; set; }

        [JsonProperty("PrintName")]
        public string PrintName { get; set; }

        [JsonProperty("PrintImage")]
        public string PrintImage { get; set; }

        [JsonProperty("RawData")]
        public string RawData { get; set; }
    }
}