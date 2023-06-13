using System.ComponentModel.DataAnnotations;

namespace Utilities.MPlusSyncOrderUtility
{
    public enum SyncStatus : int
    {
        [Display(Name = "Pending")]
        Pending = 0,
        [Display(Name = "Synced")]
        Synced = 1,
        [Display(Name = "Warning", ShortName = "Warning")]
        Warning = 2,
        [Display(Name = "Error")]
        Error = 3,
        [Display(Name = "Apply", ShortName = "Apply")]
        Apply = 4,
        [Display(Name = "NA", ShortName = "NA")]
        NA = 5,
        [Display(Name = "Testing", ShortName = "Test")]
        Testing = 6,
        [Display(Name = "Processing Client", ShortName = "Processing")]
        Processing = 7,
        /// <summary>
        /// Allow Resync
        /// </summary>
        [Display(Name = "Sent", ShortName = "Sent")]
        Sent = 8,
        [Display(Name = "Stop Sync Stock", ShortName = "StopSync")]
        StopStockSync = 9,
        [Display(Name = "Missing RawData", ShortName = "MissingRawData")]
        MissingRawData = 10,
    }
    /// <summary>
    /// Web Store type
    /// </summary>
    public enum StoreType : int
    {
        [Display(Name = "NA", ShortName = "NA")]
        NA = 0,
        [Display(Name = "Magento1", ShortName = "Magento1", Description = "Magento 1")]
        Magento = 1,
        [Display(Name = "Magento2", ShortName = "Magento2", Description = "Magento 2")]
        Magento2 = 2,
        [Display(Name = "CricketBlast", ShortName = "CA", Description = "Cricket Blast")]
        CA = 3,
        [Display(Name = "WLB", ShortName = "WLB", Description = "White Label")]
        WLB = 4,
        [Display(Name = "Shopify", ShortName = "Shopify", Description = "Shopify")]
        Shopify = 5,
    }
    //Sync Rule
    public enum SynchRole : int
    {
        [Display(Name = "NA", ShortName = "NA", Description = "Not Available")]
        NA = 0,
        [Display(Name = "Product - Inventory Sync", ShortName = "InventorySync", Description = "Inventory Sync")]
        InventorySync = 1,
        [Display(Name = "Order - Sync", ShortName = "OrderSync", Description = "Order Sync")]
        OrderSync = 2,
        [Display(Name = "Client Sync", ShortName = "ClientSync", Description = "Client Sync")]
        ClientSync = 3,

        //We can add more rules here
        [Display(Name = "Product - Turn Off Stock Sync", ShortName = "TurnOffStockSync", Description = "Turn Off Stock Sync (live site only)")]
        TurnOffStockSync = 4,
        /// <summary>
        /// Live environment else testing
        /// </summary>
        [Display(Name = "Order - Change Order Paid", ShortName = "ChangeOrderPaid", Description = "Order has paid to send the client (live site only)")]
        OrderPaid = 5,
        [Display(Name = "Order - Turn Off Order Sync", ShortName = "TurnOffOrderSync", Description = "TurnOffOrderSync")]
        TurnOffOrderSync = 6,

        [Display(Name = "Product - Request to Sync Stock", ShortName = "RequestSyncStock", Description = "Request to Sync Stock")]
        RequestSyncStock = 7,
        [Display(Name = "Order - Delivery Address Sync", ShortName = "DeliveryAddressSync", Description = "Delivery Address Sync")]
        DeliveryAddressSync = 8,

        /// <summary>
        /// If We have an item to be personalisation in the order then the order items shoule be processed By Fulfilment Team
        /// updated 14/05/2021 
        /// </summary>
        [Display(Name = "Order - Process Order By FF", ShortName = "Process Order By FF", Description = "If We have an item to be personalisation of the order then the order should be processed By Fulfilment Team")]
        OrderProcessingByFF = 9,

        /// <summary>
        /// Set onHold. If the order is on international order
        /// </summary>
        [Display(Name = "Order - Set OnHold Order", ShortName = "SetOnHoldOrder", Description = "Set onHold. If the order is on international order.")]
        SetOnHoldOrder = 10,
        /// <summary>
        /// Get inventory code on order from shop
        /// </summary>
        [Display(Name = "Order - Inventory Code From Shop", ShortName = "InventoryCodeFromShop", Description = "Get InventoryCode on order from shop")]
        InventoryCodeFromShop = 11,

        /// <summary>
        /// Get inventory code on order from shop
        /// </summary>
        [Display(Name = "Order - Apply the default tax", ShortName = "SetDefaultTax", Description = "Set default tax calculation based on country: 10% AUS, 0% for International ")]
        SetDefaultTax = 12,

        [Display(Name = "Order - Sync Tracking Number", ShortName = "SyncTrackingNumber", Description = "Sync tracking number (live site only)")]
        SyncTrackingNumber = 13,

        /// <summary>
        /// Set default Warehouse for order
        /// </summary>
        [Display(Name = "Order - Set Default OrderDetail Warehouse", ShortName = "DefaultWHOrderDetail", Description = "Set default Warehouse for order")]
        SetDefaultWH = 14,

        /// <summary>
        /// Set active to sync the tpf order staus back to external shop.
        /// </summary>
        [Display(Name = "Order - Sync TPF Order Status", ShortName = "SyncOrderStatus", Description = "Sync TPF order status back to the External Shop (live site only)")]
        SyncOrderStatus = 15,

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "Product - Allow multiple TPFCatalogues", ShortName = "MultipleTPFCatalogues", Description = "Allow to sync from the multiple catalogues")]
        MultipleTPFCatalogues = 16,
    }

    public enum GroupLog : int
    {
        [Display(Name = "NA")]
        NA = 0,
        [Display(Name = "Inventory Sync")]
        InventorySync = 1,
        [Display(Name = "Order Sync")]
        OrderSync = 2,
        [Display(Name = "Client Sync")]
        ClientSync = 3,
        [Display(Name = "SignalR Hubs")]
        SignalRHubs = 4,
        [Display(Name = "SignalR Hubs Authorize")]
        SignalRHubsAuthorize = 5,
        [Display(Name = "Order Repository")]
        OrderRepository = 6,
        [Display(Name = "Account Manager")]
        AccountManager = 7,
        [Display(Name = "Inventory Repository")]
        InventoryRepository = 8,
        [Display(Name = "SignalR Order Hubs")]
        SignalROrderHubs = 9,
        [Display(Name = "Remote Data Service Api")]
        RemoteDataServiceApi = 10,
        [Display(Name = "Sync Repository", ShortName = "SyncRepository")]
        SyncRepository = 11,
        [Display(Name = "Unit Testing", ShortName = "UnitTesting")]
        UnitTesting = 12,
        [Display(Name = "Utility", ShortName = "Utility")]
        Utility = 13,
        [Display(Name = "Sync Magento 1", ShortName = "SyncMagento1")]
        SyncMagento1 = 14,
        /// <summary>
        /// Sync Magento2 client
        /// </summary>
        [Display(Name = "Sync Magento 2", ShortName = "SyncMagento2")]
        SyncMagento2 = 15,
        [Display(Name = "Event Repository")]
        EventRepository = 16,
        [Display(Name = "Sync Manager UI")]
        SyncManagerUI = 17,
        [Display(Name = "SignalR Client Magento2", ShortName = "SignalRClientMagento2")]
        SignalRClientMagento2 = 18,
        [Display(Name = "Schedule Service", ShortName = "ScheduleService")]
        ScheduleService = 19,
        [Display(Name = "Sync WLB", ShortName = "SyncWLB")]
        SyncWLB = 20,
        [Display(Name = "Cricket Blast", ShortName = "CA")]
        SyncCA = 21,
        [Display(Name = "SignalR Client Magento1", ShortName = "SignalRClientMagento1")]
        SignalRClientMagento1 = 22,
        [Display(Name = "Magento2 API Client ", ShortName = "Magento2ApiClient")]
        Magento2ApiClient = 23,
        [Display(Name = "Sync Manager Api ", ShortName = "SyncManagerApi")]
        SyncManagerApi = 24,
        [Display(Name = "SignalR Client Cricket", ShortName = "SignalRClientCricket")]
        SignalRClientCricket = 25,
        [Display(Name = "Account Repository", ShortName = "AccountRepository")]
        AccountRepository = 26,
        [Display(Name = "SignalR Connection", ShortName = "SignalRConnection")]
        SignalRConnection = 27,
        [Display(Name = "Promotion Service", ShortName = "PromotionService")]
        PromotionService = 28,
        [Display(Name = "Sync Shopify", ShortName = "SyncShopify")]
        SyncShopify = 29,
        [Display(Name = "RabbitMQ Service", ShortName = "RabbitMQService")]
        RabbitMQService = 30,
        [Display(Name = "Shopify Sync Service", ShortName = "ShopifySyncService")]
        ShopifySyncService = 31,
        [Display(Name = "Schedule Shopify Sync Service", ShortName = "ScheduleShopifySyncService")]
        ScheduleShopifySyncService = 32,
        [Display(Name = "Validation Attribute Sync Service", ShortName = "ValidationAttributeSyncService")]
        ValidationAttribute = 33,
    }

    public enum TpfOrderRejectType : int
    {
        [Display(Name = "NA")]
        NA = 0,
        [Display(Name = "Wrong delivery address")]
        WrongDeliveryAddress = 1,
        [Display(Name = "Partly return")]
        PartlyReturn = 2,
        [Display(Name = "Fully return")]
        FullyReturn = 3,
        [Display(Name = "RTS return")]
        RTSReturn = 6,
    }

    public enum DeliveryStatus : int
    {
        [Display(Description = "NA", Name = "NA", ShortName = "NA")]
        NA = 0,
        [Display(Description = "Fully Delivered", Name = "Fully Delivered", ShortName = "FullyDelivered")]
        FullyDelivered = 1,
        [Display(Description = "New", Name = "New", ShortName = "New")]
        New = 2,
        [Display(Description = "Partly Delivered", Name = "Partly Delivered", ShortName = "PartlyDelivered")]
        PartlyDelivered = 3,
        //[Display(Description = "Partly Delivered", Name = "Partly Delivered", ShortName = "PartlyDelivered")]
        //PartlyDelivered = 3,
    };
}
