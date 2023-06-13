namespace BusinessServices.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //this.CreateMap<WhOcDelivery, MplusDeliveryNotSyncYetModel>();
            //this.CreateMap<WhOcDelivery, WarehouseOrderDeliveryModel>();
            //this.CreateMap<WhOcDeliveryDetail, WarehouseOrderDeliveryDetailModel>();

            #region SyncOrder
            this.CreateMap<MplusOrderNotSyncYetModel, SyncOrderMplusToFFQueueModel>()
                .ForMember(des => des.item, opts => opts.MapFrom(src => src));

            this.CreateMap<SyncOrderMplusToFFQueueModel, Data.Databases.BackgroundTask.PushQueue>()
                .ForMember(des => des.Action, opts => opts.MapFrom(src => src.action))
                .ForMember(des => des.Created, opts => opts.MapFrom(src => src.create))
                .ForMember(des => des.Queue, opts => opts.MapFrom(src => JsonConvert.SerializeObject(src.item)));

            this.CreateMap<Data.Databases.CMS_EMBERPLUS.WebOrder, WebOrder_OrderConnection>();
            //this.CreateMap<WebOrderDeliveryTracking, WebOrderDeliveryTracking_OrderConnection>();

            this.CreateMap<SyncOrderRequest, SyncOrderRepo>()
                .ForMember(dest => dest.PONumber, opts => opts.MapFrom(src => src.PONumber))
                .ForMember(dest => dest.Created, opts => opts.MapFrom(src => src.Created))
                .ForMember(dest => dest.PaymentType, opts => opts.MapFrom(src => src.PaymentType))
                .ForMember(dest => dest.Txnref, opts => opts.MapFrom(src => src.Txnref))
                .ForMember(dest => dest.CatalogueID, opts => opts.MapFrom(src => src.CatalogueID))
                .ForMember(dest => dest.Status, opts => opts.MapFrom(src => src.Status))
                .ForMember(dest => dest.Notes, opts => opts.MapFrom(src => src.Notes))
                .ForMember(dest => dest.Currency, opts => opts.MapFrom(src => src.Currency))
                .ForMember(dest => dest.ExchangeRate, opts => opts.MapFrom(src => src.ExchangeRate))
                .ForMember(dest => dest.TradingTerms, opts => opts.MapFrom(src => src.TradingTerms))
                .ForMember(dest => dest.ClientID, opts => opts.MapFrom(src => src.ClientID))
                .ForMember(dest => dest.FreightFee, opts => opts.MapFrom(src => src.FreightFee))
                .ForMember(dest => dest.FreightTax, opts => opts.MapFrom(src => src.FreightTax))
                .ForMember(dest => dest.FreightTaxRate, opts => opts.MapFrom(src => src.FreightTaxRate))
                .ForMember(dest => dest.DiscountAmount, opts => opts.MapFrom(src => src.DiscountAmount))
                .ForMember(dest => dest.DiscountTax, opts => opts.MapFrom(src => src.DiscountTax))
                .ForMember(dest => dest.DiscountTaxRate, opts => opts.MapFrom(src => src.DiscountTaxRate))
                .ForMember(dest => dest.ExtraInfo, opts => opts.MapFrom(src => src.ExtraInfo))
                .ForMember(dest => dest.ShippingType, opts => opts.MapFrom(src => src.ShippingType))
                .ForMember(dest => dest.RefType, opts => opts.MapFrom(src => src.RefType))
                .ForMember(dest => dest.Contact, opts => opts.MapFrom(src => src.Contact))
                .ForMember(dest => dest.Billing, opts => opts.MapFrom(src => src.Billing))
                //.ForMember(dest => dest.Billing.Attention, opts => opts.MapFrom(src => src.Billing.Attention))
                .ForMember(dest => dest.Delivery, opts => opts.MapFrom(src => src.Delivery))
                .ForMember(dest => dest.ExtraInfo, opts => opts.MapFrom(src => src.ExtraInfo))
                //.ForMember(dest => dest.Delivery.Attention, opts => opts.MapFrom(src => src.Delivery.Attention))
                .ForMember(dest => dest.Orderdetails, opts => opts.MapFrom(src => src.Orderdetails))

                //For credit card transaction
                .ForPath(dest => dest.creditCardTran.Currency, opts => opts.MapFrom(src => src.PaymentTransation.Currency))
                .ForPath(dest => dest.creditCardTran.Amount, opts => opts.MapFrom(src => src.PaymentTransation.Amount))
                .ForPath(dest => dest.creditCardTran.TxnReference, opts => opts.MapFrom(src => src.PaymentTransation.TxnReference))
                .ForPath(dest => dest.creditCardTran.ResponseCode, opts => opts.MapFrom(src => src.PaymentTransation.ResponseCode))
                .ForPath(dest => dest.creditCardTran.ResponseText, opts => opts.MapFrom(src => src.PaymentTransation.ResponseText))
                .ForPath(dest => dest.creditCardTran.Paid, opts => opts.MapFrom(src => src.PaymentTransation.Paid))
                .ForPath(dest => dest.creditCardTran.Bank, opts => opts.MapFrom(src => ""))
                .ForPath(dest => dest.creditCardTran.CardType, opts => opts.MapFrom(src => ""))
                .ForPath(dest => dest.creditCardTran.CardNumber, opts => opts.MapFrom(src => ""))
                .ForPath(dest => dest.creditCardTran.Bank, opts => opts.MapFrom(src => String.Format("{0}", src.PaymentTransation.Bank)))
                .ForPath(dest => dest.creditCardTran.CardType, opts => opts.MapFrom(src => String.Format("{0}", src.PaymentTransation.CardType)))
                .ForPath(dest => dest.creditCardTran.CardNumber, opts => opts.MapFrom(src => String.Format("{0}", src.PaymentTransation.CardNumber)))
                .ForPath(dest => dest.creditCardTran.Created, opts => opts.MapFrom(src => src.PaymentTransation.Created))
                .ForPath(dest => dest.creditCardTran.PayDate, opts => opts.MapFrom(src => src.PaymentTransation.PayDate))

                //For paypal transaction
                .ForPath(dest => dest.PaypalTran.Amount, opts => opts.MapFrom(src => src.PaymentTransation.Amount))
                .ForPath(dest => dest.PaypalTran.Created, opts => opts.MapFrom(src => src.PaymentTransation.Created))
                .ForPath(dest => dest.PaypalTran.Fee, opts => opts.MapFrom(src => 0.0m))
                .ForPath(dest => dest.PaypalTran.ExchangeRate, opts => opts.MapFrom(src => src.ExchangeRate))

                //important
                .ForPath(dest => dest.PaypalTran.TransactionId, opts => opts.MapFrom(src => src.PaymentTransation.TxnReference))
                .ForPath(dest => dest.PaypalTran.Token, opts => opts.MapFrom(src => src.PaymentTransation.ResponseCode))
                .ForPath(dest => dest.PaypalTran.Paid, opts => opts.MapFrom(src => !String.IsNullOrEmpty(src.PaymentTransation.TxnReference)))
                .ForPath(dest => dest.PaypalTran.PaymentStatus, opts => opts.MapFrom(src => "Completed"))
                .ForPath(dest => dest.PaypalTran.OrderNumber, opts => opts.MapFrom(src => ""))
                .ForPath(dest => dest.PaypalTran.PaymentType, opts => opts.MapFrom(src => "instant"))
                .ForPath(dest => dest.PaypalTran.PendingReason, opts => opts.MapFrom(src => ""))
                .ForPath(dest => dest.PaypalTran.ReasonCode, opts => opts.MapFrom(src => "0"))
                .ForPath(dest => dest.PaypalTran.Client.PayerId, opts => opts.MapFrom(src => src.PaymentTransation.PayPalClientID))
                .ForPath(dest => dest.PaypalTran.Client.Firstname, opts => opts.MapFrom(src => src.Billing.FirstName))
                .ForPath(dest => dest.PaypalTran.Client.Lastname, opts => opts.MapFrom(src => src.Billing.FirstName))
                .ForPath(dest => dest.PaypalTran.Client.Address, opts => opts.MapFrom(src => src.Billing.Address1))
                .ForPath(dest => dest.PaypalTran.Client.Attention, opts => opts.MapFrom(src => String.Format("{0} {1}", src.Billing.FirstName, src.Billing.LastName)))
                .ForPath(dest => dest.PaypalTran.Client.CompanyName, opts => opts.MapFrom(src => src.Billing.CompanyName))
                .ForPath(dest => dest.PaypalTran.Client.City, opts => opts.MapFrom(src => src.Billing.Suburb))
                .ForPath(dest => dest.PaypalTran.Client.State, opts => opts.MapFrom(src => src.Billing.State))
                .ForPath(dest => dest.PaypalTran.Client.Postcode, opts => opts.MapFrom(src => src.Billing.Postcode))
                .ForPath(dest => dest.PaypalTran.Client.Country, opts => opts.MapFrom(src => src.Billing.Country))
                .ForPath(dest => dest.PaypalTran.Client.CountryCode, opts => opts.MapFrom(src => ""))
                .ForPath(dest => dest.PaypalTran.Client.Email, opts => opts.MapFrom(src => src.Billing.Email))
                .ForPath(dest => dest.PaypalTran.Client.Phone, opts => opts.MapFrom(src => src.Billing.Phone))
                .ForPath(dest => dest.PaypalTran.Client.PayerStatus, opts => opts.MapFrom(src => "Unconfirmed"))
                .ForPath(dest => dest.PaypalTran.Client.AddressStatus, opts => opts.MapFrom(src => "unverified"))
                .ForPath(dest => dest.PaypalTran.Client.Status, opts => opts.MapFrom(src => "current"));
            #endregion SyncOrder

            #region SyncProduct
            this.CreateMap<MemberPlusProductNotSyncYetModel, MemberPlusProductNotSyncYetQueueModel>()
				.ForMember(des => des.item, opt => opt.MapFrom(s => s));

			this.CreateMap<MemberPlusProductNotSyncYetQueueModel, Data.Databases.BackgroundTask.PushQueue>()
			   .ForMember(des => des.Action, opt => opt.MapFrom(s => s.action))
			   .ForMember(des => des.Created, opt => opt.MapFrom(s => s.create))
			   .ForMember(des => des.Queue, opt => opt.MapFrom(s => JsonConvert.SerializeObject(s.item)));
            #endregion SyncProduct


        }
    }
}
