using BusinessServices.Models.MPlusSyncOrderAPI;
using Microsoft.Extensions.Logging;
using Utilities.MPlusSyncOrderUtility;

namespace BusinessServices.Models.MPlusSyncOrder
{
    [Serializable]
    public class SyncOrderRequest
    {
        public string PONumber { get; set; }
        public string ShippingType { get; set; }
        public DateTime Created { get; set; }
        public string PaymentType { get; set; }
        public string Txnref { get; set; }
        public int CatalogueID { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public string Currency { get; set; }
        public decimal ExchangeRate { get; set; }
        public string TradingTerms { get; set; }
        public int ClientID { get; set; }
        public AddressInfo Contact { get; set; }
        public AddressInfo Delivery { get; set; }
        public AddressInfo Billing { get; set; }
        public List<SyncOrderDetail> Orderdetails { get; set; }
        public decimal FreightFee { get; set; }
        public decimal FreightTax { get; set; }
        public decimal FreightTaxRate { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal DiscountTax { get; set; }
        public decimal DiscountTaxRate { get; set; }
        public string RefType { get; set; } = "WO";
        public Dictionary<string, string> ExtraInfo { get; set; }

        public SyncOrderRequest()
        {
            Currency = "AUD";
            ExchangeRate = 1.0m; //for AU
            Created = DateTime.Now;
            Status = OrderStatus.AwaitingPayment.ToString();
            Orderdetails = new List<SyncOrderDetail>();
            ExtraInfo = new Dictionary<string, string>();
            Contact = new AddressInfo();
            Billing = new AddressInfo();
            Delivery = new AddressInfo();
            PaymentTransation = new PaymentTransation();
        }

        public PaymentTransation PaymentTransation { get; set; }

    }

    [Serializable]
    public class PaymentTransation
    {
        public string PaymentType { get; set; }

        public string Currency { get; set; }

        public string TxnReference { get; set; }

        public decimal Amount { get; set; }

        public bool Paid { get; set; }

        public string ResponseCode { get; set; }

        public string ResponseText { get; set; }

        public DateTime Created { get; set; }

        public DateTime PayDate { get; set; }

        public string PayPalClientID { get; set; }

        //add new for ANZ EgateWay
        public string Bank { get; set; }
        public string CardType { get; set; }
        public string CardNumber { get; set; }
        public string PaypalClientId { get; internal set; }

        public PaymentTransation()
        {
            Currency = "";
            Paid = true;
            TxnReference = "";
            ResponseCode = "";
            ResponseText = "";
            PayPalClientID = "";

            //Add new for ANZ EgateWay
            Bank = "";
            CardType = "Unknown";
            CardNumber = "NA";
        }

    }

    [Serializable]
    public class SyncOrderDetail
    {
        public int? WarehouseID { get; set; }
        public string Name { get; set; }
        public long OcdetailID { get; set; }
        public string InternalCode { get; set; }
        public string InventoryCode { get; set; }
        public decimal Price { get; set; }
        public decimal Tax { get; set; }
        public decimal TaxRate { get; set; }
        public int Qty { get; set; }
        public int QtyBackOrder { get; set; }
        public string Comments { get; set; }
        public bool PackItem { get; set; }
        public string RawData { get; set; }
        public bool IsFF_Item { get; set; } = false;
        public Personalisation_OrderConnection Personalisation { get; set; }
        public SyncOrderDetail()
        {
            InternalCode = "";
            Name = "";
            Comments = "";
            PackItem = false;
            Price = 0.0m;
            Tax = 0.0m;
            TaxRate = 10m;
            Qty = 0;
            RawData = "";
        }
    }

    [Serializable]
    public class AddressInfo
    {
        public string Attention { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }

        public AddressInfo()
        {
            Attention = "";
            CompanyName = "";
            FirstName = "";
            LastName = "";
            Address1 = "";
            Address2 = "";
            Suburb = "";
            State = "";
            Country = "";
            Postcode = "";
            Phone = "";
            Fax = "";
            Email = "";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("To: " + Attention + "(" + FirstName + " " + LastName + ")");
            sb.AppendLine("Companyname: " + CompanyName);
            sb.AppendLine("Address Line 1: " + Address1);
            sb.AppendLine("Address Line 2: " + Address2);
            sb.AppendLine("Suburb: " + Suburb);
            sb.AppendLine("State: " + State);
            sb.AppendLine("Postcode: " + Postcode);
            sb.AppendLine("Country: " + Country);
            sb.AppendLine("Phone/Mobile/Fax: " + Phone + "/" + Mobile + "/" + Fax);
            sb.AppendLine("Email: " + Email);

            return sb.ToString();
        }
    }

    //[Serializable]
    //public class PaymentTransation
    //{
    //    public string PaymentType { get; set; }
    //    public string PaypalClientId { get; set; }

    //    public string Currency { get; set; }

    //    public string TxnReference { get; set; }

    //    public decimal Amount { get; set; }

    //    public bool Paid { get; set; }

    //    public string ResponseCode { get; set; }

    //    public string ResponseText { get; set; }

    //    public DateTime Created { get; set; }

    //    public DateTime PayDate { get; set; }

    //    public PaymentTransation()
    //    {
    //        Currency = "";
    //        Paid = true;
    //        TxnReference = "";
    //        ResponseCode = "";
    //        ResponseText = "";
    //    }
    //}

    [Serializable]
    public class Personalisation_OrderConnection
    {
        public string Type { get; set; }
        public string Style { get; set; }
        public List<string> Text { get; set; }
        public string Notes { get; set; }
        public int TemplateID { get; set; }

        public Personalisation_OrderConnection()
        {
            Type = "";
            Style = "";
            Notes = "";
            Text = new List<string>();
        }
    }

    [Serializable]
    public class WebOrder_OrderConnection : EditorEntity
    {
        public WebOrder_OrderConnection()
        {
            Status = 1;
            SyncStatus = SyncStatusOrder.Pendding.ToString();
            SyncEnable = true;
        }
        public long? ID { get; set; }
        public decimal? Gst { get; set; }
        public decimal? Total { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? TotalGst { get; set; }
        public decimal? Discount { get; set; }
        public decimal? TotalDiscount { get; set; }
        public decimal? SubTotalDiscount { get; set; }
        public int DiscountType { get; set; }
        public string Voucher { get; set; }
        public decimal? ShippingSubTotalPrice { get; set; }
        public decimal? ShippingTotalPrice { get; set; }
        public string ShippingType { get; set; }
        public string Currency { get; set; }
        public string UserID { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderType { get; set; }
        public string SubOrderType { get; set; } = "WO";
        public string OrderStatus { get; set; }
        public string PaymentType { get; set; }
        public string PaymentStatus { get; set; }
        public string Notes { get; set; }
        public string CanceledBy { get; set; }
        public DateTime? CanceledAt { get; set; }

        public decimal? CreditSubTotal { get; set; }
        public decimal? CreditGst { get; set; }

        public decimal? Credit { get; set; }
        public string TransationRef { get; set; }
        public long? TPFOrderID { get; set; }
        public DateTime? TPFOrderSyncDate { get; set; }
        public string DebtorCode { get; set; }
        public bool? ReturnCredit { get; set; } = false;
        public string CounterCode { get; set; }


        public string SyncStatus { get; set; }
        public bool? SyncEnable { get; set; }

        //Company
        public int CompanyID { get; set; }


        //Reference Object
        public List<Data.Databases.CMS_EMBERPLUS.WebOrderDetail> Details { get; set; }
        public PaymentTransation PaymentTransation { get; set; }
        public MetaAddressEntity AddressShipping { get; set; }
        public MetaAddressEntity AddressBilling { get; set; }
        public MetaAddressEntity Contact { get; set; }
        public List<Data.Databases.CMS_EMBERPLUS.WebOrderDeliveryTracking> DeliveryTrackings { get; set; }
        public List<ExtendFieldEntity> ExtendFields { get; set; }


        //Mapping Query
        public string TPFTrackingNumber { get; set; }
        public string TPFCarrier { get; set; }
        public DateTime? TPFCarrierProcessDate { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string UserFullName { get; set; }
        public string UserTypeName { get; set; }
        public string PaymentDetails { get; set; }

        public bool DeliveryRequestCreated { get; set; } = false;
    }

    [Serializable]
    public class MetaAddressEntity : EditorEntity
    {
        public MetaAddressEntity()
        {
            Status = (int)RecordStatus.Active;
        }
        public string OwnerID { get; set; }
        public string OwnerModule { get; set; }
        public long ID { get; set; }
        public bool? FreeAddress { get; set; } = false;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool? IsDefault { get; set; }
        public bool IsCaching { get; set; } = true;
    }

    [Serializable]
    public class ExtendFieldEntity : EditorEntity
    {
        public int? ID { get; set; }
        public string OwnerModule { get; set; }
        public string OwnerID { get; set; }
        public string Value { get; set; }
        //   public string ExtValidate { get; set; }
        public bool IsCaching { get; set; } = true;
    }
}
