using static Utilities.MPlusSyncOrderUtility.EnumExtensions;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace Utilities.MPlusSyncOrderUtility
{
    public static partial class Utility
    {
        private static string refOrderFolder = "RefOrders";
        private static string refRawOrderFolder = "RefRawOrders";
        private static string DateTimeString = "dd-MM-yyyy hh-mm-ss";
        private static string Directory
        {
            get
            {
                //To get the location the assembly normally resides on disk or the install directory
                string path = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
                //once you have the path you get the directory with:
                string directory = Path.GetDirectoryName(path);
                directory = directory.Replace(@"\bin", "");
                return directory.Replace(@"file:\", "") + @"\";
            }
        }

        /// <summary>
        /// Store the Order info of external to refer
        /// </summary>
        /// <param name="syncOrder"></param>
        /// <param name="type"></param>
        public static void SaveRawOrderInfo(string jsonData, string poNumber, StoreType type)
        {
            try
            {
                var now = DateTime.Now;

                var path = String.Format(@"{0}{1}/{2}/{3}", Directory, refRawOrderFolder, type.GetDisplayShortName(), now.ToString("MM-yyyy"));

                if (!System.IO.Directory.Exists(path))
                {
                    System.IO.Directory.CreateDirectory(path);
                }

                File.WriteAllText(
                    String.Format("{0}/{1}_{2}.json", path, poNumber, DateTime.Now.ToString(DateTimeString)),
                    jsonData
                );
            }
            catch (Exception ex)
            {
                //LoggerHelper.Error("Failed to create for Raw Order Info", ex, GroupLog.Utility, poNumber);
                Console.WriteLine("Failed to create for Raw Order Info", ex, GroupLog.Utility, poNumber);
            }
        }

        /// <summary>
        /// Determine Payment Method WLB
        /// </summary>
        /// <param name="rawvalue"></param>
        /// <returns></returns>
        public static PaymentMethod DeterminePaymentMethodWLB(string rawvalue = "")
        {
            PaymentMethod paymentMethod = PaymentMethod.Other;

            if (Regex.IsMatch(rawvalue, PaymentTypeOfWLB.SecurePayCreditCard.GetDisplayName(), RegexOptions.IgnoreCase))
            {
                paymentMethod = PaymentMethod.CreditCard;
            }
            else if (Regex.IsMatch(rawvalue, PaymentTypeOfWLB.ANZCreditCard.GetDisplayName(), RegexOptions.IgnoreCase))
            {
                paymentMethod = PaymentMethod.CreditCard;
            }
            else if (Regex.IsMatch(rawvalue, PaymentTypeOfWLB.Credit.GetDisplayName(), RegexOptions.IgnoreCase))
            {
                paymentMethod = PaymentMethod.CreditCard;
            }
            else if (Regex.IsMatch(rawvalue, PaymentTypeOfWLB.Invoice.GetDisplayName(), RegexOptions.IgnoreCase))
            {
                paymentMethod = PaymentMethod.Account;
            }
            else if (Regex.IsMatch(rawvalue, PaymentTypeOfWLB.Account.GetDisplayName(), RegexOptions.IgnoreCase))
            {
                paymentMethod = PaymentMethod.Account;
            }
            else if (Regex.IsMatch(rawvalue, PaymentTypeOfWLB.Paypal.GetDisplayName(), RegexOptions.IgnoreCase))
            {
                paymentMethod = PaymentMethod.PayPal;
            }
            else if (Regex.IsMatch(rawvalue, PaymentTypeOfWLB.ANZCyberSource.GetDisplayName(), RegexOptions.IgnoreCase))
            {
                paymentMethod = PaymentMethod.CreditCard;
            }
            return paymentMethod;
        }

        public static OrderStatusSync DetermineWLBOrderStatus(string rawvalue)
        {
            OrderStatusSync orderStatus = OrderStatusSync.AwaitingPayment;
            if (Regex.IsMatch(rawvalue, OrderStatusOfWLB.Processing.GetDisplayName(), RegexOptions.IgnoreCase))
            {
                orderStatus = OrderStatusSync.Processed;
            }
            return orderStatus;
        }

        public static OrderStatusSync DetermineShopifyOrderStatus(string rawvalue)
        {
            OrderStatusSync orderStatus = OrderStatusSync.AwaitingPayment;
            if (Regex.IsMatch(rawvalue, OrderStatusOfShopify.PAID.GetDisplayName(), RegexOptions.IgnoreCase))
            {
                orderStatus = OrderStatusSync.Processed;
            }
            return orderStatus;
        }

        public static TradingTerms DetermineTradingTerms(string rawvalue)
        {
            var tradingterms = rawvalue;

            tradingterms = string.IsNullOrWhiteSpace(tradingterms) ? "" : tradingterms;

            if (Regex.IsMatch(tradingterms, "cash", RegexOptions.IgnoreCase))
            {
                return TradingTerms.Cash;
            }
            else if (Regex.IsMatch(tradingterms, "prepayment", RegexOptions.IgnoreCase))
            {
                return TradingTerms.PREPAYMENT;
            }
            else if (Regex.IsMatch(tradingterms, @"60days", RegexOptions.IgnoreCase))
            {
                return TradingTerms.DAYS_60;
            }
            else if (Regex.IsMatch(tradingterms, @"45days", RegexOptions.IgnoreCase))
            {
                return TradingTerms.DAYS_45;
            }
            else if (Regex.IsMatch(tradingterms, @"30days", RegexOptions.IgnoreCase))
            {
                return TradingTerms.DAYS_30;
            }
            else if (Regex.IsMatch(tradingterms, @"14days", RegexOptions.IgnoreCase))
            {
                return TradingTerms.DAYS_14;
            }
            else if (Regex.IsMatch(tradingterms, @"7days", RegexOptions.IgnoreCase))
            {
                return TradingTerms.DAYS_7;
            }
            //else if (Regex.IsMatch(tradingterms, "cod", RegexOptions.IgnoreCase))
            //{
            //    return TradingTerms.COD;
            //}
            //else if (Regex.IsMatch(tradingterms, "cheque - 10", RegexOptions.IgnoreCase))
            //{
            //    return TradingTerms.CHEQUE10days;
            //}
            //else if (Regex.IsMatch(tradingterms, "cheque"))
            //{
            //    return TradingTerms.CHEQUE10days;
            //}
            //else if (Regex.IsMatch(tradingterms, "fob", RegexOptions.IgnoreCase))
            //{
            //    return TradingTerms.FOB;
            //}
            else
            {
                return TradingTerms.PREPAYMENT;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="internalCode"></param>
        /// <param name="proDetailId"></param>
        /// <returns></returns>
        public static bool ConvertInternalCodeToProdetailId(string internalCode, out int proDetailId)
        {
            proDetailId = 0;

            if (internalCode.Contains("TPF"))
            {
                internalCode = internalCode.Replace("TPF", "");
            }
            else if (internalCode.Contains("I"))
            {
                internalCode = internalCode.Replace("I", "");
            }
            else if (internalCode.Contains("P"))
            {
                internalCode = internalCode.Replace("P", "");

            }

            if (Int32.TryParse(internalCode, out proDetailId))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Store the Order info of external to refer
        /// </summary>
        /// <param name="syncOrder"></param>
        /// <param name="type"></param>
        public static void SaveSyncOrderInfo(object syncOrder, StoreType type, string poNumber)
        {
            try
            {
                var now = DateTime.Now;

                var path = String.Format(@"{0}{1}/{2}/{3}", Directory, refOrderFolder, type.GetDisplayShortName(), now.ToString("MM-yyyy"));

                if (!System.IO.Directory.Exists(path))
                {
                    System.IO.Directory.CreateDirectory(path);
                }

                File.WriteAllText(
                    String.Format("{0}/{1}_{2}.json", path, poNumber, DateTime.Now.ToString(DateTimeString)),
                    JsonConvert.SerializeObject(syncOrder)
                );
            }
            catch (Exception ex)
            {
                //LoggerHelper.Error("Failed to store orders to ref", ex, GroupLog.Utility, poNumber);
            }
        }

        /// <summary>
        /// Convert Order Status from Shopify to TPF order status
        /// </summary>
        /// <param name="tpfOrderStatus"></param>
        /// <param name="tpfDelStatus"></param>
        /// <returns></returns>
        public static OrderStatusOfShopify ConvertShopifyOrderStatus(string tpfOrderStatus = "", string tpfDelStatus = "")
        {
            OrderStatusOfShopify orderStatus = OrderStatusOfShopify.PENDING;

            if (Regex.IsMatch(tpfOrderStatus, OrderStatusSync.AwaitingPayment.GetDisplayName(), RegexOptions.IgnoreCase))
            {
                orderStatus = OrderStatusOfShopify.PENDING;
            }
            else if (Regex.IsMatch(tpfOrderStatus, OrderStatusSync.Cancelled.GetDisplayName(), RegexOptions.IgnoreCase)
                || Regex.IsMatch(tpfOrderStatus, OrderStatusSync.Closed.GetDisplayName(), RegexOptions.IgnoreCase))
            {
                orderStatus = OrderStatusOfShopify.VOIDED;
            }
            else if (Regex.IsMatch(tpfDelStatus, DeliveryStatus.FullyDelivered.GetDisplayName(), RegexOptions.IgnoreCase))
            {
                orderStatus = OrderStatusOfShopify.PAID;
            }
            else if (Regex.IsMatch(tpfOrderStatus, OrderStatusSync.FullInvoiced.GetDisplayName(), RegexOptions.IgnoreCase)
               && Regex.IsMatch(tpfDelStatus, DeliveryStatus.New.GetDisplayName(), RegexOptions.IgnoreCase))
            {
                orderStatus = OrderStatusOfShopify.PAID;
            }
            else
            {
                orderStatus = OrderStatusOfShopify.EXPIRED;
            }

            return orderStatus;
        }
    }
}
