using Data.Databases.CMS_EMBERPLUS;

namespace Data.Contexts;

public partial class CmsEmberplusContext : DbContext
{
    public CmsEmberplusContext()
    {
    }

    public CmsEmberplusContext(DbContextOptions<CmsEmberplusContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CalcCalculation> CalcCalculations { get; set; }

    public virtual DbSet<CalcCalculationLog> CalcCalculationLogs { get; set; }

    public virtual DbSet<CalcCalculationParticipant> CalcCalculationParticipants { get; set; }

    public virtual DbSet<CalcEntity> CalcEntities { get; set; }

    public virtual DbSet<CalcMessageCode> CalcMessageCodes { get; set; }

    public virtual DbSet<CalcOrganisation> CalcOrganisations { get; set; }

    public virtual DbSet<CalcParticipant> CalcParticipants { get; set; }

    public virtual DbSet<CalcParticipantProgram> CalcParticipantPrograms { get; set; }

    public virtual DbSet<CalcParticipantProgramDetail> CalcParticipantProgramDetails { get; set; }

    public virtual DbSet<CalcParticipantProgramOrderAddOn> CalcParticipantProgramOrderAddOns { get; set; }

    public virtual DbSet<CalcParticipantRejecttion> CalcParticipantRejecttions { get; set; }

    public virtual DbSet<CalcProgram> CalcPrograms { get; set; }

    public virtual DbSet<CalcRegion> CalcRegions { get; set; }

    public virtual DbSet<CalcSeasonCreditHistory> CalcSeasonCreditHistories { get; set; }

    public virtual DbSet<Carousel> Carousels { get; set; }

    public virtual DbSet<CarouselItem> CarouselItems { get; set; }

    public virtual DbSet<CarouselWidget> CarouselWidgets { get; set; }

    public virtual DbSet<CheckoutPayment> CheckoutPayments { get; set; }

    public virtual DbSet<CheckoutShipping> CheckoutShippings { get; set; }

    public virtual DbSet<CheckoutWidget> CheckoutWidgets { get; set; }

    public virtual DbSet<CmsBarcode> CmsBarcodes { get; set; }

    public virtual DbSet<CmsBgimageEditor> CmsBgimageEditors { get; set; }

    public virtual DbSet<CmsConfiguration> CmsConfigurations { get; set; }

    public virtual DbSet<CmsConfigurationColor> CmsConfigurationColors { get; set; }

    public virtual DbSet<CmsConfigurationJob> CmsConfigurationJobs { get; set; }

    public virtual DbSet<CmsConfigurationRule> CmsConfigurationRules { get; set; }

    public virtual DbSet<CmsConfigurationTask> CmsConfigurationTasks { get; set; }

    public virtual DbSet<CmsConfigurationUiScreen> CmsConfigurationUiScreens { get; set; }

    public virtual DbSet<CmsConfigurationUiScreenColor> CmsConfigurationUiScreenColors { get; set; }

    public virtual DbSet<CmsConfigurationUiScreenElement> CmsConfigurationUiScreenElements { get; set; }

    public virtual DbSet<CmsConfigurationUiScreenFont> CmsConfigurationUiScreenFonts { get; set; }

    public virtual DbSet<CmsCounter> CmsCounters { get; set; }

    public virtual DbSet<CmsCountry> CmsCountries { get; set; }

    public virtual DbSet<CmsCurrency> CmsCurrencies { get; set; }

    public virtual DbSet<CmsCustomerService> CmsCustomerServices { get; set; }

    public virtual DbSet<CmsEmail> CmsEmails { get; set; }

    public virtual DbSet<CmsEmailSample> CmsEmailSamples { get; set; }

    public virtual DbSet<CmsEmailTo> CmsEmailTos { get; set; }

    public virtual DbSet<CmsHtmleditor> CmsHtmleditors { get; set; }

    public virtual DbSet<CmsImageDatum> CmsImageData { get; set; }

    public virtual DbSet<CmsImageEditor> CmsImageEditors { get; set; }

    public virtual DbSet<CmsLanguage> CmsLanguages { get; set; }

    public virtual DbSet<CmsLayout> CmsLayouts { get; set; }

    public virtual DbSet<CmsLayoutCssResource> CmsLayoutCssResources { get; set; }

    public virtual DbSet<CmsLayoutHtml> CmsLayoutHtmls { get; set; }

    public virtual DbSet<CmsLayoutJsResource> CmsLayoutJsResources { get; set; }

    public virtual DbSet<CmsLinkeditor> CmsLinkeditors { get; set; }

    public virtual DbSet<CmsMedium> CmsMedia { get; set; }

    public virtual DbSet<CmsPage> CmsPages { get; set; }

    public virtual DbSet<CmsPagePermission> CmsPagePermissions { get; set; }

    public virtual DbSet<CmsReport> CmsReports { get; set; }

    public virtual DbSet<CmsReportAction> CmsReportActions { get; set; }

    public virtual DbSet<CmsTaskLog> CmsTaskLogs { get; set; }

    public virtual DbSet<CmsTaskScheduleLog> CmsTaskScheduleLogs { get; set; }

    public virtual DbSet<CmsTextEditor> CmsTextEditors { get; set; }

    public virtual DbSet<CmsTheme> CmsThemes { get; set; }

    public virtual DbSet<CmsTriggerEmail> CmsTriggerEmails { get; set; }

    public virtual DbSet<CmsTriggerEmailTo> CmsTriggerEmailTos { get; set; }

    public virtual DbSet<CmsWidgetTemplate> CmsWidgetTemplates { get; set; }

    public virtual DbSet<CmsZone> CmsZones { get; set; }

    public virtual DbSet<CmsZoneWidget> CmsZoneWidgets { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<CompanyOption> CompanyOptions { get; set; }

    public virtual DbSet<CompanySmtp> CompanySmtps { get; set; }

    public virtual DbSet<ContentMenu> ContentMenus { get; set; }

    public virtual DbSet<ContentView> ContentViews { get; set; }

    public virtual DbSet<ContentViewField> ContentViewFields { get; set; }

    public virtual DbSet<ContentWidget> ContentWidgets { get; set; }

    public virtual DbSet<CustomerService> CustomerServices { get; set; }

    public virtual DbSet<DataDictionary> DataDictionaries { get; set; }

    public virtual DbSet<DataUniqueCode> DataUniqueCodes { get; set; }

    public virtual DbSet<EmailsWithIssue> EmailsWithIssues { get; set; }

    public virtual DbSet<ExtendField> ExtendFields { get; set; }

    public virtual DbSet<HtmlWidget> HtmlWidgets { get; set; }

    public virtual DbSet<ImageWidget> ImageWidgets { get; set; }

    public virtual DbSet<ImpCondConfigurationList> ImpCondConfigurationLists { get; set; }

    public virtual DbSet<ImpCondConfigurationListHistory> ImpCondConfigurationListHistories { get; set; }

    public virtual DbSet<ImpCondEntitlement> ImpCondEntitlements { get; set; }

    public virtual DbSet<ImpCondEntitlementHistory> ImpCondEntitlementHistories { get; set; }

    public virtual DbSet<ImpLookupTable> ImpLookupTables { get; set; }

    public virtual DbSet<ImpMapping> ImpMappings { get; set; }

    public virtual DbSet<ImpMappingSetting> ImpMappingSettings { get; set; }

    public virtual DbSet<ImpMappingSettingHistory> ImpMappingSettingHistories { get; set; }

    public virtual DbSet<ImpOfferTracking> ImpOfferTrackings { get; set; }

    public virtual DbSet<ImpOfferTrackingDetail> ImpOfferTrackingDetails { get; set; }

    public virtual DbSet<ImpPostFflog> ImpPostFflogs { get; set; }

    public virtual DbSet<ImpProcessUploadFileLog> ImpProcessUploadFileLogs { get; set; }

    public virtual DbSet<ImpRuleSetup> ImpRuleSetups { get; set; }

    public virtual DbSet<ImpRuleSetupHistory> ImpRuleSetupHistories { get; set; }

    public virtual DbSet<ImpSeason> ImpSeasons { get; set; }

    public virtual DbSet<ImpTemplateList> ImpTemplateLists { get; set; }

    public virtual DbSet<ImpTemplateListDetail> ImpTemplateListDetails { get; set; }

    public virtual DbSet<ImpUploadFileLog> ImpUploadFileLogs { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<MetaAddress> MetaAddresses { get; set; }

    public virtual DbSet<MetaExtentField> MetaExtentFields { get; set; }

    public virtual DbSet<MetaExtentFieldValue> MetaExtentFieldValues { get; set; }

    public virtual DbSet<MetaLanguage> MetaLanguages { get; set; }

    public virtual DbSet<MetaResource> MetaResources { get; set; }

    public virtual DbSet<Navigation> Navigations { get; set; }

    public virtual DbSet<NavigationList> NavigationLists { get; set; }

    public virtual DbSet<NavigationWidget> NavigationWidgets { get; set; }

    public virtual DbSet<News> News { get; set; }

    public virtual DbSet<NewsCategory> NewsCategories { get; set; }

	public virtual DbSet<OrderNotification> OrderNotification { get; set; }

	public virtual DbSet<PaymentTransation> PaymentTransations { get; set; }

    public virtual DbSet<Permission> Permissions { get; set; }

    public virtual DbSet<PostAddress> PostAddresses { get; set; }

    public virtual DbSet<PrmoPromotion> PrmoPromotions { get; set; }

    public virtual DbSet<PrmoPromotionCode> PrmoPromotionCodes { get; set; }

    public virtual DbSet<PrmoPromotionCodeAssignUser> PrmoPromotionCodeAssignUsers { get; set; }

    public virtual DbSet<PrmoPromotionCodeUsed> PrmoPromotionCodeUseds { get; set; }

    public virtual DbSet<PrmoPromotionProduct> PrmoPromotionProducts { get; set; }

    public virtual DbSet<PrmoPromotionType> PrmoPromotionTypes { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductAttachment> ProductAttachments { get; set; }

    public virtual DbSet<ProductAttachmentTracking> ProductAttachmentTrackings { get; set; }

    public virtual DbSet<ProductAttributeDescription> ProductAttributeDescriptions { get; set; }

    public virtual DbSet<ProductCategory> ProductCategories { get; set; }

    public virtual DbSet<ProductCombine> ProductCombines { get; set; }

    public virtual DbSet<ProductCombineAttribute> ProductCombineAttributes { get; set; }

    public virtual DbSet<ProductCombineAttributeImage> ProductCombineAttributeImages { get; set; }

    public virtual DbSet<ProductCombineAttributeMap> ProductCombineAttributeMaps { get; set; }

    public virtual DbSet<ProductCombineMap> ProductCombineMaps { get; set; }

    public virtual DbSet<ProductFavorite> ProductFavorites { get; set; }

    public virtual DbSet<ProductFilter> ProductFilters { get; set; }

    public virtual DbSet<ProductFilterDetail> ProductFilterDetails { get; set; }

    public virtual DbSet<ProductFilterMap> ProductFilterMaps { get; set; }

    public virtual DbSet<ProductImage> ProductImages { get; set; }

    public virtual DbSet<ProductLayer> ProductLayers { get; set; }

    public virtual DbSet<ProductLayerBase> ProductLayerBases { get; set; }

    public virtual DbSet<ProductLayerDetail> ProductLayerDetails { get; set; }

    public virtual DbSet<ProductLayerDetailImage> ProductLayerDetailImages { get; set; }

    public virtual DbSet<ProductLetterPersonalize> ProductLetterPersonalizes { get; set; }

    public virtual DbSet<ProductPackedItem> ProductPackedItems { get; set; }

    public virtual DbSet<ProductPersonalize> ProductPersonalizes { get; set; }

    public virtual DbSet<ProductPrice> ProductPrices { get; set; }

    public virtual DbSet<ProductPriceBak> ProductPriceBaks { get; set; }

    public virtual DbSet<ProductQty> ProductQties { get; set; }

    public virtual DbSet<ProductQuotum> ProductQuota { get; set; }

    public virtual DbSet<ProductRedeem> ProductRedeems { get; set; }

    public virtual DbSet<ProductTag> ProductTags { get; set; }

    public virtual DbSet<ProductTagMap> ProductTagMaps { get; set; }

    public virtual DbSet<ProductTrackingClick> ProductTrackingClicks { get; set; }

    public virtual DbSet<ProductWaveHouse> ProductWaveHouses { get; set; }

    public virtual DbSet<ProductWish> ProductWishes { get; set; }

    public virtual DbSet<QrtzBlobTrigger> QrtzBlobTriggers { get; set; }

    public virtual DbSet<QrtzCalendar> QrtzCalendars { get; set; }

    public virtual DbSet<QrtzCronTrigger> QrtzCronTriggers { get; set; }

    public virtual DbSet<QrtzFiredTrigger> QrtzFiredTriggers { get; set; }

    public virtual DbSet<QrtzJobDetail> QrtzJobDetails { get; set; }

    public virtual DbSet<QrtzLock> QrtzLocks { get; set; }

    public virtual DbSet<QrtzPausedTriggerGrp> QrtzPausedTriggerGrps { get; set; }

    public virtual DbSet<QrtzSchedulerState> QrtzSchedulerStates { get; set; }

    public virtual DbSet<QrtzSimpleTrigger> QrtzSimpleTriggers { get; set; }

    public virtual DbSet<QrtzSimpropTrigger> QrtzSimpropTriggers { get; set; }

    public virtual DbSet<QrtzTrigger> QrtzTriggers { get; set; }

    public virtual DbSet<RawData12515202108020149080550> RawData12515202108020149080550s { get; set; }

    public virtual DbSet<RawData12516202108090114155899> RawData12516202108090114155899s { get; set; }

    public virtual DbSet<RawData125162021080901141558991> RawData12516202108090114155899s1 { get; set; }

    public virtual DbSet<RawData12516202108090246598409> RawData12516202108090246598409s { get; set; }

    public virtual DbSet<RawData12516202108090639445685> RawData12516202108090639445685s { get; set; }

    public virtual DbSet<RawData12516202108100211337631> RawData12516202108100211337631s { get; set; }

    public virtual DbSet<RawData13718202110120309486716> RawData13718202110120309486716s { get; set; }

    public virtual DbSet<RawData13718202110200140191035> RawData13718202110200140191035s { get; set; }

    public virtual DbSet<RawData13718202110200755439066> RawData13718202110200755439066s { get; set; }

    public virtual DbSet<RawData13718202202070130021605> RawData13718202202070130021605s { get; set; }

    public virtual DbSet<RawData13718202202070141005665> RawData13718202202070141005665s { get; set; }

    public virtual DbSet<RawData13718202202070141036173> RawData13718202202070141036173s { get; set; }

    public virtual DbSet<RawData13718202202071110561351> RawData13718202202071110561351s { get; set; }

    public virtual DbSet<RawData13718202202071110590255> RawData13718202202071110590255s { get; set; }

    public virtual DbSet<RawData13718202202071113436144> RawData13718202202071113436144s { get; set; }

    public virtual DbSet<RawData13718202202071113514674> RawData13718202202071113514674s { get; set; }

    public virtual DbSet<RawData13718202202071132103561> RawData13718202202071132103561s { get; set; }

    public virtual DbSet<RawData13718202202071132173005> RawData13718202202071132173005s { get; set; }

    public virtual DbSet<RawData13718202202071135532127> RawData13718202202071135532127s { get; set; }

    public virtual DbSet<RawData13718202202071135562057> RawData13718202202071135562057s { get; set; }

    public virtual DbSet<RawData13718202202071143436604> RawData13718202202071143436604s { get; set; }

    public virtual DbSet<RawData13718202202071143464421> RawData13718202202071143464421s { get; set; }

    public virtual DbSet<RawData13765202202150748263099> RawData13765202202150748263099s { get; set; }

    public virtual DbSet<RawData13817202110121049465229> RawData13817202110121049465229s { get; set; }

    public virtual DbSet<RawData14320202110290647018384> RawData14320202110290647018384s { get; set; }

    public virtual DbSet<RawData14320202111080329006768> RawData14320202111080329006768s { get; set; }

    public virtual DbSet<RawData14320202111080329143951> RawData14320202111080329143951s { get; set; }

    public virtual DbSet<RawData14320202111080346540337> RawData14320202111080346540337s { get; set; }

    public virtual DbSet<RawData14523202111120752127950> RawData14523202111120752127950s { get; set; }

    public virtual DbSet<RawData14523202111120815172093> RawData14523202111120815172093s { get; set; }

    public virtual DbSet<RawData14523202111120817168610> RawData14523202111120817168610s { get; set; }

    public virtual DbSet<RawData14523202112070157261399> RawData14523202112070157261399s { get; set; }

    public virtual DbSet<RawData14523202112070551228909> RawData14523202112070551228909s { get; set; }

    public virtual DbSet<RawData14523202112070552391073> RawData14523202112070552391073s { get; set; }

    public virtual DbSet<RawData14523202112070635429635> RawData14523202112070635429635s { get; set; }

    public virtual DbSet<RawData15525202204051249187411> RawData15525202204051249187411s { get; set; }

    public virtual DbSet<RawData15924202204120429023104> RawData15924202204120429023104s { get; set; }

    public virtual DbSet<RawData15924202204141200142466> RawData15924202204141200142466s { get; set; }

    public virtual DbSet<RawData16029202204130600208033> RawData16029202204130600208033s { get; set; }

    public virtual DbSet<RawData16433202205171009063367> RawData16433202205171009063367s { get; set; }

    public virtual DbSet<RawData16433202205171033357803> RawData16433202205171033357803s { get; set; }

    public virtual DbSet<RawData16564202207060950373681> RawData16564202207060950373681s { get; set; }

    public virtual DbSet<RawData16667202207061155484034> RawData16667202207061155484034s { get; set; }

    public virtual DbSet<RawData16738202207070317147324> RawData16738202207070317147324s { get; set; }

    public virtual DbSet<RawData16839202207120931356534> RawData16839202207120931356534s { get; set; }

    public virtual DbSet<RawData17142202207201140586460> RawData17142202207201140586460s { get; set; }

    public virtual DbSet<RawData17344202208030931028833> RawData17344202208030931028833s { get; set; }

    public virtual DbSet<RawData17362202210141023126220> RawData17362202210141023126220s { get; set; }

    public virtual DbSet<RawData17445202208021205202686> RawData17445202208021205202686s { get; set; }

    public virtual DbSet<RawData17445202209160726342555> RawData17445202209160726342555s { get; set; }

    public virtual DbSet<RawData17546202208020400315347> RawData17546202208020400315347s { get; set; }

    public virtual DbSet<RawData17668202209071136098342> RawData17668202209071136098342s { get; set; }

    public virtual DbSet<RawData17763202209230252212550> RawData17763202209230252212550s { get; set; }

    public virtual DbSet<RawData17849202209271142438967> RawData17849202209271142438967s { get; set; }

    public virtual DbSet<RawData17970202210030147599126> RawData17970202210030147599126s { get; set; }

    public virtual DbSet<RawData18051202210070936501890> RawData18051202210070936501890s { get; set; }

    public virtual DbSet<RawData18054202210060315031424> RawData18054202210060315031424s { get; set; }

    public virtual DbSet<RawData18055202210070221244160> RawData18055202210070221244160s { get; set; }

    public virtual DbSet<RawData18056202210071101504644> RawData18056202210071101504644s { get; set; }

    public virtual DbSet<RawData18058202210100330084519> RawData18058202210100330084519s { get; set; }

    public virtual DbSet<RawData18069202210121014405186> RawData18069202210121014405186s { get; set; }

    public virtual DbSet<RawData18152202210040302274183> RawData18152202210040302274183s { get; set; }

    public virtual DbSet<RawData18253202210110313456056> RawData18253202210110313456056s { get; set; }

    public virtual DbSet<RawData18253202210190739546008> RawData18253202210190739546008s { get; set; }

    public virtual DbSet<RawDataTest> RawDataTests { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<ScriptWidget> ScriptWidgets { get; set; }

    public virtual DbSet<Season> Seasons { get; set; }

    public virtual DbSet<ShippingCalculator> ShippingCalculators { get; set; }

    public virtual DbSet<ShippingCalculatorChild> ShippingCalculatorChildren { get; set; }

    public virtual DbSet<ShippingWeightChild> ShippingWeightChildren { get; set; }

    public virtual DbSet<ShoppingWidget> ShoppingWidgets { get; set; }

    public virtual DbSet<StyleSheetWidget> StyleSheetWidgets { get; set; }

    public virtual DbSet<Tax> Taxes { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserAccount> UserAccounts { get; set; }

    public virtual DbSet<UserCreditHistory> UserCreditHistories { get; set; }

    public virtual DbSet<UserEmailReminder> UserEmailReminders { get; set; }

    public virtual DbSet<UserRoleRelation> UserRoleRelations { get; set; }

    public virtual DbSet<UserType> UserTypes { get; set; }

    public virtual DbSet<UserTypeActionPermission> UserTypeActionPermissions { get; set; }

    public virtual DbSet<UserTypePermission> UserTypePermissions { get; set; }

    public virtual DbSet<UserTypeUser> UserTypeUsers { get; set; }

    public virtual DbSet<VCalParticipant> VCalParticipants { get; set; }

    public virtual DbSet<VCalParticipantAuk> VCalParticipantAuks { get; set; }

    public virtual DbSet<VCalParticipantBakBeforeAuk> VCalParticipantBakBeforeAuks { get; set; }

    public virtual DbSet<VParticipant> VParticipants { get; set; }

    public virtual DbSet<VRedemption> VRedemptions { get; set; }

    public virtual DbSet<VReportRedemption> VReportRedemptions { get; set; }

    public virtual DbSet<VReportRedemptionExport> VReportRedemptionExports { get; set; }

    public virtual DbSet<Warehouse> Warehouses { get; set; }

    public virtual DbSet<WebOrder> WebOrders { get; set; }

    public virtual DbSet<WebOrderDeliveryTracking> WebOrderDeliveryTrackings { get; set; }

    public virtual DbSet<WebOrderDeliveryTrackingDetail> WebOrderDeliveryTrackingDetails { get; set; }

    public virtual DbSet<WebOrderDetail> WebOrderDetails { get; set; }

    public virtual DbSet<WebOrderDetailSubItem> WebOrderDetailSubItems { get; set; }

    public virtual DbSet<WhOcDelivery> WhOcDeliveries { get; set; }

    public virtual DbSet<WhOcDeliveryDetail> WhOcDeliveryDetails { get; set; }

    public virtual DbSet<WidgetBiToolReport> WidgetBiToolReports { get; set; }

    public virtual DbSet<WidgetGroupTemplate> WidgetGroupTemplates { get; set; }

    public virtual DbSet<WidgetGroupTemplateItem> WidgetGroupTemplateItems { get; set; }

    public virtual DbSet<WidgetTemplateMode> WidgetTemplateModes { get; set; }

    public virtual DbSet<ZCalcRegion> ZCalcRegions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CalcCalculation>(entity =>
        {
            entity.ToTable("CALC_Calculation");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CalcEntityId).HasColumnName("CALC_EntityID");
            entity.Property(e => e.CreditDiversity).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreditRegistration).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreditTenure).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.RawData).HasColumnType("xml");
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<CalcCalculationLog>(entity =>
        {
            entity.ToTable("CALC_Calculation_Log");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CalcCalculationId).HasColumnName("CALC_CalculationID");
            entity.Property(e => e.CalcEntityId).HasColumnName("CALC_EntityID");
            entity.Property(e => e.CreditDiversity).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreditRegistration).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreditTenure).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.LastUpdateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<CalcCalculationParticipant>(entity =>
        {
            entity.ToTable("CALC_CalculationParticipant");

            entity.HasIndex(e => e.CalcParticipantId, "CALC_ParticipantID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CalcParticipantId).HasColumnName("CALC_ParticipantID");
            entity.Property(e => e.Credit).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.RawData).HasColumnType("xml");
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<CalcEntity>(entity =>
        {
            entity.ToTable("CALC_Entity");

            entity.HasIndex(e => e.EntityId, "EntityID");

            entity.HasIndex(e => e.UserId, "UserID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Approved)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.CompanyId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("CompanyID");
            entity.Property(e => e.DeliveryAddressLine1).HasMaxLength(250);
            entity.Property(e => e.DeliveryAddressLine2).HasMaxLength(250);
            entity.Property(e => e.DeliveryCompanyName).HasMaxLength(250);
            entity.Property(e => e.DeliveryCountry).HasMaxLength(100);
            entity.Property(e => e.DeliveryEmail).HasMaxLength(250);
            entity.Property(e => e.DeliveryFirstName).HasMaxLength(250);
            entity.Property(e => e.DeliveryLastName).HasMaxLength(250);
            entity.Property(e => e.DeliveryPhone).HasMaxLength(15);
            entity.Property(e => e.DeliveryPostcode).HasMaxLength(50);
            entity.Property(e => e.DeliveryState).HasMaxLength(15);
            entity.Property(e => e.DeliverySuburb).HasMaxLength(250);
            entity.Property(e => e.EntityCreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EntityId)
                .HasMaxLength(50)
                .HasColumnName("EntityID");
            entity.Property(e => e.EntityName).HasMaxLength(250);
            entity.Property(e => e.EntityTenure).HasMaxLength(50);
            entity.Property(e => e.EntityType).HasMaxLength(50);
            entity.Property(e => e.FirstActiveSeason).HasMaxLength(50);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.LastUpdateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.OrgId)
                .HasMaxLength(100)
                .HasColumnName("OrgID");
            entity.Property(e => e.RegionId)
                .HasMaxLength(100)
                .HasColumnName("RegionID");
            entity.Property(e => e.RegionName).HasMaxLength(100);
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<CalcMessageCode>(entity =>
        {
            entity.ToTable("CALC_MessageCode");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<CalcOrganisation>(entity =>
        {
            entity.ToTable("CALC_Organisation");

            entity.HasIndex(e => e.OrgId, "NonClusteredIndex-OrgID");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeliveryAddressLine1).HasMaxLength(80);
            entity.Property(e => e.DeliveryAddressLine2).HasMaxLength(80);
            entity.Property(e => e.DeliveryAddressLine3).HasMaxLength(80);
            entity.Property(e => e.DeliveryCompanyName).HasMaxLength(50);
            entity.Property(e => e.DeliveryCountry).HasMaxLength(60);
            entity.Property(e => e.DeliveryEmail).HasMaxLength(50);
            entity.Property(e => e.DeliveryFirstName).HasMaxLength(35);
            entity.Property(e => e.DeliveryLastName).HasMaxLength(35);
            entity.Property(e => e.DeliveryPhone).HasMaxLength(20);
            entity.Property(e => e.DeliveryPostcode).HasMaxLength(20);
            entity.Property(e => e.DeliveryState).HasMaxLength(50);
            entity.Property(e => e.DeliverySuburb).HasMaxLength(85);
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.OrgId)
                .HasMaxLength(50)
                .HasColumnName("OrgID");
            entity.Property(e => e.OrgName).HasMaxLength(100);
            entity.Property(e => e.OrgType).HasMaxLength(100);
            entity.Property(e => e.OtherInfo1)
                .HasMaxLength(500)
                .HasColumnName("other_info1");
            entity.Property(e => e.OtherInfo2)
                .HasMaxLength(500)
                .HasColumnName("other_info2");
            entity.Property(e => e.OtherInfo3)
                .HasMaxLength(500)
                .HasColumnName("other_info3");
            entity.Property(e => e.OtherInfo4)
                .HasMaxLength(500)
                .HasColumnName("other_info4");
            entity.Property(e => e.UserId).HasMaxLength(100);
        });

        modelBuilder.Entity<CalcParticipant>(entity =>
        {
            entity.ToTable("CALC_Participant");

            entity.HasIndex(e => e.UserId, "IDX_Participant_User");

            entity.HasIndex(e => e.ParticipantId, "ParticipantID");

            entity.HasIndex(e => e.UserId, "UserID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AccountId)
                .HasMaxLength(50)
                .HasColumnName("AccountID");
            entity.Property(e => e.AccountType).HasMaxLength(250);
            entity.Property(e => e.Approved)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.BirthDate).HasColumnType("datetime");
            entity.Property(e => e.CaclEntityId).HasColumnName("CACL_EntityID");
            entity.Property(e => e.Category).HasMaxLength(250);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeliveryAddressLine1).HasMaxLength(250);
            entity.Property(e => e.DeliveryAddressLine2).HasMaxLength(250);
            entity.Property(e => e.DeliveryCountry).HasMaxLength(100);
            entity.Property(e => e.DeliveryEmail).HasMaxLength(250);
            entity.Property(e => e.DeliveryFirstName).HasMaxLength(250);
            entity.Property(e => e.DeliveryLastName).HasMaxLength(250);
            entity.Property(e => e.DeliveryPhone).HasMaxLength(100);
            entity.Property(e => e.DeliveryPostcode).HasMaxLength(100);
            entity.Property(e => e.DeliveryState).HasMaxLength(100);
            entity.Property(e => e.DeliverySuburb).HasMaxLength(250);
            entity.Property(e => e.DisplayOrder).HasDefaultValueSql("((0))");
            entity.Property(e => e.ExternalLinkId)
                .HasMaxLength(50)
                .HasColumnName("ExternalLinkID");
            entity.Property(e => e.ExternalLinkType).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(250);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.LastName).HasMaxLength(250);
            entity.Property(e => e.LastUpdateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.MemberId)
                .HasMaxLength(500)
                .HasColumnName("MemberID");
            entity.Property(e => e.MemberSinceConsecutive).HasMaxLength(50);
            entity.Property(e => e.MemberSinceFirst).HasMaxLength(50);
            entity.Property(e => e.MemberType).HasMaxLength(50);
            entity.Property(e => e.MemberYearsConsecutive).HasMaxLength(50);
            entity.Property(e => e.MemberYearsTotal).HasMaxLength(50);
            entity.Property(e => e.MemberYearsUpdated).HasMaxLength(50);
            entity.Property(e => e.Note).HasMaxLength(2000);
            entity.Property(e => e.Notes).HasMaxLength(500);
            entity.Property(e => e.OtherInfo1).HasMaxLength(250);
            entity.Property(e => e.OtherInfo2).HasMaxLength(250);
            entity.Property(e => e.OtherInfo3).HasMaxLength(250);
            entity.Property(e => e.OtherInfo4).HasMaxLength(250);
            entity.Property(e => e.ParentFirstName).HasMaxLength(250);
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.ParentLastName).HasMaxLength(250);
            entity.Property(e => e.ParticipantId)
                .HasMaxLength(200)
                .HasColumnName("ParticipantID");
            entity.Property(e => e.ParticipantType).HasMaxLength(200);
            entity.Property(e => e.UserId)
                .HasMaxLength(100)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<CalcParticipantProgram>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CALC_ParticipantProgram_1");

            entity.ToTable("CALC_ParticipantProgram");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CalcParticipantId).HasColumnName("CALC_ParticipantID");
            entity.Property(e => e.CalcProgramId).HasColumnName("CALC_ProgramID");
            entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            entity.Property(e => e.Tpfcarrier)
                .HasMaxLength(500)
                .HasColumnName("TPFCarrier");
            entity.Property(e => e.TpforderBy)
                .HasMaxLength(500)
                .HasColumnName("TPFOrderBy");
            entity.Property(e => e.TpforderDate)
                .HasColumnType("date")
                .HasColumnName("TPFOrderDate");
            entity.Property(e => e.TpforderId).HasColumnName("TPFOrderID");
            entity.Property(e => e.TpforderStatus)
                .HasMaxLength(50)
                .HasColumnName("TPFOrderStatus");
            entity.Property(e => e.TpforderSyncDate)
                .HasColumnType("datetime")
                .HasColumnName("TPFOrderSyncDate");
            entity.Property(e => e.TpfrejectNotes).HasColumnName("TPFRejectNotes");
            entity.Property(e => e.TpfrejectStatus)
                .HasMaxLength(50)
                .HasColumnName("TPFRejectStatus");
            entity.Property(e => e.TpfrejectUpdatedStatus)
                .HasMaxLength(50)
                .HasColumnName("TPFRejectUpdatedStatus");
            entity.Property(e => e.TpftrackingNumber)
                .HasMaxLength(500)
                .HasColumnName("TPFTrackingNumber");
            entity.Property(e => e.TranId)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("TranID");
        });

        modelBuilder.Entity<CalcParticipantProgramDetail>(entity =>
        {
            entity.ToTable("CALC_ParticipantProgramDetail");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IsRedeem)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.OrderId)
                .HasMaxLength(50)
                .HasColumnName("OrderID");
            entity.Property(e => e.OrderItemLine).HasMaxLength(50);
            entity.Property(e => e.OtherInfo1).HasMaxLength(50);
            entity.Property(e => e.OtherInfo2).HasMaxLength(50);
            entity.Property(e => e.OtherInfo3).HasMaxLength(50);
            entity.Property(e => e.OtherInfo4).HasMaxLength(50);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductId)
                .HasMaxLength(50)
                .HasColumnName("ProductID");
            entity.Property(e => e.ProductName).HasMaxLength(200);
            entity.Property(e => e.TpforderId).HasColumnName("TPFOrderID");
            entity.Property(e => e.TpfproductCode)
                .HasMaxLength(50)
                .HasColumnName("TPFProductCode");
            entity.Property(e => e.TpfproductName)
                .HasMaxLength(200)
                .HasColumnName("TPFProductName");
            entity.Property(e => e.Tpfquantity).HasColumnName("TPFQuantity");
            entity.Property(e => e.TpfwarehouseId).HasColumnName("TPFWarehouseID");
        });

        modelBuilder.Entity<CalcParticipantProgramOrderAddOn>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CALC_ParticipantProgramOrder");

            entity.ToTable("CALC_ParticipantProgramOrderAddOn");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BarcodeAdditional).HasMaxLength(250);
            entity.Property(e => e.BarcodeAdditional2).HasMaxLength(250);
            entity.Property(e => e.BarcodeValue).HasMaxLength(100);
            entity.Property(e => e.CalcParticipantId).HasColumnName("CALC_ParticipantID");
            entity.Property(e => e.CalcProgramId).HasColumnName("CALC_ProgramID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.OrderComplimentary).HasMaxLength(250);
            entity.Property(e => e.OrderDeliveryHistory).HasMaxLength(250);
            entity.Property(e => e.OrderDeliveryNote).HasMaxLength(250);
            entity.Property(e => e.OrderDiscount).HasMaxLength(250);
            entity.Property(e => e.OrderId)
                .HasMaxLength(50)
                .HasColumnName("OrderID");
            entity.Property(e => e.OrderItemId)
                .HasMaxLength(50)
                .HasColumnName("OrderItemID");
            entity.Property(e => e.OrderItemProductCode).HasMaxLength(50);
            entity.Property(e => e.OrderItemProductId)
                .HasMaxLength(50)
                .HasColumnName("OrderItemProductID");
            entity.Property(e => e.OrderItemProductInfo1).HasMaxLength(500);
            entity.Property(e => e.OrderItemProductInfo10).HasMaxLength(500);
            entity.Property(e => e.OrderItemProductInfo2).HasMaxLength(500);
            entity.Property(e => e.OrderItemProductInfo3).HasMaxLength(500);
            entity.Property(e => e.OrderItemProductInfo4).HasMaxLength(500);
            entity.Property(e => e.OrderItemProductInfo5).HasMaxLength(500);
            entity.Property(e => e.OrderItemProductInfo6).HasMaxLength(500);
            entity.Property(e => e.OrderItemProductInfo7).HasMaxLength(500);
            entity.Property(e => e.OrderItemProductInfo8).HasMaxLength(500);
            entity.Property(e => e.OrderItemProductInfo9).HasMaxLength(500);
            entity.Property(e => e.OrderItemProductName).HasMaxLength(500);
            entity.Property(e => e.OrderOnplan).HasMaxLength(250);
            entity.Property(e => e.OrderPlanType).HasMaxLength(50);
            entity.Property(e => e.PrintDate).HasColumnType("datetime");
            entity.Property(e => e.ProductCategory).HasMaxLength(250);
            entity.Property(e => e.ProductChoice1).HasMaxLength(250);
            entity.Property(e => e.ProductChoice2).HasMaxLength(250);
            entity.Property(e => e.ProductName).HasMaxLength(500);
            entity.Property(e => e.ProductPackage).HasMaxLength(250);
            entity.Property(e => e.ProductPriceType).HasMaxLength(250);
            entity.Property(e => e.ProductPrintValue).HasMaxLength(250);
            entity.Property(e => e.ProductSpecialText).HasMaxLength(250);
            entity.Property(e => e.ProductTicketType).HasMaxLength(50);
            entity.Property(e => e.TranId).HasColumnName("TranID");
            entity.Property(e => e.Venue1Aisle).HasMaxLength(50);
            entity.Property(e => e.Venue1FullDetail).HasMaxLength(250);
            entity.Property(e => e.Venue1Gate).HasMaxLength(100);
            entity.Property(e => e.Venue1Name).HasMaxLength(250);
            entity.Property(e => e.Venue1Row).HasMaxLength(100);
            entity.Property(e => e.Venue1Seat).HasMaxLength(100);
            entity.Property(e => e.Venue1Section).HasMaxLength(50);
            entity.Property(e => e.Venue1Stand).HasMaxLength(100);
            entity.Property(e => e.Venue2Aisle).HasMaxLength(50);
            entity.Property(e => e.Venue2FullDetail).HasMaxLength(250);
            entity.Property(e => e.Venue2Gate).HasMaxLength(100);
            entity.Property(e => e.Venue2Name).HasMaxLength(250);
            entity.Property(e => e.Venue2Row).HasMaxLength(100);
            entity.Property(e => e.Venue2Seat).HasMaxLength(100);
            entity.Property(e => e.Venue2Section).HasMaxLength(50);
            entity.Property(e => e.Venue2Stand).HasMaxLength(100);
            entity.Property(e => e.Venue3Aisle).HasMaxLength(50);
            entity.Property(e => e.Venue3FullDetail).HasMaxLength(250);
            entity.Property(e => e.Venue3Gate).HasMaxLength(100);
            entity.Property(e => e.Venue3Name).HasMaxLength(250);
            entity.Property(e => e.Venue3Row).HasMaxLength(100);
            entity.Property(e => e.Venue3Seat).HasMaxLength(100);
            entity.Property(e => e.Venue3Section).HasMaxLength(50);
            entity.Property(e => e.Venue3Stand).HasMaxLength(100);
            entity.Property(e => e.Venue4Aisle).HasMaxLength(50);
            entity.Property(e => e.Venue4FullDetail).HasMaxLength(250);
            entity.Property(e => e.Venue4Gate).HasMaxLength(100);
            entity.Property(e => e.Venue4Name).HasMaxLength(250);
            entity.Property(e => e.Venue4Row).HasMaxLength(100);
            entity.Property(e => e.Venue4Seat).HasMaxLength(100);
            entity.Property(e => e.Venue4Section).HasMaxLength(50);
            entity.Property(e => e.Venue4Stand).HasMaxLength(100);
        });

        modelBuilder.Entity<CalcParticipantRejecttion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_RejecttionParticipant");

            entity.ToTable("CALC_ParticipantRejecttion");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.EntityId)
                .HasMaxLength(255)
                .HasColumnName("EntityID");
            entity.Property(e => e.EntityName).HasMaxLength(255);
            entity.Property(e => e.ErrorCode).HasMaxLength(500);
            entity.Property(e => e.FirstName).HasMaxLength(250);
            entity.Property(e => e.LastName).HasMaxLength(250);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.OrgId)
                .HasMaxLength(255)
                .HasColumnName("OrgID");
            entity.Property(e => e.OrgName).HasMaxLength(255);
            entity.Property(e => e.ParticipantId)
                .HasMaxLength(500)
                .HasColumnName("ParticipantID");
            entity.Property(e => e.ParticipantType).HasMaxLength(50);
            entity.Property(e => e.ProgramId)
                .HasMaxLength(255)
                .HasColumnName("ProgramID");
            entity.Property(e => e.ProgramName).HasMaxLength(255);
            entity.Property(e => e.ProgramType).HasMaxLength(255);
            entity.Property(e => e.RawData).HasColumnType("xml");
            entity.Property(e => e.RawId).HasColumnName("RawID");
            entity.Property(e => e.TemplateId).HasColumnName("TemplateID");
            entity.Property(e => e.Title).HasMaxLength(500);
            entity.Property(e => e.UploadId).HasColumnName("UploadID");
        });

        modelBuilder.Entity<CalcProgram>(entity =>
        {
            entity.ToTable("CALC_Program");

            entity.HasIndex(e => e.ProgramId, "ProgramID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Approved).HasDefaultValueSql("((1))");
            entity.Property(e => e.CaclEntityId).HasColumnName("CACL_EntityID");
            entity.Property(e => e.CoordinatorFirstName).HasMaxLength(250);
            entity.Property(e => e.CoordinatorLastName).HasMaxLength(250);
            entity.Property(e => e.FinishDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.LastUpdateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ProgramId)
                .HasMaxLength(500)
                .HasColumnName("ProgramID");
            entity.Property(e => e.ProgramName).HasMaxLength(250);
            entity.Property(e => e.ProgramTerm).HasMaxLength(250);
            entity.Property(e => e.ProgramType).HasMaxLength(250);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CalcRegion>(entity =>
        {
            entity.ToTable("CALC_Region");

            entity.HasIndex(e => e.RegionId, "RegionID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedBy).HasMaxLength(500);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LastUpdatedBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.OrgId)
                .HasMaxLength(100)
                .HasColumnName("OrgID");
            entity.Property(e => e.RegionId)
                .HasMaxLength(200)
                .HasColumnName("RegionID");
            entity.Property(e => e.RegionName).HasMaxLength(500);
            entity.Property(e => e.Title).HasMaxLength(200);
        });

        modelBuilder.Entity<CalcSeasonCreditHistory>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.SeasonId, e.CompanyId });

            entity.ToTable("CALC_SeasonCreditHistory");

            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");
            entity.Property(e => e.SeasonId).HasColumnName("SeasonID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.Credit).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Carousel>(entity =>
        {
            entity.ToTable("Carousel");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Animation).HasMaxLength(50);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Easing).HasMaxLength(50);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<CarouselItem>(entity =>
        {
            entity.ToTable("CarouselItem");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CarouselId).HasColumnName("CarouselID");
            entity.Property(e => e.CarouselWidgetId)
                .HasMaxLength(100)
                .HasColumnName("CarouselWidgetID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.ImageUrl).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.TargetLink).HasMaxLength(255);
            entity.Property(e => e.Title).HasMaxLength(255);

            entity.HasOne(d => d.Carousel).WithMany(p => p.CarouselItems)
                .HasForeignKey(d => d.CarouselId)
                .HasConstraintName("FK_CarouselItem_Carousel");

            entity.HasOne(d => d.CarouselWidget).WithMany(p => p.CarouselItems)
                .HasForeignKey(d => d.CarouselWidgetId)
                .HasConstraintName("FK_CarouselItem_CarouselWidget");
        });

        modelBuilder.Entity<CarouselWidget>(entity =>
        {
            entity.ToTable("CarouselWidget");

            entity.Property(e => e.Id)
                .HasMaxLength(100)
                .HasColumnName("ID");
            entity.Property(e => e.CarouselId).HasColumnName("CarouselID");

            entity.HasOne(d => d.Carousel).WithMany(p => p.CarouselWidgets)
                .HasForeignKey(d => d.CarouselId)
                .HasConstraintName("FK_CarouselWidget_Carousel");
        });

        modelBuilder.Entity<CheckoutPayment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Checkout__3214EC27AF3FDD89");

            entity.ToTable("CheckoutPayment");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(255);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(255);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(255);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentType).HasMaxLength(255);
            entity.Property(e => e.WidgetId)
                .HasMaxLength(255)
                .HasColumnName("WidgetID");
        });

        modelBuilder.Entity<CheckoutShipping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CheckoutShippingWidget");

            entity.ToTable("CheckoutShipping");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ShippingCalculator).HasMaxLength(200);
            entity.Property(e => e.ShippingType).HasDefaultValueSql("((1))");
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.WidgetId)
                .HasMaxLength(100)
                .HasColumnName("WidgetID");
        });

        modelBuilder.Entity<CheckoutWidget>(entity =>
        {
            entity.ToTable("CheckoutWidget");

            entity.Property(e => e.Id)
                .HasMaxLength(100)
                .HasColumnName("ID");
            entity.Property(e => e.CancelUrl).HasMaxLength(255);
            entity.Property(e => e.EmailUrl).HasMaxLength(255);
            entity.Property(e => e.ErrorUrl).HasMaxLength(255);
            entity.Property(e => e.IsCod).HasColumnName("IsCOD");
            entity.Property(e => e.SucessUrl).HasMaxLength(255);
        });

        modelBuilder.Entity<CmsBarcode>(entity =>
        {
            entity.ToTable("CMS_Barcode");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BarcodeThreeD).HasMaxLength(250);
            entity.Property(e => e.BarcodeTwoD).HasMaxLength(10);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.OwnerId)
                .HasMaxLength(250)
                .HasColumnName("OwnerID");
            entity.Property(e => e.OwnerModule).HasMaxLength(250);
            entity.Property(e => e.Title).HasMaxLength(80);
        });

        modelBuilder.Entity<CmsBgimageEditor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CMS_BGIm__3214EC279A2E4AA0");

            entity.ToTable("CMS_BGImageEditor");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .HasColumnName("ID");
            entity.Property(e => e.Color).HasMaxLength(255);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(255);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.ImagePosition).HasMaxLength(255);
            entity.Property(e => e.ImageSize).HasMaxLength(255);
            entity.Property(e => e.ImageUrl).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(255);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(255);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<CmsConfiguration>(entity =>
        {
            entity.ToTable("CMS_Configuration");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.GoogleIdviewReport).HasColumnName("GoogleIDViewReport");
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.LogSeqApiKey).HasMaxLength(250);
            entity.Property(e => e.OrderPrefix).HasMaxLength(50);
            entity.Property(e => e.OrderSyncCronExpression).HasMaxLength(50);
            entity.Property(e => e.OrderSyncCronJob).HasMaxLength(250);
            entity.Property(e => e.OrderSyncType).HasDefaultValueSql("((1))");
            entity.Property(e => e.SeasonChange).HasDefaultValueSql("((1))");
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.UsedCreditFreight).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<CmsConfigurationColor>(entity =>
        {
            entity.ToTable("CMS_Configuration_Colors");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.ConfigId).HasColumnName("ConfigID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<CmsConfigurationJob>(entity =>
        {
            entity.ToTable("CMS_Configuration_Job");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.ConfigId).HasColumnName("ConfigID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Group).HasMaxLength(255);
            entity.Property(e => e.JobCronExpression).HasMaxLength(255);
            entity.Property(e => e.JobPasword).HasMaxLength(255);
            entity.Property(e => e.JobRun).HasMaxLength(255);
            entity.Property(e => e.JobUrl).HasMaxLength(500);
            entity.Property(e => e.JobUserName).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<CmsConfigurationRule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CMS_Configuration_Trigger");

            entity.ToTable("CMS_Configuration_Rule");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Action).HasMaxLength(255);
            entity.Property(e => e.AssemblyName).HasMaxLength(255);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.ConfigId).HasColumnName("ConfigID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.RuleAction).HasMaxLength(255);
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<CmsConfigurationTask>(entity =>
        {
            entity.ToTable("CMS_Configuration_Task");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.ConfigId).HasColumnName("ConfigID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.TaskKey).HasMaxLength(255);
            entity.Property(e => e.TaskKeyProvider).HasMaxLength(255);
            entity.Property(e => e.TaskProvider).HasMaxLength(255);
            entity.Property(e => e.TaskUrl).HasMaxLength(255);
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<CmsConfigurationUiScreen>(entity =>
        {
            entity.ToTable("CMS_Configuration_UI_Screen");

            entity.Property(e => e.Id)
                .HasMaxLength(200)
                .HasColumnName("ID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.Type).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<CmsConfigurationUiScreenColor>(entity =>
        {
            entity.ToTable("CMS_Configuration_UI_Screen_Color");

            entity.Property(e => e.Id).HasMaxLength(200);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.ConfigId)
                .HasMaxLength(200)
                .HasColumnName("ConfigID");
            entity.Property(e => e.CreateByName).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Createby).HasMaxLength(500);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<CmsConfigurationUiScreenElement>(entity =>
        {
            //entity.HasOne(e => e.CmsConfigurationUiScreenColorBackgroundColor).HasForeignKey(f => f.Background);

            //entity.HasOne(e => e.CmsConfigurationUiScreenColorBackgroundHover).HasForeignKey(f => f.BackgroundHover);

            //entity.HasOne(e => e.CmsConfigurationUiScreenColor).HasForeignKey(f => f.Color);
            

            entity.ToTable("CMS_Configuration_UI_Screen_Element");

            entity.Property(e => e.Id).HasMaxLength(200);
            entity.Property(e => e.Background).HasMaxLength(500);
            entity.Property(e => e.BackgroundHover).HasMaxLength(500);
            entity.Property(e => e.Color).HasMaxLength(500);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.ConfigId)
                .HasMaxLength(200)
                .HasColumnName("ConfigID");
            entity.Property(e => e.CreateByName).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Createby).HasMaxLength(500);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(255);
            
        });

        modelBuilder.Entity<CmsConfigurationUiScreenFont>(entity =>
        {
            entity.ToTable("CMS_Configuration_UI_Screen_Font");

            entity.Property(e => e.Id).HasMaxLength(200);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.ConfigId)
                .HasMaxLength(200)
                .HasColumnName("ConfigID");
            entity.Property(e => e.CreateByName).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Createby).HasMaxLength(500);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.Type).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<CmsCounter>(entity =>
        {
            entity.ToTable("CMS_Counter");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Format).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.NumberFormat).HasMaxLength(255);
            entity.Property(e => e.OwnerModule).HasMaxLength(255);
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<CmsCountry>(entity =>
        {
            entity.ToTable("CMS_Country");

            entity.Property(e => e.Id)
                .HasMaxLength(100)
                .HasColumnName("ID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<CmsCurrency>(entity =>
        {
            entity.ToTable("CMS_Currency");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(500);
            entity.Property(e => e.CurrencyValue).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Key).HasMaxLength(50);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Symbol).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(500);
        });

        modelBuilder.Entity<CmsCustomerService>(entity =>
        {
            entity.ToTable("CMS_CustomerService");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(255);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(255);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(255);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CmsEmail>(entity =>
        {
            entity.ToTable("CMS_Email");

            entity.Property(e => e.Id)
                .HasMaxLength(100)
                .HasColumnName("ID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.Key).HasMaxLength(50);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<CmsEmailSample>(entity =>
        {
            entity.ToTable("CMS_EmailSample");

            entity.Property(e => e.Id)
                .HasMaxLength(100)
                .HasColumnName("ID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.Key).HasMaxLength(50);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<CmsEmailTo>(entity =>
        {
            entity.ToTable("CMS_EmailTo");

            entity.Property(e => e.Id)
                .HasMaxLength(100)
                .HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.OwnerId)
                .HasMaxLength(255)
                .HasColumnName("OwnerID");
            entity.Property(e => e.OwnerModule).HasMaxLength(255);
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<CmsHtmleditor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CMS_HTML__3214EC270B1DECE6");

            entity.ToTable("CMS_HTMLEditor");

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .HasColumnName("ID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(255);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(255);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(255);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CmsImageDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CMS_Imag__3214EC27C92B65FB");

            entity.ToTable("CMS_ImageData");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(255);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.ImageThumbUrl).HasMaxLength(255);
            entity.Property(e => e.ImageUrl).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(255);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(255);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.RefId).HasColumnName("RefID");
            entity.Property(e => e.RefModule).HasMaxLength(255);
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<CmsImageEditor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CMS_Imag__3214EC274BCC1D13");

            entity.ToTable("CMS_ImageEditor");

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .HasColumnName("ID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(255);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(255);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(255);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.Type).HasMaxLength(250);
        });

        modelBuilder.Entity<CmsLanguage>(entity =>
        {
            entity.ToTable("CMS_Language");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.IsDefault).HasDefaultValueSql("((1))");
            entity.Property(e => e.Key)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<CmsLayout>(entity =>
        {
            entity.ToTable("CMS_Layout");

            entity.Property(e => e.Id)
                .HasMaxLength(100)
                .HasColumnName("ID");
            entity.Property(e => e.CompanyId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.ImageThumbUrl).HasMaxLength(255);
            entity.Property(e => e.ImageUrl).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.LayoutName).HasMaxLength(255);
            entity.Property(e => e.Script).HasMaxLength(255);
            entity.Property(e => e.Style).HasMaxLength(255);
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<CmsLayoutCssResource>(entity =>
        {
            entity.ToTable("CMS_LayoutCssResource");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.LayoutId)
                .HasMaxLength(50)
                .HasColumnName("LayoutID");
            entity.Property(e => e.Resource).HasMaxLength(225);
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<CmsLayoutHtml>(entity =>
        {
            entity.HasKey(e => e.LayoutHtmlId);

            entity.ToTable("CMS_LayoutHtml");

            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.LayoutId).HasMaxLength(100);
        });

        modelBuilder.Entity<CmsLayoutJsResource>(entity =>
        {
            entity.ToTable("CMS_LayoutJsResource");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.LayoutId)
                .HasMaxLength(50)
                .HasColumnName("LayoutID");
            entity.Property(e => e.Position).HasMaxLength(50);
            entity.Property(e => e.Resource).HasMaxLength(225);
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<CmsLinkeditor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CMS_LINKEditor");

            entity.ToTable("CMS_LINKEditor");

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .HasColumnName("ID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(255);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(255);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(255);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(550);
            entity.Property(e => e.Target).HasMaxLength(150);
        });

        modelBuilder.Entity<CmsMedium>(entity =>
        {
            entity.ToTable("CMS_Media");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .HasColumnName("ID");
            entity.Property(e => e.CompanyId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.ParentId)
                .HasMaxLength(50)
                .HasColumnName("ParentID");
        });

        modelBuilder.Entity<CmsPage>(entity =>
        {
            entity.ToTable("CMS_Page");

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .HasColumnName("ID");
            entity.Property(e => e.CompanyId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.LayoutId).HasMaxLength(100);
            entity.Property(e => e.MetaDescription).HasMaxLength(255);
            entity.Property(e => e.MetaKeyWords).HasMaxLength(255);
            entity.Property(e => e.PageName).HasMaxLength(255);
            entity.Property(e => e.ParentId).HasMaxLength(255);
            entity.Property(e => e.ReferencePageId)
                .HasMaxLength(255)
                .HasColumnName("ReferencePageID");
            entity.Property(e => e.Script).HasMaxLength(255);
            entity.Property(e => e.Style).HasMaxLength(255);
            entity.Property(e => e.Theme)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.Url).HasMaxLength(255);
        });

        modelBuilder.Entity<CmsPagePermission>(entity =>
        {
            entity.ToTable("CMS_PagePermission");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.PageId)
                .HasMaxLength(255)
                .HasColumnName("PageID");
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<CmsReport>(entity =>
        {
            entity.ToTable("CMS_Report");

            entity.Property(e => e.Id)
                .HasMaxLength(100)
                .HasColumnName("ID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.ContentViewId).HasMaxLength(255);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.OrderBy).HasMaxLength(255);
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<CmsReportAction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ReportAction");

            entity.ToTable("CMS_ReportAction");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActionName).HasMaxLength(100);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.ContentViewId).HasMaxLength(255);
            entity.Property(e => e.CreateBy).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(500);
            entity.Property(e => e.Icon).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.OwnerId)
                .HasMaxLength(255)
                .HasColumnName("OwnerID");
            entity.Property(e => e.Title).HasMaxLength(500);
        });

        modelBuilder.Entity<CmsTaskLog>(entity =>
        {
            entity.ToTable("CMS_TaskLog");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Key).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<CmsTaskScheduleLog>(entity =>
        {
            entity.ToTable("CMS_TaskScheduleLog");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Key).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<CmsTextEditor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CMS_Text__3214EC27035A4341");

            entity.ToTable("CMS_TextEditor");

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .HasColumnName("ID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(255);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(255);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(255);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CmsTheme>(entity =>
        {
            entity.ToTable("CMS_Theme");

            entity.Property(e => e.Id)
                .HasMaxLength(100)
                .HasColumnName("ID");
            entity.Property(e => e.CompanyId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Path).HasMaxLength(500);
            entity.Property(e => e.ThemeName).HasMaxLength(255);
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<CmsTriggerEmail>(entity =>
        {
            entity.ToTable("CMS_TriggerEmail");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Key).HasMaxLength(50);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CmsTriggerEmailTo>(entity =>
        {
            entity.ToTable("CMS_TriggerEmailTo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.OwnerId)
                .HasMaxLength(255)
                .HasColumnName("OwnerID");
            entity.Property(e => e.OwnerModule).HasMaxLength(255);
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<CmsWidgetTemplate>(entity =>
        {
            entity.ToTable("CMS_WidgetTemplate");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AssemblyName).HasMaxLength(255);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.FormView).HasMaxLength(255);
            entity.Property(e => e.GroupName).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.PartialView).HasMaxLength(255);
            entity.Property(e => e.ServiceTypeName).HasMaxLength(255);
            entity.Property(e => e.StyleClass).HasMaxLength(255);
            entity.Property(e => e.Thumbnail).HasMaxLength(100);
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.ViewModelTypeName).HasMaxLength(255);
        });

        modelBuilder.Entity<CmsZone>(entity =>
        {
            entity.ToTable("CMS_Zone");

            entity.Property(e => e.Id)
                .HasMaxLength(100)
                .HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.LayoutId).HasMaxLength(100);
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.ZoneName).HasMaxLength(255);
        });

        modelBuilder.Entity<CmsZoneWidget>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CMS_WidgetBase");

            entity.ToTable("CMS_ZoneWidget");

            entity.Property(e => e.Id)
                .HasMaxLength(100)
                .HasColumnName("ID");
            entity.Property(e => e.AssemblyName).HasMaxLength(255);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.FormView).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.LayoutId).HasMaxLength(100);
            entity.Property(e => e.PageId).HasMaxLength(100);
            entity.Property(e => e.PartialView).HasMaxLength(255);
            entity.Property(e => e.ReferenceId).HasMaxLength(100);
            entity.Property(e => e.ServiceTypeName).HasMaxLength(255);
            entity.Property(e => e.StyleClass).HasMaxLength(1000);
            entity.Property(e => e.Thumbnail).HasMaxLength(200);
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.ViewModelTypeName).HasMaxLength(255);
            entity.Property(e => e.WidgetName).HasMaxLength(255);
            entity.Property(e => e.ZoneId).HasMaxLength(100);
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.ToTable("Company");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CatalogueId).HasColumnName("CatalogueID");
            entity.Property(e => e.ClientId).HasColumnName("ClientID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Currency).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(250);
            entity.Property(e => e.EmailSender).HasMaxLength(250);
            entity.Property(e => e.Host).HasMaxLength(255);
            entity.Property(e => e.ImageUrl).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.LockForCalculating).HasDefaultValueSql("((0))");
            entity.Property(e => e.Port)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.TaxRate).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<CompanyOption>(entity =>
        {
            entity.ToTable("CompanyOption");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompanyReferId).HasColumnName("CompanyReferID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<CompanySmtp>(entity =>
        {
            entity.ToTable("CompanySmtp");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompanyReferId).HasColumnName("CompanyReferID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Password).HasMaxLength(500);
            entity.Property(e => e.Smtp).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.UserName).HasMaxLength(500);
        });

        modelBuilder.Entity<ContentMenu>(entity =>
        {
            entity.ToTable("ContentMenu");

            entity.Property(e => e.Id)
                .HasMaxLength(100)
                .HasColumnName("ID");
            entity.Property(e => e.AssemblyName).HasMaxLength(255);
            entity.Property(e => e.CompanyId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.DesignType).HasDefaultValueSql("((1))");
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.OrderBy).HasMaxLength(255);
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<ContentView>(entity =>
        {
            entity.ToTable("ContentView");

            entity.Property(e => e.Id)
                .HasMaxLength(100)
                .HasColumnName("ID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Target).HasMaxLength(50);
            entity.Property(e => e.TargetType).HasDefaultValueSql("((1))");
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<ContentViewField>(entity =>
        {
            entity.ToTable("ContentViewField");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ContentViewId).HasColumnName("ContentViewID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.DataName).HasMaxLength(255);
            entity.Property(e => e.DataType).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<ContentWidget>(entity =>
        {
            entity.ToTable("ContentWidget");

            entity.Property(e => e.Id)
                .HasMaxLength(100)
                .HasColumnName("ID");
            entity.Property(e => e.AssemblyName).HasMaxLength(255);
        });

        modelBuilder.Entity<CustomerService>(entity =>
        {
            entity.ToTable("CustomerService");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(500);
            entity.Property(e => e.FirstName).HasMaxLength(500);
            entity.Property(e => e.LastName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.OrderNumber).HasMaxLength(500);
            entity.Property(e => e.Title).HasMaxLength(500);
        });

        modelBuilder.Entity<DataDictionary>(entity =>
        {
            entity.ToTable("DataDictionary");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.DicName).HasMaxLength(255);
            entity.Property(e => e.DicValue).HasMaxLength(255);
            entity.Property(e => e.ImageThumbUrl).HasMaxLength(255);
            entity.Property(e => e.ImageUrl).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<DataUniqueCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DataUniqueCode");

            entity.Property(e => e.Code).HasMaxLength(255);
        });

        modelBuilder.Entity<EmailsWithIssue>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("emails-with-issues");

            entity.Property(e => e.EmailAddr)
                .HasMaxLength(50)
                .HasColumnName("email_addr");
            entity.Property(e => e.NameFirst)
                .HasMaxLength(50)
                .HasColumnName("name_first");
            entity.Property(e => e.NameLast)
                .HasMaxLength(50)
                .HasColumnName("name_last");
        });

        modelBuilder.Entity<ExtendField>(entity =>
        {
            entity.ToTable("ExtendField");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.OwnerId)
                .HasMaxLength(255)
                .HasColumnName("OwnerID");
            entity.Property(e => e.OwnerModule).HasMaxLength(255);
        });

        modelBuilder.Entity<HtmlWidget>(entity =>
        {
            entity.ToTable("HtmlWidget");

            entity.Property(e => e.Id)
                .HasMaxLength(100)
                .HasColumnName("ID");
            entity.Property(e => e.Html).HasColumnName("HTML");
        });

        modelBuilder.Entity<ImageWidget>(entity =>
        {
            entity.ToTable("ImageWidget");

            entity.Property(e => e.Id)
                .HasMaxLength(100)
                .HasColumnName("ID");
            entity.Property(e => e.AltText).HasMaxLength(255);
            entity.Property(e => e.ImageUrl).HasMaxLength(255);
            entity.Property(e => e.Link).HasMaxLength(255);
        });

        modelBuilder.Entity<ImpCondConfigurationList>(entity =>
        {
            entity.ToTable("IMP_CondConfigurationList");

            entity.Property(e => e.CreateByName).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Createby).HasMaxLength(500);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(80);
            entity.Property(e => e.Valuescheme)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<ImpCondConfigurationListHistory>(entity =>
        {
            entity.ToTable("IMP_CondConfigurationListHistory");

            entity.Property(e => e.CreateByName).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Createby).HasMaxLength(500);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(80);
            entity.Property(e => e.Valuescheme)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<ImpCondEntitlement>(entity =>
        {
            entity.ToTable("IMP_CondEntitlement");

            entity.Property(e => e.Condition).HasMaxLength(500);
            entity.Property(e => e.CreateAcount)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Credit).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Description).HasMaxLength(30);
            entity.Property(e => e.ErrorCode)
                .HasMaxLength(50)
                .HasColumnName("Error_code");
            entity.Property(e => e.ErrorMessage)
                .HasMaxLength(500)
                .HasColumnName("Error_message");
            entity.Property(e => e.Json).HasColumnName("json");
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Products).HasMaxLength(500);
            entity.Property(e => e.SendDirect).HasMaxLength(500);
            entity.Property(e => e.SendEcard)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.SqlSentence).HasColumnName("SQL_Sentence");
        });

        modelBuilder.Entity<ImpCondEntitlementHistory>(entity =>
        {
            entity.ToTable("IMP_CondEntitlementHistory");

            entity.Property(e => e.Condition).HasMaxLength(500);
            entity.Property(e => e.CreateAcount)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Credit).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Description).HasMaxLength(30);
            entity.Property(e => e.ErrorCode)
                .HasMaxLength(50)
                .HasColumnName("Error_code");
            entity.Property(e => e.ErrorMessage)
                .HasMaxLength(500)
                .HasColumnName("Error_message");
            entity.Property(e => e.Json).HasColumnName("json");
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Products).HasMaxLength(500);
            entity.Property(e => e.SendDirect).HasMaxLength(500);
            entity.Property(e => e.SendEcard)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.SqlSentence).HasColumnName("SQL_Sentence");
        });

        modelBuilder.Entity<ImpLookupTable>(entity =>
        {
            entity.ToTable("IMP_LookupTable");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CardDirects).HasMaxLength(500);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedBy).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Credit).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Ecard)
                .HasMaxLength(500)
                .HasColumnName("ECard");
            entity.Property(e => e.Ecertificate)
                .HasMaxLength(500)
                .HasColumnName("ECertificate");
            entity.Property(e => e.ItemSets).HasMaxLength(500);
            entity.Property(e => e.ModifiedBy).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.ProgramId)
                .HasMaxLength(500)
                .HasColumnName("ProgramID");
            entity.Property(e => e.RedeemOnlyItems).HasMaxLength(500);
            entity.Property(e => e.RedeemOptOutItems).HasMaxLength(500);
            entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            entity.Property(e => e.Type).HasMaxLength(200);
        });

        modelBuilder.Entity<ImpMapping>(entity =>
        {
            entity.ToTable("IMP_Mapping");

            entity.Property(e => e.CreateByName).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Createby).HasMaxLength(500);
            entity.Property(e => e.IdTemplateList).HasColumnName("Id_TemplateList");
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.StoredMapping).HasMaxLength(500);
            entity.Property(e => e.Title).HasMaxLength(80);

            entity.HasOne(d => d.IdTemplateListNavigation).WithMany(p => p.ImpMappings)
                .HasForeignKey(d => d.IdTemplateList)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IMP_IMP_Mapping");
        });

        modelBuilder.Entity<ImpMappingSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_MappingSetting");

            entity.ToTable("IMP_MappingSetting");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(500);
            entity.Property(e => e.DataType).HasMaxLength(20);
            entity.Property(e => e.DbcolumnName)
                .HasMaxLength(50)
                .HasColumnName("DBColumnName");
            entity.Property(e => e.ExcelColumnName).HasMaxLength(200);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Len).HasMaxLength(50);
            entity.Property(e => e.Prefix)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.TableGroup).HasMaxLength(80);
            entity.Property(e => e.TemplateId).HasColumnName("TemplateID");
            entity.Property(e => e.Title).HasMaxLength(80);
        });

        modelBuilder.Entity<ImpMappingSettingHistory>(entity =>
        {
            entity.ToTable("IMP_MappingSettingHistory");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(500);
            entity.Property(e => e.ExcelColumnName).HasMaxLength(200);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.MappingId).HasColumnName("MappingID");
            entity.Property(e => e.Prefix)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.TemplateId).HasColumnName("TemplateID");
            entity.Property(e => e.Title).HasMaxLength(80);
        });

        modelBuilder.Entity<ImpOfferTracking>(entity =>
        {
            entity.ToTable("IMP_OfferTracking");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BanerSize).HasMaxLength(250);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(500);
            entity.Property(e => e.Ctalink).HasColumnName("CTALink");
            entity.Property(e => e.Ctatracking).HasColumnName("CTATracking");
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(80);
        });

        modelBuilder.Entity<ImpOfferTrackingDetail>(entity =>
        {
            entity.ToTable("IMP_OfferTrackingDetail");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Clicked).HasColumnType("datetime");
            entity.Property(e => e.Ipclient)
                .HasMaxLength(100)
                .HasColumnName("IPClient");
            entity.Property(e => e.OfferId).HasColumnName("OfferID");
            entity.Property(e => e.UserId)
                .HasMaxLength(500)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<ImpPostFflog>(entity =>
        {
            entity.ToTable("IMP_PostFFLog");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(50);
            entity.Property(e => e.DataFile).HasMaxLength(500);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(50);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(500);
            entity.Property(e => e.UploadId).HasColumnName("UploadID");
        });

        modelBuilder.Entity<ImpProcessUploadFileLog>(entity =>
        {
            entity.ToTable("IMP_ProcessUploadFileLog");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.EmailType).HasMaxLength(50);
            entity.Property(e => e.Emid)
                .HasMaxLength(250)
                .HasColumnName("EMID");
            entity.Property(e => e.GroupId)
                .HasMaxLength(250)
                .HasColumnName("GroupID");
            entity.Property(e => e.Template)
                .HasMaxLength(50)
                .HasColumnName("template");
            entity.Property(e => e.TemplateJson).HasColumnName("template_json");
            entity.Property(e => e.Title).HasMaxLength(200);
            entity.Property(e => e.UploadId).HasColumnName("UploadID");
            entity.Property(e => e.Usernme).HasMaxLength(200);
        });

        modelBuilder.Entity<ImpRuleSetup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_RuleSetup");

            entity.ToTable("IMP_RuleSetup");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.RuleSetting).HasColumnType("ntext");
            entity.Property(e => e.Title).HasMaxLength(80);
        });

        modelBuilder.Entity<ImpRuleSetupHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_RuleSetupHistory");

            entity.ToTable("IMP_RuleSetupHistory");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(500);
            entity.Property(e => e.RuleSetting).HasColumnType("ntext");
            entity.Property(e => e.RuleSetupId).HasColumnName("RuleSetupID");
        });

        modelBuilder.Entity<ImpSeason>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_IMP_Season_1");

            entity.ToTable("IMP_Season");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.FromDate).HasColumnType("datetime");
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.SeasonName).HasMaxLength(255);
            entity.Property(e => e.ShopName).HasMaxLength(200);
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.ToDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImpTemplateList>(entity =>
        {
            entity.ToTable("IMP_TemplateList");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateByName).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Createby).HasMaxLength(500);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.TableName).HasMaxLength(500);
            entity.Property(e => e.Title).HasMaxLength(80);
        });

        modelBuilder.Entity<ImpTemplateListDetail>(entity =>
        {
            entity.HasKey(e => e.IdDetail);

            entity.ToTable("IMP_TemplateListDetail");

            entity.Property(e => e.IdDetail).HasColumnName("Id_Detail");
            entity.Property(e => e.ApiColumnName).HasMaxLength(500);
            entity.Property(e => e.CreateByName).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Createby).HasMaxLength(500);
            entity.Property(e => e.DataType).HasMaxLength(250);
            entity.Property(e => e.DbcolumnName)
                .HasMaxLength(500)
                .HasColumnName("DBColumnName");
            entity.Property(e => e.ExcelColumnName).HasMaxLength(500);
            entity.Property(e => e.IdTemplateList).HasColumnName("Id_TemplateList");
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.RegexRule).HasMaxLength(500);
            entity.Property(e => e.Title).HasMaxLength(80);

            entity.HasOne(d => d.IdTemplateListNavigation).WithMany(p => p.ImpTemplateListDetails)
                .HasForeignKey(d => d.IdTemplateList)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IMP_TemplateListDetail");
        });

        modelBuilder.Entity<ImpUploadFileLog>(entity =>
        {
            entity.ToTable("IMP_UploadFileLog");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateByName).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Createby).HasMaxLength(500);
            entity.Property(e => e.IdTemplateList).HasColumnName("Id_TemplateList");
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.SeasonId).HasColumnName("SeasonID");
            entity.Property(e => e.TotalNewMainUserCreated).HasColumnName("Total_New_Main_User_Created");
            entity.Property(e => e.TotalRaw).HasColumnName("Total_Raw");
            entity.Property(e => e.TotalWelcomeEmailSended).HasColumnName("Total_Welcome_Email_Sended");

            entity.HasOne(d => d.IdTemplateListNavigation).WithMany(p => p.ImpUploadFileLogs)
                .HasForeignKey(d => d.IdTemplateList)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IMP_UploadFileLog");
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.HasKey(e => new { e.LanKey, e.LanId });

            entity.ToTable("Language");

            entity.Property(e => e.LanKey).HasMaxLength(50);
            entity.Property(e => e.LanId).HasColumnName("LanID");
            entity.Property(e => e.LanType).HasMaxLength(50);
            entity.Property(e => e.LanValue).HasMaxLength(500);
            entity.Property(e => e.Module).HasMaxLength(50);
        });

        modelBuilder.Entity<MetaAddress>(entity =>
        {
            entity.ToTable("MetaAddress");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddressLine1).HasMaxLength(255);
            entity.Property(e => e.AddressLine2).HasMaxLength(255);
            entity.Property(e => e.AddressLine3).HasMaxLength(255);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName).HasMaxLength(255);
            entity.Property(e => e.Country).HasMaxLength(255);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.OwnerId)
                .HasMaxLength(255)
                .HasColumnName("OwnerID");
            entity.Property(e => e.OwnerModule).HasMaxLength(255);
            entity.Property(e => e.Phone).HasMaxLength(255);
            entity.Property(e => e.PostCode).HasMaxLength(255);
            entity.Property(e => e.State).HasMaxLength(255);
            entity.Property(e => e.Suburb).HasMaxLength(255);
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<MetaExtentField>(entity =>
        {
            entity.ToTable("MetaExtentField");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AssemblyName).HasMaxLength(255);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<MetaExtentFieldValue>(entity =>
        {
            entity.ToTable("MetaExtentFieldValue");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AssemblyName).HasMaxLength(255);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.OwnerId)
                .HasMaxLength(255)
                .HasColumnName("OwnerID");
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<MetaLanguage>(entity =>
        {
            entity.ToTable("MetaLanguage");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.LangKey).HasMaxLength(50);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.OwnerId)
                .HasMaxLength(255)
                .HasColumnName("OwnerID");
            entity.Property(e => e.OwnerModule).HasMaxLength(255);
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<MetaResource>(entity =>
        {
            entity.ToTable("MetaResource");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<Navigation>(entity =>
        {
            entity.ToTable("Navigation");

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .HasColumnName("ID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Icon).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.MappingPage).HasMaxLength(50);
            entity.Property(e => e.NavigationId)
                .HasMaxLength(255)
                .HasColumnName("NavigationID");
            entity.Property(e => e.ParentId).HasMaxLength(255);
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.Url).HasMaxLength(255);
        });

        modelBuilder.Entity<NavigationList>(entity =>
        {
            entity.ToTable("NavigationList");

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .HasColumnName("ID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Icon).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.MappingPage).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.Url).HasMaxLength(255);
        });

        modelBuilder.Entity<NavigationWidget>(entity =>
        {
            entity.ToTable("NavigationWidget");

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .HasColumnName("ID");
            entity.Property(e => e.Source).HasMaxLength(255);
            entity.Property(e => e.Type).HasMaxLength(255);
        });

        modelBuilder.Entity<News>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(80);
        });

        modelBuilder.Entity<NewsCategory>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.ToTable("NewsCategory");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CatalogueId).HasColumnName("CatalogueID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(500);
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.ImageName).HasMaxLength(150);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.Title).HasMaxLength(40);
        });

        modelBuilder.Entity<PaymentTransation>(entity =>
        {
            entity.ToTable("PaymentTransation");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.AmountReceive).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CreateBy).HasMaxLength(255);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(255);
            entity.Property(e => e.Currency).HasMaxLength(255);
            entity.Property(e => e.Fee).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.LastUpdateBy).HasMaxLength(255);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(255);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.PayFrom).HasMaxLength(255);
            entity.Property(e => e.PayRequest).HasColumnType("datetime");
            entity.Property(e => e.PayResponse).HasColumnType("datetime");
            entity.Property(e => e.PayType).HasMaxLength(255);
            entity.Property(e => e.PaymentStatus).HasMaxLength(255);
            entity.Property(e => e.PaypalCode).HasMaxLength(255);
            entity.Property(e => e.PaypalDate).HasMaxLength(255);
            entity.Property(e => e.PaypalId)
                .HasMaxLength(255)
                .HasColumnName("PaypalID");
            entity.Property(e => e.PaypalPendingReason).HasMaxLength(255);
            entity.Property(e => e.PaypalStatus).HasMaxLength(255);
            entity.Property(e => e.PaypalType).HasMaxLength(255);
            entity.Property(e => e.ResponseCode).HasMaxLength(255);
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.Token).HasMaxLength(255);
            entity.Property(e => e.TransationId)
                .HasMaxLength(255)
                .HasColumnName("TransationID");
        });

        modelBuilder.Entity<Permission>(entity =>
        {
            entity.HasKey(e => new { e.PermissionKey, e.RoleId }).HasName("PK__Permission_PermissionKey_RoleId");

            entity.ToTable("Permission");

            entity.Property(e => e.PermissionKey).HasMaxLength(100);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Module).HasMaxLength(100);
            entity.Property(e => e.Title).HasMaxLength(100);
        });

        modelBuilder.Entity<PostAddress>(entity =>
        {
            entity.ToTable("PostAddress");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Category).HasMaxLength(200);
            entity.Property(e => e.Comments).HasMaxLength(500);
            entity.Property(e => e.Country).HasMaxLength(200);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.FullSuburb).HasMaxLength(500);
            entity.Property(e => e.PostCode).HasMaxLength(200);
            entity.Property(e => e.State).HasMaxLength(200);
            entity.Property(e => e.Suburb).HasMaxLength(200);
        });

        modelBuilder.Entity<PrmoPromotion>(entity =>
        {
            entity.ToTable("PRMO_Promotion");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AllTypeId).HasColumnName("AllTypeID");
            entity.Property(e => e.AppType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("A: All Orders \r\n\r\nP: Products\r\nU: Users");
            entity.Property(e => e.CodeApplyFor)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("SV: Static Value\r\n\r\nUP: Unique Per Instance (User/Email)");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateByName).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Createby).HasMaxLength(500);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.MinSpendStatus).HasComment("1: TRUE\r\n\r\n0: FALSE");
            entity.Property(e => e.MinSpendValue).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.PromoTypeValue).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Status).HasComment("1: TRUE\r\n\r\n0: FALSE\r\n(Active field)");
            entity.Property(e => e.Title)
                .HasMaxLength(80)
                .HasComment("PromotionName");
            entity.Property(e => e.UsageLimit)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("SU:  SingleUser\r\n\r\n1C:Once per Customer\r\n\r\nLA: LimitAmount");
        });

        modelBuilder.Entity<PrmoPromotionCode>(entity =>
        {
            entity.ToTable("PRMO_PromotionCode");

            entity.Property(e => e.Id)
                .HasComment("Promo code name ")
                .HasColumnName("ID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateByName).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Createby).HasMaxLength(500);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.PromoId).HasColumnName("PromoID");
            entity.Property(e => e.Title)
                .HasMaxLength(80)
                .HasComment("Promo code name ");
        });

        modelBuilder.Entity<PrmoPromotionCodeAssignUser>(entity =>
        {
            entity.HasKey(e => new { e.PromoCodeId, e.UserId });

            entity.ToTable("PRMO_PromotionCodeAssignUser");

            entity.Property(e => e.PromoCodeId).HasColumnName("PromoCodeID");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");
            entity.Property(e => e.CreateByName).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Createby).HasMaxLength(500);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.SendEmail).HasComment("NULL: NOT SEND\r\n\r\n1: SEND\r\n\r\n0: NOT YET SEND");
            entity.Property(e => e.Title).HasMaxLength(80);
            entity.Property(e => e.UserTypeId).HasColumnName("UserTypeID");
        });

        modelBuilder.Entity<PrmoPromotionCodeUsed>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PRMO_PromotionUsed");

            entity.ToTable("PRMO_PromotionCodeUsed");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateByName).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Createby).HasMaxLength(500);
            entity.Property(e => e.EmailUser).HasMaxLength(100);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.PromoCodeId).HasColumnName("PromoCodeID");
            entity.Property(e => e.PromoId).HasColumnName("PromoID");
            entity.Property(e => e.PromoTypeValue).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.PromoValue).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Title).HasMaxLength(80);
            entity.Property(e => e.TotalGst).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<PrmoPromotionProduct>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Idproduct });

            entity.ToTable("PRMO_PromotionProduct");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idproduct).HasColumnName("IDProduct");
            entity.Property(e => e.CreateByName).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Createby).HasMaxLength(500);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(80);
        });

        modelBuilder.Entity<PrmoPromotionType>(entity =>
        {
            entity.ToTable("PRMO_PromotionType");

            entity.Property(e => e.CreateByName).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Createby).HasMaxLength(500);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Title)
                .HasMaxLength(80)
                .HasComment("Amount\r\nPercentage\r\nFreeShipping");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("Product");

            entity.HasIndex(e => e.CompanyId, "CompanyID");

            entity.HasIndex(e => e.Skuid, "SkuID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Available).HasDefaultValueSql("((0))");
            entity.Property(e => e.BaseCode).HasMaxLength(50);
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(500);
            entity.Property(e => e.CreditValue).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.FromDate).HasColumnType("datetime");
            entity.Property(e => e.Height).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.InternalCode).HasMaxLength(50);
            entity.Property(e => e.InventoryCode).HasMaxLength(50);
            entity.Property(e => e.IsDynamicPrice).HasDefaultValueSql("((0))");
            entity.Property(e => e.IsGst).HasDefaultValueSql("((0))");
            entity.Property(e => e.IsNew).HasDefaultValueSql("((0))");
            entity.Property(e => e.IsPreOrder).HasDefaultValueSql("((0))");
            entity.Property(e => e.IsView).HasDefaultValueSql("((1))");
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Length).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.OnOrder).HasDefaultValueSql("((0))");
            entity.Property(e => e.OnStock).HasDefaultValueSql("((0))");
            entity.Property(e => e.PreOrderLimit).HasDefaultValueSql("((0))");
            entity.Property(e => e.PrimaryWh).HasDefaultValueSql("((1))");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ProductStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('Active')");
            entity.Property(e => e.ProductType).HasDefaultValueSql("((1))");
            entity.Property(e => e.Title).HasMaxLength(500);
            entity.Property(e => e.ToDate).HasColumnType("datetime");
            entity.Property(e => e.VirtualCode).HasMaxLength(50);
            entity.Property(e => e.VirtualId).HasColumnName("VirtualID");
            entity.Property(e => e.Weight).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Width).HasColumnType("decimal(18, 3)");
        });

        modelBuilder.Entity<ProductAttachment>(entity =>
        {
            entity.ToTable("ProductAttachment");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.FileType).HasMaxLength(250);
            entity.Property(e => e.FileUrl).HasMaxLength(250);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<ProductAttachmentTracking>(entity =>
        {
            entity.ToTable("ProductAttachmentTracking");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.DownLoadBy).HasMaxLength(50);
            entity.Property(e => e.DownLoadByName).HasMaxLength(250);
            entity.Property(e => e.DownLoadDate).HasColumnType("datetime");
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.ProductAttachmentId).HasColumnName("ProductAttachmentID");
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<ProductAttributeDescription>(entity =>
        {
            entity.ToTable("ProductAttributeDescription");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<ProductCategory>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_category")
                .IsClustered(false);

            entity.ToTable("ProductCategory");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(500);
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.ImageThumbUrl).HasMaxLength(250);
            entity.Property(e => e.ImageUrl).HasMaxLength(250);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.ParentId).HasDefaultValueSql("((0))");
            entity.Property(e => e.Title).HasMaxLength(40);
            entity.Property(e => e.TreeId)
                .HasMaxLength(500)
                .HasColumnName("TreeID");
        });

        modelBuilder.Entity<ProductCombine>(entity =>
        {
            entity.ToTable("ProductCombine");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(500);
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.IsAddItem).HasDefaultValueSql("((0))");
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.MaxItem).HasDefaultValueSql("((1))");
            entity.Property(e => e.MinItem).HasDefaultValueSql("((1))");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Title).HasMaxLength(40);
            entity.Property(e => e.ViewItem).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<ProductCombineAttribute>(entity =>
        {
            entity.ToTable("ProductCombineAttribute");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(500);
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.ProductCombineId).HasColumnName("ProductCombineID");
            entity.Property(e => e.SelectedValue).HasMaxLength(2000);
            entity.Property(e => e.Title).HasMaxLength(40);
        });

        modelBuilder.Entity<ProductCombineAttributeImage>(entity =>
        {
            entity.ToTable("ProductCombineAttributeImage");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AttributeName).HasMaxLength(250);
            entity.Property(e => e.AttributeValue).HasMaxLength(250);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.ImageUrl).HasMaxLength(250);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.ProductCombineId).HasColumnName("ProductCombineID");
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<ProductCombineAttributeMap>(entity =>
        {
            entity.ToTable("ProductCombineAttributeMap");

            entity.HasIndex(e => e.ProductId, "ProductID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(500);
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.ProductCombineId).HasColumnName("ProductCombineID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Title).HasMaxLength(40);
            entity.Property(e => e.Value).HasMaxLength(40);
        });

        modelBuilder.Entity<ProductCombineMap>(entity =>
        {
            entity.ToTable("ProductCombineMap");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(500);
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.ParentTitle).HasMaxLength(40);
            entity.Property(e => e.ProductCombineId).HasColumnName("ProductCombineID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Title).HasMaxLength(40);
            entity.Property(e => e.Value).HasMaxLength(150);
        });

        modelBuilder.Entity<ProductFavorite>(entity =>
        {
            entity.ToTable("ProductFavorite");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.ImageThumbUrl).HasMaxLength(250);
            entity.Property(e => e.ImageUrl).HasMaxLength(250);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.PathQuery).HasMaxLength(500);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<ProductFilter>(entity =>
        {
            entity.ToTable("ProductFilter");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompanyId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(500);
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.ImageThumbUrl).HasMaxLength(250);
            entity.Property(e => e.ImageUrl).HasMaxLength(250);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<ProductFilterDetail>(entity =>
        {
            entity.ToTable("ProductFilterDetail");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(500);
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.ImageThumbUrl).HasMaxLength(250);
            entity.Property(e => e.ImageUrl).HasMaxLength(250);
            entity.Property(e => e.Key).HasMaxLength(100);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.ProductFilterId).HasColumnName("ProductFilterID");
            entity.Property(e => e.Title).HasMaxLength(100);
        });

        modelBuilder.Entity<ProductFilterMap>(entity =>
        {
            entity.ToTable("ProductFilterMap");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(500);
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.ProductFilterDetailId).HasColumnName("ProductFilterDetailID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Title).HasMaxLength(100);
        });

        modelBuilder.Entity<ProductImage>(entity =>
        {
            entity.ToTable("ProductImage");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.ImageThumbUrl).HasMaxLength(250);
            entity.Property(e => e.ImageUrl).HasMaxLength(250);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<ProductLayer>(entity =>
        {
            entity.ToTable("ProductLayer");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(500);
            entity.Property(e => e.ImageThumbUrl).HasMaxLength(250);
            entity.Property(e => e.ImageUrl).HasMaxLength(250);
            entity.Property(e => e.Key).HasMaxLength(50);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ProductLayerBaseIndex).HasDefaultValueSql("((1))");
            entity.Property(e => e.Title).HasMaxLength(80);
        });

        modelBuilder.Entity<ProductLayerBase>(entity =>
        {
            entity.ToTable("ProductLayerBase");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(500);
            entity.Property(e => e.ImageThumbUrl).HasMaxLength(250);
            entity.Property(e => e.ImageUrl).HasMaxLength(250);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Title).HasMaxLength(80);
        });

        modelBuilder.Entity<ProductLayerDetail>(entity =>
        {
            entity.ToTable("ProductLayerDetail");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(500);
            entity.Property(e => e.Group).HasMaxLength(150);
            entity.Property(e => e.ImageThumbUrl).HasMaxLength(250);
            entity.Property(e => e.ImageUrl).HasMaxLength(250);
            entity.Property(e => e.Key).HasMaxLength(50);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Price).HasDefaultValueSql("((0))");
            entity.Property(e => e.ProductLayerId).HasColumnName("ProductLayerID");
            entity.Property(e => e.Title).HasMaxLength(80);
        });

        modelBuilder.Entity<ProductLayerDetailImage>(entity =>
        {
            entity.ToTable("ProductLayerDetailImage");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.ImageThumbUrl).HasMaxLength(250);
            entity.Property(e => e.ImageUrl).HasMaxLength(250);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.ProductLayerBaseId).HasColumnName("ProductLayerBaseID");
            entity.Property(e => e.ProductLayerDetailId).HasColumnName("ProductLayerDetailID");
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<ProductLetterPersonalize>(entity =>
        {
            entity.ToTable("ProductLetterPersonalize");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.FontColor).HasMaxLength(50);
            entity.Property(e => e.FontName).HasMaxLength(250);
            entity.Property(e => e.ImageThumbUrl).HasMaxLength(250);
            entity.Property(e => e.ImageUrl).HasMaxLength(250);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Letter).HasMaxLength(250);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.Xaxis).HasColumnName("XAxis");
            entity.Property(e => e.Yaxis).HasColumnName("YAxis");
        });

        modelBuilder.Entity<ProductPackedItem>(entity =>
        {
            entity.ToTable("ProductPackedItem");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ProductItemId).HasColumnName("ProductItemID");
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<ProductPersonalize>(entity =>
        {
            entity.ToTable("ProductPersonalize");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.ImageThumbUrl).HasMaxLength(250);
            entity.Property(e => e.ImageUrl).HasMaxLength(250);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<ProductPrice>(entity =>
        {
            entity.ToTable("ProductPrice");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(500);
            entity.Property(e => e.CreateByName).HasMaxLength(500);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Currency)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'AUD')");
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TaxRate).HasDefaultValueSql("((10))");
            entity.Property(e => e.Title).HasMaxLength(80);
            entity.Property(e => e.UserTypeId).HasColumnName("UserTypeID");
        });

        modelBuilder.Entity<ProductPriceBak>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ProductPrice_bak");

            entity.Property(e => e.CreateBy).HasMaxLength(500);
            entity.Property(e => e.CreateByName).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Currency).HasMaxLength(10);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(80);
            entity.Property(e => e.UserTypeId).HasColumnName("UserTypeID");
        });

        modelBuilder.Entity<ProductQty>(entity =>
        {
            entity.ToTable("ProductQty");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Available).HasDefaultValueSql("((0))");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.OnOrder).HasDefaultValueSql("((0))");
            entity.Property(e => e.OnStock).HasDefaultValueSql("((0))");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Title).HasMaxLength(500);
            entity.Property(e => e.Whid)
                .HasDefaultValueSql("((1))")
                .HasColumnName("WHID");
        });

        modelBuilder.Entity<ProductQuotum>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(500);
            entity.Property(e => e.CreateByName).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Title).HasMaxLength(80);
            entity.Property(e => e.UserTypeId).HasColumnName("UserTypeID");
        });

        modelBuilder.Entity<ProductRedeem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Redeem");

            entity.ToTable("ProductRedeem");

            entity.HasIndex(e => e.UserId, "UserID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.DefaultItemSelection).IsUnicode(false);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.IsNotOptOut).HasDefaultValueSql("((0))");
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ProductId1).HasColumnName("ProductID1");
            entity.Property(e => e.ProductId2).HasColumnName("ProductID2");
            entity.Property(e => e.Redeem).HasDefaultValueSql("((0))");
            entity.Property(e => e.RedeemAutoDeadLine).HasColumnType("datetime");
            entity.Property(e => e.RedeemAvailable).HasDefaultValueSql("((0))");
            entity.Property(e => e.RedeemHidden).HasDefaultValueSql("((0))");
            entity.Property(e => e.RedeemRawData).HasColumnType("xml");
            entity.Property(e => e.RedeemReject).HasDefaultValueSql("((0))");
            entity.Property(e => e.Redeemed).HasDefaultValueSql("((0))");
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<ProductTag>(entity =>
        {
            entity.ToTable("ProductTag");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompanyId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(500);
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.ImageThumbUrl).HasMaxLength(250);
            entity.Property(e => e.ImageUrl).HasMaxLength(250);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.Title).HasMaxLength(40);
        });

        modelBuilder.Entity<ProductTagMap>(entity =>
        {
            entity.ToTable("ProductTagMap");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(500);
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ProductTagId).HasColumnName("ProductTagID");
            entity.Property(e => e.Title).HasMaxLength(40);
        });

        modelBuilder.Entity<ProductTrackingClick>(entity =>
        {
            entity.ToTable("ProductTrackingClick");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<ProductWaveHouse>(entity =>
        {
            entity.ToTable("ProductWaveHouse");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Available).HasDefaultValueSql("((0))");
            entity.Property(e => e.CreateBy).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.OnOrder).HasDefaultValueSql("((0))");
            entity.Property(e => e.OnStock).HasDefaultValueSql("((0))");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            entity.Property(e => e.Title).HasMaxLength(80);
        });

        modelBuilder.Entity<ProductWish>(entity =>
        {
            entity.ToTable("ProductWish");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.PathQuery).HasMaxLength(500);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<QrtzBlobTrigger>(entity =>
        {
            entity.HasKey(e => new { e.SchedName, e.TriggerName, e.TriggerGroup });

            entity.ToTable("QRTZ_BLOB_TRIGGERS");

            entity.Property(e => e.SchedName)
                .HasMaxLength(120)
                .HasColumnName("SCHED_NAME");
            entity.Property(e => e.TriggerName)
                .HasMaxLength(150)
                .HasColumnName("TRIGGER_NAME");
            entity.Property(e => e.TriggerGroup)
                .HasMaxLength(150)
                .HasColumnName("TRIGGER_GROUP");
            entity.Property(e => e.BlobData).HasColumnName("BLOB_DATA");
        });

        modelBuilder.Entity<QrtzCalendar>(entity =>
        {
            entity.HasKey(e => new { e.SchedName, e.CalendarName });

            entity.ToTable("QRTZ_CALENDARS");

            entity.Property(e => e.SchedName)
                .HasMaxLength(120)
                .HasColumnName("SCHED_NAME");
            entity.Property(e => e.CalendarName)
                .HasMaxLength(200)
                .HasColumnName("CALENDAR_NAME");
            entity.Property(e => e.Calendar).HasColumnName("CALENDAR");
        });

        modelBuilder.Entity<QrtzCronTrigger>(entity =>
        {
            entity.HasKey(e => new { e.SchedName, e.TriggerName, e.TriggerGroup });

            entity.ToTable("QRTZ_CRON_TRIGGERS");

            entity.Property(e => e.SchedName)
                .HasMaxLength(120)
                .HasColumnName("SCHED_NAME");
            entity.Property(e => e.TriggerName)
                .HasMaxLength(150)
                .HasColumnName("TRIGGER_NAME");
            entity.Property(e => e.TriggerGroup)
                .HasMaxLength(150)
                .HasColumnName("TRIGGER_GROUP");
            entity.Property(e => e.CronExpression)
                .HasMaxLength(120)
                .HasColumnName("CRON_EXPRESSION");
            entity.Property(e => e.TimeZoneId)
                .HasMaxLength(80)
                .HasColumnName("TIME_ZONE_ID");

            entity.HasOne(d => d.QrtzTrigger).WithOne(p => p.QrtzCronTrigger)
                .HasForeignKey<QrtzCronTrigger>(d => new { d.SchedName, d.TriggerName, d.TriggerGroup })
                .HasConstraintName("FK_QRTZ_CRON_TRIGGERS_QRTZ_TRIGGERS");
        });

        modelBuilder.Entity<QrtzFiredTrigger>(entity =>
        {
            entity.HasKey(e => new { e.SchedName, e.EntryId });

            entity.ToTable("QRTZ_FIRED_TRIGGERS");

            entity.HasIndex(e => new { e.SchedName, e.InstanceName, e.RequestsRecovery }, "IDX_QRTZ_FT_INST_JOB_REQ_RCVRY");

            entity.HasIndex(e => new { e.SchedName, e.JobGroup }, "IDX_QRTZ_FT_JG");

            entity.HasIndex(e => new { e.SchedName, e.JobName, e.JobGroup }, "IDX_QRTZ_FT_J_G");

            entity.HasIndex(e => new { e.SchedName, e.TriggerGroup }, "IDX_QRTZ_FT_TG");

            entity.HasIndex(e => new { e.SchedName, e.InstanceName }, "IDX_QRTZ_FT_TRIG_INST_NAME");

            entity.HasIndex(e => new { e.SchedName, e.TriggerName, e.TriggerGroup }, "IDX_QRTZ_FT_T_G");

            entity.Property(e => e.SchedName)
                .HasMaxLength(120)
                .HasColumnName("SCHED_NAME");
            entity.Property(e => e.EntryId)
                .HasMaxLength(140)
                .HasColumnName("ENTRY_ID");
            entity.Property(e => e.FiredTime).HasColumnName("FIRED_TIME");
            entity.Property(e => e.InstanceName)
                .HasMaxLength(200)
                .HasColumnName("INSTANCE_NAME");
            entity.Property(e => e.IsNonconcurrent).HasColumnName("IS_NONCONCURRENT");
            entity.Property(e => e.JobGroup)
                .HasMaxLength(150)
                .HasColumnName("JOB_GROUP");
            entity.Property(e => e.JobName)
                .HasMaxLength(150)
                .HasColumnName("JOB_NAME");
            entity.Property(e => e.Priority).HasColumnName("PRIORITY");
            entity.Property(e => e.RequestsRecovery).HasColumnName("REQUESTS_RECOVERY");
            entity.Property(e => e.SchedTime).HasColumnName("SCHED_TIME");
            entity.Property(e => e.State)
                .HasMaxLength(16)
                .HasColumnName("STATE");
            entity.Property(e => e.TriggerGroup)
                .HasMaxLength(150)
                .HasColumnName("TRIGGER_GROUP");
            entity.Property(e => e.TriggerName)
                .HasMaxLength(150)
                .HasColumnName("TRIGGER_NAME");
        });

        modelBuilder.Entity<QrtzJobDetail>(entity =>
        {
            entity.HasKey(e => new { e.SchedName, e.JobName, e.JobGroup });

            entity.ToTable("QRTZ_JOB_DETAILS");

            entity.Property(e => e.SchedName)
                .HasMaxLength(120)
                .HasColumnName("SCHED_NAME");
            entity.Property(e => e.JobName)
                .HasMaxLength(150)
                .HasColumnName("JOB_NAME");
            entity.Property(e => e.JobGroup)
                .HasMaxLength(150)
                .HasColumnName("JOB_GROUP");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.IsDurable).HasColumnName("IS_DURABLE");
            entity.Property(e => e.IsNonconcurrent).HasColumnName("IS_NONCONCURRENT");
            entity.Property(e => e.IsUpdateData).HasColumnName("IS_UPDATE_DATA");
            entity.Property(e => e.JobClassName)
                .HasMaxLength(250)
                .HasColumnName("JOB_CLASS_NAME");
            entity.Property(e => e.JobData).HasColumnName("JOB_DATA");
            entity.Property(e => e.RequestsRecovery).HasColumnName("REQUESTS_RECOVERY");
        });

        modelBuilder.Entity<QrtzLock>(entity =>
        {
            entity.HasKey(e => new { e.SchedName, e.LockName });

            entity.ToTable("QRTZ_LOCKS");

            entity.Property(e => e.SchedName)
                .HasMaxLength(120)
                .HasColumnName("SCHED_NAME");
            entity.Property(e => e.LockName)
                .HasMaxLength(40)
                .HasColumnName("LOCK_NAME");
        });

        modelBuilder.Entity<QrtzPausedTriggerGrp>(entity =>
        {
            entity.HasKey(e => new { e.SchedName, e.TriggerGroup });

            entity.ToTable("QRTZ_PAUSED_TRIGGER_GRPS");

            entity.Property(e => e.SchedName)
                .HasMaxLength(120)
                .HasColumnName("SCHED_NAME");
            entity.Property(e => e.TriggerGroup)
                .HasMaxLength(150)
                .HasColumnName("TRIGGER_GROUP");
        });

        modelBuilder.Entity<QrtzSchedulerState>(entity =>
        {
            entity.HasKey(e => new { e.SchedName, e.InstanceName });

            entity.ToTable("QRTZ_SCHEDULER_STATE");

            entity.Property(e => e.SchedName)
                .HasMaxLength(120)
                .HasColumnName("SCHED_NAME");
            entity.Property(e => e.InstanceName)
                .HasMaxLength(200)
                .HasColumnName("INSTANCE_NAME");
            entity.Property(e => e.CheckinInterval).HasColumnName("CHECKIN_INTERVAL");
            entity.Property(e => e.LastCheckinTime).HasColumnName("LAST_CHECKIN_TIME");
        });

        modelBuilder.Entity<QrtzSimpleTrigger>(entity =>
        {
            entity.HasKey(e => new { e.SchedName, e.TriggerName, e.TriggerGroup });

            entity.ToTable("QRTZ_SIMPLE_TRIGGERS");

            entity.Property(e => e.SchedName)
                .HasMaxLength(120)
                .HasColumnName("SCHED_NAME");
            entity.Property(e => e.TriggerName)
                .HasMaxLength(150)
                .HasColumnName("TRIGGER_NAME");
            entity.Property(e => e.TriggerGroup)
                .HasMaxLength(150)
                .HasColumnName("TRIGGER_GROUP");
            entity.Property(e => e.RepeatCount).HasColumnName("REPEAT_COUNT");
            entity.Property(e => e.RepeatInterval).HasColumnName("REPEAT_INTERVAL");
            entity.Property(e => e.TimesTriggered).HasColumnName("TIMES_TRIGGERED");

            entity.HasOne(d => d.QrtzTrigger).WithOne(p => p.QrtzSimpleTrigger)
                .HasForeignKey<QrtzSimpleTrigger>(d => new { d.SchedName, d.TriggerName, d.TriggerGroup })
                .HasConstraintName("FK_QRTZ_SIMPLE_TRIGGERS_QRTZ_TRIGGERS");
        });

        modelBuilder.Entity<QrtzSimpropTrigger>(entity =>
        {
            entity.HasKey(e => new { e.SchedName, e.TriggerName, e.TriggerGroup });

            entity.ToTable("QRTZ_SIMPROP_TRIGGERS");

            entity.Property(e => e.SchedName)
                .HasMaxLength(120)
                .HasColumnName("SCHED_NAME");
            entity.Property(e => e.TriggerName)
                .HasMaxLength(150)
                .HasColumnName("TRIGGER_NAME");
            entity.Property(e => e.TriggerGroup)
                .HasMaxLength(150)
                .HasColumnName("TRIGGER_GROUP");
            entity.Property(e => e.BoolProp1).HasColumnName("BOOL_PROP_1");
            entity.Property(e => e.BoolProp2).HasColumnName("BOOL_PROP_2");
            entity.Property(e => e.DecProp1)
                .HasColumnType("numeric(13, 4)")
                .HasColumnName("DEC_PROP_1");
            entity.Property(e => e.DecProp2)
                .HasColumnType("numeric(13, 4)")
                .HasColumnName("DEC_PROP_2");
            entity.Property(e => e.IntProp1).HasColumnName("INT_PROP_1");
            entity.Property(e => e.IntProp2).HasColumnName("INT_PROP_2");
            entity.Property(e => e.LongProp1).HasColumnName("LONG_PROP_1");
            entity.Property(e => e.LongProp2).HasColumnName("LONG_PROP_2");
            entity.Property(e => e.StrProp1)
                .HasMaxLength(512)
                .HasColumnName("STR_PROP_1");
            entity.Property(e => e.StrProp2)
                .HasMaxLength(512)
                .HasColumnName("STR_PROP_2");
            entity.Property(e => e.StrProp3)
                .HasMaxLength(512)
                .HasColumnName("STR_PROP_3");
            entity.Property(e => e.TimeZoneId)
                .HasMaxLength(80)
                .HasColumnName("TIME_ZONE_ID");

            entity.HasOne(d => d.QrtzTrigger).WithOne(p => p.QrtzSimpropTrigger)
                .HasForeignKey<QrtzSimpropTrigger>(d => new { d.SchedName, d.TriggerName, d.TriggerGroup })
                .HasConstraintName("FK_QRTZ_SIMPROP_TRIGGERS_QRTZ_TRIGGERS");
        });

        modelBuilder.Entity<QrtzTrigger>(entity =>
        {
            entity.HasKey(e => new { e.SchedName, e.TriggerName, e.TriggerGroup });

            entity.ToTable("QRTZ_TRIGGERS");

            entity.HasIndex(e => new { e.SchedName, e.CalendarName }, "IDX_QRTZ_T_C");

            entity.HasIndex(e => new { e.SchedName, e.TriggerGroup }, "IDX_QRTZ_T_G");

            entity.HasIndex(e => new { e.SchedName, e.JobName, e.JobGroup }, "IDX_QRTZ_T_J");

            entity.HasIndex(e => new { e.SchedName, e.JobGroup }, "IDX_QRTZ_T_JG");

            entity.HasIndex(e => new { e.SchedName, e.NextFireTime }, "IDX_QRTZ_T_NEXT_FIRE_TIME");

            entity.HasIndex(e => new { e.SchedName, e.MisfireInstr, e.NextFireTime }, "IDX_QRTZ_T_NFT_MISFIRE");

            entity.HasIndex(e => new { e.SchedName, e.TriggerState, e.NextFireTime }, "IDX_QRTZ_T_NFT_ST");

            entity.HasIndex(e => new { e.SchedName, e.MisfireInstr, e.NextFireTime, e.TriggerState }, "IDX_QRTZ_T_NFT_ST_MISFIRE");

            entity.HasIndex(e => new { e.SchedName, e.MisfireInstr, e.NextFireTime, e.TriggerGroup, e.TriggerState }, "IDX_QRTZ_T_NFT_ST_MISFIRE_GRP");

            entity.HasIndex(e => new { e.SchedName, e.TriggerGroup, e.TriggerState }, "IDX_QRTZ_T_N_G_STATE");

            entity.HasIndex(e => new { e.SchedName, e.TriggerName, e.TriggerGroup, e.TriggerState }, "IDX_QRTZ_T_N_STATE");

            entity.HasIndex(e => new { e.SchedName, e.TriggerState }, "IDX_QRTZ_T_STATE");

            entity.Property(e => e.SchedName)
                .HasMaxLength(120)
                .HasColumnName("SCHED_NAME");
            entity.Property(e => e.TriggerName)
                .HasMaxLength(150)
                .HasColumnName("TRIGGER_NAME");
            entity.Property(e => e.TriggerGroup)
                .HasMaxLength(150)
                .HasColumnName("TRIGGER_GROUP");
            entity.Property(e => e.CalendarName)
                .HasMaxLength(200)
                .HasColumnName("CALENDAR_NAME");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.EndTime).HasColumnName("END_TIME");
            entity.Property(e => e.JobData).HasColumnName("JOB_DATA");
            entity.Property(e => e.JobGroup)
                .HasMaxLength(150)
                .HasColumnName("JOB_GROUP");
            entity.Property(e => e.JobName)
                .HasMaxLength(150)
                .HasColumnName("JOB_NAME");
            entity.Property(e => e.MisfireInstr).HasColumnName("MISFIRE_INSTR");
            entity.Property(e => e.NextFireTime).HasColumnName("NEXT_FIRE_TIME");
            entity.Property(e => e.PrevFireTime).HasColumnName("PREV_FIRE_TIME");
            entity.Property(e => e.Priority).HasColumnName("PRIORITY");
            entity.Property(e => e.StartTime).HasColumnName("START_TIME");
            entity.Property(e => e.TriggerState)
                .HasMaxLength(16)
                .HasColumnName("TRIGGER_STATE");
            entity.Property(e => e.TriggerType)
                .HasMaxLength(8)
                .HasColumnName("TRIGGER_TYPE");

            entity.HasOne(d => d.QrtzJobDetail).WithMany(p => p.QrtzTriggers)
                .HasForeignKey(d => new { d.SchedName, d.JobName, d.JobGroup })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QRTZ_TRIGGERS_QRTZ_JOB_DETAILS");
        });

        modelBuilder.Entity<RawData12515202108020149080550>(entity =>
        {
            entity.ToTable("RawData_125_15_202108020149080550");

            entity.HasIndex(e => e.EmpGroupId, "EMP_GroupID");

            entity.HasIndex(e => new { e.EmpUserId, e.UploadId }, "EMP_UserId");

            entity.HasIndex(e => e.UploadId, "UploadId");

            entity.Property(e => e.AcctId).HasColumnName("acct_id");
            entity.Property(e => e.AcctTypeDesc)
                .HasMaxLength(500)
                .HasColumnName("acct_type_desc");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Barcode)
                .HasMaxLength(500)
                .HasColumnName("barcode");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("birthdate");
            entity.Property(e => e.Card)
                .HasMaxLength(500)
                .HasColumnName("card");
            entity.Property(e => e.City)
                .HasMaxLength(500)
                .HasColumnName("city");
            entity.Property(e => e.ClubCode)
                .HasMaxLength(500)
                .HasColumnName("club_code");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(500)
                .HasColumnName("company_name");
            entity.Property(e => e.ConcessionText)
                .HasMaxLength(500)
                .HasColumnName("concession_text");
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .HasColumnName("country");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustNameId).HasColumnName("cust_name_id");
            entity.Property(e => e.DeliveryInstructions)
                .HasMaxLength(500)
                .HasColumnName("delivery_instructions");
            entity.Property(e => e.DeliveryMethodName)
                .HasMaxLength(500)
                .HasColumnName("delivery_method_name");
            entity.Property(e => e.EmailAddr)
                .HasMaxLength(500)
                .HasColumnName("email_addr");
            entity.Property(e => e.EmpAcctStatus).HasColumnName("EMP_AcctStatus");
            entity.Property(e => e.EmpCredit)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("EMP_Credit");
            entity.Property(e => e.EmpDisplayOrder).HasColumnName("EMP_DisplayOrder");
            entity.Property(e => e.EmpErrorCode)
                .HasMaxLength(200)
                .HasColumnName("EMP_ErrorCode");
            entity.Property(e => e.EmpGender)
                .HasMaxLength(200)
                .HasColumnName("EMP_Gender");
            entity.Property(e => e.EmpGroupId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupId");
            entity.Property(e => e.EmpGroupUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupUserId");
            entity.Property(e => e.EmpIsCardOnly).HasColumnName("EMP_IsCardOnly");
            entity.Property(e => e.EmpIsMain)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_IsMain");
            entity.Property(e => e.EmpLoginAcctStatus).HasColumnName("EMP_LoginAcctStatus");
            entity.Property(e => e.EmpParticipantId).HasColumnName("EMP_ParticipantId");
            entity.Property(e => e.EmpProgramId).HasColumnName("EMP_ProgramId");
            entity.Property(e => e.EmpProgramName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ProgramName");
            entity.Property(e => e.EmpRecordInActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_RecordInActive");
            entity.Property(e => e.EmpRecordType)
                .HasMaxLength(200)
                .HasColumnName("EMP_RecordType");
            entity.Property(e => e.EmpRedeemed).HasColumnName("EMP_Redeemed");
            entity.Property(e => e.EmpSeasonId).HasColumnName("EMP_SeasonID");
            entity.Property(e => e.EmpShopName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ShopName");
            entity.Property(e => e.EmpUniqueKey)
                .HasMaxLength(300)
                .HasColumnName("EMP_UniqueKey");
            entity.Property(e => e.EmpUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_UserId");
            entity.Property(e => e.EmpUserTypeId).HasColumnName("EMP_UserTypeId");
            entity.Property(e => e.EmpUsername)
                .HasMaxLength(200)
                .HasColumnName("EMP_Username");
            entity.Property(e => e.EmpXmlData)
                .HasColumnType("xml")
                .HasColumnName("EMP_XmlData");
            entity.Property(e => e.EventLine1)
                .HasMaxLength(500)
                .HasColumnName("event_line1");
            entity.Property(e => e.EventLine2)
                .HasMaxLength(500)
                .HasColumnName("event_line2");
            entity.Property(e => e.EventLine3)
                .HasMaxLength(500)
                .HasColumnName("event_line3");
            entity.Property(e => e.EventName)
                .HasMaxLength(500)
                .HasColumnName("event_name");
            entity.Property(e => e.FamilyId).HasColumnName("family_id");
            entity.Property(e => e.Fulfilment)
                .HasMaxLength(500)
                .HasColumnName("fulfilment");
            entity.Property(e => e.Gender)
                .HasMaxLength(500)
                .HasColumnName("gender");
            entity.Property(e => e.GroupCodes)
                .HasMaxLength(500)
                .HasColumnName("group_codes");
            entity.Property(e => e.LocationCity)
                .HasMaxLength(500)
                .HasColumnName("location_city");
            entity.Property(e => e.LocationCountry)
                .HasMaxLength(500)
                .HasColumnName("location_country");
            entity.Property(e => e.LocationState)
                .HasMaxLength(500)
                .HasColumnName("location_state");
            entity.Property(e => e.LocationStreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_1");
            entity.Property(e => e.LocationStreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_2");
            entity.Property(e => e.LocationZip)
                .HasMaxLength(500)
                .HasColumnName("location_zip");
            entity.Property(e => e.MemberId).HasColumnName("member_id");
            entity.Property(e => e.MemberSince).HasColumnName("member_since");
            entity.Property(e => e.MembershipType)
                .HasMaxLength(500)
                .HasColumnName("membership_type");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(500)
                .HasColumnName("middle_name");
            entity.Property(e => e.NameFirst)
                .HasMaxLength(500)
                .HasColumnName("name_first");
            entity.Property(e => e.NameLast)
                .HasMaxLength(500)
                .HasColumnName("name_last");
            entity.Property(e => e.Note1)
                .HasMaxLength(500)
                .HasColumnName("note1");
            entity.Property(e => e.NumSeats).HasColumnName("num_seats");
            entity.Property(e => e.OrderLineItem).HasColumnName("order_line_item");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.PaymentPlan)
                .HasMaxLength(500)
                .HasColumnName("payment_plan");
            entity.Property(e => e.PhoneCell)
                .HasMaxLength(500)
                .HasColumnName("phone_cell");
            entity.Property(e => e.PhoneDay)
                .HasMaxLength(500)
                .HasColumnName("phone_day");
            entity.Property(e => e.PhoneEve)
                .HasMaxLength(500)
                .HasColumnName("phone_eve");
            entity.Property(e => e.PriceCode)
                .HasMaxLength(500)
                .HasColumnName("price_code");
            entity.Property(e => e.PriceCodeDesc)
                .HasMaxLength(500)
                .HasColumnName("price_code_desc");
            entity.Property(e => e.PriceCodeExtra)
                .HasMaxLength(500)
                .HasColumnName("price_code_extra");
            entity.Property(e => e.PriceCodeInfo1)
                .HasMaxLength(500)
                .HasColumnName("price_code_info1");
            entity.Property(e => e.PriceCodeInfo2)
                .HasMaxLength(500)
                .HasColumnName("price_code_info2");
            entity.Property(e => e.PriceCodeInfo3)
                .HasMaxLength(500)
                .HasColumnName("price_code_info3");
            entity.Property(e => e.PriceCodeInfo4)
                .HasMaxLength(500)
                .HasColumnName("price_code_info4");
            entity.Property(e => e.PrimaryName)
                .HasMaxLength(500)
                .HasColumnName("primary_name");
            entity.Property(e => e.PrintCount).HasColumnName("print_count");
            entity.Property(e => e.PrintDate)
                .HasColumnType("datetime")
                .HasColumnName("print_date");
            entity.Property(e => e.RowName)
                .HasMaxLength(500)
                .HasColumnName("row_name");
            entity.Property(e => e.SeatNum).HasColumnName("seat_num");
            entity.Property(e => e.SectionName)
                .HasMaxLength(500)
                .HasColumnName("section_name");
            entity.Property(e => e.State)
                .HasMaxLength(500)
                .HasColumnName("state");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("street_addr_1");
            entity.Property(e => e.StreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("street_addr_2");
            entity.Property(e => e.TicketTypeCategory)
                .HasMaxLength(500)
                .HasColumnName("ticket_type_category");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Venue1Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue1_aisle");
            entity.Property(e => e.Venue1Gate)
                .HasMaxLength(500)
                .HasColumnName("venue1_gate");
            entity.Property(e => e.Venue1Row)
                .HasMaxLength(500)
                .HasColumnName("venue1_row");
            entity.Property(e => e.Venue1Seat)
                .HasMaxLength(500)
                .HasColumnName("venue1_seat");
            entity.Property(e => e.Venue1Section)
                .HasMaxLength(500)
                .HasColumnName("venue1_section");
            entity.Property(e => e.Venue1Stand)
                .HasMaxLength(500)
                .HasColumnName("venue1_stand");
            entity.Property(e => e.Venue2Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue2_aisle");
            entity.Property(e => e.Venue2Gate)
                .HasMaxLength(500)
                .HasColumnName("venue2_gate");
            entity.Property(e => e.Venue2Row)
                .HasMaxLength(500)
                .HasColumnName("venue2_row");
            entity.Property(e => e.Venue2Seat)
                .HasMaxLength(500)
                .HasColumnName("venue2_seat");
            entity.Property(e => e.Venue2Section)
                .HasMaxLength(500)
                .HasColumnName("venue2_section");
            entity.Property(e => e.Venue2Stand)
                .HasMaxLength(500)
                .HasColumnName("venue2_stand");
            entity.Property(e => e.WlMemberSince).HasColumnName("wl_member_since");
            entity.Property(e => e.WlYearsMembership).HasColumnName("wl_years_membership");
            entity.Property(e => e.YearsMembership).HasColumnName("years_membership");
            entity.Property(e => e.Zip)
                .HasMaxLength(500)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<RawData12516202108090114155899>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_RawData_125_16_202108090114155889");

            entity.ToTable("RawData_125_16_202108090114155899");

            entity.Property(e => e.AcctId).HasColumnName("acct_id");
            entity.Property(e => e.AcctTypeDesc)
                .HasMaxLength(500)
                .HasColumnName("acct_type_desc");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Barcode)
                .HasMaxLength(500)
                .HasColumnName("barcode");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("birthdate");
            entity.Property(e => e.Card)
                .HasMaxLength(500)
                .HasColumnName("card");
            entity.Property(e => e.City)
                .HasMaxLength(500)
                .HasColumnName("city");
            entity.Property(e => e.ClubCode)
                .HasMaxLength(500)
                .HasColumnName("club_code");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(500)
                .HasColumnName("company_name");
            entity.Property(e => e.ConcessionText)
                .HasMaxLength(500)
                .HasColumnName("concession_text");
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .HasColumnName("country");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustNameId).HasColumnName("cust_name_id");
            entity.Property(e => e.DeliveryInstructions)
                .HasMaxLength(500)
                .HasColumnName("delivery_instructions");
            entity.Property(e => e.DeliveryMethodName)
                .HasMaxLength(500)
                .HasColumnName("delivery_method_name");
            entity.Property(e => e.EmailAddr)
                .HasMaxLength(500)
                .HasColumnName("email_addr");
            entity.Property(e => e.EventLine1)
                .HasMaxLength(500)
                .HasColumnName("event_line1");
            entity.Property(e => e.EventLine2)
                .HasMaxLength(500)
                .HasColumnName("event_line2");
            entity.Property(e => e.EventLine3)
                .HasMaxLength(500)
                .HasColumnName("event_line3");
            entity.Property(e => e.EventName)
                .HasMaxLength(500)
                .HasColumnName("event_name");
            entity.Property(e => e.FamilyId).HasColumnName("family_id");
            entity.Property(e => e.Fulfilment)
                .HasMaxLength(500)
                .HasColumnName("fulfilment");
            entity.Property(e => e.Gender)
                .HasMaxLength(500)
                .HasColumnName("gender");
            entity.Property(e => e.GroupCodes)
                .HasMaxLength(500)
                .HasColumnName("group_codes");
            entity.Property(e => e.LocationCity)
                .HasMaxLength(500)
                .HasColumnName("location_city");
            entity.Property(e => e.LocationCountry)
                .HasMaxLength(500)
                .HasColumnName("location_country");
            entity.Property(e => e.LocationState)
                .HasMaxLength(500)
                .HasColumnName("location_state");
            entity.Property(e => e.LocationStreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_1");
            entity.Property(e => e.LocationStreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_2");
            entity.Property(e => e.LocationZip)
                .HasMaxLength(500)
                .HasColumnName("location_zip");
            entity.Property(e => e.MemberId).HasColumnName("member_id");
            entity.Property(e => e.MemberSince).HasColumnName("member_since");
            entity.Property(e => e.MembershipType)
                .HasMaxLength(500)
                .HasColumnName("membership_type");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(500)
                .HasColumnName("middle_name");
            entity.Property(e => e.NameFirst)
                .HasMaxLength(500)
                .HasColumnName("name_first");
            entity.Property(e => e.NameLast)
                .HasMaxLength(500)
                .HasColumnName("name_last");
            entity.Property(e => e.Note1)
                .HasMaxLength(500)
                .HasColumnName("note1");
            entity.Property(e => e.NumSeats).HasColumnName("num_seats");
            entity.Property(e => e.OrderLineItem).HasColumnName("order_line_item");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.PaymentPlan)
                .HasMaxLength(500)
                .HasColumnName("payment_plan");
            entity.Property(e => e.PhoneCell)
                .HasMaxLength(500)
                .HasColumnName("phone_cell");
            entity.Property(e => e.PhoneDay)
                .HasMaxLength(500)
                .HasColumnName("phone_day");
            entity.Property(e => e.PhoneEve)
                .HasMaxLength(500)
                .HasColumnName("phone_eve");
            entity.Property(e => e.PriceCode)
                .HasMaxLength(500)
                .HasColumnName("price_code");
            entity.Property(e => e.PriceCodeDesc)
                .HasMaxLength(500)
                .HasColumnName("price_code_desc");
            entity.Property(e => e.PriceCodeExtra)
                .HasMaxLength(500)
                .HasColumnName("price_code_extra");
            entity.Property(e => e.PriceCodeInfo1)
                .HasMaxLength(500)
                .HasColumnName("price_code_info1");
            entity.Property(e => e.PriceCodeInfo2)
                .HasMaxLength(500)
                .HasColumnName("price_code_info2");
            entity.Property(e => e.PriceCodeInfo3)
                .HasMaxLength(500)
                .HasColumnName("price_code_info3");
            entity.Property(e => e.PriceCodeInfo4)
                .HasMaxLength(500)
                .HasColumnName("price_code_info4");
            entity.Property(e => e.PrimaryName)
                .HasMaxLength(500)
                .HasColumnName("primary_name");
            entity.Property(e => e.PrintCount).HasColumnName("print_count");
            entity.Property(e => e.PrintDate)
                .HasColumnType("datetime")
                .HasColumnName("print_date");
            entity.Property(e => e.RowName)
                .HasMaxLength(500)
                .HasColumnName("row_name");
            entity.Property(e => e.SeatNum).HasColumnName("seat_num");
            entity.Property(e => e.SectionName)
                .HasMaxLength(500)
                .HasColumnName("section_name");
            entity.Property(e => e.State)
                .HasMaxLength(500)
                .HasColumnName("state");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("street_addr_1");
            entity.Property(e => e.StreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("street_addr_2");
            entity.Property(e => e.TicketTypeCategory)
                .HasMaxLength(500)
                .HasColumnName("ticket_type_category");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Venue1Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue1_aisle");
            entity.Property(e => e.Venue1Gate)
                .HasMaxLength(500)
                .HasColumnName("venue1_gate");
            entity.Property(e => e.Venue1Row)
                .HasMaxLength(500)
                .HasColumnName("venue1_row");
            entity.Property(e => e.Venue1Seat)
                .HasMaxLength(500)
                .HasColumnName("venue1_seat");
            entity.Property(e => e.Venue1Section)
                .HasMaxLength(500)
                .HasColumnName("venue1_section");
            entity.Property(e => e.Venue1Stand)
                .HasMaxLength(500)
                .HasColumnName("venue1_stand");
            entity.Property(e => e.Venue2Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue2_aisle");
            entity.Property(e => e.Venue2Gate)
                .HasMaxLength(500)
                .HasColumnName("venue2_gate");
            entity.Property(e => e.Venue2Row)
                .HasMaxLength(500)
                .HasColumnName("venue2_row");
            entity.Property(e => e.Venue2Seat)
                .HasMaxLength(500)
                .HasColumnName("venue2_seat");
            entity.Property(e => e.Venue2Section)
                .HasMaxLength(500)
                .HasColumnName("venue2_section");
            entity.Property(e => e.Venue2Stand)
                .HasMaxLength(500)
                .HasColumnName("venue2_stand");
            entity.Property(e => e.WlMemberSince).HasColumnName("wl_member_since");
            entity.Property(e => e.WlYearsMembership).HasColumnName("wl_years_membership");
            entity.Property(e => e.YearsMembership).HasColumnName("years_membership");
            entity.Property(e => e.Zip)
                .HasMaxLength(500)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<RawData125162021080901141558991>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_RawData_125_16_202108090114155899");

            entity.ToTable("RawData_125_16_202108090114155899_");

            entity.Property(e => e.AcctId).HasColumnName("acct_id");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.MemberId)
                .HasMaxLength(500)
                .HasColumnName("member_id");
            entity.Property(e => e.OrderLineItem)
                .HasMaxLength(500)
                .HasColumnName("order_line_item");
            entity.Property(e => e.OrderNum)
                .HasMaxLength(500)
                .HasColumnName("order_num");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<RawData12516202108090246598409>(entity =>
        {
            entity.ToTable("RawData_125_16_202108090246598409");

            entity.Property(e => e.AcctId).HasColumnName("acct_id");
            entity.Property(e => e.AcctTypeDesc)
                .HasMaxLength(500)
                .HasColumnName("acct_type_desc");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Barcode)
                .HasMaxLength(500)
                .HasColumnName("barcode");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("birthdate");
            entity.Property(e => e.Card)
                .HasMaxLength(500)
                .HasColumnName("card");
            entity.Property(e => e.City)
                .HasMaxLength(500)
                .HasColumnName("city");
            entity.Property(e => e.ClubCode)
                .HasMaxLength(500)
                .HasColumnName("club_code");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(500)
                .HasColumnName("company_name");
            entity.Property(e => e.ConcessionText)
                .HasMaxLength(500)
                .HasColumnName("concession_text");
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .HasColumnName("country");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustNameId)
                .HasMaxLength(500)
                .HasColumnName("cust_name_id");
            entity.Property(e => e.DeliveryInstructions)
                .HasMaxLength(500)
                .HasColumnName("delivery_instructions");
            entity.Property(e => e.DeliveryMethodName)
                .HasMaxLength(500)
                .HasColumnName("delivery_method_name");
            entity.Property(e => e.EmailAddr)
                .HasMaxLength(500)
                .HasColumnName("email_addr");
            entity.Property(e => e.EventLine1)
                .HasMaxLength(500)
                .HasColumnName("event_line1");
            entity.Property(e => e.EventLine2)
                .HasMaxLength(500)
                .HasColumnName("event_line2");
            entity.Property(e => e.EventLine3)
                .HasMaxLength(500)
                .HasColumnName("event_line3");
            entity.Property(e => e.EventName)
                .HasMaxLength(500)
                .HasColumnName("event_name");
            entity.Property(e => e.FamilyId).HasColumnName("family_id");
            entity.Property(e => e.Fulfilment)
                .HasMaxLength(500)
                .HasColumnName("fulfilment");
            entity.Property(e => e.Gender)
                .HasMaxLength(500)
                .HasColumnName("gender");
            entity.Property(e => e.GroupCodes)
                .HasMaxLength(500)
                .HasColumnName("group_codes");
            entity.Property(e => e.LocationCity)
                .HasMaxLength(500)
                .HasColumnName("location_city");
            entity.Property(e => e.LocationCountry)
                .HasMaxLength(500)
                .HasColumnName("location_country");
            entity.Property(e => e.LocationState)
                .HasMaxLength(500)
                .HasColumnName("location_state");
            entity.Property(e => e.LocationStreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_1");
            entity.Property(e => e.LocationStreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_2");
            entity.Property(e => e.LocationZip)
                .HasMaxLength(500)
                .HasColumnName("location_zip");
            entity.Property(e => e.MemberId).HasColumnName("member_id");
            entity.Property(e => e.MemberSince).HasColumnName("member_since");
            entity.Property(e => e.MembershipType)
                .HasMaxLength(500)
                .HasColumnName("membership_type");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(500)
                .HasColumnName("middle_name");
            entity.Property(e => e.NameFirst)
                .HasMaxLength(500)
                .HasColumnName("name_first");
            entity.Property(e => e.NameLast)
                .HasMaxLength(500)
                .HasColumnName("name_last");
            entity.Property(e => e.Note1)
                .HasMaxLength(500)
                .HasColumnName("note1");
            entity.Property(e => e.NumSeats).HasColumnName("num_seats");
            entity.Property(e => e.OrderLineItem).HasColumnName("order_line_item");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.PaymentPlan)
                .HasMaxLength(500)
                .HasColumnName("payment_plan");
            entity.Property(e => e.PhoneCell)
                .HasMaxLength(500)
                .HasColumnName("phone_cell");
            entity.Property(e => e.PhoneDay)
                .HasMaxLength(500)
                .HasColumnName("phone_day");
            entity.Property(e => e.PhoneEve)
                .HasMaxLength(500)
                .HasColumnName("phone_eve");
            entity.Property(e => e.PriceCode)
                .HasMaxLength(500)
                .HasColumnName("price_code");
            entity.Property(e => e.PriceCodeDesc)
                .HasMaxLength(500)
                .HasColumnName("price_code_desc");
            entity.Property(e => e.PriceCodeExtra)
                .HasMaxLength(500)
                .HasColumnName("price_code_extra");
            entity.Property(e => e.PriceCodeInfo1)
                .HasMaxLength(500)
                .HasColumnName("price_code_info1");
            entity.Property(e => e.PriceCodeInfo2)
                .HasMaxLength(500)
                .HasColumnName("price_code_info2");
            entity.Property(e => e.PriceCodeInfo3)
                .HasMaxLength(500)
                .HasColumnName("price_code_info3");
            entity.Property(e => e.PriceCodeInfo4)
                .HasMaxLength(500)
                .HasColumnName("price_code_info4");
            entity.Property(e => e.PrimaryName)
                .HasMaxLength(500)
                .HasColumnName("primary_name");
            entity.Property(e => e.PrintCount).HasColumnName("print_count");
            entity.Property(e => e.PrintDate)
                .HasColumnType("datetime")
                .HasColumnName("print_date");
            entity.Property(e => e.RowName)
                .HasMaxLength(500)
                .HasColumnName("row_name");
            entity.Property(e => e.SeatNum).HasColumnName("seat_num");
            entity.Property(e => e.SectionName)
                .HasMaxLength(500)
                .HasColumnName("section_name");
            entity.Property(e => e.State)
                .HasMaxLength(500)
                .HasColumnName("state");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("street_addr_1");
            entity.Property(e => e.StreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("street_addr_2");
            entity.Property(e => e.Test1).HasColumnName("test1");
            entity.Property(e => e.TicketTypeCategory)
                .HasMaxLength(500)
                .HasColumnName("ticket_type_category");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Venue1Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue1_aisle");
            entity.Property(e => e.Venue1Gate)
                .HasMaxLength(500)
                .HasColumnName("venue1_gate");
            entity.Property(e => e.Venue1Row)
                .HasMaxLength(500)
                .HasColumnName("venue1_row");
            entity.Property(e => e.Venue1Seat)
                .HasMaxLength(500)
                .HasColumnName("venue1_seat");
            entity.Property(e => e.Venue1Section)
                .HasMaxLength(500)
                .HasColumnName("venue1_section");
            entity.Property(e => e.Venue1Stand)
                .HasMaxLength(500)
                .HasColumnName("venue1_stand");
            entity.Property(e => e.Venue2Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue2_aisle");
            entity.Property(e => e.Venue2Gate)
                .HasMaxLength(500)
                .HasColumnName("venue2_gate");
            entity.Property(e => e.Venue2Row)
                .HasMaxLength(500)
                .HasColumnName("venue2_row");
            entity.Property(e => e.Venue2Seat)
                .HasMaxLength(500)
                .HasColumnName("venue2_seat");
            entity.Property(e => e.Venue2Section)
                .HasMaxLength(500)
                .HasColumnName("venue2_section");
            entity.Property(e => e.Venue2Stand)
                .HasMaxLength(500)
                .HasColumnName("venue2_stand");
            entity.Property(e => e.WlMemberSince).HasColumnName("wl_member_since");
            entity.Property(e => e.WlYearsMembership).HasColumnName("wl_years_membership");
            entity.Property(e => e.YearsMembership).HasColumnName("years_membership");
            entity.Property(e => e.Zip)
                .HasMaxLength(500)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<RawData12516202108090639445685>(entity =>
        {
            entity.ToTable("RawData_125_16_202108090639445685");

            entity.Property(e => e.AcctId).HasColumnName("acct_id");
            entity.Property(e => e.AcctTypeDesc)
                .HasMaxLength(500)
                .HasColumnName("acct_type_desc");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Barcode)
                .HasMaxLength(500)
                .HasColumnName("barcode");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("birthdate");
            entity.Property(e => e.Card)
                .HasMaxLength(500)
                .HasColumnName("card");
            entity.Property(e => e.City)
                .HasMaxLength(500)
                .HasColumnName("city");
            entity.Property(e => e.ClubCode)
                .HasMaxLength(500)
                .HasColumnName("club_code");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(500)
                .HasColumnName("company_name");
            entity.Property(e => e.ConcessionText)
                .HasMaxLength(500)
                .HasColumnName("concession_text");
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .HasColumnName("country");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustNameId).HasColumnName("cust_name_id");
            entity.Property(e => e.DeliveryInstructions)
                .HasMaxLength(500)
                .HasColumnName("delivery_instructions");
            entity.Property(e => e.DeliveryMethodName)
                .HasMaxLength(500)
                .HasColumnName("delivery_method_name");
            entity.Property(e => e.EmailAddr)
                .HasMaxLength(500)
                .HasColumnName("email_addr");
            entity.Property(e => e.EventLine1)
                .HasMaxLength(500)
                .HasColumnName("event_line1");
            entity.Property(e => e.EventLine2)
                .HasMaxLength(500)
                .HasColumnName("event_line2");
            entity.Property(e => e.EventLine3)
                .HasMaxLength(500)
                .HasColumnName("event_line3");
            entity.Property(e => e.EventName)
                .HasMaxLength(500)
                .HasColumnName("event_name");
            entity.Property(e => e.FamilyId).HasColumnName("family_id");
            entity.Property(e => e.Fulfilment)
                .HasMaxLength(500)
                .HasColumnName("fulfilment");
            entity.Property(e => e.Gender)
                .HasMaxLength(500)
                .HasColumnName("gender");
            entity.Property(e => e.GroupCodes)
                .HasMaxLength(500)
                .HasColumnName("group_codes");
            entity.Property(e => e.LocationCity)
                .HasMaxLength(500)
                .HasColumnName("location_city");
            entity.Property(e => e.LocationCountry)
                .HasMaxLength(500)
                .HasColumnName("location_country");
            entity.Property(e => e.LocationState)
                .HasMaxLength(500)
                .HasColumnName("location_state");
            entity.Property(e => e.LocationStreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_1");
            entity.Property(e => e.LocationStreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_2");
            entity.Property(e => e.LocationZip)
                .HasMaxLength(500)
                .HasColumnName("location_zip");
            entity.Property(e => e.MemberId).HasColumnName("member_id");
            entity.Property(e => e.MemberSince).HasColumnName("member_since");
            entity.Property(e => e.MembershipType)
                .HasMaxLength(500)
                .HasColumnName("membership_type");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(500)
                .HasColumnName("middle_name");
            entity.Property(e => e.NameFirst)
                .HasMaxLength(500)
                .HasColumnName("name_first");
            entity.Property(e => e.NameLast)
                .HasMaxLength(500)
                .HasColumnName("name_last");
            entity.Property(e => e.Note1)
                .HasMaxLength(500)
                .HasColumnName("note1");
            entity.Property(e => e.NumSeats).HasColumnName("num_seats");
            entity.Property(e => e.OrderLineItem).HasColumnName("order_line_item");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.PaymentPlan)
                .HasMaxLength(500)
                .HasColumnName("payment_plan");
            entity.Property(e => e.PhoneCell)
                .HasMaxLength(500)
                .HasColumnName("phone_cell");
            entity.Property(e => e.PhoneDay)
                .HasMaxLength(500)
                .HasColumnName("phone_day");
            entity.Property(e => e.PhoneEve)
                .HasMaxLength(500)
                .HasColumnName("phone_eve");
            entity.Property(e => e.PriceCode)
                .HasMaxLength(500)
                .HasColumnName("price_code");
            entity.Property(e => e.PriceCodeDesc)
                .HasMaxLength(500)
                .HasColumnName("price_code_desc");
            entity.Property(e => e.PriceCodeExtra)
                .HasMaxLength(500)
                .HasColumnName("price_code_extra");
            entity.Property(e => e.PriceCodeInfo1)
                .HasMaxLength(500)
                .HasColumnName("price_code_info1");
            entity.Property(e => e.PriceCodeInfo2)
                .HasMaxLength(500)
                .HasColumnName("price_code_info2");
            entity.Property(e => e.PriceCodeInfo3)
                .HasMaxLength(500)
                .HasColumnName("price_code_info3");
            entity.Property(e => e.PriceCodeInfo4)
                .HasMaxLength(500)
                .HasColumnName("price_code_info4");
            entity.Property(e => e.PrimaryName)
                .HasMaxLength(500)
                .HasColumnName("primary_name");
            entity.Property(e => e.PrintCount).HasColumnName("print_count");
            entity.Property(e => e.PrintDate)
                .HasColumnType("datetime")
                .HasColumnName("print_date");
            entity.Property(e => e.RowName)
                .HasMaxLength(500)
                .HasColumnName("row_name");
            entity.Property(e => e.SeatNum).HasColumnName("seat_num");
            entity.Property(e => e.SectionName)
                .HasMaxLength(500)
                .HasColumnName("section_name");
            entity.Property(e => e.State)
                .HasMaxLength(500)
                .HasColumnName("state");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("street_addr_1");
            entity.Property(e => e.StreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("street_addr_2");
            entity.Property(e => e.Test1).HasColumnName("test1");
            entity.Property(e => e.Test2).HasColumnName("test2");
            entity.Property(e => e.TicketTypeCategory)
                .HasMaxLength(500)
                .HasColumnName("ticket_type_category");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Venue1Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue1_aisle");
            entity.Property(e => e.Venue1Gate)
                .HasMaxLength(500)
                .HasColumnName("venue1_gate");
            entity.Property(e => e.Venue1Row)
                .HasMaxLength(500)
                .HasColumnName("venue1_row");
            entity.Property(e => e.Venue1Seat)
                .HasMaxLength(500)
                .HasColumnName("venue1_seat");
            entity.Property(e => e.Venue1Section)
                .HasMaxLength(500)
                .HasColumnName("venue1_section");
            entity.Property(e => e.Venue1Stand)
                .HasMaxLength(500)
                .HasColumnName("venue1_stand");
            entity.Property(e => e.Venue2Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue2_aisle");
            entity.Property(e => e.Venue2Gate)
                .HasMaxLength(500)
                .HasColumnName("venue2_gate");
            entity.Property(e => e.Venue2Row)
                .HasMaxLength(500)
                .HasColumnName("venue2_row");
            entity.Property(e => e.Venue2Seat)
                .HasMaxLength(500)
                .HasColumnName("venue2_seat");
            entity.Property(e => e.Venue2Section)
                .HasMaxLength(500)
                .HasColumnName("venue2_section");
            entity.Property(e => e.Venue2Stand)
                .HasMaxLength(500)
                .HasColumnName("venue2_stand");
            entity.Property(e => e.WlMemberSince).HasColumnName("wl_member_since");
            entity.Property(e => e.WlYearsMembership).HasColumnName("wl_years_membership");
            entity.Property(e => e.YearsMembership).HasColumnName("years_membership");
            entity.Property(e => e.Zip)
                .HasMaxLength(500)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<RawData12516202108100211337631>(entity =>
        {
            entity.ToTable("RawData_125_16_202108100211337631");

            entity.Property(e => e.AcctId).HasColumnName("acct_id");
            entity.Property(e => e.AcctTypeDesc)
                .HasMaxLength(500)
                .HasColumnName("acct_type_desc");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Barcode)
                .HasMaxLength(500)
                .HasColumnName("barcode");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("birthdate");
            entity.Property(e => e.Card)
                .HasMaxLength(500)
                .HasColumnName("card");
            entity.Property(e => e.City)
                .HasMaxLength(500)
                .HasColumnName("city");
            entity.Property(e => e.ClubCode)
                .HasMaxLength(500)
                .HasColumnName("club_code");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(500)
                .HasColumnName("company_name");
            entity.Property(e => e.ConcessionText)
                .HasMaxLength(500)
                .HasColumnName("concession_text");
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .HasColumnName("country");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustNameId).HasColumnName("cust_name_id");
            entity.Property(e => e.DeliveryInstructions)
                .HasMaxLength(500)
                .HasColumnName("delivery_instructions");
            entity.Property(e => e.DeliveryMethodName)
                .HasMaxLength(500)
                .HasColumnName("delivery_method_name");
            entity.Property(e => e.EmailAddr)
                .HasMaxLength(500)
                .HasColumnName("email_addr");
            entity.Property(e => e.EventLine1)
                .HasMaxLength(500)
                .HasColumnName("event_line1");
            entity.Property(e => e.EventLine2)
                .HasMaxLength(500)
                .HasColumnName("event_line2");
            entity.Property(e => e.EventLine3)
                .HasMaxLength(500)
                .HasColumnName("event_line3");
            entity.Property(e => e.EventName)
                .HasMaxLength(500)
                .HasColumnName("event_name");
            entity.Property(e => e.FamilyId).HasColumnName("family_id");
            entity.Property(e => e.Fulfilment)
                .HasMaxLength(500)
                .HasColumnName("fulfilment");
            entity.Property(e => e.Gender)
                .HasMaxLength(500)
                .HasColumnName("gender");
            entity.Property(e => e.GroupCodes)
                .HasMaxLength(500)
                .HasColumnName("group_codes");
            entity.Property(e => e.LocationCity)
                .HasMaxLength(500)
                .HasColumnName("location_city");
            entity.Property(e => e.LocationCountry)
                .HasMaxLength(500)
                .HasColumnName("location_country");
            entity.Property(e => e.LocationState)
                .HasMaxLength(500)
                .HasColumnName("location_state");
            entity.Property(e => e.LocationStreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_1");
            entity.Property(e => e.LocationStreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_2");
            entity.Property(e => e.LocationZip)
                .HasMaxLength(500)
                .HasColumnName("location_zip");
            entity.Property(e => e.MemberId).HasColumnName("member_id");
            entity.Property(e => e.MemberSince).HasColumnName("member_since");
            entity.Property(e => e.MembershipType)
                .HasMaxLength(500)
                .HasColumnName("membership_type");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(500)
                .HasColumnName("middle_name");
            entity.Property(e => e.NameFirst)
                .HasMaxLength(500)
                .HasColumnName("name_first");
            entity.Property(e => e.NameLast)
                .HasMaxLength(500)
                .HasColumnName("name_last");
            entity.Property(e => e.Note1)
                .HasMaxLength(500)
                .HasColumnName("note1");
            entity.Property(e => e.NumSeats).HasColumnName("num_seats");
            entity.Property(e => e.OrderLineItem).HasColumnName("order_line_item");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.PaymentPlan)
                .HasMaxLength(500)
                .HasColumnName("payment_plan");
            entity.Property(e => e.PhoneCell)
                .HasMaxLength(500)
                .HasColumnName("phone_cell");
            entity.Property(e => e.PhoneDay)
                .HasMaxLength(500)
                .HasColumnName("phone_day");
            entity.Property(e => e.PhoneEve)
                .HasMaxLength(500)
                .HasColumnName("phone_eve");
            entity.Property(e => e.PriceCode)
                .HasMaxLength(500)
                .HasColumnName("price_code");
            entity.Property(e => e.PriceCodeDesc)
                .HasMaxLength(500)
                .HasColumnName("price_code_desc");
            entity.Property(e => e.PriceCodeExtra)
                .HasMaxLength(500)
                .HasColumnName("price_code_extra");
            entity.Property(e => e.PriceCodeInfo1)
                .HasMaxLength(500)
                .HasColumnName("price_code_info1");
            entity.Property(e => e.PriceCodeInfo2)
                .HasMaxLength(500)
                .HasColumnName("price_code_info2");
            entity.Property(e => e.PriceCodeInfo3)
                .HasMaxLength(500)
                .HasColumnName("price_code_info3");
            entity.Property(e => e.PriceCodeInfo4)
                .HasMaxLength(500)
                .HasColumnName("price_code_info4");
            entity.Property(e => e.PrimaryName)
                .HasMaxLength(500)
                .HasColumnName("primary_name");
            entity.Property(e => e.PrintCount).HasColumnName("print_count");
            entity.Property(e => e.PrintDate)
                .HasColumnType("datetime")
                .HasColumnName("print_date");
            entity.Property(e => e.RowName)
                .HasMaxLength(500)
                .HasColumnName("row_name");
            entity.Property(e => e.SeatNum).HasColumnName("seat_num");
            entity.Property(e => e.SectionName)
                .HasMaxLength(500)
                .HasColumnName("section_name");
            entity.Property(e => e.State)
                .HasMaxLength(500)
                .HasColumnName("state");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("street_addr_1");
            entity.Property(e => e.StreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("street_addr_2");
            entity.Property(e => e.Test2).HasColumnName("test2");
            entity.Property(e => e.TicketTypeCategory)
                .HasMaxLength(500)
                .HasColumnName("ticket_type_category");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Venue1Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue1_aisle");
            entity.Property(e => e.Venue1Gate)
                .HasMaxLength(500)
                .HasColumnName("venue1_gate");
            entity.Property(e => e.Venue1Row)
                .HasMaxLength(500)
                .HasColumnName("venue1_row");
            entity.Property(e => e.Venue1Seat)
                .HasMaxLength(500)
                .HasColumnName("venue1_seat");
            entity.Property(e => e.Venue1Section)
                .HasMaxLength(500)
                .HasColumnName("venue1_section");
            entity.Property(e => e.Venue1Stand)
                .HasMaxLength(500)
                .HasColumnName("venue1_stand");
            entity.Property(e => e.Venue2Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue2_aisle");
            entity.Property(e => e.Venue2Gate)
                .HasMaxLength(500)
                .HasColumnName("venue2_gate");
            entity.Property(e => e.Venue2Row)
                .HasMaxLength(500)
                .HasColumnName("venue2_row");
            entity.Property(e => e.Venue2Seat)
                .HasMaxLength(500)
                .HasColumnName("venue2_seat");
            entity.Property(e => e.Venue2Section)
                .HasMaxLength(500)
                .HasColumnName("venue2_section");
            entity.Property(e => e.Venue2Stand)
                .HasMaxLength(500)
                .HasColumnName("venue2_stand");
            entity.Property(e => e.WlMemberSince).HasColumnName("wl_member_since");
            entity.Property(e => e.WlYearsMembership).HasColumnName("wl_years_membership");
            entity.Property(e => e.YearsMembership).HasColumnName("years_membership");
            entity.Property(e => e.Zip)
                .HasMaxLength(500)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<RawData13718202110120309486716>(entity =>
        {
            entity.ToTable("RawData_137_18_202110120309486716");

            entity.Property(e => e.AcctId).HasColumnName("acct_id");
            entity.Property(e => e.AcctTypeDesc)
                .HasMaxLength(500)
                .HasColumnName("acct_type_desc");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Barcode)
                .HasMaxLength(500)
                .HasColumnName("barcode");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("birthdate");
            entity.Property(e => e.Card)
                .HasMaxLength(500)
                .HasColumnName("card");
            entity.Property(e => e.City)
                .HasMaxLength(500)
                .HasColumnName("city");
            entity.Property(e => e.ClubCode)
                .HasMaxLength(500)
                .HasColumnName("club_code");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(500)
                .HasColumnName("company_name");
            entity.Property(e => e.ConcessionText)
                .HasMaxLength(500)
                .HasColumnName("concession_text");
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .HasColumnName("country");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustNameId).HasColumnName("cust_name_id");
            entity.Property(e => e.DeliveryInstructions)
                .HasMaxLength(500)
                .HasColumnName("delivery_instructions");
            entity.Property(e => e.DeliveryMethodName)
                .HasMaxLength(500)
                .HasColumnName("delivery_method_name");
            entity.Property(e => e.EmailAddr)
                .HasMaxLength(500)
                .HasColumnName("email_addr");
            entity.Property(e => e.EventLine1)
                .HasMaxLength(500)
                .HasColumnName("event_line1");
            entity.Property(e => e.EventLine2)
                .HasMaxLength(500)
                .HasColumnName("event_line2");
            entity.Property(e => e.EventLine3)
                .HasMaxLength(500)
                .HasColumnName("event_line3");
            entity.Property(e => e.EventName)
                .HasMaxLength(500)
                .HasColumnName("event_name");
            entity.Property(e => e.FamilyId).HasColumnName("family_id");
            entity.Property(e => e.Fulfilment)
                .HasMaxLength(500)
                .HasColumnName("fulfilment");
            entity.Property(e => e.Gender)
                .HasMaxLength(500)
                .HasColumnName("gender");
            entity.Property(e => e.GroupCodes)
                .HasMaxLength(500)
                .HasColumnName("group_codes");
            entity.Property(e => e.LocationCity)
                .HasMaxLength(500)
                .HasColumnName("location_city");
            entity.Property(e => e.LocationCountry)
                .HasMaxLength(500)
                .HasColumnName("location_country");
            entity.Property(e => e.LocationState)
                .HasMaxLength(500)
                .HasColumnName("location_state");
            entity.Property(e => e.LocationStreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_1");
            entity.Property(e => e.LocationStreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_2");
            entity.Property(e => e.LocationZip)
                .HasMaxLength(500)
                .HasColumnName("location_zip");
            entity.Property(e => e.MemberId).HasColumnName("member_id");
            entity.Property(e => e.MemberSince).HasColumnName("member_since");
            entity.Property(e => e.MembershipType)
                .HasMaxLength(500)
                .HasColumnName("membership_type");
            entity.Property(e => e.NameFirst)
                .HasMaxLength(500)
                .HasColumnName("name_first");
            entity.Property(e => e.NameLast)
                .HasMaxLength(500)
                .HasColumnName("name_last");
            entity.Property(e => e.Note1)
                .HasMaxLength(500)
                .HasColumnName("note1");
            entity.Property(e => e.NumSeats).HasColumnName("num_seats");
            entity.Property(e => e.OrderLineItem).HasColumnName("order_line_item");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.PaymentPlan)
                .HasMaxLength(500)
                .HasColumnName("payment_plan");
            entity.Property(e => e.PhoneCell)
                .HasMaxLength(500)
                .HasColumnName("phone_cell");
            entity.Property(e => e.PhoneDay)
                .HasMaxLength(500)
                .HasColumnName("phone_day");
            entity.Property(e => e.PhoneEve)
                .HasMaxLength(500)
                .HasColumnName("phone_eve");
            entity.Property(e => e.PriceCode)
                .HasMaxLength(500)
                .HasColumnName("price_code");
            entity.Property(e => e.PriceCodeDesc)
                .HasMaxLength(500)
                .HasColumnName("price_code_desc");
            entity.Property(e => e.PriceCodeExtra)
                .HasMaxLength(500)
                .HasColumnName("price_code_extra");
            entity.Property(e => e.PriceCodeInfo1)
                .HasMaxLength(500)
                .HasColumnName("price_code_info1");
            entity.Property(e => e.PriceCodeInfo2)
                .HasMaxLength(500)
                .HasColumnName("price_code_info2");
            entity.Property(e => e.PriceCodeInfo3)
                .HasMaxLength(500)
                .HasColumnName("price_code_info3");
            entity.Property(e => e.PriceCodeInfo4)
                .HasMaxLength(500)
                .HasColumnName("price_code_info4");
            entity.Property(e => e.PrimaryName)
                .HasMaxLength(500)
                .HasColumnName("primary_name");
            entity.Property(e => e.PrintCount).HasColumnName("print_count");
            entity.Property(e => e.PrintDate)
                .HasColumnType("datetime")
                .HasColumnName("print_date");
            entity.Property(e => e.RowName)
                .HasMaxLength(500)
                .HasColumnName("row_name");
            entity.Property(e => e.SeatNum).HasColumnName("seat_num");
            entity.Property(e => e.SectionName)
                .HasMaxLength(500)
                .HasColumnName("section_name");
            entity.Property(e => e.State)
                .HasMaxLength(500)
                .HasColumnName("state");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("street_addr_1");
            entity.Property(e => e.StreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("street_addr_2");
            entity.Property(e => e.TicketTypeCategory)
                .HasMaxLength(500)
                .HasColumnName("ticket_type_category");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Venue1Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue1_aisle");
            entity.Property(e => e.Venue1Gate)
                .HasMaxLength(500)
                .HasColumnName("venue1_gate");
            entity.Property(e => e.Venue1Row)
                .HasMaxLength(500)
                .HasColumnName("venue1_row");
            entity.Property(e => e.Venue1Seat)
                .HasMaxLength(500)
                .HasColumnName("venue1_seat");
            entity.Property(e => e.Venue1Section)
                .HasMaxLength(500)
                .HasColumnName("venue1_section");
            entity.Property(e => e.Venue1Stand)
                .HasMaxLength(500)
                .HasColumnName("venue1_stand");
            entity.Property(e => e.Venue2Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue2_aisle");
            entity.Property(e => e.Venue2Gate)
                .HasMaxLength(500)
                .HasColumnName("venue2_gate");
            entity.Property(e => e.Venue2Row)
                .HasMaxLength(500)
                .HasColumnName("venue2_row");
            entity.Property(e => e.Venue2Seat)
                .HasMaxLength(500)
                .HasColumnName("venue2_seat");
            entity.Property(e => e.Venue2Section)
                .HasMaxLength(500)
                .HasColumnName("venue2_section");
            entity.Property(e => e.Venue2Stand)
                .HasMaxLength(500)
                .HasColumnName("venue2_stand");
            entity.Property(e => e.YearsMembership).HasColumnName("years_membership");
            entity.Property(e => e.Zip)
                .HasMaxLength(500)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<RawData13718202110200140191035>(entity =>
        {
            entity.ToTable("RawData_137_18_202110200140191035");

            entity.Property(e => e.AcctId).HasColumnName("acct_id");
            entity.Property(e => e.AcctTypeDesc)
                .HasMaxLength(500)
                .HasColumnName("acct_type_desc");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Barcode)
                .HasMaxLength(500)
                .HasColumnName("barcode");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("birthdate");
            entity.Property(e => e.Card)
                .HasMaxLength(500)
                .HasColumnName("card");
            entity.Property(e => e.City)
                .HasMaxLength(500)
                .HasColumnName("city");
            entity.Property(e => e.ClubCode)
                .HasMaxLength(500)
                .HasColumnName("club_code");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(500)
                .HasColumnName("company_name");
            entity.Property(e => e.ConcessionText)
                .HasMaxLength(500)
                .HasColumnName("concession_text");
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .HasColumnName("country");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustNameId).HasColumnName("cust_name_id");
            entity.Property(e => e.DeliveryInstructions)
                .HasMaxLength(500)
                .HasColumnName("delivery_instructions");
            entity.Property(e => e.DeliveryMethodName)
                .HasMaxLength(500)
                .HasColumnName("delivery_method_name");
            entity.Property(e => e.EmailAddr)
                .HasMaxLength(500)
                .HasColumnName("email_addr");
            entity.Property(e => e.EventLine1)
                .HasMaxLength(500)
                .HasColumnName("event_line1");
            entity.Property(e => e.EventLine2)
                .HasMaxLength(500)
                .HasColumnName("event_line2");
            entity.Property(e => e.EventLine3)
                .HasMaxLength(500)
                .HasColumnName("event_line3");
            entity.Property(e => e.EventName)
                .HasMaxLength(500)
                .HasColumnName("event_name");
            entity.Property(e => e.FamilyId).HasColumnName("family_id");
            entity.Property(e => e.Fulfilment)
                .HasMaxLength(500)
                .HasColumnName("fulfilment");
            entity.Property(e => e.Gender)
                .HasMaxLength(500)
                .HasColumnName("gender");
            entity.Property(e => e.GroupCodes)
                .HasMaxLength(500)
                .HasColumnName("group_codes");
            entity.Property(e => e.LocationCity)
                .HasMaxLength(500)
                .HasColumnName("location_city");
            entity.Property(e => e.LocationCountry)
                .HasMaxLength(500)
                .HasColumnName("location_country");
            entity.Property(e => e.LocationState)
                .HasMaxLength(500)
                .HasColumnName("location_state");
            entity.Property(e => e.LocationStreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_1");
            entity.Property(e => e.LocationStreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_2");
            entity.Property(e => e.LocationZip)
                .HasMaxLength(500)
                .HasColumnName("location_zip");
            entity.Property(e => e.MemberId).HasColumnName("member_id");
            entity.Property(e => e.MemberSince).HasColumnName("member_since");
            entity.Property(e => e.MembershipType)
                .HasMaxLength(500)
                .HasColumnName("membership_type");
            entity.Property(e => e.NameFirst)
                .HasMaxLength(500)
                .HasColumnName("name_first");
            entity.Property(e => e.NameLast)
                .HasMaxLength(500)
                .HasColumnName("name_last");
            entity.Property(e => e.Note1)
                .HasMaxLength(500)
                .HasColumnName("note1");
            entity.Property(e => e.NumSeats).HasColumnName("num_seats");
            entity.Property(e => e.OrderLineItem).HasColumnName("order_line_item");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.PaymentPlan)
                .HasMaxLength(500)
                .HasColumnName("payment_plan");
            entity.Property(e => e.PhoneCell)
                .HasMaxLength(500)
                .HasColumnName("phone_cell");
            entity.Property(e => e.PhoneDay)
                .HasMaxLength(500)
                .HasColumnName("phone_day");
            entity.Property(e => e.PhoneEve)
                .HasMaxLength(500)
                .HasColumnName("phone_eve");
            entity.Property(e => e.PriceCode)
                .HasMaxLength(500)
                .HasColumnName("price_code");
            entity.Property(e => e.PriceCodeDesc)
                .HasMaxLength(500)
                .HasColumnName("price_code_desc");
            entity.Property(e => e.PriceCodeExtra)
                .HasMaxLength(500)
                .HasColumnName("price_code_extra");
            entity.Property(e => e.PriceCodeInfo1)
                .HasMaxLength(500)
                .HasColumnName("price_code_info1");
            entity.Property(e => e.PriceCodeInfo2)
                .HasMaxLength(500)
                .HasColumnName("price_code_info2");
            entity.Property(e => e.PriceCodeInfo3)
                .HasMaxLength(500)
                .HasColumnName("price_code_info3");
            entity.Property(e => e.PriceCodeInfo4)
                .HasMaxLength(500)
                .HasColumnName("price_code_info4");
            entity.Property(e => e.PrimaryName)
                .HasMaxLength(500)
                .HasColumnName("primary_name");
            entity.Property(e => e.PrintCount).HasColumnName("print_count");
            entity.Property(e => e.PrintDate)
                .HasColumnType("datetime")
                .HasColumnName("print_date");
            entity.Property(e => e.RowName)
                .HasMaxLength(500)
                .HasColumnName("row_name");
            entity.Property(e => e.SeatNum).HasColumnName("seat_num");
            entity.Property(e => e.SectionName)
                .HasMaxLength(500)
                .HasColumnName("section_name");
            entity.Property(e => e.State)
                .HasMaxLength(500)
                .HasColumnName("state");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("street_addr_1");
            entity.Property(e => e.StreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("street_addr_2");
            entity.Property(e => e.TicketTypeCategory)
                .HasMaxLength(500)
                .HasColumnName("ticket_type_category");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Venue1Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue1_aisle");
            entity.Property(e => e.Venue1Gate)
                .HasMaxLength(500)
                .HasColumnName("venue1_gate");
            entity.Property(e => e.Venue1Row)
                .HasMaxLength(500)
                .HasColumnName("venue1_row");
            entity.Property(e => e.Venue1Seat)
                .HasMaxLength(500)
                .HasColumnName("venue1_seat");
            entity.Property(e => e.Venue1Section)
                .HasMaxLength(500)
                .HasColumnName("venue1_section");
            entity.Property(e => e.Venue1Stand)
                .HasMaxLength(500)
                .HasColumnName("venue1_stand");
            entity.Property(e => e.Venue2Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue2_aisle");
            entity.Property(e => e.Venue2Gate)
                .HasMaxLength(500)
                .HasColumnName("venue2_gate");
            entity.Property(e => e.Venue2Row)
                .HasMaxLength(500)
                .HasColumnName("venue2_row");
            entity.Property(e => e.Venue2Seat)
                .HasMaxLength(500)
                .HasColumnName("venue2_seat");
            entity.Property(e => e.Venue2Section)
                .HasMaxLength(500)
                .HasColumnName("venue2_section");
            entity.Property(e => e.Venue2Stand)
                .HasMaxLength(500)
                .HasColumnName("venue2_stand");
            entity.Property(e => e.YearsMembership).HasColumnName("years_membership");
            entity.Property(e => e.Zip)
                .HasMaxLength(500)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<RawData13718202110200755439066>(entity =>
        {
            entity.ToTable("RawData_137_18_202110200755439066");

            entity.Property(e => e.AcctId).HasColumnName("acct_id");
            entity.Property(e => e.AcctTypeDesc)
                .HasMaxLength(500)
                .HasColumnName("acct_type_desc");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Barcode)
                .HasMaxLength(500)
                .HasColumnName("barcode");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("birthdate");
            entity.Property(e => e.Card)
                .HasMaxLength(500)
                .HasColumnName("card");
            entity.Property(e => e.City)
                .HasMaxLength(500)
                .HasColumnName("city");
            entity.Property(e => e.ClubCode)
                .HasMaxLength(500)
                .HasColumnName("club_code");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(500)
                .HasColumnName("company_name");
            entity.Property(e => e.ConcessionText)
                .HasMaxLength(500)
                .HasColumnName("concession_text");
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .HasColumnName("country");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustNameId).HasColumnName("cust_name_id");
            entity.Property(e => e.DeliveryInstructions)
                .HasMaxLength(500)
                .HasColumnName("delivery_instructions");
            entity.Property(e => e.DeliveryMethodName)
                .HasMaxLength(500)
                .HasColumnName("delivery_method_name");
            entity.Property(e => e.EmailAddr)
                .HasMaxLength(500)
                .HasColumnName("email_addr");
            entity.Property(e => e.EventLine1)
                .HasMaxLength(500)
                .HasColumnName("event_line1");
            entity.Property(e => e.EventLine2)
                .HasMaxLength(500)
                .HasColumnName("event_line2");
            entity.Property(e => e.EventLine3)
                .HasMaxLength(500)
                .HasColumnName("event_line3");
            entity.Property(e => e.EventName)
                .HasMaxLength(500)
                .HasColumnName("event_name");
            entity.Property(e => e.FamilyId).HasColumnName("family_id");
            entity.Property(e => e.Fulfilment)
                .HasMaxLength(500)
                .HasColumnName("fulfilment");
            entity.Property(e => e.FulfilmentChoice)
                .HasMaxLength(500)
                .HasColumnName("fulfilment_choice");
            entity.Property(e => e.FulfilmentQty).HasColumnName("fulfilment_qty");
            entity.Property(e => e.Gender)
                .HasMaxLength(500)
                .HasColumnName("gender");
            entity.Property(e => e.GroupCodes)
                .HasMaxLength(500)
                .HasColumnName("group_codes");
            entity.Property(e => e.LocationCity)
                .HasMaxLength(500)
                .HasColumnName("location_city");
            entity.Property(e => e.LocationCountry)
                .HasMaxLength(500)
                .HasColumnName("location_country");
            entity.Property(e => e.LocationState)
                .HasMaxLength(500)
                .HasColumnName("location_state");
            entity.Property(e => e.LocationStreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_1");
            entity.Property(e => e.LocationStreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_2");
            entity.Property(e => e.LocationZip)
                .HasMaxLength(500)
                .HasColumnName("location_zip");
            entity.Property(e => e.MemberId).HasColumnName("member_id");
            entity.Property(e => e.MemberSince).HasColumnName("member_since");
            entity.Property(e => e.MembershipType)
                .HasMaxLength(500)
                .HasColumnName("membership_type");
            entity.Property(e => e.NameFirst)
                .HasMaxLength(500)
                .HasColumnName("name_first");
            entity.Property(e => e.NameLast)
                .HasMaxLength(500)
                .HasColumnName("name_last");
            entity.Property(e => e.Note1)
                .HasMaxLength(500)
                .HasColumnName("note1");
            entity.Property(e => e.NumSeats).HasColumnName("num_seats");
            entity.Property(e => e.OrderLineItem).HasColumnName("order_line_item");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.PaymentPlan)
                .HasMaxLength(500)
                .HasColumnName("payment_plan");
            entity.Property(e => e.PhoneCell)
                .HasMaxLength(500)
                .HasColumnName("phone_cell");
            entity.Property(e => e.PhoneDay)
                .HasMaxLength(500)
                .HasColumnName("phone_day");
            entity.Property(e => e.PhoneEve)
                .HasMaxLength(500)
                .HasColumnName("phone_eve");
            entity.Property(e => e.PriceCode)
                .HasMaxLength(500)
                .HasColumnName("price_code");
            entity.Property(e => e.PriceCodeDesc)
                .HasMaxLength(500)
                .HasColumnName("price_code_desc");
            entity.Property(e => e.PriceCodeExtra)
                .HasMaxLength(500)
                .HasColumnName("price_code_extra");
            entity.Property(e => e.PriceCodeInfo1)
                .HasMaxLength(500)
                .HasColumnName("price_code_info1");
            entity.Property(e => e.PriceCodeInfo2)
                .HasMaxLength(500)
                .HasColumnName("price_code_info2");
            entity.Property(e => e.PriceCodeInfo3)
                .HasMaxLength(500)
                .HasColumnName("price_code_info3");
            entity.Property(e => e.PriceCodeInfo4)
                .HasMaxLength(500)
                .HasColumnName("price_code_info4");
            entity.Property(e => e.PrimaryName)
                .HasMaxLength(500)
                .HasColumnName("primary_name");
            entity.Property(e => e.PrintCount).HasColumnName("print_count");
            entity.Property(e => e.PrintDate)
                .HasColumnType("datetime")
                .HasColumnName("print_date");
            entity.Property(e => e.RowName)
                .HasMaxLength(500)
                .HasColumnName("row_name");
            entity.Property(e => e.SeatNum).HasColumnName("seat_num");
            entity.Property(e => e.SectionName)
                .HasMaxLength(500)
                .HasColumnName("section_name");
            entity.Property(e => e.State)
                .HasMaxLength(500)
                .HasColumnName("state");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("street_addr_1");
            entity.Property(e => e.StreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("street_addr_2");
            entity.Property(e => e.TicketTypeCategory)
                .HasMaxLength(500)
                .HasColumnName("ticket_type_category");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Venue1Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue1_aisle");
            entity.Property(e => e.Venue1Gate)
                .HasMaxLength(500)
                .HasColumnName("venue1_gate");
            entity.Property(e => e.Venue1Row)
                .HasMaxLength(500)
                .HasColumnName("venue1_row");
            entity.Property(e => e.Venue1Seat)
                .HasMaxLength(500)
                .HasColumnName("venue1_seat");
            entity.Property(e => e.Venue1Section)
                .HasMaxLength(500)
                .HasColumnName("venue1_section");
            entity.Property(e => e.Venue1Stand)
                .HasMaxLength(500)
                .HasColumnName("venue1_stand");
            entity.Property(e => e.Venue2Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue2_aisle");
            entity.Property(e => e.Venue2Gate)
                .HasMaxLength(500)
                .HasColumnName("venue2_gate");
            entity.Property(e => e.Venue2Row)
                .HasMaxLength(500)
                .HasColumnName("venue2_row");
            entity.Property(e => e.Venue2Seat)
                .HasMaxLength(500)
                .HasColumnName("venue2_seat");
            entity.Property(e => e.Venue2Section)
                .HasMaxLength(500)
                .HasColumnName("venue2_section");
            entity.Property(e => e.Venue2Stand)
                .HasMaxLength(500)
                .HasColumnName("venue2_stand");
            entity.Property(e => e.YearsMembership).HasColumnName("years_membership");
            entity.Property(e => e.Zip)
                .HasMaxLength(500)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<RawData13718202202070130021605>(entity =>
        {
            entity.ToTable("RawData_137_18_202202070130021605");

            entity.Property(e => e.AcctId).HasColumnName("acct_id");
            entity.Property(e => e.AcctTypeDesc)
                .HasMaxLength(500)
                .HasColumnName("acct_type_desc");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Barcode)
                .HasMaxLength(500)
                .HasColumnName("barcode");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("birthdate");
            entity.Property(e => e.Card)
                .HasMaxLength(500)
                .HasColumnName("card");
            entity.Property(e => e.City)
                .HasMaxLength(500)
                .HasColumnName("city");
            entity.Property(e => e.ClubCode)
                .HasMaxLength(500)
                .HasColumnName("club_code");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(500)
                .HasColumnName("company_name");
            entity.Property(e => e.ConcessionText)
                .HasMaxLength(500)
                .HasColumnName("concession_text");
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .HasColumnName("country");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustNameId).HasColumnName("cust_name_id");
            entity.Property(e => e.DeliveryInstructions)
                .HasMaxLength(500)
                .HasColumnName("delivery_instructions");
            entity.Property(e => e.DeliveryMethodName)
                .HasMaxLength(500)
                .HasColumnName("delivery_method_name");
            entity.Property(e => e.EmailAddr)
                .HasMaxLength(500)
                .HasColumnName("email_addr");
            entity.Property(e => e.EventLine1)
                .HasMaxLength(500)
                .HasColumnName("event_line1");
            entity.Property(e => e.EventLine2)
                .HasMaxLength(500)
                .HasColumnName("event_line2");
            entity.Property(e => e.EventLine3)
                .HasMaxLength(500)
                .HasColumnName("event_line3");
            entity.Property(e => e.EventName)
                .HasMaxLength(500)
                .HasColumnName("event_name");
            entity.Property(e => e.FamilyId).HasColumnName("family_id");
            entity.Property(e => e.Fulfilment)
                .HasMaxLength(500)
                .HasColumnName("fulfilment");
            entity.Property(e => e.Gender)
                .HasMaxLength(500)
                .HasColumnName("gender");
            entity.Property(e => e.GroupCodes)
                .HasMaxLength(500)
                .HasColumnName("group_codes");
            entity.Property(e => e.LocationCity)
                .HasMaxLength(500)
                .HasColumnName("location_city");
            entity.Property(e => e.LocationCountry)
                .HasMaxLength(500)
                .HasColumnName("location_country");
            entity.Property(e => e.LocationState)
                .HasMaxLength(500)
                .HasColumnName("location_state");
            entity.Property(e => e.LocationStreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_1");
            entity.Property(e => e.LocationStreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_2");
            entity.Property(e => e.LocationZip)
                .HasMaxLength(500)
                .HasColumnName("location_zip");
            entity.Property(e => e.MemberId).HasColumnName("member_id");
            entity.Property(e => e.MemberSince).HasColumnName("member_since");
            entity.Property(e => e.MembershipType)
                .HasMaxLength(500)
                .HasColumnName("membership_type");
            entity.Property(e => e.NameFirst)
                .HasMaxLength(500)
                .HasColumnName("name_first");
            entity.Property(e => e.NameLast)
                .HasMaxLength(500)
                .HasColumnName("name_last");
            entity.Property(e => e.Note1)
                .HasMaxLength(500)
                .HasColumnName("note1");
            entity.Property(e => e.NumSeats).HasColumnName("num_seats");
            entity.Property(e => e.OrderLineItem).HasColumnName("order_line_item");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.ParticipantId)
                .HasMaxLength(500)
                .HasColumnName("ParticipantID");
            entity.Property(e => e.PaymentPlan)
                .HasMaxLength(500)
                .HasColumnName("payment_plan");
            entity.Property(e => e.PhoneCell)
                .HasMaxLength(500)
                .HasColumnName("phone_cell");
            entity.Property(e => e.PhoneDay)
                .HasMaxLength(500)
                .HasColumnName("phone_day");
            entity.Property(e => e.PhoneEve)
                .HasMaxLength(500)
                .HasColumnName("phone_eve");
            entity.Property(e => e.PriceCode)
                .HasMaxLength(500)
                .HasColumnName("price_code");
            entity.Property(e => e.PriceCodeDesc)
                .HasMaxLength(500)
                .HasColumnName("price_code_desc");
            entity.Property(e => e.PriceCodeExtra)
                .HasMaxLength(500)
                .HasColumnName("price_code_extra");
            entity.Property(e => e.PriceCodeInfo1)
                .HasMaxLength(500)
                .HasColumnName("price_code_info1");
            entity.Property(e => e.PriceCodeInfo2)
                .HasMaxLength(500)
                .HasColumnName("price_code_info2");
            entity.Property(e => e.PriceCodeInfo3)
                .HasMaxLength(500)
                .HasColumnName("price_code_info3");
            entity.Property(e => e.PriceCodeInfo4)
                .HasMaxLength(500)
                .HasColumnName("price_code_info4");
            entity.Property(e => e.PrimaryName)
                .HasMaxLength(500)
                .HasColumnName("primary_name");
            entity.Property(e => e.PrintCount).HasColumnName("print_count");
            entity.Property(e => e.PrintDate)
                .HasColumnType("datetime")
                .HasColumnName("print_date");
            entity.Property(e => e.RowName)
                .HasMaxLength(500)
                .HasColumnName("row_name");
            entity.Property(e => e.SeatNum).HasColumnName("seat_num");
            entity.Property(e => e.SectionName)
                .HasMaxLength(500)
                .HasColumnName("section_name");
            entity.Property(e => e.State)
                .HasMaxLength(500)
                .HasColumnName("state");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("street_addr_1");
            entity.Property(e => e.StreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("street_addr_2");
            entity.Property(e => e.TicketTypeCategory)
                .HasMaxLength(500)
                .HasColumnName("ticket_type_category");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Venue1Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue1_aisle");
            entity.Property(e => e.Venue1Gate)
                .HasMaxLength(500)
                .HasColumnName("venue1_gate");
            entity.Property(e => e.Venue1Row)
                .HasMaxLength(500)
                .HasColumnName("venue1_row");
            entity.Property(e => e.Venue1Seat)
                .HasMaxLength(500)
                .HasColumnName("venue1_seat");
            entity.Property(e => e.Venue1Section)
                .HasMaxLength(500)
                .HasColumnName("venue1_section");
            entity.Property(e => e.Venue1Stand)
                .HasMaxLength(500)
                .HasColumnName("venue1_stand");
            entity.Property(e => e.Venue2Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue2_aisle");
            entity.Property(e => e.Venue2Gate)
                .HasMaxLength(500)
                .HasColumnName("venue2_gate");
            entity.Property(e => e.Venue2Row)
                .HasMaxLength(500)
                .HasColumnName("venue2_row");
            entity.Property(e => e.Venue2Seat)
                .HasMaxLength(500)
                .HasColumnName("venue2_seat");
            entity.Property(e => e.Venue2Section)
                .HasMaxLength(500)
                .HasColumnName("venue2_section");
            entity.Property(e => e.Venue2Stand)
                .HasMaxLength(500)
                .HasColumnName("venue2_stand");
            entity.Property(e => e.YearsMembership).HasColumnName("years_membership");
            entity.Property(e => e.Zip)
                .HasMaxLength(500)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<RawData13718202202070141005665>(entity =>
        {
            entity.ToTable("RawData_137_18_202202070141005665");

            entity.Property(e => e.AcctId).HasColumnName("acct_id");
            entity.Property(e => e.AcctTypeDesc)
                .HasMaxLength(500)
                .HasColumnName("acct_type_desc");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Barcode)
                .HasMaxLength(500)
                .HasColumnName("barcode");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("birthdate");
            entity.Property(e => e.Card)
                .HasMaxLength(500)
                .HasColumnName("card");
            entity.Property(e => e.City)
                .HasMaxLength(500)
                .HasColumnName("city");
            entity.Property(e => e.ClubCode)
                .HasMaxLength(500)
                .HasColumnName("club_code");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(500)
                .HasColumnName("company_name");
            entity.Property(e => e.ConcessionText)
                .HasMaxLength(500)
                .HasColumnName("concession_text");
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .HasColumnName("country");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustNameId).HasColumnName("cust_name_id");
            entity.Property(e => e.DeliveryInstructions)
                .HasMaxLength(500)
                .HasColumnName("delivery_instructions");
            entity.Property(e => e.DeliveryMethodName)
                .HasMaxLength(500)
                .HasColumnName("delivery_method_name");
            entity.Property(e => e.EmailAddr)
                .HasMaxLength(500)
                .HasColumnName("email_addr");
            entity.Property(e => e.EventLine1)
                .HasMaxLength(500)
                .HasColumnName("event_line1");
            entity.Property(e => e.EventLine2)
                .HasMaxLength(500)
                .HasColumnName("event_line2");
            entity.Property(e => e.EventLine3)
                .HasMaxLength(500)
                .HasColumnName("event_line3");
            entity.Property(e => e.EventName)
                .HasMaxLength(500)
                .HasColumnName("event_name");
            entity.Property(e => e.FamilyId).HasColumnName("family_id");
            entity.Property(e => e.Fulfilment)
                .HasMaxLength(500)
                .HasColumnName("fulfilment");
            entity.Property(e => e.Gender)
                .HasMaxLength(500)
                .HasColumnName("gender");
            entity.Property(e => e.GroupCodes)
                .HasMaxLength(500)
                .HasColumnName("group_codes");
            entity.Property(e => e.GroupId)
                .HasMaxLength(500)
                .HasColumnName("GroupID");
            entity.Property(e => e.LocationCity)
                .HasMaxLength(500)
                .HasColumnName("location_city");
            entity.Property(e => e.LocationCountry)
                .HasMaxLength(500)
                .HasColumnName("location_country");
            entity.Property(e => e.LocationState)
                .HasMaxLength(500)
                .HasColumnName("location_state");
            entity.Property(e => e.LocationStreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_1");
            entity.Property(e => e.LocationStreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_2");
            entity.Property(e => e.LocationZip)
                .HasMaxLength(500)
                .HasColumnName("location_zip");
            entity.Property(e => e.MemberId).HasColumnName("member_id");
            entity.Property(e => e.MemberSince).HasColumnName("member_since");
            entity.Property(e => e.MembershipType)
                .HasMaxLength(500)
                .HasColumnName("membership_type");
            entity.Property(e => e.NameFirst)
                .HasMaxLength(500)
                .HasColumnName("name_first");
            entity.Property(e => e.NameLast)
                .HasMaxLength(500)
                .HasColumnName("name_last");
            entity.Property(e => e.Note1)
                .HasMaxLength(500)
                .HasColumnName("note1");
            entity.Property(e => e.NumSeats).HasColumnName("num_seats");
            entity.Property(e => e.OrderLineItem).HasColumnName("order_line_item");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.ParticipantId)
                .HasMaxLength(500)
                .HasColumnName("ParticipantID");
            entity.Property(e => e.PaymentPlan)
                .HasMaxLength(500)
                .HasColumnName("payment_plan");
            entity.Property(e => e.PhoneCell)
                .HasMaxLength(500)
                .HasColumnName("phone_cell");
            entity.Property(e => e.PhoneDay)
                .HasMaxLength(500)
                .HasColumnName("phone_day");
            entity.Property(e => e.PhoneEve)
                .HasMaxLength(500)
                .HasColumnName("phone_eve");
            entity.Property(e => e.PriceCode)
                .HasMaxLength(500)
                .HasColumnName("price_code");
            entity.Property(e => e.PriceCodeDesc)
                .HasMaxLength(500)
                .HasColumnName("price_code_desc");
            entity.Property(e => e.PriceCodeExtra)
                .HasMaxLength(500)
                .HasColumnName("price_code_extra");
            entity.Property(e => e.PriceCodeInfo1)
                .HasMaxLength(500)
                .HasColumnName("price_code_info1");
            entity.Property(e => e.PriceCodeInfo2)
                .HasMaxLength(500)
                .HasColumnName("price_code_info2");
            entity.Property(e => e.PriceCodeInfo3)
                .HasMaxLength(500)
                .HasColumnName("price_code_info3");
            entity.Property(e => e.PriceCodeInfo4)
                .HasMaxLength(500)
                .HasColumnName("price_code_info4");
            entity.Property(e => e.PrimaryName)
                .HasMaxLength(500)
                .HasColumnName("primary_name");
            entity.Property(e => e.PrintCount).HasColumnName("print_count");
            entity.Property(e => e.PrintDate)
                .HasColumnType("datetime")
                .HasColumnName("print_date");
            entity.Property(e => e.Role).HasMaxLength(50);
            entity.Property(e => e.RowName)
                .HasMaxLength(500)
                .HasColumnName("row_name");
            entity.Property(e => e.SeatNum).HasColumnName("seat_num");
            entity.Property(e => e.SectionName)
                .HasMaxLength(500)
                .HasColumnName("section_name");
            entity.Property(e => e.State)
                .HasMaxLength(500)
                .HasColumnName("state");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("street_addr_1");
            entity.Property(e => e.StreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("street_addr_2");
            entity.Property(e => e.TicketTypeCategory)
                .HasMaxLength(500)
                .HasColumnName("ticket_type_category");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Venue1Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue1_aisle");
            entity.Property(e => e.Venue1Gate)
                .HasMaxLength(500)
                .HasColumnName("venue1_gate");
            entity.Property(e => e.Venue1Row)
                .HasMaxLength(500)
                .HasColumnName("venue1_row");
            entity.Property(e => e.Venue1Seat)
                .HasMaxLength(500)
                .HasColumnName("venue1_seat");
            entity.Property(e => e.Venue1Section)
                .HasMaxLength(500)
                .HasColumnName("venue1_section");
            entity.Property(e => e.Venue1Stand)
                .HasMaxLength(500)
                .HasColumnName("venue1_stand");
            entity.Property(e => e.Venue2Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue2_aisle");
            entity.Property(e => e.Venue2Gate)
                .HasMaxLength(500)
                .HasColumnName("venue2_gate");
            entity.Property(e => e.Venue2Row)
                .HasMaxLength(500)
                .HasColumnName("venue2_row");
            entity.Property(e => e.Venue2Seat)
                .HasMaxLength(500)
                .HasColumnName("venue2_seat");
            entity.Property(e => e.Venue2Section)
                .HasMaxLength(500)
                .HasColumnName("venue2_section");
            entity.Property(e => e.Venue2Stand)
                .HasMaxLength(500)
                .HasColumnName("venue2_stand");
            entity.Property(e => e.YearsMembership).HasColumnName("years_membership");
            entity.Property(e => e.Zip)
                .HasMaxLength(500)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<RawData13718202202070141036173>(entity =>
        {
            entity.ToTable("RawData_137_18_202202070141036173");

            entity.Property(e => e.AcctId).HasColumnName("acct_id");
            entity.Property(e => e.AcctTypeDesc)
                .HasMaxLength(500)
                .HasColumnName("acct_type_desc");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Barcode)
                .HasMaxLength(500)
                .HasColumnName("barcode");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("birthdate");
            entity.Property(e => e.Card)
                .HasMaxLength(500)
                .HasColumnName("card");
            entity.Property(e => e.City)
                .HasMaxLength(500)
                .HasColumnName("city");
            entity.Property(e => e.ClubCode)
                .HasMaxLength(500)
                .HasColumnName("club_code");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(500)
                .HasColumnName("company_name");
            entity.Property(e => e.ConcessionText)
                .HasMaxLength(500)
                .HasColumnName("concession_text");
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .HasColumnName("country");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustNameId).HasColumnName("cust_name_id");
            entity.Property(e => e.DeliveryInstructions)
                .HasMaxLength(500)
                .HasColumnName("delivery_instructions");
            entity.Property(e => e.DeliveryMethodName)
                .HasMaxLength(500)
                .HasColumnName("delivery_method_name");
            entity.Property(e => e.EmailAddr)
                .HasMaxLength(500)
                .HasColumnName("email_addr");
            entity.Property(e => e.EventLine1)
                .HasMaxLength(500)
                .HasColumnName("event_line1");
            entity.Property(e => e.EventLine2)
                .HasMaxLength(500)
                .HasColumnName("event_line2");
            entity.Property(e => e.EventLine3)
                .HasMaxLength(500)
                .HasColumnName("event_line3");
            entity.Property(e => e.EventName)
                .HasMaxLength(500)
                .HasColumnName("event_name");
            entity.Property(e => e.FamilyId).HasColumnName("family_id");
            entity.Property(e => e.Fulfilment)
                .HasMaxLength(500)
                .HasColumnName("fulfilment");
            entity.Property(e => e.Gender)
                .HasMaxLength(500)
                .HasColumnName("gender");
            entity.Property(e => e.GroupCodes)
                .HasMaxLength(500)
                .HasColumnName("group_codes");
            entity.Property(e => e.GroupId)
                .HasMaxLength(500)
                .HasColumnName("GroupID");
            entity.Property(e => e.LocationCity)
                .HasMaxLength(500)
                .HasColumnName("location_city");
            entity.Property(e => e.LocationCountry)
                .HasMaxLength(500)
                .HasColumnName("location_country");
            entity.Property(e => e.LocationState)
                .HasMaxLength(500)
                .HasColumnName("location_state");
            entity.Property(e => e.LocationStreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_1");
            entity.Property(e => e.LocationStreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_2");
            entity.Property(e => e.LocationZip)
                .HasMaxLength(500)
                .HasColumnName("location_zip");
            entity.Property(e => e.MemberId).HasColumnName("member_id");
            entity.Property(e => e.MemberSince).HasColumnName("member_since");
            entity.Property(e => e.MembershipType)
                .HasMaxLength(500)
                .HasColumnName("membership_type");
            entity.Property(e => e.NameFirst)
                .HasMaxLength(500)
                .HasColumnName("name_first");
            entity.Property(e => e.NameLast)
                .HasMaxLength(500)
                .HasColumnName("name_last");
            entity.Property(e => e.Note1)
                .HasMaxLength(500)
                .HasColumnName("note1");
            entity.Property(e => e.NumSeats).HasColumnName("num_seats");
            entity.Property(e => e.OrderLineItem).HasColumnName("order_line_item");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.ParticipantId)
                .HasMaxLength(500)
                .HasColumnName("ParticipantID");
            entity.Property(e => e.PaymentPlan)
                .HasMaxLength(500)
                .HasColumnName("payment_plan");
            entity.Property(e => e.PhoneCell)
                .HasMaxLength(500)
                .HasColumnName("phone_cell");
            entity.Property(e => e.PhoneDay)
                .HasMaxLength(500)
                .HasColumnName("phone_day");
            entity.Property(e => e.PhoneEve)
                .HasMaxLength(500)
                .HasColumnName("phone_eve");
            entity.Property(e => e.PriceCode)
                .HasMaxLength(500)
                .HasColumnName("price_code");
            entity.Property(e => e.PriceCodeDesc)
                .HasMaxLength(500)
                .HasColumnName("price_code_desc");
            entity.Property(e => e.PriceCodeExtra)
                .HasMaxLength(500)
                .HasColumnName("price_code_extra");
            entity.Property(e => e.PriceCodeInfo1)
                .HasMaxLength(500)
                .HasColumnName("price_code_info1");
            entity.Property(e => e.PriceCodeInfo2)
                .HasMaxLength(500)
                .HasColumnName("price_code_info2");
            entity.Property(e => e.PriceCodeInfo3)
                .HasMaxLength(500)
                .HasColumnName("price_code_info3");
            entity.Property(e => e.PriceCodeInfo4)
                .HasMaxLength(500)
                .HasColumnName("price_code_info4");
            entity.Property(e => e.PrimaryName)
                .HasMaxLength(500)
                .HasColumnName("primary_name");
            entity.Property(e => e.PrintCount).HasColumnName("print_count");
            entity.Property(e => e.PrintDate)
                .HasColumnType("datetime")
                .HasColumnName("print_date");
            entity.Property(e => e.Role).HasMaxLength(50);
            entity.Property(e => e.RowName)
                .HasMaxLength(500)
                .HasColumnName("row_name");
            entity.Property(e => e.SeatNum).HasColumnName("seat_num");
            entity.Property(e => e.SectionName)
                .HasMaxLength(500)
                .HasColumnName("section_name");
            entity.Property(e => e.State)
                .HasMaxLength(500)
                .HasColumnName("state");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("street_addr_1");
            entity.Property(e => e.StreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("street_addr_2");
            entity.Property(e => e.TicketTypeCategory)
                .HasMaxLength(500)
                .HasColumnName("ticket_type_category");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Venue1Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue1_aisle");
            entity.Property(e => e.Venue1Gate)
                .HasMaxLength(500)
                .HasColumnName("venue1_gate");
            entity.Property(e => e.Venue1Row)
                .HasMaxLength(500)
                .HasColumnName("venue1_row");
            entity.Property(e => e.Venue1Seat)
                .HasMaxLength(500)
                .HasColumnName("venue1_seat");
            entity.Property(e => e.Venue1Section)
                .HasMaxLength(500)
                .HasColumnName("venue1_section");
            entity.Property(e => e.Venue1Stand)
                .HasMaxLength(500)
                .HasColumnName("venue1_stand");
            entity.Property(e => e.Venue2Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue2_aisle");
            entity.Property(e => e.Venue2Gate)
                .HasMaxLength(500)
                .HasColumnName("venue2_gate");
            entity.Property(e => e.Venue2Row)
                .HasMaxLength(500)
                .HasColumnName("venue2_row");
            entity.Property(e => e.Venue2Seat)
                .HasMaxLength(500)
                .HasColumnName("venue2_seat");
            entity.Property(e => e.Venue2Section)
                .HasMaxLength(500)
                .HasColumnName("venue2_section");
            entity.Property(e => e.Venue2Stand)
                .HasMaxLength(500)
                .HasColumnName("venue2_stand");
            entity.Property(e => e.YearsMembership).HasColumnName("years_membership");
            entity.Property(e => e.Zip)
                .HasMaxLength(500)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<RawData13718202202071110561351>(entity =>
        {
            entity.ToTable("RawData_137_18_202202071110561351");

            entity.Property(e => e.AcctId).HasColumnName("acct_id");
            entity.Property(e => e.AcctTypeDesc)
                .HasMaxLength(500)
                .HasColumnName("acct_type_desc");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Barcode)
                .HasMaxLength(500)
                .HasColumnName("barcode");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("birthdate");
            entity.Property(e => e.Card)
                .HasMaxLength(500)
                .HasColumnName("card");
            entity.Property(e => e.City)
                .HasMaxLength(500)
                .HasColumnName("city");
            entity.Property(e => e.ClubCode)
                .HasMaxLength(500)
                .HasColumnName("club_code");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(500)
                .HasColumnName("company_name");
            entity.Property(e => e.ConcessionText)
                .HasMaxLength(500)
                .HasColumnName("concession_text");
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .HasColumnName("country");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustNameId).HasColumnName("cust_name_id");
            entity.Property(e => e.DeliveryInstructions)
                .HasMaxLength(500)
                .HasColumnName("delivery_instructions");
            entity.Property(e => e.DeliveryMethodName)
                .HasMaxLength(500)
                .HasColumnName("delivery_method_name");
            entity.Property(e => e.EmailAddr)
                .HasMaxLength(500)
                .HasColumnName("email_addr");
            entity.Property(e => e.EventLine1)
                .HasMaxLength(500)
                .HasColumnName("event_line1");
            entity.Property(e => e.EventLine2)
                .HasMaxLength(500)
                .HasColumnName("event_line2");
            entity.Property(e => e.EventLine3)
                .HasMaxLength(500)
                .HasColumnName("event_line3");
            entity.Property(e => e.EventName)
                .HasMaxLength(500)
                .HasColumnName("event_name");
            entity.Property(e => e.FamilyId).HasColumnName("family_id");
            entity.Property(e => e.Fulfilment)
                .HasMaxLength(500)
                .HasColumnName("fulfilment");
            entity.Property(e => e.Gender)
                .HasMaxLength(500)
                .HasColumnName("gender");
            entity.Property(e => e.GroupCodes)
                .HasMaxLength(500)
                .HasColumnName("group_codes");
            entity.Property(e => e.GroupId)
                .HasMaxLength(500)
                .HasColumnName("GroupID");
            entity.Property(e => e.LocationCity)
                .HasMaxLength(500)
                .HasColumnName("location_city");
            entity.Property(e => e.LocationCountry)
                .HasMaxLength(500)
                .HasColumnName("location_country");
            entity.Property(e => e.LocationState)
                .HasMaxLength(500)
                .HasColumnName("location_state");
            entity.Property(e => e.LocationStreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_1");
            entity.Property(e => e.LocationStreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_2");
            entity.Property(e => e.LocationZip)
                .HasMaxLength(500)
                .HasColumnName("location_zip");
            entity.Property(e => e.MemberId).HasColumnName("member_id");
            entity.Property(e => e.MemberSince).HasColumnName("member_since");
            entity.Property(e => e.MembershipType)
                .HasMaxLength(500)
                .HasColumnName("membership_type");
            entity.Property(e => e.NameFirst)
                .HasMaxLength(500)
                .HasColumnName("name_first");
            entity.Property(e => e.NameLast)
                .HasMaxLength(500)
                .HasColumnName("name_last");
            entity.Property(e => e.Note1)
                .HasMaxLength(500)
                .HasColumnName("note1");
            entity.Property(e => e.NumSeats).HasColumnName("num_seats");
            entity.Property(e => e.OrderLineItem).HasColumnName("order_line_item");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.ParticipantId)
                .HasMaxLength(500)
                .HasColumnName("ParticipantID");
            entity.Property(e => e.PaymentPlan)
                .HasMaxLength(500)
                .HasColumnName("payment_plan");
            entity.Property(e => e.PhoneCell)
                .HasMaxLength(500)
                .HasColumnName("phone_cell");
            entity.Property(e => e.PhoneDay)
                .HasMaxLength(500)
                .HasColumnName("phone_day");
            entity.Property(e => e.PhoneEve)
                .HasMaxLength(500)
                .HasColumnName("phone_eve");
            entity.Property(e => e.PriceCode)
                .HasMaxLength(500)
                .HasColumnName("price_code");
            entity.Property(e => e.PriceCodeDesc)
                .HasMaxLength(500)
                .HasColumnName("price_code_desc");
            entity.Property(e => e.PriceCodeExtra)
                .HasMaxLength(500)
                .HasColumnName("price_code_extra");
            entity.Property(e => e.PriceCodeInfo1)
                .HasMaxLength(500)
                .HasColumnName("price_code_info1");
            entity.Property(e => e.PriceCodeInfo2)
                .HasMaxLength(500)
                .HasColumnName("price_code_info2");
            entity.Property(e => e.PriceCodeInfo3)
                .HasMaxLength(500)
                .HasColumnName("price_code_info3");
            entity.Property(e => e.PriceCodeInfo4)
                .HasMaxLength(500)
                .HasColumnName("price_code_info4");
            entity.Property(e => e.PrimaryName)
                .HasMaxLength(500)
                .HasColumnName("primary_name");
            entity.Property(e => e.PrintCount).HasColumnName("print_count");
            entity.Property(e => e.PrintDate)
                .HasColumnType("datetime")
                .HasColumnName("print_date");
            entity.Property(e => e.Role).HasMaxLength(500);
            entity.Property(e => e.RowName)
                .HasMaxLength(500)
                .HasColumnName("row_name");
            entity.Property(e => e.SeatNum).HasColumnName("seat_num");
            entity.Property(e => e.SectionName)
                .HasMaxLength(500)
                .HasColumnName("section_name");
            entity.Property(e => e.State)
                .HasMaxLength(500)
                .HasColumnName("state");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("street_addr_1");
            entity.Property(e => e.StreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("street_addr_2");
            entity.Property(e => e.TicketTypeCategory)
                .HasMaxLength(500)
                .HasColumnName("ticket_type_category");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Venue1Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue1_aisle");
            entity.Property(e => e.Venue1Gate)
                .HasMaxLength(500)
                .HasColumnName("venue1_gate");
            entity.Property(e => e.Venue1Row)
                .HasMaxLength(500)
                .HasColumnName("venue1_row");
            entity.Property(e => e.Venue1Seat)
                .HasMaxLength(500)
                .HasColumnName("venue1_seat");
            entity.Property(e => e.Venue1Section)
                .HasMaxLength(500)
                .HasColumnName("venue1_section");
            entity.Property(e => e.Venue1Stand)
                .HasMaxLength(500)
                .HasColumnName("venue1_stand");
            entity.Property(e => e.Venue2Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue2_aisle");
            entity.Property(e => e.Venue2Gate)
                .HasMaxLength(500)
                .HasColumnName("venue2_gate");
            entity.Property(e => e.Venue2Row)
                .HasMaxLength(500)
                .HasColumnName("venue2_row");
            entity.Property(e => e.Venue2Seat)
                .HasMaxLength(500)
                .HasColumnName("venue2_seat");
            entity.Property(e => e.Venue2Section)
                .HasMaxLength(500)
                .HasColumnName("venue2_section");
            entity.Property(e => e.Venue2Stand)
                .HasMaxLength(500)
                .HasColumnName("venue2_stand");
            entity.Property(e => e.YearsMembership).HasColumnName("years_membership");
            entity.Property(e => e.Zip)
                .HasMaxLength(500)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<RawData13718202202071110590255>(entity =>
        {
            entity.ToTable("RawData_137_18_202202071110590255");

            entity.Property(e => e.AcctId).HasColumnName("acct_id");
            entity.Property(e => e.AcctTypeDesc)
                .HasMaxLength(500)
                .HasColumnName("acct_type_desc");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Barcode)
                .HasMaxLength(500)
                .HasColumnName("barcode");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("birthdate");
            entity.Property(e => e.Card)
                .HasMaxLength(500)
                .HasColumnName("card");
            entity.Property(e => e.City)
                .HasMaxLength(500)
                .HasColumnName("city");
            entity.Property(e => e.ClubCode)
                .HasMaxLength(500)
                .HasColumnName("club_code");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(500)
                .HasColumnName("company_name");
            entity.Property(e => e.ConcessionText)
                .HasMaxLength(500)
                .HasColumnName("concession_text");
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .HasColumnName("country");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustNameId).HasColumnName("cust_name_id");
            entity.Property(e => e.DeliveryInstructions)
                .HasMaxLength(500)
                .HasColumnName("delivery_instructions");
            entity.Property(e => e.DeliveryMethodName)
                .HasMaxLength(500)
                .HasColumnName("delivery_method_name");
            entity.Property(e => e.EmailAddr)
                .HasMaxLength(500)
                .HasColumnName("email_addr");
            entity.Property(e => e.EventLine1)
                .HasMaxLength(500)
                .HasColumnName("event_line1");
            entity.Property(e => e.EventLine2)
                .HasMaxLength(500)
                .HasColumnName("event_line2");
            entity.Property(e => e.EventLine3)
                .HasMaxLength(500)
                .HasColumnName("event_line3");
            entity.Property(e => e.EventName)
                .HasMaxLength(500)
                .HasColumnName("event_name");
            entity.Property(e => e.FamilyId).HasColumnName("family_id");
            entity.Property(e => e.Fulfilment)
                .HasMaxLength(500)
                .HasColumnName("fulfilment");
            entity.Property(e => e.Gender)
                .HasMaxLength(500)
                .HasColumnName("gender");
            entity.Property(e => e.GroupCodes)
                .HasMaxLength(500)
                .HasColumnName("group_codes");
            entity.Property(e => e.GroupId)
                .HasMaxLength(500)
                .HasColumnName("GroupID");
            entity.Property(e => e.LocationCity)
                .HasMaxLength(500)
                .HasColumnName("location_city");
            entity.Property(e => e.LocationCountry)
                .HasMaxLength(500)
                .HasColumnName("location_country");
            entity.Property(e => e.LocationState)
                .HasMaxLength(500)
                .HasColumnName("location_state");
            entity.Property(e => e.LocationStreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_1");
            entity.Property(e => e.LocationStreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_2");
            entity.Property(e => e.LocationZip)
                .HasMaxLength(500)
                .HasColumnName("location_zip");
            entity.Property(e => e.MemberId).HasColumnName("member_id");
            entity.Property(e => e.MemberSince).HasColumnName("member_since");
            entity.Property(e => e.MembershipType)
                .HasMaxLength(500)
                .HasColumnName("membership_type");
            entity.Property(e => e.NameFirst)
                .HasMaxLength(500)
                .HasColumnName("name_first");
            entity.Property(e => e.NameLast)
                .HasMaxLength(500)
                .HasColumnName("name_last");
            entity.Property(e => e.Note1)
                .HasMaxLength(500)
                .HasColumnName("note1");
            entity.Property(e => e.NumSeats).HasColumnName("num_seats");
            entity.Property(e => e.OrderLineItem).HasColumnName("order_line_item");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.ParticipantId)
                .HasMaxLength(500)
                .HasColumnName("ParticipantID");
            entity.Property(e => e.PaymentPlan)
                .HasMaxLength(500)
                .HasColumnName("payment_plan");
            entity.Property(e => e.PhoneCell)
                .HasMaxLength(500)
                .HasColumnName("phone_cell");
            entity.Property(e => e.PhoneDay)
                .HasMaxLength(500)
                .HasColumnName("phone_day");
            entity.Property(e => e.PhoneEve)
                .HasMaxLength(500)
                .HasColumnName("phone_eve");
            entity.Property(e => e.PriceCode)
                .HasMaxLength(500)
                .HasColumnName("price_code");
            entity.Property(e => e.PriceCodeDesc)
                .HasMaxLength(500)
                .HasColumnName("price_code_desc");
            entity.Property(e => e.PriceCodeExtra)
                .HasMaxLength(500)
                .HasColumnName("price_code_extra");
            entity.Property(e => e.PriceCodeInfo1)
                .HasMaxLength(500)
                .HasColumnName("price_code_info1");
            entity.Property(e => e.PriceCodeInfo2)
                .HasMaxLength(500)
                .HasColumnName("price_code_info2");
            entity.Property(e => e.PriceCodeInfo3)
                .HasMaxLength(500)
                .HasColumnName("price_code_info3");
            entity.Property(e => e.PriceCodeInfo4)
                .HasMaxLength(500)
                .HasColumnName("price_code_info4");
            entity.Property(e => e.PrimaryName)
                .HasMaxLength(500)
                .HasColumnName("primary_name");
            entity.Property(e => e.PrintCount).HasColumnName("print_count");
            entity.Property(e => e.PrintDate)
                .HasColumnType("datetime")
                .HasColumnName("print_date");
            entity.Property(e => e.Role).HasMaxLength(500);
            entity.Property(e => e.RowName)
                .HasMaxLength(500)
                .HasColumnName("row_name");
            entity.Property(e => e.SeatNum).HasColumnName("seat_num");
            entity.Property(e => e.SectionName)
                .HasMaxLength(500)
                .HasColumnName("section_name");
            entity.Property(e => e.State)
                .HasMaxLength(500)
                .HasColumnName("state");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("street_addr_1");
            entity.Property(e => e.StreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("street_addr_2");
            entity.Property(e => e.TicketTypeCategory)
                .HasMaxLength(500)
                .HasColumnName("ticket_type_category");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Venue1Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue1_aisle");
            entity.Property(e => e.Venue1Gate)
                .HasMaxLength(500)
                .HasColumnName("venue1_gate");
            entity.Property(e => e.Venue1Row)
                .HasMaxLength(500)
                .HasColumnName("venue1_row");
            entity.Property(e => e.Venue1Seat)
                .HasMaxLength(500)
                .HasColumnName("venue1_seat");
            entity.Property(e => e.Venue1Section)
                .HasMaxLength(500)
                .HasColumnName("venue1_section");
            entity.Property(e => e.Venue1Stand)
                .HasMaxLength(500)
                .HasColumnName("venue1_stand");
            entity.Property(e => e.Venue2Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue2_aisle");
            entity.Property(e => e.Venue2Gate)
                .HasMaxLength(500)
                .HasColumnName("venue2_gate");
            entity.Property(e => e.Venue2Row)
                .HasMaxLength(500)
                .HasColumnName("venue2_row");
            entity.Property(e => e.Venue2Seat)
                .HasMaxLength(500)
                .HasColumnName("venue2_seat");
            entity.Property(e => e.Venue2Section)
                .HasMaxLength(500)
                .HasColumnName("venue2_section");
            entity.Property(e => e.Venue2Stand)
                .HasMaxLength(500)
                .HasColumnName("venue2_stand");
            entity.Property(e => e.YearsMembership).HasColumnName("years_membership");
            entity.Property(e => e.Zip)
                .HasMaxLength(500)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<RawData13718202202071113436144>(entity =>
        {
            entity.ToTable("RawData_137_18_202202071113436144");

            entity.Property(e => e.AcctId).HasColumnName("acct_id");
            entity.Property(e => e.AcctTypeDesc)
                .HasMaxLength(500)
                .HasColumnName("acct_type_desc");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Barcode)
                .HasMaxLength(500)
                .HasColumnName("barcode");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("birthdate");
            entity.Property(e => e.Card)
                .HasMaxLength(500)
                .HasColumnName("card");
            entity.Property(e => e.City)
                .HasMaxLength(500)
                .HasColumnName("city");
            entity.Property(e => e.ClubCode)
                .HasMaxLength(500)
                .HasColumnName("club_code");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(500)
                .HasColumnName("company_name");
            entity.Property(e => e.ConcessionText)
                .HasMaxLength(500)
                .HasColumnName("concession_text");
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .HasColumnName("country");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustNameId).HasColumnName("cust_name_id");
            entity.Property(e => e.DeliveryInstructions)
                .HasMaxLength(500)
                .HasColumnName("delivery_instructions");
            entity.Property(e => e.DeliveryMethodName)
                .HasMaxLength(500)
                .HasColumnName("delivery_method_name");
            entity.Property(e => e.EmailAddr)
                .HasMaxLength(500)
                .HasColumnName("email_addr");
            entity.Property(e => e.EventLine1)
                .HasMaxLength(500)
                .HasColumnName("event_line1");
            entity.Property(e => e.EventLine2)
                .HasMaxLength(500)
                .HasColumnName("event_line2");
            entity.Property(e => e.EventLine3)
                .HasMaxLength(500)
                .HasColumnName("event_line3");
            entity.Property(e => e.EventName)
                .HasMaxLength(500)
                .HasColumnName("event_name");
            entity.Property(e => e.FamilyId).HasColumnName("family_id");
            entity.Property(e => e.Fulfilment)
                .HasMaxLength(500)
                .HasColumnName("fulfilment");
            entity.Property(e => e.Gender)
                .HasMaxLength(500)
                .HasColumnName("gender");
            entity.Property(e => e.GroupCodes)
                .HasMaxLength(500)
                .HasColumnName("group_codes");
            entity.Property(e => e.GroupId)
                .HasMaxLength(500)
                .HasColumnName("GroupID");
            entity.Property(e => e.LocationCity)
                .HasMaxLength(500)
                .HasColumnName("location_city");
            entity.Property(e => e.LocationCountry)
                .HasMaxLength(500)
                .HasColumnName("location_country");
            entity.Property(e => e.LocationState)
                .HasMaxLength(500)
                .HasColumnName("location_state");
            entity.Property(e => e.LocationStreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_1");
            entity.Property(e => e.LocationStreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_2");
            entity.Property(e => e.LocationZip)
                .HasMaxLength(500)
                .HasColumnName("location_zip");
            entity.Property(e => e.MemberId).HasColumnName("member_id");
            entity.Property(e => e.MemberSince).HasColumnName("member_since");
            entity.Property(e => e.MembershipType)
                .HasMaxLength(500)
                .HasColumnName("membership_type");
            entity.Property(e => e.NameFirst)
                .HasMaxLength(500)
                .HasColumnName("name_first");
            entity.Property(e => e.NameLast)
                .HasMaxLength(500)
                .HasColumnName("name_last");
            entity.Property(e => e.Note1)
                .HasMaxLength(500)
                .HasColumnName("note1");
            entity.Property(e => e.NumSeats).HasColumnName("num_seats");
            entity.Property(e => e.OrderLineItem).HasColumnName("order_line_item");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.ParticipantId)
                .HasMaxLength(500)
                .HasColumnName("ParticipantID");
            entity.Property(e => e.PaymentPlan)
                .HasMaxLength(500)
                .HasColumnName("payment_plan");
            entity.Property(e => e.PhoneCell)
                .HasMaxLength(500)
                .HasColumnName("phone_cell");
            entity.Property(e => e.PhoneDay)
                .HasMaxLength(500)
                .HasColumnName("phone_day");
            entity.Property(e => e.PhoneEve)
                .HasMaxLength(500)
                .HasColumnName("phone_eve");
            entity.Property(e => e.PriceCode)
                .HasMaxLength(500)
                .HasColumnName("price_code");
            entity.Property(e => e.PriceCodeDesc)
                .HasMaxLength(500)
                .HasColumnName("price_code_desc");
            entity.Property(e => e.PriceCodeExtra)
                .HasMaxLength(500)
                .HasColumnName("price_code_extra");
            entity.Property(e => e.PriceCodeInfo1)
                .HasMaxLength(500)
                .HasColumnName("price_code_info1");
            entity.Property(e => e.PriceCodeInfo2)
                .HasMaxLength(500)
                .HasColumnName("price_code_info2");
            entity.Property(e => e.PriceCodeInfo3)
                .HasMaxLength(500)
                .HasColumnName("price_code_info3");
            entity.Property(e => e.PriceCodeInfo4)
                .HasMaxLength(500)
                .HasColumnName("price_code_info4");
            entity.Property(e => e.PrimaryName)
                .HasMaxLength(500)
                .HasColumnName("primary_name");
            entity.Property(e => e.PrintCount).HasColumnName("print_count");
            entity.Property(e => e.PrintDate)
                .HasColumnType("datetime")
                .HasColumnName("print_date");
            entity.Property(e => e.Role).HasMaxLength(500);
            entity.Property(e => e.RowName)
                .HasMaxLength(500)
                .HasColumnName("row_name");
            entity.Property(e => e.SeatNum).HasColumnName("seat_num");
            entity.Property(e => e.SectionName)
                .HasMaxLength(500)
                .HasColumnName("section_name");
            entity.Property(e => e.State)
                .HasMaxLength(500)
                .HasColumnName("state");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("street_addr_1");
            entity.Property(e => e.StreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("street_addr_2");
            entity.Property(e => e.TicketTypeCategory)
                .HasMaxLength(500)
                .HasColumnName("ticket_type_category");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Venue1Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue1_aisle");
            entity.Property(e => e.Venue1Gate)
                .HasMaxLength(500)
                .HasColumnName("venue1_gate");
            entity.Property(e => e.Venue1Row)
                .HasMaxLength(500)
                .HasColumnName("venue1_row");
            entity.Property(e => e.Venue1Seat)
                .HasMaxLength(500)
                .HasColumnName("venue1_seat");
            entity.Property(e => e.Venue1Section)
                .HasMaxLength(500)
                .HasColumnName("venue1_section");
            entity.Property(e => e.Venue1Stand)
                .HasMaxLength(500)
                .HasColumnName("venue1_stand");
            entity.Property(e => e.Venue2Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue2_aisle");
            entity.Property(e => e.Venue2Gate)
                .HasMaxLength(500)
                .HasColumnName("venue2_gate");
            entity.Property(e => e.Venue2Row)
                .HasMaxLength(500)
                .HasColumnName("venue2_row");
            entity.Property(e => e.Venue2Seat)
                .HasMaxLength(500)
                .HasColumnName("venue2_seat");
            entity.Property(e => e.Venue2Section)
                .HasMaxLength(500)
                .HasColumnName("venue2_section");
            entity.Property(e => e.Venue2Stand)
                .HasMaxLength(500)
                .HasColumnName("venue2_stand");
            entity.Property(e => e.YearsMembership).HasColumnName("years_membership");
            entity.Property(e => e.Zip)
                .HasMaxLength(500)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<RawData13718202202071113514674>(entity =>
        {
            entity.ToTable("RawData_137_18_202202071113514674");

            entity.Property(e => e.AcctId).HasColumnName("acct_id");
            entity.Property(e => e.AcctTypeDesc)
                .HasMaxLength(500)
                .HasColumnName("acct_type_desc");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Barcode)
                .HasMaxLength(500)
                .HasColumnName("barcode");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("birthdate");
            entity.Property(e => e.Card)
                .HasMaxLength(500)
                .HasColumnName("card");
            entity.Property(e => e.City)
                .HasMaxLength(500)
                .HasColumnName("city");
            entity.Property(e => e.ClubCode)
                .HasMaxLength(500)
                .HasColumnName("club_code");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(500)
                .HasColumnName("company_name");
            entity.Property(e => e.ConcessionText)
                .HasMaxLength(500)
                .HasColumnName("concession_text");
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .HasColumnName("country");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustNameId).HasColumnName("cust_name_id");
            entity.Property(e => e.DeliveryInstructions)
                .HasMaxLength(500)
                .HasColumnName("delivery_instructions");
            entity.Property(e => e.DeliveryMethodName)
                .HasMaxLength(500)
                .HasColumnName("delivery_method_name");
            entity.Property(e => e.EmailAddr)
                .HasMaxLength(500)
                .HasColumnName("email_addr");
            entity.Property(e => e.EventLine1)
                .HasMaxLength(500)
                .HasColumnName("event_line1");
            entity.Property(e => e.EventLine2)
                .HasMaxLength(500)
                .HasColumnName("event_line2");
            entity.Property(e => e.EventLine3)
                .HasMaxLength(500)
                .HasColumnName("event_line3");
            entity.Property(e => e.EventName)
                .HasMaxLength(500)
                .HasColumnName("event_name");
            entity.Property(e => e.FamilyId).HasColumnName("family_id");
            entity.Property(e => e.Fulfilment)
                .HasMaxLength(500)
                .HasColumnName("fulfilment");
            entity.Property(e => e.Gender)
                .HasMaxLength(500)
                .HasColumnName("gender");
            entity.Property(e => e.GroupCodes)
                .HasMaxLength(500)
                .HasColumnName("group_codes");
            entity.Property(e => e.GroupId)
                .HasMaxLength(500)
                .HasColumnName("GroupID");
            entity.Property(e => e.LocationCity)
                .HasMaxLength(500)
                .HasColumnName("location_city");
            entity.Property(e => e.LocationCountry)
                .HasMaxLength(500)
                .HasColumnName("location_country");
            entity.Property(e => e.LocationState)
                .HasMaxLength(500)
                .HasColumnName("location_state");
            entity.Property(e => e.LocationStreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_1");
            entity.Property(e => e.LocationStreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_2");
            entity.Property(e => e.LocationZip)
                .HasMaxLength(500)
                .HasColumnName("location_zip");
            entity.Property(e => e.MemberId).HasColumnName("member_id");
            entity.Property(e => e.MemberSince).HasColumnName("member_since");
            entity.Property(e => e.MembershipType)
                .HasMaxLength(500)
                .HasColumnName("membership_type");
            entity.Property(e => e.NameFirst)
                .HasMaxLength(500)
                .HasColumnName("name_first");
            entity.Property(e => e.NameLast)
                .HasMaxLength(500)
                .HasColumnName("name_last");
            entity.Property(e => e.Note1)
                .HasMaxLength(500)
                .HasColumnName("note1");
            entity.Property(e => e.NumSeats).HasColumnName("num_seats");
            entity.Property(e => e.OrderLineItem).HasColumnName("order_line_item");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.ParticipantId)
                .HasMaxLength(500)
                .HasColumnName("ParticipantID");
            entity.Property(e => e.PaymentPlan)
                .HasMaxLength(500)
                .HasColumnName("payment_plan");
            entity.Property(e => e.PhoneCell)
                .HasMaxLength(500)
                .HasColumnName("phone_cell");
            entity.Property(e => e.PhoneDay)
                .HasMaxLength(500)
                .HasColumnName("phone_day");
            entity.Property(e => e.PhoneEve)
                .HasMaxLength(500)
                .HasColumnName("phone_eve");
            entity.Property(e => e.PriceCode)
                .HasMaxLength(500)
                .HasColumnName("price_code");
            entity.Property(e => e.PriceCodeDesc)
                .HasMaxLength(500)
                .HasColumnName("price_code_desc");
            entity.Property(e => e.PriceCodeExtra)
                .HasMaxLength(500)
                .HasColumnName("price_code_extra");
            entity.Property(e => e.PriceCodeInfo1)
                .HasMaxLength(500)
                .HasColumnName("price_code_info1");
            entity.Property(e => e.PriceCodeInfo2)
                .HasMaxLength(500)
                .HasColumnName("price_code_info2");
            entity.Property(e => e.PriceCodeInfo3)
                .HasMaxLength(500)
                .HasColumnName("price_code_info3");
            entity.Property(e => e.PriceCodeInfo4)
                .HasMaxLength(500)
                .HasColumnName("price_code_info4");
            entity.Property(e => e.PrimaryName)
                .HasMaxLength(500)
                .HasColumnName("primary_name");
            entity.Property(e => e.PrintCount).HasColumnName("print_count");
            entity.Property(e => e.PrintDate)
                .HasColumnType("datetime")
                .HasColumnName("print_date");
            entity.Property(e => e.Role).HasMaxLength(500);
            entity.Property(e => e.RowName)
                .HasMaxLength(500)
                .HasColumnName("row_name");
            entity.Property(e => e.SeatNum).HasColumnName("seat_num");
            entity.Property(e => e.SectionName)
                .HasMaxLength(500)
                .HasColumnName("section_name");
            entity.Property(e => e.State)
                .HasMaxLength(500)
                .HasColumnName("state");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("street_addr_1");
            entity.Property(e => e.StreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("street_addr_2");
            entity.Property(e => e.TicketTypeCategory)
                .HasMaxLength(500)
                .HasColumnName("ticket_type_category");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Venue1Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue1_aisle");
            entity.Property(e => e.Venue1Gate)
                .HasMaxLength(500)
                .HasColumnName("venue1_gate");
            entity.Property(e => e.Venue1Row)
                .HasMaxLength(500)
                .HasColumnName("venue1_row");
            entity.Property(e => e.Venue1Seat)
                .HasMaxLength(500)
                .HasColumnName("venue1_seat");
            entity.Property(e => e.Venue1Section)
                .HasMaxLength(500)
                .HasColumnName("venue1_section");
            entity.Property(e => e.Venue1Stand)
                .HasMaxLength(500)
                .HasColumnName("venue1_stand");
            entity.Property(e => e.Venue2Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue2_aisle");
            entity.Property(e => e.Venue2Gate)
                .HasMaxLength(500)
                .HasColumnName("venue2_gate");
            entity.Property(e => e.Venue2Row)
                .HasMaxLength(500)
                .HasColumnName("venue2_row");
            entity.Property(e => e.Venue2Seat)
                .HasMaxLength(500)
                .HasColumnName("venue2_seat");
            entity.Property(e => e.Venue2Section)
                .HasMaxLength(500)
                .HasColumnName("venue2_section");
            entity.Property(e => e.Venue2Stand)
                .HasMaxLength(500)
                .HasColumnName("venue2_stand");
            entity.Property(e => e.YearsMembership).HasColumnName("years_membership");
            entity.Property(e => e.Zip)
                .HasMaxLength(500)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<RawData13718202202071132103561>(entity =>
        {
            entity.ToTable("RawData_137_18_202202071132103561");

            entity.Property(e => e.AcctId).HasColumnName("acct_id");
            entity.Property(e => e.AcctTypeDesc)
                .HasMaxLength(500)
                .HasColumnName("acct_type_desc");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Barcode)
                .HasMaxLength(500)
                .HasColumnName("barcode");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("birthdate");
            entity.Property(e => e.Card)
                .HasMaxLength(500)
                .HasColumnName("card");
            entity.Property(e => e.City)
                .HasMaxLength(500)
                .HasColumnName("city");
            entity.Property(e => e.ClubCode)
                .HasMaxLength(500)
                .HasColumnName("club_code");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(500)
                .HasColumnName("company_name");
            entity.Property(e => e.ConcessionText)
                .HasMaxLength(500)
                .HasColumnName("concession_text");
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .HasColumnName("country");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustNameId).HasColumnName("cust_name_id");
            entity.Property(e => e.DeliveryInstructions)
                .HasMaxLength(500)
                .HasColumnName("delivery_instructions");
            entity.Property(e => e.DeliveryMethodName)
                .HasMaxLength(500)
                .HasColumnName("delivery_method_name");
            entity.Property(e => e.EmailAddr)
                .HasMaxLength(500)
                .HasColumnName("email_addr");
            entity.Property(e => e.EventLine1)
                .HasMaxLength(500)
                .HasColumnName("event_line1");
            entity.Property(e => e.EventLine2)
                .HasMaxLength(500)
                .HasColumnName("event_line2");
            entity.Property(e => e.EventLine3)
                .HasMaxLength(500)
                .HasColumnName("event_line3");
            entity.Property(e => e.EventName)
                .HasMaxLength(500)
                .HasColumnName("event_name");
            entity.Property(e => e.FamilyId).HasColumnName("family_id");
            entity.Property(e => e.Fulfilment)
                .HasMaxLength(500)
                .HasColumnName("fulfilment");
            entity.Property(e => e.Gender)
                .HasMaxLength(500)
                .HasColumnName("gender");
            entity.Property(e => e.GroupCodes)
                .HasMaxLength(500)
                .HasColumnName("group_codes");
            entity.Property(e => e.GroupId)
                .HasMaxLength(500)
                .HasColumnName("GroupID");
            entity.Property(e => e.LocationCity)
                .HasMaxLength(500)
                .HasColumnName("location_city");
            entity.Property(e => e.LocationCountry)
                .HasMaxLength(500)
                .HasColumnName("location_country");
            entity.Property(e => e.LocationState)
                .HasMaxLength(500)
                .HasColumnName("location_state");
            entity.Property(e => e.LocationStreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_1");
            entity.Property(e => e.LocationStreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_2");
            entity.Property(e => e.LocationZip)
                .HasMaxLength(500)
                .HasColumnName("location_zip");
            entity.Property(e => e.MemberId).HasColumnName("member_id");
            entity.Property(e => e.MemberSince).HasColumnName("member_since");
            entity.Property(e => e.MembershipType)
                .HasMaxLength(500)
                .HasColumnName("membership_type");
            entity.Property(e => e.NameFirst)
                .HasMaxLength(500)
                .HasColumnName("name_first");
            entity.Property(e => e.NameLast)
                .HasMaxLength(500)
                .HasColumnName("name_last");
            entity.Property(e => e.Note1)
                .HasMaxLength(500)
                .HasColumnName("note1");
            entity.Property(e => e.NumSeats).HasColumnName("num_seats");
            entity.Property(e => e.OrderLineItem).HasColumnName("order_line_item");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.ParticipantId)
                .HasMaxLength(500)
                .HasColumnName("ParticipantID");
            entity.Property(e => e.PaymentPlan)
                .HasMaxLength(500)
                .HasColumnName("payment_plan");
            entity.Property(e => e.PhoneCell)
                .HasMaxLength(500)
                .HasColumnName("phone_cell");
            entity.Property(e => e.PhoneDay)
                .HasMaxLength(500)
                .HasColumnName("phone_day");
            entity.Property(e => e.PhoneEve)
                .HasMaxLength(500)
                .HasColumnName("phone_eve");
            entity.Property(e => e.PriceCode)
                .HasMaxLength(500)
                .HasColumnName("price_code");
            entity.Property(e => e.PriceCodeDesc)
                .HasMaxLength(500)
                .HasColumnName("price_code_desc");
            entity.Property(e => e.PriceCodeExtra)
                .HasMaxLength(500)
                .HasColumnName("price_code_extra");
            entity.Property(e => e.PriceCodeInfo1)
                .HasMaxLength(500)
                .HasColumnName("price_code_info1");
            entity.Property(e => e.PriceCodeInfo2)
                .HasMaxLength(500)
                .HasColumnName("price_code_info2");
            entity.Property(e => e.PriceCodeInfo3)
                .HasMaxLength(500)
                .HasColumnName("price_code_info3");
            entity.Property(e => e.PriceCodeInfo4)
                .HasMaxLength(500)
                .HasColumnName("price_code_info4");
            entity.Property(e => e.PrimaryName)
                .HasMaxLength(500)
                .HasColumnName("primary_name");
            entity.Property(e => e.PrintCount).HasColumnName("print_count");
            entity.Property(e => e.PrintDate)
                .HasColumnType("datetime")
                .HasColumnName("print_date");
            entity.Property(e => e.Role).HasMaxLength(500);
            entity.Property(e => e.RowName)
                .HasMaxLength(500)
                .HasColumnName("row_name");
            entity.Property(e => e.SeatNum).HasColumnName("seat_num");
            entity.Property(e => e.SectionName)
                .HasMaxLength(500)
                .HasColumnName("section_name");
            entity.Property(e => e.State)
                .HasMaxLength(500)
                .HasColumnName("state");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("street_addr_1");
            entity.Property(e => e.StreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("street_addr_2");
            entity.Property(e => e.TicketTypeCategory)
                .HasMaxLength(500)
                .HasColumnName("ticket_type_category");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Venue1Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue1_aisle");
            entity.Property(e => e.Venue1Gate)
                .HasMaxLength(500)
                .HasColumnName("venue1_gate");
            entity.Property(e => e.Venue1Row)
                .HasMaxLength(500)
                .HasColumnName("venue1_row");
            entity.Property(e => e.Venue1Seat)
                .HasMaxLength(500)
                .HasColumnName("venue1_seat");
            entity.Property(e => e.Venue1Section)
                .HasMaxLength(500)
                .HasColumnName("venue1_section");
            entity.Property(e => e.Venue1Stand)
                .HasMaxLength(500)
                .HasColumnName("venue1_stand");
            entity.Property(e => e.Venue2Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue2_aisle");
            entity.Property(e => e.Venue2Gate)
                .HasMaxLength(500)
                .HasColumnName("venue2_gate");
            entity.Property(e => e.Venue2Row)
                .HasMaxLength(500)
                .HasColumnName("venue2_row");
            entity.Property(e => e.Venue2Seat)
                .HasMaxLength(500)
                .HasColumnName("venue2_seat");
            entity.Property(e => e.Venue2Section)
                .HasMaxLength(500)
                .HasColumnName("venue2_section");
            entity.Property(e => e.Venue2Stand)
                .HasMaxLength(500)
                .HasColumnName("venue2_stand");
            entity.Property(e => e.YearsMembership).HasColumnName("years_membership");
            entity.Property(e => e.Zip)
                .HasMaxLength(500)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<RawData13718202202071132173005>(entity =>
        {
            entity.ToTable("RawData_137_18_202202071132173005");

            entity.Property(e => e.AcctId).HasColumnName("acct_id");
            entity.Property(e => e.AcctTypeDesc)
                .HasMaxLength(500)
                .HasColumnName("acct_type_desc");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Barcode)
                .HasMaxLength(500)
                .HasColumnName("barcode");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("birthdate");
            entity.Property(e => e.Card)
                .HasMaxLength(500)
                .HasColumnName("card");
            entity.Property(e => e.City)
                .HasMaxLength(500)
                .HasColumnName("city");
            entity.Property(e => e.ClubCode)
                .HasMaxLength(500)
                .HasColumnName("club_code");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(500)
                .HasColumnName("company_name");
            entity.Property(e => e.ConcessionText)
                .HasMaxLength(500)
                .HasColumnName("concession_text");
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .HasColumnName("country");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustNameId).HasColumnName("cust_name_id");
            entity.Property(e => e.DeliveryInstructions)
                .HasMaxLength(500)
                .HasColumnName("delivery_instructions");
            entity.Property(e => e.DeliveryMethodName)
                .HasMaxLength(500)
                .HasColumnName("delivery_method_name");
            entity.Property(e => e.EmailAddr)
                .HasMaxLength(500)
                .HasColumnName("email_addr");
            entity.Property(e => e.EventLine1)
                .HasMaxLength(500)
                .HasColumnName("event_line1");
            entity.Property(e => e.EventLine2)
                .HasMaxLength(500)
                .HasColumnName("event_line2");
            entity.Property(e => e.EventLine3)
                .HasMaxLength(500)
                .HasColumnName("event_line3");
            entity.Property(e => e.EventName)
                .HasMaxLength(500)
                .HasColumnName("event_name");
            entity.Property(e => e.FamilyId).HasColumnName("family_id");
            entity.Property(e => e.Fulfilment)
                .HasMaxLength(500)
                .HasColumnName("fulfilment");
            entity.Property(e => e.Gender)
                .HasMaxLength(500)
                .HasColumnName("gender");
            entity.Property(e => e.GroupCodes)
                .HasMaxLength(500)
                .HasColumnName("group_codes");
            entity.Property(e => e.GroupId)
                .HasMaxLength(500)
                .HasColumnName("GroupID");
            entity.Property(e => e.LocationCity)
                .HasMaxLength(500)
                .HasColumnName("location_city");
            entity.Property(e => e.LocationCountry)
                .HasMaxLength(500)
                .HasColumnName("location_country");
            entity.Property(e => e.LocationState)
                .HasMaxLength(500)
                .HasColumnName("location_state");
            entity.Property(e => e.LocationStreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_1");
            entity.Property(e => e.LocationStreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_2");
            entity.Property(e => e.LocationZip)
                .HasMaxLength(500)
                .HasColumnName("location_zip");
            entity.Property(e => e.MemberId).HasColumnName("member_id");
            entity.Property(e => e.MemberSince).HasColumnName("member_since");
            entity.Property(e => e.MembershipType)
                .HasMaxLength(500)
                .HasColumnName("membership_type");
            entity.Property(e => e.NameFirst)
                .HasMaxLength(500)
                .HasColumnName("name_first");
            entity.Property(e => e.NameLast)
                .HasMaxLength(500)
                .HasColumnName("name_last");
            entity.Property(e => e.Note1)
                .HasMaxLength(500)
                .HasColumnName("note1");
            entity.Property(e => e.NumSeats).HasColumnName("num_seats");
            entity.Property(e => e.OrderLineItem).HasColumnName("order_line_item");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.ParticipantId)
                .HasMaxLength(500)
                .HasColumnName("ParticipantID");
            entity.Property(e => e.PaymentPlan)
                .HasMaxLength(500)
                .HasColumnName("payment_plan");
            entity.Property(e => e.PhoneCell)
                .HasMaxLength(500)
                .HasColumnName("phone_cell");
            entity.Property(e => e.PhoneDay)
                .HasMaxLength(500)
                .HasColumnName("phone_day");
            entity.Property(e => e.PhoneEve)
                .HasMaxLength(500)
                .HasColumnName("phone_eve");
            entity.Property(e => e.PriceCode)
                .HasMaxLength(500)
                .HasColumnName("price_code");
            entity.Property(e => e.PriceCodeDesc)
                .HasMaxLength(500)
                .HasColumnName("price_code_desc");
            entity.Property(e => e.PriceCodeExtra)
                .HasMaxLength(500)
                .HasColumnName("price_code_extra");
            entity.Property(e => e.PriceCodeInfo1)
                .HasMaxLength(500)
                .HasColumnName("price_code_info1");
            entity.Property(e => e.PriceCodeInfo2)
                .HasMaxLength(500)
                .HasColumnName("price_code_info2");
            entity.Property(e => e.PriceCodeInfo3)
                .HasMaxLength(500)
                .HasColumnName("price_code_info3");
            entity.Property(e => e.PriceCodeInfo4)
                .HasMaxLength(500)
                .HasColumnName("price_code_info4");
            entity.Property(e => e.PrimaryName)
                .HasMaxLength(500)
                .HasColumnName("primary_name");
            entity.Property(e => e.PrintCount).HasColumnName("print_count");
            entity.Property(e => e.PrintDate)
                .HasColumnType("datetime")
                .HasColumnName("print_date");
            entity.Property(e => e.Role).HasMaxLength(500);
            entity.Property(e => e.RowName)
                .HasMaxLength(500)
                .HasColumnName("row_name");
            entity.Property(e => e.SeatNum).HasColumnName("seat_num");
            entity.Property(e => e.SectionName)
                .HasMaxLength(500)
                .HasColumnName("section_name");
            entity.Property(e => e.State)
                .HasMaxLength(500)
                .HasColumnName("state");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("street_addr_1");
            entity.Property(e => e.StreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("street_addr_2");
            entity.Property(e => e.TicketTypeCategory)
                .HasMaxLength(500)
                .HasColumnName("ticket_type_category");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Venue1Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue1_aisle");
            entity.Property(e => e.Venue1Gate)
                .HasMaxLength(500)
                .HasColumnName("venue1_gate");
            entity.Property(e => e.Venue1Row)
                .HasMaxLength(500)
                .HasColumnName("venue1_row");
            entity.Property(e => e.Venue1Seat)
                .HasMaxLength(500)
                .HasColumnName("venue1_seat");
            entity.Property(e => e.Venue1Section)
                .HasMaxLength(500)
                .HasColumnName("venue1_section");
            entity.Property(e => e.Venue1Stand)
                .HasMaxLength(500)
                .HasColumnName("venue1_stand");
            entity.Property(e => e.Venue2Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue2_aisle");
            entity.Property(e => e.Venue2Gate)
                .HasMaxLength(500)
                .HasColumnName("venue2_gate");
            entity.Property(e => e.Venue2Row)
                .HasMaxLength(500)
                .HasColumnName("venue2_row");
            entity.Property(e => e.Venue2Seat)
                .HasMaxLength(500)
                .HasColumnName("venue2_seat");
            entity.Property(e => e.Venue2Section)
                .HasMaxLength(500)
                .HasColumnName("venue2_section");
            entity.Property(e => e.Venue2Stand)
                .HasMaxLength(500)
                .HasColumnName("venue2_stand");
            entity.Property(e => e.YearsMembership).HasColumnName("years_membership");
            entity.Property(e => e.Zip)
                .HasMaxLength(500)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<RawData13718202202071135532127>(entity =>
        {
            entity.ToTable("RawData_137_18_202202071135532127");

            entity.Property(e => e.AcctId).HasColumnName("acct_id");
            entity.Property(e => e.AcctTypeDesc)
                .HasMaxLength(500)
                .HasColumnName("acct_type_desc");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Barcode)
                .HasMaxLength(500)
                .HasColumnName("barcode");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("birthdate");
            entity.Property(e => e.Card)
                .HasMaxLength(500)
                .HasColumnName("card");
            entity.Property(e => e.City)
                .HasMaxLength(500)
                .HasColumnName("city");
            entity.Property(e => e.ClubCode)
                .HasMaxLength(500)
                .HasColumnName("club_code");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(500)
                .HasColumnName("company_name");
            entity.Property(e => e.ConcessionText)
                .HasMaxLength(500)
                .HasColumnName("concession_text");
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .HasColumnName("country");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustNameId).HasColumnName("cust_name_id");
            entity.Property(e => e.DeliveryInstructions)
                .HasMaxLength(500)
                .HasColumnName("delivery_instructions");
            entity.Property(e => e.DeliveryMethodName)
                .HasMaxLength(500)
                .HasColumnName("delivery_method_name");
            entity.Property(e => e.EmailAddr)
                .HasMaxLength(500)
                .HasColumnName("email_addr");
            entity.Property(e => e.EventLine1)
                .HasMaxLength(500)
                .HasColumnName("event_line1");
            entity.Property(e => e.EventLine2)
                .HasMaxLength(500)
                .HasColumnName("event_line2");
            entity.Property(e => e.EventLine3)
                .HasMaxLength(500)
                .HasColumnName("event_line3");
            entity.Property(e => e.EventName)
                .HasMaxLength(500)
                .HasColumnName("event_name");
            entity.Property(e => e.FamilyId).HasColumnName("family_id");
            entity.Property(e => e.Fulfilment)
                .HasMaxLength(500)
                .HasColumnName("fulfilment");
            entity.Property(e => e.Gender)
                .HasMaxLength(500)
                .HasColumnName("gender");
            entity.Property(e => e.GroupCodes)
                .HasMaxLength(500)
                .HasColumnName("group_codes");
            entity.Property(e => e.GroupId)
                .HasMaxLength(500)
                .HasColumnName("GroupID");
            entity.Property(e => e.LocationCity)
                .HasMaxLength(500)
                .HasColumnName("location_city");
            entity.Property(e => e.LocationCountry)
                .HasMaxLength(500)
                .HasColumnName("location_country");
            entity.Property(e => e.LocationState)
                .HasMaxLength(500)
                .HasColumnName("location_state");
            entity.Property(e => e.LocationStreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_1");
            entity.Property(e => e.LocationStreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_2");
            entity.Property(e => e.LocationZip)
                .HasMaxLength(500)
                .HasColumnName("location_zip");
            entity.Property(e => e.MemberId).HasColumnName("member_id");
            entity.Property(e => e.MemberSince).HasColumnName("member_since");
            entity.Property(e => e.MembershipType)
                .HasMaxLength(500)
                .HasColumnName("membership_type");
            entity.Property(e => e.NameFirst)
                .HasMaxLength(500)
                .HasColumnName("name_first");
            entity.Property(e => e.NameLast)
                .HasMaxLength(500)
                .HasColumnName("name_last");
            entity.Property(e => e.Note1)
                .HasMaxLength(500)
                .HasColumnName("note1");
            entity.Property(e => e.NumSeats).HasColumnName("num_seats");
            entity.Property(e => e.OrderLineItem).HasColumnName("order_line_item");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.ParticipantId)
                .HasMaxLength(500)
                .HasColumnName("ParticipantID");
            entity.Property(e => e.PaymentPlan)
                .HasMaxLength(500)
                .HasColumnName("payment_plan");
            entity.Property(e => e.PhoneCell)
                .HasMaxLength(500)
                .HasColumnName("phone_cell");
            entity.Property(e => e.PhoneDay)
                .HasMaxLength(500)
                .HasColumnName("phone_day");
            entity.Property(e => e.PhoneEve)
                .HasMaxLength(500)
                .HasColumnName("phone_eve");
            entity.Property(e => e.PriceCode)
                .HasMaxLength(500)
                .HasColumnName("price_code");
            entity.Property(e => e.PriceCodeDesc)
                .HasMaxLength(500)
                .HasColumnName("price_code_desc");
            entity.Property(e => e.PriceCodeExtra)
                .HasMaxLength(500)
                .HasColumnName("price_code_extra");
            entity.Property(e => e.PriceCodeInfo1)
                .HasMaxLength(500)
                .HasColumnName("price_code_info1");
            entity.Property(e => e.PriceCodeInfo2)
                .HasMaxLength(500)
                .HasColumnName("price_code_info2");
            entity.Property(e => e.PriceCodeInfo3)
                .HasMaxLength(500)
                .HasColumnName("price_code_info3");
            entity.Property(e => e.PriceCodeInfo4)
                .HasMaxLength(500)
                .HasColumnName("price_code_info4");
            entity.Property(e => e.PrimaryName)
                .HasMaxLength(500)
                .HasColumnName("primary_name");
            entity.Property(e => e.PrintCount).HasColumnName("print_count");
            entity.Property(e => e.PrintDate)
                .HasColumnType("datetime")
                .HasColumnName("print_date");
            entity.Property(e => e.Role).HasMaxLength(500);
            entity.Property(e => e.RowName)
                .HasMaxLength(500)
                .HasColumnName("row_name");
            entity.Property(e => e.SeatNum).HasColumnName("seat_num");
            entity.Property(e => e.SectionName)
                .HasMaxLength(500)
                .HasColumnName("section_name");
            entity.Property(e => e.State)
                .HasMaxLength(500)
                .HasColumnName("state");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("street_addr_1");
            entity.Property(e => e.StreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("street_addr_2");
            entity.Property(e => e.TicketTypeCategory)
                .HasMaxLength(500)
                .HasColumnName("ticket_type_category");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Venue1Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue1_aisle");
            entity.Property(e => e.Venue1Gate)
                .HasMaxLength(500)
                .HasColumnName("venue1_gate");
            entity.Property(e => e.Venue1Row)
                .HasMaxLength(500)
                .HasColumnName("venue1_row");
            entity.Property(e => e.Venue1Seat)
                .HasMaxLength(500)
                .HasColumnName("venue1_seat");
            entity.Property(e => e.Venue1Section)
                .HasMaxLength(500)
                .HasColumnName("venue1_section");
            entity.Property(e => e.Venue1Stand)
                .HasMaxLength(500)
                .HasColumnName("venue1_stand");
            entity.Property(e => e.Venue2Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue2_aisle");
            entity.Property(e => e.Venue2Gate)
                .HasMaxLength(500)
                .HasColumnName("venue2_gate");
            entity.Property(e => e.Venue2Row)
                .HasMaxLength(500)
                .HasColumnName("venue2_row");
            entity.Property(e => e.Venue2Seat)
                .HasMaxLength(500)
                .HasColumnName("venue2_seat");
            entity.Property(e => e.Venue2Section)
                .HasMaxLength(500)
                .HasColumnName("venue2_section");
            entity.Property(e => e.Venue2Stand)
                .HasMaxLength(500)
                .HasColumnName("venue2_stand");
            entity.Property(e => e.YearsMembership).HasColumnName("years_membership");
            entity.Property(e => e.Zip)
                .HasMaxLength(500)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<RawData13718202202071135562057>(entity =>
        {
            entity.ToTable("RawData_137_18_202202071135562057");

            entity.Property(e => e.AcctId).HasColumnName("acct_id");
            entity.Property(e => e.AcctTypeDesc)
                .HasMaxLength(500)
                .HasColumnName("acct_type_desc");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Barcode)
                .HasMaxLength(500)
                .HasColumnName("barcode");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("birthdate");
            entity.Property(e => e.Card)
                .HasMaxLength(500)
                .HasColumnName("card");
            entity.Property(e => e.City)
                .HasMaxLength(500)
                .HasColumnName("city");
            entity.Property(e => e.ClubCode)
                .HasMaxLength(500)
                .HasColumnName("club_code");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(500)
                .HasColumnName("company_name");
            entity.Property(e => e.ConcessionText)
                .HasMaxLength(500)
                .HasColumnName("concession_text");
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .HasColumnName("country");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustNameId).HasColumnName("cust_name_id");
            entity.Property(e => e.DeliveryInstructions)
                .HasMaxLength(500)
                .HasColumnName("delivery_instructions");
            entity.Property(e => e.DeliveryMethodName)
                .HasMaxLength(500)
                .HasColumnName("delivery_method_name");
            entity.Property(e => e.EmailAddr)
                .HasMaxLength(500)
                .HasColumnName("email_addr");
            entity.Property(e => e.EventLine1)
                .HasMaxLength(500)
                .HasColumnName("event_line1");
            entity.Property(e => e.EventLine2)
                .HasMaxLength(500)
                .HasColumnName("event_line2");
            entity.Property(e => e.EventLine3)
                .HasMaxLength(500)
                .HasColumnName("event_line3");
            entity.Property(e => e.EventName)
                .HasMaxLength(500)
                .HasColumnName("event_name");
            entity.Property(e => e.FamilyId).HasColumnName("family_id");
            entity.Property(e => e.Fulfilment)
                .HasMaxLength(500)
                .HasColumnName("fulfilment");
            entity.Property(e => e.Gender)
                .HasMaxLength(500)
                .HasColumnName("gender");
            entity.Property(e => e.GroupCodes)
                .HasMaxLength(500)
                .HasColumnName("group_codes");
            entity.Property(e => e.GroupId)
                .HasMaxLength(500)
                .HasColumnName("GroupID");
            entity.Property(e => e.LocationCity)
                .HasMaxLength(500)
                .HasColumnName("location_city");
            entity.Property(e => e.LocationCountry)
                .HasMaxLength(500)
                .HasColumnName("location_country");
            entity.Property(e => e.LocationState)
                .HasMaxLength(500)
                .HasColumnName("location_state");
            entity.Property(e => e.LocationStreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_1");
            entity.Property(e => e.LocationStreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_2");
            entity.Property(e => e.LocationZip)
                .HasMaxLength(500)
                .HasColumnName("location_zip");
            entity.Property(e => e.MemberId).HasColumnName("member_id");
            entity.Property(e => e.MemberSince).HasColumnName("member_since");
            entity.Property(e => e.MembershipType)
                .HasMaxLength(500)
                .HasColumnName("membership_type");
            entity.Property(e => e.NameFirst)
                .HasMaxLength(500)
                .HasColumnName("name_first");
            entity.Property(e => e.NameLast)
                .HasMaxLength(500)
                .HasColumnName("name_last");
            entity.Property(e => e.Note1)
                .HasMaxLength(500)
                .HasColumnName("note1");
            entity.Property(e => e.NumSeats).HasColumnName("num_seats");
            entity.Property(e => e.OrderLineItem).HasColumnName("order_line_item");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.ParticipantId)
                .HasMaxLength(500)
                .HasColumnName("ParticipantID");
            entity.Property(e => e.PaymentPlan)
                .HasMaxLength(500)
                .HasColumnName("payment_plan");
            entity.Property(e => e.PhoneCell)
                .HasMaxLength(500)
                .HasColumnName("phone_cell");
            entity.Property(e => e.PhoneDay)
                .HasMaxLength(500)
                .HasColumnName("phone_day");
            entity.Property(e => e.PhoneEve)
                .HasMaxLength(500)
                .HasColumnName("phone_eve");
            entity.Property(e => e.PriceCode)
                .HasMaxLength(500)
                .HasColumnName("price_code");
            entity.Property(e => e.PriceCodeDesc)
                .HasMaxLength(500)
                .HasColumnName("price_code_desc");
            entity.Property(e => e.PriceCodeExtra)
                .HasMaxLength(500)
                .HasColumnName("price_code_extra");
            entity.Property(e => e.PriceCodeInfo1)
                .HasMaxLength(500)
                .HasColumnName("price_code_info1");
            entity.Property(e => e.PriceCodeInfo2)
                .HasMaxLength(500)
                .HasColumnName("price_code_info2");
            entity.Property(e => e.PriceCodeInfo3)
                .HasMaxLength(500)
                .HasColumnName("price_code_info3");
            entity.Property(e => e.PriceCodeInfo4)
                .HasMaxLength(500)
                .HasColumnName("price_code_info4");
            entity.Property(e => e.PrimaryName)
                .HasMaxLength(500)
                .HasColumnName("primary_name");
            entity.Property(e => e.PrintCount).HasColumnName("print_count");
            entity.Property(e => e.PrintDate)
                .HasColumnType("datetime")
                .HasColumnName("print_date");
            entity.Property(e => e.Role).HasMaxLength(500);
            entity.Property(e => e.RowName)
                .HasMaxLength(500)
                .HasColumnName("row_name");
            entity.Property(e => e.SeatNum).HasColumnName("seat_num");
            entity.Property(e => e.SectionName)
                .HasMaxLength(500)
                .HasColumnName("section_name");
            entity.Property(e => e.State)
                .HasMaxLength(500)
                .HasColumnName("state");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("street_addr_1");
            entity.Property(e => e.StreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("street_addr_2");
            entity.Property(e => e.TicketTypeCategory)
                .HasMaxLength(500)
                .HasColumnName("ticket_type_category");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Venue1Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue1_aisle");
            entity.Property(e => e.Venue1Gate)
                .HasMaxLength(500)
                .HasColumnName("venue1_gate");
            entity.Property(e => e.Venue1Row)
                .HasMaxLength(500)
                .HasColumnName("venue1_row");
            entity.Property(e => e.Venue1Seat)
                .HasMaxLength(500)
                .HasColumnName("venue1_seat");
            entity.Property(e => e.Venue1Section)
                .HasMaxLength(500)
                .HasColumnName("venue1_section");
            entity.Property(e => e.Venue1Stand)
                .HasMaxLength(500)
                .HasColumnName("venue1_stand");
            entity.Property(e => e.Venue2Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue2_aisle");
            entity.Property(e => e.Venue2Gate)
                .HasMaxLength(500)
                .HasColumnName("venue2_gate");
            entity.Property(e => e.Venue2Row)
                .HasMaxLength(500)
                .HasColumnName("venue2_row");
            entity.Property(e => e.Venue2Seat)
                .HasMaxLength(500)
                .HasColumnName("venue2_seat");
            entity.Property(e => e.Venue2Section)
                .HasMaxLength(500)
                .HasColumnName("venue2_section");
            entity.Property(e => e.Venue2Stand)
                .HasMaxLength(500)
                .HasColumnName("venue2_stand");
            entity.Property(e => e.YearsMembership).HasColumnName("years_membership");
            entity.Property(e => e.Zip)
                .HasMaxLength(500)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<RawData13718202202071143436604>(entity =>
        {
            entity.ToTable("RawData_137_18_202202071143436604");

            entity.Property(e => e.AcctId).HasColumnName("acct_id");
            entity.Property(e => e.AcctTypeDesc)
                .HasMaxLength(500)
                .HasColumnName("acct_type_desc");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Barcode)
                .HasMaxLength(500)
                .HasColumnName("barcode");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("birthdate");
            entity.Property(e => e.Card)
                .HasMaxLength(500)
                .HasColumnName("card");
            entity.Property(e => e.City)
                .HasMaxLength(500)
                .HasColumnName("city");
            entity.Property(e => e.ClubCode)
                .HasMaxLength(500)
                .HasColumnName("club_code");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(500)
                .HasColumnName("company_name");
            entity.Property(e => e.ConcessionText)
                .HasMaxLength(500)
                .HasColumnName("concession_text");
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .HasColumnName("country");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustNameId).HasColumnName("cust_name_id");
            entity.Property(e => e.DeliveryInstructions)
                .HasMaxLength(500)
                .HasColumnName("delivery_instructions");
            entity.Property(e => e.DeliveryMethodName)
                .HasMaxLength(500)
                .HasColumnName("delivery_method_name");
            entity.Property(e => e.EmailAddr)
                .HasMaxLength(500)
                .HasColumnName("email_addr");
            entity.Property(e => e.EventLine1)
                .HasMaxLength(500)
                .HasColumnName("event_line1");
            entity.Property(e => e.EventLine2)
                .HasMaxLength(500)
                .HasColumnName("event_line2");
            entity.Property(e => e.EventLine3)
                .HasMaxLength(500)
                .HasColumnName("event_line3");
            entity.Property(e => e.EventName)
                .HasMaxLength(500)
                .HasColumnName("event_name");
            entity.Property(e => e.FamilyId).HasColumnName("family_id");
            entity.Property(e => e.Fulfilment)
                .HasMaxLength(500)
                .HasColumnName("fulfilment");
            entity.Property(e => e.Gender)
                .HasMaxLength(500)
                .HasColumnName("gender");
            entity.Property(e => e.GroupCodes)
                .HasMaxLength(500)
                .HasColumnName("group_codes");
            entity.Property(e => e.GroupId)
                .HasMaxLength(500)
                .HasColumnName("GroupID");
            entity.Property(e => e.LocationCity)
                .HasMaxLength(500)
                .HasColumnName("location_city");
            entity.Property(e => e.LocationCountry)
                .HasMaxLength(500)
                .HasColumnName("location_country");
            entity.Property(e => e.LocationState)
                .HasMaxLength(500)
                .HasColumnName("location_state");
            entity.Property(e => e.LocationStreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_1");
            entity.Property(e => e.LocationStreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_2");
            entity.Property(e => e.LocationZip)
                .HasMaxLength(500)
                .HasColumnName("location_zip");
            entity.Property(e => e.MemberId).HasColumnName("member_id");
            entity.Property(e => e.MemberSince).HasColumnName("member_since");
            entity.Property(e => e.MembershipType)
                .HasMaxLength(500)
                .HasColumnName("membership_type");
            entity.Property(e => e.NameFirst)
                .HasMaxLength(500)
                .HasColumnName("name_first");
            entity.Property(e => e.NameLast)
                .HasMaxLength(500)
                .HasColumnName("name_last");
            entity.Property(e => e.Note1)
                .HasMaxLength(500)
                .HasColumnName("note1");
            entity.Property(e => e.NumSeats).HasColumnName("num_seats");
            entity.Property(e => e.OrderLineItem).HasColumnName("order_line_item");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.ParticipantId)
                .HasMaxLength(500)
                .HasColumnName("ParticipantID");
            entity.Property(e => e.PaymentPlan)
                .HasMaxLength(500)
                .HasColumnName("payment_plan");
            entity.Property(e => e.PhoneCell)
                .HasMaxLength(500)
                .HasColumnName("phone_cell");
            entity.Property(e => e.PhoneDay)
                .HasMaxLength(500)
                .HasColumnName("phone_day");
            entity.Property(e => e.PhoneEve)
                .HasMaxLength(500)
                .HasColumnName("phone_eve");
            entity.Property(e => e.PriceCode)
                .HasMaxLength(500)
                .HasColumnName("price_code");
            entity.Property(e => e.PriceCodeDesc)
                .HasMaxLength(500)
                .HasColumnName("price_code_desc");
            entity.Property(e => e.PriceCodeExtra)
                .HasMaxLength(500)
                .HasColumnName("price_code_extra");
            entity.Property(e => e.PriceCodeInfo1)
                .HasMaxLength(500)
                .HasColumnName("price_code_info1");
            entity.Property(e => e.PriceCodeInfo2)
                .HasMaxLength(500)
                .HasColumnName("price_code_info2");
            entity.Property(e => e.PriceCodeInfo3)
                .HasMaxLength(500)
                .HasColumnName("price_code_info3");
            entity.Property(e => e.PriceCodeInfo4)
                .HasMaxLength(500)
                .HasColumnName("price_code_info4");
            entity.Property(e => e.PrimaryName)
                .HasMaxLength(500)
                .HasColumnName("primary_name");
            entity.Property(e => e.PrintCount).HasColumnName("print_count");
            entity.Property(e => e.PrintDate)
                .HasColumnType("datetime")
                .HasColumnName("print_date");
            entity.Property(e => e.Role).HasMaxLength(500);
            entity.Property(e => e.RowName)
                .HasMaxLength(500)
                .HasColumnName("row_name");
            entity.Property(e => e.SeatNum).HasColumnName("seat_num");
            entity.Property(e => e.SectionName)
                .HasMaxLength(500)
                .HasColumnName("section_name");
            entity.Property(e => e.State)
                .HasMaxLength(500)
                .HasColumnName("state");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("street_addr_1");
            entity.Property(e => e.StreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("street_addr_2");
            entity.Property(e => e.TicketTypeCategory)
                .HasMaxLength(500)
                .HasColumnName("ticket_type_category");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Venue1Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue1_aisle");
            entity.Property(e => e.Venue1Gate)
                .HasMaxLength(500)
                .HasColumnName("venue1_gate");
            entity.Property(e => e.Venue1Row)
                .HasMaxLength(500)
                .HasColumnName("venue1_row");
            entity.Property(e => e.Venue1Seat)
                .HasMaxLength(500)
                .HasColumnName("venue1_seat");
            entity.Property(e => e.Venue1Section)
                .HasMaxLength(500)
                .HasColumnName("venue1_section");
            entity.Property(e => e.Venue1Stand)
                .HasMaxLength(500)
                .HasColumnName("venue1_stand");
            entity.Property(e => e.Venue2Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue2_aisle");
            entity.Property(e => e.Venue2Gate)
                .HasMaxLength(500)
                .HasColumnName("venue2_gate");
            entity.Property(e => e.Venue2Row)
                .HasMaxLength(500)
                .HasColumnName("venue2_row");
            entity.Property(e => e.Venue2Seat)
                .HasMaxLength(500)
                .HasColumnName("venue2_seat");
            entity.Property(e => e.Venue2Section)
                .HasMaxLength(500)
                .HasColumnName("venue2_section");
            entity.Property(e => e.Venue2Stand)
                .HasMaxLength(500)
                .HasColumnName("venue2_stand");
            entity.Property(e => e.YearsMembership).HasColumnName("years_membership");
            entity.Property(e => e.Zip)
                .HasMaxLength(500)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<RawData13718202202071143464421>(entity =>
        {
            entity.ToTable("RawData_137_18_202202071143464421");

            entity.Property(e => e.AcctId).HasColumnName("acct_id");
            entity.Property(e => e.AcctTypeDesc)
                .HasMaxLength(500)
                .HasColumnName("acct_type_desc");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Barcode)
                .HasMaxLength(500)
                .HasColumnName("barcode");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("birthdate");
            entity.Property(e => e.Card)
                .HasMaxLength(500)
                .HasColumnName("card");
            entity.Property(e => e.City)
                .HasMaxLength(500)
                .HasColumnName("city");
            entity.Property(e => e.ClubCode)
                .HasMaxLength(500)
                .HasColumnName("club_code");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(500)
                .HasColumnName("company_name");
            entity.Property(e => e.ConcessionText)
                .HasMaxLength(500)
                .HasColumnName("concession_text");
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .HasColumnName("country");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustNameId).HasColumnName("cust_name_id");
            entity.Property(e => e.DeliveryInstructions)
                .HasMaxLength(500)
                .HasColumnName("delivery_instructions");
            entity.Property(e => e.DeliveryMethodName)
                .HasMaxLength(500)
                .HasColumnName("delivery_method_name");
            entity.Property(e => e.EmailAddr)
                .HasMaxLength(500)
                .HasColumnName("email_addr");
            entity.Property(e => e.EventLine1)
                .HasMaxLength(500)
                .HasColumnName("event_line1");
            entity.Property(e => e.EventLine2)
                .HasMaxLength(500)
                .HasColumnName("event_line2");
            entity.Property(e => e.EventLine3)
                .HasMaxLength(500)
                .HasColumnName("event_line3");
            entity.Property(e => e.EventName)
                .HasMaxLength(500)
                .HasColumnName("event_name");
            entity.Property(e => e.FamilyId).HasColumnName("family_id");
            entity.Property(e => e.Fulfilment)
                .HasMaxLength(500)
                .HasColumnName("fulfilment");
            entity.Property(e => e.Gender)
                .HasMaxLength(500)
                .HasColumnName("gender");
            entity.Property(e => e.GroupCodes)
                .HasMaxLength(500)
                .HasColumnName("group_codes");
            entity.Property(e => e.GroupId)
                .HasMaxLength(500)
                .HasColumnName("GroupID");
            entity.Property(e => e.LocationCity)
                .HasMaxLength(500)
                .HasColumnName("location_city");
            entity.Property(e => e.LocationCountry)
                .HasMaxLength(500)
                .HasColumnName("location_country");
            entity.Property(e => e.LocationState)
                .HasMaxLength(500)
                .HasColumnName("location_state");
            entity.Property(e => e.LocationStreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_1");
            entity.Property(e => e.LocationStreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_2");
            entity.Property(e => e.LocationZip)
                .HasMaxLength(500)
                .HasColumnName("location_zip");
            entity.Property(e => e.MemberId).HasColumnName("member_id");
            entity.Property(e => e.MemberSince).HasColumnName("member_since");
            entity.Property(e => e.MembershipType)
                .HasMaxLength(500)
                .HasColumnName("membership_type");
            entity.Property(e => e.NameFirst)
                .HasMaxLength(500)
                .HasColumnName("name_first");
            entity.Property(e => e.NameLast)
                .HasMaxLength(500)
                .HasColumnName("name_last");
            entity.Property(e => e.Note1)
                .HasMaxLength(500)
                .HasColumnName("note1");
            entity.Property(e => e.NumSeats).HasColumnName("num_seats");
            entity.Property(e => e.OrderLineItem).HasColumnName("order_line_item");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.ParticipantId)
                .HasMaxLength(500)
                .HasColumnName("ParticipantID");
            entity.Property(e => e.PaymentPlan)
                .HasMaxLength(500)
                .HasColumnName("payment_plan");
            entity.Property(e => e.PhoneCell)
                .HasMaxLength(500)
                .HasColumnName("phone_cell");
            entity.Property(e => e.PhoneDay)
                .HasMaxLength(500)
                .HasColumnName("phone_day");
            entity.Property(e => e.PhoneEve)
                .HasMaxLength(500)
                .HasColumnName("phone_eve");
            entity.Property(e => e.PriceCode)
                .HasMaxLength(500)
                .HasColumnName("price_code");
            entity.Property(e => e.PriceCodeDesc)
                .HasMaxLength(500)
                .HasColumnName("price_code_desc");
            entity.Property(e => e.PriceCodeExtra)
                .HasMaxLength(500)
                .HasColumnName("price_code_extra");
            entity.Property(e => e.PriceCodeInfo1)
                .HasMaxLength(500)
                .HasColumnName("price_code_info1");
            entity.Property(e => e.PriceCodeInfo2)
                .HasMaxLength(500)
                .HasColumnName("price_code_info2");
            entity.Property(e => e.PriceCodeInfo3)
                .HasMaxLength(500)
                .HasColumnName("price_code_info3");
            entity.Property(e => e.PriceCodeInfo4)
                .HasMaxLength(500)
                .HasColumnName("price_code_info4");
            entity.Property(e => e.PrimaryName)
                .HasMaxLength(500)
                .HasColumnName("primary_name");
            entity.Property(e => e.PrintCount).HasColumnName("print_count");
            entity.Property(e => e.PrintDate)
                .HasColumnType("datetime")
                .HasColumnName("print_date");
            entity.Property(e => e.Role).HasMaxLength(500);
            entity.Property(e => e.RowName)
                .HasMaxLength(500)
                .HasColumnName("row_name");
            entity.Property(e => e.SeatNum).HasColumnName("seat_num");
            entity.Property(e => e.SectionName)
                .HasMaxLength(500)
                .HasColumnName("section_name");
            entity.Property(e => e.State)
                .HasMaxLength(500)
                .HasColumnName("state");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("street_addr_1");
            entity.Property(e => e.StreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("street_addr_2");
            entity.Property(e => e.TicketTypeCategory)
                .HasMaxLength(500)
                .HasColumnName("ticket_type_category");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Venue1Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue1_aisle");
            entity.Property(e => e.Venue1Gate)
                .HasMaxLength(500)
                .HasColumnName("venue1_gate");
            entity.Property(e => e.Venue1Row)
                .HasMaxLength(500)
                .HasColumnName("venue1_row");
            entity.Property(e => e.Venue1Seat)
                .HasMaxLength(500)
                .HasColumnName("venue1_seat");
            entity.Property(e => e.Venue1Section)
                .HasMaxLength(500)
                .HasColumnName("venue1_section");
            entity.Property(e => e.Venue1Stand)
                .HasMaxLength(500)
                .HasColumnName("venue1_stand");
            entity.Property(e => e.Venue2Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue2_aisle");
            entity.Property(e => e.Venue2Gate)
                .HasMaxLength(500)
                .HasColumnName("venue2_gate");
            entity.Property(e => e.Venue2Row)
                .HasMaxLength(500)
                .HasColumnName("venue2_row");
            entity.Property(e => e.Venue2Seat)
                .HasMaxLength(500)
                .HasColumnName("venue2_seat");
            entity.Property(e => e.Venue2Section)
                .HasMaxLength(500)
                .HasColumnName("venue2_section");
            entity.Property(e => e.Venue2Stand)
                .HasMaxLength(500)
                .HasColumnName("venue2_stand");
            entity.Property(e => e.YearsMembership).HasColumnName("years_membership");
            entity.Property(e => e.Zip)
                .HasMaxLength(500)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<RawData13765202202150748263099>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_RawData_137_18_202202150748263099");

            entity.ToTable("RawData_137_65_202202150748263099");

            entity.HasIndex(e => e.EmpGroupId, "EMP_GroupID");

            entity.HasIndex(e => new { e.EmpUserId, e.UploadId }, "EMP_UserId");

            entity.HasIndex(e => e.UploadId, "UploadId");

            entity.Property(e => e.AcctId).HasColumnName("acct_id");
            entity.Property(e => e.AcctTypeDesc)
                .HasMaxLength(500)
                .HasColumnName("acct_type_desc");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Barcode)
                .HasMaxLength(500)
                .HasColumnName("barcode");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("birthdate");
            entity.Property(e => e.Card)
                .HasMaxLength(500)
                .HasColumnName("card");
            entity.Property(e => e.City)
                .HasMaxLength(500)
                .HasColumnName("city");
            entity.Property(e => e.ClubCode)
                .HasMaxLength(500)
                .HasColumnName("club_code");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(500)
                .HasColumnName("company_name");
            entity.Property(e => e.ConcessionText)
                .HasMaxLength(500)
                .HasColumnName("concession_text");
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .HasColumnName("country");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustNameId).HasColumnName("cust_name_id");
            entity.Property(e => e.DeliveryInstructions)
                .HasMaxLength(500)
                .HasColumnName("delivery_instructions");
            entity.Property(e => e.DeliveryMethodName)
                .HasMaxLength(500)
                .HasColumnName("delivery_method_name");
            entity.Property(e => e.EmailAddr)
                .HasMaxLength(500)
                .HasColumnName("email_addr");
            entity.Property(e => e.EmpAcctStatus).HasColumnName("EMP_AcctStatus");
            entity.Property(e => e.EmpCredit)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("EMP_Credit");
            entity.Property(e => e.EmpDisplayOrder).HasColumnName("EMP_DisplayOrder");
            entity.Property(e => e.EmpErrorCode)
                .HasMaxLength(200)
                .HasColumnName("EMP_ErrorCode");
            entity.Property(e => e.EmpGender)
                .HasMaxLength(200)
                .HasColumnName("EMP_Gender");
            entity.Property(e => e.EmpGroupId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupId");
            entity.Property(e => e.EmpGroupUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupUserId");
            entity.Property(e => e.EmpIsCardOnly).HasColumnName("EMP_IsCardOnly");
            entity.Property(e => e.EmpIsMain)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_IsMain");
            entity.Property(e => e.EmpLoginAcctStatus).HasColumnName("EMP_LoginAcctStatus");
            entity.Property(e => e.EmpParticipantId).HasColumnName("EMP_ParticipantId");
            entity.Property(e => e.EmpProgramId).HasColumnName("EMP_ProgramId");
            entity.Property(e => e.EmpProgramName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ProgramName");
            entity.Property(e => e.EmpRecordInActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_RecordInActive");
            entity.Property(e => e.EmpRecordType)
                .HasMaxLength(200)
                .HasColumnName("EMP_RecordType");
            entity.Property(e => e.EmpRedeemed).HasColumnName("EMP_Redeemed");
            entity.Property(e => e.EmpSeasonId).HasColumnName("EMP_SeasonID");
            entity.Property(e => e.EmpShopName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ShopName");
            entity.Property(e => e.EmpUniqueKey)
                .HasMaxLength(300)
                .HasColumnName("EMP_UniqueKey");
            entity.Property(e => e.EmpUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_UserId");
            entity.Property(e => e.EmpUserTypeId).HasColumnName("EMP_UserTypeId");
            entity.Property(e => e.EmpUsername)
                .HasMaxLength(200)
                .HasColumnName("EMP_Username");
            entity.Property(e => e.EmpXmlData)
                .HasColumnType("xml")
                .HasColumnName("EMP_XmlData");
            entity.Property(e => e.EventLine1)
                .HasMaxLength(500)
                .HasColumnName("event_line1");
            entity.Property(e => e.EventLine2)
                .HasMaxLength(500)
                .HasColumnName("event_line2");
            entity.Property(e => e.EventLine3)
                .HasMaxLength(500)
                .HasColumnName("event_line3");
            entity.Property(e => e.EventName)
                .HasMaxLength(500)
                .HasColumnName("event_name");
            entity.Property(e => e.FamilyId).HasColumnName("family_id");
            entity.Property(e => e.Fulfilment)
                .HasMaxLength(500)
                .HasColumnName("fulfilment");
            entity.Property(e => e.FulfilmentChoice)
                .HasMaxLength(500)
                .HasColumnName("fulfilment_choice");
            entity.Property(e => e.FulfilmentQty).HasColumnName("fulfilment_qty");
            entity.Property(e => e.Gender)
                .HasMaxLength(500)
                .HasColumnName("gender");
            entity.Property(e => e.GroupCodes)
                .HasMaxLength(500)
                .HasColumnName("group_codes");
            entity.Property(e => e.LocationCity)
                .HasMaxLength(500)
                .HasColumnName("location_city");
            entity.Property(e => e.LocationCountry)
                .HasMaxLength(500)
                .HasColumnName("location_country");
            entity.Property(e => e.LocationState)
                .HasMaxLength(500)
                .HasColumnName("location_state");
            entity.Property(e => e.LocationStreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_1");
            entity.Property(e => e.LocationStreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_2");
            entity.Property(e => e.LocationZip)
                .HasMaxLength(500)
                .HasColumnName("location_zip");
            entity.Property(e => e.MemberId).HasColumnName("member_id");
            entity.Property(e => e.MemberSince).HasColumnName("member_since");
            entity.Property(e => e.MembershipType)
                .HasMaxLength(500)
                .HasColumnName("membership_type");
            entity.Property(e => e.NameFirst)
                .HasMaxLength(500)
                .HasColumnName("name_first");
            entity.Property(e => e.NameLast)
                .HasMaxLength(500)
                .HasColumnName("name_last");
            entity.Property(e => e.Note1)
                .HasMaxLength(500)
                .HasColumnName("note1");
            entity.Property(e => e.NumSeats).HasColumnName("num_seats");
            entity.Property(e => e.OrderLineItem).HasColumnName("order_line_item");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.PaymentPlan)
                .HasMaxLength(500)
                .HasColumnName("payment_plan");
            entity.Property(e => e.PhoneCell)
                .HasMaxLength(500)
                .HasColumnName("phone_cell");
            entity.Property(e => e.PhoneDay)
                .HasMaxLength(500)
                .HasColumnName("phone_day");
            entity.Property(e => e.PhoneEve)
                .HasMaxLength(500)
                .HasColumnName("phone_eve");
            entity.Property(e => e.PriceCode)
                .HasMaxLength(500)
                .HasColumnName("price_code");
            entity.Property(e => e.PriceCodeDesc)
                .HasMaxLength(500)
                .HasColumnName("price_code_desc");
            entity.Property(e => e.PriceCodeExtra)
                .HasMaxLength(500)
                .HasColumnName("price_code_extra");
            entity.Property(e => e.PriceCodeInfo1)
                .HasMaxLength(500)
                .HasColumnName("price_code_info1");
            entity.Property(e => e.PriceCodeInfo2)
                .HasMaxLength(500)
                .HasColumnName("price_code_info2");
            entity.Property(e => e.PriceCodeInfo3)
                .HasMaxLength(500)
                .HasColumnName("price_code_info3");
            entity.Property(e => e.PriceCodeInfo4)
                .HasMaxLength(500)
                .HasColumnName("price_code_info4");
            entity.Property(e => e.PrimaryName)
                .HasMaxLength(500)
                .HasColumnName("primary_name");
            entity.Property(e => e.PrintCount).HasColumnName("print_count");
            entity.Property(e => e.PrintDate)
                .HasColumnType("datetime")
                .HasColumnName("print_date");
            entity.Property(e => e.RowName)
                .HasMaxLength(500)
                .HasColumnName("row_name");
            entity.Property(e => e.SeatNum).HasColumnName("seat_num");
            entity.Property(e => e.SectionName)
                .HasMaxLength(500)
                .HasColumnName("section_name");
            entity.Property(e => e.State)
                .HasMaxLength(500)
                .HasColumnName("state");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("street_addr_1");
            entity.Property(e => e.StreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("street_addr_2");
            entity.Property(e => e.TicketTypeCategory)
                .HasMaxLength(500)
                .HasColumnName("ticket_type_category");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Venue1Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue1_aisle");
            entity.Property(e => e.Venue1Gate)
                .HasMaxLength(500)
                .HasColumnName("venue1_gate");
            entity.Property(e => e.Venue1Row)
                .HasMaxLength(500)
                .HasColumnName("venue1_row");
            entity.Property(e => e.Venue1Seat)
                .HasMaxLength(500)
                .HasColumnName("venue1_seat");
            entity.Property(e => e.Venue1Section)
                .HasMaxLength(500)
                .HasColumnName("venue1_section");
            entity.Property(e => e.Venue1Stand)
                .HasMaxLength(500)
                .HasColumnName("venue1_stand");
            entity.Property(e => e.Venue2Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue2_aisle");
            entity.Property(e => e.Venue2Gate)
                .HasMaxLength(500)
                .HasColumnName("venue2_gate");
            entity.Property(e => e.Venue2Row)
                .HasMaxLength(500)
                .HasColumnName("venue2_row");
            entity.Property(e => e.Venue2Seat)
                .HasMaxLength(500)
                .HasColumnName("venue2_seat");
            entity.Property(e => e.Venue2Section)
                .HasMaxLength(500)
                .HasColumnName("venue2_section");
            entity.Property(e => e.Venue2Stand)
                .HasMaxLength(500)
                .HasColumnName("venue2_stand");
            entity.Property(e => e.YearsMembership).HasColumnName("years_membership");
            entity.Property(e => e.Zip)
                .HasMaxLength(500)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<RawData13817202110121049465229>(entity =>
        {
            entity.ToTable("RawData_138_17_202110121049465229");

            entity.Property(e => e.AddressLine1).HasMaxLength(500);
            entity.Property(e => e.AddressLine2).HasMaxLength(500);
            entity.Property(e => e.Aisle1).HasMaxLength(500);
            entity.Property(e => e.Aisle2).HasMaxLength(500);
            entity.Property(e => e.Aisle3).HasMaxLength(500);
            entity.Property(e => e.Barcode).HasMaxLength(500);
            entity.Property(e => e.CardFirstName).HasMaxLength(500);
            entity.Property(e => e.CardLastName).HasMaxLength(500);
            entity.Property(e => e.CardStatus).HasMaxLength(500);
            entity.Property(e => e.Category).HasMaxLength(500);
            entity.Property(e => e.ClubMembershipId).HasColumnName("ClubMembershipID");
            entity.Property(e => e.ClubNativeId)
                .HasMaxLength(500)
                .HasColumnName("ClubNativeID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName).HasMaxLength(500);
            entity.Property(e => e.ConsecutiveTenure).HasMaxLength(500);
            entity.Property(e => e.Country).HasMaxLength(500);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.DateOfBirth).HasColumnType("date");
            entity.Property(e => e.DeliveryType).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(500);
            entity.Property(e => e.EmpAcctStatus).HasColumnName("EMP_AcctStatus");
            entity.Property(e => e.EmpCredit)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("EMP_Credit");
            entity.Property(e => e.EmpDisplayOrder).HasColumnName("EMP_DisplayOrder");
            entity.Property(e => e.EmpErrorCode)
                .HasMaxLength(200)
                .HasColumnName("EMP_ErrorCode");
            entity.Property(e => e.EmpGender)
                .HasMaxLength(200)
                .HasColumnName("EMP_Gender");
            entity.Property(e => e.EmpGroupId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupId");
            entity.Property(e => e.EmpGroupUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupUserId");
            entity.Property(e => e.EmpIsCardOnly).HasColumnName("EMP_IsCardOnly");
            entity.Property(e => e.EmpIsMain)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_IsMain");
            entity.Property(e => e.EmpLoginAcctStatus).HasColumnName("EMP_LoginAcctStatus");
            entity.Property(e => e.EmpParticipantId).HasColumnName("EMP_ParticipantId");
            entity.Property(e => e.EmpProgramId).HasColumnName("EMP_ProgramId");
            entity.Property(e => e.EmpProgramName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ProgramName");
            entity.Property(e => e.EmpRecordInActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_RecordInActive");
            entity.Property(e => e.EmpRecordType)
                .HasMaxLength(200)
                .HasColumnName("EMP_RecordType");
            entity.Property(e => e.EmpRedeemed).HasColumnName("EMP_Redeemed");
            entity.Property(e => e.EmpShopName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ShopName");
            entity.Property(e => e.EmpUniqueKey)
                .HasMaxLength(300)
                .HasColumnName("EMP_UniqueKey");
            entity.Property(e => e.EmpUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_UserId");
            entity.Property(e => e.EmpUserTypeId).HasColumnName("EMP_UserTypeId");
            entity.Property(e => e.EmpUsername)
                .HasMaxLength(200)
                .HasColumnName("EMP_Username");
            entity.Property(e => e.EmpXmlData)
                .HasColumnType("xml")
                .HasColumnName("EMP_XmlData");
            entity.Property(e => e.Gate1).HasMaxLength(500);
            entity.Property(e => e.Gate2).HasMaxLength(500);
            entity.Property(e => e.Gate3).HasMaxLength(500);
            entity.Property(e => e.MemberExpiry).HasColumnType("date");
            entity.Property(e => e.MemberSince).HasMaxLength(500);
            entity.Property(e => e.MemberType).HasMaxLength(500);
            entity.Property(e => e.OrderId)
                .HasMaxLength(500)
                .HasColumnName("OrderID");
            entity.Property(e => e.OrderlineId)
                .HasMaxLength(500)
                .HasColumnName("OrderlineID");
            entity.Property(e => e.OrderlineItemIdguid)
                .HasMaxLength(500)
                .HasColumnName("OrderlineItemIDGuid");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.Package).HasMaxLength(500);
            entity.Property(e => e.PahaddressLine1)
                .HasMaxLength(500)
                .HasColumnName("PAHAddressLine1");
            entity.Property(e => e.PahaddressLine2)
                .HasMaxLength(500)
                .HasColumnName("PAHAddressLine2");
            entity.Property(e => e.PahclubMembershipId).HasColumnName("PAHClubMembershipID");
            entity.Property(e => e.PahclubNativeId)
                .HasMaxLength(500)
                .HasColumnName("PAHClubNativeID");
            entity.Property(e => e.PahcompanyName)
                .HasMaxLength(500)
                .HasColumnName("PAHCompanyName");
            entity.Property(e => e.Pahcountry)
                .HasMaxLength(500)
                .HasColumnName("PAHCountry");
            entity.Property(e => e.PahcustomerId).HasColumnName("PAHCustomerID");
            entity.Property(e => e.Pahemail)
                .HasMaxLength(500)
                .HasColumnName("PAHEmail");
            entity.Property(e => e.PahfirstName)
                .HasMaxLength(500)
                .HasColumnName("PAHFirstName");
            entity.Property(e => e.PahlastName)
                .HasMaxLength(500)
                .HasColumnName("PAHLastName");
            entity.Property(e => e.PahpostCode)
                .HasMaxLength(500)
                .HasColumnName("PAHPostCode");
            entity.Property(e => e.PahprimaryPhone)
                .HasMaxLength(500)
                .HasColumnName("PAHPrimaryPhone");
            entity.Property(e => e.Pahsalutation)
                .HasMaxLength(500)
                .HasColumnName("PAHSalutation");
            entity.Property(e => e.Pahstate)
                .HasMaxLength(500)
                .HasColumnName("PAHState");
            entity.Property(e => e.Pahsuburb)
                .HasMaxLength(500)
                .HasColumnName("PAHSuburb");
            entity.Property(e => e.PaxCardNo).HasMaxLength(500);
            entity.Property(e => e.PaymentOption).HasMaxLength(500);
            entity.Property(e => e.PostCode).HasMaxLength(500);
            entity.Property(e => e.PriceType).HasMaxLength(500);
            entity.Property(e => e.PriceTypePrintName).HasMaxLength(500);
            entity.Property(e => e.ProcessMethod).HasMaxLength(500);
            entity.Property(e => e.Row1).HasMaxLength(500);
            entity.Property(e => e.Row2).HasMaxLength(500);
            entity.Property(e => e.Row3).HasMaxLength(500);
            entity.Property(e => e.RunNumber).HasMaxLength(500);
            entity.Property(e => e.Seat1).HasMaxLength(500);
            entity.Property(e => e.Seat2).HasMaxLength(500);
            entity.Property(e => e.Seat3).HasMaxLength(500);
            entity.Property(e => e.SeatingType).HasMaxLength(500);
            entity.Property(e => e.Section1).HasMaxLength(500);
            entity.Property(e => e.Section2).HasMaxLength(500);
            entity.Property(e => e.Section3).HasMaxLength(500);
            entity.Property(e => e.State).HasMaxLength(500);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.Suburb).HasMaxLength(500);
            entity.Property(e => e.Uniqueid).HasMaxLength(500);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Venue1).HasMaxLength(500);
            entity.Property(e => e.Venue2).HasMaxLength(500);
            entity.Property(e => e.Venue3).HasMaxLength(500);
        });

        modelBuilder.Entity<RawData14320202110290647018384>(entity =>
        {
            entity.ToTable("RawData_143_20_202110290647018384");

            entity.Property(e => e.AcctId).HasColumnName("acct_id");
            entity.Property(e => e.AcctTypeDesc)
                .HasMaxLength(500)
                .HasColumnName("acct_type_desc");
            entity.Property(e => e.Barcode)
                .HasMaxLength(500)
                .HasColumnName("barcode");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("birthdate");
            entity.Property(e => e.Card)
                .HasMaxLength(500)
                .HasColumnName("card");
            entity.Property(e => e.City)
                .HasMaxLength(500)
                .HasColumnName("city");
            entity.Property(e => e.ClubCode)
                .HasMaxLength(500)
                .HasColumnName("club_code");
            entity.Property(e => e.CompName)
                .HasMaxLength(500)
                .HasColumnName("comp_name");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(500)
                .HasColumnName("company_name");
            entity.Property(e => e.ConcessionText)
                .HasMaxLength(500)
                .HasColumnName("concession_text");
            entity.Property(e => e.ConsecutiveSince).HasColumnName("consecutive_since");
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .HasColumnName("country");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustNameId).HasColumnName("cust_name_id");
            entity.Property(e => e.DeliveryInstructions)
                .HasMaxLength(500)
                .HasColumnName("delivery_instructions");
            entity.Property(e => e.DeliveryMethodName)
                .HasMaxLength(500)
                .HasColumnName("delivery_method_name");
            entity.Property(e => e.DiscName)
                .HasMaxLength(500)
                .HasColumnName("disc_name");
            entity.Property(e => e.EmailAddr)
                .HasMaxLength(500)
                .HasColumnName("email_addr");
            entity.Property(e => e.EventLine1)
                .HasMaxLength(500)
                .HasColumnName("event_line1");
            entity.Property(e => e.EventLine2)
                .HasMaxLength(500)
                .HasColumnName("event_line2");
            entity.Property(e => e.EventLine3)
                .HasMaxLength(500)
                .HasColumnName("event_line3");
            entity.Property(e => e.EventName)
                .HasMaxLength(500)
                .HasColumnName("event_name");
            entity.Property(e => e.FamilyId).HasColumnName("family_id");
            entity.Property(e => e.Fulfilment)
                .HasMaxLength(500)
                .HasColumnName("fulfilment");
            entity.Property(e => e.FullName1)
                .HasMaxLength(500)
                .HasColumnName("full_name_1");
            entity.Property(e => e.Gate)
                .HasMaxLength(500)
                .HasColumnName("gate");
            entity.Property(e => e.Gender)
                .HasMaxLength(500)
                .HasColumnName("gender");
            entity.Property(e => e.GroupCodes)
                .HasMaxLength(500)
                .HasColumnName("group_codes");
            entity.Property(e => e.LocationCity)
                .HasMaxLength(500)
                .HasColumnName("location_city");
            entity.Property(e => e.LocationCountry)
                .HasMaxLength(500)
                .HasColumnName("location_country");
            entity.Property(e => e.LocationState)
                .HasMaxLength(500)
                .HasColumnName("location_state");
            entity.Property(e => e.LocationStreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_1");
            entity.Property(e => e.LocationStreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_2");
            entity.Property(e => e.LocationZip)
                .HasMaxLength(500)
                .HasColumnName("location_zip");
            entity.Property(e => e.MemberSince).HasColumnName("member_since");
            entity.Property(e => e.MembershipType)
                .HasMaxLength(500)
                .HasColumnName("membership_type");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
            entity.Property(e => e.NameFirst)
                .HasMaxLength(500)
                .HasColumnName("name_first");
            entity.Property(e => e.Note1)
                .HasMaxLength(500)
                .HasColumnName("note1");
            entity.Property(e => e.Note2)
                .HasMaxLength(500)
                .HasColumnName("note2");
            entity.Property(e => e.NumSeats).HasColumnName("num_seats");
            entity.Property(e => e.OrderLineItem).HasColumnName("order_line_item");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.OtherInfo6)
                .HasMaxLength(500)
                .HasColumnName("other_info_6");
            entity.Property(e => e.OtherInfo7)
                .HasMaxLength(500)
                .HasColumnName("other_info_7");
            entity.Property(e => e.OtherInfo9)
                .HasMaxLength(500)
                .HasColumnName("other_info_9");
            entity.Property(e => e.PackChoice)
                .HasMaxLength(500)
                .HasColumnName("pack_choice");
            entity.Property(e => e.PhoneCell)
                .HasMaxLength(500)
                .HasColumnName("phone_cell");
            entity.Property(e => e.PhoneDay)
                .HasMaxLength(500)
                .HasColumnName("phone_day");
            entity.Property(e => e.PhoneEve)
                .HasMaxLength(500)
                .HasColumnName("phone_eve");
            entity.Property(e => e.PinMasked)
                .HasMaxLength(500)
                .HasColumnName("pin_masked");
            entity.Property(e => e.Portal)
                .HasMaxLength(500)
                .HasColumnName("portal");
            entity.Property(e => e.PriceCode)
                .HasMaxLength(500)
                .HasColumnName("price_code");
            entity.Property(e => e.PriceCodeDesc)
                .HasMaxLength(500)
                .HasColumnName("price_code_desc");
            entity.Property(e => e.PrintCount).HasColumnName("print_count");
            entity.Property(e => e.PrintDate)
                .HasColumnType("datetime")
                .HasColumnName("print_date");
            entity.Property(e => e.RowName)
                .HasMaxLength(500)
                .HasColumnName("row_name");
            entity.Property(e => e.SeatLabel1)
                .HasMaxLength(500)
                .HasColumnName("seat_label1");
            entity.Property(e => e.SeatLabel2)
                .HasMaxLength(500)
                .HasColumnName("seat_label2");
            entity.Property(e => e.SeatLabel3)
                .HasMaxLength(500)
                .HasColumnName("seat_label3");
            entity.Property(e => e.SeatLabel4)
                .HasMaxLength(500)
                .HasColumnName("seat_label4");
            entity.Property(e => e.SeatLocation1)
                .HasMaxLength(500)
                .HasColumnName("seat_location1");
            entity.Property(e => e.SeatLocation2)
                .HasMaxLength(500)
                .HasColumnName("seat_location2");
            entity.Property(e => e.SeatLocation3)
                .HasMaxLength(500)
                .HasColumnName("seat_location3");
            entity.Property(e => e.SeatLocation4)
                .HasMaxLength(500)
                .HasColumnName("seat_location4");
            entity.Property(e => e.SeatNum).HasColumnName("seat_num");
            entity.Property(e => e.SectionName)
                .HasMaxLength(500)
                .HasColumnName("section_name");
            entity.Property(e => e.State)
                .HasMaxLength(500)
                .HasColumnName("state");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("street_addr_1");
            entity.Property(e => e.StreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("street_addr_2");
            entity.Property(e => e.SurchgName)
                .HasMaxLength(500)
                .HasColumnName("surchg_name");
            entity.Property(e => e.TicketTypeCategory)
                .HasMaxLength(500)
                .HasColumnName("ticket_type_category");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.YearsConsecutive).HasColumnName("years_consecutive");
            entity.Property(e => e.YearsMembership).HasColumnName("years_membership");
            entity.Property(e => e.YearsUpdated)
                .HasMaxLength(500)
                .HasColumnName("years_updated");
            entity.Property(e => e.Zip)
                .HasMaxLength(500)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<RawData14320202111080329006768>(entity =>
        {
            entity.ToTable("RawData_143_20_202111080329006768");

            entity.Property(e => e.AcctId).HasColumnName("acct_id");
            entity.Property(e => e.AcctTypeDesc)
                .HasMaxLength(500)
                .HasColumnName("acct_type_desc");
            entity.Property(e => e.Barcode)
                .HasMaxLength(500)
                .HasColumnName("barcode");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("birthdate");
            entity.Property(e => e.Card)
                .HasMaxLength(500)
                .HasColumnName("card");
            entity.Property(e => e.City)
                .HasMaxLength(500)
                .HasColumnName("city");
            entity.Property(e => e.ClubCode)
                .HasMaxLength(500)
                .HasColumnName("club_code");
            entity.Property(e => e.CompName)
                .HasMaxLength(500)
                .HasColumnName("comp_name");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(500)
                .HasColumnName("company_name");
            entity.Property(e => e.ConcessionText)
                .HasMaxLength(500)
                .HasColumnName("concession_text");
            entity.Property(e => e.ConsecutiveSince).HasColumnName("consecutive_since");
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .HasColumnName("country");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustNameId).HasColumnName("cust_name_id");
            entity.Property(e => e.DeliveryInstructions)
                .HasMaxLength(500)
                .HasColumnName("delivery_instructions");
            entity.Property(e => e.DeliveryMethodName)
                .HasMaxLength(500)
                .HasColumnName("delivery_method_name");
            entity.Property(e => e.DiscName)
                .HasMaxLength(500)
                .HasColumnName("disc_name");
            entity.Property(e => e.EmailAddr)
                .HasMaxLength(500)
                .HasColumnName("email_addr");
            entity.Property(e => e.EventLine1)
                .HasMaxLength(500)
                .HasColumnName("event_line1");
            entity.Property(e => e.EventLine2)
                .HasMaxLength(500)
                .HasColumnName("event_line2");
            entity.Property(e => e.EventLine3)
                .HasMaxLength(500)
                .HasColumnName("event_line3");
            entity.Property(e => e.EventName)
                .HasMaxLength(500)
                .HasColumnName("event_name");
            entity.Property(e => e.FamilyId).HasColumnName("family_id");
            entity.Property(e => e.Fulfilment)
                .HasMaxLength(500)
                .HasColumnName("fulfilment");
            entity.Property(e => e.FullName1)
                .HasMaxLength(500)
                .HasColumnName("full_name_1");
            entity.Property(e => e.Gate)
                .HasMaxLength(500)
                .HasColumnName("gate");
            entity.Property(e => e.Gender)
                .HasMaxLength(500)
                .HasColumnName("gender");
            entity.Property(e => e.GroupCodes)
                .HasColumnType("text")
                .HasColumnName("group_codes");
            entity.Property(e => e.LocationCity)
                .HasMaxLength(500)
                .HasColumnName("location_city");
            entity.Property(e => e.LocationCountry)
                .HasMaxLength(500)
                .HasColumnName("location_country");
            entity.Property(e => e.LocationState)
                .HasMaxLength(500)
                .HasColumnName("location_state");
            entity.Property(e => e.LocationStreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_1");
            entity.Property(e => e.LocationStreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_2");
            entity.Property(e => e.LocationZip)
                .HasMaxLength(500)
                .HasColumnName("location_zip");
            entity.Property(e => e.MemberSince).HasColumnName("member_since");
            entity.Property(e => e.MembershipType)
                .HasMaxLength(500)
                .HasColumnName("membership_type");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
            entity.Property(e => e.NameFirst)
                .HasMaxLength(500)
                .HasColumnName("name_first");
            entity.Property(e => e.Note1)
                .HasMaxLength(500)
                .HasColumnName("note1");
            entity.Property(e => e.Note2)
                .HasMaxLength(500)
                .HasColumnName("note2");
            entity.Property(e => e.NumSeats).HasColumnName("num_seats");
            entity.Property(e => e.OrderLineItem).HasColumnName("order_line_item");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.OtherInfo6)
                .HasMaxLength(500)
                .HasColumnName("other_info_6");
            entity.Property(e => e.OtherInfo7)
                .HasMaxLength(500)
                .HasColumnName("other_info_7");
            entity.Property(e => e.OtherInfo9)
                .HasMaxLength(500)
                .HasColumnName("other_info_9");
            entity.Property(e => e.PackChoice)
                .HasMaxLength(500)
                .HasColumnName("pack_choice");
            entity.Property(e => e.PhoneCell)
                .HasMaxLength(500)
                .HasColumnName("phone_cell");
            entity.Property(e => e.PhoneDay)
                .HasMaxLength(500)
                .HasColumnName("phone_day");
            entity.Property(e => e.PhoneEve)
                .HasMaxLength(500)
                .HasColumnName("phone_eve");
            entity.Property(e => e.PinMasked)
                .HasMaxLength(500)
                .HasColumnName("pin_masked");
            entity.Property(e => e.Portal)
                .HasMaxLength(500)
                .HasColumnName("portal");
            entity.Property(e => e.PriceCode)
                .HasMaxLength(500)
                .HasColumnName("price_code");
            entity.Property(e => e.PriceCodeDesc)
                .HasMaxLength(500)
                .HasColumnName("price_code_desc");
            entity.Property(e => e.PrintCount).HasColumnName("print_count");
            entity.Property(e => e.PrintDate)
                .HasColumnType("datetime")
                .HasColumnName("print_date");
            entity.Property(e => e.RowName)
                .HasMaxLength(500)
                .HasColumnName("row_name");
            entity.Property(e => e.SeatLabel1)
                .HasMaxLength(500)
                .HasColumnName("seat_label1");
            entity.Property(e => e.SeatLabel2)
                .HasMaxLength(500)
                .HasColumnName("seat_label2");
            entity.Property(e => e.SeatLabel3)
                .HasMaxLength(500)
                .HasColumnName("seat_label3");
            entity.Property(e => e.SeatLabel4)
                .HasMaxLength(500)
                .HasColumnName("seat_label4");
            entity.Property(e => e.SeatLocation1)
                .HasMaxLength(500)
                .HasColumnName("seat_location1");
            entity.Property(e => e.SeatLocation2)
                .HasMaxLength(500)
                .HasColumnName("seat_location2");
            entity.Property(e => e.SeatLocation3)
                .HasMaxLength(500)
                .HasColumnName("seat_location3");
            entity.Property(e => e.SeatLocation4)
                .HasMaxLength(500)
                .HasColumnName("seat_location4");
            entity.Property(e => e.SeatNum).HasColumnName("seat_num");
            entity.Property(e => e.SectionName)
                .HasMaxLength(500)
                .HasColumnName("section_name");
            entity.Property(e => e.State)
                .HasMaxLength(500)
                .HasColumnName("state");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("street_addr_1");
            entity.Property(e => e.StreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("street_addr_2");
            entity.Property(e => e.SurchgName)
                .HasMaxLength(500)
                .HasColumnName("surchg_name");
            entity.Property(e => e.TicketTypeCategory)
                .HasMaxLength(500)
                .HasColumnName("ticket_type_category");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.YearsConsecutive).HasColumnName("years_consecutive");
            entity.Property(e => e.YearsMembership).HasColumnName("years_membership");
            entity.Property(e => e.YearsUpdated)
                .HasMaxLength(500)
                .HasColumnName("years_updated");
            entity.Property(e => e.Zip)
                .HasMaxLength(500)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<RawData14320202111080329143951>(entity =>
        {
            entity.ToTable("RawData_143_20_202111080329143951");

            entity.Property(e => e.AcctId).HasColumnName("acct_id");
            entity.Property(e => e.AcctTypeDesc)
                .HasMaxLength(500)
                .HasColumnName("acct_type_desc");
            entity.Property(e => e.Barcode)
                .HasMaxLength(500)
                .HasColumnName("barcode");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("birthdate");
            entity.Property(e => e.Card)
                .HasMaxLength(500)
                .HasColumnName("card");
            entity.Property(e => e.City)
                .HasMaxLength(500)
                .HasColumnName("city");
            entity.Property(e => e.ClubCode)
                .HasMaxLength(500)
                .HasColumnName("club_code");
            entity.Property(e => e.CompName)
                .HasMaxLength(500)
                .HasColumnName("comp_name");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(500)
                .HasColumnName("company_name");
            entity.Property(e => e.ConcessionText)
                .HasMaxLength(500)
                .HasColumnName("concession_text");
            entity.Property(e => e.ConsecutiveSince).HasColumnName("consecutive_since");
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .HasColumnName("country");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustNameId).HasColumnName("cust_name_id");
            entity.Property(e => e.DeliveryInstructions)
                .HasMaxLength(500)
                .HasColumnName("delivery_instructions");
            entity.Property(e => e.DeliveryMethodName)
                .HasMaxLength(500)
                .HasColumnName("delivery_method_name");
            entity.Property(e => e.DiscName)
                .HasMaxLength(500)
                .HasColumnName("disc_name");
            entity.Property(e => e.EmailAddr)
                .HasMaxLength(500)
                .HasColumnName("email_addr");
            entity.Property(e => e.EventLine1)
                .HasMaxLength(500)
                .HasColumnName("event_line1");
            entity.Property(e => e.EventLine2)
                .HasMaxLength(500)
                .HasColumnName("event_line2");
            entity.Property(e => e.EventLine3)
                .HasMaxLength(500)
                .HasColumnName("event_line3");
            entity.Property(e => e.EventName)
                .HasMaxLength(500)
                .HasColumnName("event_name");
            entity.Property(e => e.FamilyId).HasColumnName("family_id");
            entity.Property(e => e.Fulfilment)
                .HasMaxLength(500)
                .HasColumnName("fulfilment");
            entity.Property(e => e.FullName1)
                .HasMaxLength(500)
                .HasColumnName("full_name_1");
            entity.Property(e => e.Gate)
                .HasMaxLength(500)
                .HasColumnName("gate");
            entity.Property(e => e.Gender)
                .HasMaxLength(500)
                .HasColumnName("gender");
            entity.Property(e => e.GroupCodes)
                .HasColumnType("text")
                .HasColumnName("group_codes");
            entity.Property(e => e.LocationCity)
                .HasMaxLength(500)
                .HasColumnName("location_city");
            entity.Property(e => e.LocationCountry)
                .HasMaxLength(500)
                .HasColumnName("location_country");
            entity.Property(e => e.LocationState)
                .HasMaxLength(500)
                .HasColumnName("location_state");
            entity.Property(e => e.LocationStreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_1");
            entity.Property(e => e.LocationStreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_2");
            entity.Property(e => e.LocationZip)
                .HasMaxLength(500)
                .HasColumnName("location_zip");
            entity.Property(e => e.MemberSince).HasColumnName("member_since");
            entity.Property(e => e.MembershipType)
                .HasMaxLength(500)
                .HasColumnName("membership_type");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
            entity.Property(e => e.NameFirst)
                .HasMaxLength(500)
                .HasColumnName("name_first");
            entity.Property(e => e.Note1)
                .HasMaxLength(500)
                .HasColumnName("note1");
            entity.Property(e => e.Note2)
                .HasMaxLength(500)
                .HasColumnName("note2");
            entity.Property(e => e.NumSeats).HasColumnName("num_seats");
            entity.Property(e => e.OrderLineItem).HasColumnName("order_line_item");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.OtherInfo6)
                .HasMaxLength(500)
                .HasColumnName("other_info_6");
            entity.Property(e => e.OtherInfo7)
                .HasMaxLength(500)
                .HasColumnName("other_info_7");
            entity.Property(e => e.OtherInfo9)
                .HasMaxLength(500)
                .HasColumnName("other_info_9");
            entity.Property(e => e.PackChoice)
                .HasMaxLength(500)
                .HasColumnName("pack_choice");
            entity.Property(e => e.PhoneCell)
                .HasMaxLength(500)
                .HasColumnName("phone_cell");
            entity.Property(e => e.PhoneDay)
                .HasMaxLength(500)
                .HasColumnName("phone_day");
            entity.Property(e => e.PhoneEve)
                .HasMaxLength(500)
                .HasColumnName("phone_eve");
            entity.Property(e => e.PinMasked)
                .HasMaxLength(500)
                .HasColumnName("pin_masked");
            entity.Property(e => e.Portal)
                .HasMaxLength(500)
                .HasColumnName("portal");
            entity.Property(e => e.PriceCode)
                .HasMaxLength(500)
                .HasColumnName("price_code");
            entity.Property(e => e.PriceCodeDesc)
                .HasMaxLength(500)
                .HasColumnName("price_code_desc");
            entity.Property(e => e.PrintCount).HasColumnName("print_count");
            entity.Property(e => e.PrintDate)
                .HasColumnType("datetime")
                .HasColumnName("print_date");
            entity.Property(e => e.RowName)
                .HasMaxLength(500)
                .HasColumnName("row_name");
            entity.Property(e => e.SeatLabel1)
                .HasMaxLength(500)
                .HasColumnName("seat_label1");
            entity.Property(e => e.SeatLabel2)
                .HasMaxLength(500)
                .HasColumnName("seat_label2");
            entity.Property(e => e.SeatLabel3)
                .HasMaxLength(500)
                .HasColumnName("seat_label3");
            entity.Property(e => e.SeatLabel4)
                .HasMaxLength(500)
                .HasColumnName("seat_label4");
            entity.Property(e => e.SeatLocation1)
                .HasMaxLength(500)
                .HasColumnName("seat_location1");
            entity.Property(e => e.SeatLocation2)
                .HasMaxLength(500)
                .HasColumnName("seat_location2");
            entity.Property(e => e.SeatLocation3)
                .HasMaxLength(500)
                .HasColumnName("seat_location3");
            entity.Property(e => e.SeatLocation4)
                .HasMaxLength(500)
                .HasColumnName("seat_location4");
            entity.Property(e => e.SeatNum).HasColumnName("seat_num");
            entity.Property(e => e.SectionName)
                .HasMaxLength(500)
                .HasColumnName("section_name");
            entity.Property(e => e.State)
                .HasMaxLength(500)
                .HasColumnName("state");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("street_addr_1");
            entity.Property(e => e.StreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("street_addr_2");
            entity.Property(e => e.SurchgName)
                .HasMaxLength(500)
                .HasColumnName("surchg_name");
            entity.Property(e => e.TicketTypeCategory)
                .HasMaxLength(500)
                .HasColumnName("ticket_type_category");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.YearsConsecutive).HasColumnName("years_consecutive");
            entity.Property(e => e.YearsMembership).HasColumnName("years_membership");
            entity.Property(e => e.YearsUpdated)
                .HasMaxLength(500)
                .HasColumnName("years_updated");
            entity.Property(e => e.Zip)
                .HasMaxLength(500)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<RawData14320202111080346540337>(entity =>
        {
            entity.ToTable("RawData_143_20_202111080346540337");

            entity.Property(e => e.AcctId)
                .HasMaxLength(500)
                .HasColumnName("acct_id");
            entity.Property(e => e.AcctTypeDesc)
                .HasMaxLength(500)
                .HasColumnName("acct_type_desc");
            entity.Property(e => e.Barcode)
                .HasMaxLength(500)
                .HasColumnName("barcode");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("birthdate");
            entity.Property(e => e.Card)
                .HasMaxLength(500)
                .HasColumnName("card");
            entity.Property(e => e.City)
                .HasMaxLength(500)
                .HasColumnName("city");
            entity.Property(e => e.ClubCode)
                .HasMaxLength(500)
                .HasColumnName("club_code");
            entity.Property(e => e.CompName)
                .HasMaxLength(500)
                .HasColumnName("comp_name");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(500)
                .HasColumnName("company_name");
            entity.Property(e => e.ConcessionText)
                .HasMaxLength(500)
                .HasColumnName("concession_text");
            entity.Property(e => e.ConsecutiveSince).HasColumnName("consecutive_since");
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .HasColumnName("country");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustNameId).HasColumnName("cust_name_id");
            entity.Property(e => e.DeliveryInstructions)
                .HasMaxLength(500)
                .HasColumnName("delivery_instructions");
            entity.Property(e => e.DeliveryMethodName)
                .HasMaxLength(500)
                .HasColumnName("delivery_method_name");
            entity.Property(e => e.DiscName)
                .HasMaxLength(500)
                .HasColumnName("disc_name");
            entity.Property(e => e.EmailAddr)
                .HasMaxLength(500)
                .HasColumnName("email_addr");
            entity.Property(e => e.EmpAcctStatus).HasColumnName("EMP_AcctStatus");
            entity.Property(e => e.EmpCredit)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("EMP_Credit");
            entity.Property(e => e.EmpDisplayOrder).HasColumnName("EMP_DisplayOrder");
            entity.Property(e => e.EmpErrorCode)
                .HasMaxLength(200)
                .HasColumnName("EMP_ErrorCode");
            entity.Property(e => e.EmpGender)
                .HasMaxLength(200)
                .HasColumnName("EMP_Gender");
            entity.Property(e => e.EmpGroupId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupId");
            entity.Property(e => e.EmpGroupUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupUserId");
            entity.Property(e => e.EmpIsCardOnly).HasColumnName("EMP_IsCardOnly");
            entity.Property(e => e.EmpIsMain)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_IsMain");
            entity.Property(e => e.EmpLoginAcctStatus).HasColumnName("EMP_LoginAcctStatus");
            entity.Property(e => e.EmpParticipantId).HasColumnName("EMP_ParticipantId");
            entity.Property(e => e.EmpProgramId).HasColumnName("EMP_ProgramId");
            entity.Property(e => e.EmpProgramName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ProgramName");
            entity.Property(e => e.EmpRecordInActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_RecordInActive");
            entity.Property(e => e.EmpRecordType)
                .HasMaxLength(200)
                .HasColumnName("EMP_RecordType");
            entity.Property(e => e.EmpRedeemed).HasColumnName("EMP_Redeemed");
            entity.Property(e => e.EmpShopName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ShopName");
            entity.Property(e => e.EmpUniqueKey)
                .HasMaxLength(300)
                .HasColumnName("EMP_UniqueKey");
            entity.Property(e => e.EmpUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_UserId");
            entity.Property(e => e.EmpUserTypeId).HasColumnName("EMP_UserTypeId");
            entity.Property(e => e.EmpUsername)
                .HasMaxLength(200)
                .HasColumnName("EMP_Username");
            entity.Property(e => e.EmpXmlData)
                .HasColumnType("xml")
                .HasColumnName("EMP_XmlData");
            entity.Property(e => e.EventLine1)
                .HasMaxLength(500)
                .HasColumnName("event_line1");
            entity.Property(e => e.EventLine2)
                .HasMaxLength(500)
                .HasColumnName("event_line2");
            entity.Property(e => e.EventLine3)
                .HasMaxLength(500)
                .HasColumnName("event_line3");
            entity.Property(e => e.EventName)
                .HasMaxLength(500)
                .HasColumnName("event_name");
            entity.Property(e => e.FamilyId).HasColumnName("family_id");
            entity.Property(e => e.Fulfilment)
                .HasMaxLength(500)
                .HasColumnName("fulfilment");
            entity.Property(e => e.FullName1)
                .HasMaxLength(500)
                .HasColumnName("full_name_1");
            entity.Property(e => e.Gate)
                .HasMaxLength(500)
                .HasColumnName("gate");
            entity.Property(e => e.Gender)
                .HasMaxLength(500)
                .HasColumnName("gender");
            entity.Property(e => e.GroupCodes)
                .HasColumnType("text")
                .HasColumnName("group_codes");
            entity.Property(e => e.LocationCity)
                .HasMaxLength(500)
                .HasColumnName("location_city");
            entity.Property(e => e.LocationCountry)
                .HasMaxLength(500)
                .HasColumnName("location_country");
            entity.Property(e => e.LocationState)
                .HasMaxLength(500)
                .HasColumnName("location_state");
            entity.Property(e => e.LocationStreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_1");
            entity.Property(e => e.LocationStreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_2");
            entity.Property(e => e.LocationZip)
                .HasMaxLength(500)
                .HasColumnName("location_zip");
            entity.Property(e => e.MemberSince).HasColumnName("member_since");
            entity.Property(e => e.MembershipType)
                .HasMaxLength(500)
                .HasColumnName("membership_type");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
            entity.Property(e => e.NameFirst)
                .HasMaxLength(500)
                .HasColumnName("name_first");
            entity.Property(e => e.Note1)
                .HasMaxLength(500)
                .HasColumnName("note1");
            entity.Property(e => e.Note2)
                .HasMaxLength(500)
                .HasColumnName("note2");
            entity.Property(e => e.NumSeats).HasColumnName("num_seats");
            entity.Property(e => e.OrderLineItem).HasColumnName("order_line_item");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.OtherInfo6)
                .HasMaxLength(500)
                .HasColumnName("other_info_6");
            entity.Property(e => e.OtherInfo7)
                .HasMaxLength(500)
                .HasColumnName("other_info_7");
            entity.Property(e => e.OtherInfo9)
                .HasMaxLength(500)
                .HasColumnName("other_info_9");
            entity.Property(e => e.PackChoice)
                .HasMaxLength(500)
                .HasColumnName("pack_choice");
            entity.Property(e => e.PhoneCell)
                .HasMaxLength(500)
                .HasColumnName("phone_cell");
            entity.Property(e => e.PhoneDay)
                .HasMaxLength(500)
                .HasColumnName("phone_day");
            entity.Property(e => e.PhoneEve)
                .HasMaxLength(500)
                .HasColumnName("phone_eve");
            entity.Property(e => e.PinMasked)
                .HasMaxLength(500)
                .HasColumnName("pin_masked");
            entity.Property(e => e.Portal)
                .HasMaxLength(500)
                .HasColumnName("portal");
            entity.Property(e => e.PriceCode)
                .HasMaxLength(500)
                .HasColumnName("price_code");
            entity.Property(e => e.PriceCodeDesc)
                .HasMaxLength(500)
                .HasColumnName("price_code_desc");
            entity.Property(e => e.PrintCount).HasColumnName("print_count");
            entity.Property(e => e.PrintDate)
                .HasColumnType("datetime")
                .HasColumnName("print_date");
            entity.Property(e => e.RowName)
                .HasMaxLength(500)
                .HasColumnName("row_name");
            entity.Property(e => e.SeatLabel1)
                .HasMaxLength(500)
                .HasColumnName("seat_label1");
            entity.Property(e => e.SeatLabel2)
                .HasMaxLength(500)
                .HasColumnName("seat_label2");
            entity.Property(e => e.SeatLabel3)
                .HasMaxLength(500)
                .HasColumnName("seat_label3");
            entity.Property(e => e.SeatLabel4)
                .HasMaxLength(500)
                .HasColumnName("seat_label4");
            entity.Property(e => e.SeatLocation1)
                .HasMaxLength(500)
                .HasColumnName("seat_location1");
            entity.Property(e => e.SeatLocation2)
                .HasMaxLength(500)
                .HasColumnName("seat_location2");
            entity.Property(e => e.SeatLocation3)
                .HasMaxLength(500)
                .HasColumnName("seat_location3");
            entity.Property(e => e.SeatLocation4)
                .HasMaxLength(500)
                .HasColumnName("seat_location4");
            entity.Property(e => e.SeatNum).HasColumnName("seat_num");
            entity.Property(e => e.SectionName)
                .HasMaxLength(500)
                .HasColumnName("section_name");
            entity.Property(e => e.State)
                .HasMaxLength(500)
                .HasColumnName("state");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("street_addr_1");
            entity.Property(e => e.StreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("street_addr_2");
            entity.Property(e => e.SurchgName)
                .HasMaxLength(500)
                .HasColumnName("surchg_name");
            entity.Property(e => e.TicketTypeCategory)
                .HasMaxLength(500)
                .HasColumnName("ticket_type_category");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.YearsConsecutive).HasColumnName("years_consecutive");
            entity.Property(e => e.YearsMembership).HasColumnName("years_membership");
            entity.Property(e => e.YearsUpdated)
                .HasMaxLength(500)
                .HasColumnName("years_updated");
            entity.Property(e => e.Zip)
                .HasMaxLength(500)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<RawData14523202111120752127950>(entity =>
        {
            entity.ToTable("RawData_145_23_202111120752127950");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<RawData14523202111120815172093>(entity =>
        {
            entity.ToTable("RawData_145_23_202111120815172093");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<RawData14523202111120817168610>(entity =>
        {
            entity.ToTable("RawData_145_23_202111120817168610");

            entity.Property(e => e.AddressLine1).HasMaxLength(500);
            entity.Property(e => e.AddressLine2).HasMaxLength(500);
            entity.Property(e => e.Age).HasMaxLength(500);
            entity.Property(e => e.Aisle1).HasMaxLength(500);
            entity.Property(e => e.Barcode).HasMaxLength(500);
            entity.Property(e => e.CardFirstName).HasMaxLength(500);
            entity.Property(e => e.CardLastName).HasMaxLength(500);
            entity.Property(e => e.CardStatus).HasMaxLength(500);
            entity.Property(e => e.Category).HasMaxLength(500);
            entity.Property(e => e.ClubMembershipId).HasColumnName("ClubMembershipID");
            entity.Property(e => e.ClubNativeId)
                .HasMaxLength(500)
                .HasColumnName("ClubNativeID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName).HasMaxLength(500);
            entity.Property(e => e.Country).HasMaxLength(500);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(500)
                .HasColumnName("CustomerID");
            entity.Property(e => e.DateofBirth).HasMaxLength(500);
            entity.Property(e => e.DeliveryType).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(500);
            entity.Property(e => e.Gate1).HasMaxLength(500);
            entity.Property(e => e.MemberExpiry).HasMaxLength(500);
            entity.Property(e => e.MemberType).HasMaxLength(500);
            entity.Property(e => e.Membersince).HasMaxLength(500);
            entity.Property(e => e.OrderId)
                .HasMaxLength(500)
                .HasColumnName("OrderID");
            entity.Property(e => e.OrderlineId)
                .HasMaxLength(500)
                .HasColumnName("OrderlineID");
            entity.Property(e => e.OrderlineItemIdguid)
                .HasMaxLength(500)
                .HasColumnName("OrderlineItemIDGuid");
            entity.Property(e => e.OrganisationId)
                .HasMaxLength(500)
                .HasColumnName("OrganisationID");
            entity.Property(e => e.Package).HasMaxLength(500);
            entity.Property(e => e.PahaddressLine1)
                .HasMaxLength(500)
                .HasColumnName("PAHAddressLine1");
            entity.Property(e => e.PahaddressLine2)
                .HasMaxLength(500)
                .HasColumnName("PAHAddressLine2");
            entity.Property(e => e.PahclubMembershipId).HasColumnName("PAHClubMembershipID");
            entity.Property(e => e.PahclubNativeId)
                .HasMaxLength(500)
                .HasColumnName("PAHClubNativeID");
            entity.Property(e => e.PahcompanyName)
                .HasMaxLength(500)
                .HasColumnName("PAHCompanyName");
            entity.Property(e => e.Pahcountry)
                .HasMaxLength(500)
                .HasColumnName("PAHCountry");
            entity.Property(e => e.PahcustomerId)
                .HasMaxLength(500)
                .HasColumnName("PAHCustomerID");
            entity.Property(e => e.Pahemail)
                .HasMaxLength(500)
                .HasColumnName("PAHEmail");
            entity.Property(e => e.PahfirstName)
                .HasMaxLength(500)
                .HasColumnName("PAHFirstName");
            entity.Property(e => e.PahlastName)
                .HasMaxLength(500)
                .HasColumnName("PAHLastName");
            entity.Property(e => e.PahpostCode)
                .HasMaxLength(500)
                .HasColumnName("PAHPostCode");
            entity.Property(e => e.PahprimaryPhone)
                .HasMaxLength(500)
                .HasColumnName("PAHPrimaryPhone");
            entity.Property(e => e.Pahsalutation)
                .HasMaxLength(500)
                .HasColumnName("PAHSalutation");
            entity.Property(e => e.Pahstate)
                .HasMaxLength(500)
                .HasColumnName("PAHState");
            entity.Property(e => e.PahsuburbCity)
                .HasMaxLength(500)
                .HasColumnName("PAHSuburb_City");
            entity.Property(e => e.PaxCardNo).HasMaxLength(500);
            entity.Property(e => e.PaymentOption).HasMaxLength(500);
            entity.Property(e => e.PostCode).HasMaxLength(500);
            entity.Property(e => e.PriceType).HasMaxLength(500);
            entity.Property(e => e.PriceTypePrintName).HasMaxLength(500);
            entity.Property(e => e.ProcessMethod)
                .HasMaxLength(500)
                .HasColumnName("Process_method");
            entity.Property(e => e.Row1).HasMaxLength(500);
            entity.Property(e => e.RunNumber).HasMaxLength(500);
            entity.Property(e => e.Seat1).HasMaxLength(500);
            entity.Property(e => e.SeatingType).HasMaxLength(500);
            entity.Property(e => e.Section1).HasMaxLength(500);
            entity.Property(e => e.State).HasMaxLength(500);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.SuburbCity)
                .HasMaxLength(500)
                .HasColumnName("Suburb_City");
            entity.Property(e => e.Uniqueid).HasMaxLength(500);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Venue1).HasMaxLength(500);
        });

        modelBuilder.Entity<RawData14523202112070157261399>(entity =>
        {
            entity.ToTable("RawData_145_23_202112070157261399");

            entity.Property(e => e.AddressLine1).HasMaxLength(500);
            entity.Property(e => e.AddressLine2).HasMaxLength(500);
            entity.Property(e => e.Age).HasMaxLength(500);
            entity.Property(e => e.Aisle1).HasMaxLength(500);
            entity.Property(e => e.Barcode).HasMaxLength(500);
            entity.Property(e => e.CardFirstName).HasMaxLength(500);
            entity.Property(e => e.CardLastName).HasMaxLength(500);
            entity.Property(e => e.CardStatus).HasMaxLength(500);
            entity.Property(e => e.Category).HasMaxLength(500);
            entity.Property(e => e.ClubMembershipId).HasColumnName("ClubMembershipID");
            entity.Property(e => e.ClubNativeId)
                .HasMaxLength(500)
                .HasColumnName("ClubNativeID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName).HasMaxLength(500);
            entity.Property(e => e.Country).HasMaxLength(500);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(500)
                .HasColumnName("CustomerID");
            entity.Property(e => e.DateofBirth).HasMaxLength(500);
            entity.Property(e => e.DeliveryType).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(500);
            entity.Property(e => e.Gate1).HasMaxLength(500);
            entity.Property(e => e.MemberExpiry).HasMaxLength(500);
            entity.Property(e => e.MemberType).HasMaxLength(500);
            entity.Property(e => e.Membersince).HasMaxLength(500);
            entity.Property(e => e.OrderId)
                .HasMaxLength(500)
                .HasColumnName("OrderID");
            entity.Property(e => e.OrderlineDate).HasColumnType("datetime");
            entity.Property(e => e.OrderlineId)
                .HasMaxLength(500)
                .HasColumnName("OrderlineID");
            entity.Property(e => e.OrderlineItemIdguid)
                .HasMaxLength(500)
                .HasColumnName("OrderlineItemIDGuid");
            entity.Property(e => e.OrganisationId)
                .HasMaxLength(500)
                .HasColumnName("OrganisationID");
            entity.Property(e => e.Package).HasMaxLength(500);
            entity.Property(e => e.PahaddressLine1)
                .HasMaxLength(500)
                .HasColumnName("PAHAddressLine1");
            entity.Property(e => e.PahaddressLine2)
                .HasMaxLength(500)
                .HasColumnName("PAHAddressLine2");
            entity.Property(e => e.PahclubMembershipId).HasColumnName("PAHClubMembershipID");
            entity.Property(e => e.PahclubNativeId)
                .HasMaxLength(500)
                .HasColumnName("PAHClubNativeID");
            entity.Property(e => e.PahcompanyName)
                .HasMaxLength(500)
                .HasColumnName("PAHCompanyName");
            entity.Property(e => e.Pahcountry)
                .HasMaxLength(500)
                .HasColumnName("PAHCountry");
            entity.Property(e => e.PahcustomerId)
                .HasMaxLength(500)
                .HasColumnName("PAHCustomerID");
            entity.Property(e => e.Pahemail)
                .HasMaxLength(500)
                .HasColumnName("PAHEmail");
            entity.Property(e => e.PahfirstName)
                .HasMaxLength(500)
                .HasColumnName("PAHFirstName");
            entity.Property(e => e.PahlastName)
                .HasMaxLength(500)
                .HasColumnName("PAHLastName");
            entity.Property(e => e.PahpostCode)
                .HasMaxLength(500)
                .HasColumnName("PAHPostCode");
            entity.Property(e => e.PahprimaryPhone)
                .HasMaxLength(500)
                .HasColumnName("PAHPrimaryPhone");
            entity.Property(e => e.Pahsalutation)
                .HasMaxLength(500)
                .HasColumnName("PAHSalutation");
            entity.Property(e => e.Pahstate)
                .HasMaxLength(500)
                .HasColumnName("PAHState");
            entity.Property(e => e.PahsuburbCity)
                .HasMaxLength(500)
                .HasColumnName("PAHSuburb_City");
            entity.Property(e => e.PaxCardNo).HasMaxLength(500);
            entity.Property(e => e.PaymentOption).HasMaxLength(500);
            entity.Property(e => e.PostCode).HasMaxLength(500);
            entity.Property(e => e.PriceType).HasMaxLength(500);
            entity.Property(e => e.PriceTypePrintName).HasMaxLength(500);
            entity.Property(e => e.Row1).HasMaxLength(500);
            entity.Property(e => e.RunNumber).HasMaxLength(500);
            entity.Property(e => e.Seat1).HasMaxLength(500);
            entity.Property(e => e.SeatingType).HasMaxLength(500);
            entity.Property(e => e.Section1).HasMaxLength(500);
            entity.Property(e => e.State).HasMaxLength(500);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.SuburbCity)
                .HasMaxLength(500)
                .HasColumnName("Suburb_City");
            entity.Property(e => e.Uniqueid).HasMaxLength(500);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Venue1).HasMaxLength(500);
        });

        modelBuilder.Entity<RawData14523202112070551228909>(entity =>
        {
            entity.ToTable("RawData_145_23_202112070551228909");

            entity.Property(e => e.AddressLine1).HasMaxLength(500);
            entity.Property(e => e.AddressLine2).HasMaxLength(500);
            entity.Property(e => e.Age).HasMaxLength(500);
            entity.Property(e => e.Aisle1).HasMaxLength(500);
            entity.Property(e => e.Barcode).HasMaxLength(500);
            entity.Property(e => e.CardFirstName).HasMaxLength(500);
            entity.Property(e => e.CardLastName).HasMaxLength(500);
            entity.Property(e => e.CardStatus).HasMaxLength(500);
            entity.Property(e => e.Category).HasMaxLength(500);
            entity.Property(e => e.ClubMembershipId).HasColumnName("ClubMembershipID");
            entity.Property(e => e.ClubNativeId)
                .HasMaxLength(500)
                .HasColumnName("ClubNativeID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName).HasMaxLength(500);
            entity.Property(e => e.Country).HasMaxLength(500);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(500)
                .HasColumnName("CustomerID");
            entity.Property(e => e.DateofBirth).HasMaxLength(500);
            entity.Property(e => e.DeliveryType).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(500);
            entity.Property(e => e.Gate1).HasMaxLength(500);
            entity.Property(e => e.MemberExpiry).HasMaxLength(500);
            entity.Property(e => e.MemberType).HasMaxLength(500);
            entity.Property(e => e.Membersince).HasMaxLength(500);
            entity.Property(e => e.OrderId)
                .HasMaxLength(500)
                .HasColumnName("OrderID");
            entity.Property(e => e.OrderlineDate).HasColumnType("datetime");
            entity.Property(e => e.OrderlineId)
                .HasMaxLength(500)
                .HasColumnName("OrderlineID");
            entity.Property(e => e.OrderlineItemIdguid)
                .HasMaxLength(500)
                .HasColumnName("OrderlineItemIDGuid");
            entity.Property(e => e.OrganisationId)
                .HasMaxLength(500)
                .HasColumnName("OrganisationID");
            entity.Property(e => e.Package).HasMaxLength(500);
            entity.Property(e => e.PahaddressLine1)
                .HasMaxLength(500)
                .HasColumnName("PAHAddressLine1");
            entity.Property(e => e.PahaddressLine2)
                .HasMaxLength(500)
                .HasColumnName("PAHAddressLine2");
            entity.Property(e => e.PahclubMembershipId).HasColumnName("PAHClubMembershipID");
            entity.Property(e => e.PahclubNativeId)
                .HasMaxLength(500)
                .HasColumnName("PAHClubNativeID");
            entity.Property(e => e.PahcompanyName)
                .HasMaxLength(500)
                .HasColumnName("PAHCompanyName");
            entity.Property(e => e.Pahcountry)
                .HasMaxLength(500)
                .HasColumnName("PAHCountry");
            entity.Property(e => e.PahcustomerId)
                .HasMaxLength(500)
                .HasColumnName("PAHCustomerID");
            entity.Property(e => e.Pahemail)
                .HasMaxLength(500)
                .HasColumnName("PAHEmail");
            entity.Property(e => e.PahfirstName)
                .HasMaxLength(500)
                .HasColumnName("PAHFirstName");
            entity.Property(e => e.PahlastName)
                .HasMaxLength(500)
                .HasColumnName("PAHLastName");
            entity.Property(e => e.PahpostCode)
                .HasMaxLength(500)
                .HasColumnName("PAHPostCode");
            entity.Property(e => e.PahprimaryPhone)
                .HasMaxLength(500)
                .HasColumnName("PAHPrimaryPhone");
            entity.Property(e => e.Pahsalutation)
                .HasMaxLength(500)
                .HasColumnName("PAHSalutation");
            entity.Property(e => e.Pahstate)
                .HasMaxLength(500)
                .HasColumnName("PAHState");
            entity.Property(e => e.PahsuburbCity)
                .HasMaxLength(500)
                .HasColumnName("PAHSuburb_City");
            entity.Property(e => e.PaxCardNo).HasMaxLength(500);
            entity.Property(e => e.PaymentOption).HasMaxLength(500);
            entity.Property(e => e.PostCode).HasMaxLength(500);
            entity.Property(e => e.PriceType).HasMaxLength(500);
            entity.Property(e => e.PriceTypePrintName).HasMaxLength(500);
            entity.Property(e => e.ProcessMethod)
                .HasMaxLength(500)
                .HasColumnName("Process_method");
            entity.Property(e => e.Row1).HasMaxLength(500);
            entity.Property(e => e.RunNumber).HasMaxLength(500);
            entity.Property(e => e.Seat1).HasMaxLength(500);
            entity.Property(e => e.SeatingType).HasMaxLength(500);
            entity.Property(e => e.Section1).HasMaxLength(500);
            entity.Property(e => e.State).HasMaxLength(500);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.SuburbCity)
                .HasMaxLength(500)
                .HasColumnName("Suburb_City");
            entity.Property(e => e.Uniqueid).HasMaxLength(500);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Venue1).HasMaxLength(500);
        });

        modelBuilder.Entity<RawData14523202112070552391073>(entity =>
        {
            entity.ToTable("RawData_145_23_202112070552391073");

            entity.Property(e => e.AddressLine1).HasMaxLength(500);
            entity.Property(e => e.AddressLine2).HasMaxLength(500);
            entity.Property(e => e.Age).HasMaxLength(500);
            entity.Property(e => e.Aisle1).HasMaxLength(500);
            entity.Property(e => e.Barcode).HasMaxLength(500);
            entity.Property(e => e.CardFirstName).HasMaxLength(500);
            entity.Property(e => e.CardLastName).HasMaxLength(500);
            entity.Property(e => e.CardStatus).HasMaxLength(500);
            entity.Property(e => e.Category).HasMaxLength(500);
            entity.Property(e => e.ClubMembershipId).HasColumnName("ClubMembershipID");
            entity.Property(e => e.ClubNativeId)
                .HasMaxLength(500)
                .HasColumnName("ClubNativeID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName).HasMaxLength(500);
            entity.Property(e => e.Country).HasMaxLength(500);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(500)
                .HasColumnName("CustomerID");
            entity.Property(e => e.DateofBirth).HasMaxLength(500);
            entity.Property(e => e.DeliveryType).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(500);
            entity.Property(e => e.Gate1).HasMaxLength(500);
            entity.Property(e => e.GroupId)
                .HasMaxLength(500)
                .HasColumnName("GroupID");
            entity.Property(e => e.MemberExpiry).HasMaxLength(500);
            entity.Property(e => e.MemberType).HasMaxLength(500);
            entity.Property(e => e.Membersince).HasMaxLength(500);
            entity.Property(e => e.OrderId)
                .HasMaxLength(500)
                .HasColumnName("OrderID");
            entity.Property(e => e.OrderlineDate).HasColumnType("datetime");
            entity.Property(e => e.OrderlineId)
                .HasMaxLength(500)
                .HasColumnName("OrderlineID");
            entity.Property(e => e.OrderlineItemIdguid)
                .HasMaxLength(500)
                .HasColumnName("OrderlineItemIDGuid");
            entity.Property(e => e.OrganisationId)
                .HasMaxLength(500)
                .HasColumnName("OrganisationID");
            entity.Property(e => e.Package).HasMaxLength(500);
            entity.Property(e => e.PahaddressLine1)
                .HasMaxLength(500)
                .HasColumnName("PAHAddressLine1");
            entity.Property(e => e.PahaddressLine2)
                .HasMaxLength(500)
                .HasColumnName("PAHAddressLine2");
            entity.Property(e => e.PahclubMembershipId).HasColumnName("PAHClubMembershipID");
            entity.Property(e => e.PahclubNativeId)
                .HasMaxLength(500)
                .HasColumnName("PAHClubNativeID");
            entity.Property(e => e.PahcompanyName)
                .HasMaxLength(500)
                .HasColumnName("PAHCompanyName");
            entity.Property(e => e.Pahcountry)
                .HasMaxLength(500)
                .HasColumnName("PAHCountry");
            entity.Property(e => e.PahcustomerId)
                .HasMaxLength(500)
                .HasColumnName("PAHCustomerID");
            entity.Property(e => e.Pahemail)
                .HasMaxLength(500)
                .HasColumnName("PAHEmail");
            entity.Property(e => e.PahfirstName)
                .HasMaxLength(500)
                .HasColumnName("PAHFirstName");
            entity.Property(e => e.PahlastName)
                .HasMaxLength(500)
                .HasColumnName("PAHLastName");
            entity.Property(e => e.PahpostCode)
                .HasMaxLength(500)
                .HasColumnName("PAHPostCode");
            entity.Property(e => e.PahprimaryPhone)
                .HasMaxLength(500)
                .HasColumnName("PAHPrimaryPhone");
            entity.Property(e => e.Pahsalutation)
                .HasMaxLength(500)
                .HasColumnName("PAHSalutation");
            entity.Property(e => e.Pahstate)
                .HasMaxLength(500)
                .HasColumnName("PAHState");
            entity.Property(e => e.PahsuburbCity)
                .HasMaxLength(500)
                .HasColumnName("PAHSuburb_City");
            entity.Property(e => e.ParticipantId)
                .HasMaxLength(500)
                .HasColumnName("ParticipantID");
            entity.Property(e => e.PaxCardNo).HasMaxLength(500);
            entity.Property(e => e.PaymentOption).HasMaxLength(500);
            entity.Property(e => e.PostCode).HasMaxLength(500);
            entity.Property(e => e.PriceType).HasMaxLength(500);
            entity.Property(e => e.PriceTypePrintName).HasMaxLength(500);
            entity.Property(e => e.Role).HasMaxLength(50);
            entity.Property(e => e.Row1).HasMaxLength(500);
            entity.Property(e => e.RunNumber).HasMaxLength(500);
            entity.Property(e => e.Seat1).HasMaxLength(500);
            entity.Property(e => e.SeatingType).HasMaxLength(500);
            entity.Property(e => e.Section1).HasMaxLength(500);
            entity.Property(e => e.State).HasMaxLength(500);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.SuburbCity)
                .HasMaxLength(500)
                .HasColumnName("Suburb_City");
            entity.Property(e => e.Uniqueid).HasMaxLength(500);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Venue1).HasMaxLength(500);
        });

        modelBuilder.Entity<RawData14523202112070635429635>(entity =>
        {
            entity.ToTable("RawData_145_23_202112070635429635");

            entity.HasIndex(e => new { e.UploadId, e.Status }, "UploadID_Status");

            entity.Property(e => e.AddressLine1).HasMaxLength(500);
            entity.Property(e => e.AddressLine2).HasMaxLength(500);
            entity.Property(e => e.Age).HasMaxLength(500);
            entity.Property(e => e.Aisle1).HasMaxLength(500);
            entity.Property(e => e.Barcode).HasMaxLength(500);
            entity.Property(e => e.CardFirstName).HasMaxLength(500);
            entity.Property(e => e.CardLastName).HasMaxLength(500);
            entity.Property(e => e.CardStatus).HasMaxLength(500);
            entity.Property(e => e.Category).HasMaxLength(500);
            entity.Property(e => e.ClubMembershipId).HasColumnName("ClubMembershipID");
            entity.Property(e => e.ClubNativeId)
                .HasMaxLength(500)
                .HasColumnName("ClubNativeID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName).HasMaxLength(500);
            entity.Property(e => e.Country).HasMaxLength(500);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(500)
                .HasColumnName("CustomerID");
            entity.Property(e => e.DateofBirth).HasColumnType("datetime");
            entity.Property(e => e.DeliveryType).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(500);
            entity.Property(e => e.EmpAcctStatus)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_AcctStatus");
            entity.Property(e => e.EmpCredit)
                .HasDefaultValueSql("((0.0))")
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("EMP_Credit");
            entity.Property(e => e.EmpDisplayOrder).HasColumnName("EMP_DisplayOrder");
            entity.Property(e => e.EmpErrorCode)
                .HasMaxLength(200)
                .HasColumnName("EMP_ErrorCode");
            entity.Property(e => e.EmpGender)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')")
                .HasColumnName("EMP_Gender");
            entity.Property(e => e.EmpGroupId)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')")
                .HasColumnName("EMP_GroupId");
            entity.Property(e => e.EmpGroupUserId)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')")
                .HasColumnName("EMP_GroupUserId");
            entity.Property(e => e.EmpIsCardOnly)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_IsCardOnly");
            entity.Property(e => e.EmpIsMain)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_IsMain");
            entity.Property(e => e.EmpLoginAcctStatus)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_LoginAcctStatus");
            entity.Property(e => e.EmpParticipantId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_ParticipantId");
            entity.Property(e => e.EmpProgramId).HasColumnName("EMP_ProgramId");
            entity.Property(e => e.EmpProgramName)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')")
                .HasColumnName("EMP_ProgramName");
            entity.Property(e => e.EmpRecordInActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_RecordInActive");
            entity.Property(e => e.EmpRecordType)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')")
                .HasColumnName("EMP_RecordType");
            entity.Property(e => e.EmpRedeemed)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_Redeemed");
            entity.Property(e => e.EmpShopName)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')")
                .HasColumnName("EMP_ShopName");
            entity.Property(e => e.EmpUniqueKey)
                .HasMaxLength(300)
                .HasDefaultValueSql("('')")
                .HasColumnName("EMP_UniqueKey");
            entity.Property(e => e.EmpUserId)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')")
                .HasColumnName("EMP_UserId");
            entity.Property(e => e.EmpUserTypeId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_UserTypeId");
            entity.Property(e => e.EmpUsername)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')")
                .HasColumnName("EMP_Username");
            entity.Property(e => e.EmpXmlData)
                .HasColumnType("xml")
                .HasColumnName("EMP_XmlData");
            entity.Property(e => e.Gate1).HasMaxLength(500);
            entity.Property(e => e.MemberExpiry).HasMaxLength(500);
            entity.Property(e => e.MemberType).HasMaxLength(500);
            entity.Property(e => e.Membersince).HasMaxLength(500);
            entity.Property(e => e.OrderId)
                .HasMaxLength(500)
                .HasColumnName("OrderID");
            entity.Property(e => e.OrderlineDate).HasColumnType("datetime");
            entity.Property(e => e.OrderlineId)
                .HasMaxLength(500)
                .HasColumnName("OrderlineID");
            entity.Property(e => e.OrderlineItemIdguid)
                .HasMaxLength(500)
                .HasColumnName("OrderlineItemIDGuid");
            entity.Property(e => e.OrganisationId)
                .HasMaxLength(500)
                .HasColumnName("OrganisationID");
            entity.Property(e => e.Package).HasMaxLength(500);
            entity.Property(e => e.PahaddressLine1)
                .HasMaxLength(500)
                .HasColumnName("PAHAddressLine1");
            entity.Property(e => e.PahaddressLine2)
                .HasMaxLength(500)
                .HasColumnName("PAHAddressLine2");
            entity.Property(e => e.PahclubMembershipId).HasColumnName("PAHClubMembershipID");
            entity.Property(e => e.PahclubNativeId)
                .HasMaxLength(500)
                .HasColumnName("PAHClubNativeID");
            entity.Property(e => e.PahcompanyName)
                .HasMaxLength(500)
                .HasColumnName("PAHCompanyName");
            entity.Property(e => e.Pahcountry)
                .HasMaxLength(500)
                .HasColumnName("PAHCountry");
            entity.Property(e => e.PahcustomerId)
                .HasMaxLength(500)
                .HasColumnName("PAHCustomerID");
            entity.Property(e => e.Pahemail)
                .HasMaxLength(500)
                .HasColumnName("PAHEmail");
            entity.Property(e => e.PahfirstName)
                .HasMaxLength(500)
                .HasColumnName("PAHFirstName");
            entity.Property(e => e.PahlastName)
                .HasMaxLength(500)
                .HasColumnName("PAHLastName");
            entity.Property(e => e.PahpostCode)
                .HasMaxLength(500)
                .HasColumnName("PAHPostCode");
            entity.Property(e => e.PahprimaryPhone)
                .HasMaxLength(500)
                .HasColumnName("PAHPrimaryPhone");
            entity.Property(e => e.Pahsalutation)
                .HasMaxLength(500)
                .HasColumnName("PAHSalutation");
            entity.Property(e => e.Pahstate)
                .HasMaxLength(500)
                .HasColumnName("PAHState");
            entity.Property(e => e.PahsuburbCity)
                .HasMaxLength(500)
                .HasColumnName("PAHSuburb_City");
            entity.Property(e => e.PaxCardNo).HasMaxLength(500);
            entity.Property(e => e.PaymentOption).HasMaxLength(500);
            entity.Property(e => e.PostCode).HasMaxLength(500);
            entity.Property(e => e.PriceType).HasMaxLength(500);
            entity.Property(e => e.PriceTypePrintName).HasMaxLength(500);
            entity.Property(e => e.Row1).HasMaxLength(500);
            entity.Property(e => e.RunNumber).HasMaxLength(500);
            entity.Property(e => e.Seat1).HasMaxLength(500);
            entity.Property(e => e.SeatingType).HasMaxLength(500);
            entity.Property(e => e.Section1).HasMaxLength(500);
            entity.Property(e => e.State).HasMaxLength(500);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.SuburbCity)
                .HasMaxLength(500)
                .HasColumnName("Suburb_City");
            entity.Property(e => e.Uniqueid).HasMaxLength(500);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Venue1).HasMaxLength(500);
        });

        modelBuilder.Entity<RawData15525202204051249187411>(entity =>
        {
            entity.ToTable("RawData_155_25_202204051249187411");

            entity.Property(e => e.AddressLine1).HasMaxLength(500);
            entity.Property(e => e.AddressLine2).HasMaxLength(500);
            entity.Property(e => e.Aisle1).HasMaxLength(500);
            entity.Property(e => e.Aisle2).HasMaxLength(500);
            entity.Property(e => e.Aisle3).HasMaxLength(500);
            entity.Property(e => e.Barcode).HasMaxLength(500);
            entity.Property(e => e.CardFirstName).HasMaxLength(500);
            entity.Property(e => e.CardLastName).HasMaxLength(500);
            entity.Property(e => e.CardStatus).HasMaxLength(500);
            entity.Property(e => e.Category).HasMaxLength(500);
            entity.Property(e => e.ClubMembershipId).HasColumnName("ClubMembershipID");
            entity.Property(e => e.ClubNativeId)
                .HasMaxLength(500)
                .HasColumnName("ClubNativeID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName).HasMaxLength(500);
            entity.Property(e => e.ConsecutiveTenure).HasMaxLength(500);
            entity.Property(e => e.Country).HasMaxLength(500);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.DateOfBirth).HasColumnType("date");
            entity.Property(e => e.DeliveryType).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(500);
            entity.Property(e => e.EmpAcctStatus)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_AcctStatus");
            entity.Property(e => e.EmpCredit)
                .HasDefaultValueSql("((0.0))")
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("EMP_Credit");
            entity.Property(e => e.EmpDisplayOrder).HasColumnName("EMP_DisplayOrder");
            entity.Property(e => e.EmpErrorCode)
                .HasMaxLength(200)
                .HasColumnName("EMP_ErrorCode");
            entity.Property(e => e.EmpGender)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')")
                .HasColumnName("EMP_Gender");
            entity.Property(e => e.EmpGroupId)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')")
                .HasColumnName("EMP_GroupId");
            entity.Property(e => e.EmpGroupUserId)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')")
                .HasColumnName("EMP_GroupUserId");
            entity.Property(e => e.EmpIsCardOnly)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_IsCardOnly");
            entity.Property(e => e.EmpIsMain)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_IsMain");
            entity.Property(e => e.EmpLoginAcctStatus)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_LoginAcctStatus");
            entity.Property(e => e.EmpParticipantId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_ParticipantId");
            entity.Property(e => e.EmpProgramId).HasColumnName("EMP_ProgramId");
            entity.Property(e => e.EmpProgramName)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')")
                .HasColumnName("EMP_ProgramName");
            entity.Property(e => e.EmpRecordInActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_RecordInActive");
            entity.Property(e => e.EmpRecordType)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')")
                .HasColumnName("EMP_RecordType");
            entity.Property(e => e.EmpRedeemed)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_Redeemed");
            entity.Property(e => e.EmpShopName)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')")
                .HasColumnName("EMP_ShopName");
            entity.Property(e => e.EmpUniqueKey)
                .HasMaxLength(300)
                .HasDefaultValueSql("('')")
                .HasColumnName("EMP_UniqueKey");
            entity.Property(e => e.EmpUserId)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')")
                .HasColumnName("EMP_UserId");
            entity.Property(e => e.EmpUserTypeId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_UserTypeId");
            entity.Property(e => e.EmpUsername)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')")
                .HasColumnName("EMP_Username");
            entity.Property(e => e.EmpXmlData)
                .HasColumnType("xml")
                .HasColumnName("EMP_XmlData");
            entity.Property(e => e.Gate1).HasMaxLength(500);
            entity.Property(e => e.Gate2).HasMaxLength(500);
            entity.Property(e => e.Gate3).HasMaxLength(500);
            entity.Property(e => e.MemberExpiry).HasColumnType("date");
            entity.Property(e => e.MemberSince).HasMaxLength(500);
            entity.Property(e => e.MemberType).HasMaxLength(500);
            entity.Property(e => e.OrderId)
                .HasMaxLength(500)
                .HasColumnName("OrderID");
            entity.Property(e => e.OrderlineId)
                .HasMaxLength(500)
                .HasColumnName("OrderlineID");
            entity.Property(e => e.OrderlineItemIdguid)
                .HasMaxLength(500)
                .HasColumnName("OrderlineItemIDGuid");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.Package).HasMaxLength(500);
            entity.Property(e => e.PahaddressLine1)
                .HasMaxLength(500)
                .HasColumnName("PAHAddressLine1");
            entity.Property(e => e.PahaddressLine2)
                .HasMaxLength(500)
                .HasColumnName("PAHAddressLine2");
            entity.Property(e => e.PahclubMembershipId).HasColumnName("PAHClubMembershipID");
            entity.Property(e => e.PahclubNativeId)
                .HasMaxLength(500)
                .HasColumnName("PAHClubNativeID");
            entity.Property(e => e.PahcompanyName)
                .HasMaxLength(500)
                .HasColumnName("PAHCompanyName");
            entity.Property(e => e.Pahcountry)
                .HasMaxLength(500)
                .HasColumnName("PAHCountry");
            entity.Property(e => e.PahcustomerId).HasColumnName("PAHCustomerID");
            entity.Property(e => e.Pahemail)
                .HasMaxLength(500)
                .HasColumnName("PAHEmail");
            entity.Property(e => e.PahfirstName)
                .HasMaxLength(500)
                .HasColumnName("PAHFirstName");
            entity.Property(e => e.PahlastName)
                .HasMaxLength(500)
                .HasColumnName("PAHLastName");
            entity.Property(e => e.PahpostCode)
                .HasMaxLength(500)
                .HasColumnName("PAHPostCode");
            entity.Property(e => e.PahprimaryPhone)
                .HasMaxLength(500)
                .HasColumnName("PAHPrimaryPhone");
            entity.Property(e => e.Pahsalutation)
                .HasMaxLength(500)
                .HasColumnName("PAHSalutation");
            entity.Property(e => e.Pahstate)
                .HasMaxLength(500)
                .HasColumnName("PAHState");
            entity.Property(e => e.Pahsuburb)
                .HasMaxLength(500)
                .HasColumnName("PAHSuburb");
            entity.Property(e => e.PaxCardNo).HasMaxLength(500);
            entity.Property(e => e.PaymentOption).HasMaxLength(500);
            entity.Property(e => e.PostCode).HasMaxLength(500);
            entity.Property(e => e.PriceType).HasMaxLength(500);
            entity.Property(e => e.PriceTypePrintName).HasMaxLength(500);
            entity.Property(e => e.ProcessMethod).HasMaxLength(500);
            entity.Property(e => e.Row1).HasMaxLength(500);
            entity.Property(e => e.Row2).HasMaxLength(500);
            entity.Property(e => e.Row3).HasMaxLength(500);
            entity.Property(e => e.RunNumber).HasMaxLength(500);
            entity.Property(e => e.Seat1).HasMaxLength(500);
            entity.Property(e => e.Seat2).HasMaxLength(500);
            entity.Property(e => e.Seat3).HasMaxLength(500);
            entity.Property(e => e.SeatingType).HasMaxLength(500);
            entity.Property(e => e.Section1).HasMaxLength(500);
            entity.Property(e => e.Section2).HasMaxLength(500);
            entity.Property(e => e.Section3).HasMaxLength(500);
            entity.Property(e => e.State).HasMaxLength(500);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.Suburb).HasMaxLength(500);
            entity.Property(e => e.Uniqueid).HasMaxLength(500);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Venue1).HasMaxLength(500);
            entity.Property(e => e.Venue2).HasMaxLength(500);
            entity.Property(e => e.Venue3).HasMaxLength(500);
        });

        modelBuilder.Entity<RawData15924202204120429023104>(entity =>
        {
            entity.ToTable("RawData_159_24_202204120429023104");

            entity.Property(e => e.AddressLine1).HasMaxLength(500);
            entity.Property(e => e.AddressLine2).HasMaxLength(500);
            entity.Property(e => e.Age).HasMaxLength(500);
            entity.Property(e => e.Aisle1).HasMaxLength(500);
            entity.Property(e => e.Barcode).HasMaxLength(500);
            entity.Property(e => e.CardFirstName).HasMaxLength(500);
            entity.Property(e => e.CardLastName).HasMaxLength(500);
            entity.Property(e => e.CardStatus).HasMaxLength(500);
            entity.Property(e => e.Category).HasMaxLength(500);
            entity.Property(e => e.ClubMembershipId).HasColumnName("ClubMembershipID");
            entity.Property(e => e.ClubNativeId)
                .HasMaxLength(500)
                .HasColumnName("ClubNativeID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName).HasMaxLength(500);
            entity.Property(e => e.Country).HasMaxLength(500);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(500)
                .HasColumnName("CustomerID");
            entity.Property(e => e.DateofBirth).HasColumnType("datetime");
            entity.Property(e => e.DeliveryType).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(500);
            entity.Property(e => e.Gate1).HasMaxLength(500);
            entity.Property(e => e.MemberExpiry).HasMaxLength(500);
            entity.Property(e => e.MemberType).HasMaxLength(500);
            entity.Property(e => e.Membersince).HasMaxLength(500);
            entity.Property(e => e.OrderId)
                .HasMaxLength(500)
                .HasColumnName("OrderID");
            entity.Property(e => e.OrderlineDate).HasColumnType("datetime");
            entity.Property(e => e.OrderlineId)
                .HasMaxLength(500)
                .HasColumnName("OrderlineID");
            entity.Property(e => e.OrderlineItemIdguid)
                .HasMaxLength(500)
                .HasColumnName("OrderlineItemIDGuid");
            entity.Property(e => e.OrganisationId)
                .HasMaxLength(500)
                .HasColumnName("OrganisationID");
            entity.Property(e => e.Package).HasMaxLength(500);
            entity.Property(e => e.PahaddressLine1)
                .HasMaxLength(500)
                .HasColumnName("PAHAddressLine1");
            entity.Property(e => e.PahaddressLine2)
                .HasMaxLength(500)
                .HasColumnName("PAHAddressLine2");
            entity.Property(e => e.PahclubMembershipId).HasColumnName("PAHClubMembershipID");
            entity.Property(e => e.PahclubNativeId)
                .HasMaxLength(500)
                .HasColumnName("PAHClubNativeID");
            entity.Property(e => e.PahcompanyName)
                .HasMaxLength(500)
                .HasColumnName("PAHCompanyName");
            entity.Property(e => e.Pahcountry)
                .HasMaxLength(500)
                .HasColumnName("PAHCountry");
            entity.Property(e => e.PahcustomerId)
                .HasMaxLength(500)
                .HasColumnName("PAHCustomerID");
            entity.Property(e => e.Pahemail)
                .HasMaxLength(500)
                .HasColumnName("PAHEmail");
            entity.Property(e => e.PahfirstName)
                .HasMaxLength(500)
                .HasColumnName("PAHFirstName");
            entity.Property(e => e.PahlastName)
                .HasMaxLength(500)
                .HasColumnName("PAHLastName");
            entity.Property(e => e.PahpostCode)
                .HasMaxLength(500)
                .HasColumnName("PAHPostCode");
            entity.Property(e => e.PahprimaryPhone)
                .HasMaxLength(500)
                .HasColumnName("PAHPrimaryPhone");
            entity.Property(e => e.Pahsalutation)
                .HasMaxLength(500)
                .HasColumnName("PAHSalutation");
            entity.Property(e => e.Pahstate)
                .HasMaxLength(500)
                .HasColumnName("PAHState");
            entity.Property(e => e.PahsuburbCity)
                .HasMaxLength(500)
                .HasColumnName("PAHSuburb_City");
            entity.Property(e => e.PaxCardNo).HasMaxLength(500);
            entity.Property(e => e.PaymentOption).HasMaxLength(500);
            entity.Property(e => e.PostCode).HasMaxLength(500);
            entity.Property(e => e.PriceType).HasMaxLength(500);
            entity.Property(e => e.PriceTypePrintName).HasMaxLength(500);
            entity.Property(e => e.Row1).HasMaxLength(500);
            entity.Property(e => e.RunNumber).HasMaxLength(500);
            entity.Property(e => e.Seat1).HasMaxLength(500);
            entity.Property(e => e.SeatingType).HasMaxLength(500);
            entity.Property(e => e.Section1).HasMaxLength(500);
            entity.Property(e => e.State).HasMaxLength(500);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.SuburbCity)
                .HasMaxLength(500)
                .HasColumnName("Suburb_City");
            entity.Property(e => e.Uniqueid).HasMaxLength(500);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Venue1).HasMaxLength(500);
        });

        modelBuilder.Entity<RawData15924202204141200142466>(entity =>
        {
            entity.ToTable("RawData_159_24_202204141200142466");

            entity.HasIndex(e => e.EmpGroupId, "EMP_GroupID");

            entity.HasIndex(e => new { e.EmpUserId, e.UploadId }, "EMP_UserId");

            entity.HasIndex(e => e.UploadId, "UploadId");

            entity.Property(e => e.AcctId).HasColumnName("acct_id");
            entity.Property(e => e.AcctTypeDesc)
                .HasMaxLength(500)
                .HasColumnName("acct_type_desc");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Barcode)
                .HasMaxLength(500)
                .HasColumnName("barcode");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("birthdate");
            entity.Property(e => e.Card)
                .HasMaxLength(500)
                .HasColumnName("card");
            entity.Property(e => e.City)
                .HasMaxLength(500)
                .HasColumnName("city");
            entity.Property(e => e.ClubCode)
                .HasMaxLength(500)
                .HasColumnName("club_code");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(500)
                .HasColumnName("company_name");
            entity.Property(e => e.ConcessionText)
                .HasMaxLength(500)
                .HasColumnName("concession_text");
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .HasColumnName("country");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustNameId).HasColumnName("cust_name_id");
            entity.Property(e => e.DeliveryInstructions)
                .HasMaxLength(500)
                .HasColumnName("delivery_instructions");
            entity.Property(e => e.DeliveryMethodName)
                .HasMaxLength(500)
                .HasColumnName("delivery_method_name");
            entity.Property(e => e.EmailAddr)
                .HasMaxLength(500)
                .HasColumnName("email_addr");
            entity.Property(e => e.EmpAcctStatus).HasColumnName("EMP_AcctStatus");
            entity.Property(e => e.EmpCredit)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("EMP_Credit");
            entity.Property(e => e.EmpDisplayOrder).HasColumnName("EMP_DisplayOrder");
            entity.Property(e => e.EmpErrorCode)
                .HasMaxLength(200)
                .HasColumnName("EMP_ErrorCode");
            entity.Property(e => e.EmpGender)
                .HasMaxLength(200)
                .HasColumnName("EMP_Gender");
            entity.Property(e => e.EmpGroupId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupId");
            entity.Property(e => e.EmpGroupUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupUserId");
            entity.Property(e => e.EmpIsCardOnly).HasColumnName("EMP_IsCardOnly");
            entity.Property(e => e.EmpIsMain)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_IsMain");
            entity.Property(e => e.EmpLoginAcctStatus).HasColumnName("EMP_LoginAcctStatus");
            entity.Property(e => e.EmpParticipantId).HasColumnName("EMP_ParticipantId");
            entity.Property(e => e.EmpProgramId).HasColumnName("EMP_ProgramId");
            entity.Property(e => e.EmpProgramName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ProgramName");
            entity.Property(e => e.EmpRecordInActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_RecordInActive");
            entity.Property(e => e.EmpRecordType)
                .HasMaxLength(200)
                .HasColumnName("EMP_RecordType");
            entity.Property(e => e.EmpRedeemed).HasColumnName("EMP_Redeemed");
            entity.Property(e => e.EmpSeasonId).HasColumnName("EMP_SeasonID");
            entity.Property(e => e.EmpShopName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ShopName");
            entity.Property(e => e.EmpUniqueKey)
                .HasMaxLength(300)
                .HasColumnName("EMP_UniqueKey");
            entity.Property(e => e.EmpUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_UserId");
            entity.Property(e => e.EmpUserTypeId).HasColumnName("EMP_UserTypeId");
            entity.Property(e => e.EmpUsername)
                .HasMaxLength(200)
                .HasColumnName("EMP_Username");
            entity.Property(e => e.EmpXmlData)
                .HasColumnType("xml")
                .HasColumnName("EMP_XmlData");
            entity.Property(e => e.EventLine1)
                .HasMaxLength(500)
                .HasColumnName("event_line1");
            entity.Property(e => e.EventLine2)
                .HasMaxLength(500)
                .HasColumnName("event_line2");
            entity.Property(e => e.EventLine3)
                .HasMaxLength(500)
                .HasColumnName("event_line3");
            entity.Property(e => e.EventName)
                .HasMaxLength(500)
                .HasColumnName("event_name");
            entity.Property(e => e.FamilyId).HasColumnName("family_id");
            entity.Property(e => e.Fulfilment)
                .HasMaxLength(500)
                .HasColumnName("fulfilment");
            entity.Property(e => e.Gender)
                .HasMaxLength(500)
                .HasColumnName("gender");
            entity.Property(e => e.GroupCodes)
                .HasMaxLength(500)
                .HasColumnName("group_codes");
            entity.Property(e => e.LocationCity)
                .HasMaxLength(500)
                .HasColumnName("location_city");
            entity.Property(e => e.LocationCountry)
                .HasMaxLength(500)
                .HasColumnName("location_country");
            entity.Property(e => e.LocationState)
                .HasMaxLength(500)
                .HasColumnName("location_state");
            entity.Property(e => e.LocationStreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_1");
            entity.Property(e => e.LocationStreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_2");
            entity.Property(e => e.LocationZip)
                .HasMaxLength(500)
                .HasColumnName("location_zip");
            entity.Property(e => e.MemberId).HasColumnName("member_id");
            entity.Property(e => e.MemberSince).HasColumnName("member_since");
            entity.Property(e => e.MembershipType)
                .HasMaxLength(500)
                .HasColumnName("membership_type");
            entity.Property(e => e.NameFirst)
                .HasMaxLength(500)
                .HasColumnName("name_first");
            entity.Property(e => e.NameLast)
                .HasMaxLength(500)
                .HasColumnName("name_last");
            entity.Property(e => e.Note1)
                .HasMaxLength(500)
                .HasColumnName("note1");
            entity.Property(e => e.NumSeats).HasColumnName("num_seats");
            entity.Property(e => e.OrderLineItem).HasColumnName("order_line_item");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.PaymentPlan)
                .HasMaxLength(500)
                .HasColumnName("payment_plan");
            entity.Property(e => e.PhoneCell)
                .HasMaxLength(500)
                .HasColumnName("phone_cell");
            entity.Property(e => e.PhoneDay)
                .HasMaxLength(500)
                .HasColumnName("phone_day");
            entity.Property(e => e.PhoneEve)
                .HasMaxLength(500)
                .HasColumnName("phone_eve");
            entity.Property(e => e.PriceCode)
                .HasMaxLength(500)
                .HasColumnName("price_code");
            entity.Property(e => e.PriceCodeDesc)
                .HasMaxLength(500)
                .HasColumnName("price_code_desc");
            entity.Property(e => e.PriceCodeExtra)
                .HasMaxLength(500)
                .HasColumnName("price_code_extra");
            entity.Property(e => e.PriceCodeInfo1)
                .HasMaxLength(500)
                .HasColumnName("price_code_info1");
            entity.Property(e => e.PriceCodeInfo2)
                .HasMaxLength(500)
                .HasColumnName("price_code_info2");
            entity.Property(e => e.PriceCodeInfo3)
                .HasMaxLength(500)
                .HasColumnName("price_code_info3");
            entity.Property(e => e.PriceCodeInfo4)
                .HasMaxLength(500)
                .HasColumnName("price_code_info4");
            entity.Property(e => e.PrimaryName)
                .HasMaxLength(500)
                .HasColumnName("primary_name");
            entity.Property(e => e.PrintCount).HasColumnName("print_count");
            entity.Property(e => e.PrintDate)
                .HasColumnType("datetime")
                .HasColumnName("print_date");
            entity.Property(e => e.RowName)
                .HasMaxLength(500)
                .HasColumnName("row_name");
            entity.Property(e => e.SeatNum).HasColumnName("seat_num");
            entity.Property(e => e.SectionName)
                .HasMaxLength(500)
                .HasColumnName("section_name");
            entity.Property(e => e.State)
                .HasMaxLength(500)
                .HasColumnName("state");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("street_addr_1");
            entity.Property(e => e.StreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("street_addr_2");
            entity.Property(e => e.TicketTypeCategory)
                .HasMaxLength(500)
                .HasColumnName("ticket_type_category");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Venue1Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue1_aisle");
            entity.Property(e => e.Venue1Gate)
                .HasMaxLength(500)
                .HasColumnName("venue1_gate");
            entity.Property(e => e.Venue1Row)
                .HasMaxLength(500)
                .HasColumnName("venue1_row");
            entity.Property(e => e.Venue1Seat)
                .HasMaxLength(500)
                .HasColumnName("venue1_seat");
            entity.Property(e => e.Venue1Section)
                .HasMaxLength(500)
                .HasColumnName("venue1_section");
            entity.Property(e => e.Venue1Stand)
                .HasMaxLength(500)
                .HasColumnName("venue1_stand");
            entity.Property(e => e.Venue2Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue2_aisle");
            entity.Property(e => e.Venue2Gate)
                .HasMaxLength(500)
                .HasColumnName("venue2_gate");
            entity.Property(e => e.Venue2Row)
                .HasMaxLength(500)
                .HasColumnName("venue2_row");
            entity.Property(e => e.Venue2Seat)
                .HasMaxLength(500)
                .HasColumnName("venue2_seat");
            entity.Property(e => e.Venue2Section)
                .HasMaxLength(500)
                .HasColumnName("venue2_section");
            entity.Property(e => e.Venue2Stand)
                .HasMaxLength(500)
                .HasColumnName("venue2_stand");
            entity.Property(e => e.YearsMembership).HasColumnName("years_membership");
            entity.Property(e => e.Zip)
                .HasMaxLength(500)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<RawData16029202204130600208033>(entity =>
        {
            entity.ToTable("RawData_160_29_202204130600208033");

            entity.Property(e => e.AcctId).HasColumnName("acct_id");
            entity.Property(e => e.AcctTypeDesc)
                .HasMaxLength(500)
                .HasColumnName("acct_type_desc");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Barcode)
                .HasMaxLength(500)
                .HasColumnName("barcode");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("birthdate");
            entity.Property(e => e.Card)
                .HasMaxLength(500)
                .HasColumnName("card");
            entity.Property(e => e.City)
                .HasMaxLength(500)
                .HasColumnName("city");
            entity.Property(e => e.ClubCode)
                .HasMaxLength(500)
                .HasColumnName("club_code");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(500)
                .HasColumnName("company_name");
            entity.Property(e => e.ConcessionText)
                .HasMaxLength(500)
                .HasColumnName("concession_text");
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .HasColumnName("country");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustNameId).HasColumnName("cust_name_id");
            entity.Property(e => e.DeliveryInstructions)
                .HasMaxLength(500)
                .HasColumnName("delivery_instructions");
            entity.Property(e => e.DeliveryMethodName)
                .HasMaxLength(500)
                .HasColumnName("delivery_method_name");
            entity.Property(e => e.EmailAddr)
                .HasMaxLength(500)
                .HasColumnName("email_addr");
            entity.Property(e => e.EmpAcctStatus).HasColumnName("EMP_AcctStatus");
            entity.Property(e => e.EmpCredit)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("EMP_Credit");
            entity.Property(e => e.EmpDisplayOrder).HasColumnName("EMP_DisplayOrder");
            entity.Property(e => e.EmpErrorCode)
                .HasMaxLength(200)
                .HasColumnName("EMP_ErrorCode");
            entity.Property(e => e.EmpGender)
                .HasMaxLength(200)
                .HasColumnName("EMP_Gender");
            entity.Property(e => e.EmpGroupId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupId");
            entity.Property(e => e.EmpGroupUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupUserId");
            entity.Property(e => e.EmpIsCardOnly).HasColumnName("EMP_IsCardOnly");
            entity.Property(e => e.EmpIsMain)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_IsMain");
            entity.Property(e => e.EmpLoginAcctStatus).HasColumnName("EMP_LoginAcctStatus");
            entity.Property(e => e.EmpParticipantId).HasColumnName("EMP_ParticipantId");
            entity.Property(e => e.EmpProgramId).HasColumnName("EMP_ProgramId");
            entity.Property(e => e.EmpProgramName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ProgramName");
            entity.Property(e => e.EmpRecordInActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_RecordInActive");
            entity.Property(e => e.EmpRecordType)
                .HasMaxLength(200)
                .HasColumnName("EMP_RecordType");
            entity.Property(e => e.EmpRedeemed).HasColumnName("EMP_Redeemed");
            entity.Property(e => e.EmpShopName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ShopName");
            entity.Property(e => e.EmpUniqueKey)
                .HasMaxLength(300)
                .HasColumnName("EMP_UniqueKey");
            entity.Property(e => e.EmpUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_UserId");
            entity.Property(e => e.EmpUserTypeId).HasColumnName("EMP_UserTypeId");
            entity.Property(e => e.EmpUsername)
                .HasMaxLength(200)
                .HasColumnName("EMP_Username");
            entity.Property(e => e.EmpXmlData)
                .HasColumnType("xml")
                .HasColumnName("EMP_XmlData");
            entity.Property(e => e.EventLine1)
                .HasMaxLength(500)
                .HasColumnName("event_line1");
            entity.Property(e => e.EventLine2)
                .HasMaxLength(500)
                .HasColumnName("event_line2");
            entity.Property(e => e.EventLine3)
                .HasMaxLength(500)
                .HasColumnName("event_line3");
            entity.Property(e => e.EventName)
                .HasMaxLength(500)
                .HasColumnName("event_name");
            entity.Property(e => e.FamilyId).HasColumnName("family_id");
            entity.Property(e => e.Fulfilment)
                .HasMaxLength(500)
                .HasColumnName("fulfilment");
            entity.Property(e => e.Gender)
                .HasMaxLength(500)
                .HasColumnName("gender");
            entity.Property(e => e.GroupCodes)
                .HasMaxLength(500)
                .HasColumnName("group_codes");
            entity.Property(e => e.LocationCity)
                .HasMaxLength(500)
                .HasColumnName("location_city");
            entity.Property(e => e.LocationCountry)
                .HasMaxLength(500)
                .HasColumnName("location_country");
            entity.Property(e => e.LocationState)
                .HasMaxLength(500)
                .HasColumnName("location_state");
            entity.Property(e => e.LocationStreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_1");
            entity.Property(e => e.LocationStreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_2");
            entity.Property(e => e.LocationZip)
                .HasMaxLength(500)
                .HasColumnName("location_zip");
            entity.Property(e => e.MemberId).HasColumnName("member_id");
            entity.Property(e => e.MemberSince).HasColumnName("member_since");
            entity.Property(e => e.MembershipType)
                .HasMaxLength(500)
                .HasColumnName("membership_type");
            entity.Property(e => e.NameFirst)
                .HasMaxLength(500)
                .HasColumnName("name_first");
            entity.Property(e => e.NameLast)
                .HasMaxLength(500)
                .HasColumnName("name_last");
            entity.Property(e => e.Note1)
                .HasMaxLength(500)
                .HasColumnName("note1");
            entity.Property(e => e.NumSeats).HasColumnName("num_seats");
            entity.Property(e => e.OrderLineItem).HasColumnName("order_line_item");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.PaymentPlan)
                .HasMaxLength(500)
                .HasColumnName("payment_plan");
            entity.Property(e => e.PhoneCell)
                .HasMaxLength(500)
                .HasColumnName("phone_cell");
            entity.Property(e => e.PhoneDay)
                .HasMaxLength(500)
                .HasColumnName("phone_day");
            entity.Property(e => e.PhoneEve)
                .HasMaxLength(500)
                .HasColumnName("phone_eve");
            entity.Property(e => e.PriceCode)
                .HasMaxLength(500)
                .HasColumnName("price_code");
            entity.Property(e => e.PriceCodeDesc)
                .HasMaxLength(500)
                .HasColumnName("price_code_desc");
            entity.Property(e => e.PriceCodeExtra)
                .HasMaxLength(500)
                .HasColumnName("price_code_extra");
            entity.Property(e => e.PriceCodeInfo1)
                .HasMaxLength(500)
                .HasColumnName("price_code_info1");
            entity.Property(e => e.PriceCodeInfo2)
                .HasMaxLength(500)
                .HasColumnName("price_code_info2");
            entity.Property(e => e.PriceCodeInfo3)
                .HasMaxLength(500)
                .HasColumnName("price_code_info3");
            entity.Property(e => e.PriceCodeInfo4)
                .HasMaxLength(500)
                .HasColumnName("price_code_info4");
            entity.Property(e => e.PrimaryName)
                .HasMaxLength(500)
                .HasColumnName("primary_name");
            entity.Property(e => e.PrintCount).HasColumnName("print_count");
            entity.Property(e => e.PrintDate)
                .HasColumnType("datetime")
                .HasColumnName("print_date");
            entity.Property(e => e.RowName)
                .HasMaxLength(500)
                .HasColumnName("row_name");
            entity.Property(e => e.SeatNum).HasColumnName("seat_num");
            entity.Property(e => e.SectionName)
                .HasMaxLength(500)
                .HasColumnName("section_name");
            entity.Property(e => e.State)
                .HasMaxLength(500)
                .HasColumnName("state");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("street_addr_1");
            entity.Property(e => e.StreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("street_addr_2");
            entity.Property(e => e.TicketTypeCategory)
                .HasMaxLength(500)
                .HasColumnName("ticket_type_category");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Venue1Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue1_aisle");
            entity.Property(e => e.Venue1Gate)
                .HasMaxLength(500)
                .HasColumnName("venue1_gate");
            entity.Property(e => e.Venue1Row)
                .HasMaxLength(500)
                .HasColumnName("venue1_row");
            entity.Property(e => e.Venue1Seat)
                .HasMaxLength(500)
                .HasColumnName("venue1_seat");
            entity.Property(e => e.Venue1Section)
                .HasMaxLength(500)
                .HasColumnName("venue1_section");
            entity.Property(e => e.Venue1Stand)
                .HasMaxLength(500)
                .HasColumnName("venue1_stand");
            entity.Property(e => e.Venue2Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue2_aisle");
            entity.Property(e => e.Venue2Gate)
                .HasMaxLength(500)
                .HasColumnName("venue2_gate");
            entity.Property(e => e.Venue2Row)
                .HasMaxLength(500)
                .HasColumnName("venue2_row");
            entity.Property(e => e.Venue2Seat)
                .HasMaxLength(500)
                .HasColumnName("venue2_seat");
            entity.Property(e => e.Venue2Section)
                .HasMaxLength(500)
                .HasColumnName("venue2_section");
            entity.Property(e => e.Venue2Stand)
                .HasMaxLength(500)
                .HasColumnName("venue2_stand");
            entity.Property(e => e.YearsMembership).HasColumnName("years_membership");
            entity.Property(e => e.Zip)
                .HasMaxLength(500)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<RawData16433202205171009063367>(entity =>
        {
            entity.ToTable("RawData_164_33_202205171009063367");

            entity.Property(e => e.AddressLine1).HasMaxLength(500);
            entity.Property(e => e.AddressLine2).HasMaxLength(500);
            entity.Property(e => e.Age).HasMaxLength(500);
            entity.Property(e => e.Aisle1).HasMaxLength(500);
            entity.Property(e => e.Barcode).HasMaxLength(500);
            entity.Property(e => e.CardFirstName).HasMaxLength(500);
            entity.Property(e => e.CardLastName).HasMaxLength(500);
            entity.Property(e => e.CardStatus).HasMaxLength(500);
            entity.Property(e => e.Category).HasMaxLength(500);
            entity.Property(e => e.ClubMembershipId).HasColumnName("ClubMembershipID");
            entity.Property(e => e.ClubNativeId)
                .HasMaxLength(500)
                .HasColumnName("ClubNativeID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName).HasMaxLength(500);
            entity.Property(e => e.Country).HasMaxLength(500);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(500)
                .HasColumnName("CustomerID");
            entity.Property(e => e.DateofBirth).HasColumnType("datetime");
            entity.Property(e => e.DeliveryType).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(500);
            entity.Property(e => e.EmpAcctStatus).HasColumnName("EMP_AcctStatus");
            entity.Property(e => e.EmpCredit)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("EMP_Credit");
            entity.Property(e => e.EmpDisplayOrder).HasColumnName("EMP_DisplayOrder");
            entity.Property(e => e.EmpErrorCode)
                .HasMaxLength(200)
                .HasColumnName("EMP_ErrorCode");
            entity.Property(e => e.EmpGender)
                .HasMaxLength(200)
                .HasColumnName("EMP_Gender");
            entity.Property(e => e.EmpGroupId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupId");
            entity.Property(e => e.EmpGroupUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupUserId");
            entity.Property(e => e.EmpIsCardOnly).HasColumnName("EMP_IsCardOnly");
            entity.Property(e => e.EmpIsMain)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_IsMain");
            entity.Property(e => e.EmpLoginAcctStatus).HasColumnName("EMP_LoginAcctStatus");
            entity.Property(e => e.EmpParticipantId).HasColumnName("EMP_ParticipantId");
            entity.Property(e => e.EmpProgramId).HasColumnName("EMP_ProgramId");
            entity.Property(e => e.EmpProgramName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ProgramName");
            entity.Property(e => e.EmpRecordInActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_RecordInActive");
            entity.Property(e => e.EmpRecordType)
                .HasMaxLength(200)
                .HasColumnName("EMP_RecordType");
            entity.Property(e => e.EmpRedeemed).HasColumnName("EMP_Redeemed");
            entity.Property(e => e.EmpSeasonId).HasColumnName("EMP_SeasonID");
            entity.Property(e => e.EmpShopName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ShopName");
            entity.Property(e => e.EmpUniqueKey)
                .HasMaxLength(300)
                .HasColumnName("EMP_UniqueKey");
            entity.Property(e => e.EmpUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_UserId");
            entity.Property(e => e.EmpUserTypeId).HasColumnName("EMP_UserTypeId");
            entity.Property(e => e.EmpUsername)
                .HasMaxLength(200)
                .HasColumnName("EMP_Username");
            entity.Property(e => e.EmpXmlData)
                .HasColumnType("xml")
                .HasColumnName("EMP_XmlData");
            entity.Property(e => e.Gate1).HasMaxLength(500);
            entity.Property(e => e.MemberExpiry).HasMaxLength(500);
            entity.Property(e => e.MemberSince).HasMaxLength(500);
            entity.Property(e => e.MemberType).HasMaxLength(500);
            entity.Property(e => e.OrderId)
                .HasMaxLength(500)
                .HasColumnName("OrderID");
            entity.Property(e => e.OrderlineDate).HasColumnType("datetime");
            entity.Property(e => e.OrderlineId)
                .HasMaxLength(500)
                .HasColumnName("OrderlineID");
            entity.Property(e => e.OrderlineItemIdguid)
                .HasMaxLength(500)
                .HasColumnName("OrderlineItemIDGuid");
            entity.Property(e => e.OrganisationId)
                .HasMaxLength(500)
                .HasColumnName("OrganisationID");
            entity.Property(e => e.Package).HasMaxLength(500);
            entity.Property(e => e.PahaddressLine1)
                .HasMaxLength(500)
                .HasColumnName("PAHAddressLine1");
            entity.Property(e => e.PahaddressLine2)
                .HasMaxLength(500)
                .HasColumnName("PAHAddressLine2");
            entity.Property(e => e.PahclubMembershipId).HasColumnName("PAHClubMembershipID");
            entity.Property(e => e.PahclubNativeId)
                .HasMaxLength(500)
                .HasColumnName("PAHClubNativeID");
            entity.Property(e => e.PahcompanyName)
                .HasMaxLength(500)
                .HasColumnName("PAHCompanyName");
            entity.Property(e => e.Pahcountry)
                .HasMaxLength(500)
                .HasColumnName("PAHCountry");
            entity.Property(e => e.PahcustomerId)
                .HasMaxLength(500)
                .HasColumnName("PAHCustomerID");
            entity.Property(e => e.Pahemail)
                .HasMaxLength(500)
                .HasColumnName("PAHEmail");
            entity.Property(e => e.PahfirstName)
                .HasMaxLength(500)
                .HasColumnName("PAHFirstName");
            entity.Property(e => e.PahlastName)
                .HasMaxLength(500)
                .HasColumnName("PAHLastName");
            entity.Property(e => e.PahpostCode)
                .HasMaxLength(500)
                .HasColumnName("PAHPostCode");
            entity.Property(e => e.PahprimaryPhone)
                .HasMaxLength(500)
                .HasColumnName("PAHPrimaryPhone");
            entity.Property(e => e.Pahsalutation)
                .HasMaxLength(500)
                .HasColumnName("PAHSalutation");
            entity.Property(e => e.Pahstate)
                .HasMaxLength(500)
                .HasColumnName("PAHState");
            entity.Property(e => e.PahsuburbCity)
                .HasMaxLength(500)
                .HasColumnName("PAHSuburb_City");
            entity.Property(e => e.PaxCardNo).HasMaxLength(500);
            entity.Property(e => e.PaymentOption).HasMaxLength(500);
            entity.Property(e => e.PostCode).HasMaxLength(500);
            entity.Property(e => e.PriceType).HasMaxLength(500);
            entity.Property(e => e.PriceTypePrintName).HasMaxLength(500);
            entity.Property(e => e.ProcessMethod)
                .HasMaxLength(500)
                .HasColumnName("Process_Method");
            entity.Property(e => e.Row1).HasMaxLength(500);
            entity.Property(e => e.RunNumber).HasMaxLength(500);
            entity.Property(e => e.Seat1).HasMaxLength(500);
            entity.Property(e => e.SeatingType).HasMaxLength(500);
            entity.Property(e => e.Section1).HasMaxLength(500);
            entity.Property(e => e.State).HasMaxLength(500);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.SuburbCity)
                .HasMaxLength(500)
                .HasColumnName("Suburb_City");
            entity.Property(e => e.Uniqueid).HasMaxLength(500);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Venue1).HasMaxLength(500);
        });

        modelBuilder.Entity<RawData16433202205171033357803>(entity =>
        {
            entity.ToTable("RawData_164_33_202205171033357803");

            entity.HasIndex(e => e.EmpGroupId, "EMP_GroupID");

            entity.HasIndex(e => new { e.EmpUserId, e.UploadId }, "EMP_UserId");

            entity.HasIndex(e => e.UploadId, "UploadId");

            entity.Property(e => e.AddressLine1).HasMaxLength(500);
            entity.Property(e => e.AddressLine2).HasMaxLength(500);
            entity.Property(e => e.Age).HasMaxLength(500);
            entity.Property(e => e.Aisle1).HasMaxLength(500);
            entity.Property(e => e.Barcode).HasMaxLength(500);
            entity.Property(e => e.CardFirstName).HasMaxLength(500);
            entity.Property(e => e.CardLastName).HasMaxLength(500);
            entity.Property(e => e.CardStatus).HasMaxLength(500);
            entity.Property(e => e.Category).HasMaxLength(500);
            entity.Property(e => e.ClubMembershipId).HasColumnName("ClubMembershipID");
            entity.Property(e => e.ClubNativeId)
                .HasMaxLength(500)
                .HasColumnName("ClubNativeID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName).HasMaxLength(500);
            entity.Property(e => e.Country).HasMaxLength(500);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(500)
                .HasColumnName("CustomerID");
            entity.Property(e => e.DateofBirth).HasColumnType("datetime");
            entity.Property(e => e.DeliveryType).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(500);
            entity.Property(e => e.EmpAcctStatus).HasColumnName("EMP_AcctStatus");
            entity.Property(e => e.EmpCredit)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("EMP_Credit");
            entity.Property(e => e.EmpDisplayOrder).HasColumnName("EMP_DisplayOrder");
            entity.Property(e => e.EmpErrorCode)
                .HasMaxLength(200)
                .HasColumnName("EMP_ErrorCode");
            entity.Property(e => e.EmpGender)
                .HasMaxLength(200)
                .HasColumnName("EMP_Gender");
            entity.Property(e => e.EmpGroupId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupId");
            entity.Property(e => e.EmpGroupUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupUserId");
            entity.Property(e => e.EmpIsCardOnly).HasColumnName("EMP_IsCardOnly");
            entity.Property(e => e.EmpIsMain)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_IsMain");
            entity.Property(e => e.EmpLoginAcctStatus).HasColumnName("EMP_LoginAcctStatus");
            entity.Property(e => e.EmpParticipantId).HasColumnName("EMP_ParticipantId");
            entity.Property(e => e.EmpProgramId).HasColumnName("EMP_ProgramId");
            entity.Property(e => e.EmpProgramName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ProgramName");
            entity.Property(e => e.EmpRecordInActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_RecordInActive");
            entity.Property(e => e.EmpRecordType)
                .HasMaxLength(200)
                .HasColumnName("EMP_RecordType");
            entity.Property(e => e.EmpRedeemed).HasColumnName("EMP_Redeemed");
            entity.Property(e => e.EmpSeasonId).HasColumnName("EMP_SeasonID");
            entity.Property(e => e.EmpShopName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ShopName");
            entity.Property(e => e.EmpUniqueKey)
                .HasMaxLength(300)
                .HasColumnName("EMP_UniqueKey");
            entity.Property(e => e.EmpUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_UserId");
            entity.Property(e => e.EmpUserTypeId).HasColumnName("EMP_UserTypeId");
            entity.Property(e => e.EmpUsername)
                .HasMaxLength(200)
                .HasColumnName("EMP_Username");
            entity.Property(e => e.EmpXmlData)
                .HasColumnType("xml")
                .HasColumnName("EMP_XmlData");
            entity.Property(e => e.Gate1).HasMaxLength(500);
            entity.Property(e => e.MemberExpiry).HasMaxLength(500);
            entity.Property(e => e.MemberSince).HasMaxLength(500);
            entity.Property(e => e.MemberType).HasMaxLength(500);
            entity.Property(e => e.OrderId)
                .HasMaxLength(500)
                .HasColumnName("OrderID");
            entity.Property(e => e.OrderlineId)
                .HasMaxLength(500)
                .HasColumnName("OrderlineID");
            entity.Property(e => e.OrderlineItemIdguid)
                .HasMaxLength(500)
                .HasColumnName("OrderlineItemIDGuid");
            entity.Property(e => e.OrganisationId)
                .HasMaxLength(500)
                .HasColumnName("OrganisationID");
            entity.Property(e => e.Package).HasMaxLength(500);
            entity.Property(e => e.PahaddressLine1)
                .HasMaxLength(500)
                .HasColumnName("PAHAddressLine1");
            entity.Property(e => e.PahaddressLine2)
                .HasMaxLength(500)
                .HasColumnName("PAHAddressLine2");
            entity.Property(e => e.PahclubMembershipId).HasColumnName("PAHClubMembershipID");
            entity.Property(e => e.PahclubNativeId)
                .HasMaxLength(500)
                .HasColumnName("PAHClubNativeID");
            entity.Property(e => e.PahcompanyName)
                .HasMaxLength(500)
                .HasColumnName("PAHCompanyName");
            entity.Property(e => e.Pahcountry)
                .HasMaxLength(500)
                .HasColumnName("PAHCountry");
            entity.Property(e => e.PahcustomerId)
                .HasMaxLength(500)
                .HasColumnName("PAHCustomerID");
            entity.Property(e => e.Pahemail)
                .HasMaxLength(500)
                .HasColumnName("PAHEmail");
            entity.Property(e => e.PahfirstName)
                .HasMaxLength(500)
                .HasColumnName("PAHFirstName");
            entity.Property(e => e.PahlastName)
                .HasMaxLength(500)
                .HasColumnName("PAHLastName");
            entity.Property(e => e.PahpostCode)
                .HasMaxLength(500)
                .HasColumnName("PAHPostCode");
            entity.Property(e => e.PahprimaryPhone)
                .HasMaxLength(500)
                .HasColumnName("PAHPrimaryPhone");
            entity.Property(e => e.Pahsalutation)
                .HasMaxLength(500)
                .HasColumnName("PAHSalutation");
            entity.Property(e => e.Pahstate)
                .HasMaxLength(500)
                .HasColumnName("PAHState");
            entity.Property(e => e.PahsuburbCity)
                .HasMaxLength(500)
                .HasColumnName("PAHSuburb_City");
            entity.Property(e => e.PaxCardNo).HasMaxLength(500);
            entity.Property(e => e.PaymentOption).HasMaxLength(500);
            entity.Property(e => e.PostCode).HasMaxLength(500);
            entity.Property(e => e.PriceType).HasMaxLength(500);
            entity.Property(e => e.PriceTypePrintName).HasMaxLength(500);
            entity.Property(e => e.ProcessMethod)
                .HasMaxLength(500)
                .HasColumnName("Process_Method");
            entity.Property(e => e.Row1).HasMaxLength(500);
            entity.Property(e => e.RunNumber).HasMaxLength(500);
            entity.Property(e => e.Seat1).HasMaxLength(500);
            entity.Property(e => e.SeatingType).HasMaxLength(500);
            entity.Property(e => e.Section1).HasMaxLength(500);
            entity.Property(e => e.State).HasMaxLength(500);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.SuburbCity)
                .HasMaxLength(500)
                .HasColumnName("Suburb_City");
            entity.Property(e => e.Uniqueid).HasMaxLength(500);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Venue1).HasMaxLength(500);
        });

        modelBuilder.Entity<RawData16564202207060950373681>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_RawData_165_36_202207060950373681");

            entity.ToTable("RawData_165_64_202207060950373681");

            entity.HasIndex(e => e.EmpGroupId, "EMP_GroupID");

            entity.HasIndex(e => new { e.EmpUserId, e.UploadId }, "EMP_UserId");

            entity.HasIndex(e => e.UploadId, "UploadId");

            entity.Property(e => e.AcctId).HasColumnName("acct_id");
            entity.Property(e => e.AcctTypeDesc)
                .HasMaxLength(500)
                .HasColumnName("acct_type_desc");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Barcode)
                .HasMaxLength(500)
                .HasColumnName("barcode");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("birthdate");
            entity.Property(e => e.Card)
                .HasMaxLength(500)
                .HasColumnName("card");
            entity.Property(e => e.City)
                .HasMaxLength(500)
                .HasColumnName("city");
            entity.Property(e => e.ClubCode)
                .HasMaxLength(500)
                .HasColumnName("club_code");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(500)
                .HasColumnName("company_name");
            entity.Property(e => e.ConcessionText)
                .HasMaxLength(500)
                .HasColumnName("concession_text");
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .HasColumnName("country");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustNameId).HasColumnName("cust_name_id");
            entity.Property(e => e.DeliveryInstructions)
                .HasMaxLength(500)
                .HasColumnName("delivery_instructions");
            entity.Property(e => e.DeliveryMethodName)
                .HasMaxLength(500)
                .HasColumnName("delivery_method_name");
            entity.Property(e => e.EmailAddr)
                .HasMaxLength(500)
                .HasColumnName("email_addr");
            entity.Property(e => e.EmpAcctId).HasColumnName("EMP_acct_id");
            entity.Property(e => e.EmpAcctStatus).HasColumnName("EMP_AcctStatus");
            entity.Property(e => e.EmpCredit)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("EMP_Credit");
            entity.Property(e => e.EmpDisplayOrder).HasColumnName("EMP_DisplayOrder");
            entity.Property(e => e.EmpErrorCode)
                .HasMaxLength(200)
                .HasColumnName("EMP_ErrorCode");
            entity.Property(e => e.EmpExists)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_EXISTS");
            entity.Property(e => e.EmpGender)
                .HasMaxLength(200)
                .HasColumnName("EMP_Gender");
            entity.Property(e => e.EmpGroupId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupId");
            entity.Property(e => e.EmpGroupNum).HasColumnName("EMP_Group_Num");
            entity.Property(e => e.EmpGroupUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupUserId");
            entity.Property(e => e.EmpIsCardOnly).HasColumnName("EMP_IsCardOnly");
            entity.Property(e => e.EmpIsMain)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_IsMain");
            entity.Property(e => e.EmpLoginAcctStatus).HasColumnName("EMP_LoginAcctStatus");
            entity.Property(e => e.EmpOldMain)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_OldMain");
            entity.Property(e => e.EmpParticipantId).HasColumnName("EMP_ParticipantId");
            entity.Property(e => e.EmpProgramId).HasColumnName("EMP_ProgramId");
            entity.Property(e => e.EmpProgramName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ProgramName");
            entity.Property(e => e.EmpRecordInActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_RecordInActive");
            entity.Property(e => e.EmpRecordType)
                .HasMaxLength(200)
                .HasColumnName("EMP_RecordType");
            entity.Property(e => e.EmpRedeemed).HasColumnName("EMP_Redeemed");
            entity.Property(e => e.EmpSeasonId).HasColumnName("EMP_SeasonID");
            entity.Property(e => e.EmpShopName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ShopName");
            entity.Property(e => e.EmpUniqueKey)
                .HasMaxLength(300)
                .HasColumnName("EMP_UniqueKey");
            entity.Property(e => e.EmpUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_UserId");
            entity.Property(e => e.EmpUserTypeId).HasColumnName("EMP_UserTypeId");
            entity.Property(e => e.EmpUsername)
                .HasMaxLength(200)
                .HasColumnName("EMP_Username");
            entity.Property(e => e.EmpXmlData)
                .HasColumnType("xml")
                .HasColumnName("EMP_XmlData");
            entity.Property(e => e.EventLine1)
                .HasMaxLength(500)
                .HasColumnName("event_line1");
            entity.Property(e => e.EventLine2)
                .HasMaxLength(500)
                .HasColumnName("event_line2");
            entity.Property(e => e.EventLine3)
                .HasMaxLength(500)
                .HasColumnName("event_line3");
            entity.Property(e => e.EventName)
                .HasMaxLength(500)
                .HasColumnName("event_name");
            entity.Property(e => e.FamilyId).HasColumnName("family_id");
            entity.Property(e => e.Fulfilment)
                .HasMaxLength(500)
                .HasColumnName("fulfilment");
            entity.Property(e => e.FulfilmentChoice)
                .HasMaxLength(500)
                .HasColumnName("fulfilment_choice");
            entity.Property(e => e.FulfilmentQty).HasColumnName("fulfilment_qty");
            entity.Property(e => e.Gender)
                .HasMaxLength(500)
                .HasColumnName("gender");
            entity.Property(e => e.GroupCodes)
                .HasMaxLength(500)
                .HasColumnName("group_codes");
            entity.Property(e => e.LocationCity)
                .HasMaxLength(500)
                .HasColumnName("location_city");
            entity.Property(e => e.LocationCountry)
                .HasMaxLength(500)
                .HasColumnName("location_country");
            entity.Property(e => e.LocationState)
                .HasMaxLength(500)
                .HasColumnName("location_state");
            entity.Property(e => e.LocationStreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_1");
            entity.Property(e => e.LocationStreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_2");
            entity.Property(e => e.LocationZip)
                .HasMaxLength(500)
                .HasColumnName("location_zip");
            entity.Property(e => e.MemberId).HasColumnName("member_id");
            entity.Property(e => e.MemberSince).HasColumnName("member_since");
            entity.Property(e => e.MembershipType)
                .HasMaxLength(500)
                .HasColumnName("membership_type");
            entity.Property(e => e.NameFirst)
                .HasMaxLength(500)
                .HasColumnName("name_first");
            entity.Property(e => e.NameLast)
                .HasMaxLength(500)
                .HasColumnName("name_last");
            entity.Property(e => e.Note1)
                .HasMaxLength(500)
                .HasColumnName("note1");
            entity.Property(e => e.NumSeats).HasColumnName("num_seats");
            entity.Property(e => e.OrderLineItem).HasColumnName("order_line_item");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.PaymentPlan)
                .HasMaxLength(500)
                .HasColumnName("payment_plan");
            entity.Property(e => e.PhoneCell)
                .HasMaxLength(500)
                .HasColumnName("phone_cell");
            entity.Property(e => e.PhoneDay)
                .HasMaxLength(500)
                .HasColumnName("phone_day");
            entity.Property(e => e.PhoneEve)
                .HasMaxLength(500)
                .HasColumnName("phone_eve");
            entity.Property(e => e.PriceCode)
                .HasMaxLength(500)
                .HasColumnName("price_code");
            entity.Property(e => e.PriceCodeDesc)
                .HasMaxLength(500)
                .HasColumnName("price_code_desc");
            entity.Property(e => e.PriceCodeExtra)
                .HasMaxLength(500)
                .HasColumnName("price_code_extra");
            entity.Property(e => e.PriceCodeInfo1)
                .HasMaxLength(500)
                .HasColumnName("price_code_info1");
            entity.Property(e => e.PriceCodeInfo2)
                .HasMaxLength(500)
                .HasColumnName("price_code_info2");
            entity.Property(e => e.PriceCodeInfo3)
                .HasMaxLength(500)
                .HasColumnName("price_code_info3");
            entity.Property(e => e.PriceCodeInfo4)
                .HasMaxLength(500)
                .HasColumnName("price_code_info4");
            entity.Property(e => e.PrimaryName)
                .HasMaxLength(500)
                .HasColumnName("primary_name");
            entity.Property(e => e.PrintCount).HasColumnName("print_count");
            entity.Property(e => e.PrintDate)
                .HasColumnType("datetime")
                .HasColumnName("print_date");
            entity.Property(e => e.RowName)
                .HasMaxLength(500)
                .HasColumnName("row_name");
            entity.Property(e => e.SeatNum).HasColumnName("seat_num");
            entity.Property(e => e.SectionName)
                .HasMaxLength(500)
                .HasColumnName("section_name");
            entity.Property(e => e.State)
                .HasMaxLength(500)
                .HasColumnName("state");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("street_addr_1");
            entity.Property(e => e.StreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("street_addr_2");
            entity.Property(e => e.TicketTypeCategory)
                .HasMaxLength(500)
                .HasColumnName("ticket_type_category");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Venue1Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue1_aisle");
            entity.Property(e => e.Venue1Gate)
                .HasMaxLength(500)
                .HasColumnName("venue1_gate");
            entity.Property(e => e.Venue1Row)
                .HasMaxLength(500)
                .HasColumnName("venue1_row");
            entity.Property(e => e.Venue1Seat)
                .HasMaxLength(500)
                .HasColumnName("venue1_seat");
            entity.Property(e => e.Venue1Section)
                .HasMaxLength(500)
                .HasColumnName("venue1_section");
            entity.Property(e => e.Venue1Stand)
                .HasMaxLength(500)
                .HasColumnName("venue1_stand");
            entity.Property(e => e.Venue2Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue2_aisle");
            entity.Property(e => e.Venue2Gate)
                .HasMaxLength(500)
                .HasColumnName("venue2_gate");
            entity.Property(e => e.Venue2Row)
                .HasMaxLength(500)
                .HasColumnName("venue2_row");
            entity.Property(e => e.Venue2Seat)
                .HasMaxLength(500)
                .HasColumnName("venue2_seat");
            entity.Property(e => e.Venue2Section)
                .HasMaxLength(500)
                .HasColumnName("venue2_section");
            entity.Property(e => e.Venue2Stand)
                .HasMaxLength(500)
                .HasColumnName("venue2_stand");
            entity.Property(e => e.YearsMembership).HasColumnName("years_membership");
            entity.Property(e => e.Zip)
                .HasMaxLength(500)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<RawData16667202207061155484034>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_RawData_166_37_202207061155484034");

            entity.ToTable("RawData_166_67_202207061155484034");

            entity.HasIndex(e => e.EmpGroupId, "EMP_GroupID");

            entity.HasIndex(e => new { e.EmpUserId, e.UploadId }, "EMP_UserId");

            entity.HasIndex(e => e.UploadId, "UploadId");

            entity.Property(e => e.AcctId).HasColumnName("acct_id");
            entity.Property(e => e.AcctTypeDesc)
                .HasMaxLength(500)
                .HasColumnName("acct_type_desc");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Barcode)
                .HasMaxLength(500)
                .HasColumnName("barcode");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("birthdate");
            entity.Property(e => e.Card)
                .HasMaxLength(500)
                .HasColumnName("card");
            entity.Property(e => e.City)
                .HasMaxLength(500)
                .HasColumnName("city");
            entity.Property(e => e.ClubCode)
                .HasMaxLength(500)
                .HasColumnName("club_code");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(500)
                .HasColumnName("company_name");
            entity.Property(e => e.ConcessionText)
                .HasMaxLength(500)
                .HasColumnName("concession_text");
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .HasColumnName("country");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustNameId).HasColumnName("cust_name_id");
            entity.Property(e => e.DeliveryInstructions)
                .HasMaxLength(500)
                .HasColumnName("delivery_instructions");
            entity.Property(e => e.DeliveryMethodName)
                .HasMaxLength(500)
                .HasColumnName("delivery_method_name");
            entity.Property(e => e.EmailAddr)
                .HasMaxLength(500)
                .HasColumnName("email_addr");
            entity.Property(e => e.EmpAcctId).HasColumnName("EMP_acct_id");
            entity.Property(e => e.EmpAcctStatus).HasColumnName("EMP_AcctStatus");
            entity.Property(e => e.EmpCredit)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("EMP_Credit");
            entity.Property(e => e.EmpDisplayOrder).HasColumnName("EMP_DisplayOrder");
            entity.Property(e => e.EmpErrorCode)
                .HasMaxLength(200)
                .HasColumnName("EMP_ErrorCode");
            entity.Property(e => e.EmpExists)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_EXISTS");
            entity.Property(e => e.EmpGender)
                .HasMaxLength(200)
                .HasColumnName("EMP_Gender");
            entity.Property(e => e.EmpGroupId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupId");
            entity.Property(e => e.EmpGroupNum).HasColumnName("EMP_Group_Num");
            entity.Property(e => e.EmpGroupUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupUserId");
            entity.Property(e => e.EmpIsCardOnly).HasColumnName("EMP_IsCardOnly");
            entity.Property(e => e.EmpIsMain)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_IsMain");
            entity.Property(e => e.EmpLoginAcctStatus).HasColumnName("EMP_LoginAcctStatus");
            entity.Property(e => e.EmpOldMain)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_OldMain");
            entity.Property(e => e.EmpParticipantId).HasColumnName("EMP_ParticipantId");
            entity.Property(e => e.EmpProgramId).HasColumnName("EMP_ProgramId");
            entity.Property(e => e.EmpProgramName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ProgramName");
            entity.Property(e => e.EmpRecordInActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_RecordInActive");
            entity.Property(e => e.EmpRecordType)
                .HasMaxLength(200)
                .HasColumnName("EMP_RecordType");
            entity.Property(e => e.EmpRedeemed).HasColumnName("EMP_Redeemed");
            entity.Property(e => e.EmpSeasonId).HasColumnName("EMP_SeasonID");
            entity.Property(e => e.EmpShopName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ShopName");
            entity.Property(e => e.EmpUniqueKey)
                .HasMaxLength(300)
                .HasColumnName("EMP_UniqueKey");
            entity.Property(e => e.EmpUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_UserId");
            entity.Property(e => e.EmpUserTypeId).HasColumnName("EMP_UserTypeId");
            entity.Property(e => e.EmpUsername)
                .HasMaxLength(200)
                .HasColumnName("EMP_Username");
            entity.Property(e => e.EmpXmlData)
                .HasColumnType("xml")
                .HasColumnName("EMP_XmlData");
            entity.Property(e => e.EventLine1)
                .HasMaxLength(500)
                .HasColumnName("event_line1");
            entity.Property(e => e.EventLine2)
                .HasMaxLength(500)
                .HasColumnName("event_line2");
            entity.Property(e => e.EventLine3)
                .HasMaxLength(500)
                .HasColumnName("event_line3");
            entity.Property(e => e.EventName)
                .HasMaxLength(500)
                .HasColumnName("event_name");
            entity.Property(e => e.FamilyId).HasColumnName("family_id");
            entity.Property(e => e.Fulfilment)
                .HasMaxLength(500)
                .HasColumnName("fulfilment");
            entity.Property(e => e.FulfilmentChoice)
                .HasMaxLength(500)
                .HasColumnName("fulfilment_choice");
            entity.Property(e => e.FulfilmentQty).HasColumnName("fulfilment_qty");
            entity.Property(e => e.Gender)
                .HasMaxLength(500)
                .HasColumnName("gender");
            entity.Property(e => e.GroupCodes)
                .HasMaxLength(500)
                .HasColumnName("group_codes");
            entity.Property(e => e.LocationCity)
                .HasMaxLength(500)
                .HasColumnName("location_city");
            entity.Property(e => e.LocationCountry)
                .HasMaxLength(500)
                .HasColumnName("location_country");
            entity.Property(e => e.LocationState)
                .HasMaxLength(500)
                .HasColumnName("location_state");
            entity.Property(e => e.LocationStreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_1");
            entity.Property(e => e.LocationStreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_2");
            entity.Property(e => e.LocationZip)
                .HasMaxLength(500)
                .HasColumnName("location_zip");
            entity.Property(e => e.MemberId).HasColumnName("member_id");
            entity.Property(e => e.MemberSince).HasColumnName("member_since");
            entity.Property(e => e.MembershipType)
                .HasMaxLength(500)
                .HasColumnName("membership_type");
            entity.Property(e => e.NameFirst)
                .HasMaxLength(500)
                .HasColumnName("name_first");
            entity.Property(e => e.NameLast)
                .HasMaxLength(500)
                .HasColumnName("name_last");
            entity.Property(e => e.Note1)
                .HasMaxLength(500)
                .HasColumnName("note1");
            entity.Property(e => e.NumSeats).HasColumnName("num_seats");
            entity.Property(e => e.OrderLineItem).HasColumnName("order_line_item");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.PaymentPlan)
                .HasMaxLength(500)
                .HasColumnName("payment_plan");
            entity.Property(e => e.PhoneCell)
                .HasMaxLength(500)
                .HasColumnName("phone_cell");
            entity.Property(e => e.PhoneDay)
                .HasMaxLength(500)
                .HasColumnName("phone_day");
            entity.Property(e => e.PhoneEve)
                .HasMaxLength(500)
                .HasColumnName("phone_eve");
            entity.Property(e => e.PriceCode)
                .HasMaxLength(500)
                .HasColumnName("price_code");
            entity.Property(e => e.PriceCodeDesc)
                .HasMaxLength(500)
                .HasColumnName("price_code_desc");
            entity.Property(e => e.PriceCodeExtra)
                .HasMaxLength(500)
                .HasColumnName("price_code_extra");
            entity.Property(e => e.PriceCodeInfo1)
                .HasMaxLength(500)
                .HasColumnName("price_code_info1");
            entity.Property(e => e.PriceCodeInfo2)
                .HasMaxLength(500)
                .HasColumnName("price_code_info2");
            entity.Property(e => e.PriceCodeInfo3)
                .HasMaxLength(500)
                .HasColumnName("price_code_info3");
            entity.Property(e => e.PriceCodeInfo4)
                .HasMaxLength(500)
                .HasColumnName("price_code_info4");
            entity.Property(e => e.PrimaryName)
                .HasMaxLength(500)
                .HasColumnName("primary_name");
            entity.Property(e => e.PrintCount).HasColumnName("print_count");
            entity.Property(e => e.PrintDate)
                .HasColumnType("datetime")
                .HasColumnName("print_date");
            entity.Property(e => e.RowName)
                .HasMaxLength(500)
                .HasColumnName("row_name");
            entity.Property(e => e.SeatNum).HasColumnName("seat_num");
            entity.Property(e => e.SectionName)
                .HasMaxLength(500)
                .HasColumnName("section_name");
            entity.Property(e => e.State)
                .HasMaxLength(500)
                .HasColumnName("state");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("street_addr_1");
            entity.Property(e => e.StreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("street_addr_2");
            entity.Property(e => e.TicketTypeCategory)
                .HasMaxLength(500)
                .HasColumnName("ticket_type_category");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Venue1Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue1_aisle");
            entity.Property(e => e.Venue1Gate)
                .HasMaxLength(500)
                .HasColumnName("venue1_gate");
            entity.Property(e => e.Venue1Row)
                .HasMaxLength(500)
                .HasColumnName("venue1_row");
            entity.Property(e => e.Venue1Seat)
                .HasMaxLength(500)
                .HasColumnName("venue1_seat");
            entity.Property(e => e.Venue1Section)
                .HasMaxLength(500)
                .HasColumnName("venue1_section");
            entity.Property(e => e.Venue1Stand)
                .HasMaxLength(500)
                .HasColumnName("venue1_stand");
            entity.Property(e => e.Venue2Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue2_aisle");
            entity.Property(e => e.Venue2Gate)
                .HasMaxLength(500)
                .HasColumnName("venue2_gate");
            entity.Property(e => e.Venue2Row)
                .HasMaxLength(500)
                .HasColumnName("venue2_row");
            entity.Property(e => e.Venue2Seat)
                .HasMaxLength(500)
                .HasColumnName("venue2_seat");
            entity.Property(e => e.Venue2Section)
                .HasMaxLength(500)
                .HasColumnName("venue2_section");
            entity.Property(e => e.Venue2Stand)
                .HasMaxLength(500)
                .HasColumnName("venue2_stand");
            entity.Property(e => e.YearsMembership).HasColumnName("years_membership");
            entity.Property(e => e.Zip)
                .HasMaxLength(500)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<RawData16738202207070317147324>(entity =>
        {
            entity.ToTable("RawData_167_38_202207070317147324");

            entity.HasIndex(e => new { e.ClubMembershipId, e.OrderlineItemIdguid }, "ClubMembershipID");

            entity.HasIndex(e => e.EmpGroupId, "EMP_GroupID");

            entity.HasIndex(e => new { e.EmpUserId, e.UploadId }, "EMP_UserId");

            entity.HasIndex(e => e.UploadId, "UploadId");

            entity.Property(e => e.AddressLine1).HasMaxLength(500);
            entity.Property(e => e.AddressLine2).HasMaxLength(500);
            entity.Property(e => e.Aisle1).HasMaxLength(500);
            entity.Property(e => e.Aisle2).HasMaxLength(500);
            entity.Property(e => e.Aisle3).HasMaxLength(500);
            entity.Property(e => e.Barcode).HasMaxLength(500);
            entity.Property(e => e.CardFirstName).HasMaxLength(500);
            entity.Property(e => e.CardLastName).HasMaxLength(500);
            entity.Property(e => e.CardStatus).HasMaxLength(500);
            entity.Property(e => e.Category).HasMaxLength(500);
            entity.Property(e => e.ClubMembershipId).HasColumnName("ClubMembershipID");
            entity.Property(e => e.ClubNativeId)
                .HasMaxLength(500)
                .HasColumnName("ClubNativeID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName).HasMaxLength(500);
            entity.Property(e => e.Country).HasMaxLength(500);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.DateOfBirth).HasColumnType("date");
            entity.Property(e => e.DeliveryType).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(500);
            entity.Property(e => e.EmpAcctStatus).HasColumnName("EMP_AcctStatus");
            entity.Property(e => e.EmpCredit)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("EMP_Credit");
            entity.Property(e => e.EmpDisplayOrder).HasColumnName("EMP_DisplayOrder");
            entity.Property(e => e.EmpErrorCode)
                .HasMaxLength(200)
                .HasColumnName("EMP_ErrorCode");
            entity.Property(e => e.EmpGender)
                .HasMaxLength(200)
                .HasColumnName("EMP_Gender");
            entity.Property(e => e.EmpGroupId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupId");
            entity.Property(e => e.EmpGroupUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupUserId");
            entity.Property(e => e.EmpIsCardOnly).HasColumnName("EMP_IsCardOnly");
            entity.Property(e => e.EmpIsMain)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_IsMain");
            entity.Property(e => e.EmpLoginAcctStatus).HasColumnName("EMP_LoginAcctStatus");
            entity.Property(e => e.EmpParticipantId).HasColumnName("EMP_ParticipantId");
            entity.Property(e => e.EmpProgramId).HasColumnName("EMP_ProgramId");
            entity.Property(e => e.EmpProgramName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ProgramName");
            entity.Property(e => e.EmpRecordInActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_RecordInActive");
            entity.Property(e => e.EmpRecordType)
                .HasMaxLength(200)
                .HasColumnName("EMP_RecordType");
            entity.Property(e => e.EmpRedeemed).HasColumnName("EMP_Redeemed");
            entity.Property(e => e.EmpSeasonId).HasColumnName("EMP_SeasonID");
            entity.Property(e => e.EmpShopName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ShopName");
            entity.Property(e => e.EmpUniqueKey)
                .HasMaxLength(300)
                .HasColumnName("EMP_UniqueKey");
            entity.Property(e => e.EmpUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_UserId");
            entity.Property(e => e.EmpUserTypeId).HasColumnName("EMP_UserTypeId");
            entity.Property(e => e.EmpUsername)
                .HasMaxLength(200)
                .HasColumnName("EMP_Username");
            entity.Property(e => e.EmpXmlData)
                .HasColumnType("xml")
                .HasColumnName("EMP_XmlData");
            entity.Property(e => e.Gate1).HasMaxLength(500);
            entity.Property(e => e.Gate2).HasMaxLength(500);
            entity.Property(e => e.Gate3).HasMaxLength(500);
            entity.Property(e => e.MemberExpiry).HasColumnType("date");
            entity.Property(e => e.MemberSince).HasMaxLength(500);
            entity.Property(e => e.MemberType).HasMaxLength(500);
            entity.Property(e => e.OrderId)
                .HasMaxLength(500)
                .HasColumnName("OrderID");
            entity.Property(e => e.OrderlineId)
                .HasMaxLength(500)
                .HasColumnName("OrderlineID");
            entity.Property(e => e.OrderlineItemIdguid)
                .HasMaxLength(500)
                .HasColumnName("OrderlineItemIDGuid");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.Package).HasMaxLength(500);
            entity.Property(e => e.PahaddressLine1)
                .HasMaxLength(500)
                .HasColumnName("PAHAddressLine1");
            entity.Property(e => e.PahaddressLine2)
                .HasMaxLength(500)
                .HasColumnName("PAHAddressLine2");
            entity.Property(e => e.PahclubMembershipId).HasColumnName("PAHClubMembershipID");
            entity.Property(e => e.PahclubNativeId)
                .HasMaxLength(500)
                .HasColumnName("PAHClubNativeID");
            entity.Property(e => e.PahcompanyName)
                .HasMaxLength(500)
                .HasColumnName("PAHCompanyName");
            entity.Property(e => e.Pahcountry)
                .HasMaxLength(500)
                .HasColumnName("PAHCountry");
            entity.Property(e => e.PahcustomerId).HasColumnName("PAHCustomerID");
            entity.Property(e => e.Pahemail)
                .HasMaxLength(500)
                .HasColumnName("PAHEmail");
            entity.Property(e => e.PahfirstName)
                .HasMaxLength(500)
                .HasColumnName("PAHFirstName");
            entity.Property(e => e.PahlastName)
                .HasMaxLength(500)
                .HasColumnName("PAHLastName");
            entity.Property(e => e.PahpostCode)
                .HasMaxLength(500)
                .HasColumnName("PAHPostCode");
            entity.Property(e => e.PahprimaryPhone)
                .HasMaxLength(500)
                .HasColumnName("PAHPrimaryPhone");
            entity.Property(e => e.Pahsalutation)
                .HasMaxLength(500)
                .HasColumnName("PAHSalutation");
            entity.Property(e => e.Pahstate)
                .HasMaxLength(500)
                .HasColumnName("PAHState");
            entity.Property(e => e.Pahsuburb)
                .HasMaxLength(500)
                .HasColumnName("PAHSuburb");
            entity.Property(e => e.PaxCardNo).HasMaxLength(500);
            entity.Property(e => e.PaymentOption).HasMaxLength(500);
            entity.Property(e => e.PostCode).HasMaxLength(500);
            entity.Property(e => e.PriceType).HasMaxLength(500);
            entity.Property(e => e.PriceTypePrintName).HasMaxLength(500);
            entity.Property(e => e.ProcessMethod).HasMaxLength(500);
            entity.Property(e => e.Row1).HasMaxLength(500);
            entity.Property(e => e.Row2).HasMaxLength(500);
            entity.Property(e => e.Row3).HasMaxLength(500);
            entity.Property(e => e.RunNumber).HasMaxLength(500);
            entity.Property(e => e.Seat1).HasMaxLength(500);
            entity.Property(e => e.Seat2).HasMaxLength(500);
            entity.Property(e => e.Seat3).HasMaxLength(500);
            entity.Property(e => e.SeatingType).HasMaxLength(500);
            entity.Property(e => e.Section1).HasMaxLength(500);
            entity.Property(e => e.Section2).HasMaxLength(500);
            entity.Property(e => e.Section3).HasMaxLength(500);
            entity.Property(e => e.State).HasMaxLength(500);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.Suburb).HasMaxLength(500);
            entity.Property(e => e.Uniqueid).HasMaxLength(500);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Venue1).HasMaxLength(500);
            entity.Property(e => e.Venue2).HasMaxLength(500);
            entity.Property(e => e.Venue3).HasMaxLength(500);
        });

        modelBuilder.Entity<RawData16839202207120931356534>(entity =>
        {
            entity.ToTable("RawData_168_39_202207120931356534");

            entity.HasIndex(e => e.EmpGroupId, "EMP_GroupID");

            entity.HasIndex(e => new { e.EmpUserId, e.UploadId }, "EMP_UserId");

            entity.HasIndex(e => e.UploadId, "UploadId");

            entity.Property(e => e.AcctId).HasColumnName("acct_id");
            entity.Property(e => e.AcctTypeDesc)
                .HasMaxLength(500)
                .HasColumnName("acct_type_desc");
            entity.Property(e => e.Barcode)
                .HasMaxLength(500)
                .HasColumnName("barcode");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("birthdate");
            entity.Property(e => e.Card)
                .HasMaxLength(500)
                .HasColumnName("card");
            entity.Property(e => e.City)
                .HasMaxLength(500)
                .HasColumnName("city");
            entity.Property(e => e.ClubCode)
                .HasMaxLength(500)
                .HasColumnName("club_code");
            entity.Property(e => e.CompName)
                .HasMaxLength(500)
                .HasColumnName("comp_name");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(500)
                .HasColumnName("company_name");
            entity.Property(e => e.ConcessionText)
                .HasMaxLength(500)
                .HasColumnName("concession_text");
            entity.Property(e => e.ConsecutiveSince).HasColumnName("consecutive_since");
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .HasColumnName("country");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustNameId).HasColumnName("cust_name_id");
            entity.Property(e => e.DeliveryInstructions)
                .HasMaxLength(500)
                .HasColumnName("delivery_instructions");
            entity.Property(e => e.DeliveryMethodName)
                .HasMaxLength(500)
                .HasColumnName("delivery_method_name");
            entity.Property(e => e.DiscName)
                .HasMaxLength(500)
                .HasColumnName("disc_name");
            entity.Property(e => e.EmailAddr)
                .HasMaxLength(500)
                .HasColumnName("email_addr");
            entity.Property(e => e.EmpAcctStatus).HasColumnName("EMP_AcctStatus");
            entity.Property(e => e.EmpCredit)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("EMP_Credit");
            entity.Property(e => e.EmpDisplayOrder).HasColumnName("EMP_DisplayOrder");
            entity.Property(e => e.EmpErrorCode)
                .HasMaxLength(200)
                .HasColumnName("EMP_ErrorCode");
            entity.Property(e => e.EmpFamilyId).HasColumnName("EMP_FamilyID");
            entity.Property(e => e.EmpGender)
                .HasMaxLength(200)
                .HasColumnName("EMP_Gender");
            entity.Property(e => e.EmpGroupId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupId");
            entity.Property(e => e.EmpGroupUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupUserId");
            entity.Property(e => e.EmpIsCardOnly).HasColumnName("EMP_IsCardOnly");
            entity.Property(e => e.EmpIsMain)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_IsMain");
            entity.Property(e => e.EmpLoginAcctStatus).HasColumnName("EMP_LoginAcctStatus");
            entity.Property(e => e.EmpParticipantId).HasColumnName("EMP_ParticipantId");
            entity.Property(e => e.EmpProgramId).HasColumnName("EMP_ProgramId");
            entity.Property(e => e.EmpProgramName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ProgramName");
            entity.Property(e => e.EmpRecordInActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_RecordInActive");
            entity.Property(e => e.EmpRecordType)
                .HasMaxLength(200)
                .HasColumnName("EMP_RecordType");
            entity.Property(e => e.EmpRedeemed).HasColumnName("EMP_Redeemed");
            entity.Property(e => e.EmpSeasonId).HasColumnName("EMP_SeasonID");
            entity.Property(e => e.EmpShopName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ShopName");
            entity.Property(e => e.EmpUniqueKey)
                .HasMaxLength(300)
                .HasColumnName("EMP_UniqueKey");
            entity.Property(e => e.EmpUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_UserId");
            entity.Property(e => e.EmpUserTypeId).HasColumnName("EMP_UserTypeId");
            entity.Property(e => e.EmpUsername)
                .HasMaxLength(200)
                .HasColumnName("EMP_Username");
            entity.Property(e => e.EmpXmlData)
                .HasColumnType("xml")
                .HasColumnName("EMP_XmlData");
            entity.Property(e => e.EventLine1)
                .HasMaxLength(500)
                .HasColumnName("event_line1");
            entity.Property(e => e.EventLine2)
                .HasMaxLength(500)
                .HasColumnName("event_line2");
            entity.Property(e => e.EventLine3)
                .HasMaxLength(500)
                .HasColumnName("event_line3");
            entity.Property(e => e.EventName)
                .HasMaxLength(500)
                .HasColumnName("event_name");
            entity.Property(e => e.FamilyId).HasColumnName("family_id");
            entity.Property(e => e.Fulfilment)
                .HasMaxLength(500)
                .HasColumnName("fulfilment");
            entity.Property(e => e.FullName1)
                .HasMaxLength(500)
                .HasColumnName("full_name_1");
            entity.Property(e => e.Gate)
                .HasMaxLength(500)
                .HasColumnName("gate");
            entity.Property(e => e.Gender)
                .HasMaxLength(500)
                .HasColumnName("gender");
            entity.Property(e => e.GroupCodes)
                .HasMaxLength(500)
                .HasColumnName("group_codes");
            entity.Property(e => e.LocationCity)
                .HasMaxLength(500)
                .HasColumnName("location_city");
            entity.Property(e => e.LocationCountry)
                .HasMaxLength(500)
                .HasColumnName("location_country");
            entity.Property(e => e.LocationState)
                .HasMaxLength(500)
                .HasColumnName("location_state");
            entity.Property(e => e.LocationStreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_1");
            entity.Property(e => e.LocationStreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_2");
            entity.Property(e => e.LocationZip)
                .HasMaxLength(500)
                .HasColumnName("location_zip");
            entity.Property(e => e.MemberSince).HasColumnName("member_since");
            entity.Property(e => e.MembershipType)
                .HasMaxLength(500)
                .HasColumnName("membership_type");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
            entity.Property(e => e.NameFirst)
                .HasMaxLength(500)
                .HasColumnName("name_first");
            entity.Property(e => e.Note1)
                .HasMaxLength(500)
                .HasColumnName("note1");
            entity.Property(e => e.Note2)
                .HasMaxLength(500)
                .HasColumnName("note2");
            entity.Property(e => e.NumSeats).HasColumnName("num_seats");
            entity.Property(e => e.OrderLineItem).HasColumnName("order_line_item");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.OtherInfo6)
                .HasMaxLength(500)
                .HasColumnName("other_info_6");
            entity.Property(e => e.OtherInfo7)
                .HasMaxLength(500)
                .HasColumnName("other_info_7");
            entity.Property(e => e.OtherInfo9)
                .HasMaxLength(500)
                .HasColumnName("other_info_9");
            entity.Property(e => e.PhoneCell)
                .HasMaxLength(500)
                .HasColumnName("phone_cell");
            entity.Property(e => e.PhoneDay)
                .HasMaxLength(500)
                .HasColumnName("phone_day");
            entity.Property(e => e.PhoneEve)
                .HasMaxLength(500)
                .HasColumnName("phone_eve");
            entity.Property(e => e.PinMasked)
                .HasMaxLength(500)
                .HasColumnName("pin_masked");
            entity.Property(e => e.Portal)
                .HasMaxLength(500)
                .HasColumnName("portal");
            entity.Property(e => e.PriceCode)
                .HasMaxLength(500)
                .HasColumnName("price_code");
            entity.Property(e => e.PriceCodeDesc)
                .HasMaxLength(500)
                .HasColumnName("price_code_desc");
            entity.Property(e => e.PrintCount).HasColumnName("print_count");
            entity.Property(e => e.PrintDate)
                .HasColumnType("datetime")
                .HasColumnName("print_date");
            entity.Property(e => e.RowName)
                .HasMaxLength(500)
                .HasColumnName("row_name");
            entity.Property(e => e.SeatLabel1)
                .HasMaxLength(500)
                .HasColumnName("seat_label1");
            entity.Property(e => e.SeatLabel2)
                .HasMaxLength(500)
                .HasColumnName("seat_label2");
            entity.Property(e => e.SeatLabel3)
                .HasMaxLength(500)
                .HasColumnName("seat_label3");
            entity.Property(e => e.SeatLabel4)
                .HasMaxLength(500)
                .HasColumnName("seat_label4");
            entity.Property(e => e.SeatLocation1)
                .HasMaxLength(500)
                .HasColumnName("seat_location1");
            entity.Property(e => e.SeatLocation2)
                .HasMaxLength(500)
                .HasColumnName("seat_location2");
            entity.Property(e => e.SeatLocation3)
                .HasMaxLength(500)
                .HasColumnName("seat_location3");
            entity.Property(e => e.SeatLocation4)
                .HasMaxLength(500)
                .HasColumnName("seat_location4");
            entity.Property(e => e.SeatNum).HasColumnName("seat_num");
            entity.Property(e => e.SectionName)
                .HasMaxLength(500)
                .HasColumnName("section_name");
            entity.Property(e => e.State)
                .HasMaxLength(500)
                .HasColumnName("state");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("street_addr_1");
            entity.Property(e => e.StreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("street_addr_2");
            entity.Property(e => e.SurchgName)
                .HasMaxLength(500)
                .HasColumnName("surchg_name");
            entity.Property(e => e.TicketTypeCategory)
                .HasMaxLength(500)
                .HasColumnName("ticket_type_category");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.YearsConsecutive).HasColumnName("years_consecutive");
            entity.Property(e => e.YearsMembership).HasColumnName("years_membership");
            entity.Property(e => e.YearsUpdated)
                .HasMaxLength(500)
                .HasColumnName("years_updated");
            entity.Property(e => e.Zip)
                .HasMaxLength(500)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<RawData17142202207201140586460>(entity =>
        {
            entity.ToTable("RawData_171_42_202207201140586460");

            entity.HasIndex(e => e.EmpGroupId, "EMP_GroupID");

            entity.HasIndex(e => new { e.EmpUserId, e.UploadId }, "EMP_UserId");

            entity.HasIndex(e => e.UploadId, "UploadId");

            entity.Property(e => e.AcctId).HasColumnName("acct_id");
            entity.Property(e => e.AcctTypeDesc)
                .HasMaxLength(500)
                .HasColumnName("acct_type_desc");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Barcode)
                .HasMaxLength(500)
                .HasColumnName("barcode");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("birthdate");
            entity.Property(e => e.Card)
                .HasMaxLength(500)
                .HasColumnName("card");
            entity.Property(e => e.City)
                .HasMaxLength(500)
                .HasColumnName("city");
            entity.Property(e => e.ClubCode)
                .HasMaxLength(500)
                .HasColumnName("club_code");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(500)
                .HasColumnName("company_name");
            entity.Property(e => e.ConcessionText)
                .HasMaxLength(500)
                .HasColumnName("concession_text");
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .HasColumnName("country");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustNameId).HasColumnName("cust_name_id");
            entity.Property(e => e.DeliveryInstructions)
                .HasMaxLength(500)
                .HasColumnName("delivery_instructions");
            entity.Property(e => e.DeliveryMethodName)
                .HasMaxLength(500)
                .HasColumnName("delivery_method_name");
            entity.Property(e => e.EmailAddr)
                .HasMaxLength(500)
                .HasColumnName("email_addr");
            entity.Property(e => e.EmpAcctStatus).HasColumnName("EMP_AcctStatus");
            entity.Property(e => e.EmpCredit)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("EMP_Credit");
            entity.Property(e => e.EmpDisplayOrder).HasColumnName("EMP_DisplayOrder");
            entity.Property(e => e.EmpErrorCode)
                .HasMaxLength(200)
                .HasColumnName("EMP_ErrorCode");
            entity.Property(e => e.EmpGender)
                .HasMaxLength(200)
                .HasColumnName("EMP_Gender");
            entity.Property(e => e.EmpGroupId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupId");
            entity.Property(e => e.EmpGroupUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupUserId");
            entity.Property(e => e.EmpIsCardOnly).HasColumnName("EMP_IsCardOnly");
            entity.Property(e => e.EmpIsMain)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_IsMain");
            entity.Property(e => e.EmpLoginAcctStatus).HasColumnName("EMP_LoginAcctStatus");
            entity.Property(e => e.EmpParticipantId).HasColumnName("EMP_ParticipantId");
            entity.Property(e => e.EmpProgramId).HasColumnName("EMP_ProgramId");
            entity.Property(e => e.EmpProgramName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ProgramName");
            entity.Property(e => e.EmpRecordInActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_RecordInActive");
            entity.Property(e => e.EmpRecordType)
                .HasMaxLength(200)
                .HasColumnName("EMP_RecordType");
            entity.Property(e => e.EmpRedeemed).HasColumnName("EMP_Redeemed");
            entity.Property(e => e.EmpSeasonId).HasColumnName("EMP_SeasonID");
            entity.Property(e => e.EmpShopName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ShopName");
            entity.Property(e => e.EmpUniqueKey)
                .HasMaxLength(300)
                .HasColumnName("EMP_UniqueKey");
            entity.Property(e => e.EmpUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_UserId");
            entity.Property(e => e.EmpUserTypeId).HasColumnName("EMP_UserTypeId");
            entity.Property(e => e.EmpUsername)
                .HasMaxLength(200)
                .HasColumnName("EMP_Username");
            entity.Property(e => e.EmpXmlData)
                .HasColumnType("xml")
                .HasColumnName("EMP_XmlData");
            entity.Property(e => e.EventLine1)
                .HasMaxLength(500)
                .HasColumnName("event_line1");
            entity.Property(e => e.EventLine2)
                .HasMaxLength(500)
                .HasColumnName("event_line2");
            entity.Property(e => e.EventLine3)
                .HasMaxLength(500)
                .HasColumnName("event_line3");
            entity.Property(e => e.EventName)
                .HasMaxLength(500)
                .HasColumnName("event_name");
            entity.Property(e => e.FamilyId).HasColumnName("family_id");
            entity.Property(e => e.Fulfilment)
                .HasMaxLength(500)
                .HasColumnName("fulfilment");
            entity.Property(e => e.Gender)
                .HasMaxLength(500)
                .HasColumnName("gender");
            entity.Property(e => e.GroupCodes)
                .HasMaxLength(500)
                .HasColumnName("group_codes");
            entity.Property(e => e.LocationCity)
                .HasMaxLength(500)
                .HasColumnName("location_city");
            entity.Property(e => e.LocationCountry)
                .HasMaxLength(500)
                .HasColumnName("location_country");
            entity.Property(e => e.LocationState)
                .HasMaxLength(500)
                .HasColumnName("location_state");
            entity.Property(e => e.LocationStreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_1");
            entity.Property(e => e.LocationStreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_2");
            entity.Property(e => e.LocationZip)
                .HasMaxLength(500)
                .HasColumnName("location_zip");
            entity.Property(e => e.MemberId).HasColumnName("member_id");
            entity.Property(e => e.MemberSince).HasColumnName("member_since");
            entity.Property(e => e.MembershipType)
                .HasMaxLength(500)
                .HasColumnName("membership_type");
            entity.Property(e => e.NameFirst)
                .HasMaxLength(500)
                .HasColumnName("name_first");
            entity.Property(e => e.NameLast)
                .HasMaxLength(500)
                .HasColumnName("name_last");
            entity.Property(e => e.Note1)
                .HasMaxLength(500)
                .HasColumnName("note1");
            entity.Property(e => e.NumSeats).HasColumnName("num_seats");
            entity.Property(e => e.OrderLineItem).HasColumnName("order_line_item");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.PaymentPlan)
                .HasMaxLength(500)
                .HasColumnName("payment_plan");
            entity.Property(e => e.PhoneCell)
                .HasMaxLength(500)
                .HasColumnName("phone_cell");
            entity.Property(e => e.PhoneDay)
                .HasMaxLength(500)
                .HasColumnName("phone_day");
            entity.Property(e => e.PhoneEve)
                .HasMaxLength(500)
                .HasColumnName("phone_eve");
            entity.Property(e => e.PriceCode)
                .HasMaxLength(500)
                .HasColumnName("price_code");
            entity.Property(e => e.PriceCodeDesc)
                .HasMaxLength(500)
                .HasColumnName("price_code_desc");
            entity.Property(e => e.PriceCodeExtra)
                .HasMaxLength(500)
                .HasColumnName("price_code_extra");
            entity.Property(e => e.PriceCodeInfo1)
                .HasMaxLength(500)
                .HasColumnName("price_code_info1");
            entity.Property(e => e.PriceCodeInfo2)
                .HasMaxLength(500)
                .HasColumnName("price_code_info2");
            entity.Property(e => e.PriceCodeInfo3)
                .HasMaxLength(500)
                .HasColumnName("price_code_info3");
            entity.Property(e => e.PriceCodeInfo4)
                .HasMaxLength(500)
                .HasColumnName("price_code_info4");
            entity.Property(e => e.PrimaryName)
                .HasMaxLength(500)
                .HasColumnName("primary_name");
            entity.Property(e => e.PrintCount).HasColumnName("print_count");
            entity.Property(e => e.PrintDate)
                .HasColumnType("datetime")
                .HasColumnName("print_date");
            entity.Property(e => e.RowName)
                .HasMaxLength(500)
                .HasColumnName("row_name");
            entity.Property(e => e.SeatNum).HasColumnName("seat_num");
            entity.Property(e => e.SectionName)
                .HasMaxLength(500)
                .HasColumnName("section_name");
            entity.Property(e => e.State)
                .HasMaxLength(500)
                .HasColumnName("state");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("street_addr_1");
            entity.Property(e => e.StreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("street_addr_2");
            entity.Property(e => e.TicketTypeCategory)
                .HasMaxLength(500)
                .HasColumnName("ticket_type_category");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Venue1Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue1_aisle");
            entity.Property(e => e.Venue1Gate)
                .HasMaxLength(500)
                .HasColumnName("venue1_gate");
            entity.Property(e => e.Venue1Row)
                .HasMaxLength(500)
                .HasColumnName("venue1_row");
            entity.Property(e => e.Venue1Seat)
                .HasMaxLength(500)
                .HasColumnName("venue1_seat");
            entity.Property(e => e.Venue1Section)
                .HasMaxLength(500)
                .HasColumnName("venue1_section");
            entity.Property(e => e.Venue1Stand)
                .HasMaxLength(500)
                .HasColumnName("venue1_stand");
            entity.Property(e => e.Venue2Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue2_aisle");
            entity.Property(e => e.Venue2Gate)
                .HasMaxLength(500)
                .HasColumnName("venue2_gate");
            entity.Property(e => e.Venue2Row)
                .HasMaxLength(500)
                .HasColumnName("venue2_row");
            entity.Property(e => e.Venue2Seat)
                .HasMaxLength(500)
                .HasColumnName("venue2_seat");
            entity.Property(e => e.Venue2Section)
                .HasMaxLength(500)
                .HasColumnName("venue2_section");
            entity.Property(e => e.Venue2Stand)
                .HasMaxLength(500)
                .HasColumnName("venue2_stand");
            entity.Property(e => e.YearsMembership).HasColumnName("years_membership");
            entity.Property(e => e.Zip)
                .HasMaxLength(500)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<RawData17344202208030931028833>(entity =>
        {
            entity.ToTable("RawData_173_44_202208030931028833");

            entity.HasIndex(e => e.EmpGroupId, "EMP_GroupID");

            entity.HasIndex(e => new { e.EmpUserId, e.UploadId }, "EMP_UserId");

            entity.HasIndex(e => e.UploadId, "UploadId");

            entity.Property(e => e.AcctId).HasColumnName("acct_id");
            entity.Property(e => e.AcctTypeDesc)
                .HasMaxLength(500)
                .HasColumnName("acct_type_desc");
            entity.Property(e => e.Barcode)
                .HasMaxLength(500)
                .HasColumnName("barcode");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("birthdate");
            entity.Property(e => e.Card)
                .HasMaxLength(500)
                .HasColumnName("card");
            entity.Property(e => e.City)
                .HasMaxLength(500)
                .HasColumnName("city");
            entity.Property(e => e.ClubCode)
                .HasMaxLength(500)
                .HasColumnName("club_code");
            entity.Property(e => e.CompName)
                .HasMaxLength(500)
                .HasColumnName("comp_name");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(500)
                .HasColumnName("company_name");
            entity.Property(e => e.ConcessionText)
                .HasMaxLength(500)
                .HasColumnName("concession_text");
            entity.Property(e => e.ConsecutiveSince).HasColumnName("consecutive_since");
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .HasColumnName("country");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustNameId).HasColumnName("cust_name_id");
            entity.Property(e => e.DeliveryInstructions)
                .HasMaxLength(500)
                .HasColumnName("delivery_instructions");
            entity.Property(e => e.DeliveryMethodName)
                .HasMaxLength(500)
                .HasColumnName("delivery_method_name");
            entity.Property(e => e.DiscName)
                .HasMaxLength(500)
                .HasColumnName("disc_name");
            entity.Property(e => e.EmailAddr)
                .HasMaxLength(500)
                .HasColumnName("email_addr");
            entity.Property(e => e.EmpAcctStatus).HasColumnName("EMP_AcctStatus");
            entity.Property(e => e.EmpCredit)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("EMP_Credit");
            entity.Property(e => e.EmpDisplayOrder).HasColumnName("EMP_DisplayOrder");
            entity.Property(e => e.EmpErrorCode)
                .HasMaxLength(200)
                .HasColumnName("EMP_ErrorCode");
            entity.Property(e => e.EmpFamilyId).HasColumnName("EMP_FamilyID");
            entity.Property(e => e.EmpGender)
                .HasMaxLength(200)
                .HasColumnName("EMP_Gender");
            entity.Property(e => e.EmpGroupId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupId");
            entity.Property(e => e.EmpGroupUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupUserId");
            entity.Property(e => e.EmpIsCardOnly).HasColumnName("EMP_IsCardOnly");
            entity.Property(e => e.EmpIsMain)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_IsMain");
            entity.Property(e => e.EmpLoginAcctStatus).HasColumnName("EMP_LoginAcctStatus");
            entity.Property(e => e.EmpParticipantId).HasColumnName("EMP_ParticipantId");
            entity.Property(e => e.EmpProgramId).HasColumnName("EMP_ProgramId");
            entity.Property(e => e.EmpProgramName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ProgramName");
            entity.Property(e => e.EmpRecordInActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_RecordInActive");
            entity.Property(e => e.EmpRecordType)
                .HasMaxLength(200)
                .HasColumnName("EMP_RecordType");
            entity.Property(e => e.EmpRedeemed).HasColumnName("EMP_Redeemed");
            entity.Property(e => e.EmpSeasonId).HasColumnName("EMP_SeasonID");
            entity.Property(e => e.EmpShopName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ShopName");
            entity.Property(e => e.EmpUniqueKey)
                .HasMaxLength(300)
                .HasColumnName("EMP_UniqueKey");
            entity.Property(e => e.EmpUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_UserId");
            entity.Property(e => e.EmpUserTypeId).HasColumnName("EMP_UserTypeId");
            entity.Property(e => e.EmpUsername)
                .HasMaxLength(200)
                .HasColumnName("EMP_Username");
            entity.Property(e => e.EmpXmlData)
                .HasColumnType("xml")
                .HasColumnName("EMP_XmlData");
            entity.Property(e => e.EventLine1)
                .HasMaxLength(500)
                .HasColumnName("event_line1");
            entity.Property(e => e.EventLine2)
                .HasMaxLength(500)
                .HasColumnName("event_line2");
            entity.Property(e => e.EventLine3)
                .HasMaxLength(500)
                .HasColumnName("event_line3");
            entity.Property(e => e.EventName)
                .HasMaxLength(500)
                .HasColumnName("event_name");
            entity.Property(e => e.FamilyId).HasColumnName("family_id");
            entity.Property(e => e.Fulfilment)
                .HasMaxLength(500)
                .HasColumnName("fulfilment");
            entity.Property(e => e.FullName1)
                .HasMaxLength(500)
                .HasColumnName("full_name_1");
            entity.Property(e => e.Gate)
                .HasMaxLength(500)
                .HasColumnName("gate");
            entity.Property(e => e.Gender)
                .HasMaxLength(500)
                .HasColumnName("gender");
            entity.Property(e => e.GroupCodes)
                .HasMaxLength(500)
                .HasColumnName("group_codes");
            entity.Property(e => e.LocationCity)
                .HasMaxLength(500)
                .HasColumnName("location_city");
            entity.Property(e => e.LocationCountry)
                .HasMaxLength(500)
                .HasColumnName("location_country");
            entity.Property(e => e.LocationState)
                .HasMaxLength(500)
                .HasColumnName("location_state");
            entity.Property(e => e.LocationStreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_1");
            entity.Property(e => e.LocationStreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_2");
            entity.Property(e => e.LocationZip)
                .HasMaxLength(500)
                .HasColumnName("location_zip");
            entity.Property(e => e.MemberSince).HasColumnName("member_since");
            entity.Property(e => e.MembershipType)
                .HasMaxLength(500)
                .HasColumnName("membership_type");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
            entity.Property(e => e.NameFirst)
                .HasMaxLength(500)
                .HasColumnName("name_first");
            entity.Property(e => e.Note1)
                .HasMaxLength(500)
                .HasColumnName("note1");
            entity.Property(e => e.Note2)
                .HasMaxLength(500)
                .HasColumnName("note2");
            entity.Property(e => e.NumSeats).HasColumnName("num_seats");
            entity.Property(e => e.OrderLineItem).HasColumnName("order_line_item");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.OtherInfo6)
                .HasMaxLength(500)
                .HasColumnName("other_info_6");
            entity.Property(e => e.OtherInfo7)
                .HasMaxLength(500)
                .HasColumnName("other_info_7");
            entity.Property(e => e.OtherInfo9)
                .HasMaxLength(500)
                .HasColumnName("other_info_9");
            entity.Property(e => e.PhoneCell)
                .HasMaxLength(500)
                .HasColumnName("phone_cell");
            entity.Property(e => e.PhoneDay)
                .HasMaxLength(500)
                .HasColumnName("phone_day");
            entity.Property(e => e.PhoneEve)
                .HasMaxLength(500)
                .HasColumnName("phone_eve");
            entity.Property(e => e.PinMasked)
                .HasMaxLength(500)
                .HasColumnName("pin_masked");
            entity.Property(e => e.Portal)
                .HasMaxLength(500)
                .HasColumnName("portal");
            entity.Property(e => e.PriceCode)
                .HasMaxLength(500)
                .HasColumnName("price_code");
            entity.Property(e => e.PriceCodeDesc)
                .HasMaxLength(500)
                .HasColumnName("price_code_desc");
            entity.Property(e => e.PrintCount).HasColumnName("print_count");
            entity.Property(e => e.PrintDate)
                .HasColumnType("datetime")
                .HasColumnName("print_date");
            entity.Property(e => e.RowName)
                .HasMaxLength(500)
                .HasColumnName("row_name");
            entity.Property(e => e.SeatLabel1)
                .HasMaxLength(500)
                .HasColumnName("seat_label1");
            entity.Property(e => e.SeatLabel2)
                .HasMaxLength(500)
                .HasColumnName("seat_label2");
            entity.Property(e => e.SeatLabel3)
                .HasMaxLength(500)
                .HasColumnName("seat_label3");
            entity.Property(e => e.SeatLabel4)
                .HasMaxLength(500)
                .HasColumnName("seat_label4");
            entity.Property(e => e.SeatLocation1)
                .HasMaxLength(500)
                .HasColumnName("seat_location1");
            entity.Property(e => e.SeatLocation2)
                .HasMaxLength(500)
                .HasColumnName("seat_location2");
            entity.Property(e => e.SeatLocation3)
                .HasMaxLength(500)
                .HasColumnName("seat_location3");
            entity.Property(e => e.SeatLocation4)
                .HasMaxLength(500)
                .HasColumnName("seat_location4");
            entity.Property(e => e.SeatNum).HasColumnName("seat_num");
            entity.Property(e => e.SectionName)
                .HasMaxLength(500)
                .HasColumnName("section_name");
            entity.Property(e => e.State)
                .HasMaxLength(500)
                .HasColumnName("state");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("street_addr_1");
            entity.Property(e => e.StreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("street_addr_2");
            entity.Property(e => e.SurchgName)
                .HasMaxLength(500)
                .HasColumnName("surchg_name");
            entity.Property(e => e.TicketTypeCategory)
                .HasMaxLength(500)
                .HasColumnName("ticket_type_category");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.YearsConsecutive).HasColumnName("years_consecutive");
            entity.Property(e => e.YearsMembership).HasColumnName("years_membership");
            entity.Property(e => e.YearsUpdated)
                .HasMaxLength(500)
                .HasColumnName("years_updated");
            entity.Property(e => e.Zip)
                .HasMaxLength(500)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<RawData17362202210141023126220>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_RawData_173_60_202210141023126220");

            entity.ToTable("RawData_173_62_202210141023126220");

            entity.HasIndex(e => e.EmpGroupId, "EMP_GroupID");

            entity.HasIndex(e => new { e.EmpUserId, e.UploadId }, "EMP_UserId");

            entity.HasIndex(e => e.UploadId, "UploadId");

            entity.Property(e => e.AcctId).HasColumnName("acct_id");
            entity.Property(e => e.AcctTypeDesc)
                .HasMaxLength(500)
                .HasColumnName("acct_type_desc");
            entity.Property(e => e.Barcode)
                .HasMaxLength(500)
                .HasColumnName("barcode");
            entity.Property(e => e.BirthDate)
                .HasMaxLength(500)
                .HasColumnName("birth_date");
            entity.Property(e => e.Card)
                .HasMaxLength(500)
                .HasColumnName("card");
            entity.Property(e => e.City)
                .HasMaxLength(500)
                .HasColumnName("city");
            entity.Property(e => e.ClubCode)
                .HasMaxLength(500)
                .HasColumnName("club_code");
            entity.Property(e => e.CompName)
                .HasMaxLength(500)
                .HasColumnName("comp_name");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(500)
                .HasColumnName("company_name");
            entity.Property(e => e.ConcessionText)
                .HasMaxLength(500)
                .HasColumnName("concession_text");
            entity.Property(e => e.ConsecutiveSince).HasColumnName("consecutive_since");
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .HasColumnName("country");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustNameId).HasColumnName("cust_name_id");
            entity.Property(e => e.DeliveryInstructions)
                .HasMaxLength(500)
                .HasColumnName("delivery_instructions");
            entity.Property(e => e.DeliveryMethodName)
                .HasMaxLength(500)
                .HasColumnName("delivery_method_name");
            entity.Property(e => e.DiscName)
                .HasMaxLength(500)
                .HasColumnName("disc_name");
            entity.Property(e => e.EmailAddr)
                .HasMaxLength(500)
                .HasColumnName("email_addr");
            entity.Property(e => e.EmpAcctStatus).HasColumnName("EMP_AcctStatus");
            entity.Property(e => e.EmpCredit)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("EMP_Credit");
            entity.Property(e => e.EmpDisplayOrder).HasColumnName("EMP_DisplayOrder");
            entity.Property(e => e.EmpErrorCode)
                .HasMaxLength(200)
                .HasColumnName("EMP_ErrorCode");
            entity.Property(e => e.EmpFamilyId).HasColumnName("EMP_FamilyID");
            entity.Property(e => e.EmpGender)
                .HasMaxLength(200)
                .HasColumnName("EMP_Gender");
            entity.Property(e => e.EmpGroupId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupId");
            entity.Property(e => e.EmpGroupUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupUserId");
            entity.Property(e => e.EmpIsCardOnly).HasColumnName("EMP_IsCardOnly");
            entity.Property(e => e.EmpIsMain)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_IsMain");
            entity.Property(e => e.EmpLoginAcctStatus).HasColumnName("EMP_LoginAcctStatus");
            entity.Property(e => e.EmpParticipantId).HasColumnName("EMP_ParticipantId");
            entity.Property(e => e.EmpProgramId).HasColumnName("EMP_ProgramId");
            entity.Property(e => e.EmpProgramName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ProgramName");
            entity.Property(e => e.EmpRecordInActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_RecordInActive");
            entity.Property(e => e.EmpRecordType)
                .HasMaxLength(200)
                .HasColumnName("EMP_RecordType");
            entity.Property(e => e.EmpRedeemed).HasColumnName("EMP_Redeemed");
            entity.Property(e => e.EmpSeasonId).HasColumnName("EMP_SeasonID");
            entity.Property(e => e.EmpShopName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ShopName");
            entity.Property(e => e.EmpUniqueKey)
                .HasMaxLength(300)
                .HasColumnName("EMP_UniqueKey");
            entity.Property(e => e.EmpUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_UserId");
            entity.Property(e => e.EmpUserTypeId).HasColumnName("EMP_UserTypeId");
            entity.Property(e => e.EmpUsername)
                .HasMaxLength(200)
                .HasColumnName("EMP_Username");
            entity.Property(e => e.EmpXmlData)
                .HasColumnType("xml")
                .HasColumnName("EMP_XmlData");
            entity.Property(e => e.EventLine1)
                .HasMaxLength(500)
                .HasColumnName("event_line1");
            entity.Property(e => e.EventLine2)
                .HasMaxLength(500)
                .HasColumnName("event_line2");
            entity.Property(e => e.EventLine3)
                .HasMaxLength(500)
                .HasColumnName("event_line3");
            entity.Property(e => e.EventName)
                .HasMaxLength(500)
                .HasColumnName("event_name");
            entity.Property(e => e.FamilyId).HasColumnName("family_id");
            entity.Property(e => e.Fulfilment)
                .HasMaxLength(500)
                .HasColumnName("fulfilment");
            entity.Property(e => e.FullName)
                .HasMaxLength(500)
                .HasColumnName("full_name");
            entity.Property(e => e.Gate)
                .HasMaxLength(500)
                .HasColumnName("gate");
            entity.Property(e => e.Gender)
                .HasMaxLength(500)
                .HasColumnName("gender");
            entity.Property(e => e.GroupCodes)
                .HasMaxLength(2000)
                .HasColumnName("group_codes");
            entity.Property(e => e.LocationCity)
                .HasMaxLength(500)
                .HasColumnName("location_city");
            entity.Property(e => e.LocationCountry)
                .HasMaxLength(500)
                .HasColumnName("location_country");
            entity.Property(e => e.LocationState)
                .HasMaxLength(500)
                .HasColumnName("location_state");
            entity.Property(e => e.LocationStreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_1");
            entity.Property(e => e.LocationStreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_2");
            entity.Property(e => e.LocationZip)
                .HasMaxLength(500)
                .HasColumnName("location_zip");
            entity.Property(e => e.MemberSince).HasColumnName("member_since");
            entity.Property(e => e.MembershipType)
                .HasMaxLength(500)
                .HasColumnName("membership_type");
            entity.Property(e => e.NameFirst)
                .HasMaxLength(500)
                .HasColumnName("name_first");
            entity.Property(e => e.NameLast)
                .HasMaxLength(500)
                .HasColumnName("name_last");
            entity.Property(e => e.Note1)
                .HasMaxLength(500)
                .HasColumnName("note1");
            entity.Property(e => e.Note2)
                .HasMaxLength(500)
                .HasColumnName("note2");
            entity.Property(e => e.NumSeats).HasColumnName("num_seats");
            entity.Property(e => e.OrderLineItem).HasColumnName("order_line_item");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.OtherInfo6)
                .HasMaxLength(500)
                .HasColumnName("other_info_6");
            entity.Property(e => e.OtherInfo7)
                .HasMaxLength(500)
                .HasColumnName("other_info_7");
            entity.Property(e => e.OtherInfo9)
                .HasMaxLength(500)
                .HasColumnName("other_info_9");
            entity.Property(e => e.PackChoice)
                .HasMaxLength(500)
                .HasColumnName("pack_choice");
            entity.Property(e => e.PhoneCell)
                .HasMaxLength(500)
                .HasColumnName("phone_cell");
            entity.Property(e => e.PhoneDay)
                .HasMaxLength(500)
                .HasColumnName("phone_day");
            entity.Property(e => e.PhoneEve)
                .HasMaxLength(500)
                .HasColumnName("phone_eve");
            entity.Property(e => e.PinMasked)
                .HasMaxLength(500)
                .HasColumnName("pin_masked");
            entity.Property(e => e.Portal)
                .HasMaxLength(500)
                .HasColumnName("portal");
            entity.Property(e => e.PriceCode)
                .HasMaxLength(500)
                .HasColumnName("price_code");
            entity.Property(e => e.PriceCodeDesc)
                .HasMaxLength(500)
                .HasColumnName("price_code_desc");
            entity.Property(e => e.PrimaryCustNameId).HasColumnName("primary_cust_name_id");
            entity.Property(e => e.PrimaryName)
                .HasMaxLength(500)
                .HasColumnName("primary_name");
            entity.Property(e => e.PrintCount).HasColumnName("print_count");
            entity.Property(e => e.PrintDate)
                .HasMaxLength(500)
                .HasColumnName("print_date");
            entity.Property(e => e.RowName)
                .HasMaxLength(500)
                .HasColumnName("row_name");
            entity.Property(e => e.SeatLabel1)
                .HasMaxLength(500)
                .HasColumnName("seat_label1");
            entity.Property(e => e.SeatLabel2)
                .HasMaxLength(500)
                .HasColumnName("seat_label2");
            entity.Property(e => e.SeatLabel3)
                .HasMaxLength(500)
                .HasColumnName("seat_label3");
            entity.Property(e => e.SeatLabel4)
                .HasMaxLength(500)
                .HasColumnName("seat_label4");
            entity.Property(e => e.SeatLocation1)
                .HasMaxLength(500)
                .HasColumnName("seat_location1");
            entity.Property(e => e.SeatLocation2)
                .HasMaxLength(500)
                .HasColumnName("seat_location2");
            entity.Property(e => e.SeatLocation3)
                .HasMaxLength(500)
                .HasColumnName("seat_location3");
            entity.Property(e => e.SeatLocation4)
                .HasMaxLength(500)
                .HasColumnName("seat_location4");
            entity.Property(e => e.SeatNum).HasColumnName("seat_num");
            entity.Property(e => e.SectionName)
                .HasMaxLength(500)
                .HasColumnName("section_name");
            entity.Property(e => e.State)
                .HasMaxLength(500)
                .HasColumnName("state");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("street_addr_1");
            entity.Property(e => e.StreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("street_addr_2");
            entity.Property(e => e.SurchgName)
                .HasMaxLength(500)
                .HasColumnName("surchg_name");
            entity.Property(e => e.TicketTypeCategory)
                .HasMaxLength(500)
                .HasColumnName("ticket_type_category");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.YearsConsecutive).HasColumnName("years_consecutive");
            entity.Property(e => e.YearsMembership).HasColumnName("years_membership");
            entity.Property(e => e.YearsUpdated)
                .HasMaxLength(500)
                .HasColumnName("years_updated");
            entity.Property(e => e.Zip)
                .HasMaxLength(500)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<RawData17445202208021205202686>(entity =>
        {
            entity.ToTable("RawData_174_45_202208021205202686");

            entity.HasIndex(e => e.EmpGroupId, "EMP_GroupID");

            entity.HasIndex(e => new { e.EmpUserId, e.UploadId }, "EMP_UserId");

            entity.HasIndex(e => e.UploadId, "UploadId");

            entity.Property(e => e.AmountDue).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.AmountPaid).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.AmountPaidNet).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.BudgetCode).HasMaxLength(500);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.EmpAcctStatus).HasColumnName("EMP_AcctStatus");
            entity.Property(e => e.EmpCredit)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("EMP_Credit");
            entity.Property(e => e.EmpDisplayOrder).HasColumnName("EMP_DisplayOrder");
            entity.Property(e => e.EmpErrorCode)
                .HasMaxLength(200)
                .HasColumnName("EMP_ErrorCode");
            entity.Property(e => e.EmpGender)
                .HasMaxLength(200)
                .HasColumnName("EMP_Gender");
            entity.Property(e => e.EmpGroupId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupId");
            entity.Property(e => e.EmpGroupUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupUserId");
            entity.Property(e => e.EmpIsCardOnly).HasColumnName("EMP_IsCardOnly");
            entity.Property(e => e.EmpIsMain)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_IsMain");
            entity.Property(e => e.EmpLoginAcctStatus).HasColumnName("EMP_LoginAcctStatus");
            entity.Property(e => e.EmpParticipantId).HasColumnName("EMP_ParticipantId");
            entity.Property(e => e.EmpProgramId).HasColumnName("EMP_ProgramId");
            entity.Property(e => e.EmpProgramName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ProgramName");
            entity.Property(e => e.EmpRecordInActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_RecordInActive");
            entity.Property(e => e.EmpRecordType)
                .HasMaxLength(200)
                .HasColumnName("EMP_RecordType");
            entity.Property(e => e.EmpRedeemed).HasColumnName("EMP_Redeemed");
            entity.Property(e => e.EmpSeasonId).HasColumnName("EMP_SeasonID");
            entity.Property(e => e.EmpShopName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ShopName");
            entity.Property(e => e.EmpUniqueKey)
                .HasMaxLength(300)
                .HasColumnName("EMP_UniqueKey");
            entity.Property(e => e.EmpUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_UserId");
            entity.Property(e => e.EmpUserTypeId).HasColumnName("EMP_UserTypeId");
            entity.Property(e => e.EmpUsername)
                .HasMaxLength(200)
                .HasColumnName("EMP_Username");
            entity.Property(e => e.EmpXmlData)
                .HasColumnType("xml")
                .HasColumnName("EMP_XmlData");
            entity.Property(e => e.Enaid).HasColumnName("ENAID");
            entity.Property(e => e.Invoice).HasMaxLength(500);
            entity.Property(e => e.ItemStatus).HasMaxLength(500);
            entity.Property(e => e.LineTotal).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.LinkedEmail).HasMaxLength(500);
            entity.Property(e => e.LinkedEnaid).HasColumnName("LinkedENAID");
            entity.Property(e => e.LinkedFirstName).HasMaxLength(500);
            entity.Property(e => e.LinkedLastName).HasMaxLength(500);
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentPending).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.PendingPayments).HasMaxLength(500);
            entity.Property(e => e.ProductCategory).HasMaxLength(500);
            entity.Property(e => e.ProductName).HasMaxLength(500);
            entity.Property(e => e.Promotion).HasMaxLength(500);
            entity.Property(e => e.PurchaserEmailAddress).HasMaxLength(500);
            entity.Property(e => e.PurchaserFirstName).HasMaxLength(500);
            entity.Property(e => e.PurchaserLastName).HasMaxLength(500);
            entity.Property(e => e.Season)
                .HasMaxLength(500)
                .HasColumnName("Season.");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.Status1)
                .HasMaxLength(500)
                .HasColumnName("Status.");
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<RawData17445202209160726342555>(entity =>
        {
            entity.ToTable("RawData_174_45_202209160726342555");

            entity.HasIndex(e => e.EmpGroupId, "EMP_GroupID");

            entity.HasIndex(e => new { e.EmpUserId, e.UploadId }, "EMP_UserId");

            entity.HasIndex(e => e.UploadId, "UploadId");

            entity.Property(e => e.AmountDue).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.AmountPaid).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.AmountPaidNet).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.BudgetCode).HasMaxLength(500);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.EmpAcctStatus).HasColumnName("EMP_AcctStatus");
            entity.Property(e => e.EmpCredit)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("EMP_Credit");
            entity.Property(e => e.EmpDisplayOrder).HasColumnName("EMP_DisplayOrder");
            entity.Property(e => e.EmpErrorCode)
                .HasMaxLength(200)
                .HasColumnName("EMP_ErrorCode");
            entity.Property(e => e.EmpGender)
                .HasMaxLength(200)
                .HasColumnName("EMP_Gender");
            entity.Property(e => e.EmpGroupId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupId");
            entity.Property(e => e.EmpGroupUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupUserId");
            entity.Property(e => e.EmpIsCardOnly).HasColumnName("EMP_IsCardOnly");
            entity.Property(e => e.EmpIsMain)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_IsMain");
            entity.Property(e => e.EmpLoginAcctStatus).HasColumnName("EMP_LoginAcctStatus");
            entity.Property(e => e.EmpParticipantId).HasColumnName("EMP_ParticipantId");
            entity.Property(e => e.EmpProgramId).HasColumnName("EMP_ProgramId");
            entity.Property(e => e.EmpProgramName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ProgramName");
            entity.Property(e => e.EmpRecordInActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_RecordInActive");
            entity.Property(e => e.EmpRecordType)
                .HasMaxLength(200)
                .HasColumnName("EMP_RecordType");
            entity.Property(e => e.EmpRedeemed).HasColumnName("EMP_Redeemed");
            entity.Property(e => e.EmpSeasonId).HasColumnName("EMP_SeasonID");
            entity.Property(e => e.EmpShopName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ShopName");
            entity.Property(e => e.EmpUniqueKey)
                .HasMaxLength(300)
                .HasColumnName("EMP_UniqueKey");
            entity.Property(e => e.EmpUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_UserId");
            entity.Property(e => e.EmpUserTypeId).HasColumnName("EMP_UserTypeId");
            entity.Property(e => e.EmpUsername)
                .HasMaxLength(200)
                .HasColumnName("EMP_Username");
            entity.Property(e => e.EmpXmlData)
                .HasColumnType("xml")
                .HasColumnName("EMP_XmlData");
            entity.Property(e => e.Enaid).HasColumnName("ENAID");
            entity.Property(e => e.Invoice).HasMaxLength(500);
            entity.Property(e => e.ItemStatus).HasMaxLength(500);
            entity.Property(e => e.LineTotal).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.LinkedEmail).HasMaxLength(500);
            entity.Property(e => e.LinkedEnaid).HasColumnName("LinkedENAID");
            entity.Property(e => e.LinkedFirstName).HasMaxLength(500);
            entity.Property(e => e.LinkedLastName).HasMaxLength(500);
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentPending).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.PendingPayments).HasMaxLength(500);
            entity.Property(e => e.ProductCategory).HasMaxLength(500);
            entity.Property(e => e.ProductName).HasMaxLength(500);
            entity.Property(e => e.Promotion).HasMaxLength(500);
            entity.Property(e => e.PurchaserEmailAddress).HasMaxLength(500);
            entity.Property(e => e.PurchaserFirstName).HasMaxLength(500);
            entity.Property(e => e.PurchaserLastName).HasMaxLength(500);
            entity.Property(e => e.Season).HasMaxLength(500);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.Status1).HasMaxLength(500);
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<RawData17546202208020400315347>(entity =>
        {
            entity.ToTable("RawData_175_46_202208020400315347");

            entity.HasIndex(e => new { e.EmpUserId, e.UploadId }, "EMP_UserId");

            entity.HasIndex(e => e.UploadId, "UploadId");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(500);
            entity.Property(e => e.EmpAcctStatus).HasColumnName("EMP_AcctStatus");
            entity.Property(e => e.EmpCredit)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("EMP_Credit");
            entity.Property(e => e.EmpDisplayOrder).HasColumnName("EMP_DisplayOrder");
            entity.Property(e => e.EmpErrorCode)
                .HasMaxLength(200)
                .HasColumnName("EMP_ErrorCode");
            entity.Property(e => e.EmpGender)
                .HasMaxLength(200)
                .HasColumnName("EMP_Gender");
            entity.Property(e => e.EmpGroupId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupId");
            entity.Property(e => e.EmpGroupUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupUserId");
            entity.Property(e => e.EmpIsCardOnly).HasColumnName("EMP_IsCardOnly");
            entity.Property(e => e.EmpIsMain)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_IsMain");
            entity.Property(e => e.EmpLoginAcctStatus).HasColumnName("EMP_LoginAcctStatus");
            entity.Property(e => e.EmpParticipantId).HasColumnName("EMP_ParticipantId");
            entity.Property(e => e.EmpProgramId).HasColumnName("EMP_ProgramId");
            entity.Property(e => e.EmpProgramName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ProgramName");
            entity.Property(e => e.EmpRecordInActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_RecordInActive");
            entity.Property(e => e.EmpRecordType)
                .HasMaxLength(200)
                .HasColumnName("EMP_RecordType");
            entity.Property(e => e.EmpRedeemed).HasColumnName("EMP_Redeemed");
            entity.Property(e => e.EmpSeasonId).HasColumnName("EMP_SeasonID");
            entity.Property(e => e.EmpShopName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ShopName");
            entity.Property(e => e.EmpUniqueKey)
                .HasMaxLength(300)
                .HasColumnName("EMP_UniqueKey");
            entity.Property(e => e.EmpUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_UserId");
            entity.Property(e => e.EmpUserStatus)
                .HasMaxLength(200)
                .HasColumnName("EMP_UserStatus");
            entity.Property(e => e.EmpUserTypeId).HasColumnName("EMP_UserTypeId");
            entity.Property(e => e.EmpUsername)
                .HasMaxLength(200)
                .HasColumnName("EMP_Username");
            entity.Property(e => e.EmpXmlData)
                .HasColumnType("xml")
                .HasColumnName("EMP_XmlData");
            entity.Property(e => e.FirstName).HasMaxLength(500);
            entity.Property(e => e.LastName).HasMaxLength(500);
            entity.Property(e => e.MemberId)
                .HasMaxLength(500)
                .HasColumnName("MemberID");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<RawData17668202209071136098342>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_RawData_176_47_202209071136098342");

            entity.ToTable("RawData_176_68_202209071136098342");

            entity.HasIndex(e => e.EmpGroupId, "EMP_GroupID");

            entity.HasIndex(e => new { e.EmpUserId, e.UploadId }, "EMP_UserId");

            entity.HasIndex(e => e.UploadId, "UploadId");

            entity.Property(e => e.AcctId).HasColumnName("acct_id");
            entity.Property(e => e.AcctTypeDesc)
                .HasMaxLength(500)
                .HasColumnName("acct_type_desc");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Barcode)
                .HasMaxLength(500)
                .HasColumnName("barcode");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("birthdate");
            entity.Property(e => e.Card)
                .HasMaxLength(500)
                .HasColumnName("card");
            entity.Property(e => e.City)
                .HasMaxLength(500)
                .HasColumnName("city");
            entity.Property(e => e.ClubCode)
                .HasMaxLength(500)
                .HasColumnName("club_code");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(500)
                .HasColumnName("company_name");
            entity.Property(e => e.ConcessionText)
                .HasMaxLength(500)
                .HasColumnName("concession_text");
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .HasColumnName("country");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustNameId).HasColumnName("cust_name_id");
            entity.Property(e => e.DeliveryInstructions)
                .HasMaxLength(500)
                .HasColumnName("delivery_instructions");
            entity.Property(e => e.DeliveryMethodName)
                .HasMaxLength(500)
                .HasColumnName("delivery_method_name");
            entity.Property(e => e.EmailAddr)
                .HasMaxLength(500)
                .HasColumnName("email_addr");
            entity.Property(e => e.EmpAcctId).HasColumnName("EMP_acct_id");
            entity.Property(e => e.EmpAcctStatus).HasColumnName("EMP_AcctStatus");
            entity.Property(e => e.EmpCredit)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("EMP_Credit");
            entity.Property(e => e.EmpDisplayOrder).HasColumnName("EMP_DisplayOrder");
            entity.Property(e => e.EmpErrorCode)
                .HasMaxLength(200)
                .HasColumnName("EMP_ErrorCode");
            entity.Property(e => e.EmpExists)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_EXISTS");
            entity.Property(e => e.EmpGender)
                .HasMaxLength(200)
                .HasColumnName("EMP_Gender");
            entity.Property(e => e.EmpGroupId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupId");
            entity.Property(e => e.EmpGroupNum).HasColumnName("EMP_Group_Num");
            entity.Property(e => e.EmpGroupUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupUserId");
            entity.Property(e => e.EmpIsCardOnly).HasColumnName("EMP_IsCardOnly");
            entity.Property(e => e.EmpIsMain)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_IsMain");
            entity.Property(e => e.EmpLoginAcctStatus).HasColumnName("EMP_LoginAcctStatus");
            entity.Property(e => e.EmpOldMain)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_OldMain");
            entity.Property(e => e.EmpParticipantId).HasColumnName("EMP_ParticipantId");
            entity.Property(e => e.EmpProgramId).HasColumnName("EMP_ProgramId");
            entity.Property(e => e.EmpProgramName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ProgramName");
            entity.Property(e => e.EmpRecordInActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_RecordInActive");
            entity.Property(e => e.EmpRecordType)
                .HasMaxLength(200)
                .HasColumnName("EMP_RecordType");
            entity.Property(e => e.EmpRedeemed).HasColumnName("EMP_Redeemed");
            entity.Property(e => e.EmpSeasonId).HasColumnName("EMP_SeasonID");
            entity.Property(e => e.EmpShopName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ShopName");
            entity.Property(e => e.EmpTemplateJson)
                .HasMaxLength(1000)
                .HasColumnName("EMP_template_json");
            entity.Property(e => e.EmpUniqueKey)
                .HasMaxLength(300)
                .HasColumnName("EMP_UniqueKey");
            entity.Property(e => e.EmpUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_UserId");
            entity.Property(e => e.EmpUserTypeId).HasColumnName("EMP_UserTypeId");
            entity.Property(e => e.EmpUsername)
                .HasMaxLength(200)
                .HasColumnName("EMP_Username");
            entity.Property(e => e.EmpXmlData)
                .HasColumnType("xml")
                .HasColumnName("EMP_XmlData");
            entity.Property(e => e.EventLine1)
                .HasMaxLength(500)
                .HasColumnName("event_line1");
            entity.Property(e => e.EventLine2)
                .HasMaxLength(500)
                .HasColumnName("event_line2");
            entity.Property(e => e.EventLine3)
                .HasMaxLength(500)
                .HasColumnName("event_line3");
            entity.Property(e => e.EventName)
                .HasMaxLength(500)
                .HasColumnName("event_name");
            entity.Property(e => e.FamilyId).HasColumnName("family_id");
            entity.Property(e => e.Fulfilment)
                .HasMaxLength(500)
                .HasColumnName("fulfilment");
            entity.Property(e => e.FulfilmentChoice)
                .HasMaxLength(500)
                .HasColumnName("fulfilment_choice");
            entity.Property(e => e.FulfilmentQty).HasColumnName("fulfilment_qty");
            entity.Property(e => e.Gender)
                .HasMaxLength(500)
                .HasColumnName("gender");
            entity.Property(e => e.GroupCodes)
                .HasMaxLength(500)
                .HasColumnName("group_codes");
            entity.Property(e => e.LocationCity)
                .HasMaxLength(500)
                .HasColumnName("location_city");
            entity.Property(e => e.LocationCountry)
                .HasMaxLength(500)
                .HasColumnName("location_country");
            entity.Property(e => e.LocationState)
                .HasMaxLength(500)
                .HasColumnName("location_state");
            entity.Property(e => e.LocationStreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_1");
            entity.Property(e => e.LocationStreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_2");
            entity.Property(e => e.LocationZip)
                .HasMaxLength(500)
                .HasColumnName("location_zip");
            entity.Property(e => e.MemberId).HasColumnName("member_id");
            entity.Property(e => e.MemberSince).HasColumnName("member_since");
            entity.Property(e => e.MembershipType)
                .HasMaxLength(500)
                .HasColumnName("membership_type");
            entity.Property(e => e.NameFirst)
                .HasMaxLength(500)
                .HasColumnName("name_first");
            entity.Property(e => e.NameLast)
                .HasMaxLength(500)
                .HasColumnName("name_last");
            entity.Property(e => e.Note1)
                .HasMaxLength(500)
                .HasColumnName("note1");
            entity.Property(e => e.NumSeats).HasColumnName("num_seats");
            entity.Property(e => e.OrderLineItem).HasColumnName("order_line_item");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.PaymentPlan)
                .HasMaxLength(500)
                .HasColumnName("payment_plan");
            entity.Property(e => e.PhoneCell)
                .HasMaxLength(500)
                .HasColumnName("phone_cell");
            entity.Property(e => e.PhoneDay)
                .HasMaxLength(500)
                .HasColumnName("phone_day");
            entity.Property(e => e.PhoneEve)
                .HasMaxLength(500)
                .HasColumnName("phone_eve");
            entity.Property(e => e.PriceCode)
                .HasMaxLength(500)
                .HasColumnName("price_code");
            entity.Property(e => e.PriceCodeDesc)
                .HasMaxLength(500)
                .HasColumnName("price_code_desc");
            entity.Property(e => e.PriceCodeExtra)
                .HasMaxLength(500)
                .HasColumnName("price_code_extra");
            entity.Property(e => e.PriceCodeInfo1)
                .HasMaxLength(500)
                .HasColumnName("price_code_info1");
            entity.Property(e => e.PriceCodeInfo2)
                .HasMaxLength(500)
                .HasColumnName("price_code_info2");
            entity.Property(e => e.PriceCodeInfo3)
                .HasMaxLength(500)
                .HasColumnName("price_code_info3");
            entity.Property(e => e.PriceCodeInfo4)
                .HasMaxLength(500)
                .HasColumnName("price_code_info4");
            entity.Property(e => e.PrimaryName)
                .HasMaxLength(500)
                .HasColumnName("primary_name");
            entity.Property(e => e.PrintCount).HasColumnName("print_count");
            entity.Property(e => e.PrintDate)
                .HasColumnType("datetime")
                .HasColumnName("print_date");
            entity.Property(e => e.RowName)
                .HasMaxLength(500)
                .HasColumnName("row_name");
            entity.Property(e => e.SeatNum).HasColumnName("seat_num");
            entity.Property(e => e.SectionName)
                .HasMaxLength(500)
                .HasColumnName("section_name");
            entity.Property(e => e.State)
                .HasMaxLength(500)
                .HasColumnName("state");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("street_addr_1");
            entity.Property(e => e.StreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("street_addr_2");
            entity.Property(e => e.TicketTypeCategory)
                .HasMaxLength(500)
                .HasColumnName("ticket_type_category");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Venue1Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue1_aisle");
            entity.Property(e => e.Venue1Gate)
                .HasMaxLength(500)
                .HasColumnName("venue1_gate");
            entity.Property(e => e.Venue1Row)
                .HasMaxLength(500)
                .HasColumnName("venue1_row");
            entity.Property(e => e.Venue1Seat)
                .HasMaxLength(500)
                .HasColumnName("venue1_seat");
            entity.Property(e => e.Venue1Section)
                .HasMaxLength(500)
                .HasColumnName("venue1_section");
            entity.Property(e => e.Venue1Stand)
                .HasMaxLength(500)
                .HasColumnName("venue1_stand");
            entity.Property(e => e.Venue2Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue2_aisle");
            entity.Property(e => e.Venue2Gate)
                .HasMaxLength(500)
                .HasColumnName("venue2_gate");
            entity.Property(e => e.Venue2Row)
                .HasMaxLength(500)
                .HasColumnName("venue2_row");
            entity.Property(e => e.Venue2Seat)
                .HasMaxLength(500)
                .HasColumnName("venue2_seat");
            entity.Property(e => e.Venue2Section)
                .HasMaxLength(500)
                .HasColumnName("venue2_section");
            entity.Property(e => e.Venue2Stand)
                .HasMaxLength(500)
                .HasColumnName("venue2_stand");
            entity.Property(e => e.YearsMembership).HasColumnName("years_membership");
            entity.Property(e => e.Zip)
                .HasMaxLength(500)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<RawData17763202209230252212550>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_RawData_177_48_202209230252212550");

            entity.ToTable("RawData_177_63_202209230252212550");

            entity.HasIndex(e => e.EmpGroupId, "EMP_GroupID");

            entity.HasIndex(e => new { e.EmpUserId, e.UploadId }, "EMP_UserId");

            entity.HasIndex(e => e.UploadId, "UploadId");

            entity.Property(e => e.AcctId)
                .HasMaxLength(500)
                .HasColumnName("acct_id");
            entity.Property(e => e.AcctTypeDesc)
                .HasMaxLength(500)
                .HasColumnName("acct_type_desc");
            entity.Property(e => e.Barcode)
                .HasMaxLength(500)
                .HasColumnName("barcode");
            entity.Property(e => e.BirthDate)
                .HasColumnType("datetime")
                .HasColumnName("birth_date");
            entity.Property(e => e.Card)
                .HasMaxLength(500)
                .HasColumnName("card");
            entity.Property(e => e.City)
                .HasMaxLength(500)
                .HasColumnName("city");
            entity.Property(e => e.ClubCode)
                .HasMaxLength(500)
                .HasColumnName("club_code");
            entity.Property(e => e.CompName)
                .HasMaxLength(500)
                .HasColumnName("comp_name");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(500)
                .HasColumnName("company_name");
            entity.Property(e => e.ConcessionText)
                .HasMaxLength(500)
                .HasColumnName("concession_text");
            entity.Property(e => e.ConsecutiveSince).HasColumnName("consecutive_since");
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .HasColumnName("country");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustNameId).HasColumnName("cust_name_id");
            entity.Property(e => e.DeliveryInstructions)
                .HasMaxLength(500)
                .HasColumnName("delivery_instructions");
            entity.Property(e => e.DeliveryMethodName)
                .HasMaxLength(500)
                .HasColumnName("delivery_method_name");
            entity.Property(e => e.DiscName)
                .HasMaxLength(500)
                .HasColumnName("disc_name");
            entity.Property(e => e.EmailAddr)
                .HasMaxLength(500)
                .HasColumnName("email_addr");
            entity.Property(e => e.EmpAcctStatus).HasColumnName("EMP_AcctStatus");
            entity.Property(e => e.EmpCredit)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("EMP_Credit");
            entity.Property(e => e.EmpDisplayOrder).HasColumnName("EMP_DisplayOrder");
            entity.Property(e => e.EmpErrorCode)
                .HasMaxLength(200)
                .HasColumnName("EMP_ErrorCode");
            entity.Property(e => e.EmpGender)
                .HasMaxLength(200)
                .HasColumnName("EMP_Gender");
            entity.Property(e => e.EmpGroupId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupId");
            entity.Property(e => e.EmpGroupUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupUserId");
            entity.Property(e => e.EmpIsCardOnly).HasColumnName("EMP_IsCardOnly");
            entity.Property(e => e.EmpIsMain)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_IsMain");
            entity.Property(e => e.EmpLoginAcctStatus).HasColumnName("EMP_LoginAcctStatus");
            entity.Property(e => e.EmpParticipantId).HasColumnName("EMP_ParticipantId");
            entity.Property(e => e.EmpProgramId).HasColumnName("EMP_ProgramId");
            entity.Property(e => e.EmpProgramName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ProgramName");
            entity.Property(e => e.EmpRecordInActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_RecordInActive");
            entity.Property(e => e.EmpRecordType)
                .HasMaxLength(200)
                .HasColumnName("EMP_RecordType");
            entity.Property(e => e.EmpRedeemed).HasColumnName("EMP_Redeemed");
            entity.Property(e => e.EmpSeasonId).HasColumnName("EMP_SeasonID");
            entity.Property(e => e.EmpShopName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ShopName");
            entity.Property(e => e.EmpUniqueKey)
                .HasMaxLength(300)
                .HasColumnName("EMP_UniqueKey");
            entity.Property(e => e.EmpUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_UserId");
            entity.Property(e => e.EmpUserTypeId).HasColumnName("EMP_UserTypeId");
            entity.Property(e => e.EmpUsername)
                .HasMaxLength(200)
                .HasColumnName("EMP_Username");
            entity.Property(e => e.EmpXmlData)
                .HasColumnType("xml")
                .HasColumnName("EMP_XmlData");
            entity.Property(e => e.EventLine1)
                .HasMaxLength(500)
                .HasColumnName("event_line1");
            entity.Property(e => e.EventLine2)
                .HasMaxLength(500)
                .HasColumnName("event_line2");
            entity.Property(e => e.EventLine3)
                .HasMaxLength(500)
                .HasColumnName("event_line3");
            entity.Property(e => e.EventName)
                .HasMaxLength(500)
                .HasColumnName("event_name");
            entity.Property(e => e.FamilyId).HasColumnName("family_id");
            entity.Property(e => e.Fulfilment)
                .HasMaxLength(500)
                .HasColumnName("fulfilment");
            entity.Property(e => e.FullName)
                .HasMaxLength(500)
                .HasColumnName("full_name");
            entity.Property(e => e.Gate)
                .HasMaxLength(500)
                .HasColumnName("gate");
            entity.Property(e => e.Gender)
                .HasMaxLength(500)
                .HasColumnName("gender");
            entity.Property(e => e.GroupCodes)
                .HasColumnType("text")
                .HasColumnName("group_codes");
            entity.Property(e => e.LocationCity)
                .HasMaxLength(500)
                .HasColumnName("location_city");
            entity.Property(e => e.LocationCountry)
                .HasMaxLength(500)
                .HasColumnName("location_country");
            entity.Property(e => e.LocationState)
                .HasMaxLength(500)
                .HasColumnName("location_state");
            entity.Property(e => e.LocationStreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_1");
            entity.Property(e => e.LocationStreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_2");
            entity.Property(e => e.LocationZip)
                .HasMaxLength(500)
                .HasColumnName("location_zip");
            entity.Property(e => e.MemberSince).HasColumnName("member_since");
            entity.Property(e => e.MembershipType)
                .HasMaxLength(500)
                .HasColumnName("membership_type");
            entity.Property(e => e.NameFirst)
                .HasMaxLength(500)
                .HasColumnName("name_first");
            entity.Property(e => e.NameLast)
                .HasMaxLength(500)
                .HasColumnName("name_last");
            entity.Property(e => e.Note1)
                .HasMaxLength(500)
                .HasColumnName("note1");
            entity.Property(e => e.Note2)
                .HasMaxLength(500)
                .HasColumnName("note2");
            entity.Property(e => e.NumSeats).HasColumnName("num_seats");
            entity.Property(e => e.OrderLineItem).HasColumnName("order_line_item");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.OtherInfo6)
                .HasMaxLength(500)
                .HasColumnName("other_info_6");
            entity.Property(e => e.OtherInfo7)
                .HasMaxLength(500)
                .HasColumnName("other_info_7");
            entity.Property(e => e.OtherInfo9)
                .HasMaxLength(500)
                .HasColumnName("other_info_9");
            entity.Property(e => e.PackChoice)
                .HasMaxLength(500)
                .HasColumnName("pack_choice");
            entity.Property(e => e.PhoneCell)
                .HasMaxLength(500)
                .HasColumnName("phone_cell");
            entity.Property(e => e.PhoneDay)
                .HasMaxLength(500)
                .HasColumnName("phone_day");
            entity.Property(e => e.PhoneEve)
                .HasMaxLength(500)
                .HasColumnName("phone_eve");
            entity.Property(e => e.PinMasked)
                .HasMaxLength(500)
                .HasColumnName("pin_masked");
            entity.Property(e => e.Portal)
                .HasMaxLength(500)
                .HasColumnName("portal");
            entity.Property(e => e.PriceCode)
                .HasMaxLength(500)
                .HasColumnName("price_code");
            entity.Property(e => e.PriceCodeDesc)
                .HasMaxLength(500)
                .HasColumnName("price_code_desc");
            entity.Property(e => e.PrimaryCustNameId).HasColumnName("primary_cust_name_id");
            entity.Property(e => e.PrimaryName)
                .HasMaxLength(500)
                .HasColumnName("primary_name");
            entity.Property(e => e.PrintCount).HasColumnName("print_count");
            entity.Property(e => e.PrintDate)
                .HasColumnType("datetime")
                .HasColumnName("print_date");
            entity.Property(e => e.RowName)
                .HasMaxLength(500)
                .HasColumnName("row_name");
            entity.Property(e => e.SeatLabel1)
                .HasMaxLength(500)
                .HasColumnName("seat_label1");
            entity.Property(e => e.SeatLabel2)
                .HasMaxLength(500)
                .HasColumnName("seat_label2");
            entity.Property(e => e.SeatLabel3)
                .HasMaxLength(500)
                .HasColumnName("seat_label3");
            entity.Property(e => e.SeatLabel4)
                .HasMaxLength(500)
                .HasColumnName("seat_label4");
            entity.Property(e => e.SeatLocation1)
                .HasMaxLength(500)
                .HasColumnName("seat_location1");
            entity.Property(e => e.SeatLocation2)
                .HasMaxLength(500)
                .HasColumnName("seat_location2");
            entity.Property(e => e.SeatLocation3)
                .HasMaxLength(500)
                .HasColumnName("seat_location3");
            entity.Property(e => e.SeatLocation4)
                .HasMaxLength(500)
                .HasColumnName("seat_location4");
            entity.Property(e => e.SeatNum).HasColumnName("seat_num");
            entity.Property(e => e.SectionName)
                .HasMaxLength(500)
                .HasColumnName("section_name");
            entity.Property(e => e.State)
                .HasMaxLength(500)
                .HasColumnName("state");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("street_addr_1");
            entity.Property(e => e.StreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("street_addr_2");
            entity.Property(e => e.SurchgName)
                .HasMaxLength(500)
                .HasColumnName("surchg_name");
            entity.Property(e => e.TicketTypeCategory)
                .HasMaxLength(500)
                .HasColumnName("ticket_type_category");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.YearsConsecutive).HasColumnName("years_consecutive");
            entity.Property(e => e.YearsMembership).HasColumnName("years_membership");
            entity.Property(e => e.YearsUpdated)
                .HasMaxLength(500)
                .HasColumnName("years_updated");
            entity.Property(e => e.Zip)
                .HasMaxLength(500)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<RawData17849202209271142438967>(entity =>
        {
            entity.ToTable("RawData_178_49_202209271142438967");

            entity.HasIndex(e => e.EmpGroupId, "EMP_GroupID");

            entity.HasIndex(e => new { e.EmpUserId, e.UploadId }, "EMP_UserId");

            entity.HasIndex(e => e.UploadId, "UploadId");

            entity.Property(e => e.AddressLine1).HasMaxLength(500);
            entity.Property(e => e.AddressLine2).HasMaxLength(500);
            entity.Property(e => e.Aisle1).HasMaxLength(500);
            entity.Property(e => e.Aisle2).HasMaxLength(500);
            entity.Property(e => e.Aisle3).HasMaxLength(500);
            entity.Property(e => e.Barcode).HasMaxLength(500);
            entity.Property(e => e.CardFirstName).HasMaxLength(500);
            entity.Property(e => e.CardLastName).HasMaxLength(500);
            entity.Property(e => e.CardStatus).HasMaxLength(500);
            entity.Property(e => e.Category).HasMaxLength(500);
            entity.Property(e => e.ClubMembershipId).HasColumnName("ClubMembershipID");
            entity.Property(e => e.ClubNativeId)
                .HasMaxLength(500)
                .HasColumnName("ClubNativeID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName).HasMaxLength(500);
            entity.Property(e => e.ConsecutiveTenure).HasMaxLength(500);
            entity.Property(e => e.Country).HasMaxLength(500);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.DateOfBirth).HasColumnType("date");
            entity.Property(e => e.DeliveryType).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(500);
            entity.Property(e => e.EmpAcctStatus).HasColumnName("EMP_AcctStatus");
            entity.Property(e => e.EmpCredit)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("EMP_Credit");
            entity.Property(e => e.EmpDisplayOrder).HasColumnName("EMP_DisplayOrder");
            entity.Property(e => e.EmpErrorCode)
                .HasMaxLength(200)
                .HasColumnName("EMP_ErrorCode");
            entity.Property(e => e.EmpGender)
                .HasMaxLength(200)
                .HasColumnName("EMP_Gender");
            entity.Property(e => e.EmpGroupId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupId");
            entity.Property(e => e.EmpGroupUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupUserId");
            entity.Property(e => e.EmpIsCardOnly).HasColumnName("EMP_IsCardOnly");
            entity.Property(e => e.EmpIsMain)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_IsMain");
            entity.Property(e => e.EmpLoginAcctStatus).HasColumnName("EMP_LoginAcctStatus");
            entity.Property(e => e.EmpParticipantId).HasColumnName("EMP_ParticipantId");
            entity.Property(e => e.EmpProgramId).HasColumnName("EMP_ProgramId");
            entity.Property(e => e.EmpProgramName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ProgramName");
            entity.Property(e => e.EmpRecordInActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_RecordInActive");
            entity.Property(e => e.EmpRecordType)
                .HasMaxLength(200)
                .HasColumnName("EMP_RecordType");
            entity.Property(e => e.EmpRecordTypeFf)
                .HasMaxLength(200)
                .HasColumnName("EMP_RecordTypeFF");
            entity.Property(e => e.EmpRedeemed).HasColumnName("EMP_Redeemed");
            entity.Property(e => e.EmpSeasonId).HasColumnName("EMP_SeasonID");
            entity.Property(e => e.EmpShopName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ShopName");
            entity.Property(e => e.EmpTemplateJson)
                .HasMaxLength(2000)
                .HasColumnName("EMP_template_json");
            entity.Property(e => e.EmpUniqueKey)
                .HasMaxLength(300)
                .HasColumnName("EMP_UniqueKey");
            entity.Property(e => e.EmpUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_UserId");
            entity.Property(e => e.EmpUserTypeId).HasColumnName("EMP_UserTypeId");
            entity.Property(e => e.EmpUsername)
                .HasMaxLength(200)
                .HasColumnName("EMP_Username");
            entity.Property(e => e.EmpXmlData)
                .HasColumnType("xml")
                .HasColumnName("EMP_XmlData");
            entity.Property(e => e.Gate1).HasMaxLength(500);
            entity.Property(e => e.Gate2).HasMaxLength(500);
            entity.Property(e => e.Gate3).HasMaxLength(500);
            entity.Property(e => e.MemberExpiry).HasColumnType("date");
            entity.Property(e => e.MemberSince).HasMaxLength(500);
            entity.Property(e => e.MemberType).HasMaxLength(500);
            entity.Property(e => e.OrderId)
                .HasMaxLength(500)
                .HasColumnName("OrderID");
            entity.Property(e => e.OrderlineId)
                .HasMaxLength(500)
                .HasColumnName("OrderlineID");
            entity.Property(e => e.OrderlineItemIdguid)
                .HasMaxLength(500)
                .HasColumnName("OrderlineItemIDGuid");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.Package).HasMaxLength(500);
            entity.Property(e => e.PahaddressLine1)
                .HasMaxLength(500)
                .HasColumnName("PAHAddressLine1");
            entity.Property(e => e.PahaddressLine2)
                .HasMaxLength(500)
                .HasColumnName("PAHAddressLine2");
            entity.Property(e => e.PahclubMembershipId).HasColumnName("PAHClubMembershipID");
            entity.Property(e => e.PahclubNativeId)
                .HasMaxLength(500)
                .HasColumnName("PAHClubNativeID");
            entity.Property(e => e.PahcompanyName)
                .HasMaxLength(500)
                .HasColumnName("PAHCompanyName");
            entity.Property(e => e.Pahcountry)
                .HasMaxLength(500)
                .HasColumnName("PAHCountry");
            entity.Property(e => e.PahcustomerId).HasColumnName("PAHCustomerID");
            entity.Property(e => e.Pahemail)
                .HasMaxLength(500)
                .HasColumnName("PAHEmail");
            entity.Property(e => e.PahfirstName)
                .HasMaxLength(500)
                .HasColumnName("PAHFirstName");
            entity.Property(e => e.PahlastName)
                .HasMaxLength(500)
                .HasColumnName("PAHLastName");
            entity.Property(e => e.PahpostCode)
                .HasMaxLength(500)
                .HasColumnName("PAHPostCode");
            entity.Property(e => e.PahprimaryPhone)
                .HasMaxLength(500)
                .HasColumnName("PAHPrimaryPhone");
            entity.Property(e => e.Pahsalutation)
                .HasMaxLength(500)
                .HasColumnName("PAHSalutation");
            entity.Property(e => e.Pahstate)
                .HasMaxLength(500)
                .HasColumnName("PAHState");
            entity.Property(e => e.Pahsuburb)
                .HasMaxLength(500)
                .HasColumnName("PAHSuburb");
            entity.Property(e => e.PaxCardNo).HasMaxLength(500);
            entity.Property(e => e.PaymentOption).HasMaxLength(500);
            entity.Property(e => e.PostCode).HasMaxLength(500);
            entity.Property(e => e.PriceType).HasMaxLength(500);
            entity.Property(e => e.PriceTypePrintName).HasMaxLength(500);
            entity.Property(e => e.ProcessMethod).HasMaxLength(500);
            entity.Property(e => e.Row1).HasMaxLength(500);
            entity.Property(e => e.Row2).HasMaxLength(500);
            entity.Property(e => e.Row3).HasMaxLength(500);
            entity.Property(e => e.RunNumber).HasMaxLength(500);
            entity.Property(e => e.Seat1).HasMaxLength(500);
            entity.Property(e => e.Seat2).HasMaxLength(500);
            entity.Property(e => e.Seat3).HasMaxLength(500);
            entity.Property(e => e.SeatingType).HasMaxLength(500);
            entity.Property(e => e.Section1).HasMaxLength(500);
            entity.Property(e => e.Section2).HasMaxLength(500);
            entity.Property(e => e.Section3).HasMaxLength(500);
            entity.Property(e => e.State).HasMaxLength(500);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.Suburb).HasMaxLength(500);
            entity.Property(e => e.Uniqueid).HasMaxLength(500);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Venue1).HasMaxLength(500);
            entity.Property(e => e.Venue2).HasMaxLength(500);
            entity.Property(e => e.Venue3).HasMaxLength(500);
        });

        modelBuilder.Entity<RawData17970202210030147599126>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_RawData_179_50_202210030147599126");

            entity.ToTable("RawData_179_70_202210030147599126");

            entity.HasIndex(e => e.EmpGroupId, "EMP_GroupID");

            entity.HasIndex(e => new { e.EmpUserId, e.UploadId }, "EMP_UserId");

            entity.HasIndex(e => e.UploadId, "UploadId");

            entity.Property(e => e.AddressLine1).HasMaxLength(500);
            entity.Property(e => e.AddressLine2).HasMaxLength(500);
            entity.Property(e => e.Age).HasMaxLength(500);
            entity.Property(e => e.Aisle1).HasMaxLength(500);
            entity.Property(e => e.Barcode).HasMaxLength(500);
            entity.Property(e => e.CardFirstName).HasMaxLength(500);
            entity.Property(e => e.CardLastName).HasMaxLength(500);
            entity.Property(e => e.CardStatus).HasMaxLength(500);
            entity.Property(e => e.Category).HasMaxLength(500);
            entity.Property(e => e.ClubMembershipId).HasColumnName("ClubMembershipID");
            entity.Property(e => e.ClubNativeId)
                .HasMaxLength(500)
                .HasColumnName("ClubNativeID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName).HasMaxLength(500);
            entity.Property(e => e.Country).HasMaxLength(500);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(500)
                .HasColumnName("CustomerID");
            entity.Property(e => e.DateofBirth).HasMaxLength(500);
            entity.Property(e => e.DeliveryType).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(500);
            entity.Property(e => e.EmpAcctStatus).HasColumnName("EMP_AcctStatus");
            entity.Property(e => e.EmpCredit)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("EMP_Credit");
            entity.Property(e => e.EmpDisplayOrder).HasColumnName("EMP_DisplayOrder");
            entity.Property(e => e.EmpErrorCode)
                .HasMaxLength(200)
                .HasColumnName("EMP_ErrorCode");
            entity.Property(e => e.EmpGender)
                .HasMaxLength(200)
                .HasColumnName("EMP_Gender");
            entity.Property(e => e.EmpGroupId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupId");
            entity.Property(e => e.EmpGroupUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupUserId");
            entity.Property(e => e.EmpIsCardOnly).HasColumnName("EMP_IsCardOnly");
            entity.Property(e => e.EmpIsMain)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_IsMain");
            entity.Property(e => e.EmpLoginAcctStatus).HasColumnName("EMP_LoginAcctStatus");
            entity.Property(e => e.EmpParticipantId).HasColumnName("EMP_ParticipantId");
            entity.Property(e => e.EmpProgramId).HasColumnName("EMP_ProgramId");
            entity.Property(e => e.EmpProgramName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ProgramName");
            entity.Property(e => e.EmpRecordInActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_RecordInActive");
            entity.Property(e => e.EmpRecordType)
                .HasMaxLength(200)
                .HasColumnName("EMP_RecordType");
            entity.Property(e => e.EmpRecordTypeFf)
                .HasMaxLength(200)
                .HasColumnName("EMP_RecordTypeFF");
            entity.Property(e => e.EmpRedeemed).HasColumnName("EMP_Redeemed");
            entity.Property(e => e.EmpSeasonId).HasColumnName("EMP_SeasonID");
            entity.Property(e => e.EmpShopName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ShopName");
            entity.Property(e => e.EmpUniqueKey)
                .HasMaxLength(500)
                .HasColumnName("EMP_UniqueKey");
            entity.Property(e => e.EmpUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_UserId");
            entity.Property(e => e.EmpUserTypeId).HasColumnName("EMP_UserTypeId");
            entity.Property(e => e.EmpUsername)
                .HasMaxLength(200)
                .HasColumnName("EMP_Username");
            entity.Property(e => e.EmpXmlData)
                .HasColumnType("xml")
                .HasColumnName("EMP_XmlData");
            entity.Property(e => e.Gate1).HasMaxLength(500);
            entity.Property(e => e.MemberExpiry).HasMaxLength(500);
            entity.Property(e => e.MemberType).HasMaxLength(500);
            entity.Property(e => e.Membersince).HasMaxLength(500);
            entity.Property(e => e.OrderId)
                .HasMaxLength(500)
                .HasColumnName("OrderID");
            entity.Property(e => e.OrderlineId)
                .HasMaxLength(500)
                .HasColumnName("OrderlineID");
            entity.Property(e => e.OrderlineItemIdguid)
                .HasMaxLength(500)
                .HasColumnName("OrderlineItemIDGuid");
            entity.Property(e => e.OrganisationId)
                .HasMaxLength(500)
                .HasColumnName("OrganisationID");
            entity.Property(e => e.Package).HasMaxLength(500);
            entity.Property(e => e.PahaddressLine1)
                .HasMaxLength(500)
                .HasColumnName("PAHAddressLine1");
            entity.Property(e => e.PahaddressLine2)
                .HasMaxLength(500)
                .HasColumnName("PAHAddressLine2");
            entity.Property(e => e.PahclubMembershipId).HasColumnName("PAHClubMembershipID");
            entity.Property(e => e.PahclubNativeId)
                .HasMaxLength(500)
                .HasColumnName("PAHClubNativeID");
            entity.Property(e => e.PahcompanyName)
                .HasMaxLength(500)
                .HasColumnName("PAHCompanyName");
            entity.Property(e => e.Pahcountry)
                .HasMaxLength(500)
                .HasColumnName("PAHCountry");
            entity.Property(e => e.PahcustomerId)
                .HasMaxLength(500)
                .HasColumnName("PAHCustomerID");
            entity.Property(e => e.Pahemail)
                .HasMaxLength(500)
                .HasColumnName("PAHEmail");
            entity.Property(e => e.PahfirstName)
                .HasMaxLength(500)
                .HasColumnName("PAHFirstName");
            entity.Property(e => e.PahlastName)
                .HasMaxLength(500)
                .HasColumnName("PAHLastName");
            entity.Property(e => e.PahpostCode)
                .HasMaxLength(500)
                .HasColumnName("PAHPostCode");
            entity.Property(e => e.PahprimaryPhone)
                .HasMaxLength(500)
                .HasColumnName("PAHPrimaryPhone");
            entity.Property(e => e.Pahsalutation)
                .HasMaxLength(500)
                .HasColumnName("PAHSalutation");
            entity.Property(e => e.Pahstate)
                .HasMaxLength(500)
                .HasColumnName("PAHState");
            entity.Property(e => e.PahsuburbCity)
                .HasMaxLength(500)
                .HasColumnName("PAHSuburb_City");
            entity.Property(e => e.PaxCardNo).HasMaxLength(500);
            entity.Property(e => e.PaymentOption).HasMaxLength(500);
            entity.Property(e => e.PostCode).HasMaxLength(500);
            entity.Property(e => e.PriceType).HasMaxLength(500);
            entity.Property(e => e.PriceTypePrintName).HasMaxLength(500);
            entity.Property(e => e.ProcessMethod)
                .HasMaxLength(500)
                .HasColumnName("Process_method");
            entity.Property(e => e.Row1).HasMaxLength(500);
            entity.Property(e => e.RunNumber).HasMaxLength(500);
            entity.Property(e => e.Seat1).HasMaxLength(500);
            entity.Property(e => e.SeatingType).HasMaxLength(500);
            entity.Property(e => e.Section1).HasMaxLength(500);
            entity.Property(e => e.State).HasMaxLength(500);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.SuburbCity)
                .HasMaxLength(500)
                .HasColumnName("Suburb_City");
            entity.Property(e => e.UniqueCode)
                .HasMaxLength(500)
                .HasColumnName("unique_code");
            entity.Property(e => e.Uniqueid).HasMaxLength(500);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Venue1).HasMaxLength(500);
        });

        modelBuilder.Entity<RawData18051202210070936501890>(entity =>
        {
            entity.ToTable("RawData_180_51_202210070936501890");

            entity.Property(e => e.AccName)
                .HasMaxLength(500)
                .HasColumnName("acc_name");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("amount");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeliveryAddressLine1).HasMaxLength(500);
            entity.Property(e => e.DeliveryAddressLine2).HasMaxLength(500);
            entity.Property(e => e.DeliveryAddressLine3).HasMaxLength(500);
            entity.Property(e => e.DeliveryCompanyName).HasMaxLength(500);
            entity.Property(e => e.DeliveryCountry).HasMaxLength(500);
            entity.Property(e => e.DeliveryEmail).HasMaxLength(500);
            entity.Property(e => e.DeliveryFirstName).HasMaxLength(500);
            entity.Property(e => e.DeliveryLastName).HasMaxLength(500);
            entity.Property(e => e.DeliveryPhone).HasMaxLength(500);
            entity.Property(e => e.DeliveryPostcode).HasMaxLength(500);
            entity.Property(e => e.DeliveryState).HasMaxLength(500);
            entity.Property(e => e.DeliverySuburb).HasMaxLength(500);
            entity.Property(e => e.Email)
                .HasMaxLength(500)
                .HasColumnName("email");
            entity.Property(e => e.EmpAcctStatus).HasColumnName("EMP_AcctStatus");
            entity.Property(e => e.EmpCredit)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("EMP_Credit");
            entity.Property(e => e.EmpDisplayOrder).HasColumnName("EMP_DisplayOrder");
            entity.Property(e => e.EmpErrorCode)
                .HasMaxLength(200)
                .HasColumnName("EMP_ErrorCode");
            entity.Property(e => e.EmpGender)
                .HasMaxLength(200)
                .HasColumnName("EMP_Gender");
            entity.Property(e => e.EmpGroupId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupId");
            entity.Property(e => e.EmpGroupUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupUserId");
            entity.Property(e => e.EmpIsCardOnly).HasColumnName("EMP_IsCardOnly");
            entity.Property(e => e.EmpIsMain)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_IsMain");
            entity.Property(e => e.EmpLoginAcctStatus).HasColumnName("EMP_LoginAcctStatus");
            entity.Property(e => e.EmpParticipantId).HasColumnName("EMP_ParticipantId");
            entity.Property(e => e.EmpProgramId).HasColumnName("EMP_ProgramId");
            entity.Property(e => e.EmpProgramName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ProgramName");
            entity.Property(e => e.EmpRecordInActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_RecordInActive");
            entity.Property(e => e.EmpRecordType)
                .HasMaxLength(200)
                .HasColumnName("EMP_RecordType");
            entity.Property(e => e.EmpRedeemed).HasColumnName("EMP_Redeemed");
            entity.Property(e => e.EmpSeasonId).HasColumnName("EMP_SeasonID");
            entity.Property(e => e.EmpShopName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ShopName");
            entity.Property(e => e.EmpUniqueKey)
                .HasMaxLength(300)
                .HasColumnName("EMP_UniqueKey");
            entity.Property(e => e.EmpUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_UserId");
            entity.Property(e => e.EmpUserTypeId).HasColumnName("EMP_UserTypeId");
            entity.Property(e => e.EmpUsername)
                .HasMaxLength(200)
                .HasColumnName("EMP_Username");
            entity.Property(e => e.EmpXmlData)
                .HasColumnType("xml")
                .HasColumnName("EMP_XmlData");
            entity.Property(e => e.Entitlement)
                .HasMaxLength(500)
                .HasColumnName("entitlement");
            entity.Property(e => e.OtherInfo1)
                .HasMaxLength(500)
                .HasColumnName("other_info1");
            entity.Property(e => e.OtherInfo2)
                .HasMaxLength(500)
                .HasColumnName("other_info2");
            entity.Property(e => e.OtherInfo3)
                .HasMaxLength(500)
                .HasColumnName("other_info3");
            entity.Property(e => e.OtherInfo4)
                .HasMaxLength(500)
                .HasColumnName("other_info4");
            entity.Property(e => e.ParentState)
                .HasMaxLength(500)
                .HasColumnName("parent_state");
            entity.Property(e => e.RecordType)
                .HasMaxLength(500)
                .HasColumnName("record_type");
            entity.Property(e => e.RegionId)
                .HasMaxLength(500)
                .HasColumnName("region_ID");
            entity.Property(e => e.RegionName)
                .HasMaxLength(500)
                .HasColumnName("region_Name");
            entity.Property(e => e.Source)
                .HasMaxLength(500)
                .HasColumnName("source");
            entity.Property(e => e.SourceId)
                .HasMaxLength(500)
                .HasColumnName("source_id");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserType)
                .HasMaxLength(500)
                .HasColumnName("user_type");
        });

        modelBuilder.Entity<RawData18054202210060315031424>(entity =>
        {
            entity.ToTable("RawData_180_54_202210060315031424");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeliveryAddressLine1).HasMaxLength(500);
            entity.Property(e => e.DeliveryAddressLine2).HasMaxLength(500);
            entity.Property(e => e.DeliveryAddressLine3).HasMaxLength(500);
            entity.Property(e => e.DeliveryCompanyName).HasMaxLength(500);
            entity.Property(e => e.DeliveryCountry).HasMaxLength(500);
            entity.Property(e => e.DeliveryEmail).HasMaxLength(500);
            entity.Property(e => e.DeliveryFirstName).HasMaxLength(500);
            entity.Property(e => e.DeliveryLastName).HasMaxLength(500);
            entity.Property(e => e.DeliveryPhone).HasMaxLength(500);
            entity.Property(e => e.DeliveryPostcode).HasMaxLength(500);
            entity.Property(e => e.DeliveryState).HasMaxLength(500);
            entity.Property(e => e.DeliverySuburb).HasMaxLength(500);
            entity.Property(e => e.EmpAcctStatus).HasColumnName("EMP_AcctStatus");
            entity.Property(e => e.EmpCredit)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("EMP_Credit");
            entity.Property(e => e.EmpDisplayOrder).HasColumnName("EMP_DisplayOrder");
            entity.Property(e => e.EmpErrorCode)
                .HasMaxLength(200)
                .HasColumnName("EMP_ErrorCode");
            entity.Property(e => e.EmpGender)
                .HasMaxLength(200)
                .HasColumnName("EMP_Gender");
            entity.Property(e => e.EmpGroupId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupId");
            entity.Property(e => e.EmpGroupUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupUserId");
            entity.Property(e => e.EmpIsCardOnly).HasColumnName("EMP_IsCardOnly");
            entity.Property(e => e.EmpIsMain)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_IsMain");
            entity.Property(e => e.EmpLoginAcctStatus).HasColumnName("EMP_LoginAcctStatus");
            entity.Property(e => e.EmpParticipantId).HasColumnName("EMP_ParticipantId");
            entity.Property(e => e.EmpProgramId).HasColumnName("EMP_ProgramId");
            entity.Property(e => e.EmpProgramName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ProgramName");
            entity.Property(e => e.EmpRecordInActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_RecordInActive");
            entity.Property(e => e.EmpRecordType)
                .HasMaxLength(200)
                .HasColumnName("EMP_RecordType");
            entity.Property(e => e.EmpRedeemed).HasColumnName("EMP_Redeemed");
            entity.Property(e => e.EmpSeasonId).HasColumnName("EMP_SeasonID");
            entity.Property(e => e.EmpShopName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ShopName");
            entity.Property(e => e.EmpUniqueKey)
                .HasMaxLength(300)
                .HasColumnName("EMP_UniqueKey");
            entity.Property(e => e.EmpUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_UserId");
            entity.Property(e => e.EmpUserTypeId).HasColumnName("EMP_UserTypeId");
            entity.Property(e => e.EmpUsername)
                .HasMaxLength(200)
                .HasColumnName("EMP_Username");
            entity.Property(e => e.EmpXmlData)
                .HasColumnType("xml")
                .HasColumnName("EMP_XmlData");
            entity.Property(e => e.OrgId)
                .HasMaxLength(500)
                .HasColumnName("OrgID");
            entity.Property(e => e.OrgName).HasMaxLength(500);
            entity.Property(e => e.OrgType).HasMaxLength(500);
            entity.Property(e => e.OtherInfo1)
                .HasMaxLength(500)
                .HasColumnName("other_info1");
            entity.Property(e => e.OtherInfo2)
                .HasMaxLength(500)
                .HasColumnName("other_info2");
            entity.Property(e => e.OtherInfo3)
                .HasMaxLength(500)
                .HasColumnName("other_info3");
            entity.Property(e => e.OtherInfo4)
                .HasMaxLength(500)
                .HasColumnName("other_info4");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<RawData18055202210070221244160>(entity =>
        {
            entity.ToTable("RawData_180_55_202210070221244160");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeliveryAddressLine1).HasMaxLength(500);
            entity.Property(e => e.DeliveryAddressLine2).HasMaxLength(500);
            entity.Property(e => e.DeliveryAddressLine3).HasMaxLength(500);
            entity.Property(e => e.DeliveryCompanyName).HasMaxLength(500);
            entity.Property(e => e.DeliveryCountry).HasMaxLength(500);
            entity.Property(e => e.DeliveryEmail).HasMaxLength(500);
            entity.Property(e => e.DeliveryFirstName).HasMaxLength(500);
            entity.Property(e => e.DeliveryLastName).HasMaxLength(500);
            entity.Property(e => e.DeliveryPhone).HasMaxLength(500);
            entity.Property(e => e.DeliveryPostcode).HasMaxLength(500);
            entity.Property(e => e.DeliveryState).HasMaxLength(500);
            entity.Property(e => e.DeliverySuburb).HasMaxLength(500);
            entity.Property(e => e.EmpAcctStatus).HasColumnName("EMP_AcctStatus");
            entity.Property(e => e.EmpCredit)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("EMP_Credit");
            entity.Property(e => e.EmpDisplayOrder).HasColumnName("EMP_DisplayOrder");
            entity.Property(e => e.EmpErrorCode)
                .HasMaxLength(200)
                .HasColumnName("EMP_ErrorCode");
            entity.Property(e => e.EmpGender)
                .HasMaxLength(200)
                .HasColumnName("EMP_Gender");
            entity.Property(e => e.EmpGroupId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupId");
            entity.Property(e => e.EmpGroupUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupUserId");
            entity.Property(e => e.EmpIsCardOnly).HasColumnName("EMP_IsCardOnly");
            entity.Property(e => e.EmpIsMain)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_IsMain");
            entity.Property(e => e.EmpLoginAcctStatus).HasColumnName("EMP_LoginAcctStatus");
            entity.Property(e => e.EmpParticipantId).HasColumnName("EMP_ParticipantId");
            entity.Property(e => e.EmpProgramId).HasColumnName("EMP_ProgramId");
            entity.Property(e => e.EmpProgramName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ProgramName");
            entity.Property(e => e.EmpRecordInActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_RecordInActive");
            entity.Property(e => e.EmpRecordType)
                .HasMaxLength(200)
                .HasColumnName("EMP_RecordType");
            entity.Property(e => e.EmpRedeemed).HasColumnName("EMP_Redeemed");
            entity.Property(e => e.EmpSeasonId).HasColumnName("EMP_SeasonID");
            entity.Property(e => e.EmpShopName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ShopName");
            entity.Property(e => e.EmpUniqueKey)
                .HasMaxLength(300)
                .HasColumnName("EMP_UniqueKey");
            entity.Property(e => e.EmpUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_UserId");
            entity.Property(e => e.EmpUserTypeId).HasColumnName("EMP_UserTypeId");
            entity.Property(e => e.EmpUsername)
                .HasMaxLength(200)
                .HasColumnName("EMP_Username");
            entity.Property(e => e.EmpXmlData)
                .HasColumnType("xml")
                .HasColumnName("EMP_XmlData");
            entity.Property(e => e.EntityId)
                .HasMaxLength(500)
                .HasColumnName("EntityID");
            entity.Property(e => e.EntityName).HasMaxLength(500);
            entity.Property(e => e.EntityTenure).HasMaxLength(500);
            entity.Property(e => e.EntityType).HasMaxLength(500);
            entity.Property(e => e.OrgId)
                .HasMaxLength(500)
                .HasColumnName("OrgID");
            entity.Property(e => e.PrevYearParticipants).HasMaxLength(500);
            entity.Property(e => e.RegionId)
                .HasMaxLength(500)
                .HasColumnName("RegionID");
            entity.Property(e => e.RegionName).HasMaxLength(500);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<RawData18056202210071101504644>(entity =>
        {
            entity.ToTable("RawData_180_56_202210071101504644");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CoordinatorFirstName).HasMaxLength(500);
            entity.Property(e => e.CoordinatorId)
                .HasMaxLength(500)
                .HasColumnName("CoordinatorID");
            entity.Property(e => e.CoordinatorLastName).HasMaxLength(500);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeliveryAddressLine1).HasMaxLength(500);
            entity.Property(e => e.DeliveryAddressLine2).HasMaxLength(500);
            entity.Property(e => e.DeliveryAddressLine3).HasMaxLength(500);
            entity.Property(e => e.DeliveryCompanyName).HasMaxLength(500);
            entity.Property(e => e.DeliveryCountry).HasMaxLength(500);
            entity.Property(e => e.DeliveryEmail).HasMaxLength(500);
            entity.Property(e => e.DeliveryFirstName).HasMaxLength(500);
            entity.Property(e => e.DeliveryLastName).HasMaxLength(500);
            entity.Property(e => e.DeliveryPhone).HasMaxLength(500);
            entity.Property(e => e.DeliveryPostcode).HasMaxLength(500);
            entity.Property(e => e.DeliveryState).HasMaxLength(500);
            entity.Property(e => e.DeliverySuburb).HasMaxLength(500);
            entity.Property(e => e.EmpAcctStatus).HasColumnName("EMP_AcctStatus");
            entity.Property(e => e.EmpCredit)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("EMP_Credit");
            entity.Property(e => e.EmpDisplayOrder).HasColumnName("EMP_DisplayOrder");
            entity.Property(e => e.EmpErrorCode)
                .HasMaxLength(200)
                .HasColumnName("EMP_ErrorCode");
            entity.Property(e => e.EmpGender)
                .HasMaxLength(200)
                .HasColumnName("EMP_Gender");
            entity.Property(e => e.EmpGroupId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupId");
            entity.Property(e => e.EmpGroupUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupUserId");
            entity.Property(e => e.EmpIsCardOnly).HasColumnName("EMP_IsCardOnly");
            entity.Property(e => e.EmpIsMain)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_IsMain");
            entity.Property(e => e.EmpLoginAcctStatus).HasColumnName("EMP_LoginAcctStatus");
            entity.Property(e => e.EmpParticipantId).HasColumnName("EMP_ParticipantId");
            entity.Property(e => e.EmpProgramId).HasColumnName("EMP_ProgramId");
            entity.Property(e => e.EmpProgramName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ProgramName");
            entity.Property(e => e.EmpRecordInActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_RecordInActive");
            entity.Property(e => e.EmpRecordType)
                .HasMaxLength(200)
                .HasColumnName("EMP_RecordType");
            entity.Property(e => e.EmpRedeemed).HasColumnName("EMP_Redeemed");
            entity.Property(e => e.EmpSeasonId).HasColumnName("EMP_SeasonID");
            entity.Property(e => e.EmpShopName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ShopName");
            entity.Property(e => e.EmpUniqueKey)
                .HasMaxLength(300)
                .HasColumnName("EMP_UniqueKey");
            entity.Property(e => e.EmpUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_UserId");
            entity.Property(e => e.EmpUserTypeId).HasColumnName("EMP_UserTypeId");
            entity.Property(e => e.EmpUsername)
                .HasMaxLength(200)
                .HasColumnName("EMP_Username");
            entity.Property(e => e.EmpXmlData)
                .HasColumnType("xml")
                .HasColumnName("EMP_XmlData");
            entity.Property(e => e.EntityId)
                .HasMaxLength(500)
                .HasColumnName("EntityID");
            entity.Property(e => e.FinishDate).HasColumnType("datetime");
            entity.Property(e => e.OtherInfo1)
                .HasMaxLength(500)
                .HasColumnName("other_info1");
            entity.Property(e => e.OtherInfo2)
                .HasMaxLength(500)
                .HasColumnName("other_info2");
            entity.Property(e => e.OtherInfo3)
                .HasMaxLength(500)
                .HasColumnName("other_info3");
            entity.Property(e => e.OtherInfo4)
                .HasMaxLength(500)
                .HasColumnName("other_info4");
            entity.Property(e => e.ProgramId)
                .HasMaxLength(500)
                .HasColumnName("ProgramID");
            entity.Property(e => e.ProgramName).HasMaxLength(500);
            entity.Property(e => e.ProgramTerm).HasMaxLength(500);
            entity.Property(e => e.ProgramType).HasMaxLength(500);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.VenueAddressLine1).HasMaxLength(500);
            entity.Property(e => e.VenueAddressLine2).HasMaxLength(500);
            entity.Property(e => e.VenueAddressLine3).HasMaxLength(500);
            entity.Property(e => e.VenueCountry).HasMaxLength(500);
            entity.Property(e => e.VenuePostcode).HasMaxLength(500);
            entity.Property(e => e.VenueState).HasMaxLength(500);
            entity.Property(e => e.VenueSuburb).HasMaxLength(500);
        });

        modelBuilder.Entity<RawData18058202210100330084519>(entity =>
        {
            entity.ToTable("RawData_180_58_202210100330084519");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeliveryAddressLine1).HasMaxLength(500);
            entity.Property(e => e.DeliveryAddressLine2).HasMaxLength(500);
            entity.Property(e => e.DeliveryAddressLine3).HasMaxLength(500);
            entity.Property(e => e.DeliveryCompanyName).HasMaxLength(500);
            entity.Property(e => e.DeliveryCountry).HasMaxLength(500);
            entity.Property(e => e.DeliveryEmail).HasMaxLength(500);
            entity.Property(e => e.DeliveryFirstName).HasMaxLength(500);
            entity.Property(e => e.DeliveryLastName).HasMaxLength(500);
            entity.Property(e => e.DeliveryPhone).HasMaxLength(500);
            entity.Property(e => e.DeliveryPostcode).HasMaxLength(500);
            entity.Property(e => e.DeliveryState).HasMaxLength(500);
            entity.Property(e => e.DeliverySuburb).HasMaxLength(500);
            entity.Property(e => e.EmpAcctStatus).HasColumnName("EMP_AcctStatus");
            entity.Property(e => e.EmpCredit)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("EMP_Credit");
            entity.Property(e => e.EmpDisplayOrder).HasColumnName("EMP_DisplayOrder");
            entity.Property(e => e.EmpErrorCode)
                .HasMaxLength(200)
                .HasColumnName("EMP_ErrorCode");
            entity.Property(e => e.EmpGender)
                .HasMaxLength(200)
                .HasColumnName("EMP_Gender");
            entity.Property(e => e.EmpGroupId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupId");
            entity.Property(e => e.EmpGroupUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupUserId");
            entity.Property(e => e.EmpIsCardOnly).HasColumnName("EMP_IsCardOnly");
            entity.Property(e => e.EmpIsMain)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_IsMain");
            entity.Property(e => e.EmpLoginAcctStatus).HasColumnName("EMP_LoginAcctStatus");
            entity.Property(e => e.EmpParticipantId).HasColumnName("EMP_ParticipantId");
            entity.Property(e => e.EmpProgramId).HasColumnName("EMP_ProgramId");
            entity.Property(e => e.EmpProgramName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ProgramName");
            entity.Property(e => e.EmpRecordInActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_RecordInActive");
            entity.Property(e => e.EmpRecordType)
                .HasMaxLength(200)
                .HasColumnName("EMP_RecordType");
            entity.Property(e => e.EmpRedeemed).HasColumnName("EMP_Redeemed");
            entity.Property(e => e.EmpSeasonId).HasColumnName("EMP_SeasonID");
            entity.Property(e => e.EmpShopName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ShopName");
            entity.Property(e => e.EmpUniqueKey)
                .HasMaxLength(300)
                .HasColumnName("EMP_UniqueKey");
            entity.Property(e => e.EmpUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_UserId");
            entity.Property(e => e.EmpUserTypeId).HasColumnName("EMP_UserTypeId");
            entity.Property(e => e.EmpUsername)
                .HasMaxLength(200)
                .HasColumnName("EMP_Username");
            entity.Property(e => e.EmpXmlData)
                .HasColumnType("xml")
                .HasColumnName("EMP_XmlData");
            entity.Property(e => e.EntityId)
                .HasMaxLength(500)
                .HasColumnName("EntityID");
            entity.Property(e => e.EntityName).HasMaxLength(500);
            entity.Property(e => e.EntityTenure).HasMaxLength(500);
            entity.Property(e => e.EntityType).HasMaxLength(500);
            entity.Property(e => e.FirstActiveSeason).HasMaxLength(500);
            entity.Property(e => e.OrgId)
                .HasMaxLength(500)
                .HasColumnName("OrgID");
            entity.Property(e => e.PrevYearParticipants).HasMaxLength(500);
            entity.Property(e => e.RegionId)
                .HasMaxLength(500)
                .HasColumnName("RegionID");
            entity.Property(e => e.RegionName).HasMaxLength(500);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<RawData18069202210121014405186>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_RawData_180_57_202210121014405186");

            entity.ToTable("RawData_180_69_202210121014405186");

            entity.Property(e => e.AccountId)
                .HasMaxLength(500)
                .HasColumnName("AccountID");
            entity.Property(e => e.AccountType).HasMaxLength(500);
            entity.Property(e => e.BarcodeAdditional)
                .HasMaxLength(500)
                .HasColumnName("barcode_additional");
            entity.Property(e => e.BarcodeAdditional2)
                .HasMaxLength(500)
                .HasColumnName("barcode_additional2");
            entity.Property(e => e.BarcodePrintCount)
                .HasMaxLength(500)
                .HasColumnName("barcode_print_count");
            entity.Property(e => e.BarcodePrintDate)
                .HasMaxLength(500)
                .HasColumnName("barcode_print_date");
            entity.Property(e => e.BarcodeValue)
                .HasMaxLength(500)
                .HasColumnName("barcode_value");
            entity.Property(e => e.BirthDate).HasColumnType("datetime");
            entity.Property(e => e.Category).HasMaxLength(500);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DeliveryAddressLine1).HasMaxLength(500);
            entity.Property(e => e.DeliveryAddressLine2).HasMaxLength(500);
            entity.Property(e => e.DeliveryAddressLine3).HasMaxLength(500);
            entity.Property(e => e.DeliveryCompanyName).HasMaxLength(500);
            entity.Property(e => e.DeliveryCountry).HasMaxLength(500);
            entity.Property(e => e.DeliveryEmail).HasMaxLength(500);
            entity.Property(e => e.DeliveryFirstName).HasMaxLength(500);
            entity.Property(e => e.DeliveryLastName).HasMaxLength(500);
            entity.Property(e => e.DeliveryPhone).HasMaxLength(500);
            entity.Property(e => e.DeliveryPostcode).HasMaxLength(500);
            entity.Property(e => e.DeliveryState).HasMaxLength(500);
            entity.Property(e => e.DeliverySuburb).HasMaxLength(500);
            entity.Property(e => e.EmpAcctStatus).HasColumnName("EMP_AcctStatus");
            entity.Property(e => e.EmpCredit)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("EMP_Credit");
            entity.Property(e => e.EmpDisplayOrder).HasColumnName("EMP_DisplayOrder");
            entity.Property(e => e.EmpErrorCode)
                .HasMaxLength(200)
                .HasColumnName("EMP_ErrorCode");
            entity.Property(e => e.EmpGender)
                .HasMaxLength(200)
                .HasColumnName("EMP_Gender");
            entity.Property(e => e.EmpGroupId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupId");
            entity.Property(e => e.EmpGroupUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupUserId");
            entity.Property(e => e.EmpIsCardOnly).HasColumnName("EMP_IsCardOnly");
            entity.Property(e => e.EmpIsMain)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_IsMain");
            entity.Property(e => e.EmpLoginAcctStatus).HasColumnName("EMP_LoginAcctStatus");
            entity.Property(e => e.EmpParticipantId).HasColumnName("EMP_ParticipantId");
            entity.Property(e => e.EmpProgramId).HasColumnName("EMP_ProgramId");
            entity.Property(e => e.EmpProgramName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ProgramName");
            entity.Property(e => e.EmpRecordInActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_RecordInActive");
            entity.Property(e => e.EmpRecordType)
                .HasMaxLength(200)
                .HasColumnName("EMP_RecordType");
            entity.Property(e => e.EmpRedeemed).HasColumnName("EMP_Redeemed");
            entity.Property(e => e.EmpSeasonId).HasColumnName("EMP_SeasonID");
            entity.Property(e => e.EmpShopName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ShopName");
            entity.Property(e => e.EmpUniqueKey)
                .HasMaxLength(500)
                .HasColumnName("EMP_UniqueKey");
            entity.Property(e => e.EmpUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_UserId");
            entity.Property(e => e.EmpUserTypeId).HasColumnName("EMP_UserTypeId");
            entity.Property(e => e.EmpUsername)
                .HasMaxLength(200)
                .HasColumnName("EMP_Username");
            entity.Property(e => e.EmpXmlData)
                .HasColumnType("xml")
                .HasColumnName("EMP_XmlData");
            entity.Property(e => e.EntityId)
                .HasMaxLength(500)
                .HasColumnName("EntityID");
            entity.Property(e => e.EntityName).HasMaxLength(500);
            entity.Property(e => e.EntityType).HasMaxLength(500);
            entity.Property(e => e.ExternalLinkId)
                .HasMaxLength(500)
                .HasColumnName("External_linkID");
            entity.Property(e => e.ExternalLinkType)
                .HasMaxLength(500)
                .HasColumnName("External_linkType");
            entity.Property(e => e.FirstName).HasMaxLength(500);
            entity.Property(e => e.Gender).HasMaxLength(500);
            entity.Property(e => e.LastName).HasMaxLength(500);
            entity.Property(e => e.MemberId)
                .HasMaxLength(500)
                .HasColumnName("member_ID");
            entity.Property(e => e.MemberSinceConsecutive)
                .HasMaxLength(500)
                .HasColumnName("member_since_consecutive");
            entity.Property(e => e.MemberSinceFirst)
                .HasMaxLength(500)
                .HasColumnName("member_since_first");
            entity.Property(e => e.MemberYearsConsecutive)
                .HasMaxLength(500)
                .HasColumnName("member_years_consecutive");
            entity.Property(e => e.MemberYearsTotal)
                .HasMaxLength(500)
                .HasColumnName("member_years_total");
            entity.Property(e => e.MemberYearsUpdated)
                .HasMaxLength(500)
                .HasColumnName("member_years_updated");
            entity.Property(e => e.Notes).HasMaxLength(500);
            entity.Property(e => e.OrderComplimentary)
                .HasMaxLength(500)
                .HasColumnName("order_complimentary");
            entity.Property(e => e.OrderDate)
                .HasMaxLength(500)
                .HasColumnName("order_date");
            entity.Property(e => e.OrderDeliveryHistory)
                .HasMaxLength(500)
                .HasColumnName("order_delivery_history");
            entity.Property(e => e.OrderDeliveryNote)
                .HasMaxLength(500)
                .HasColumnName("order_delivery_note");
            entity.Property(e => e.OrderDiscount)
                .HasMaxLength(500)
                .HasColumnName("order_discount");
            entity.Property(e => e.OrderId)
                .HasMaxLength(500)
                .HasColumnName("OrderID");
            entity.Property(e => e.OrderLineItem)
                .HasMaxLength(500)
                .HasColumnName("order_LineItem");
            entity.Property(e => e.OrderLineItemQty).HasColumnName("order_LineItem_QTY");
            entity.Property(e => e.OrderOnplan)
                .HasMaxLength(500)
                .HasColumnName("order_onplan");
            entity.Property(e => e.OrderPlantype)
                .HasMaxLength(500)
                .HasColumnName("order_plantype");
            entity.Property(e => e.OrgId)
                .HasMaxLength(500)
                .HasColumnName("OrgID");
            entity.Property(e => e.OrgName).HasMaxLength(500);
            entity.Property(e => e.OrgType).HasMaxLength(500);
            entity.Property(e => e.OtherInfo1).HasColumnName("other_info1");
            entity.Property(e => e.OtherInfo10)
                .HasMaxLength(500)
                .HasColumnName("other_info10");
            entity.Property(e => e.OtherInfo2)
                .HasMaxLength(500)
                .HasColumnName("other_info2");
            entity.Property(e => e.OtherInfo3)
                .HasMaxLength(500)
                .HasColumnName("other_info3");
            entity.Property(e => e.OtherInfo4)
                .HasMaxLength(500)
                .HasColumnName("other_info4");
            entity.Property(e => e.OtherInfo5)
                .HasMaxLength(500)
                .HasColumnName("other_info5");
            entity.Property(e => e.OtherInfo6)
                .HasMaxLength(500)
                .HasColumnName("other_info6");
            entity.Property(e => e.OtherInfo7)
                .HasMaxLength(500)
                .HasColumnName("other_info7");
            entity.Property(e => e.OtherInfo8)
                .HasMaxLength(500)
                .HasColumnName("other_info8");
            entity.Property(e => e.OtherInfo9)
                .HasMaxLength(500)
                .HasColumnName("other_info9");
            entity.Property(e => e.ParentFirstName).HasMaxLength(500);
            entity.Property(e => e.ParentLastName).HasMaxLength(500);
            entity.Property(e => e.ParticipantId)
                .HasMaxLength(500)
                .HasColumnName("ParticipantID");
            entity.Property(e => e.ParticipantRawId).HasColumnName("ParticipantRawID");
            entity.Property(e => e.ParticipantType).HasMaxLength(500);
            entity.Property(e => e.ProductCategory)
                .HasMaxLength(500)
                .HasColumnName("product_category");
            entity.Property(e => e.ProductChoice1)
                .HasMaxLength(500)
                .HasColumnName("product_choice1");
            entity.Property(e => e.ProductChoice2)
                .HasMaxLength(500)
                .HasColumnName("product_choice2");
            entity.Property(e => e.ProductDescription)
                .HasMaxLength(500)
                .HasColumnName("product_description");
            entity.Property(e => e.ProductId)
                .HasMaxLength(500)
                .HasColumnName("product_ID");
            entity.Property(e => e.ProductName)
                .HasMaxLength(500)
                .HasColumnName("product_name");
            entity.Property(e => e.ProductPackage)
                .HasMaxLength(500)
                .HasColumnName("product_package");
            entity.Property(e => e.ProductPricetype)
                .HasMaxLength(500)
                .HasColumnName("product_pricetype");
            entity.Property(e => e.ProductPrintvalue)
                .HasMaxLength(500)
                .HasColumnName("product_printvalue");
            entity.Property(e => e.ProductSpecialtext)
                .HasMaxLength(500)
                .HasColumnName("product_specialtext");
            entity.Property(e => e.ProductTickettype)
                .HasMaxLength(500)
                .HasColumnName("product_tickettype");
            entity.Property(e => e.ProgramId)
                .HasMaxLength(500)
                .HasColumnName("ProgramID");
            entity.Property(e => e.ProgramName).HasMaxLength(500);
            entity.Property(e => e.ProgramType).HasMaxLength(500);
            entity.Property(e => e.RtsAddressline1)
                .HasMaxLength(500)
                .HasColumnName("rts_addressline1");
            entity.Property(e => e.RtsAddressline2)
                .HasMaxLength(500)
                .HasColumnName("rts_addressline2");
            entity.Property(e => e.RtsCompanyname)
                .HasMaxLength(500)
                .HasColumnName("rts_companyname");
            entity.Property(e => e.RtsCountry)
                .HasMaxLength(500)
                .HasColumnName("rts_country");
            entity.Property(e => e.RtsFullname)
                .HasMaxLength(500)
                .HasColumnName("rts_fullname");
            entity.Property(e => e.RtsPostcode)
                .HasMaxLength(500)
                .HasColumnName("rts_postcode");
            entity.Property(e => e.RtsState)
                .HasMaxLength(500)
                .HasColumnName("rts_state");
            entity.Property(e => e.RtsSuburb)
                .HasMaxLength(500)
                .HasColumnName("rts_suburb");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(500);
            entity.Property(e => e.TranId).HasColumnName("TranID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Venue1Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue1_aisle");
            entity.Property(e => e.Venue1Fulldetail)
                .HasMaxLength(500)
                .HasColumnName("venue1_fulldetail");
            entity.Property(e => e.Venue1Gate)
                .HasMaxLength(500)
                .HasColumnName("venue1_gate");
            entity.Property(e => e.Venue1Name)
                .HasMaxLength(500)
                .HasColumnName("venue1_name");
            entity.Property(e => e.Venue1Row)
                .HasMaxLength(500)
                .HasColumnName("venue1_row");
            entity.Property(e => e.Venue1Seat)
                .HasMaxLength(500)
                .HasColumnName("venue1_seat");
            entity.Property(e => e.Venue1Section)
                .HasMaxLength(500)
                .HasColumnName("venue1_section");
            entity.Property(e => e.Venue1Stand)
                .HasMaxLength(500)
                .HasColumnName("venue1_stand");
            entity.Property(e => e.Venue2Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue2_aisle");
            entity.Property(e => e.Venue2Fulldetail)
                .HasMaxLength(500)
                .HasColumnName("venue2_fulldetail");
            entity.Property(e => e.Venue2Gate)
                .HasMaxLength(500)
                .HasColumnName("venue2_gate");
            entity.Property(e => e.Venue2Name)
                .HasMaxLength(500)
                .HasColumnName("venue2_name");
            entity.Property(e => e.Venue2Row)
                .HasMaxLength(500)
                .HasColumnName("venue2_row");
            entity.Property(e => e.Venue2Seat)
                .HasMaxLength(500)
                .HasColumnName("venue2_seat");
            entity.Property(e => e.Venue2Section)
                .HasMaxLength(500)
                .HasColumnName("venue2_section");
            entity.Property(e => e.Venue2Stand)
                .HasMaxLength(500)
                .HasColumnName("venue2_stand");
            entity.Property(e => e.Venue3Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue3_aisle");
            entity.Property(e => e.Venue3Fulldetail)
                .HasMaxLength(500)
                .HasColumnName("venue3_fulldetail");
            entity.Property(e => e.Venue3Gate)
                .HasMaxLength(500)
                .HasColumnName("venue3_gate");
            entity.Property(e => e.Venue3Name)
                .HasMaxLength(500)
                .HasColumnName("venue3_name");
            entity.Property(e => e.Venue3Row)
                .HasMaxLength(500)
                .HasColumnName("venue3_row");
            entity.Property(e => e.Venue3Seat)
                .HasMaxLength(500)
                .HasColumnName("venue3_seat");
            entity.Property(e => e.Venue3Section)
                .HasMaxLength(500)
                .HasColumnName("venue3_section");
            entity.Property(e => e.Venue3Stand)
                .HasMaxLength(500)
                .HasColumnName("venue3_stand");
            entity.Property(e => e.Venue4Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue4_aisle");
            entity.Property(e => e.Venue4Fulldetail)
                .HasMaxLength(500)
                .HasColumnName("venue4_fulldetail");
            entity.Property(e => e.Venue4Gate)
                .HasMaxLength(500)
                .HasColumnName("venue4_gate");
            entity.Property(e => e.Venue4Name)
                .HasMaxLength(500)
                .HasColumnName("venue4_name");
            entity.Property(e => e.Venue4Row)
                .HasMaxLength(500)
                .HasColumnName("venue4_row");
            entity.Property(e => e.Venue4Seat)
                .HasMaxLength(500)
                .HasColumnName("venue4_seat");
            entity.Property(e => e.Venue4Section)
                .HasMaxLength(500)
                .HasColumnName("venue4_section");
            entity.Property(e => e.Venue4Stand)
                .HasMaxLength(500)
                .HasColumnName("venue4_stand");
        });

        modelBuilder.Entity<RawData18152202210040302274183>(entity =>
        {
            entity.ToTable("RawData_181_52_202210040302274183");

            entity.HasIndex(e => e.EmpGroupId, "EMP_GroupID");

            entity.HasIndex(e => new { e.EmpUserId, e.UploadId }, "EMP_UserId");

            entity.HasIndex(e => e.UploadId, "UploadId");

            entity.Property(e => e.AcctId).HasColumnName("acct_id");
            entity.Property(e => e.AcctTypeDesc)
                .HasMaxLength(500)
                .HasColumnName("acct_type_desc");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Barcode)
                .HasMaxLength(500)
                .HasColumnName("barcode");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("birthdate");
            entity.Property(e => e.Card)
                .HasMaxLength(500)
                .HasColumnName("card");
            entity.Property(e => e.City)
                .HasMaxLength(500)
                .HasColumnName("city");
            entity.Property(e => e.ClubCode)
                .HasMaxLength(500)
                .HasColumnName("club_code");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(500)
                .HasColumnName("company_name");
            entity.Property(e => e.ConcessionText)
                .HasMaxLength(500)
                .HasColumnName("concession_text");
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .HasColumnName("country");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustNameId).HasColumnName("cust_name_id");
            entity.Property(e => e.DeliveryInstructions)
                .HasMaxLength(500)
                .HasColumnName("delivery_instructions");
            entity.Property(e => e.DeliveryMethodName)
                .HasMaxLength(500)
                .HasColumnName("delivery_method_name");
            entity.Property(e => e.EmailAddr)
                .HasMaxLength(500)
                .HasColumnName("email_addr");
            entity.Property(e => e.EmpAcctStatus).HasColumnName("EMP_AcctStatus");
            entity.Property(e => e.EmpCredit)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("EMP_Credit");
            entity.Property(e => e.EmpDisplayOrder).HasColumnName("EMP_DisplayOrder");
            entity.Property(e => e.EmpErrorCode)
                .HasMaxLength(200)
                .HasColumnName("EMP_ErrorCode");
            entity.Property(e => e.EmpExistsOldRaw)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_ExistsOldRaw");
            entity.Property(e => e.EmpGender)
                .HasMaxLength(200)
                .HasColumnName("EMP_Gender");
            entity.Property(e => e.EmpGroupId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupId");
            entity.Property(e => e.EmpGroupUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupUserId");
            entity.Property(e => e.EmpIsCardOnly).HasColumnName("EMP_IsCardOnly");
            entity.Property(e => e.EmpIsMain)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_IsMain");
            entity.Property(e => e.EmpLoginAcctStatus).HasColumnName("EMP_LoginAcctStatus");
            entity.Property(e => e.EmpParticipantId).HasColumnName("EMP_ParticipantId");
            entity.Property(e => e.EmpProgramId).HasColumnName("EMP_ProgramId");
            entity.Property(e => e.EmpProgramName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ProgramName");
            entity.Property(e => e.EmpRecordInActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_RecordInActive");
            entity.Property(e => e.EmpRecordType)
                .HasMaxLength(200)
                .HasColumnName("EMP_RecordType");
            entity.Property(e => e.EmpRedeemed).HasColumnName("EMP_Redeemed");
            entity.Property(e => e.EmpSeasonId).HasColumnName("EMP_SeasonID");
            entity.Property(e => e.EmpShopName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ShopName");
            entity.Property(e => e.EmpUniqueKey)
                .HasMaxLength(300)
                .HasColumnName("EMP_UniqueKey");
            entity.Property(e => e.EmpUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_UserId");
            entity.Property(e => e.EmpUserTypeId).HasColumnName("EMP_UserTypeId");
            entity.Property(e => e.EmpUsername)
                .HasMaxLength(200)
                .HasColumnName("EMP_Username");
            entity.Property(e => e.EmpXmlData)
                .HasColumnType("xml")
                .HasColumnName("EMP_XmlData");
            entity.Property(e => e.EventLine1)
                .HasMaxLength(500)
                .HasColumnName("event_line1");
            entity.Property(e => e.EventLine2)
                .HasMaxLength(500)
                .HasColumnName("event_line2");
            entity.Property(e => e.EventLine3)
                .HasMaxLength(500)
                .HasColumnName("event_line3");
            entity.Property(e => e.EventName)
                .HasMaxLength(500)
                .HasColumnName("event_name");
            entity.Property(e => e.FamilyId).HasColumnName("family_id");
            entity.Property(e => e.Fulfilment)
                .HasMaxLength(500)
                .HasColumnName("fulfilment");
            entity.Property(e => e.FulfilmentChoice)
                .HasMaxLength(500)
                .HasColumnName("fulfilment_choice");
            entity.Property(e => e.FulfilmentQty)
                .HasMaxLength(500)
                .HasColumnName("fulfilment_qty");
            entity.Property(e => e.Gender)
                .HasMaxLength(500)
                .HasColumnName("gender");
            entity.Property(e => e.GroupCodes)
                .HasMaxLength(500)
                .HasColumnName("group_codes");
            entity.Property(e => e.LocationCity)
                .HasMaxLength(500)
                .HasColumnName("location_city");
            entity.Property(e => e.LocationCountry)
                .HasMaxLength(500)
                .HasColumnName("location_country");
            entity.Property(e => e.LocationState)
                .HasMaxLength(500)
                .HasColumnName("location_state");
            entity.Property(e => e.LocationStreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_1");
            entity.Property(e => e.LocationStreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_2");
            entity.Property(e => e.LocationZip)
                .HasMaxLength(500)
                .HasColumnName("location_zip");
            entity.Property(e => e.MemberId).HasColumnName("member_id");
            entity.Property(e => e.MemberSince).HasColumnName("member_since");
            entity.Property(e => e.MembershipType)
                .HasMaxLength(500)
                .HasColumnName("membership_type");
            entity.Property(e => e.NameFirst)
                .HasMaxLength(500)
                .HasColumnName("name_first");
            entity.Property(e => e.NameLast)
                .HasMaxLength(500)
                .HasColumnName("name_last");
            entity.Property(e => e.Note1)
                .HasMaxLength(500)
                .HasColumnName("note1");
            entity.Property(e => e.NumSeats).HasColumnName("num_seats");
            entity.Property(e => e.OrderLineItem).HasColumnName("order_line_item");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.OrigDatetime)
                .HasColumnType("datetime")
                .HasColumnName("orig_datetime");
            entity.Property(e => e.PaymentPlan)
                .HasMaxLength(500)
                .HasColumnName("payment_plan");
            entity.Property(e => e.PhoneCell)
                .HasMaxLength(500)
                .HasColumnName("phone_cell");
            entity.Property(e => e.PhoneDay)
                .HasMaxLength(500)
                .HasColumnName("phone_day");
            entity.Property(e => e.PhoneEve)
                .HasMaxLength(500)
                .HasColumnName("phone_eve");
            entity.Property(e => e.PinMasked)
                .HasMaxLength(500)
                .HasColumnName("pin_masked");
            entity.Property(e => e.PriceCode)
                .HasMaxLength(500)
                .HasColumnName("price_code");
            entity.Property(e => e.PriceCodeDesc)
                .HasMaxLength(500)
                .HasColumnName("price_code_desc");
            entity.Property(e => e.PriceCodeExtra)
                .HasMaxLength(500)
                .HasColumnName("price_code_extra");
            entity.Property(e => e.PriceCodeInfo1)
                .HasMaxLength(500)
                .HasColumnName("price_code_info1");
            entity.Property(e => e.PriceCodeInfo2)
                .HasMaxLength(500)
                .HasColumnName("price_code_info2");
            entity.Property(e => e.PriceCodeInfo3)
                .HasMaxLength(500)
                .HasColumnName("price_code_info3");
            entity.Property(e => e.PriceCodeInfo4)
                .HasMaxLength(500)
                .HasColumnName("price_code_info4");
            entity.Property(e => e.PrimaryName)
                .HasMaxLength(500)
                .HasColumnName("primary_name");
            entity.Property(e => e.PrintCount).HasColumnName("print_count");
            entity.Property(e => e.PrintDate)
                .HasColumnType("datetime")
                .HasColumnName("print_date");
            entity.Property(e => e.RowName)
                .HasMaxLength(500)
                .HasColumnName("row_name");
            entity.Property(e => e.SeatNum).HasColumnName("seat_num");
            entity.Property(e => e.SectionName)
                .HasMaxLength(500)
                .HasColumnName("section_name");
            entity.Property(e => e.State)
                .HasMaxLength(500)
                .HasColumnName("state");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("street_addr_1");
            entity.Property(e => e.StreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("street_addr_2");
            entity.Property(e => e.TicketTypeCategory)
                .HasMaxLength(500)
                .HasColumnName("ticket_type_category");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Venue1Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue1_aisle");
            entity.Property(e => e.Venue1Gate)
                .HasMaxLength(500)
                .HasColumnName("venue1_gate");
            entity.Property(e => e.Venue1Row)
                .HasMaxLength(500)
                .HasColumnName("venue1_row");
            entity.Property(e => e.Venue1Seat)
                .HasMaxLength(500)
                .HasColumnName("venue1_seat");
            entity.Property(e => e.Venue1Section)
                .HasMaxLength(500)
                .HasColumnName("venue1_section");
            entity.Property(e => e.Venue1Stand)
                .HasMaxLength(500)
                .HasColumnName("venue1_stand");
            entity.Property(e => e.Venue2Aisle)
                .HasMaxLength(500)
                .HasColumnName("venue2_aisle");
            entity.Property(e => e.Venue2Gate)
                .HasMaxLength(500)
                .HasColumnName("venue2_gate");
            entity.Property(e => e.Venue2Row)
                .HasMaxLength(500)
                .HasColumnName("venue2_row");
            entity.Property(e => e.Venue2Seat)
                .HasMaxLength(500)
                .HasColumnName("venue2_seat");
            entity.Property(e => e.Venue2Section)
                .HasMaxLength(500)
                .HasColumnName("venue2_section");
            entity.Property(e => e.Venue2Stand)
                .HasMaxLength(500)
                .HasColumnName("venue2_stand");
            entity.Property(e => e.YearsMembership).HasColumnName("years_membership");
            entity.Property(e => e.Zip)
                .HasMaxLength(500)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<RawData18253202210110313456056>(entity =>
        {
            entity.ToTable("RawData_182_53_202210110313456056");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<RawData18253202210190739546008>(entity =>
        {
            entity.ToTable("RawData_182_53_202210190739546008");

            entity.HasIndex(e => e.EmpGroupId, "EMP_GroupID");

            entity.HasIndex(e => new { e.EmpUserId, e.UploadId }, "EMP_UserId");

            entity.HasIndex(e => e.UploadId, "UploadId");

            entity.Property(e => e.AcctId)
                .HasMaxLength(500)
                .HasColumnName("acct_id");
            entity.Property(e => e.AcctTypeDesc)
                .HasMaxLength(500)
                .HasColumnName("acct_type_desc");
            entity.Property(e => e.Barcode)
                .HasMaxLength(500)
                .HasColumnName("barcode");
            entity.Property(e => e.BirthDate)
                .HasColumnType("datetime")
                .HasColumnName("birth_date");
            entity.Property(e => e.Card)
                .HasMaxLength(500)
                .HasColumnName("card");
            entity.Property(e => e.City)
                .HasMaxLength(500)
                .HasColumnName("city");
            entity.Property(e => e.ClubCode)
                .HasMaxLength(500)
                .HasColumnName("club_code");
            entity.Property(e => e.CompName)
                .HasMaxLength(500)
                .HasColumnName("comp_name");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(500)
                .HasColumnName("company_name");
            entity.Property(e => e.ConcessionText)
                .HasMaxLength(500)
                .HasColumnName("concession_text");
            entity.Property(e => e.ConsecutiveSince).HasColumnName("consecutive_since");
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .HasColumnName("country");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustNameId).HasColumnName("cust_name_id");
            entity.Property(e => e.DeliveryInstructions)
                .HasMaxLength(500)
                .HasColumnName("delivery_instructions");
            entity.Property(e => e.DeliveryMethodName)
                .HasMaxLength(500)
                .HasColumnName("delivery_method_name");
            entity.Property(e => e.DiscName)
                .HasMaxLength(500)
                .HasColumnName("disc_name");
            entity.Property(e => e.EmailAddr)
                .HasMaxLength(500)
                .HasColumnName("email_addr");
            entity.Property(e => e.EmpAcctStatus).HasColumnName("EMP_AcctStatus");
            entity.Property(e => e.EmpCredit)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("EMP_Credit");
            entity.Property(e => e.EmpDisplayOrder).HasColumnName("EMP_DisplayOrder");
            entity.Property(e => e.EmpErrorCode)
                .HasMaxLength(200)
                .HasColumnName("EMP_ErrorCode");
            entity.Property(e => e.EmpGender)
                .HasMaxLength(200)
                .HasColumnName("EMP_Gender");
            entity.Property(e => e.EmpGroupId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupId");
            entity.Property(e => e.EmpGroupUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_GroupUserId");
            entity.Property(e => e.EmpIsCardOnly).HasColumnName("EMP_IsCardOnly");
            entity.Property(e => e.EmpIsMain)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_IsMain");
            entity.Property(e => e.EmpLoginAcctStatus).HasColumnName("EMP_LoginAcctStatus");
            entity.Property(e => e.EmpParticipantId).HasColumnName("EMP_ParticipantId");
            entity.Property(e => e.EmpProgramId).HasColumnName("EMP_ProgramId");
            entity.Property(e => e.EmpProgramName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ProgramName");
            entity.Property(e => e.EmpRecordInActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMP_RecordInActive");
            entity.Property(e => e.EmpRecordType)
                .HasMaxLength(200)
                .HasColumnName("EMP_RecordType");
            entity.Property(e => e.EmpRedeemed).HasColumnName("EMP_Redeemed");
            entity.Property(e => e.EmpSeasonId).HasColumnName("EMP_SeasonID");
            entity.Property(e => e.EmpShopName)
                .HasMaxLength(200)
                .HasColumnName("EMP_ShopName");
            entity.Property(e => e.EmpUniqueKey)
                .HasMaxLength(300)
                .HasColumnName("EMP_UniqueKey");
            entity.Property(e => e.EmpUserId)
                .HasMaxLength(200)
                .HasColumnName("EMP_UserId");
            entity.Property(e => e.EmpUserTypeId).HasColumnName("EMP_UserTypeId");
            entity.Property(e => e.EmpUsername)
                .HasMaxLength(200)
                .HasColumnName("EMP_Username");
            entity.Property(e => e.EmpXmlData)
                .HasColumnType("xml")
                .HasColumnName("EMP_XmlData");
            entity.Property(e => e.EventLine1)
                .HasMaxLength(500)
                .HasColumnName("event_line1");
            entity.Property(e => e.EventLine2)
                .HasMaxLength(500)
                .HasColumnName("event_line2");
            entity.Property(e => e.EventLine3)
                .HasMaxLength(500)
                .HasColumnName("event_line3");
            entity.Property(e => e.EventName)
                .HasMaxLength(500)
                .HasColumnName("event_name");
            entity.Property(e => e.FamilyId).HasColumnName("family_id");
            entity.Property(e => e.Fulfilment)
                .HasMaxLength(500)
                .HasColumnName("fulfilment");
            entity.Property(e => e.FullName)
                .HasMaxLength(500)
                .HasColumnName("full_name");
            entity.Property(e => e.Gate)
                .HasMaxLength(500)
                .HasColumnName("gate");
            entity.Property(e => e.Gender)
                .HasMaxLength(500)
                .HasColumnName("gender");
            entity.Property(e => e.GroupCodes)
                .HasColumnType("text")
                .HasColumnName("group_codes");
            entity.Property(e => e.LocationCity)
                .HasMaxLength(500)
                .HasColumnName("location_city");
            entity.Property(e => e.LocationCountry)
                .HasMaxLength(500)
                .HasColumnName("location_country");
            entity.Property(e => e.LocationState)
                .HasMaxLength(500)
                .HasColumnName("location_state");
            entity.Property(e => e.LocationStreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_1");
            entity.Property(e => e.LocationStreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("location_street_addr_2");
            entity.Property(e => e.LocationZip)
                .HasMaxLength(500)
                .HasColumnName("location_zip");
            entity.Property(e => e.MemberSince).HasColumnName("member_since");
            entity.Property(e => e.MembershipType)
                .HasMaxLength(500)
                .HasColumnName("membership_type");
            entity.Property(e => e.NameFirst)
                .HasMaxLength(500)
                .HasColumnName("name_first");
            entity.Property(e => e.NameLast)
                .HasMaxLength(500)
                .HasColumnName("name_last");
            entity.Property(e => e.Note1)
                .HasMaxLength(500)
                .HasColumnName("note1");
            entity.Property(e => e.Note2)
                .HasMaxLength(500)
                .HasColumnName("note2");
            entity.Property(e => e.NumSeats).HasColumnName("num_seats");
            entity.Property(e => e.OrderLineItem).HasColumnName("order_line_item");
            entity.Property(e => e.OrderNum).HasColumnName("order_num");
            entity.Property(e => e.OtherInfo6)
                .HasMaxLength(500)
                .HasColumnName("other_info_6");
            entity.Property(e => e.OtherInfo7)
                .HasMaxLength(500)
                .HasColumnName("other_info_7");
            entity.Property(e => e.OtherInfo9)
                .HasMaxLength(500)
                .HasColumnName("other_info_9");
            entity.Property(e => e.PackChoice)
                .HasMaxLength(500)
                .HasColumnName("pack_choice");
            entity.Property(e => e.PhoneCell)
                .HasMaxLength(500)
                .HasColumnName("phone_cell");
            entity.Property(e => e.PhoneDay)
                .HasMaxLength(500)
                .HasColumnName("phone_day");
            entity.Property(e => e.PhoneEve)
                .HasMaxLength(500)
                .HasColumnName("phone_eve");
            entity.Property(e => e.PinMasked)
                .HasMaxLength(500)
                .HasColumnName("pin_masked");
            entity.Property(e => e.Portal)
                .HasMaxLength(500)
                .HasColumnName("portal");
            entity.Property(e => e.PriceCode)
                .HasMaxLength(500)
                .HasColumnName("price_code");
            entity.Property(e => e.PriceCodeDesc)
                .HasMaxLength(500)
                .HasColumnName("price_code_desc");
            entity.Property(e => e.PrimaryCustNameId).HasColumnName("primary_cust_name_id");
            entity.Property(e => e.PrimaryName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("primary_name");
            entity.Property(e => e.PrintCount).HasColumnName("print_count");
            entity.Property(e => e.PrintDate)
                .HasColumnType("datetime")
                .HasColumnName("print_date");
            entity.Property(e => e.RowName)
                .HasMaxLength(500)
                .HasColumnName("row_name");
            entity.Property(e => e.SeatLabel1)
                .HasMaxLength(500)
                .HasColumnName("seat_label1");
            entity.Property(e => e.SeatLabel2)
                .HasMaxLength(500)
                .HasColumnName("seat_label2");
            entity.Property(e => e.SeatLabel3)
                .HasMaxLength(500)
                .HasColumnName("seat_label3");
            entity.Property(e => e.SeatLabel4)
                .HasMaxLength(500)
                .HasColumnName("seat_label4");
            entity.Property(e => e.SeatLocation1)
                .HasMaxLength(500)
                .HasColumnName("seat_location1");
            entity.Property(e => e.SeatLocation2)
                .HasMaxLength(500)
                .HasColumnName("seat_location2");
            entity.Property(e => e.SeatLocation3)
                .HasMaxLength(500)
                .HasColumnName("seat_location3");
            entity.Property(e => e.SeatLocation4)
                .HasMaxLength(500)
                .HasColumnName("seat_location4");
            entity.Property(e => e.SeatNum).HasColumnName("seat_num");
            entity.Property(e => e.SectionName)
                .HasMaxLength(500)
                .HasColumnName("section_name");
            entity.Property(e => e.State)
                .HasMaxLength(500)
                .HasColumnName("state");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StreetAddr1)
                .HasMaxLength(500)
                .HasColumnName("street_addr_1");
            entity.Property(e => e.StreetAddr2)
                .HasMaxLength(500)
                .HasColumnName("street_addr_2");
            entity.Property(e => e.SurchgName)
                .HasMaxLength(500)
                .HasColumnName("surchg_name");
            entity.Property(e => e.TicketTypeCategory)
                .HasMaxLength(500)
                .HasColumnName("ticket_type_category");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.YearsConsecutive).HasColumnName("years_consecutive");
            entity.Property(e => e.YearsMembership).HasColumnName("years_membership");
            entity.Property(e => e.YearsUpdated)
                .HasMaxLength(500)
                .HasColumnName("years_updated");
            entity.Property(e => e.Zip)
                .HasMaxLength(500)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<RawDataTest>(entity =>
        {
            entity.ToTable("RawData_Test");

            entity.HasIndex(e => e.EmpGroupId, "EMP_GroupID");

            entity.HasIndex(e => new { e.EmpUserId, e.UploadId }, "EMP_UserId");

            entity.HasIndex(e => e.UploadId, "UploadId");

            entity.Property(e => e.Id)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("ID");
            entity.Property(e => e.EmpGroupId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("EMP_GroupID");
            entity.Property(e => e.EmpUserId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("EMP_UserId");
            entity.Property(e => e.Test)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Roles__3214EC2723BF9AA4");

            entity.ToTable("Role");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(100);
        });

        modelBuilder.Entity<ScriptWidget>(entity =>
        {
            entity.ToTable("ScriptWidget");

            entity.Property(e => e.Id)
                .HasMaxLength(100)
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Season>(entity =>
        {
            entity.ToTable("Season");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.FromDate).HasColumnType("datetime");
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.SeasonStatus).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.ToDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ShippingCalculator>(entity =>
        {
            entity.ToTable("ShippingCalculator");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Calculator).HasMaxLength(500);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.DefaultPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ExtInit).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.ExtPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Init).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.IsMinShippingHasRedeemItem).HasDefaultValueSql("((0))");
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.MinShippingHasRedeemItem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.ToCountry).HasMaxLength(150);
            entity.Property(e => e.ToState).HasMaxLength(150);
            entity.Property(e => e.WaveHouseId).HasColumnName("WaveHouseID");
        });

        modelBuilder.Entity<ShippingCalculatorChild>(entity =>
        {
            entity.ToTable("ShippingCalculatorChild");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.PostCode).HasMaxLength(150);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ShippingCalculatorId).HasColumnName("ShippingCalculatorID");
            entity.Property(e => e.Suburb).HasMaxLength(150);
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<ShippingWeightChild>(entity =>
        {
            entity.ToTable("ShippingWeightChild");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Country).HasMaxLength(500);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.FromWeight).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.PostCode).HasMaxLength(500);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ShippingCalculatorId).HasColumnName("ShippingCalculatorID");
            entity.Property(e => e.State).HasMaxLength(500);
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.ToWeight).HasColumnType("decimal(18, 3)");
        });

        modelBuilder.Entity<ShoppingWidget>(entity =>
        {
            entity.ToTable("ShoppingWidget");

            entity.Property(e => e.Id)
                .HasMaxLength(100)
                .HasColumnName("ID");
        });

        modelBuilder.Entity<StyleSheetWidget>(entity =>
        {
            entity.ToTable("StyleSheetWidget");

            entity.Property(e => e.Id)
                .HasMaxLength(100)
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Tax>(entity =>
        {
            entity.ToTable("Tax");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.Country).HasMaxLength(255);
            entity.Property(e => e.CountryCode).HasMaxLength(3);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.TaxRate).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK_Users");

            entity.ToTable("User");

            entity.HasIndex(e => e.CompanyId, "CompanyID");

            entity.HasIndex(e => e.ParentId, "ParentID");

            entity.HasIndex(e => e.TreeId, "TreeID");

            entity.HasIndex(e => new { e.CompanyId, e.Status }, "company_status");

            entity.Property(e => e.UserId)
                .HasMaxLength(100)
                .HasColumnName("UserID");
            entity.Property(e => e.AccountId)
                .HasMaxLength(100)
                .HasColumnName("AccountID");
            entity.Property(e => e.AccountStatus).HasDefaultValueSql("((1))");
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.Birthday).HasColumnType("datetime");
            entity.Property(e => e.CompanyId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("CompanyID");
            entity.Property(e => e.CountError).HasDefaultValueSql("((0))");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Credit)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastLoginDate).HasColumnType("datetime");
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LastResetPasswordDate).HasColumnType("datetime");
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.LoginIp)
                .HasMaxLength(50)
                .HasColumnName("LoginIP");
            entity.Property(e => e.LoginToken).HasMaxLength(255);
            entity.Property(e => e.NickName).HasMaxLength(255);
            entity.Property(e => e.OrgId)
                .HasMaxLength(50)
                .HasColumnName("OrgID");
            entity.Property(e => e.ParentId)
                .HasMaxLength(100)
                .HasColumnName("ParentID");
            entity.Property(e => e.PassWord).HasMaxLength(255);
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.PhotoUrl).HasMaxLength(255);
            entity.Property(e => e.ResetPasswordToken).HasMaxLength(255);
            entity.Property(e => e.Test).HasMaxLength(50);
            entity.Property(e => e.TreeId)
                .HasMaxLength(800)
                .HasColumnName("TreeID");
            entity.Property(e => e.UserName).HasMaxLength(100);
            entity.Property(e => e.UserTypeId).HasColumnName("UserTypeID");
            entity.Property(e => e.ZipCode).HasMaxLength(50);
        });

        modelBuilder.Entity<UserAccount>(entity =>
        {
            entity.HasKey(e => e.AccountId);

            entity.ToTable("UserAccount");

            entity.Property(e => e.AccountId)
                .HasMaxLength(100)
                .HasColumnName("AccountID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.PassWord).HasMaxLength(255);
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<UserCreditHistory>(entity =>
        {
            entity.ToTable("UserCreditHistory");

            entity.HasIndex(e => e.UserId, "UserID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AfterCredit).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BeforeCredit).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.InCredit).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InRef).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.OutCredit).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OutRef).HasMaxLength(255);
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<UserEmailReminder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_UserEnailReminder");

            entity.ToTable("UserEmailReminder");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.UserId)
                .HasMaxLength(100)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<UserRoleRelation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserRole__3214EC270977C2D9");

            entity.ToTable("UserRoleRelation");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<UserType>(entity =>
        {
            entity.ToTable("UserType", tb => tb.HasTrigger("TG_LOG_USERTYPE"));

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(500);
            entity.Property(e => e.Discount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.IsCreate).HasDefaultValueSql("((1))");
            entity.Property(e => e.IsDefault).HasDefaultValueSql("((0))");
            entity.Property(e => e.IsOrder).HasDefaultValueSql("((1))");
            entity.Property(e => e.IsSupperAdmin).HasDefaultValueSql("((0))");
            entity.Property(e => e.IsUseCredit).HasDefaultValueSql("((1))");
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.OrgId)
                .HasMaxLength(50)
                .HasColumnName("OrgID");
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.Title).HasMaxLength(500);
            entity.Property(e => e.TreeId)
                .HasMaxLength(500)
                .HasColumnName("TreeID");
        });

        modelBuilder.Entity<UserTypeActionPermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserType__3214EC2734414031");

            entity.ToTable("UserTypeActionPermission");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActionKey).HasMaxLength(255);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(255);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(255);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(255);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.UserTypeId).HasColumnName("UserTypeID");
        });

        modelBuilder.Entity<UserTypePermission>(entity =>
        {
            entity.ToTable("UserTypePermission");

            entity.HasIndex(e => e.OwnerId, "OwnerID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.OwnerId)
                .HasMaxLength(255)
                .HasColumnName("OwnerID");
            entity.Property(e => e.OwnerModule).HasMaxLength(255);
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.UserTypeId).HasColumnName("UserTypeID");
        });

        modelBuilder.Entity<UserTypeUser>(entity =>
        {
            entity.ToTable("UserTypeUser");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(500);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(500);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(500);
            entity.Property(e => e.UserId)
                .HasMaxLength(100)
                .HasColumnName("UserID");
            entity.Property(e => e.UserTypeId).HasColumnName("UserTypeID");
        });

        modelBuilder.Entity<VCalParticipant>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_CalParticipant");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.TotalAdjustCredit).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.TotalAvailableCredit).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.TotalCredit).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.TotalUsedCredit).HasColumnType("decimal(38, 2)");
        });

        modelBuilder.Entity<VCalParticipantAuk>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_CalParticipant_AUK");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.TotalAdjustCredit).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.TotalAvailableCredit).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.TotalCredit).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.TotalUsedCredit).HasColumnType("decimal(38, 2)");
        });

        modelBuilder.Entity<VCalParticipantBakBeforeAuk>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_CalParticipant_BAK_BEFORE_AUK");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.TotalAdjustCredit).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.TotalAvailableCredit).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.TotalCredit).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.TotalUsedCredit).HasColumnType("decimal(38, 2)");
        });

        modelBuilder.Entity<VParticipant>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Participant");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.EntId)
                .HasMaxLength(50)
                .HasColumnName("EntID");
            entity.Property(e => e.EntName).HasMaxLength(250);
            entity.Property(e => e.EntState).HasMaxLength(15);
            entity.Property(e => e.FirstTime)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Fname)
                .HasMaxLength(250)
                .HasColumnName("FName");
            entity.Property(e => e.Lname)
                .HasMaxLength(250)
                .HasColumnName("LName");
            entity.Property(e => e.OrderEtadate)
                .HasColumnType("datetime")
                .HasColumnName("OrderETADate");
            entity.Property(e => e.OrderId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OrderID");
            entity.Property(e => e.OrderSendDate).HasColumnType("datetime");
            entity.Property(e => e.OrderStatus)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ParticipantId)
                .HasMaxLength(50)
                .HasColumnName("ParticipantID");
            entity.Property(e => e.PlayerCategory)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ShirtName)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ShirtSize)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Ssnclub)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SSNClub");
        });

        modelBuilder.Entity<VRedemption>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Redemption");

            entity.Property(e => e.AssignedCredit).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.AvailableCredit).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreditTenure).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DiversityCredit).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EntityId)
                .HasMaxLength(50)
                .HasColumnName("EntityID");
            entity.Property(e => e.EntityName).HasMaxLength(250);
            entity.Property(e => e.EntityState).HasMaxLength(15);
            entity.Property(e => e.OrgId)
                .HasMaxLength(50)
                .HasColumnName("OrgID");
            entity.Property(e => e.PackStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ParticipantCredit).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
            entity.Property(e => e.UpdateCredit).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.UsedCredit).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.UserId)
                .HasMaxLength(100)
                .HasColumnName("UserID");
            entity.Property(e => e.UserTypeId).HasColumnName("UserTypeID");
        });

        modelBuilder.Entity<VReportRedemption>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_ReportRedemption");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreditAssigned).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.CreditAvailable).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreditUpdated).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.CreditUsage)
                .HasMaxLength(61)
                .IsUnicode(false);
            entity.Property(e => e.CreditUsed).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.FirstName).HasMaxLength(250);
            entity.Property(e => e.ItemSelecttion)
                .HasMaxLength(61)
                .IsUnicode(false);
            entity.Property(e => e.LastName).HasMaxLength(250);
            entity.Property(e => e.ParticipantId)
                .HasMaxLength(50)
                .HasColumnName("ParticipantID");
            entity.Property(e => e.UserId)
                .HasMaxLength(100)
                .HasColumnName("UserID");
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<VReportRedemptionExport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_ReportRedemptionExport");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CreditAccount)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CreditAdjust).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.CreditAssigned).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.CreditAvailable).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreditUsage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreditUsed).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.EntityId)
                .HasMaxLength(50)
                .HasColumnName("EntityID");
            entity.Property(e => e.EntityName).HasMaxLength(250);
            entity.Property(e => e.FirstName).HasMaxLength(250);
            entity.Property(e => e.Item).HasMaxLength(80);
            entity.Property(e => e.ItemAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ItemSelecttion)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.ItemType)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.LastName).HasMaxLength(250);
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.OrderStatus).HasMaxLength(255);
            entity.Property(e => e.OrgId)
                .HasMaxLength(100)
                .HasColumnName("OrgID");
            entity.Property(e => e.OrgName).HasMaxLength(100);
            entity.Property(e => e.ParticipantId)
                .HasMaxLength(50)
                .HasColumnName("ParticipantID");
            entity.Property(e => e.ProgramId)
                .HasMaxLength(50)
                .HasColumnName("ProgramID");
            entity.Property(e => e.ProgramName).HasMaxLength(250);
            entity.Property(e => e.ProgramType).HasMaxLength(50);
            entity.Property(e => e.Redeem)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Redeemed)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.SelectionDate).HasColumnType("datetime");
            entity.Property(e => e.SelectionDeadline)
                .HasColumnType("datetime")
                .HasColumnName("Selection_Deadline");
            entity.Property(e => e.SelectionDesign)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Selection_Design");
            entity.Property(e => e.SelectionInput)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Selection_Input");
            entity.Property(e => e.SelectionOther)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Selection_Other");
            entity.Property(e => e.SelectionSize)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Selection_Size");
            entity.Property(e => e.SelectionType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Selection_Type");
            entity.Property(e => e.UserId)
                .HasMaxLength(100)
                .HasColumnName("UserID");
            entity.Property(e => e.UserName).HasMaxLength(100);
            entity.Property(e => e.WebAcctId)
                .HasMaxLength(100)
                .HasColumnName("WebAcctID");
            entity.Property(e => e.WebAcctType).HasMaxLength(500);
        });

        modelBuilder.Entity<Warehouse>(entity =>
        {
            entity.ToTable("Warehouse");

            entity.Property(e => e.Id)
                .HasMaxLength(100)
                .HasColumnName("ID");
            entity.Property(e => e.Addr1).HasMaxLength(500);
            entity.Property(e => e.Addr2)
                .HasMaxLength(500)
                .IsFixedLength();
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.TpfcatalogueId)
                .HasMaxLength(50)
                .HasColumnName("TPFCatalogueID");
            entity.Property(e => e.Tpfwhid)
                .HasMaxLength(50)
                .HasColumnName("TPFWHID");
            entity.Property(e => e.WhType).HasMaxLength(50);
            entity.Property(e => e.Whid).HasColumnName("WHID");
            entity.Property(e => e.Whstatus).HasColumnName("WHStatus");
            entity.Property(e => e.Whurl)
                .HasMaxLength(1000)
                .HasColumnName("WHUrl");
        });

        modelBuilder.Entity<WebOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WebOrder__3214EC27822BC5FF");

            entity.ToTable("WebOrder");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CanceledAt).HasColumnType("datetime");
            entity.Property(e => e.CanceledBy).HasMaxLength(255);
            entity.Property(e => e.CompanyId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("CompanyID");
            entity.Property(e => e.CounterCode).HasMaxLength(500);
            entity.Property(e => e.CreateBy).HasMaxLength(255);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(255);
            entity.Property(e => e.Credit).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CreditGst)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CreditSubTotal)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Currency).HasMaxLength(255);
            entity.Property(e => e.DebtorCode).HasMaxLength(50);
            entity.Property(e => e.DeliveryRequestCreated).HasDefaultValueSql("((0))");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Gst).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.LastUpdateBy).HasMaxLength(255);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(255);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.OrderStatus).HasMaxLength(255);
            entity.Property(e => e.OrderType).HasMaxLength(50);
            entity.Property(e => e.PaymentStatus).HasMaxLength(255);
            entity.Property(e => e.PaymentType).HasMaxLength(255);
            entity.Property(e => e.SeasonId).HasColumnName("SeasonID");
            entity.Property(e => e.ShippingSubTotalPrice).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ShippingTotalPrice).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ShippingType).HasMaxLength(50);
            entity.Property(e => e.SubOrderType).HasMaxLength(50);
            entity.Property(e => e.SubTotal).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SubTotalDiscount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SyncStatus).HasMaxLength(255);
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.Total).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalDiscount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalGst).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TpforderId).HasColumnName("TPFOrderID");
            entity.Property(e => e.TpforderSyncDate)
                .HasColumnType("datetime")
                .HasColumnName("TPFOrderSyncDate");
            entity.Property(e => e.TransationRef).HasMaxLength(255);
            entity.Property(e => e.UserId)
                .HasMaxLength(255)
                .HasColumnName("UserID");
            entity.Property(e => e.Voucher).HasMaxLength(255);
        });

        modelBuilder.Entity<WebOrderDeliveryTracking>(entity =>
        {
            entity.ToTable("WebOrderDeliveryTracking");

            entity.HasIndex(e => e.OrderId, "OrderID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CarrierName).HasMaxLength(500);
            entity.Property(e => e.CompanyId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(255);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(255);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(255);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.OcDelId).HasColumnName("OcDelID");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.ProcessedDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.TrackingNo).HasMaxLength(255);
        });

        modelBuilder.Entity<WebOrderDeliveryTrackingDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Wh_OcTrackingDetail");

            entity.ToTable("WebOrderDeliveryTrackingDetail");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompanyId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(255);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(255);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(255);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Status).HasComment("1: New, 2:Partly, 3: Fully");
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<WebOrderDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WebOrder__3214EC27E097E18C");

            entity.ToTable("WebOrderDetail");

            entity.HasIndex(e => e.OrderId, "OrderID");

            entity.HasIndex(e => e.ProductId, "ProductID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Gst).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Height).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Image).HasMaxLength(255);
            entity.Property(e => e.Length).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.PersonalizedData).HasMaxLength(255);
            entity.Property(e => e.PersonalizedLetter).HasMaxLength(255);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PrimaryWh).HasDefaultValueSql("((1))");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.RedeemId).HasColumnName("RedeemID");
            entity.Property(e => e.RedeemRawData).HasColumnType("xml");
            entity.Property(e => e.RedeemValue).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ShippingPrice).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ShippingSubTotalPrice).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ShippingTotalPrice).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Sku)
                .HasMaxLength(255)
                .HasColumnName("SKU");
            entity.Property(e => e.SubTotal).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TargetView).HasMaxLength(255);
            entity.Property(e => e.Total).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalDiscount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalGst).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Width).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<WebOrderDetailSubItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WebOrderDetailSubItem__3214EC27E097E18C");

            entity.ToTable("WebOrderDetailSubItem");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.OrderDetailId).HasColumnName("OrderDetailID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Sku)
                .HasMaxLength(255)
                .HasColumnName("SKU");
            entity.Property(e => e.TargetView).HasMaxLength(255);
            entity.Property(e => e.TotalWeight).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<WhOcDelivery>(entity =>
        {
            entity.ToTable("Wh_OcDelivery");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Addr1).HasMaxLength(500);
            entity.Property(e => e.Addr2).HasMaxLength(500);
            entity.Property(e => e.Addr3).HasMaxLength(500);
            entity.Property(e => e.ClubCode).HasMaxLength(50);
            entity.Property(e => e.CompanyId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName).HasMaxLength(500);
            entity.Property(e => e.Country).HasMaxLength(300);
            entity.Property(e => e.CreateBy).HasMaxLength(255);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(255);
            entity.Property(e => e.DeliveryStatus).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(500);
            entity.Property(e => e.Fname).HasMaxLength(300);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(255);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(255);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Lname).HasMaxLength(300);
            entity.Property(e => e.MemberId)
                .HasMaxLength(50)
                .HasColumnName("MemberID");
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.OrderType).HasMaxLength(100);
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.Postcode).HasMaxLength(300);
            entity.Property(e => e.ShippingType).HasMaxLength(100);
            entity.Property(e => e.Specialinstructions).HasMaxLength(500);
            entity.Property(e => e.State).HasMaxLength(500);
            entity.Property(e => e.Status).HasComment("1: New, 2:Partly, 3: Fully");
            entity.Property(e => e.Suburb).HasMaxLength(500);
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.UserName).HasMaxLength(500);
            entity.Property(e => e.WhRefNo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WhOcDeliveryDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Wh_DeliveryDetail");

            entity.ToTable("Wh_OcDeliveryDetail");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompanyId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("CompanyID");
            entity.Property(e => e.CreateBy).HasMaxLength(255);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(255);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(255);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.PrintImage).HasMaxLength(255);
            entity.Property(e => e.PrintName).HasMaxLength(255);
            entity.Property(e => e.ProCode).HasMaxLength(200);
            entity.Property(e => e.ProName).HasMaxLength(500);
            entity.Property(e => e.RawData).HasColumnType("xml");
            entity.Property(e => e.Status).HasComment("1: New, 2:Partly, 3: Fully");
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<WidgetBiToolReport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WidgetBi__3214EC27F5C7B3D4");

            entity.ToTable("WidgetBiToolReport");

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .HasColumnName("ID");
            entity.Property(e => e.ConfigReport).HasMaxLength(255);
            entity.Property(e => e.FilterReport).HasMaxLength(255);
            entity.Property(e => e.QueryReport).HasMaxLength(255);
        });

        modelBuilder.Entity<WidgetGroupTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CheckoutWidgetGroup");

            entity.ToTable("WidgetGroupTemplate");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.WidgetId)
                .HasMaxLength(100)
                .HasColumnName("WidgetID");
        });

        modelBuilder.Entity<WidgetGroupTemplateItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CheckoutShippingConfig");

            entity.ToTable("WidgetGroupTemplateItem");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ContentType).HasMaxLength(100);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.DefaultValue).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Mapping).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<WidgetTemplateMode>(entity =>
        {
            entity.ToTable("WidgetTemplateMode");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatebyName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.LastUpdateBy).HasMaxLength(50);
            entity.Property(e => e.LastUpdateByName).HasMaxLength(100);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.WigetId)
                .HasMaxLength(100)
                .HasColumnName("WigetID");
        });

        modelBuilder.Entity<ZCalcRegion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Z_CALC_Region");

            entity.Property(e => e.MberOrgStateId)
                .HasMaxLength(255)
                .HasColumnName("Mber+ Org (State) ID");
            entity.Property(e => e.MberOrgStateName)
                .HasMaxLength(255)
                .HasColumnName("Mber+ Org (State) name");
            entity.Property(e => e.PlayHqParentRegionId)
                .HasMaxLength(255)
                .HasColumnName("Play HQ parent (Region) ID");
            entity.Property(e => e.PlayHqParentRegionName)
                .HasMaxLength(255)
                .HasColumnName("Play HQ parent (Region) name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
