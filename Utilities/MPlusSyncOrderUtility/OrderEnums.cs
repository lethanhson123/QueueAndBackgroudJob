using System.ComponentModel.DataAnnotations;

namespace Utilities.MPlusSyncOrderUtility
{
    public static class StaffID
    {
        /// <summary>
        /// This is default TPF System ID 332
        /// </summary>
        public const int TPFSystem = 332;
    }

    public enum RecordStatus
    {
        Active = 1,
        InActive = 2
    }

    public enum OrderStatusOfWLB
    {
        [Display(Description = "Awaiting Payment", Name = "AwaitingPayment")]
        AwaitingPayment, // create order
        [Display(Description = "Processing", Name = "Processing")]
        Processing, // after paid
        [Display(Description = "Rejected", Name = "Rejected")]
        Rejected,// if WaitingDelivery check ... from fulfilment => update ... => change to Processed => resync (WaitingDelivery)
        [Display(Description = "Dispatched", Name = "Dispatched")]
        Dispatched,// after delivery if full delivery
        [Display(Description = "Cancelled", Name = "Cancelled")]
        Cancelled, // WaitingDelivery, Processed, InProcess, Rejected
        [Display(Description = "Error", Name = "Error")]
        Error, // system
    }

    public enum EntityStatus : int
    {
        [Display(Name = "Deleted")]
        Deleted = 0,
        [Display(Name = "Active")]
        Active = 1,
        [Display(Name = "Pending")]
        Pending = 2,
        [Display(Name = "InActive")]
        InActive = 3,
        [Display(Name = "Testing")]
        Testing = 4,
    }

    /// <summary>
    /// Tpf Payment Method
    /// </summary>
    public enum PaymentMethod
    {
        [Display(Description = "Credit Card", Name = "CreditCard")]
        CreditCard = 0,
        /// <summary>
        /// PurchaseOrder
        /// </summary>
        [Display(Description = "Account", Name = "Account")]
        Account = 1,
        [Display(Description = "Pay Pal", Name = "PayPal")]
        PayPal = 2,
        /// <summary>
        /// For BankTransfer
        /// </summary>
        [Display(Description = "Direct Debit", Name = "DirectDebit")]
        DirectDebit = 5,
        [Display(Description = "Other", Name = "Other")]
        Other = 6,
        /// <summary>
        /// GiftCard
        /// </summary>
        [Display(Description = "Voucher", Name = "Voucher")]
        Voucher = 7,
        [Display(Description = "Debit", Name = "Debit")]
        Debit = 8,
    };

    public enum TradingTerms : int
    {
        [Display(Description = "Cash", Name = "Cash")]
        Cash,
        [Display(Description = "Prepayment", Name = "PREPAYMENT")]
        PREPAYMENT,
        [Display(Description = "7days", Name = "7days")]
        DAYS_7,
        [Display(Description = "14days", Name = "14days")]
        DAYS_14,
        [Display(Description = "30days", Name = "30days")]
        DAYS_30,
        [Display(Description = "45days", Name = "45days")]
        DAYS_45,
        [Display(Description = "60days", Name = "60days")]
        DAYS_60,
        [Display(Description = "90days", Name = "90days")]
        DAYS_90,
        [Display(Description = "120days", Name = "120days")]
        DAYS_120,
        [Display(Description = "lc", Name = "lc")]
        LC,
        [Display(Description = "LC30days", Name = "LC30days")]
        LC30days,
        [Display(Description = "lcatsite", Name = "lcatsite")]
        LCATSITE,
        [Display(Description = "TT", Name = "TT")]
        TT,
        [Display(Description = "Cheque10days", Name = "Cheque10days")]
        CHEQUE10days,
        [Display(Description = "COD", Name = "COD")]
        COD,
        [Display(Description = "FOB", Name = "FOB")]
        FOB
    };

    public enum PaymentTypeOfWLB
    {
        [Display(Description = "ANZ Credit Card", Name = "ANZCreditCard")]
        ANZCreditCard, // create order
        [Display(Description = "Secure Pay CreditCard", Name = "SecurePayCreditCard")]
        SecurePayCreditCard, // create order
        [Display(Description = "Paypal", Name = "Paypal")]
        Paypal, // after paid
        [Display(Description = "Invoice", Name = "Invoice")]
        Invoice,
        [Display(Description = "Credit", Name = "Credit")]
        Credit,
        [Display(Description = "Account", Name = "Account")]
        Account,
        [Display(Description = "ANZCyberSource", Name = "ANZCyberSource", ShortName = "CBS")]
        ANZCyberSource
    }

    public enum OrderStatusSync
    {
        [Display(Description = "Cancelled", Name = "Cancelled")]
        Cancelled,
        [Display(Description = "Closed", Name = "Closed")]
        Closed,
        [Display(Description = "Awaiting Payment", Name = "Awaiting Payment")]
        AwaitingPayment,
        [Display(Description = "Processed", Name = "Processed")]
        Processed,
        [Display(Description = "Part Invoiced", Name = "part-invoiced")]
        PartInvoiced,
        [Display(Description = "Full Invoiced", Name = "full-invoiced")]
        FullInvoiced,
        [Display(Description = "NA", Name = "NA")]
        NA
    };

    public enum OrderStatus
    {
        AwaitingPayment, // create order
        AwaitingConfirmation, // after paid
        Processing, // after paid
                    //   WaitingDelivery,// after sync
        Rejected,// if WaitingDelivery check ... from fulfilment => update ... => change to Processed => resync (WaitingDelivery)
                 //    PartDelivery, // after delivery if part
        Dispatched,// after delivery if full delivery
        Cancelled, // WaitingDelivery, Processed, InProcess, Rejected
        Error, // system
        Completed,
        Cancel,
    }

    public enum Currencies
    {
        AUD,
        EUR,
        GBP,
        HKD,
        NZD,
        SGD,
        USD
    }

    /// <summary>
    /// Order Status of Shopify
    /// </summary>
    public enum OrderStatusOfShopify
    {
        [Display(Description = "Displayed as Pending.", Name = "PENDING")]
        PENDING,
        [Display(Description = "Displayed as Authorized.", Name = "AUTHORIZED")]
        AUTHORIZED,
        [Display(Description = "Displayed as Partially paid.", Name = "PARTIALLY_PAID")]
        PARTIALLY_PAID,
        [Display(Description = "Displayed as Partially refunded.", Name = "PARTIALLY_REFUNDED")]
        PARTIALLY_REFUNDED,
        [Display(Description = "Displayed as Voided.", Name = "VOIDED")]
        VOIDED,
        [Display(Description = "Displayed as Paid.", Name = "PAID")]
        PAID,
        [Display(Description = "Displayed as Refunded.", Name = "REFUNDED")]
        REFUNDED,
        [Display(Description = "Displayed as Expired.", Name = "EXPIRED")]
        EXPIRED,
    }

    public enum SyncStatusOrder
    {
        Pendding,
        ReSynchronize,
        Synchronized
    }
}
