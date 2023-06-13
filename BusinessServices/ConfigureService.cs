

using BusinessServices.Services;
using BusinessServices.Services.MPlusSyncOrder;

namespace BusinessServices
{
	public static class ConfigureService
	{
		public static IServiceCollection AddBusinessService(this IServiceCollection services)
		{
			services.AddTransient<ISendMailServices, SendMailServices>();
			services.AddTransient<IMplusOrderNotSyncYetServices, MplusOrderNotSyncYetServices>();
			services.AddTransient<IMemberPlusProductNotSyncYetServices, MemberPlusProductNotSyncYetServices>();
			services.AddTransient<IMemberPlusReminderPaymentNotificationServices, MemberPlusReminderPaymentNotificationServices>();
			services.AddTransient<IMemberPlusOrderDeliveryNotSyncServices, MemberPlusOrderDeliveryNotSyncServices>();
			services.AddTransient<IMemberPlusOrderDeliveryNotDispatchServices, MemberPlusOrderDeliveryNotDispatchServices>();
			services.AddTransient<ISignalRServices, SignalRServices>();
			services.AddTransient<IAPIOrderDispatchsServices, APIOrderDispatchsServices>();

			

			services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
			return services;
		}
		public static IServiceCollection AddContextsService(this IServiceCollection services)
		{
			if (AppSettingsConstant.ENV.Equals("PROD"))
			{
				services.AddDbContext<Data.Contexts.ExternalServicesContext>(opts =>
				{
					opts.UseSqlServer(AppSettingsConstant.Config.Dbs.ConnectionString["192.168.21.69"]["ExternalServicesDatabase"].DecodeFrom64());
				});
				services.AddDbContext<Data.Contexts.CmsEmberplusContext>(opts =>
				{
					opts.UseSqlServer(AppSettingsConstant.Config.Dbs.ConnectionString["10.0.2.155"]["CMS_EMBERPLUS_DEVDatabase"].DecodeFrom64());
				});
				services.AddDbContext<Data.Contexts.TpfservicesContext>(opts =>
				{
					opts.UseSqlServer(AppSettingsConstant.Config.Dbs.ConnectionString["192.168.7.203"]["TpfservicesDatabase"].DecodeFrom64());
				});
				services.AddDbContext<Data.Contexts.Csversion1Context>(opts =>
				{
					opts.UseSqlServer(AppSettingsConstant.Config.Dbs.ConnectionString["10.0.2.44"]["Csversion1Database"].DecodeFrom64());
				});
				services.AddDbContext<Data.Contexts.TpfsystemContext>(opts =>
				{
					opts.UseSqlServer(AppSettingsConstant.Config.Dbs.ConnectionString["192.168.7.203"]["TpfsystemDatabase"].DecodeFrom64());
				});
				services.AddDbContext<Data.Contexts.Tpf2003Context>(opts =>
				{
					opts.UseSqlServer(AppSettingsConstant.Config.Dbs.ConnectionString["192.168.7.203"]["Tpf2003Database"].DecodeFrom64());
				});
				services.AddDbContext<Data.Contexts.OnlineSyncDataContext>(opts =>
				{
					opts.UseSqlServer(AppSettingsConstant.Config.Dbs.ConnectionString["192.168.7.203"]["OnlineSyncDataDatabase"].DecodeFrom64());
				});
				services.AddDbContext<Data.Contexts.TestDbContext>(opts =>
				{
					opts.UseSqlServer(AppSettingsConstant.Config.Dbs.ConnectionString["localhost"]["LocalhostDatabase"].DecodeFrom64());
				});
				services.AddDbContext<Data.Contexts.BackgroundTaskContext>(opts =>
				{
					opts.UseSqlServer(AppSettingsConstant.Config.Dbs.ConnectionString["localhost"]["Localhost2Database"].DecodeFrom64());
				});
			}
			else
			{
				services.AddDbContext<Data.Contexts.ExternalServicesContext>(opts =>
				{
					opts.UseSqlServer(AppSettingsConstant.Config.Dbs.ConnectionString["192.168.21.69"]["ExternalServicesDatabase"]);
				});
				services.AddDbContext<Data.Contexts.CmsEmberplusContext>(opts =>
				{
					opts.UseSqlServer(AppSettingsConstant.Config.Dbs.ConnectionString["10.0.2.155"]["CMS_EMBERPLUS_DEVDatabase"]);
				});
				services.AddDbContext<Data.Contexts.TpfservicesContext>(opts =>
				{
					opts.UseSqlServer(AppSettingsConstant.Config.Dbs.ConnectionString["192.168.7.203"]["TpfservicesDatabase"]);
				});
				services.AddDbContext<Data.Contexts.Csversion1Context>(opts =>
				{
					opts.UseSqlServer(AppSettingsConstant.Config.Dbs.ConnectionString["10.0.2.44"]["Csversion1Database"]);
				});
				services.AddDbContext<Data.Contexts.TpfsystemContext>(opts =>
				{
					opts.UseSqlServer(AppSettingsConstant.Config.Dbs.ConnectionString["192.168.7.203"]["TpfsystemDatabase"]);
				});
				services.AddDbContext<Data.Contexts.Tpf2003Context>(opts =>
				{
					opts.UseSqlServer(AppSettingsConstant.Config.Dbs.ConnectionString["192.168.7.203"]["Tpf2003Database"]);
				});
				services.AddDbContext<Data.Contexts.OnlineSyncDataContext>(opts =>
				{
					opts.UseSqlServer(AppSettingsConstant.Config.Dbs.ConnectionString["192.168.7.203"]["OnlineSyncDataDatabase"]);
				});
				services.AddDbContext<Data.Contexts.TestDbContext>(opts =>
				{
					opts.UseSqlServer(AppSettingsConstant.Config.Dbs.ConnectionString["localhost"]["LocalhostDatabase"]);
				});
				services.AddDbContext<Data.Contexts.BackgroundTaskContext>(opts =>
				{
					opts.UseSqlServer(AppSettingsConstant.Config.Dbs.ConnectionString["localhost"]["Localhost2Database"]);
				});
			}
			return services;
		}
		
		public static IServiceCollection AddRepositoriesService(this IServiceCollection services)
		{			

			services.AddTransient<Data.Repositories.BackgroundTask.IPushQueueRepository, Data.Repositories.BackgroundTask.PushQueueRepository>();

			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICalcCalculationLogRepository, Data.Repositories.CMS_EMBERPLUS.CalcCalculationLogRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICalcCalculationParticipantRepository, Data.Repositories.CMS_EMBERPLUS.CalcCalculationParticipantRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICalcEntityRepository, Data.Repositories.CMS_EMBERPLUS.CalcEntityRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICalcMessageCodeRepository, Data.Repositories.CMS_EMBERPLUS.CalcMessageCodeRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICalcOrganisationRepository, Data.Repositories.CMS_EMBERPLUS.CalcOrganisationRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICalcParticipantRepository, Data.Repositories.CMS_EMBERPLUS.CalcParticipantRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICalcParticipantProgramRepository, Data.Repositories.CMS_EMBERPLUS.CalcParticipantProgramRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICalcParticipantProgramDetailRepository, Data.Repositories.CMS_EMBERPLUS.CalcParticipantProgramDetailRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICalcParticipantProgramOrderAddOnRepository, Data.Repositories.CMS_EMBERPLUS.CalcParticipantProgramOrderAddOnRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICalcParticipantRejecttionRepository, Data.Repositories.CMS_EMBERPLUS.CalcParticipantRejecttionRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICalcProgramRepository, Data.Repositories.CMS_EMBERPLUS.CalcProgramRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICalcRegionRepository, Data.Repositories.CMS_EMBERPLUS.CalcRegionRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICalcSeasonCreditHistoryRepository, Data.Repositories.CMS_EMBERPLUS.CalcSeasonCreditHistoryRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICarouselRepository, Data.Repositories.CMS_EMBERPLUS.CarouselRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICarouselItemRepository, Data.Repositories.CMS_EMBERPLUS.CarouselItemRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICarouselWidgetRepository, Data.Repositories.CMS_EMBERPLUS.CarouselWidgetRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICheckoutPaymentRepository, Data.Repositories.CMS_EMBERPLUS.CheckoutPaymentRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICheckoutShippingRepository, Data.Repositories.CMS_EMBERPLUS.CheckoutShippingRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICheckoutWidgetRepository, Data.Repositories.CMS_EMBERPLUS.CheckoutWidgetRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICmsBarcodeRepository, Data.Repositories.CMS_EMBERPLUS.CmsBarcodeRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICmsBgimageEditorRepository, Data.Repositories.CMS_EMBERPLUS.CmsBgimageEditorRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICmsConfigurationRepository, Data.Repositories.CMS_EMBERPLUS.CmsConfigurationRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICmsConfigurationColorRepository, Data.Repositories.CMS_EMBERPLUS.CmsConfigurationColorRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICmsConfigurationJobRepository, Data.Repositories.CMS_EMBERPLUS.CmsConfigurationJobRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICmsConfigurationRuleRepository, Data.Repositories.CMS_EMBERPLUS.CmsConfigurationRuleRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICmsConfigurationTaskRepository, Data.Repositories.CMS_EMBERPLUS.CmsConfigurationTaskRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICmsConfigurationUiScreenRepository, Data.Repositories.CMS_EMBERPLUS.CmsConfigurationUiScreenRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICmsConfigurationUiScreenColorRepository, Data.Repositories.CMS_EMBERPLUS.CmsConfigurationUiScreenColorRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICmsConfigurationUiScreenElementRepository, Data.Repositories.CMS_EMBERPLUS.CmsConfigurationUiScreenElementRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICmsConfigurationUiScreenFontRepository, Data.Repositories.CMS_EMBERPLUS.CmsConfigurationUiScreenFontRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICmsCounterRepository, Data.Repositories.CMS_EMBERPLUS.CmsCounterRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICmsCountryRepository, Data.Repositories.CMS_EMBERPLUS.CmsCountryRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICmsCurrencyRepository, Data.Repositories.CMS_EMBERPLUS.CmsCurrencyRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICmsCustomerServiceRepository, Data.Repositories.CMS_EMBERPLUS.CmsCustomerServiceRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICmsEmailRepository, Data.Repositories.CMS_EMBERPLUS.CmsEmailRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICmsEmailSampleRepository, Data.Repositories.CMS_EMBERPLUS.CmsEmailSampleRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICmsEmailToRepository, Data.Repositories.CMS_EMBERPLUS.CmsEmailToRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICmsHtmleditorRepository, Data.Repositories.CMS_EMBERPLUS.CmsHtmleditorRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICmsImageDatumRepository, Data.Repositories.CMS_EMBERPLUS.CmsImageDatumRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICmsImageEditorRepository, Data.Repositories.CMS_EMBERPLUS.CmsImageEditorRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICmsLanguageRepository, Data.Repositories.CMS_EMBERPLUS.CmsLanguageRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICmsLayoutRepository, Data.Repositories.CMS_EMBERPLUS.CmsLayoutRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICmsLayoutCssResourceRepository, Data.Repositories.CMS_EMBERPLUS.CmsLayoutCssResourceRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICmsLayoutHtmlRepository, Data.Repositories.CMS_EMBERPLUS.CmsLayoutHtmlRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICmsLayoutJsResourceRepository, Data.Repositories.CMS_EMBERPLUS.CmsLayoutJsResourceRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICmsLinkeditorRepository, Data.Repositories.CMS_EMBERPLUS.CmsLinkeditorRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICmsMediumRepository, Data.Repositories.CMS_EMBERPLUS.CmsMediumRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICmsPageRepository, Data.Repositories.CMS_EMBERPLUS.CmsPageRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICmsPagePermissionRepository, Data.Repositories.CMS_EMBERPLUS.CmsPagePermissionRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICmsReportRepository, Data.Repositories.CMS_EMBERPLUS.CmsReportRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICmsReportActionRepository, Data.Repositories.CMS_EMBERPLUS.CmsReportActionRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICmsTaskLogRepository, Data.Repositories.CMS_EMBERPLUS.CmsTaskLogRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICmsTaskScheduleLogRepository, Data.Repositories.CMS_EMBERPLUS.CmsTaskScheduleLogRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICmsTextEditorRepository, Data.Repositories.CMS_EMBERPLUS.CmsTextEditorRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICmsThemeRepository, Data.Repositories.CMS_EMBERPLUS.CmsThemeRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICmsTriggerEmailRepository, Data.Repositories.CMS_EMBERPLUS.CmsTriggerEmailRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICmsTriggerEmailToRepository, Data.Repositories.CMS_EMBERPLUS.CmsTriggerEmailToRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICmsWidgetTemplateRepository, Data.Repositories.CMS_EMBERPLUS.CmsWidgetTemplateRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICmsZoneRepository, Data.Repositories.CMS_EMBERPLUS.CmsZoneRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICmsZoneWidgetRepository, Data.Repositories.CMS_EMBERPLUS.CmsZoneWidgetRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICompanyRepository, Data.Repositories.CMS_EMBERPLUS.CompanyRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICompanyOptionRepository, Data.Repositories.CMS_EMBERPLUS.CompanyOptionRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICompanySmtpRepository, Data.Repositories.CMS_EMBERPLUS.CompanySmtpRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IContentMenuRepository, Data.Repositories.CMS_EMBERPLUS.ContentMenuRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IContentViewRepository, Data.Repositories.CMS_EMBERPLUS.ContentViewRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IContentViewFieldRepository, Data.Repositories.CMS_EMBERPLUS.ContentViewFieldRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IContentWidgetRepository, Data.Repositories.CMS_EMBERPLUS.ContentWidgetRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ICustomerServiceRepository, Data.Repositories.CMS_EMBERPLUS.CustomerServiceRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IDataDictionaryRepository, Data.Repositories.CMS_EMBERPLUS.DataDictionaryRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IDataUniqueCodeRepository, Data.Repositories.CMS_EMBERPLUS.DataUniqueCodeRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IEmailsWithIssueRepository, Data.Repositories.CMS_EMBERPLUS.EmailsWithIssueRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IExtendFieldRepository, Data.Repositories.CMS_EMBERPLUS.ExtendFieldRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IHtmlWidgetRepository, Data.Repositories.CMS_EMBERPLUS.HtmlWidgetRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IImageWidgetRepository, Data.Repositories.CMS_EMBERPLUS.ImageWidgetRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IImpCondConfigurationListRepository, Data.Repositories.CMS_EMBERPLUS.ImpCondConfigurationListRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IImpCondConfigurationListHistoryRepository, Data.Repositories.CMS_EMBERPLUS.ImpCondConfigurationListHistoryRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IImpCondEntitlementRepository, Data.Repositories.CMS_EMBERPLUS.ImpCondEntitlementRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IImpCondEntitlementHistoryRepository, Data.Repositories.CMS_EMBERPLUS.ImpCondEntitlementHistoryRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IImpLookupTableRepository, Data.Repositories.CMS_EMBERPLUS.ImpLookupTableRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IImpMappingRepository, Data.Repositories.CMS_EMBERPLUS.ImpMappingRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IImpMappingSettingRepository, Data.Repositories.CMS_EMBERPLUS.ImpMappingSettingRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IImpMappingSettingHistoryRepository, Data.Repositories.CMS_EMBERPLUS.ImpMappingSettingHistoryRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IImpOfferTrackingRepository, Data.Repositories.CMS_EMBERPLUS.ImpOfferTrackingRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IImpOfferTrackingDetailRepository, Data.Repositories.CMS_EMBERPLUS.ImpOfferTrackingDetailRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IImpPostFflogRepository, Data.Repositories.CMS_EMBERPLUS.ImpPostFflogRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IImpProcessUploadFileLogRepository, Data.Repositories.CMS_EMBERPLUS.ImpProcessUploadFileLogRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IImpRuleSetupRepository, Data.Repositories.CMS_EMBERPLUS.ImpRuleSetupRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IImpRuleSetupHistoryRepository, Data.Repositories.CMS_EMBERPLUS.ImpRuleSetupHistoryRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IImpSeasonRepository, Data.Repositories.CMS_EMBERPLUS.ImpSeasonRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IImpTemplateListRepository, Data.Repositories.CMS_EMBERPLUS.ImpTemplateListRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IImpTemplateListDetailRepository, Data.Repositories.CMS_EMBERPLUS.ImpTemplateListDetailRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IImpUploadFileLogRepository, Data.Repositories.CMS_EMBERPLUS.ImpUploadFileLogRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ILanguageRepository, Data.Repositories.CMS_EMBERPLUS.LanguageRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IMetaAddressRepository, Data.Repositories.CMS_EMBERPLUS.MetaAddressRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IMetaExtentFieldRepository, Data.Repositories.CMS_EMBERPLUS.MetaExtentFieldRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IMetaExtentFieldValueRepository, Data.Repositories.CMS_EMBERPLUS.MetaExtentFieldValueRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IMetaLanguageRepository, Data.Repositories.CMS_EMBERPLUS.MetaLanguageRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IMetaResourceRepository, Data.Repositories.CMS_EMBERPLUS.MetaResourceRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.INavigationRepository, Data.Repositories.CMS_EMBERPLUS.NavigationRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.INavigationListRepository, Data.Repositories.CMS_EMBERPLUS.NavigationListRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.INavigationWidgetRepository, Data.Repositories.CMS_EMBERPLUS.NavigationWidgetRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.INewsRepository, Data.Repositories.CMS_EMBERPLUS.NewsRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.INewsCategoryRepository, Data.Repositories.CMS_EMBERPLUS.NewsCategoryRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IOrderNotificationRepository, Data.Repositories.CMS_EMBERPLUS.OrderNotificationRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IPaymentTransationRepository, Data.Repositories.CMS_EMBERPLUS.PaymentTransationRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IPermissionRepository, Data.Repositories.CMS_EMBERPLUS.PermissionRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IPostAddressRepository, Data.Repositories.CMS_EMBERPLUS.PostAddressRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IPrmoPromotionRepository, Data.Repositories.CMS_EMBERPLUS.PrmoPromotionRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IPrmoPromotionCodeRepository, Data.Repositories.CMS_EMBERPLUS.PrmoPromotionCodeRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IPrmoPromotionCodeAssignUserRepository, Data.Repositories.CMS_EMBERPLUS.PrmoPromotionCodeAssignUserRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IPrmoPromotionCodeUsedRepository, Data.Repositories.CMS_EMBERPLUS.PrmoPromotionCodeUsedRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IPrmoPromotionProductRepository, Data.Repositories.CMS_EMBERPLUS.PrmoPromotionProductRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IPrmoPromotionTypeRepository, Data.Repositories.CMS_EMBERPLUS.PrmoPromotionTypeRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IProductRepository, Data.Repositories.CMS_EMBERPLUS.ProductRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IProductAttachmentRepository, Data.Repositories.CMS_EMBERPLUS.ProductAttachmentRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IProductAttachmentTrackingRepository, Data.Repositories.CMS_EMBERPLUS.ProductAttachmentTrackingRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IProductAttributeDescriptionRepository, Data.Repositories.CMS_EMBERPLUS.ProductAttributeDescriptionRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IProductCategoryRepository, Data.Repositories.CMS_EMBERPLUS.ProductCategoryRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IProductCombineRepository, Data.Repositories.CMS_EMBERPLUS.ProductCombineRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IProductCombineAttributeRepository, Data.Repositories.CMS_EMBERPLUS.ProductCombineAttributeRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IProductCombineAttributeImageRepository, Data.Repositories.CMS_EMBERPLUS.ProductCombineAttributeImageRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IProductCombineAttributeMapRepository, Data.Repositories.CMS_EMBERPLUS.ProductCombineAttributeMapRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IProductCombineMapRepository, Data.Repositories.CMS_EMBERPLUS.ProductCombineMapRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IProductFavoriteRepository, Data.Repositories.CMS_EMBERPLUS.ProductFavoriteRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IProductFilterRepository, Data.Repositories.CMS_EMBERPLUS.ProductFilterRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IProductFilterDetailRepository, Data.Repositories.CMS_EMBERPLUS.ProductFilterDetailRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IProductFilterMapRepository, Data.Repositories.CMS_EMBERPLUS.ProductFilterMapRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IProductImageRepository, Data.Repositories.CMS_EMBERPLUS.ProductImageRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IProductLayerRepository, Data.Repositories.CMS_EMBERPLUS.ProductLayerRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IProductLayerBaseRepository, Data.Repositories.CMS_EMBERPLUS.ProductLayerBaseRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IProductLayerDetailRepository, Data.Repositories.CMS_EMBERPLUS.ProductLayerDetailRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IProductLayerDetailImageRepository, Data.Repositories.CMS_EMBERPLUS.ProductLayerDetailImageRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IProductLetterPersonalizeRepository, Data.Repositories.CMS_EMBERPLUS.ProductLetterPersonalizeRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IProductPackedItemRepository, Data.Repositories.CMS_EMBERPLUS.ProductPackedItemRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IProductPersonalizeRepository, Data.Repositories.CMS_EMBERPLUS.ProductPersonalizeRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IProductPriceRepository, Data.Repositories.CMS_EMBERPLUS.ProductPriceRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IProductPriceBakRepository, Data.Repositories.CMS_EMBERPLUS.ProductPriceBakRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IProductQtyRepository, Data.Repositories.CMS_EMBERPLUS.ProductQtyRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IProductQuotumRepository, Data.Repositories.CMS_EMBERPLUS.ProductQuotumRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IProductRedeemRepository, Data.Repositories.CMS_EMBERPLUS.ProductRedeemRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IProductTagRepository, Data.Repositories.CMS_EMBERPLUS.ProductTagRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IProductTagMapRepository, Data.Repositories.CMS_EMBERPLUS.ProductTagMapRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IProductTrackingClickRepository, Data.Repositories.CMS_EMBERPLUS.ProductTrackingClickRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IProductWaveHouseRepository, Data.Repositories.CMS_EMBERPLUS.ProductWaveHouseRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IProductWishRepository, Data.Repositories.CMS_EMBERPLUS.ProductWishRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IQrtzBlobTriggerRepository, Data.Repositories.CMS_EMBERPLUS.QrtzBlobTriggerRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IQrtzCalendarRepository, Data.Repositories.CMS_EMBERPLUS.QrtzCalendarRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IQrtzCronTriggerRepository, Data.Repositories.CMS_EMBERPLUS.QrtzCronTriggerRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IQrtzFiredTriggerRepository, Data.Repositories.CMS_EMBERPLUS.QrtzFiredTriggerRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IQrtzJobDetailRepository, Data.Repositories.CMS_EMBERPLUS.QrtzJobDetailRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IQrtzLockRepository, Data.Repositories.CMS_EMBERPLUS.QrtzLockRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IQrtzPausedTriggerGrpRepository, Data.Repositories.CMS_EMBERPLUS.QrtzPausedTriggerGrpRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IQrtzSchedulerStateRepository, Data.Repositories.CMS_EMBERPLUS.QrtzSchedulerStateRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IQrtzSimpleTriggerRepository, Data.Repositories.CMS_EMBERPLUS.QrtzSimpleTriggerRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IQrtzSimpropTriggerRepository, Data.Repositories.CMS_EMBERPLUS.QrtzSimpropTriggerRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IQrtzTriggerRepository, Data.Repositories.CMS_EMBERPLUS.QrtzTriggerRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData12515202108020149080550Repository, Data.Repositories.CMS_EMBERPLUS.RawData12515202108020149080550Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData12516202108090114155899Repository, Data.Repositories.CMS_EMBERPLUS.RawData12516202108090114155899Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData125162021080901141558991Repository, Data.Repositories.CMS_EMBERPLUS.RawData125162021080901141558991Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData12516202108090246598409Repository, Data.Repositories.CMS_EMBERPLUS.RawData12516202108090246598409Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData12516202108090639445685Repository, Data.Repositories.CMS_EMBERPLUS.RawData12516202108090639445685Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData12516202108100211337631Repository, Data.Repositories.CMS_EMBERPLUS.RawData12516202108100211337631Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData13718202110120309486716Repository, Data.Repositories.CMS_EMBERPLUS.RawData13718202110120309486716Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData13718202110200140191035Repository, Data.Repositories.CMS_EMBERPLUS.RawData13718202110200140191035Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData13718202110200755439066Repository, Data.Repositories.CMS_EMBERPLUS.RawData13718202110200755439066Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData13718202202070130021605Repository, Data.Repositories.CMS_EMBERPLUS.RawData13718202202070130021605Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData13718202202070141005665Repository, Data.Repositories.CMS_EMBERPLUS.RawData13718202202070141005665Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData13718202202070141036173Repository, Data.Repositories.CMS_EMBERPLUS.RawData13718202202070141036173Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData13718202202071110561351Repository, Data.Repositories.CMS_EMBERPLUS.RawData13718202202071110561351Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData13718202202071110590255Repository, Data.Repositories.CMS_EMBERPLUS.RawData13718202202071110590255Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData13718202202071113436144Repository, Data.Repositories.CMS_EMBERPLUS.RawData13718202202071113436144Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData13718202202071113514674Repository, Data.Repositories.CMS_EMBERPLUS.RawData13718202202071113514674Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData13718202202071132103561Repository, Data.Repositories.CMS_EMBERPLUS.RawData13718202202071132103561Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData13718202202071132173005Repository, Data.Repositories.CMS_EMBERPLUS.RawData13718202202071132173005Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData13718202202071135532127Repository, Data.Repositories.CMS_EMBERPLUS.RawData13718202202071135532127Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData13718202202071135562057Repository, Data.Repositories.CMS_EMBERPLUS.RawData13718202202071135562057Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData13718202202071143436604Repository, Data.Repositories.CMS_EMBERPLUS.RawData13718202202071143436604Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData13718202202071143464421Repository, Data.Repositories.CMS_EMBERPLUS.RawData13718202202071143464421Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData13765202202150748263099Repository, Data.Repositories.CMS_EMBERPLUS.RawData13765202202150748263099Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData13817202110121049465229Repository, Data.Repositories.CMS_EMBERPLUS.RawData13817202110121049465229Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData14320202110290647018384Repository, Data.Repositories.CMS_EMBERPLUS.RawData14320202110290647018384Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData14320202111080329006768Repository, Data.Repositories.CMS_EMBERPLUS.RawData14320202111080329006768Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData14320202111080329143951Repository, Data.Repositories.CMS_EMBERPLUS.RawData14320202111080329143951Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData14320202111080346540337Repository, Data.Repositories.CMS_EMBERPLUS.RawData14320202111080346540337Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData14523202111120752127950Repository, Data.Repositories.CMS_EMBERPLUS.RawData14523202111120752127950Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData14523202111120815172093Repository, Data.Repositories.CMS_EMBERPLUS.RawData14523202111120815172093Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData14523202111120817168610Repository, Data.Repositories.CMS_EMBERPLUS.RawData14523202111120817168610Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData14523202112070157261399Repository, Data.Repositories.CMS_EMBERPLUS.RawData14523202112070157261399Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData14523202112070551228909Repository, Data.Repositories.CMS_EMBERPLUS.RawData14523202112070551228909Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData14523202112070552391073Repository, Data.Repositories.CMS_EMBERPLUS.RawData14523202112070552391073Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData14523202112070635429635Repository, Data.Repositories.CMS_EMBERPLUS.RawData14523202112070635429635Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData15525202204051249187411Repository, Data.Repositories.CMS_EMBERPLUS.RawData15525202204051249187411Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData15924202204120429023104Repository, Data.Repositories.CMS_EMBERPLUS.RawData15924202204120429023104Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData15924202204141200142466Repository, Data.Repositories.CMS_EMBERPLUS.RawData15924202204141200142466Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData16029202204130600208033Repository, Data.Repositories.CMS_EMBERPLUS.RawData16029202204130600208033Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData16433202205171009063367Repository, Data.Repositories.CMS_EMBERPLUS.RawData16433202205171009063367Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData16433202205171033357803Repository, Data.Repositories.CMS_EMBERPLUS.RawData16433202205171033357803Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData16564202207060950373681Repository, Data.Repositories.CMS_EMBERPLUS.RawData16564202207060950373681Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData16667202207061155484034Repository, Data.Repositories.CMS_EMBERPLUS.RawData16667202207061155484034Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData16738202207070317147324Repository, Data.Repositories.CMS_EMBERPLUS.RawData16738202207070317147324Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData16839202207120931356534Repository, Data.Repositories.CMS_EMBERPLUS.RawData16839202207120931356534Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData17142202207201140586460Repository, Data.Repositories.CMS_EMBERPLUS.RawData17142202207201140586460Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData17344202208030931028833Repository, Data.Repositories.CMS_EMBERPLUS.RawData17344202208030931028833Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData17362202210141023126220Repository, Data.Repositories.CMS_EMBERPLUS.RawData17362202210141023126220Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData17445202208021205202686Repository, Data.Repositories.CMS_EMBERPLUS.RawData17445202208021205202686Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData17445202209160726342555Repository, Data.Repositories.CMS_EMBERPLUS.RawData17445202209160726342555Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData17546202208020400315347Repository, Data.Repositories.CMS_EMBERPLUS.RawData17546202208020400315347Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData17668202209071136098342Repository, Data.Repositories.CMS_EMBERPLUS.RawData17668202209071136098342Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData17763202209230252212550Repository, Data.Repositories.CMS_EMBERPLUS.RawData17763202209230252212550Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData17849202209271142438967Repository, Data.Repositories.CMS_EMBERPLUS.RawData17849202209271142438967Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData17970202210030147599126Repository, Data.Repositories.CMS_EMBERPLUS.RawData17970202210030147599126Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData18051202210070936501890Repository, Data.Repositories.CMS_EMBERPLUS.RawData18051202210070936501890Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData18054202210060315031424Repository, Data.Repositories.CMS_EMBERPLUS.RawData18054202210060315031424Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData18055202210070221244160Repository, Data.Repositories.CMS_EMBERPLUS.RawData18055202210070221244160Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData18056202210071101504644Repository, Data.Repositories.CMS_EMBERPLUS.RawData18056202210071101504644Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData18058202210100330084519Repository, Data.Repositories.CMS_EMBERPLUS.RawData18058202210100330084519Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData18069202210121014405186Repository, Data.Repositories.CMS_EMBERPLUS.RawData18069202210121014405186Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData18152202210040302274183Repository, Data.Repositories.CMS_EMBERPLUS.RawData18152202210040302274183Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData18253202210110313456056Repository, Data.Repositories.CMS_EMBERPLUS.RawData18253202210110313456056Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawData18253202210190739546008Repository, Data.Repositories.CMS_EMBERPLUS.RawData18253202210190739546008Repository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRawDataTestRepository, Data.Repositories.CMS_EMBERPLUS.RawDataTestRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IRoleRepository, Data.Repositories.CMS_EMBERPLUS.RoleRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IScriptWidgetRepository, Data.Repositories.CMS_EMBERPLUS.ScriptWidgetRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ISeasonRepository, Data.Repositories.CMS_EMBERPLUS.SeasonRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IShippingCalculatorRepository, Data.Repositories.CMS_EMBERPLUS.ShippingCalculatorRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IShippingCalculatorChildRepository, Data.Repositories.CMS_EMBERPLUS.ShippingCalculatorChildRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IShippingWeightChildRepository, Data.Repositories.CMS_EMBERPLUS.ShippingWeightChildRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IShoppingWidgetRepository, Data.Repositories.CMS_EMBERPLUS.ShoppingWidgetRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IStyleSheetWidgetRepository, Data.Repositories.CMS_EMBERPLUS.StyleSheetWidgetRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.ITaxRepository, Data.Repositories.CMS_EMBERPLUS.TaxRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IUserRepository, Data.Repositories.CMS_EMBERPLUS.UserRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IUserAccountRepository, Data.Repositories.CMS_EMBERPLUS.UserAccountRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IUserCreditHistoryRepository, Data.Repositories.CMS_EMBERPLUS.UserCreditHistoryRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IUserEmailReminderRepository, Data.Repositories.CMS_EMBERPLUS.UserEmailReminderRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IUserRoleRelationRepository, Data.Repositories.CMS_EMBERPLUS.UserRoleRelationRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IUserTypeRepository, Data.Repositories.CMS_EMBERPLUS.UserTypeRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IUserTypeActionPermissionRepository, Data.Repositories.CMS_EMBERPLUS.UserTypeActionPermissionRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IUserTypePermissionRepository, Data.Repositories.CMS_EMBERPLUS.UserTypePermissionRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IUserTypeUserRepository, Data.Repositories.CMS_EMBERPLUS.UserTypeUserRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IVCalParticipantRepository, Data.Repositories.CMS_EMBERPLUS.VCalParticipantRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IVCalParticipantAukRepository, Data.Repositories.CMS_EMBERPLUS.VCalParticipantAukRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IVCalParticipantBakBeforeAukRepository, Data.Repositories.CMS_EMBERPLUS.VCalParticipantBakBeforeAukRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IVParticipantRepository, Data.Repositories.CMS_EMBERPLUS.VParticipantRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IVRedemptionRepository, Data.Repositories.CMS_EMBERPLUS.VRedemptionRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IVReportRedemptionRepository, Data.Repositories.CMS_EMBERPLUS.VReportRedemptionRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IVReportRedemptionExportRepository, Data.Repositories.CMS_EMBERPLUS.VReportRedemptionExportRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IWarehouseRepository, Data.Repositories.CMS_EMBERPLUS.WarehouseRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IWebOrderRepository, Data.Repositories.CMS_EMBERPLUS.WebOrderRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IWebOrderDeliveryTrackingRepository, Data.Repositories.CMS_EMBERPLUS.WebOrderDeliveryTrackingRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IWebOrderDeliveryTrackingDetailRepository, Data.Repositories.CMS_EMBERPLUS.WebOrderDeliveryTrackingDetailRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IWebOrderDetailRepository, Data.Repositories.CMS_EMBERPLUS.WebOrderDetailRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IWebOrderDetailSubItemRepository, Data.Repositories.CMS_EMBERPLUS.WebOrderDetailSubItemRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IWhOcDeliveryRepository, Data.Repositories.CMS_EMBERPLUS.WhOcDeliveryRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IWhOcDeliveryDetailRepository, Data.Repositories.CMS_EMBERPLUS.WhOcDeliveryDetailRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IWidgetBiToolReportRepository, Data.Repositories.CMS_EMBERPLUS.WidgetBiToolReportRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IWidgetGroupTemplateRepository, Data.Repositories.CMS_EMBERPLUS.WidgetGroupTemplateRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IWidgetGroupTemplateItemRepository, Data.Repositories.CMS_EMBERPLUS.WidgetGroupTemplateItemRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IWidgetTemplateModeRepository, Data.Repositories.CMS_EMBERPLUS.WidgetTemplateModeRepository>();
			services.AddTransient<Data.Repositories.CMS_EMBERPLUS.IZCalcRegionRepository, Data.Repositories.CMS_EMBERPLUS.ZCalcRegionRepository>();

			services.AddTransient<Data.Repositories.Csversion1.ICaAdjustMentCreditPointRepository, Data.Repositories.Csversion1.CaAdjustMentCreditPointRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaAdjustMentCreditPointEntityLogRepository, Data.Repositories.Csversion1.CaAdjustMentCreditPointEntityLogRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaAusStateListRepository, Data.Repositories.Csversion1.CaAusStateListRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaAvalableRepository, Data.Repositories.Csversion1.CaAvalableRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaAvalableCheckSendMailRepository, Data.Repositories.Csversion1.CaAvalableCheckSendMailRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaAvalableCheckSendMailTBakRepository, Data.Repositories.Csversion1.CaAvalableCheckSendMailTBakRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaAvalableTBakRepository, Data.Repositories.Csversion1.CaAvalableTBakRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaBblRepository, Data.Repositories.Csversion1.CaBblRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaBlastCentreSettingRepository, Data.Repositories.Csversion1.CaBlastCentreSettingRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaCalculateRepository, Data.Repositories.Csversion1.CaCalculateRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaCalculatebackRepository, Data.Repositories.Csversion1.CaCalculatebackRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaCategoryRepository, Data.Repositories.Csversion1.CaCategoryRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaClubBblRepository, Data.Repositories.Csversion1.CaClubBblRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaConditionUpdateTransIdRepository, Data.Repositories.Csversion1.CaConditionUpdateTransIdRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaConsetRepository, Data.Repositories.Csversion1.CaConsetRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaConsetCheckRepository, Data.Repositories.Csversion1.CaConsetCheckRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaDayPerStateRepository, Data.Repositories.Csversion1.CaDayPerStateRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaDeleteUserLogRepository, Data.Repositories.Csversion1.CaDeleteUserLogRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaEntityRepository, Data.Repositories.Csversion1.CaEntityRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaEntityBkRepository, Data.Repositories.Csversion1.CaEntityBkRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaImgBblRepository, Data.Repositories.Csversion1.CaImgBblRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaImgSubRepository, Data.Repositories.Csversion1.CaImgSubRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaImgSubBakRepository, Data.Repositories.Csversion1.CaImgSubBakRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaJnrcritketRawRepository, Data.Repositories.Csversion1.CaJnrcritketRawRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaModifiedEntitiesLogRepository, Data.Repositories.Csversion1.CaModifiedEntitiesLogRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaOrderRepository, Data.Repositories.Csversion1.CaOrderRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaOrganisationRepository, Data.Repositories.Csversion1.CaOrganisationRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaPlayerRepository, Data.Repositories.Csversion1.CaPlayerRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaPlayerLogRepository, Data.Repositories.Csversion1.CaPlayerLogRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaPlayerProductRepository, Data.Repositories.Csversion1.CaPlayerProductRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaPlayerProductBak20191205Repository, Data.Repositories.Csversion1.CaPlayerProductBak20191205Repository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaPlayerProductLogRepository, Data.Repositories.Csversion1.CaPlayerProductLogRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaPlayerProductsLogRepository, Data.Repositories.Csversion1.CaPlayerProductsLogRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaPlayerProgramRepository, Data.Repositories.Csversion1.CaPlayerProgramRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaProductRepository, Data.Repositories.Csversion1.CaProductRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaProductBblclubRepository, Data.Repositories.Csversion1.CaProductBblclubRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaProductPreviewRepository, Data.Repositories.Csversion1.CaProductPreviewRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaProductProfilePreviewRepository, Data.Repositories.Csversion1.CaProductProfilePreviewRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaProductTableRepository, Data.Repositories.Csversion1.CaProductTableRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaProductTbakRepository, Data.Repositories.Csversion1.CaProductTbakRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaProductTypeRepository, Data.Repositories.Csversion1.CaProductTypeRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaProductType1Repository, Data.Repositories.Csversion1.CaProductType1Repository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaProductTypeSubRepository, Data.Repositories.Csversion1.CaProductTypeSubRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaProductTypeTuRepository, Data.Repositories.Csversion1.CaProductTypeTuRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaProgramRepository, Data.Repositories.Csversion1.CaProgramRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaPromoRepository, Data.Repositories.Csversion1.CaPromoRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaPropackDetailRepository, Data.Repositories.Csversion1.CaPropackDetailRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaRedeemRepository, Data.Repositories.Csversion1.CaRedeemRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaRedeemNewRepository, Data.Repositories.Csversion1.CaRedeemNewRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaSchoolOrganisationStatusRepository, Data.Repositories.Csversion1.CaSchoolOrganisationStatusRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaSchoolOrganisationStatusBakup20201203Repository, Data.Repositories.Csversion1.CaSchoolOrganisationStatusBakup20201203Repository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaSchoolOrganisationStatusBakUpdateOrgIdRepository, Data.Repositories.Csversion1.CaSchoolOrganisationStatusBakUpdateOrgIdRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaSchoolOrgContactRepository, Data.Repositories.Csversion1.CaSchoolOrgContactRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaSchoolOrgContactBak20201303Repository, Data.Repositories.Csversion1.CaSchoolOrgContactBak20201303Repository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaSchoolOrgContactBakDeleteRepository, Data.Repositories.Csversion1.CaSchoolOrgContactBakDeleteRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaSchoolOrgContactBakDelete20200311Repository, Data.Repositories.Csversion1.CaSchoolOrgContactBakDelete20200311Repository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaSchoolOrgContactBakUpdateOrgIdRepository, Data.Repositories.Csversion1.CaSchoolOrgContactBakUpdateOrgIdRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaSchoolOrgContactRestoreRepository, Data.Repositories.Csversion1.CaSchoolOrgContactRestoreRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaSchoolUpdateChangeAccountRepository, Data.Repositories.Csversion1.CaSchoolUpdateChangeAccountRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaSchoolUserEntitlementRawRepository, Data.Repositories.Csversion1.CaSchoolUserEntitlementRawRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaSchoolUserOrganisationRawRepository, Data.Repositories.Csversion1.CaSchoolUserOrganisationRawRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaSchoolUserStatusRepository, Data.Repositories.Csversion1.CaSchoolUserStatusRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaSchoolUserStatusBak201909013Repository, Data.Repositories.Csversion1.CaSchoolUserStatusBak201909013Repository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaSchoolUserStatusBakUpdateContactIdRepository, Data.Repositories.Csversion1.CaSchoolUserStatusBakUpdateContactIdRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaSeasonRepository, Data.Repositories.Csversion1.CaSeasonRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaStateSchoolRepository, Data.Repositories.Csversion1.CaStateSchoolRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaTagRepository, Data.Repositories.Csversion1.CaTagRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaTagProdetailRepository, Data.Repositories.Csversion1.CaTagProdetailRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICatalogueRepository, Data.Repositories.Csversion1.CatalogueRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICatalogueLiveHelpSettingRepository, Data.Repositories.Csversion1.CatalogueLiveHelpSettingRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICataloguePaymentMethodRepository, Data.Repositories.Csversion1.CataloguePaymentMethodRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICatalogueSeoRepository, Data.Repositories.Csversion1.CatalogueSeoRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICategoryRepository, Data.Repositories.Csversion1.CategoryRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaTranLogFulfilmentRepository, Data.Repositories.Csversion1.CaTranLogFulfilmentRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaTransactionLogRepository, Data.Repositories.Csversion1.CaTransactionLogRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICatVoucherRepository, Data.Repositories.Csversion1.CatVoucherRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICaTypeDetailRepository, Data.Repositories.Csversion1.CaTypeDetailRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICheckNewPriceRepository, Data.Repositories.Csversion1.CheckNewPriceRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICheckOrgeRepository, Data.Repositories.Csversion1.CheckOrgeRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICheckPriceCaRepository, Data.Repositories.Csversion1.CheckPriceCaRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICheckProdetailIdRepository, Data.Repositories.Csversion1.CheckProdetailIdRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IComSyncLogRepository, Data.Repositories.Csversion1.ComSyncLogRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICustProfileRepository, Data.Repositories.Csversion1.CustProfileRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ICustProfileBakUpProfileRepository, Data.Repositories.Csversion1.CustProfileBakUpProfileRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IFinanceCurrencyRepository, Data.Repositories.Csversion1.FinanceCurrencyRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IGroupTransactionFfRepository, Data.Repositories.Csversion1.GroupTransactionFfRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IImportTransactionRepository, Data.Repositories.Csversion1.ImportTransactionRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IImportTransactionServiceRepository, Data.Repositories.Csversion1.ImportTransactionServiceRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IItemRatingRepository, Data.Repositories.Csversion1.ItemRatingRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ILogCancelParticipantOrderRepository, Data.Repositories.Csversion1.LogCancelParticipantOrderRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IMatchingRepository, Data.Repositories.Csversion1.MatchingRepository>();
			services.AddTransient<Data.Repositories.Csversion1.INewOrgIdnotUsingUserEntitlementRawRepository, Data.Repositories.Csversion1.NewOrgIdnotUsingUserEntitlementRawRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IParticipantOrderCompareRepository, Data.Repositories.Csversion1.ParticipantOrderCompareRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IParticipantReportOrderSeasonRepository, Data.Repositories.Csversion1.ParticipantReportOrderSeasonRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IPersonalisationRepository, Data.Repositories.Csversion1.PersonalisationRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IPlayHqproductRefRepository, Data.Repositories.Csversion1.PlayHqproductRefRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IProductRepository, Data.Repositories.Csversion1.ProductRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IProductdetailRepository, Data.Repositories.Csversion1.ProductdetailRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IProductdetailReferenceRepository, Data.Repositories.Csversion1.ProductdetailReferenceRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IProductKitRepository, Data.Repositories.Csversion1.ProductKitRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IProductPriceRepository, Data.Repositories.Csversion1.ProductPriceRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IProductPricesBakRepository, Data.Repositories.Csversion1.ProductPricesBakRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IProductPricesgroupcaRepository, Data.Repositories.Csversion1.ProductPricesgroupcaRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IProductProfileRepository, Data.Repositories.Csversion1.ProductProfileRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IProductQtyRepository, Data.Repositories.Csversion1.ProductQtyRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IProductSeoRepository, Data.Repositories.Csversion1.ProductSeoRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IProductTemplateRepository, Data.Repositories.Csversion1.ProductTemplateRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IProductTemplateFieldRepository, Data.Repositories.Csversion1.ProductTemplateFieldRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IProductTemplateFieldOptionRepository, Data.Repositories.Csversion1.ProductTemplateFieldOptionRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IProductTemplateMapRepository, Data.Repositories.Csversion1.ProductTemplateMapRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IProPackRepository, Data.Repositories.Csversion1.ProPackRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IProPackDynamicRepository, Data.Repositories.Csversion1.ProPackDynamicRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ISheet1Repository, Data.Repositories.Csversion1.Sheet1Repository>();
			services.AddTransient<Data.Repositories.Csversion1.IStockCaRepository, Data.Repositories.Csversion1.StockCaRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IStockCheckRepository, Data.Repositories.Csversion1.StockCheckRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IStockCheckplRepository, Data.Repositories.Csversion1.StockCheckplRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IStockViewRepository, Data.Repositories.Csversion1.StockViewRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IStockViewtestRepository, Data.Repositories.Csversion1.StockViewtestRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ITagRepository, Data.Repositories.Csversion1.TagRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ITagmapRepository, Data.Repositories.Csversion1.TagmapRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ITagmapbakRepository, Data.Repositories.Csversion1.TagmapbakRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ITagsbakRepository, Data.Repositories.Csversion1.TagsbakRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ITemplateOcdetailsItemRepository, Data.Repositories.Csversion1.TemplateOcdetailsItemRepository>();
			services.AddTransient<Data.Repositories.Csversion1.ITestRepository, Data.Repositories.Csversion1.TestRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IUserSchoolCheckRepository, Data.Repositories.Csversion1.UserSchoolCheckRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IVCablastCentreDayPerStateStateSchoolRepository, Data.Repositories.Csversion1.VCablastCentreDayPerStateStateSchoolRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IVCaDetailsPackRepository, Data.Repositories.Csversion1.VCaDetailsPackRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IVCaDetailsPacknNoneQtyRepository, Data.Repositories.Csversion1.VCaDetailsPacknNoneQtyRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IVCaDetailsPackplRepository, Data.Repositories.Csversion1.VCaDetailsPackplRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IVCaDetailsPackPublicRepository, Data.Repositories.Csversion1.VCaDetailsPackPublicRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IVCaFindCaEntityRepository, Data.Repositories.Csversion1.VCaFindCaEntityRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IVCafindUserRepository, Data.Repositories.Csversion1.VCafindUserRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IVCaGetbblRepository, Data.Repositories.Csversion1.VCaGetbblRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IVCagetbblnewRepository, Data.Repositories.Csversion1.VCagetbblnewRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IVCagetcreditRepository, Data.Repositories.Csversion1.VCagetcreditRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IVCagetprofileproductRepository, Data.Repositories.Csversion1.VCagetprofileproductRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IVCagetpropackdynamicRepository, Data.Repositories.Csversion1.VCagetpropackdynamicRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IVCahistoryRepository, Data.Repositories.Csversion1.VCahistoryRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IVCaOrderRepository, Data.Repositories.Csversion1.VCaOrderRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IVCaProductProfileProductPriceRepository, Data.Repositories.Csversion1.VCaProductProfileProductPriceRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IVCaProductProfileProductPricegroupRepository, Data.Repositories.Csversion1.VCaProductProfileProductPricegroupRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IVCaproductsizeRepository, Data.Repositories.Csversion1.VCaproductsizeRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IVCashowbblRepository, Data.Repositories.Csversion1.VCashowbblRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IVCaUserRepository, Data.Repositories.Csversion1.VCaUserRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IVCaWebAccountRepository, Data.Repositories.Csversion1.VCaWebAccountRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IVGetcavreditRepository, Data.Repositories.Csversion1.VGetcavreditRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IVGetclubDynamicRepository, Data.Repositories.Csversion1.VGetclubDynamicRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IVoucherRepository, Data.Repositories.Csversion1.VoucherRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IVoucherHistoryRepository, Data.Repositories.Csversion1.VoucherHistoryRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IVoucherHistory20200428Repository, Data.Repositories.Csversion1.VoucherHistory20200428Repository>();
			services.AddTransient<Data.Repositories.Csversion1.IVoucherHistoryBackAddCreditRepository, Data.Repositories.Csversion1.VoucherHistoryBackAddCreditRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IVoucherHistoryTuanBakRepository, Data.Repositories.Csversion1.VoucherHistoryTuanBakRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IVouchersBackAddCreditRepository, Data.Repositories.Csversion1.VouchersBackAddCreditRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IVouchersbak20200428Repository, Data.Repositories.Csversion1.Vouchersbak20200428Repository>();
			services.AddTransient<Data.Repositories.Csversion1.IVouchersTuanBakRepository, Data.Repositories.Csversion1.VouchersTuanBakRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IVSwiWebAccountRepository, Data.Repositories.Csversion1.VSwiWebAccountRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IWarehouseRepository, Data.Repositories.Csversion1.WarehouseRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IXmlDatumRepository, Data.Repositories.Csversion1.XmlDatumRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IZexcelRepository, Data.Repositories.Csversion1.ZexcelRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IZplayeridRepository, Data.Repositories.Csversion1.ZplayeridRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IZTbCheckDataEverydayRepository, Data.Repositories.Csversion1.ZTbCheckDataEverydayRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IZUpdatePlayHq220624Repository, Data.Repositories.Csversion1.ZUpdatePlayHq220624Repository>();
			services.AddTransient<Data.Repositories.Csversion1.IZUpdatePlayHqidRepository, Data.Repositories.Csversion1.ZUpdatePlayHqidRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IZUpdateResetRepository, Data.Repositories.Csversion1.ZUpdateResetRepository>();
			services.AddTransient<Data.Repositories.Csversion1.IProductionOrderRepository, Data.Repositories.Csversion1.ProductionOrderRepository>();

			services.AddTransient<Data.Repositories.ExternalServices.IProductRepository, Data.Repositories.ExternalServices.ProductRepository>();
			services.AddTransient<Data.Repositories.ExternalServices.IRoleRepository, Data.Repositories.ExternalServices.RoleRepository>();
			services.AddTransient<Data.Repositories.ExternalServices.ITokenRepository, Data.Repositories.ExternalServices.TokenRepository>();
			services.AddTransient<Data.Repositories.ExternalServices.IUserRepository, Data.Repositories.ExternalServices.UserRepository>();
			services.AddTransient<Data.Repositories.ExternalServices.IWebDomainRepository, Data.Repositories.ExternalServices.WebDomainRepository>();

			services.AddTransient<Data.Repositories.OnlineSyncData.IAccountRepository, Data.Repositories.OnlineSyncData.AccountRepository>();
			services.AddTransient<Data.Repositories.OnlineSyncData.IAccountClaimRepository, Data.Repositories.OnlineSyncData.AccountClaimRepository>();
			services.AddTransient<Data.Repositories.OnlineSyncData.IAccountLoginRepository, Data.Repositories.OnlineSyncData.AccountLoginRepository>();
			services.AddTransient<Data.Repositories.OnlineSyncData.IAccountRegistrationTokenRepository, Data.Repositories.OnlineSyncData.AccountRegistrationTokenRepository>();
			services.AddTransient<Data.Repositories.OnlineSyncData.IAccountRoleRepository, Data.Repositories.OnlineSyncData.AccountRoleRepository>();
			services.AddTransient<Data.Repositories.OnlineSyncData.IClientCheckingRepository, Data.Repositories.OnlineSyncData.ClientCheckingRepository>();
			services.AddTransient<Data.Repositories.OnlineSyncData.IInventorySyncRepository, Data.Repositories.OnlineSyncData.InventorySyncRepository>();
			services.AddTransient<Data.Repositories.OnlineSyncData.IOrderDelTrackingRepository, Data.Repositories.OnlineSyncData.OrderDelTrackingRepository>();
			services.AddTransient<Data.Repositories.OnlineSyncData.IOrderSyncLogRepository, Data.Repositories.OnlineSyncData.OrderSyncLogRepository>();
			services.AddTransient<Data.Repositories.OnlineSyncData.IOrderSyncTrackingRepository, Data.Repositories.OnlineSyncData.OrderSyncTrackingRepository>();
			services.AddTransient<Data.Repositories.OnlineSyncData.IRoleRepository, Data.Repositories.OnlineSyncData.RoleRepository>();
			services.AddTransient<Data.Repositories.OnlineSyncData.IShopifyMembershipInfoTmpRepository, Data.Repositories.OnlineSyncData.ShopifyMembershipInfoTmpRepository>();
			services.AddTransient<Data.Repositories.OnlineSyncData.IStockComparisonRepository, Data.Repositories.OnlineSyncData.StockComparisonRepository>();
			services.AddTransient<Data.Repositories.OnlineSyncData.IStockSyncLogRepository, Data.Repositories.OnlineSyncData.StockSyncLogRepository>();
			services.AddTransient<Data.Repositories.OnlineSyncData.IStoreWebsiteRepository, Data.Repositories.OnlineSyncData.StoreWebsiteRepository>();
			services.AddTransient<Data.Repositories.OnlineSyncData.ISyncLogRepository, Data.Repositories.OnlineSyncData.SyncLogRepository>();
			services.AddTransient<Data.Repositories.OnlineSyncData.IVAccountRepository, Data.Repositories.OnlineSyncData.VAccountRepository>();
			services.AddTransient<Data.Repositories.OnlineSyncData.IVOrderSyncKeyRepository, Data.Repositories.OnlineSyncData.VOrderSyncKeyRepository>();
			services.AddTransient<Data.Repositories.OnlineSyncData.IVOrderSyncTrackingRepository, Data.Repositories.OnlineSyncData.VOrderSyncTrackingRepository>();
			services.AddTransient<Data.Repositories.OnlineSyncData.IVOrderSyncTrackingDevRepository, Data.Repositories.OnlineSyncData.VOrderSyncTrackingDevRepository>();
			services.AddTransient<Data.Repositories.OnlineSyncData.IVOrderTrackingRepository, Data.Repositories.OnlineSyncData.VOrderTrackingRepository>();
			services.AddTransient<Data.Repositories.OnlineSyncData.IVOrderTrackingV2Repository, Data.Repositories.OnlineSyncData.VOrderTrackingV2Repository>();
			services.AddTransient<Data.Repositories.OnlineSyncData.IVSiteStoreInfoRepository, Data.Repositories.OnlineSyncData.VSiteStoreInfoRepository>();
			services.AddTransient<Data.Repositories.OnlineSyncData.IVStockSyncLogRepository, Data.Repositories.OnlineSyncData.VStockSyncLogRepository>();
			services.AddTransient<Data.Repositories.OnlineSyncData.IVStockToSyncRepository, Data.Repositories.OnlineSyncData.VStockToSyncRepository>();

			services.AddTransient<Data.Repositories.TestDB.ICustomerRepository, Data.Repositories.TestDB.CustomerRepository>();
			services.AddTransient<Data.Repositories.TestDB.IPersonRepository, Data.Repositories.TestDB.PersonRepository>();

			services.AddTransient<Data.Repositories.Tpf2003.IBinbaseRepository, Data.Repositories.Tpf2003.BinbaseRepository>();
			services.AddTransient<Data.Repositories.Tpf2003.IElecpaymentRepository, Data.Repositories.Tpf2003.ElecpaymentRepository>();
			services.AddTransient<Data.Repositories.Tpf2003.IPaypalclientRepository, Data.Repositories.Tpf2003.PaypalclientRepository>();
			services.AddTransient<Data.Repositories.Tpf2003.IPaypaltranRepository, Data.Repositories.Tpf2003.PaypaltranRepository>();
			services.AddTransient<Data.Repositories.Tpf2003.IPayTransLogRepository, Data.Repositories.Tpf2003.PayTransLogRepository>();
			services.AddTransient<Data.Repositories.Tpf2003.IStaffRepository, Data.Repositories.Tpf2003.StaffRepository>();

			services.AddTransient<Data.Repositories.TPFServices.IAppClientRepository, Data.Repositories.TPFServices.AppClientRepository>();
			services.AddTransient<Data.Repositories.TPFServices.IAppClientShopRepository, Data.Repositories.TPFServices.AppClientShopRepository>();
			services.AddTransient<Data.Repositories.TPFServices.IFfApiclientRepository, Data.Repositories.TPFServices.FfApiclientRepository>();
			services.AddTransient<Data.Repositories.TPFServices.IFfImportTransactionRepository, Data.Repositories.TPFServices.FfImportTransactionRepository>();
			services.AddTransient<Data.Repositories.TPFServices.IImportDataDictionaryRepository, Data.Repositories.TPFServices.ImportDataDictionaryRepository>();
			services.AddTransient<Data.Repositories.TPFServices.IImportEntityRepository, Data.Repositories.TPFServices.ImportEntityRepository>();
			services.AddTransient<Data.Repositories.TPFServices.IImportOrganisationRepository, Data.Repositories.TPFServices.ImportOrganisationRepository>();
			services.AddTransient<Data.Repositories.TPFServices.IImportParticipantRepository, Data.Repositories.TPFServices.ImportParticipantRepository>();
			services.AddTransient<Data.Repositories.TPFServices.IImportProductRepository, Data.Repositories.TPFServices.ImportProductRepository>();
			services.AddTransient<Data.Repositories.TPFServices.IImportProgramRepository, Data.Repositories.TPFServices.ImportProgramRepository>();
			services.AddTransient<Data.Repositories.TPFServices.IImportTransactionRepository, Data.Repositories.TPFServices.ImportTransactionRepository>();
			services.AddTransient<Data.Repositories.TPFServices.IImportUserRepository, Data.Repositories.TPFServices.ImportUserRepository>();
			services.AddTransient<Data.Repositories.TPFServices.ILogErrorsImportRepository, Data.Repositories.TPFServices.LogErrorsImportRepository>();
			services.AddTransient<Data.Repositories.TPFServices.IRoleRepository, Data.Repositories.TPFServices.RoleRepository>();
			services.AddTransient<Data.Repositories.TPFServices.IScheduleCallOnShopRepository, Data.Repositories.TPFServices.ScheduleCallOnShopRepository>();
			services.AddTransient<Data.Repositories.TPFServices.ISeasonRepository, Data.Repositories.TPFServices.SeasonRepository>();
			services.AddTransient<Data.Repositories.TPFServices.ITestTableRepository, Data.Repositories.TPFServices.TestTableRepository>();
			services.AddTransient<Data.Repositories.TPFServices.IUserRoleRepository, Data.Repositories.TPFServices.UserRoleRepository>();

			services.AddTransient<Data.Repositories.Tpfsystem.ICaLogRepository, Data.Repositories.Tpfsystem.CaLogRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.ICaParticipantOrderDetailRepository, Data.Repositories.Tpfsystem.CaParticipantOrderDetailRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.ICaParticipantOrderDetailBackup20201113Repository, Data.Repositories.Tpfsystem.CaParticipantOrderDetailBackup20201113Repository>();
			services.AddTransient<Data.Repositories.Tpfsystem.ICaParticipantOrderInfoRepository, Data.Repositories.Tpfsystem.CaParticipantOrderInfoRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.ICaParticipantOrderInfoBackup20201113Repository, Data.Repositories.Tpfsystem.CaParticipantOrderInfoBackup20201113Repository>();
			services.AddTransient<Data.Repositories.Tpfsystem.ICaTempReportParticipantRepository, Data.Repositories.Tpfsystem.CaTempReportParticipantRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.ICaTrackingDetailRepository, Data.Repositories.Tpfsystem.CaTrackingDetailRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.ICaTrackingInfoRepository, Data.Repositories.Tpfsystem.CaTrackingInfoRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IClientBillingRepository, Data.Repositories.Tpfsystem.ClientBillingRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IClientDatumRepository, Data.Repositories.Tpfsystem.ClientDatumRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IClientDelDatumRepository, Data.Repositories.Tpfsystem.ClientDelDatumRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IClientWebAccountRepository, Data.Repositories.Tpfsystem.ClientWebAccountRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IClientWebAccountBakUpdateProfileRepository, Data.Repositories.Tpfsystem.ClientWebAccountBakUpdateProfileRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IInvoiceRepository, Data.Repositories.Tpfsystem.InvoiceRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IInvoiceDetailRepository, Data.Repositories.Tpfsystem.InvoiceDetailRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IOcDeliveryDetailRepository, Data.Repositories.Tpfsystem.OcDeliveryDetailRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IOcDeliveryOrderRepository, Data.Repositories.Tpfsystem.OcDeliveryOrderRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IOcdetailRepository, Data.Repositories.Tpfsystem.OcdetailRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IOcDetailsExtraInfoRepository, Data.Repositories.Tpfsystem.OcDetailsExtraInfoRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IOnlineAccountsListRepository, Data.Repositories.Tpfsystem.OnlineAccountsListRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IOrderconfRepository, Data.Repositories.Tpfsystem.OrderconfRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IOrderconfExtrainfoRepository, Data.Repositories.Tpfsystem.OrderconfExtrainfoRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IOrdersLogRepository, Data.Repositories.Tpfsystem.OrdersLogRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IOrderSummaryReportRepository, Data.Repositories.Tpfsystem.OrderSummaryReportRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IParticipantProductRepository, Data.Repositories.Tpfsystem.ParticipantProductRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IPartnerAccountRepository, Data.Repositories.Tpfsystem.PartnerAccountRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IPartnerAddressRepository, Data.Repositories.Tpfsystem.PartnerAddressRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IPartnerTradingNameRepository, Data.Repositories.Tpfsystem.PartnerTradingNameRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IPostAddressRepository, Data.Repositories.Tpfsystem.PostAddressRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IPostAddressBackRepository, Data.Repositories.Tpfsystem.PostAddressBackRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IPostAddressBack20211020Repository, Data.Repositories.Tpfsystem.PostAddressBack20211020Repository>();
			services.AddTransient<Data.Repositories.Tpfsystem.ISyncOrderHistoryRepository, Data.Repositories.Tpfsystem.SyncOrderHistoryRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.ISyncStockHistoryRepository, Data.Repositories.Tpfsystem.SyncStockHistoryRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.ISyncTransactionRepository, Data.Repositories.Tpfsystem.SyncTransactionRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IVCaImportDataReportParticipantCaTempReportRepository, Data.Repositories.Tpfsystem.VCaImportDataReportParticipantCaTempReportRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IVCaReminderEmailRepository, Data.Repositories.Tpfsystem.VCaReminderEmailRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IVCaReportOrderAddressIssueRepository, Data.Repositories.Tpfsystem.VCaReportOrderAddressIssueRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IVCaReportOrderNoBatSizeRepository, Data.Repositories.Tpfsystem.VCaReportOrderNoBatSizeRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IVCaReportOrderSummaryRepository, Data.Repositories.Tpfsystem.VCaReportOrderSummaryRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IVCaReportOrderSummaryDetailRepository, Data.Repositories.Tpfsystem.VCaReportOrderSummaryDetailRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IVCaReportOrderSummaryDetailstestRepository, Data.Repositories.Tpfsystem.VCaReportOrderSummaryDetailstestRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IVCaReportParticipantRepository, Data.Repositories.Tpfsystem.VCaReportParticipantRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IVCaReportParticipantCentreRepository, Data.Repositories.Tpfsystem.VCaReportParticipantCentreRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IVCaReportParticipantItemDetailRepository, Data.Repositories.Tpfsystem.VCaReportParticipantItemDetailRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IVCaReportParticipantItemDetailBakPhase42Repository, Data.Repositories.Tpfsystem.VCaReportParticipantItemDetailBakPhase42Repository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IVCaReportParticipantItemDetailV2Repository, Data.Repositories.Tpfsystem.VCaReportParticipantItemDetailV2Repository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IVCaReportParticipantRawDataBakPhase4Repository, Data.Repositories.Tpfsystem.VCaReportParticipantRawDataBakPhase4Repository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IVCaReportParticipantRawDataV2Repository, Data.Repositories.Tpfsystem.VCaReportParticipantRawDataV2Repository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IVCaReportParticipantRawDatumRepository, Data.Repositories.Tpfsystem.VCaReportParticipantRawDatumRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IVCaReportParticipantSentPlayerRepository, Data.Repositories.Tpfsystem.VCaReportParticipantSentPlayerRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IVCaReportRedemptionCentreRepository, Data.Repositories.Tpfsystem.VCaReportRedemptionCentreRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IVCaReportRedemptionJuniorRepository, Data.Repositories.Tpfsystem.VCaReportRedemptionJuniorRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IVCaReportRedemptionShoolRepository, Data.Repositories.Tpfsystem.VCaReportRedemptionShoolRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IVCaReportRejectionOrderRepository, Data.Repositories.Tpfsystem.VCaReportRejectionOrderRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IVCaReportRejectionPlayerRepository, Data.Repositories.Tpfsystem.VCaReportRejectionPlayerRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IVCaReportRejectionPlayerTestRepository, Data.Repositories.Tpfsystem.VCaReportRejectionPlayerTestRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IVCaReportSaleProductRepository, Data.Repositories.Tpfsystem.VCaReportSaleProductRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IVCaReportValidationPlayerProductRepository, Data.Repositories.Tpfsystem.VCaReportValidationPlayerProductRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IVEcomOrderRepository, Data.Repositories.Tpfsystem.VEcomOrderRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IVmUsersOrderHistoryRepository, Data.Repositories.Tpfsystem.VmUsersOrderHistoryRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IVOrdersSummaryRepository, Data.Repositories.Tpfsystem.VOrdersSummaryRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IVSyncHistoryRepository, Data.Repositories.Tpfsystem.VSyncHistoryRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IVSyncStockHistoryRepository, Data.Repositories.Tpfsystem.VSyncStockHistoryRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IWebaccountGroupRepository, Data.Repositories.Tpfsystem.WebaccountGroupRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IWebaccountRoleRepository, Data.Repositories.Tpfsystem.WebaccountRoleRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IWebGroupRepository, Data.Repositories.Tpfsystem.WebGroupRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IWebGroupCategoryRepository, Data.Repositories.Tpfsystem.WebGroupCategoryRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IWebPermissionRepository, Data.Repositories.Tpfsystem.WebPermissionRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IWebRoleRepository, Data.Repositories.Tpfsystem.WebRoleRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IWho2blameRepository, Data.Repositories.Tpfsystem.Who2blameRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IZRosaCaPlayerRepository, Data.Repositories.Tpfsystem.ZRosaCaPlayerRepository>();
			services.AddTransient<Data.Repositories.Tpfsystem.IZRosaUdtFforderInfoRepository, Data.Repositories.Tpfsystem.ZRosaUdtFforderInfoRepository>();

			
			return services;
		}

	}
}