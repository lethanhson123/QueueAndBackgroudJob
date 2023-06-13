using BusinessServices.Models.MPlusSyncOrder.Validation;
using BusinessServices.Models.MPlusSyncOrderAPI;
using Dapper;
using Newtonsoft.Json;
using RestSharp;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Net;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;
using Utilities.MPlusSyncOrderUtility;
using static Utilities.MPlusSyncOrderUtility.EnumExtensions;

namespace BusinessServices.Models.MPlusSyncOrder
{
    public class SyncOrderResponse
    {
        public long ID { get; set; }
        public string GuiID { get; set; }
        public string TPFOrderID { get; set; }
        public string PONumber { get; set; }
        public List<string> Errors { get; set; }
        public string OrderStatus { get; set; }
        public string Notes { get; set; }
        public int StoreSiteId { get; set; }
        public StoreType StoreType { get; set; }

        public IEnumerable<DeliveryTracking> Deliveries { get; set; }
        public SyncOrderResponse()
        {
            TPFOrderID = string.Empty;
            PONumber = string.Empty;
            Errors = new List<string>();
            OrderStatus = string.Empty;
            Notes = string.Empty;
            Deliveries = new List<DeliveryTracking>();
        }
    }

    public class DeliveryTracking
    {
        public long Id { get; set; }
        public string TrackingNo { get; set; }
        public string CarrierName { get; set; }
        public string CarrierUrl { get; set; }
        public DateTime ProcessedDate { get; set; }
        public int WhId { get; set; }
    }

    public class SiteStoreInfo
    {
        public string ApiID { get; set; }
        public string ApiKey { get; set; }

        [Display(Name = "Store Id")]
        public int StoreSiteId { get; set; }
        [Display(Name = "Catalogue Id")]
        public int CatalogueId { get; set; }
        [Display(Name = "Catalogue Name")]
        public string CatalogueName { get; set; }
        public string MagentoKey { get; set; }
        public int HandledBy { get; set; }
        [Display(Name = "ClientId")]
        public int CashClientId { get; set; }
        /// <summary>
        /// Store Status => for Stop Sync 
        /// Active / Inactive
        /// </summary>
        [Display(Name = "Store Status")]
        public string StoreStatus { get; set; }
        [Display(Name = "Catalogue Status")]
        public bool Active { get; set; }
        public int TaxRate { get; set; }
        public string Currency { get; set; }

        public StoreType StoreType { get; set; }
        public string URL { get; set; }
        public string StoreAPIUrl { get; set; }
        [Display(Name = "Use Primary WH")]
        public bool UsedPrimaryWH { get; set; }
        public string Roles { get; set; }
        public string[] RoleNames
        {
            get
            {
                List<string> roleNames = new List<string>();
                if (!String.IsNullOrEmpty(Roles) && !String.IsNullOrEmpty(Roles))
                {
                    var rules = Roles.Split(';');
                    if (rules.Length > 0)
                    {
                        for (int i = 0; i < rules.Length; i++)
                        {
                            int ruleId = 0;
                            if (int.TryParse(rules[i], out ruleId) && ruleId > 0)
                            {
                                var role = (SynchRole)ruleId;
                                roleNames.Add(role.GetDisplayShortName());
                            }
                        }
                    }
                }
                List<string> result = roleNames.Count > 0 ? roleNames : new List<string>();

                return result.ToArray();
            }
        }

        public List<SynchRole> RoleIDs
        {
            get
            {
                List<SynchRole> roleIds = new List<SynchRole>();
                if (!String.IsNullOrEmpty(Roles) && !String.IsNullOrEmpty(Roles))
                {
                    var rules = Roles.Split(';');
                    if (rules.Length > 0)
                    {
                        for (int i = 0; i < rules.Length; i++)
                        {
                            int ruleId = 0;
                            if (int.TryParse(rules[i], out ruleId) && ruleId > 0)
                            {
                                var role = (SynchRole)ruleId;
                                roleIds.Add(role);
                            }
                        }
                    }
                }
                return roleIds;
            }
        }
        [Display(Name = "Lastest Sync Date")]
        public DateTime LastSyncDate { get; set; }

        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; }
        [Display(Name = "Modified Date")]
        public DateTime ModifiedDate { get; set; }
        public SiteStoreInfo()
        {
            StoreType = StoreType.NA;
        }
    }

    public class SyncOrderRepo
    {
        /// <summary>
        /// Purchase Order Number
        /// </summary>
        [Required]
        public string PONumber { get; set; }

        [Required]
        public DateTime Created { get; set; }

        [Required]
        [WLBPaymentRange]
        public string PaymentType { get; set; }
        public string Txnref { get; set; }

        [Required]
        public int CatalogueID { get; set; }

        /// <summary>
        /// Set up Royalty info from external shop to be synced for FF system
        /// </summary>
        public string RefType { get; set; }
        /// <summary>
        /// Shipping Type
        /// Standard // Express 
        /// updated on 13-08-2021
        /// </summary>
        public string ShippingType { get; set; }

        [Required]
        [WLBOrderStatusRange]

        public string Status { get; set; }
        /// <summary>
        /// Note of Client to view on oc
        /// </summary>
        public string Notes { get; set; }
        [Required]
        [CurrencyRange]
        public string Currency { get; set; }
        [Required]
        public decimal ExchangeRate { get; set; }
        public string TradingTerms { get; set; }

        [Required]
        public int ClientID { get; set; }
        [Required]
        public AddressInfo Contact { get; set; }
        [Required]
        public AddressInfo Delivery { get; set; }
        [Required]
        public AddressInfo Billing { get; set; }

        [Required]
        public List<SyncOrderDetail> Orderdetails { get; set; }

        #region order freight
        /// <summary>
        /// Price exclude Tax
        /// </summary>
        public decimal FreightFee { get; set; }
        public decimal FreightTax { get; set; }
        public decimal FreightTaxRate { get; set; }
        /// <summary>
        /// Total Discount
        /// </summary>
        public decimal DiscountAmount { get; set; }
        public decimal DiscountTax { get; set; }
        public decimal DiscountTaxRate { get; set; }

        #endregion

        public Dictionary<string, string> ExtraInfo { get; set; }

        public CreditCardTranWLB creditCardTran { get; set; }
        public PaypalTransaction PaypalTran { get; set; }

        public SyncOrderRepo()
        {
            Currency = "AUD";
            RefType = String.Empty;
            ExchangeRate = 1.0m; //for AU
            Created = DateTime.Now;
            Status = OrderStatusOfWLB.AwaitingPayment.GetDisplayName();
            ShippingType = "";
            //creditCardTran = new CreditCardTranWLB();
            Orderdetails = new List<SyncOrderDetail>();
            ExtraInfo = new Dictionary<string, string>();
            Contact = new AddressInfo();
            Billing = new AddressInfo();
            Delivery = new AddressInfo();
            creditCardTran = new CreditCardTranWLB();
            PaypalTran = new PaypalTransaction();
        }

    }

    public class CreditCardTranWLB : CreditCardTran
    {
        public CreditCardTranWLB()
        {
            Bank = "";
            Currency = "";
            Paid = false;
            TxnReference = "";
            ResponseCode = "";
            ResponseText = "";
        }
    }

    public class CreditCardTran
    {
        [Required(ErrorMessage = "Missing field {0}")]
        public string Currency { get; set; }
        [Required(ErrorMessage = "Missing field {0}")]
        public string TxnReference { get; set; }
        [Required(ErrorMessage = "Missing field {0}")]
        public decimal Amount { get; set; }
        public bool Paid { get; set; }
        [Required(ErrorMessage = "Missing field {0}")]
        public string CardNumber { get; set; }
        [Required(ErrorMessage = "Missing field {0}")]
        public string CardType { get; set; }
        [Required(ErrorMessage = "Missing field {0}")]
        public string Bank { get; set; }
        [Required(ErrorMessage = "Missing field {0}")]
        public string ResponseCode { get; set; }
        [Required(ErrorMessage = "Missing field {0}")]
        public string ResponseText { get; set; }
        [Required(ErrorMessage = "Missing field {0}")]
        public DateTime Created { get; set; }
        [Required(ErrorMessage = "Missing field {0}")]
        public DateTime PayDate { get; set; }

        public CreditCardTran()
        {
            Bank = "";
            Currency = "";
            Paid = false;
            TxnReference = "";
            ResponseCode = "";
            ResponseText = "";
        }
    }

    public class PaypalTransaction
    {
        [Required(ErrorMessage = "Missing field {0}")]
        public string Token { get; set; }
        [Required(ErrorMessage = "Missing field {0}")]
        public string TransactionId { get; set; }

        public bool Paid { get; set; }

        [Required(ErrorMessage = "Missing field {0}")]
        public decimal Amount { get; set; }

        public DateTime Created { get; set; }

        public string Timestamp { get; set; }

        public decimal ExchangeRate { get; set; }

        public decimal Fee { get; set; }
        [Required(ErrorMessage = "Missing field {0}")]
        [RegularExpression(@"^7\d{8}", ErrorMessage = "Invalid TPF Order Number")]
        public string OrderNumber { get; set; }

        public string PaymentType { get; set; }

        public string PaymentStatus { get; set; }
        [Required(ErrorMessage = "Missing field {0}")]
        public string ReasonCode { get; set; }

        public string PendingReason { get; set; }

        public PaypalClient Client { get; set; }

        public PaypalTransaction()
        {
            OrderNumber = "";
            Token = "";
        }
    }

    public class PaypalClient
    {
        public string PayerId { get; set; }

        public string CompanyName { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Attention { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Postcode { get; set; }

        public string Country { get; set; }

        public string CountryCode { get; set; }

        public string Phone { get; set; }

        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Invalid Value {0}")]
        public string Email { get; set; }

        public string PayerStatus { get; set; }

        public string AddressStatus { get; set; }

        public string Status { get; set; }

        public PaypalClient()
        {
            PayerId = "";
            CompanyName = "";
            Firstname = "";
            Lastname = "";
            Attention = "";
            Address = "";
            City = "";
            State = "";
            Postcode = "";
            CountryCode = "";
            Country = "";
            Phone = "";
            Email = "";
            PayerStatus = "";
            AddressStatus = "";
            Status = "";
        }
    }

    public class OrderStatusTracking
    {
        public long Id { get; set; }
        public long TPFOrderID { get; set; }
        public string PONumber { get; set; }
        public string OrderStatus { get; set; }
        public string DeliveryStatus { get; set; }
        public SyncStatus SyncStatus { get; set; }
        public SyncStatus SyncDelStatus { get; set; }
        public int PendingDuration { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid RGuid { get; set; }
    }

    public class OrderSyncTrackingSignalR
    {
        public long Id { get; set; }
        public long TPFOrderID { get; set; }
        public int StoreId { get; set; }
        public StoreType StoreType { get; set; }
        public int CatalogueId { get; set; }
        public string CatalogueName { get; set; }
        public string PONumber { get; set; }
        public int PendingDuration { get; set; }
        public string OrderStatus { get; set; }
        public string DelStatus { get; set; }
        public TpfOrderRejectType RejectType { get; set; }
        public string RejectNote { get; set; }

        public SyncStatus SyncStatus { get; set; }
        public DeliveryStatus SyncDelStatus { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public Guid RGuid { get; set; }
        public string RawData { get; set; }
        public string Status { get; set; }

        public OrderSyncTrackingSignalR()
        {
            TPFOrderID = 0;
            StoreId = 0;
            PendingDuration = 0;
            Status = "active";
        }
    }

    public class CatalogueView
    {
        public int CatalogueId { get; set; }
        public string CatalogueName { get; set; }
        public string MagentoKey { get; set; }
        public string CatStatus { get; set; }
        public long ClientID { get; set; }
        public long StaffId { get; set; }
        public int TaxRate { get; set; }
        public string Currency { get; set; }
    }

    public class CatalogueSignalR
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MagentoKey { get; set; }
        public int HandledBy { get; set; }
        public int CashClientId { get; set; }
        public bool Active { get; set; }
        public int TaxRate { get; set; }
        public string Currency { get; set; }
    }

    public class OrderNote
    {
        public string Note { get; set; }
        public int Enteredby { get; set; }
        public DateTime CreateDate { get; set; }

        public OrderNote()
        {
            Note = "";
            Enteredby = 332;
            CreateDate = DateTime.Now;
        }
        public OrderNote(string note)
        {
            Note = note;
            Enteredby = 332;
            CreateDate = DateTime.Now;
        }
    }

    public class OrderRepository : IDisposable
    {
        #region Properties
        public long OrderNumber { get; set; }
        public string PromotionName { get; set; }
        public string CostCentre { get; set; }
        public DateTime Created { get; set; }
        public DateTime DeliveryDate { get; set; }
        public PaymentMethod PayOption { get; set; }
        public string Txnref { get; set; }
        public string PONumber { get; set; }
        public string Vendorno { get; set; }
        public int CatalogueID { get; set; }
        public string Status { get; set; }
        /// <summary>
        /// Notes of order
        /// </summary>
        public string Notes { get; set; }
        public string Currency { get; set; }
        public decimal Exchangerate { get; set; }
        public TradingTerms TradingTerms { get; set; }
        public string VendorNumber { get; set; }
        public decimal OrderTotal
        {
            get
            {
                var total = Orderdetails.Sum(it => it.Qty * (it.Price + it.Tax));
                return total;
            }
            set { }
        }
        public decimal OrderTotalExc
        {
            get
            {
                var total = Orderdetails.Sum(it => it.Qty * it.Price);
                return total;
            }
            set { }
        }
        public int ProfileID { get; set; }
        public bool Onhold { get; set; }
        public bool Closed { get; set; }
        public bool FreeOnBoard { get; set; }
        public string WebstoreNumber { get; set; }
        public bool OnlineOrder { get; set; }
        public string Ordergroup { get; set; }
        /// <summary>
        /// Set up Royalty info from external shop to be synced for FF system 
        /// </summary>
        public string RefType { get; set; }
        /// <summary>
        /// add discount code for magento 1 and magento 2
        /// </summary>
        public string Importref { get; set; }
        /// <summary>
        /// Add position for FF Team processing Shipping Type on 13-08-2021
        /// </summary>
        public string Position { get; set; }
        public string DeliveryNotesToWarehouse { get; set; }
        public string Disclaimer { get; set; }
        public int HandledBy { get; set; }
        public int ProcessedBy { get; set; }
        public int Enteredby { get; set; }

        public int ClientID { get; set; }

        /// <summary>
        /// For External Order: Magento 1, Magento 2, CA, NetSetGo
        /// </summary>
        public bool IsMagento { get; set; }

        public AddressInfo Contact { get; set; }
        public AddressInfo Delivery { get; set; }
        public AddressInfo Billing { get; set; }
        public List<Orderdetail> Orderdetails { get; set; }

        public bool ToBeInvoiced { get; set; }
        public bool SendInvoiceWithGoods { get; set; }
        public string Trackingcode { get; set; }

        [XmlIgnore]
        public Dictionary<string, string> ExtraInfo { get; set; }
        #endregion

        #region Base Info 
        private Dictionary<string, string> _dataLog;
        protected Dictionary<string, string> getLogBaseInfo
        {
            get
            {
                var dataLog = new Dictionary<string, string>();
                dataLog.Add("NameSpace: ", GetType().ToString());
                dataLog.Add("Path file: ", @"\SyncApp.Repository\Repository\OrderRepository.cs");
                return dataLog;
            }
        }
        #endregion

        //default value of some attribute 
        public OrderRepository()
        {
            Currency = "AUD";
            Exchangerate = 1.0m;
            Created = DateTime.Now;
            DeliveryDate = DateTime.Now;
            Status = "Awaiting Payment";
            Ordergroup = "External";
            Orderdetails = new List<Orderdetail>();
            ExtraInfo = new Dictionary<string, string>();
            Contact = new AddressInfo();
            Billing = new AddressInfo();
            Delivery = new AddressInfo();
            _dataLog = new Dictionary<string, string>();
        }

        public void Dispose()
        {
        }
    }

    public class Orderdetail
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        /// <summary>
        /// Price Ex Tax
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Set IsFF_Item to be TRUE to sync FF
        /// </summary>
        public bool IsFF_Item { get; set; }

        /// <summary>
        /// Raw Data store into Tpfsystem.dbo.ItemRawData
        /// </summary>
        public string RawData { get; set; }
        /// <summary>
        /// ShopOcdetailID store into Tpfsystem.dbo.ItemRawData to compare with external shop (Member +)
        /// </summary>
        public long ShopOcdetailID { get; set; }

        public decimal Tax { get; set; }

        public decimal TaxRate { get; set; }

        public decimal PriceExTax { get; set; }
        public decimal PriceInTax { get; set; }

        public int Qty { get; set; }
        public int QtyBackOrder { get; set; }
        public string Comments { get; set; }
        public bool PackItem { get; set; }
        public int StockId { get; set; }
        public int WarehouseID { get; set; }
        public int CatalogueId { get; set; }

        public decimal LineTotal
        {
            get
            {
                return (Price + Tax) * Qty;
            }
            set { }
        }
        public decimal LineTotalExc
        {
            get
            {
                return Price * Qty;
            }
            set { }
        }

        public bool ToBeProduced
        {
            get
            {
                return Personalisation != null;
            }
        }

        public List<OrderDetailExtraInfo> ExtraInfo { get; set; }
        public Personalisation_OrderConnection Personalisation { get; set; }
        public Orderdetail()
        {
            Code = "";
            Name = "";
            Comments = "";
            PackItem = false;
            Price = 0.0m;
            Tax = 0.0m;
            Qty = 0;
            IsFF_Item = false;
            RawData = String.Empty;
            ExtraInfo = new List<OrderDetailExtraInfo>();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("(Name, Code, Comments) = (" + Name + ", " + Code + ", " + Comments + ")");
            sb.Append("(Price, Tax, TotalQty, QtyBackOrder) = (" + Price + ", " + Tax + ", " + Qty + ", " + QtyBackOrder + ")");
            sb.Append("(LineTotal, LineTotalExc) = (" + LineTotal + ", " + LineTotalExc + ")");
            return sb.ToString();
        }
    }

    public class OrderDetailExtraInfo
    {
        public string Title { get; set; }
        public string Companyname { get; set; }
        public string MemberNumber { get; set; }
        public string DiscountCode { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Postcode { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string EmergencyContact { get; set; }
        public string EmergencyPhone { get; set; }
        public string DietaryRequirements { get; set; }
        public string TravelMode { get; set; }
        public string ItemCode { get; set; }
        public DateTime DOB { get; set; }
        public int Index { get; set; }

        public string EmergencyContact2 { get; set; }

        public string Travelmode { get; set; }

        public string PhysicalCondition { get; set; }
        public string Event { get; set; }
        public string Allergies { get; set; }

        public bool ReportToClub { get; set; }

        public string Status { get; set; }
        public OrderDetailExtraInfo()
        {
            Title = "";
            Companyname = "";
            Fname = "";
            Lname = "";
            Address = "";
            City = "";
            State = "";
            Postcode = "";
            Phone = "";
            Mobile = "";
            Email = "";
            Gender = "";
            EmergencyContact = "";
            EmergencyPhone = "";
            TravelMode = "";
            ItemCode = "";
            DOB = DateTime.Now;
        }

        public XElement ToXML()
        {
            return new XElement("ExtraItemInfo",
                new XElement("index", Index),
                new XElement("title", Title),
                new XElement("companyname", Companyname),
                new XElement("fname", Fname),
                new XElement("lname", Lname),
                new XElement("address", Address),
                new XElement("city", City),
                new XElement("state", State),
                new XElement("postcode", Postcode),
                new XElement("phone", Phone),
                new XElement("mobile", Mobile),
                new XElement("email", Email),
                new XElement("gender", Gender),
                new XElement("emergencycontact", EmergencyContact),
                new XElement("emergencyphone", EmergencyPhone),
                new XElement("travelmode", TravelMode),
                new XElement("itemcode", ItemCode),
                new XElement("dob", DOB)
            );
        }
    }

    public class CreditCardTransaction
    {
        [Required(ErrorMessage = "Missing field {0}")]
        public string TxnReference { get; set; }

        public DateTime Created { get; set; }
        [Required(ErrorMessage = "Missing field {0}")]
        public decimal Amount { get; set; }

        public string CustomerName { get; set; }

        public string CustomerEmail { get; set; }
        //[MaxLength(4)]
        [Required(ErrorMessage = "Missing field {0}")]
        public string CardNumber { get; set; }
        [Required(ErrorMessage = "Missing field {0}")]
        public string CardType { get; set; }

        public DateTime? PayDate { get; set; }

        public int ClientId { get; set; }
        [Required(ErrorMessage = "Missing field {0}")]
        public string Currency { get; set; }

        public bool Paid { get; set; }

        [Required(ErrorMessage = "Missing field {0}")]
        //[MaxLength(3)]
        public string Bank { get; set; }
        //[MaxLength(2)]
        public string ExpiryMonth { get; set; }
        //[MaxLength(2)]
        public string ExpiryYear { get; set; }

        [Required(ErrorMessage = "Missing field {0}")]
        [RegularExpression(@"^7\d{8}", ErrorMessage = "Invalid TPF Order Number")]
        public string OrderNumber { get; set; }

        public string PromotionName { get; set; }
        [Required(ErrorMessage = "Missing field {0}")]
        public string ResponseCode { get; set; }
        [Required(ErrorMessage = "Missing field {0}")]
        public string ResponseText { get; set; }

        public string ProcessedBy { get; set; }

        public CreditCardTransaction()
        {
            TxnReference = "";
            Bank = "";
            CustomerName = "";
            CustomerEmail = "";
            CardNumber = "";
            Currency = "";
            ExpiryMonth = "";
            ExpiryYear = "";
            OrderNumber = "";
            PromotionName = "";
            ResponseCode = "";
            ResponseText = "";
            ProcessedBy = "";
        }
    }

    public class SKU
    {
        //[JsonProperty("id")]
        public int Id { get; set; }
        //[JsonProperty("pid")]
        public int ProId { get; set; }
        //[JsonProperty("vtid")]
        public int VirtualId { get; set; }
        //[JsonProperty("ctlid")]
        public int CatalogueId { get; set; }
        //[JsonProperty("nme")]
        public string Name { get; set; }
        //[JsonProperty("s")]
        public string Size { get; set; }
        //[JsonProperty("itncode")]
        public string InternalCode { get; set; }
        //[JsonProperty("bcode")]
        public string Barcode { get; set; }
        //[JsonProperty("ivtcode")]
        public string InventoryCode { get; set; }
        //[JsonProperty("ivtstatus")]
        public string InventoryStatus { get; set; }
        //[JsonProperty("pw")]
        public int PrimaryWarehouse { get; set; }
        //[JsonProperty("goh")]
        public long GlobalOnhand
        {
            get
            {
                long sum = 0;
                foreach (var entry in Onhand)
                {
                    sum += entry.Value;
                }
                return sum;
            }
            set
            {

            }
        }
        //[JsonProperty("goor")]
        public long GlobalOnorder
        {
            get
            {
                long sum = 0;
                foreach (var entry in Onorder)
                {
                    sum += entry.Value;
                }
                return sum;
            }
            set
            {

            }
        }
        //[JsonProperty("ga")]
        public long GlobalAvailable
        {
            get
            {
                return GlobalOnhand - GlobalOnorder;
            }
            set
            {

            }
        }
        //[JsonProperty("oh")]
        public Dictionary<int, long> Onhand { get; set; }
        //[JsonProperty("oor")]
        public Dictionary<int, long> Onorder { get; set; }
        //[JsonProperty("avlb")]
        public Dictionary<int, long> Available { get; set; }
        //[JsonProperty("w")]
        public decimal Weight { get; set; }
        //[JsonProperty("cbor")]
        public bool CanBackOrder { get; set; }
        //[JsonIgnore]
        public DateTime LastSync { get; set; }
        //[JsonProperty("iskd")]
        public bool IsKitDynamic { get; set; }
        //[JsonProperty("kqty")]
        public int KitQty { get; set; }
        //[JsonProperty("kitems")]
        public List<SKU> KitItems { get; set; }
        public SKU()
        {
            Name = "";
            InternalCode = "";
            Barcode = "";
            InventoryCode = "";
            Size = "";
            Onhand = new Dictionary<int, long>();
            Onorder = new Dictionary<int, long>();
            Available = new Dictionary<int, long>();
            InventoryStatus = "";
            KitItems = new List<SKU>();
        }
    }

    public class ProductInfo
    {
        public int ProID { get; set; }
        public long ProdetailID { get; set; }
        public long VirtualRefID { get; set; }
        public int CatalogueID { get; set; }
        public string Internalcode { get; set; }
        public string Barcode { get; set; }
        public string ProdetailCode { get; set; }
        public string ProdName { get; set; }
        public string ProdetailSize { get; set; }
        public decimal Weight { get; set; }
        public string Bo_Status { get; set; }
        public string InventoryStatusText { get; set; }
        public int Pd_Whid { get; set; }
        public double ProdetailStock { get; set; }
        public long CustOrder { get; set; }
        public string ImageName { get; set; }
        public double Available { get; set; }
        public bool ToSync { get; set; }
        public int isDynamicKit { get; set; }
        public Nullable<System.DateTime> LastTurnOnToSync { get; set; }
    }

    public class ProductQtySignalR
    {
        public int Id { get; set; }
        public int ProdetailId { get; set; }
        public int WhId { get; set; }
        public long Available { get; set; }
        public long OnHand { get; set; }
        public long OnOrder { get; set; }
        public long OnCustOrder { get; set; }
        public long OnBackOrder { get; set; }
        public long OnReorder { get; set; }
        public long OnReturns { get; set; }
        public Nullable<DateTime> LastUpdate { get; set; }
        public int last_location_stock_id { get; set; }
        public Nullable<DateTime> CreateDate { get; set; }
    }

    public partial class API_ProPack
    {
        public string InternalCode { get; set; }
        public string ProdetailCode { get; set; }
        public int pkID { get; set; }
        public int pkProID { get; set; }
        public int pkProdetailID { get; set; }
        public int pkQty { get; set; }
        public string pkStatus { get; set; }
        public Nullable<int> GroupID { get; set; }
        public string kitInternalCode { get; set; }
        public string kitProdetailCode { get; set; }
    }

    public class SNSModel
    {
        [JsonProperty("jsonMessage")]
        public string JsonMessage { get; set; }

        [JsonProperty("typeData")]
        public int TypeData { get; set; }

        public SNSModel(string _jsonMessage, int _typeData)
        {
            JsonMessage = _jsonMessage;
            TypeData = _typeData;
        }
        public bool PostDataToSNS()
        {
            try
            {
                var urllink = "http://192.168.21.69:7610/api/AWS/postDataSNS";
                var typeContent = "application/json";
                var client = new RestClient(urllink);
                var request = new RestRequest();
                request.Timeout = 60000;
                request.Method = Method.Post;
                request.AddHeader("Content-Type", typeContent);
                var modelsubmit = new SNSModel(JsonMessage, TypeData);
                var body = JsonConvert.SerializeObject(modelsubmit);
                request.AddParameter(typeContent, body, ParameterType.RequestBody);
                var response = client.Execute(request);
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
