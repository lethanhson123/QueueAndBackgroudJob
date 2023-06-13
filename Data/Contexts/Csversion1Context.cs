using Data.Databases.Csversion1;

namespace Data.Contexts;

public partial class Csversion1Context : DbContext
{
    public Csversion1Context()
    {
    }

    public Csversion1Context(DbContextOptions<Csversion1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<CaAdjustMentCreditPoint> CaAdjustMentCreditPoints { get; set; }

    public virtual DbSet<CaAdjustMentCreditPointEntityLog> CaAdjustMentCreditPointEntityLogs { get; set; }

    public virtual DbSet<CaAusStateList> CaAusStateLists { get; set; }

    public virtual DbSet<CaAvalable> CaAvalables { get; set; }

    public virtual DbSet<CaAvalableCheckSendMail> CaAvalableCheckSendMails { get; set; }

    public virtual DbSet<CaAvalableCheckSendMailTBak> CaAvalableCheckSendMailTBaks { get; set; }

    public virtual DbSet<CaAvalableTBak> CaAvalableTBaks { get; set; }

    public virtual DbSet<CaBbl> CaBbls { get; set; }

    public virtual DbSet<CaBlastCentreSetting> CaBlastCentreSettings { get; set; }

    public virtual DbSet<CaCalculate> CaCalculates { get; set; }

    public virtual DbSet<CaCalculateback> CaCalculatebacks { get; set; }

    public virtual DbSet<CaCategory> CaCategories { get; set; }

    public virtual DbSet<CaClubBbl> CaClubBbls { get; set; }

    public virtual DbSet<CaConditionUpdateTransId> CaConditionUpdateTransIds { get; set; }

    public virtual DbSet<CaConset> CaConsets { get; set; }

    public virtual DbSet<CaConsetCheck> CaConsetChecks { get; set; }

    public virtual DbSet<CaDayPerState> CaDayPerStates { get; set; }

    public virtual DbSet<CaDeleteUserLog> CaDeleteUserLogs { get; set; }

    public virtual DbSet<CaEntity> CaEntities { get; set; }

    public virtual DbSet<CaEntityBk> CaEntityBks { get; set; }

    public virtual DbSet<CaImgBbl> CaImgBbls { get; set; }

    public virtual DbSet<CaImgSub> CaImgSubs { get; set; }

    public virtual DbSet<CaImgSubBak> CaImgSubBaks { get; set; }

    public virtual DbSet<CaJnrcritketRaw> CaJnrcritketRaws { get; set; }

    public virtual DbSet<CaModifiedEntitiesLog> CaModifiedEntitiesLogs { get; set; }

    public virtual DbSet<CaOrder> CaOrders { get; set; }

    public virtual DbSet<CaOrganisation> CaOrganisations { get; set; }

    public virtual DbSet<CaPlayer> CaPlayers { get; set; }

    public virtual DbSet<CaPlayerLog> CaPlayerLogs { get; set; }

    public virtual DbSet<CaPlayerProduct> CaPlayerProducts { get; set; }

    public virtual DbSet<CaPlayerProductBak20191205> CaPlayerProductBak20191205s { get; set; }

    public virtual DbSet<CaPlayerProductLog> CaPlayerProductLogs { get; set; }

    public virtual DbSet<CaPlayerProductsLog> CaPlayerProductsLogs { get; set; }

    public virtual DbSet<CaPlayerProgram> CaPlayerPrograms { get; set; }

    public virtual DbSet<CaProduct> CaProducts { get; set; }

    public virtual DbSet<CaProductBblclub> CaProductBblclubs { get; set; }

    public virtual DbSet<CaProductPreview> CaProductPreviews { get; set; }

    public virtual DbSet<CaProductProfilePreview> CaProductProfilePreviews { get; set; }

    public virtual DbSet<CaProductTable> CaProductTables { get; set; }

    public virtual DbSet<CaProductTbak> CaProductTbaks { get; set; }

    public virtual DbSet<CaProductType> CaProductTypes { get; set; }

    public virtual DbSet<CaProductType1> CaProductTypes1 { get; set; }

    public virtual DbSet<CaProductTypeSub> CaProductTypeSubs { get; set; }

    public virtual DbSet<CaProductTypeTu> CaProductTypeTus { get; set; }

    public virtual DbSet<CaProgram> CaPrograms { get; set; }

    public virtual DbSet<CaPromo> CaPromos { get; set; }

    public virtual DbSet<CaPropackDetail> CaPropackDetails { get; set; }

    public virtual DbSet<CaRedeem> CaRedeems { get; set; }

    public virtual DbSet<CaRedeemNew> CaRedeemNews { get; set; }

    public virtual DbSet<CaSchoolOrgContact> CaSchoolOrgContacts { get; set; }

    public virtual DbSet<CaSchoolOrgContactBak20201303> CaSchoolOrgContactBak20201303s { get; set; }

    public virtual DbSet<CaSchoolOrgContactBakDelete> CaSchoolOrgContactBakDeletes { get; set; }

    public virtual DbSet<CaSchoolOrgContactBakDelete20200311> CaSchoolOrgContactBakDelete20200311s { get; set; }

    public virtual DbSet<CaSchoolOrgContactBakUpdateOrgId> CaSchoolOrgContactBakUpdateOrgIds { get; set; }

    public virtual DbSet<CaSchoolOrgContactRestore> CaSchoolOrgContactRestores { get; set; }

    public virtual DbSet<CaSchoolOrganisationStatus> CaSchoolOrganisationStatuses { get; set; }

    public virtual DbSet<CaSchoolOrganisationStatusBakUpdateOrgId> CaSchoolOrganisationStatusBakUpdateOrgIds { get; set; }

    public virtual DbSet<CaSchoolOrganisationStatusBakup20201203> CaSchoolOrganisationStatusBakup20201203s { get; set; }

    public virtual DbSet<CaSchoolUpdateChangeAccount> CaSchoolUpdateChangeAccounts { get; set; }

    public virtual DbSet<CaSchoolUserEntitlementRaw> CaSchoolUserEntitlementRaws { get; set; }

    public virtual DbSet<CaSchoolUserOrganisationRaw> CaSchoolUserOrganisationRaws { get; set; }

    public virtual DbSet<CaSchoolUserStatus> CaSchoolUserStatuses { get; set; }

    public virtual DbSet<CaSchoolUserStatusBak201909013> CaSchoolUserStatusBak201909013s { get; set; }

    public virtual DbSet<CaSchoolUserStatusBakUpdateContactId> CaSchoolUserStatusBakUpdateContactIds { get; set; }

    public virtual DbSet<CaSeason> CaSeasons { get; set; }

    public virtual DbSet<CaStateSchool> CaStateSchools { get; set; }

    public virtual DbSet<CaTag> CaTags { get; set; }

    public virtual DbSet<CaTagProdetail> CaTagProdetails { get; set; }

    public virtual DbSet<CaTranLogFulfilment> CaTranLogFulfilments { get; set; }

    public virtual DbSet<CaTransactionLog> CaTransactionLogs { get; set; }

    public virtual DbSet<CaTypeDetail> CaTypeDetails { get; set; }

    public virtual DbSet<CatVoucher> CatVouchers { get; set; }

    public virtual DbSet<Catalogue> Catalogues { get; set; }

    public virtual DbSet<CatalogueLiveHelpSetting> CatalogueLiveHelpSettings { get; set; }

    public virtual DbSet<CataloguePaymentMethod> CataloguePaymentMethods { get; set; }

    public virtual DbSet<CatalogueSeo> CatalogueSeos { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<CheckNewPrice> CheckNewPrices { get; set; }

    public virtual DbSet<CheckOrge> CheckOrges { get; set; }

    public virtual DbSet<CheckPriceCa> CheckPriceCas { get; set; }

    public virtual DbSet<CheckProdetailId> CheckProdetailIds { get; set; }

    public virtual DbSet<ComSyncLog> ComSyncLogs { get; set; }

    public virtual DbSet<CustProfile> CustProfiles { get; set; }

    public virtual DbSet<CustProfileBakUpProfile> CustProfileBakUpProfiles { get; set; }

    public virtual DbSet<FinanceCurrency> FinanceCurrencies { get; set; }

    public virtual DbSet<GroupTransactionFf> GroupTransactionFfs { get; set; }

    public virtual DbSet<ImportTransaction> ImportTransactions { get; set; }

    public virtual DbSet<ImportTransactionService> ImportTransactionServices { get; set; }

    public virtual DbSet<ItemRating> ItemRatings { get; set; }

    public virtual DbSet<LogCancelParticipantOrder> LogCancelParticipantOrders { get; set; }

    public virtual DbSet<Matching> Matchings { get; set; }

    public virtual DbSet<NewOrgIdnotUsingUserEntitlementRaw> NewOrgIdnotUsingUserEntitlementRaws { get; set; }

    public virtual DbSet<ParticipantOrderCompare> ParticipantOrderCompares { get; set; }

    public virtual DbSet<ParticipantReportOrderSeason> ParticipantReportOrderSeasons { get; set; }

    public virtual DbSet<Personalisation> Personalisations { get; set; }

    public virtual DbSet<PlayHqproductRef> PlayHqproductRefs { get; set; }

    public virtual DbSet<ProPack> ProPacks { get; set; }

    public virtual DbSet<ProPackDynamic> ProPackDynamics { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductKit> ProductKits { get; set; }

    public virtual DbSet<ProductPrice> ProductPrices { get; set; }

    public virtual DbSet<ProductPricesBak> ProductPricesBaks { get; set; }

    public virtual DbSet<ProductPricesgroupca> ProductPricesgroupcas { get; set; }

    public virtual DbSet<ProductProfile> ProductProfiles { get; set; }

    public virtual DbSet<ProductQty> ProductQties { get; set; }

    public virtual DbSet<ProductSeo> ProductSeos { get; set; }

    public virtual DbSet<ProductTemplate> ProductTemplates { get; set; }

    public virtual DbSet<ProductTemplateField> ProductTemplateFields { get; set; }

    public virtual DbSet<ProductTemplateFieldOption> ProductTemplateFieldOptions { get; set; }

    public virtual DbSet<ProductTemplateMap> ProductTemplateMaps { get; set; }

    public virtual DbSet<Productdetail> Productdetails { get; set; }

    public virtual DbSet<ProductdetailReference> ProductdetailReferences { get; set; }

    public virtual DbSet<Sheet1> Sheet1s { get; set; }

    public virtual DbSet<StockCa> StockCas { get; set; }

    public virtual DbSet<StockCheck> StockChecks { get; set; }

    public virtual DbSet<StockCheckpl> StockCheckpls { get; set; }

    public virtual DbSet<StockView> StockViews { get; set; }

    public virtual DbSet<StockViewtest> StockViewtests { get; set; }

    public virtual DbSet<Tag> Tags { get; set; }

    public virtual DbSet<Tagmap> Tagmaps { get; set; }

    public virtual DbSet<Tagmapbak> Tagmapbaks { get; set; }

    public virtual DbSet<Tagsbak> Tagsbaks { get; set; }

    public virtual DbSet<TemplateOcdetailsItem> TemplateOcdetailsItems { get; set; }

    public virtual DbSet<Test> Tests { get; set; }

    public virtual DbSet<UserSchoolCheck> UserSchoolChecks { get; set; }

    public virtual DbSet<VCaDetailsPack> VCaDetailsPacks { get; set; }

    public virtual DbSet<VCaDetailsPackPublic> VCaDetailsPackPublics { get; set; }

    public virtual DbSet<VCaDetailsPacknNoneQty> VCaDetailsPacknNoneQties { get; set; }

    public virtual DbSet<VCaDetailsPackpl> VCaDetailsPackpls { get; set; }

    public virtual DbSet<VCaFindCaEntity> VCaFindCaEntities { get; set; }

    public virtual DbSet<VCaGetbbl> VCaGetbbls { get; set; }

    public virtual DbSet<VCaOrder> VCaOrders { get; set; }

    public virtual DbSet<VCaProductProfileProductPrice> VCaProductProfileProductPrices { get; set; }

    public virtual DbSet<VCaProductProfileProductPricegroup> VCaProductProfileProductPricegroups { get; set; }

    public virtual DbSet<VCaUser> VCaUsers { get; set; }

    public virtual DbSet<VCaWebAccount> VCaWebAccounts { get; set; }

    public virtual DbSet<VCablastCentreDayPerStateStateSchool> VCablastCentreDayPerStateStateSchools { get; set; }

    public virtual DbSet<VCafindUser> VCafindUsers { get; set; }

    public virtual DbSet<VCagetbblnew> VCagetbblnews { get; set; }

    public virtual DbSet<VCagetcredit> VCagetcredits { get; set; }

    public virtual DbSet<VCagetprofileproduct> VCagetprofileproducts { get; set; }

    public virtual DbSet<VCagetpropackdynamic> VCagetpropackdynamics { get; set; }

    public virtual DbSet<VCahistory> VCahistories { get; set; }

    public virtual DbSet<VCaproductsize> VCaproductsizes { get; set; }

    public virtual DbSet<VCashowbbl> VCashowbbls { get; set; }

    public virtual DbSet<VGetcavredit> VGetcavredits { get; set; }

    public virtual DbSet<VGetclubDynamic> VGetclubDynamics { get; set; }

    public virtual DbSet<VSwiWebAccount> VSwiWebAccounts { get; set; }

    public virtual DbSet<Voucher> Vouchers { get; set; }

    public virtual DbSet<VoucherHistory> VoucherHistories { get; set; }

    public virtual DbSet<VoucherHistory20200428> VoucherHistory20200428s { get; set; }

    public virtual DbSet<VoucherHistoryBackAddCredit> VoucherHistoryBackAddCredits { get; set; }

    public virtual DbSet<VoucherHistoryTuanBak> VoucherHistoryTuanBaks { get; set; }

    public virtual DbSet<VouchersBackAddCredit> VouchersBackAddCredits { get; set; }

    public virtual DbSet<VouchersTuanBak> VouchersTuanBaks { get; set; }

    public virtual DbSet<Vouchersbak20200428> Vouchersbak20200428s { get; set; }

    public virtual DbSet<Warehouse> Warehouses { get; set; }

    public virtual DbSet<XmlDatum> XmlData { get; set; }

    public virtual DbSet<ZTbCheckDataEveryday> ZTbCheckDataEverydays { get; set; }

    public virtual DbSet<ZUpdatePlayHq220624> ZUpdatePlayHq220624s { get; set; }

    public virtual DbSet<ZUpdatePlayHqid> ZUpdatePlayHqids { get; set; }

    public virtual DbSet<ZUpdateReset> ZUpdateResets { get; set; }

    public virtual DbSet<Zexcel> Zexcels { get; set; }

    public virtual DbSet<Zplayerid> Zplayerids { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CaAdjustMentCreditPoint>(entity =>
        {
            entity.HasKey(e => e.AdjustmentId).HasName("PK__CA_Adjus__E60DB8B34668F0B9");

            entity.ToTable("CA_AdjustMentCreditPoint");

            entity.Property(e => e.AdjustmentId).HasColumnName("AdjustmentID");

            entity.Property(e => e.AddDate).HasColumnType("datetime");
            entity.Property(e => e.AdjustmentAmount).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<CaAdjustMentCreditPointEntityLog>(entity =>
        {
            entity.HasKey(e => e.AdjustmentId).HasName("PK__CA_Adjus__E60DB8B3CB0F54B6");

            entity.ToTable("CA_AdjustMentCreditPointEntityLog");

            entity.Property(e => e.AdjustmentId).HasColumnName("AdjustmentID");
            entity.Property(e => e.AddDate).HasColumnType("datetime");
            entity.Property(e => e.AdjustedCredit).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AdjustmentAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AssignedCredit).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AvailableCredit).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EntityId).HasMaxLength(50);
            entity.Property(e => e.TotalCredit).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UsedCredit).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<CaAusStateList>(entity =>
        {
            entity.ToTable("CA_AusStateList");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<CaAvalable>(entity =>
        {
            entity.ToTable("Ca_Avalable");

            entity.Property(e => e.Avalable).HasDefaultValueSql("((0))");
            entity.Property(e => e.CalColumnName).HasMaxLength(100);
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.EntityType).HasMaxLength(50);
            entity.Property(e => e.Unavalable).HasDefaultValueSql("((0))");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CaAvalableCheckSendMail>(entity =>
        {
            entity.ToTable("Ca_AvalableCheckSendMail");

            entity.Property(e => e.Avalable).HasDefaultValueSql("((0))");
            entity.Property(e => e.CalColumnName).HasMaxLength(100);
            entity.Property(e => e.CheckSendMail).HasDefaultValueSql("((0))");
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.EntityType).HasMaxLength(50);
            entity.Property(e => e.Unavalable).HasDefaultValueSql("((0))");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CaAvalableCheckSendMailTBak>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ca_Avala__3214EC0755D0D8CF");

            entity.ToTable("Ca_AvalableCheckSendMailT_Bak");

            entity.Property(e => e.CalColumnName).HasMaxLength(100);
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.EntityType).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CaAvalableTBak>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ca_Avala__3214EC07BB34F9C4");

            entity.ToTable("Ca_AvalableT_Bak");

            entity.Property(e => e.CalColumnName).HasMaxLength(100);
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.EntityType).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CaBbl>(entity =>
        {
            entity.ToTable("CA_BBL");

            entity.HasIndex(e => new { e.State, e.PostCode }, "IX_BBL_StatePostcode");

            entity.HasIndex(e => new { e.Id, e.ClubCode, e.Bblclud }, "indexCABBL");

            entity.Property(e => e.Bblclud)
                .HasMaxLength(50)
                .HasColumnName("BBLClud");
            entity.Property(e => e.ClubCode).HasMaxLength(10);
            entity.Property(e => e.Key).HasMaxLength(10);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.PostCode).HasMaxLength(10);
            entity.Property(e => e.Region).HasMaxLength(255);
            entity.Property(e => e.State).HasMaxLength(10);
            entity.Property(e => e.Status).HasMaxLength(10);
        });

        modelBuilder.Entity<CaBlastCentreSetting>(entity =>
        {
            entity.ToTable("CA_BlastCentreSettings");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(10);
            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CaCalculate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_clientWebAccount");

            entity.ToTable("CA_Calculate");

            entity.HasIndex(e => e.EntityId, "IX_Calculate_EntityID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AdjCredit).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CoordPackAssigned).HasColumnName("coordPackAssigned");
            entity.Property(e => e.CoordPackAvailable).HasColumnName("coordPackAvailable");
            entity.Property(e => e.CoordPackBblteam)
                .HasMaxLength(50)
                .HasColumnName("coordPackBBLTeam");
            entity.Property(e => e.CoordPackRedeemed).HasColumnName("coordPackRedeemed");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.EntityId).HasColumnName("EntityID");
            entity.Property(e => e.GrndMkrAssigned).HasColumnName("grndMkrAssigned");
            entity.Property(e => e.GrndMkrAvailable).HasColumnName("grndMkrAvailable");
            entity.Property(e => e.GrndMkrRedeemed).HasColumnName("grndMkrRedeemed");
            entity.Property(e => e.JnrCertAssigned).HasColumnName("jnrCertAssigned");
            entity.Property(e => e.JnrCertAvailable).HasColumnName("jnrCertAvailable");
            entity.Property(e => e.JnrCertRedeemed).HasColumnName("jnrCertRedeemed");
            entity.Property(e => e.JnrCredit).HasColumnName("jnrCredit");
            entity.Property(e => e.JnrMainAssigned).HasColumnName("jnrMainAssigned");
            entity.Property(e => e.JnrMainAvailable).HasColumnName("jnrMainAvailable");
            entity.Property(e => e.JnrMainConeStart).HasColumnName("jnrMainConeStart");
            entity.Property(e => e.JnrMainRedeemed).HasColumnName("jnrMainRedeemed");
            entity.Property(e => e.JnrNew).HasColumnName("jnrNEW");
            entity.Property(e => e.JnrOld).HasColumnName("jnrOLD");
            entity.Property(e => e.JnrTopUpAssigned).HasColumnName("jnrTopUpAssigned");
            entity.Property(e => e.JnrTopUpAvailable).HasColumnName("jnrTopUpAvailable");
            entity.Property(e => e.JnrTopUpRedeemed).HasColumnName("jnrTopUpRedeemed");
            entity.Property(e => e.JnrTopupConeStart)
                .HasMaxLength(50)
                .HasColumnName("jnrTopupConeStart");
            entity.Property(e => e.JnrcricketStumpsAssigned).HasColumnName("jnrcricket_stumpsAssigned");
            entity.Property(e => e.JnrcricketStumpsAvailable).HasColumnName("jnrcricket_stumpsAvailable");
            entity.Property(e => e.JnrcricketStumpsRedeemed).HasColumnName("jnrcricket_stumpsRedeemed");
            entity.Property(e => e.JnrcricketTapemesAssigned).HasColumnName("jnrcricket_tapemesAssigned");
            entity.Property(e => e.JnrcricketTapemesAvailable).HasColumnName("jnrcricket_tapemesAvailable");
            entity.Property(e => e.JnrcricketTapemesRedeemed).HasColumnName("jnrcricket_tapemesRedeemed");
            entity.Property(e => e.MainSet1)
                .HasMaxLength(50)
                .HasColumnName("main_set1");
            entity.Property(e => e.MainSet2)
                .HasMaxLength(50)
                .HasColumnName("main_set2");
            entity.Property(e => e.MainSet3)
                .HasMaxLength(50)
                .HasColumnName("main_set3");
            entity.Property(e => e.MainSet4)
                .HasMaxLength(50)
                .HasColumnName("main_set4");
            entity.Property(e => e.MstrCredit).HasColumnName("mstrCredit");
            entity.Property(e => e.MstrNew).HasColumnName("mstrNEW");
            entity.Property(e => e.MstrOld).HasColumnName("mstrOLD");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.ParticipantTotal).HasColumnName("participantTOTAL");
            entity.Property(e => e.SchlCupAssigned).HasColumnName("schl_cupAssigned");
            entity.Property(e => e.SchlCupAvailable).HasColumnName("schl_cupAvailable");
            entity.Property(e => e.SchlCupRedeemed).HasColumnName("schl_cupRedeemed");
            entity.Property(e => e.SchlHpeAssigned).HasColumnName("schl_hpeAssigned");
            entity.Property(e => e.SchlHpeAvailable).HasColumnName("schl_hpeAvailable");
            entity.Property(e => e.SchlHpeRedeemed).HasColumnName("schl_hpeRedeemed");
            entity.Property(e => e.SentDate1).HasColumnType("datetime");
            entity.Property(e => e.SentDate2).HasColumnType("datetime");
            entity.Property(e => e.TearDropFlagAssigned).HasColumnName("tearDropFlagAssigned");
            entity.Property(e => e.TearDropFlagAvailable).HasColumnName("tearDropFlagAvailable");
            entity.Property(e => e.TearDropFlagRedeemed).HasColumnName("tearDropFlagRedeemed");
            entity.Property(e => e.TotalCredit)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("totalCredit");
            entity.Property(e => e.TupSet1)
                .HasMaxLength(50)
                .HasColumnName("tup_set1");
            entity.Property(e => e.TupSet2)
                .HasMaxLength(50)
                .HasColumnName("tup_set2");
            entity.Property(e => e.TupSet3)
                .HasMaxLength(50)
                .HasColumnName("tup_set3");
            entity.Property(e => e.TupSet4)
                .HasMaxLength(50)
                .HasColumnName("tup_set4");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UsedCredit)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("usedCredit");
            entity.Property(e => e.VolPackAssigned).HasColumnName("volPackAssigned");
            entity.Property(e => e.VolPackAvailable).HasColumnName("volPackAvailable");
            entity.Property(e => e.VolPackRedeemed).HasColumnName("volPackRedeemed");
        });

        modelBuilder.Entity<CaCalculateback>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CA_Calcu__3214EC273F337DE5");

            entity.ToTable("CA_Calculateback");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AdjCredit).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CoordPackAssigned).HasColumnName("coordPackAssigned");
            entity.Property(e => e.CoordPackAvailable).HasColumnName("coordPackAvailable");
            entity.Property(e => e.CoordPackBblteam)
                .HasMaxLength(50)
                .HasColumnName("coordPackBBLTeam");
            entity.Property(e => e.CoordPackRedeemed).HasColumnName("coordPackRedeemed");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.EntityId).HasColumnName("EntityID");
            entity.Property(e => e.GrndMkrAssigned).HasColumnName("grndMkrAssigned");
            entity.Property(e => e.GrndMkrAvailable).HasColumnName("grndMkrAvailable");
            entity.Property(e => e.GrndMkrRedeemed).HasColumnName("grndMkrRedeemed");
            entity.Property(e => e.JnrCertAssigned).HasColumnName("jnrCertAssigned");
            entity.Property(e => e.JnrCertAvailable).HasColumnName("jnrCertAvailable");
            entity.Property(e => e.JnrCertRedeemed).HasColumnName("jnrCertRedeemed");
            entity.Property(e => e.JnrCredit).HasColumnName("jnrCredit");
            entity.Property(e => e.JnrMainAssigned).HasColumnName("jnrMainAssigned");
            entity.Property(e => e.JnrMainAvailable).HasColumnName("jnrMainAvailable");
            entity.Property(e => e.JnrMainConeStart).HasColumnName("jnrMainConeStart");
            entity.Property(e => e.JnrMainRedeemed).HasColumnName("jnrMainRedeemed");
            entity.Property(e => e.JnrNew).HasColumnName("jnrNEW");
            entity.Property(e => e.JnrOld).HasColumnName("jnrOLD");
            entity.Property(e => e.JnrTopUpAssigned).HasColumnName("jnrTopUpAssigned");
            entity.Property(e => e.JnrTopUpAvailable).HasColumnName("jnrTopUpAvailable");
            entity.Property(e => e.JnrTopUpRedeemed).HasColumnName("jnrTopUpRedeemed");
            entity.Property(e => e.JnrTopupConeStart)
                .HasMaxLength(50)
                .HasColumnName("jnrTopupConeStart");
            entity.Property(e => e.JnrcricketStumpsAssigned).HasColumnName("jnrcricket_stumpsAssigned");
            entity.Property(e => e.JnrcricketStumpsAvailable).HasColumnName("jnrcricket_stumpsAvailable");
            entity.Property(e => e.JnrcricketStumpsRedeemed).HasColumnName("jnrcricket_stumpsRedeemed");
            entity.Property(e => e.JnrcricketTapemesAssigned).HasColumnName("jnrcricket_tapemesAssigned");
            entity.Property(e => e.JnrcricketTapemesAvailable).HasColumnName("jnrcricket_tapemesAvailable");
            entity.Property(e => e.JnrcricketTapemesRedeemed).HasColumnName("jnrcricket_tapemesRedeemed");
            entity.Property(e => e.MainSet1)
                .HasMaxLength(50)
                .HasColumnName("main_set1");
            entity.Property(e => e.MainSet2)
                .HasMaxLength(50)
                .HasColumnName("main_set2");
            entity.Property(e => e.MainSet3)
                .HasMaxLength(50)
                .HasColumnName("main_set3");
            entity.Property(e => e.MainSet4)
                .HasMaxLength(50)
                .HasColumnName("main_set4");
            entity.Property(e => e.MstrCredit).HasColumnName("mstrCredit");
            entity.Property(e => e.MstrNew).HasColumnName("mstrNEW");
            entity.Property(e => e.MstrOld).HasColumnName("mstrOLD");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.ParticipantTotal).HasColumnName("participantTOTAL");
            entity.Property(e => e.SchlCupAssigned).HasColumnName("schl_cupAssigned");
            entity.Property(e => e.SchlCupAvailable).HasColumnName("schl_cupAvailable");
            entity.Property(e => e.SchlCupRedeemed).HasColumnName("schl_cupRedeemed");
            entity.Property(e => e.SchlHpeAssigned).HasColumnName("schl_hpeAssigned");
            entity.Property(e => e.SchlHpeAvailable).HasColumnName("schl_hpeAvailable");
            entity.Property(e => e.SchlHpeRedeemed).HasColumnName("schl_hpeRedeemed");
            entity.Property(e => e.SentDate1).HasColumnType("datetime");
            entity.Property(e => e.SentDate2).HasColumnType("datetime");
            entity.Property(e => e.TearDropFlagAssigned).HasColumnName("tearDropFlagAssigned");
            entity.Property(e => e.TearDropFlagAvailable).HasColumnName("tearDropFlagAvailable");
            entity.Property(e => e.TearDropFlagRedeemed).HasColumnName("tearDropFlagRedeemed");
            entity.Property(e => e.TotalCredit)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("totalCredit");
            entity.Property(e => e.TupSet1)
                .HasMaxLength(50)
                .HasColumnName("tup_set1");
            entity.Property(e => e.TupSet2)
                .HasMaxLength(50)
                .HasColumnName("tup_set2");
            entity.Property(e => e.TupSet3)
                .HasMaxLength(50)
                .HasColumnName("tup_set3");
            entity.Property(e => e.TupSet4)
                .HasMaxLength(50)
                .HasColumnName("tup_set4");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UsedCredit)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("usedCredit");
            entity.Property(e => e.VolPackAssigned).HasColumnName("volPackAssigned");
            entity.Property(e => e.VolPackAvailable).HasColumnName("volPackAvailable");
            entity.Property(e => e.VolPackRedeemed).HasColumnName("volPackRedeemed");
        });

        modelBuilder.Entity<CaCategory>(entity =>
        {
            entity.ToTable("Ca_Category");

            entity.Property(e => e.IsDisplay)
                .HasDefaultValueSql("((1))")
                .HasColumnName("isDisplay");
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<CaClubBbl>(entity =>
        {
            entity.ToTable("CA_ClubBBL");

            entity.HasIndex(e => new { e.ClubCode, e.Id }, "IX_ClubCode");

            entity.Property(e => e.ClubCode).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<CaConditionUpdateTransId>(entity =>
        {
            entity.ToTable("Ca_ConditionUpdateTransId");

            entity.HasIndex(e => e.IdCaProductPlayer, "IX_TransIdInParticipant");

            entity.HasIndex(e => e.TranLogFulfilmentId, "TranLogFulfilmentId");

            entity.Property(e => e.IdCaProductPlayer).HasColumnName("Id_CaProductPlayer");
            entity.Property(e => e.SendDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CaConset>(entity =>
        {
            entity.ToTable("Ca_Conset");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.VitualCodeAcalable).HasMaxLength(50);
            entity.Property(e => e.VitualCodeConCenAcalable).HasMaxLength(50);
        });

        modelBuilder.Entity<CaConsetCheck>(entity =>
        {
            entity.ToTable("CaConsetCheck");

            entity.Property(e => e.IsConset).HasColumnName("isConset");
            entity.Property(e => e.IsPkProid).HasColumnName("isPkProid");
        });

        modelBuilder.Entity<CaDayPerState>(entity =>
        {
            entity.ToTable("CA_DayPerState");

            entity.Property(e => e.State).HasMaxLength(50);
        });

        modelBuilder.Entity<CaDeleteUserLog>(entity =>
        {
            entity.ToTable("Ca_DeleteUserLogs");

            entity.Property(e => e.DeleteDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<CaEntity>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CA_Entity", tb =>
                {
                    tb.HasTrigger("TG_INSERT_TABLE_CA_ENTITY_");
                    tb.HasTrigger("TG_UPDATE_TABLE_CA_ENTITY_");
                });

            entity.Property(e => e.CapAdultVolavalable).HasColumnName("CapAdultVOLAvalable");
            entity.Property(e => e.CapAdultVolcode)
                .HasMaxLength(50)
                .HasColumnName("CapAdultVOLCode");
            entity.Property(e => e.CapAdultVolredempted).HasColumnName("CapAdultVOLRedempted");
            entity.Property(e => e.CblteardropBannerAvalable).HasColumnName("CBLTeardropBannerAvalable");
            entity.Property(e => e.CblteardropBannerCode)
                .HasMaxLength(50)
                .HasColumnName("CBLTeardropBannerCode");
            entity.Property(e => e.CblteardropBannerRedempted).HasColumnName("CBLTeardropBannerRedempted");
            entity.Property(e => e.CentreTypeDescription)
                .HasMaxLength(50)
                .HasColumnName("centreTypeDescription");
            entity.Property(e => e.CertificateBlastCode).HasMaxLength(50);
            entity.Property(e => e.Con1Code).HasMaxLength(50);
            entity.Property(e => e.Con3Code).HasMaxLength(50);
            entity.Property(e => e.Con4Code).HasMaxLength(50);
            entity.Property(e => e.Cone2).HasColumnName("cone2");
            entity.Property(e => e.Cone2Code).HasMaxLength(50);
            entity.Property(e => e.Cone3).HasColumnName("cone3");
            entity.Property(e => e.Cone4).HasColumnName("cone4");
            entity.Property(e => e.CoorPackTeam)
                .HasMaxLength(10)
                .HasColumnName("coorPackTeam");
            entity.Property(e => e.CoordPackAvailable).HasColumnName("coordPackAvailable");
            entity.Property(e => e.CoordPackCode)
                .HasMaxLength(50)
                .HasColumnName("coordPackCode");
            entity.Property(e => e.CoordPackRedempted).HasColumnName("coordPackRedempted");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DeliveryCountry).HasMaxLength(200);
            entity.Property(e => e.EnTypeExt).HasMaxLength(50);
            entity.Property(e => e.EntityId)
                .HasMaxLength(50)
                .HasColumnName("entityID");
            entity.Property(e => e.EntityName)
                .HasMaxLength(200)
                .HasColumnName("entityName");
            entity.Property(e => e.EntityPostcode)
                .HasMaxLength(10)
                .HasColumnName("entityPostcode");
            entity.Property(e => e.EntityState).HasMaxLength(50);
            entity.Property(e => e.EntityType)
                .HasMaxLength(50)
                .HasColumnName("entityType");
            entity.Property(e => e.FirstActiveSeason).HasMaxLength(50);
            entity.Property(e => e.FirstSeason).HasMaxLength(50);
            entity.Property(e => e.FirstYear).HasMaxLength(50);
            entity.Property(e => e.GetSourceFrom).HasMaxLength(100);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.InsertDate).HasColumnType("datetime");
            entity.Property(e => e.IsAddMore).HasColumnName("isAddMore");
            entity.Property(e => e.IsRedeem)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isRedeem");
            entity.Property(e => e.IsSync).HasColumnName("isSync");
            entity.Property(e => e.Jcredit).HasColumnName("JCredit");
            entity.Property(e => e.JuniorBcoordinatorEmail)
                .HasMaxLength(100)
                .HasColumnName("juniorBCoordinatorEmail");
            entity.Property(e => e.JuniorBcoordinatorName)
                .HasMaxLength(100)
                .HasColumnName("juniorBCoordinatorName");
            entity.Property(e => e.JuniorBcoordinatorPhone)
                .HasMaxLength(20)
                .HasColumnName("juniorBCoordinatorPhone");
            entity.Property(e => e.JuniorBdeliveryAddress1)
                .HasMaxLength(200)
                .HasColumnName("juniorBDeliveryAddress1");
            entity.Property(e => e.JuniorBdeliveryAddress2)
                .HasMaxLength(200)
                .HasColumnName("juniorBDeliveryAddress2");
            entity.Property(e => e.JuniorBdeliveryPostcode)
                .HasMaxLength(10)
                .HasColumnName("juniorBDeliveryPostcode");
            entity.Property(e => e.JuniorBdeliveryState)
                .HasMaxLength(50)
                .HasColumnName("juniorBDeliveryState");
            entity.Property(e => e.JuniorBdeliverySuburb)
                .HasMaxLength(100)
                .HasColumnName("juniorBDeliverySuburb");
            entity.Property(e => e.JuniorBprogramOneStartDate)
                .HasMaxLength(50)
                .HasColumnName("juniorBProgramOneStartDate");
            entity.Property(e => e.JuniorBprogramTwoStartDate)
                .HasMaxLength(50)
                .HasColumnName("juniorBProgramTwoStartDate");
            entity.Property(e => e.JuniorMainAvalaible).HasColumnName("juniorMainAvalaible");
            entity.Property(e => e.JuniorMainCode)
                .HasMaxLength(50)
                .HasColumnName("juniorMainCode");
            entity.Property(e => e.JuniorMainRedempted).HasColumnName("juniorMainRedempted");
            entity.Property(e => e.JuniorTopUpAvailable).HasColumnName("juniorTopUpAvailable");
            entity.Property(e => e.JuniorTopUpRedempted).HasColumnName("juniorTopUpRedempted");
            entity.Property(e => e.JuniorTopupCode)
                .HasMaxLength(50)
                .HasColumnName("juniorTopupCode");
            entity.Property(e => e.LegacyId)
                .HasMaxLength(50)
                .HasColumnName("LegacyID");
            entity.Property(e => e.Master2Gavailable).HasColumnName("Master2GAvailable");
            entity.Property(e => e.Master2Gcode)
                .HasMaxLength(50)
                .HasColumnName("Master2GCode");
            entity.Property(e => e.Master2Gredempted).HasColumnName("Master2GRedempted");
            entity.Property(e => e.Master4Gavailable).HasColumnName("Master4GAvailable");
            entity.Property(e => e.Master4Gcode)
                .HasMaxLength(50)
                .HasColumnName("Master4GCode");
            entity.Property(e => e.Master4Gredempted).HasColumnName("Master4GRedempted");
            entity.Property(e => e.MasterBcoordinatorEmail)
                .HasMaxLength(100)
                .HasColumnName("masterBCoordinatorEmail");
            entity.Property(e => e.MasterBcoordinatorName)
                .HasMaxLength(200)
                .HasColumnName("masterBCoordinatorName");
            entity.Property(e => e.MasterBcoordinatorPhone)
                .HasMaxLength(20)
                .HasColumnName("masterBCoordinatorPhone");
            entity.Property(e => e.MasterBdeliveryAddress1)
                .HasMaxLength(200)
                .HasColumnName("masterBDeliveryAddress1");
            entity.Property(e => e.MasterBdeliveryAddress2)
                .HasMaxLength(200)
                .HasColumnName("masterBDeliveryAddress2");
            entity.Property(e => e.MasterBdeliveryPostcode)
                .HasMaxLength(10)
                .HasColumnName("masterBDeliveryPostcode");
            entity.Property(e => e.MasterBdeliveryState)
                .HasMaxLength(50)
                .HasColumnName("masterBDeliveryState");
            entity.Property(e => e.MasterBdeliverySuburb)
                .HasMaxLength(100)
                .HasColumnName("masterBDeliverySuburb");
            entity.Property(e => e.MasterBprogramStartDate)
                .HasMaxLength(50)
                .HasColumnName("masterBProgramStartDate");
            entity.Property(e => e.Mcredit).HasColumnName("MCredit");
            entity.Property(e => e.SchoolIncentiveCode)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.SchoolPackCode).HasMaxLength(50);
            entity.Property(e => e.SchoolSportCode)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.State).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.VolPackAvailable).HasColumnName("volPackAvailable");
            entity.Property(e => e.VolPackRedempted).HasColumnName("volPackRedempted");
        });

        modelBuilder.Entity<CaEntityBk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CA_Entity");

            entity.ToTable("CA_Entity_BK", tb =>
                {
                    tb.HasTrigger("TG_INSERT_TABLE_CA_ENTITY");
                    tb.HasTrigger("TG_UPDATE_TABLE_CA_ENTITY");
                });

            entity.HasIndex(e => e.ClientWebAccountId, "ClientWebAccountId");

            entity.HasIndex(e => new { e.EntityId, e.EntityType }, "EntityID");

            entity.HasIndex(e => e.EntityType, "EntityType");

            entity.HasIndex(e => e.EntityType, "F_EntityType").HasFilter("([EntityType] IN ('Master_B', 'Junior_B', 'BOTH', 'JNR', 'public', 'TPF'))");

            entity.HasIndex(e => e.Status, "Status");

            entity.Property(e => e.CapAdultVolavalable).HasColumnName("CapAdultVOLAvalable");
            entity.Property(e => e.CapAdultVolcode)
                .HasMaxLength(50)
                .HasColumnName("CapAdultVOLCode");
            entity.Property(e => e.CapAdultVolredempted).HasColumnName("CapAdultVOLRedempted");
            entity.Property(e => e.CblteardropBannerAvalable).HasColumnName("CBLTeardropBannerAvalable");
            entity.Property(e => e.CblteardropBannerCode)
                .HasMaxLength(50)
                .HasColumnName("CBLTeardropBannerCode");
            entity.Property(e => e.CblteardropBannerRedempted).HasColumnName("CBLTeardropBannerRedempted");
            entity.Property(e => e.CentreTypeDescription)
                .HasMaxLength(50)
                .HasColumnName("centreTypeDescription");
            entity.Property(e => e.CertificateBlastCode).HasMaxLength(50);
            entity.Property(e => e.Con1Code).HasMaxLength(50);
            entity.Property(e => e.Con3Code).HasMaxLength(50);
            entity.Property(e => e.Con4Code).HasMaxLength(50);
            entity.Property(e => e.Cone2).HasColumnName("cone2");
            entity.Property(e => e.Cone2Code).HasMaxLength(50);
            entity.Property(e => e.Cone3).HasColumnName("cone3");
            entity.Property(e => e.Cone4).HasColumnName("cone4");
            entity.Property(e => e.CoorPackTeam)
                .HasMaxLength(10)
                .HasColumnName("coorPackTeam");
            entity.Property(e => e.CoordPackAvailable)
                .HasDefaultValueSql("((1))")
                .HasColumnName("coordPackAvailable");
            entity.Property(e => e.CoordPackCode)
                .HasMaxLength(50)
                .HasColumnName("coordPackCode");
            entity.Property(e => e.CoordPackRedempted).HasColumnName("coordPackRedempted");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DeliveryCountry).HasMaxLength(200);
            entity.Property(e => e.EnTypeExt).HasMaxLength(50);
            entity.Property(e => e.EntityId)
                .HasMaxLength(50)
                .HasColumnName("entityID");
            entity.Property(e => e.EntityName)
                .HasMaxLength(200)
                .HasColumnName("entityName");
            entity.Property(e => e.EntityPostcode)
                .HasMaxLength(10)
                .HasColumnName("entityPostcode");
            entity.Property(e => e.EntityState).HasMaxLength(50);
            entity.Property(e => e.EntityType)
                .HasMaxLength(50)
                .HasColumnName("entityType");
            entity.Property(e => e.FirstActiveSeason).HasMaxLength(50);
            entity.Property(e => e.FirstSeason)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.FirstYear).HasMaxLength(50);
            entity.Property(e => e.GetSourceFrom).HasMaxLength(100);
            entity.Property(e => e.InsertDate).HasColumnType("datetime");
            entity.Property(e => e.IsAddMore).HasColumnName("isAddMore");
            entity.Property(e => e.IsSync)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isSync");
            entity.Property(e => e.Jcredit).HasColumnName("JCredit");
            entity.Property(e => e.JuniorBcoordinatorEmail)
                .HasMaxLength(100)
                .HasColumnName("juniorBCoordinatorEmail");
            entity.Property(e => e.JuniorBcoordinatorName)
                .HasMaxLength(100)
                .HasColumnName("juniorBCoordinatorName");
            entity.Property(e => e.JuniorBcoordinatorPhone)
                .HasMaxLength(20)
                .HasColumnName("juniorBCoordinatorPhone");
            entity.Property(e => e.JuniorBdeliveryAddress1)
                .HasMaxLength(200)
                .HasColumnName("juniorBDeliveryAddress1");
            entity.Property(e => e.JuniorBdeliveryAddress2)
                .HasMaxLength(200)
                .HasColumnName("juniorBDeliveryAddress2");
            entity.Property(e => e.JuniorBdeliveryPostcode)
                .HasMaxLength(10)
                .HasColumnName("juniorBDeliveryPostcode");
            entity.Property(e => e.JuniorBdeliveryState)
                .HasMaxLength(50)
                .HasColumnName("juniorBDeliveryState");
            entity.Property(e => e.JuniorBdeliverySuburb)
                .HasMaxLength(100)
                .HasColumnName("juniorBDeliverySuburb");
            entity.Property(e => e.JuniorBprogramOneStartDate)
                .HasMaxLength(50)
                .HasColumnName("juniorBProgramOneStartDate");
            entity.Property(e => e.JuniorBprogramTwoStartDate)
                .HasMaxLength(50)
                .HasColumnName("juniorBProgramTwoStartDate");
            entity.Property(e => e.JuniorMainAvalaible).HasColumnName("juniorMainAvalaible");
            entity.Property(e => e.JuniorMainCode)
                .HasMaxLength(50)
                .HasColumnName("juniorMainCode");
            entity.Property(e => e.JuniorMainRedempted).HasColumnName("juniorMainRedempted");
            entity.Property(e => e.JuniorTopUpAvailable).HasColumnName("juniorTopUpAvailable");
            entity.Property(e => e.JuniorTopUpRedempted).HasColumnName("juniorTopUpRedempted");
            entity.Property(e => e.JuniorTopupCode)
                .HasMaxLength(50)
                .HasColumnName("juniorTopupCode");
            entity.Property(e => e.LegacyId)
                .HasMaxLength(50)
                .HasColumnName("LegacyID");
            entity.Property(e => e.Master2Gavailable).HasColumnName("Master2GAvailable");
            entity.Property(e => e.Master2Gcode)
                .HasMaxLength(50)
                .HasColumnName("Master2GCode");
            entity.Property(e => e.Master2Gredempted).HasColumnName("Master2GRedempted");
            entity.Property(e => e.Master4Gavailable).HasColumnName("Master4GAvailable");
            entity.Property(e => e.Master4Gcode)
                .HasMaxLength(50)
                .HasColumnName("Master4GCode");
            entity.Property(e => e.Master4Gredempted).HasColumnName("Master4GRedempted");
            entity.Property(e => e.MasterBcoordinatorEmail)
                .HasMaxLength(100)
                .HasColumnName("masterBCoordinatorEmail");
            entity.Property(e => e.MasterBcoordinatorName)
                .HasMaxLength(200)
                .HasColumnName("masterBCoordinatorName");
            entity.Property(e => e.MasterBcoordinatorPhone)
                .HasMaxLength(20)
                .HasColumnName("masterBCoordinatorPhone");
            entity.Property(e => e.MasterBdeliveryAddress1)
                .HasMaxLength(200)
                .HasColumnName("masterBDeliveryAddress1");
            entity.Property(e => e.MasterBdeliveryAddress2)
                .HasMaxLength(200)
                .HasColumnName("masterBDeliveryAddress2");
            entity.Property(e => e.MasterBdeliveryPostcode)
                .HasMaxLength(10)
                .HasColumnName("masterBDeliveryPostcode");
            entity.Property(e => e.MasterBdeliveryState)
                .HasMaxLength(50)
                .HasColumnName("masterBDeliveryState");
            entity.Property(e => e.MasterBdeliverySuburb)
                .HasMaxLength(100)
                .HasColumnName("masterBDeliverySuburb");
            entity.Property(e => e.MasterBprogramStartDate)
                .HasMaxLength(50)
                .HasColumnName("masterBProgramStartDate");
            entity.Property(e => e.Mcredit).HasColumnName("MCredit");
            entity.Property(e => e.SchoolIncentiveCode)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.SchoolPackCode).HasMaxLength(50);
            entity.Property(e => e.SchoolSportCode)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.State).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.VolPackAvailable).HasColumnName("volPackAvailable");
            entity.Property(e => e.VolPackRedempted).HasColumnName("volPackRedempted");
        });

        modelBuilder.Entity<CaImgBbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Ca_ImgBBL");

            entity.Property(e => e.Bblcode)
                .HasMaxLength(50)
                .HasColumnName("BBLCode");
            entity.Property(e => e.Img)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.PkProId).HasColumnName("pkProId");
        });

        modelBuilder.Entity<CaImgSub>(entity =>
        {
            entity.ToTable("CA_ImgSub");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Image).HasMaxLength(100);
            entity.Property(e => e.IsDisplay).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<CaImgSubBak>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CA_ImgSu__3214EC0781494ADD");

            entity.ToTable("CA_ImgSubBak");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Image).HasMaxLength(100);
        });

        modelBuilder.Entity<CaJnrcritketRaw>(entity =>
        {
            entity.ToTable("CA_JNRCritketRAW");

            entity.Property(e => e.AssociationId)
                .HasMaxLength(50)
                .HasColumnName("AssociationID");
            entity.Property(e => e.AssociationName).HasMaxLength(255);
            entity.Property(e => e.ClubId)
                .HasMaxLength(50)
                .HasColumnName("ClubID");
            entity.Property(e => e.ClubName).HasMaxLength(255);
            entity.Property(e => e.ClubPrimaryContactEmail).HasMaxLength(100);
            entity.Property(e => e.ClubPrimaryContactName).HasMaxLength(100);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.EmailTemplate).HasMaxLength(200);
            entity.Property(e => e.EntryDate).HasMaxLength(50);
            entity.Property(e => e.Grade).HasMaxLength(255);
            entity.Property(e => e.GradeId)
                .HasMaxLength(50)
                .HasColumnName("GradeID");
            entity.Property(e => e.GradeStandard).HasMaxLength(50);
            entity.Property(e => e.GradeType).HasMaxLength(50);
            entity.Property(e => e.GradeTypeId)
                .HasMaxLength(50)
                .HasColumnName("GradeTypeID");
            entity.Property(e => e.Gradeformatid).HasMaxLength(50);
            entity.Property(e => e.IsCalculated).HasColumnName("isCalculated");
            entity.Property(e => e.JuniorFormat).HasMaxLength(50);
            entity.Property(e => e.OrganisationEmail).HasMaxLength(100);
            entity.Property(e => e.OrganisationPhone).HasMaxLength(50);
            entity.Property(e => e.Rcmemail)
                .HasMaxLength(50)
                .HasColumnName("RCMEmail");
            entity.Property(e => e.SendDate).HasColumnType("datetime");
            entity.Property(e => e.State).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TeamId)
                .HasMaxLength(50)
                .HasColumnName("TeamID");
            entity.Property(e => e.TeamName).HasMaxLength(255);
            entity.Property(e => e.TransactionId).HasColumnName("TransactionID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CaModifiedEntitiesLog>(entity =>
        {
            entity.HasKey(e => e.LogId);

            entity.ToTable("CA_ModifiedEntities_Log");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedType).HasMaxLength(50);
            entity.Property(e => e.Xml).HasColumnName("XML");
        });

        modelBuilder.Entity<CaOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CA_Order");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DateUpdateStatus).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CaOrganisation>(entity =>
        {
            entity.ToTable("CA_Organisations");

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
        });

        modelBuilder.Entity<CaPlayer>(entity =>
        {
            entity.ToTable("CA_Player", tb => tb.HasTrigger("TG_INSERT_TABLE_CA_PLAYER"));

            entity.HasIndex(e => e.EntityId, "EntityID");

            entity.HasIndex(e => new { e.ProgramRefId, e.PlayerId, e.EntityId, e.Status }, "IX_ParticipantReport");

            entity.HasIndex(e => new { e.EntityId, e.Status, e.RejectionStatus, e.RejectionNote }, "IX_PlayerRejection");

            entity.HasIndex(e => e.PackChoice, "IX_Player_PackChoice");

            entity.HasIndex(e => new { e.Status, e.ManualReg }, "IX_Player_Status_ManualReg");

            entity.Property(e => e.AccountId)
                .HasMaxLength(50)
                .HasColumnName("AccountID");
            entity.Property(e => e.Address1)
                .HasMaxLength(250)
                .HasColumnName("address1");
            entity.Property(e => e.BatSendaddtype)
                .HasMaxLength(250)
                .HasColumnName("bat_sendaddtype");
            entity.Property(e => e.BatSendconnote)
                .HasMaxLength(250)
                .HasColumnName("bat_sendconnote");
            entity.Property(e => e.BatSenddate)
                .HasMaxLength(250)
                .HasColumnName("bat_senddate");
            entity.Property(e => e.BatSize)
                .HasMaxLength(250)
                .HasColumnName("batSize");
            entity.Property(e => e.BblTeam)
                .HasMaxLength(250)
                .HasColumnName("bblTeam");
            entity.Property(e => e.CodeSeason).HasMaxLength(50);
            entity.Property(e => e.Country)
                .HasMaxLength(250)
                .HasDefaultValueSql("(N'Australia')")
                .HasColumnName("country");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DeliveryAddress)
                .HasMaxLength(250)
                .HasColumnName("deliveryAddress");
            entity.Property(e => e.DeliveryAddress2)
                .HasMaxLength(200)
                .HasColumnName("deliveryAddress2");
            entity.Property(e => e.DeliveryContactEmail)
                .HasMaxLength(250)
                .HasColumnName("deliveryContactEmail");
            entity.Property(e => e.DeliveryContactNumber)
                .HasMaxLength(250)
                .HasColumnName("deliveryContactNumber");
            entity.Property(e => e.DeliveryCountry)
                .HasMaxLength(250)
                .HasColumnName("deliveryCountry");
            entity.Property(e => e.DeliveryName)
                .HasMaxLength(250)
                .HasColumnName("deliveryName");
            entity.Property(e => e.DeliveryPostcode)
                .HasMaxLength(250)
                .HasColumnName("deliveryPostcode");
            entity.Property(e => e.DeliveryState)
                .HasMaxLength(250)
                .HasColumnName("deliveryState");
            entity.Property(e => e.DeliverySuburb)
                .HasMaxLength(250)
                .HasColumnName("deliverySuburb");
            entity.Property(e => e.EntityId).HasColumnName("entityID");
            entity.Property(e => e.FirstTime).HasMaxLength(250);
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsCounted).HasMaxLength(250);
            entity.Property(e => e.IsExpressDelivery)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('AIR')")
                .HasColumnName("isExpressDelivery");
            entity.Property(e => e.ManualReg)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("manualReg");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.OrderDate)
                .HasMaxLength(250)
                .HasColumnName("order_Date");
            entity.Property(e => e.OrderId)
                .HasMaxLength(100)
                .HasColumnName("orderID");
            entity.Property(e => e.PackChoice).HasMaxLength(250);
            entity.Property(e => e.PackType)
                .HasMaxLength(250)
                .HasColumnName("packType");
            entity.Property(e => e.ParentFirstName)
                .HasMaxLength(250)
                .HasColumnName("parentFirstName");
            entity.Property(e => e.ParentLastName)
                .HasMaxLength(250)
                .HasColumnName("parentLastName");
            entity.Property(e => e.ParticipantPaid)
                .HasMaxLength(250)
                .HasColumnName("participantPaid");
            entity.Property(e => e.ParticipantRegistered)
                .HasMaxLength(250)
                .HasColumnName("participantRegistered");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(250)
                .HasColumnName("paymentMethod");
            entity.Property(e => e.PaymentStatus)
                .HasMaxLength(250)
                .HasColumnName("paymentStatus");
            entity.Property(e => e.PinkShirt)
                .HasMaxLength(250)
                .HasColumnName("pinkShirt");
            entity.Property(e => e.PlayerCategory)
                .HasMaxLength(250)
                .HasColumnName("playerCategory");
            entity.Property(e => e.PlayerFirstName)
                .HasMaxLength(250)
                .HasColumnName("playerFirstName");
            entity.Property(e => e.PlayerId)
                .HasMaxLength(250)
                .HasColumnName("playerID");
            entity.Property(e => e.PlayerLastName)
                .HasMaxLength(250)
                .HasColumnName("playerLastName");
            entity.Property(e => e.PlayerType)
                .HasMaxLength(250)
                .HasColumnName("playerType");
            entity.Property(e => e.Postcode)
                .HasMaxLength(250)
                .HasColumnName("postcode");
            entity.Property(e => e.ProgramRefId).HasMaxLength(250);
            entity.Property(e => e.ProgramStartDate).HasMaxLength(250);
            entity.Property(e => e.ProgramTypeOptionFlags).HasMaxLength(250);
            entity.Property(e => e.RegistrationDate)
                .HasMaxLength(250)
                .HasColumnName("registrationDate");
            entity.Property(e => e.RejectionNote)
                .HasMaxLength(750)
                .HasDefaultValueSql("('')")
                .HasColumnName("rejectionNote");
            entity.Property(e => e.RejectionStatus)
                .HasMaxLength(50)
                .HasDefaultValueSql("('pending')");
            entity.Property(e => e.ShirtName)
                .HasMaxLength(250)
                .HasColumnName("shirtName");
            entity.Property(e => e.ShirtSize)
                .HasMaxLength(250)
                .HasColumnName("shirtSize");
            entity.Property(e => e.State)
                .HasMaxLength(250)
                .HasColumnName("state");
            entity.Property(e => e.Status).HasMaxLength(250);
            entity.Property(e => e.Suburb)
                .HasMaxLength(250)
                .HasColumnName("suburb");
            entity.Property(e => e.TpforderId).HasColumnName("TPFOrderID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateStatus).HasMaxLength(50);
        });

        modelBuilder.Entity<CaPlayerLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CA_Playe__3214EC07D6ED32B5");

            entity.ToTable("CA_PlayerLogs");

            entity.Property(e => e.Address1)
                .HasMaxLength(250)
                .HasColumnName("address1");
            entity.Property(e => e.BatSendaddtype)
                .HasMaxLength(250)
                .HasColumnName("bat_sendaddtype");
            entity.Property(e => e.BatSendconnote)
                .HasMaxLength(250)
                .HasColumnName("bat_sendconnote");
            entity.Property(e => e.BatSenddate)
                .HasMaxLength(250)
                .HasColumnName("bat_senddate");
            entity.Property(e => e.BatSize)
                .HasMaxLength(250)
                .HasColumnName("batSize");
            entity.Property(e => e.BblTeam)
                .HasMaxLength(250)
                .HasColumnName("bblTeam");
            entity.Property(e => e.CodeSeason).HasMaxLength(50);
            entity.Property(e => e.Country)
                .HasMaxLength(250)
                .HasColumnName("country");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DeliveryAddress)
                .HasMaxLength(250)
                .HasColumnName("deliveryAddress");
            entity.Property(e => e.DeliveryContactEmail)
                .HasMaxLength(250)
                .HasColumnName("deliveryContactEmail");
            entity.Property(e => e.DeliveryContactNumber)
                .HasMaxLength(250)
                .HasColumnName("deliveryContactNumber");
            entity.Property(e => e.DeliveryCountry)
                .HasMaxLength(250)
                .HasColumnName("deliveryCountry");
            entity.Property(e => e.DeliveryName)
                .HasMaxLength(250)
                .HasColumnName("deliveryName");
            entity.Property(e => e.DeliveryPostcode)
                .HasMaxLength(250)
                .HasColumnName("deliveryPostcode");
            entity.Property(e => e.DeliveryState)
                .HasMaxLength(250)
                .HasColumnName("deliveryState");
            entity.Property(e => e.DeliverySuburb)
                .HasMaxLength(250)
                .HasColumnName("deliverySuburb");
            entity.Property(e => e.EntityId).HasColumnName("entityID");
            entity.Property(e => e.FirstTime).HasMaxLength(250);
            entity.Property(e => e.IsCounted).HasMaxLength(250);
            entity.Property(e => e.IsExpressDelivery)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("isExpressDelivery");
            entity.Property(e => e.IsUpdate)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("isUpdate");
            entity.Property(e => e.ManualReg)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("manualReg");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.PackChoice).HasMaxLength(250);
            entity.Property(e => e.PackType)
                .HasMaxLength(250)
                .HasColumnName("packType");
            entity.Property(e => e.ParentFirstName)
                .HasMaxLength(250)
                .HasColumnName("parentFirstName");
            entity.Property(e => e.ParentLastName)
                .HasMaxLength(250)
                .HasColumnName("parentLastName");
            entity.Property(e => e.ParticipantPaid)
                .HasMaxLength(250)
                .HasColumnName("participantPaid");
            entity.Property(e => e.ParticipantRegistered)
                .HasMaxLength(250)
                .HasColumnName("participantRegistered");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(250)
                .HasColumnName("paymentMethod");
            entity.Property(e => e.PaymentStatus)
                .HasMaxLength(250)
                .HasColumnName("paymentStatus");
            entity.Property(e => e.PinkShirt)
                .HasMaxLength(250)
                .HasColumnName("pinkShirt");
            entity.Property(e => e.PlayerCategory)
                .HasMaxLength(250)
                .HasColumnName("playerCategory");
            entity.Property(e => e.PlayerFirstName)
                .HasMaxLength(250)
                .HasColumnName("playerFirstName");
            entity.Property(e => e.PlayerId)
                .HasMaxLength(250)
                .HasColumnName("playerID");
            entity.Property(e => e.PlayerLastName)
                .HasMaxLength(250)
                .HasColumnName("playerLastName");
            entity.Property(e => e.PlayerType)
                .HasMaxLength(250)
                .HasColumnName("playerType");
            entity.Property(e => e.Postcode)
                .HasMaxLength(250)
                .HasColumnName("postcode");
            entity.Property(e => e.ProgramRefId).HasMaxLength(250);
            entity.Property(e => e.ProgramStartDate).HasMaxLength(250);
            entity.Property(e => e.ProgramTypeOptionFlags).HasMaxLength(250);
            entity.Property(e => e.RegistrationDate)
                .HasMaxLength(250)
                .HasColumnName("registrationDate");
            entity.Property(e => e.RejectionNote)
                .HasMaxLength(750)
                .HasColumnName("rejectionNote");
            entity.Property(e => e.RejectionStatus).HasMaxLength(50);
            entity.Property(e => e.ShirtName)
                .HasMaxLength(250)
                .HasColumnName("shirtName");
            entity.Property(e => e.ShirtSize)
                .HasMaxLength(250)
                .HasColumnName("shirtSize");
            entity.Property(e => e.State)
                .HasMaxLength(250)
                .HasColumnName("state");
            entity.Property(e => e.Status).HasMaxLength(250);
            entity.Property(e => e.Suburb)
                .HasMaxLength(250)
                .HasColumnName("suburb");
            entity.Property(e => e.TpforderId).HasColumnName("TPFOrderID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateStatus).HasMaxLength(50);
        });

        modelBuilder.Entity<CaPlayerProduct>(entity =>
        {
            entity.ToTable("CA_PlayerProduct", tb =>
                {
                    tb.HasTrigger("TG_INSERT_TABLE_CA_PlayerProduct");
                    tb.HasTrigger("TG_UPDATE_TABLE_CA_PlayerProduct");
                });

            entity.HasIndex(e => new { e.TransId, e.Colours }, "IDX_Colors_TransID");

            entity.HasIndex(e => new { e.ProgramRefId, e.PlayerId, e.TransId, e.Status }, "IX_PlayerProductInParticipant");

            entity.HasIndex(e => e.Status, "IX_PlayerProduct_Status");

            entity.Property(e => e.CaEntityId).HasMaxLength(255);
            entity.Property(e => e.Colours).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Input).HasMaxLength(255);
            entity.Property(e => e.IsHold)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isHold");
            entity.Property(e => e.IsSend).HasColumnName("isSend");
            entity.Property(e => e.IsSendProid).HasColumnName("isSendProid");
            entity.Property(e => e.ManualReg)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("manualReg");
            entity.Property(e => e.OrderId)
                .HasMaxLength(100)
                .HasColumnName("OrderID");
            entity.Property(e => e.OrderLineItem)
                .HasMaxLength(100)
                .HasColumnName("order_LineItem");
            entity.Property(e => e.OrderLineItemQty).HasColumnName("order_LineItem_QTY");
            entity.Property(e => e.PlayerId).HasMaxLength(255);
            entity.Property(e => e.ProcessMethod)
                .HasMaxLength(50)
                .HasColumnName("Process_Method");
            entity.Property(e => e.ProgramRefId).HasMaxLength(255);
            entity.Property(e => e.ProgramType).HasMaxLength(255);
            entity.Property(e => e.Size).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.TpfprodId)
                .HasMaxLength(100)
                .HasColumnName("TPFProdID");
            entity.Property(e => e.TransId)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("TransID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CaPlayerProductBak20191205>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CA_Playe__3214EC07C62AB198");

            entity.ToTable("CA_PlayerProductBAK2019_12_05");

            entity.Property(e => e.CaEntityId).HasMaxLength(255);
            entity.Property(e => e.Colours).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Input).HasMaxLength(255);
            entity.Property(e => e.PlayerId).HasMaxLength(255);
            entity.Property(e => e.ProgramRefId).HasMaxLength(255);
            entity.Property(e => e.Size).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.TpfprodId)
                .HasMaxLength(100)
                .HasColumnName("TPFProdID");
            entity.Property(e => e.TransId)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("TransID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CaPlayerProductLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CA_Playe__3214EC0706197699");

            entity.ToTable("CA_PlayerProduct_Logs");

            entity.Property(e => e.Action)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CaEntityId).HasMaxLength(255);
            entity.Property(e => e.Colours).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Input).HasMaxLength(255);
            entity.Property(e => e.PlayerId).HasMaxLength(255);
            entity.Property(e => e.ProgramRefId).HasMaxLength(255);
            entity.Property(e => e.Size).HasMaxLength(50);
            entity.Property(e => e.Sources)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.TpfprodId)
                .HasMaxLength(100)
                .HasColumnName("TPFProdID");
        });

        modelBuilder.Entity<CaPlayerProductsLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CA_Playe__3214EC076298FC83");

            entity.ToTable("CA_PlayerProducts_Log");

            entity.Property(e => e.CaEntityId).HasMaxLength(255);
            entity.Property(e => e.Colours).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Input).HasMaxLength(255);
            entity.Property(e => e.IsNewllogs).HasColumnName("isNewllogs");
            entity.Property(e => e.IsSend).HasColumnName("isSend");
            entity.Property(e => e.IsUpdateLog).HasColumnName("isUpdateLog");
            entity.Property(e => e.ManualReg)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("manualReg");
            entity.Property(e => e.PlayerId).HasMaxLength(255);
            entity.Property(e => e.ProgramRefId).HasMaxLength(255);
            entity.Property(e => e.Size).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.TpfprodId)
                .HasMaxLength(100)
                .HasColumnName("TPFProdID");
            entity.Property(e => e.TransId).HasColumnName("TransID");
            entity.Property(e => e.TransIdlogs).HasColumnName("TransIDLogs");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CaPlayerProgram>(entity =>
        {
            entity.ToTable("CA_PlayerProgram");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.EntityId)
                .HasMaxLength(50)
                .HasColumnName("EntityID");
            entity.Property(e => e.PlayerId)
                .HasMaxLength(50)
                .HasColumnName("PlayerID");
            entity.Property(e => e.ProgramId)
                .HasMaxLength(50)
                .HasColumnName("ProgramID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CaProduct>(entity =>
        {
            entity.ToTable("CA_Product");

            entity.Property(e => e.BblclubCode)
                .HasMaxLength(50)
                .HasColumnName("BBLClubCode");
            entity.Property(e => e.Bblimg).HasColumnName("BBLImg");
            entity.Property(e => e.CaBblclub).HasColumnName("CaBBLClub");
            entity.Property(e => e.CaProductType).HasDefaultValueSql("((0))");
            entity.Property(e => e.CaproductTysub).HasDefaultValueSql("((0))");
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Image).HasMaxLength(100);
            entity.Property(e => e.IsCheckQty)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isCheckQTY");
            entity.Property(e => e.IsProducType)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isProducType");
            entity.Property(e => e.IsSendF)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isSendF");
            entity.Property(e => e.IsShow)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isShow");
            entity.Property(e => e.IsShowProId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isShowProId");
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.PPriority)
                .HasDefaultValueSql("((1000))")
                .HasColumnName("p_priority");
            entity.Property(e => e.PackType)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'normal')");
            entity.Property(e => e.ProductType).HasMaxLength(50);
            entity.Property(e => e.Size).HasMaxLength(10);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StatusProduct).HasMaxLength(50);
            entity.Property(e => e.Type).HasDefaultValueSql("((1))");
            entity.Property(e => e.VirtualCode).HasMaxLength(50);
        });

        modelBuilder.Entity<CaProductBblclub>(entity =>
        {
            entity.ToTable("CaProductBBLClub");

            entity.Property(e => e.IdBbLclub).HasColumnName("IdBbLClub");
            entity.Property(e => e.IsDisplay)
                .HasDefaultValueSql("((1))")
                .HasColumnName("isDisplay");
        });

        modelBuilder.Entity<CaProductPreview>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CaProductPreview");

            entity.Property(e => e.BblclubCode)
                .HasMaxLength(255)
                .HasColumnName("BBLClubCode");
            entity.Property(e => e.Bblimg)
                .HasMaxLength(255)
                .HasColumnName("BBLImg");
            entity.Property(e => e.CaBblclub)
                .HasMaxLength(255)
                .HasColumnName("CaBBLClub");
            entity.Property(e => e.CaProductType).HasMaxLength(255);
            entity.Property(e => e.CaproductTysub).HasMaxLength(255);
            entity.Property(e => e.Code).HasMaxLength(255);
            entity.Property(e => e.CreateDate).HasMaxLength(255);
            entity.Property(e => e.Image).HasMaxLength(255);
            entity.Property(e => e.IsCheckQty)
                .HasMaxLength(255)
                .HasColumnName("isCheckQTY");
            entity.Property(e => e.IsProducType).HasColumnName("isProducType");
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.PPriority).HasColumnName("p_priority");
            entity.Property(e => e.PackType).HasMaxLength(255);
            entity.Property(e => e.ProductType).HasMaxLength(255);
            entity.Property(e => e.Size).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(255);
            entity.Property(e => e.StatusProduct).HasMaxLength(255);
            entity.Property(e => e.VirtualCode).HasMaxLength(255);
            entity.Property(e => e.Weight).HasMaxLength(255);
        });

        modelBuilder.Entity<CaProductProfilePreview>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CaProductProfilePreview");

            entity.Property(e => e.Currency)
                .HasMaxLength(255)
                .HasColumnName("currency");
            entity.Property(e => e.Currentprice).HasColumnName("currentprice");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Lastmodified)
                .HasColumnType("datetime")
                .HasColumnName("lastmodified");
            entity.Property(e => e.Legacyfield)
                .HasMaxLength(255)
                .HasColumnName("legacyfield");
            entity.Property(e => e.Profileid).HasColumnName("profileid");
            entity.Property(e => e.Proid).HasColumnName("proid");
            entity.Property(e => e.RebatePercentage).HasColumnName("rebate_percentage");
            entity.Property(e => e.Taxrate).HasColumnName("taxrate");
            entity.Property(e => e.Wasprice).HasColumnName("wasprice");
        });

        modelBuilder.Entity<CaProductTable>(entity =>
        {
            entity.ToTable("CA_ProductTable");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Environment).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.RegType).HasMaxLength(255);
            entity.Property(e => e.ReqBatSize).HasColumnName("Req_batSize");
            entity.Property(e => e.ReqColour).HasColumnName("Req_Colour");
            entity.Property(e => e.ReqFirstTime).HasColumnName("Req_FirstTime");
            entity.Property(e => e.ReqInput).HasColumnName("Req_Input");
            entity.Property(e => e.ReqPackChoice).HasColumnName("Req_packChoice");
            entity.Property(e => e.ReqShirtSize).HasColumnName("Req_shirtSize");
            entity.Property(e => e.ReqSize).HasColumnName("Req_Size");
            entity.Property(e => e.Source).HasMaxLength(255);
            entity.Property(e => e.TpfprodId)
                .HasMaxLength(255)
                .HasColumnName("TPFProdID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CaProductTbak>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CA_Produ__3214EC07D6578687");

            entity.ToTable("CA_ProductTBak");

            entity.Property(e => e.BblclubCode)
                .HasMaxLength(50)
                .HasColumnName("BBLClubCode");
            entity.Property(e => e.Bblimg).HasColumnName("BBLImg");
            entity.Property(e => e.CaBblclub).HasColumnName("CaBBLClub");
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Image).HasMaxLength(100);
            entity.Property(e => e.IsCheckQty).HasColumnName("isCheckQTY");
            entity.Property(e => e.IsProducType).HasColumnName("isProducType");
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.PPriority).HasColumnName("p_priority");
            entity.Property(e => e.PackType).HasMaxLength(20);
            entity.Property(e => e.ProductType).HasMaxLength(50);
            entity.Property(e => e.Size).HasMaxLength(10);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StatusProduct).HasMaxLength(50);
            entity.Property(e => e.VirtualCode).HasMaxLength(50);
        });

        modelBuilder.Entity<CaProductType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CA_Produ__3214EC0718916725");

            entity.ToTable("CA_ProductType");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.ProductType).HasMaxLength(50);
        });

        modelBuilder.Entity<CaProductType1>(entity =>
        {
            entity.ToTable("Ca_ProductTypes");

            entity.Property(e => e.NameType).HasMaxLength(200);
        });

        modelBuilder.Entity<CaProductTypeSub>(entity =>
        {
            entity.ToTable("CA_ProductTypeSub");

            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<CaProductTypeTu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CA_Produ__3214EC071B9D955D");

            entity.ToTable("CA_ProductTypeTu");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.ProductType).HasMaxLength(50);
        });

        modelBuilder.Entity<CaProgram>(entity =>
        {
            entity.ToTable("CA_Program", tb => tb.HasTrigger("TG_INSERT_TABLE_CA_PROGRAM"));

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DeliveryDate1).HasColumnType("date");
            entity.Property(e => e.DeliveryDate2).HasColumnType("date");
            entity.Property(e => e.EntityId)
                .HasMaxLength(50)
                .HasColumnName("EntityID");
            entity.Property(e => e.ProgramCoordName).HasMaxLength(255);
            entity.Property(e => e.ProgramCoordPhone).HasMaxLength(50);
            entity.Property(e => e.ProgramId)
                .HasMaxLength(50)
                .HasColumnName("ProgramID");
            entity.Property(e => e.ProgramName).HasMaxLength(100);
            entity.Property(e => e.ProgramStartDate).HasMaxLength(50);
            entity.Property(e => e.ProgramType).HasMaxLength(50);
            entity.Property(e => e.ProgrameCoordEmail).HasMaxLength(100);
            entity.Property(e => e.SeasonId)
                .HasMaxLength(50)
                .HasColumnName("SeasonID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CaPromo>(entity =>
        {
            entity.ToTable("CA_Promo");

            entity.Property(e => e.ApplyFor).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DiscountAmount).HasDefaultValueSql("((0))");
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.PromoName).HasMaxLength(200);
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CaPropackDetail>(entity =>
        {
            entity.ToTable("Ca_PropackDetails");
        });

        modelBuilder.Entity<CaRedeem>(entity =>
        {
            entity.ToTable("CA_Redeem");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CaRedeemNew>(entity =>
        {
            entity.ToTable("CA_RedeemNew");

            entity.Property(e => e.ApplyFor).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CaSchoolOrgContact>(entity =>
        {
            entity.ToTable("CA_SchoolOrgContact");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.OrgId).HasMaxLength(50);
            entity.Property(e => e.SchoolUser).HasMaxLength(50);
            entity.Property(e => e.TransId).HasColumnName("TransID");
        });

        modelBuilder.Entity<CaSchoolOrgContactBak20201303>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CA_SchoolOrgContactBak2020_13_03");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.OrgId).HasMaxLength(50);
            entity.Property(e => e.SchoolUser).HasMaxLength(50);
            entity.Property(e => e.TransId).HasColumnName("TransID");
        });

        modelBuilder.Entity<CaSchoolOrgContactBakDelete>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CA_SchoolOrgContactBakDelete");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.OrgId).HasMaxLength(50);
            entity.Property(e => e.SchoolUser).HasMaxLength(50);
            entity.Property(e => e.TransId).HasColumnName("TransID");
        });

        modelBuilder.Entity<CaSchoolOrgContactBakDelete20200311>(entity =>
        {
            entity.ToTable("CA_SchoolOrgContactBakDelete2020_03_11");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.OrgId).HasMaxLength(50);
            entity.Property(e => e.SchoolUser).HasMaxLength(1);
            entity.Property(e => e.TransId).HasColumnName("TransID");
        });

        modelBuilder.Entity<CaSchoolOrgContactBakUpdateOrgId>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CA_Schoo__3214EC07EF0D1760");

            entity.ToTable("CA_SchoolOrgContactBakUpdateOrgId");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.OrgId).HasMaxLength(50);
            entity.Property(e => e.SchoolUser).HasMaxLength(50);
            entity.Property(e => e.TransId).HasColumnName("TransID");
        });

        modelBuilder.Entity<CaSchoolOrgContactRestore>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CA_SchoolOrgContactRestore");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.OrgId).HasMaxLength(50);
            entity.Property(e => e.SchoolUser).HasMaxLength(50);
            entity.Property(e => e.TransId).HasColumnName("TransID");
        });

        modelBuilder.Entity<CaSchoolOrganisationStatus>(entity =>
        {
            entity.ToTable("CA_SchoolOrganisationStatus");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DefaultBbl)
                .HasMaxLength(50)
                .HasColumnName("DefaultBBL");
            entity.Property(e => e.IsDup).HasColumnName("isDup");
            entity.Property(e => e.LegacyId)
                .HasMaxLength(50)
                .HasColumnName("LegacyID");
            entity.Property(e => e.Organisation).HasMaxLength(100);
            entity.Property(e => e.OrganisationId)
                .HasMaxLength(50)
                .HasColumnName("OrganisationID");
            entity.Property(e => e.SchoolUserId).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TransId).HasColumnName("TransID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CaSchoolOrganisationStatusBakUpdateOrgId>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CA_Schoo__3214EC0741EF60C3");

            entity.ToTable("CA_SchoolOrganisationStatusBakUpdateOrgId");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DefaultBbl)
                .HasMaxLength(50)
                .HasColumnName("DefaultBBL");
            entity.Property(e => e.LegacyId)
                .HasMaxLength(50)
                .HasColumnName("LegacyID");
            entity.Property(e => e.Organisation).HasMaxLength(100);
            entity.Property(e => e.OrganisationId)
                .HasMaxLength(50)
                .HasColumnName("OrganisationID");
            entity.Property(e => e.SchoolUserId).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TransId).HasColumnName("TransID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CaSchoolOrganisationStatusBakup20201203>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CA_SchoolOrganisationStatusBakup2020_12_03");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DefaultBbl)
                .HasMaxLength(50)
                .HasColumnName("DefaultBBL");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.LegacyId)
                .HasMaxLength(50)
                .HasColumnName("LegacyID");
            entity.Property(e => e.Organisation).HasMaxLength(100);
            entity.Property(e => e.OrganisationId)
                .HasMaxLength(50)
                .HasColumnName("OrganisationID");
            entity.Property(e => e.SchoolUserId).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TransId).HasColumnName("TransID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CaSchoolUpdateChangeAccount>(entity =>
        {
            entity.ToTable("Ca_SchoolUpdateChangeAccount");

            entity.Property(e => e.ContactEmail).HasMaxLength(200);
            entity.Property(e => e.ContactId).HasMaxLength(200);
            entity.Property(e => e.GyId).HasMaxLength(200);
            entity.Property(e => e.OldAccount).HasMaxLength(200);
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CaSchoolUserEntitlementRaw>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CA_SchoolEntitlementRAW");

            entity.ToTable("CA_SchoolUserEntitlementRAW");

            entity.Property(e => e.ActivityId)
                .HasMaxLength(50)
                .HasColumnName("ActivityID");
            entity.Property(e => e.AddressLine1).HasMaxLength(255);
            entity.Property(e => e.AddressLine2).HasMaxLength(255);
            entity.Property(e => e.Bblteam)
                .HasMaxLength(50)
                .HasColumnName("BBLTeam");
            entity.Property(e => e.ContactEmail).HasMaxLength(150);
            entity.Property(e => e.ContactName).HasMaxLength(50);
            entity.Property(e => e.ContactPhone).HasMaxLength(50);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EmailTemplate).HasMaxLength(200);
            entity.Property(e => e.FulfilmentId)
                .HasMaxLength(200)
                .HasColumnName("FulfilmentID");
            entity.Property(e => e.GigyaId)
                .HasMaxLength(200)
                .HasColumnName("GigyaID");
            entity.Property(e => e.IsCalculated).HasColumnName("isCalculated");
            entity.Property(e => e.IsHpe).HasColumnName("isHPE");
            entity.Property(e => e.NoClasses).HasMaxLength(50);
            entity.Property(e => e.NoParticipants).HasMaxLength(50);
            entity.Property(e => e.Organisation).HasMaxLength(255);
            entity.Property(e => e.OrgansationId)
                .HasMaxLength(50)
                .HasColumnName("OrgansationID");
            entity.Property(e => e.Postcode).HasMaxLength(50);
            entity.Property(e => e.SendDate).HasColumnType("datetime");
            entity.Property(e => e.State).HasMaxLength(50);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Suburb).HasMaxLength(50);
            entity.Property(e => e.TpforderId).HasColumnName("TPFOrderID");
            entity.Property(e => e.TransId).HasColumnName("TransID");
            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UploadedWebAccId).HasColumnName("UploadedWebAccID");
        });

        modelBuilder.Entity<CaSchoolUserOrganisationRaw>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CA_SchoolUserRAW");

            entity.ToTable("CA_SchoolUserOrganisationRAW");

            entity.Property(e => e.Action).HasMaxLength(50);
            entity.Property(e => e.ContactEmail).HasMaxLength(50);
            entity.Property(e => e.ContactId)
                .HasMaxLength(255)
                .HasColumnName("ContactID");
            entity.Property(e => e.ContactName).HasMaxLength(50);
            entity.Property(e => e.ContactPhone).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DefaultBbl)
                .HasMaxLength(255)
                .HasColumnName("DefaultBBL");
            entity.Property(e => e.EmailTemplate).HasMaxLength(200);
            entity.Property(e => e.GigyaId)
                .HasMaxLength(200)
                .HasColumnName("GigyaID");
            entity.Property(e => e.Organisation).HasMaxLength(255);
            entity.Property(e => e.OrganisationId)
                .HasMaxLength(255)
                .HasColumnName("OrganisationID");
            entity.Property(e => e.RelationshipId)
                .HasMaxLength(255)
                .HasColumnName("RelationshipID");
            entity.Property(e => e.SendDate).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TransactionId).HasColumnName("TransactionID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CaSchoolUserStatus>(entity =>
        {
            entity.ToTable("CA_SchoolUserStatus");

            entity.HasIndex(e => new { e.AccountStatus, e.EntityId }, "IX_SchoolUserStatus_EntityID");

            entity.Property(e => e.AccountStatus).HasMaxLength(50);
            entity.Property(e => e.ContactEmail).HasMaxLength(100);
            entity.Property(e => e.ContactId)
                .HasMaxLength(50)
                .HasColumnName("ContactID");
            entity.Property(e => e.ContactName).HasMaxLength(50);
            entity.Property(e => e.ContactPhone).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedOrderDate).HasColumnType("datetime");
            entity.Property(e => e.DefaultBbl)
                .HasMaxLength(500)
                .HasColumnName("DefaultBBL");
            entity.Property(e => e.EntityId).HasColumnName("EntityID");
            entity.Property(e => e.GigyaId)
                .HasMaxLength(200)
                .HasColumnName("GigyaID");
            entity.Property(e => e.LegacyId)
                .HasMaxLength(50)
                .HasColumnName("LegacyID");
            entity.Property(e => e.TpfgigyaId)
                .HasMaxLength(200)
                .HasColumnName("TPFGigyaID");
            entity.Property(e => e.TransId).HasColumnName("TransID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CaSchoolUserStatusBak201909013>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CA_Schoo__3214EC07925035CC");

            entity.ToTable("CA_SchoolUserStatusBak2019_090_13");

            entity.Property(e => e.AccountStatus).HasMaxLength(50);
            entity.Property(e => e.ContactEmail).HasMaxLength(100);
            entity.Property(e => e.ContactId)
                .HasMaxLength(50)
                .HasColumnName("ContactID");
            entity.Property(e => e.ContactName).HasMaxLength(50);
            entity.Property(e => e.ContactPhone).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedOrderDate).HasColumnType("datetime");
            entity.Property(e => e.DefaultBbl)
                .HasMaxLength(500)
                .HasColumnName("DefaultBBL");
            entity.Property(e => e.EntityId).HasColumnName("EntityID");
            entity.Property(e => e.TransId).HasColumnName("TransID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CaSchoolUserStatusBakUpdateContactId>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CA_Schoo__3214EC07A98EB8E2");

            entity.ToTable("CA_SchoolUserStatus_BakUpdateContactId");

            entity.Property(e => e.AccountStatus).HasMaxLength(50);
            entity.Property(e => e.ContactEmail).HasMaxLength(100);
            entity.Property(e => e.ContactId)
                .HasMaxLength(50)
                .HasColumnName("ContactID");
            entity.Property(e => e.ContactName).HasMaxLength(50);
            entity.Property(e => e.ContactPhone).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedOrderDate).HasColumnType("datetime");
            entity.Property(e => e.DefaultBbl)
                .HasMaxLength(500)
                .HasColumnName("DefaultBBL");
            entity.Property(e => e.EntityId).HasColumnName("EntityID");
            entity.Property(e => e.GigyaId)
                .HasMaxLength(200)
                .HasColumnName("GigyaID");
            entity.Property(e => e.LegacyId)
                .HasMaxLength(50)
                .HasColumnName("LegacyID");
            entity.Property(e => e.TransId).HasColumnName("TransID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CaSeason>(entity =>
        {
            entity.ToTable("CA_Season");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CaStateSchool>(entity =>
        {
            entity.ToTable("CA_StateSchool");

            entity.Property(e => e.EndDay).HasColumnType("datetime");
            entity.Property(e => e.StartDay).HasColumnType("datetime");
            entity.Property(e => e.StateId)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.StateName).HasMaxLength(100);
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<CaTag>(entity =>
        {
            entity.ToTable("CA_Tag");

            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<CaTagProdetail>(entity =>
        {
            entity.ToTable("CA_tag_prodetail");

            entity.Property(e => e.ProdetailCode).HasMaxLength(50);
        });

        modelBuilder.Entity<CaTranLogFulfilment>(entity =>
        {
            entity.HasKey(e => e.TranLogFulfilmentId);

            entity.ToTable("Ca_TranLogFulfilment");

            entity.Property(e => e.TransId).HasColumnName("TransID");
            entity.Property(e => e.Transdate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CaTransactionLog>(entity =>
        {
            entity.ToTable("CA_TransactionLog");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.OrderStatus).HasMaxLength(100);
            entity.Property(e => e.OrderType).HasMaxLength(100);
        });

        modelBuilder.Entity<CaTypeDetail>(entity =>
        {
            entity.Property(e => e.IdCaBbl).HasColumnName("IdCaBBL");
            entity.Property(e => e.IdCaSub).HasDefaultValueSql("((0))");
            entity.Property(e => e.IsDisplay).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<CatVoucher>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.ToTable("catVoucher");

            entity.HasIndex(e => e.CatId, "catid")
                .IsClustered()
                .HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Accesslevel)
                .HasDefaultValueSql("((5))")
                .HasColumnName("accesslevel");
            entity.Property(e => e.Autoset).HasColumnName("autoset");
            entity.Property(e => e.CatId).HasColumnName("catID");
            entity.Property(e => e.Deactivate).HasColumnName("deactivate");
            entity.Property(e => e.Displayname)
                .HasMaxLength(100)
                .HasColumnName("displayname");
            entity.Property(e => e.Minspend)
                .HasDefaultValueSql("((0.00))")
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("minspend");
            entity.Property(e => e.NeedsToActivate).HasColumnName("needs_to_activate");
            entity.Property(e => e.RecordActive)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("recordActive");
            entity.Property(e => e.RecordExpiry)
                .HasDefaultValueSql("(((2008)-(10))-(15))")
                .HasColumnType("datetime")
                .HasColumnName("recordExpiry");
            entity.Property(e => e.RecordMatch)
                .HasMaxLength(50)
                .HasColumnName("recordMatch");
            entity.Property(e => e.RecordValue).HasColumnName("recordValue");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('yes')")
                .IsFixedLength()
                .HasColumnName("status");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");
            entity.Property(e => e.Units)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'dollars')")
                .HasColumnName("units");
            entity.Property(e => e.UserId).HasColumnName("userID");
        });

        modelBuilder.Entity<Catalogue>(entity =>
        {
            entity.ToTable("catalogue");

            entity.Property(e => e.CatalogueId).HasColumnName("catalogueID");
            entity.Property(e => e.Assetsfolder)
                .HasMaxLength(50)
                .HasColumnName("assetsfolder");
            entity.Property(e => e.AutoDeliveryRequest)
                .HasDefaultValueSql("((1))")
                .HasColumnName("autoDeliveryRequest");
            entity.Property(e => e.BdcNo)
                .HasDefaultValueSql("((0))")
                .HasColumnName("bdcNo");
            entity.Property(e => e.Cataloguegroup)
                .HasMaxLength(50)
                .HasColumnName("cataloguegroup");
            entity.Property(e => e.Cataloguename)
                .HasMaxLength(80)
                .HasColumnName("cataloguename");
            entity.Property(e => e.Catstatus)
                .HasMaxLength(15)
                .HasDefaultValueSql("(N'yes')")
                .HasColumnName("catstatus");
            entity.Property(e => e.ClientId).HasColumnName("clientID");
            entity.Property(e => e.Code)
                .HasMaxLength(4)
                .HasColumnName("code");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createDate");
            entity.Property(e => e.DefaultEntityId)
                .HasDefaultValueSql("((9))")
                .HasColumnName("defaultEntityId");
            entity.Property(e => e.Display)
                .HasMaxLength(50)
                .HasDefaultValueSql("('y')")
                .HasComment("Display is used for inventory access")
                .HasColumnName("display");
            entity.Property(e => e.Emailcat)
                .HasMaxLength(40)
                .HasColumnName("emailcat");
            entity.Property(e => e.Emailrec)
                .HasMaxLength(40)
                .HasColumnName("emailrec");
            entity.Property(e => e.Folder)
                .HasMaxLength(80)
                .HasColumnName("folder");
            entity.Property(e => e.FreeNumber)
                .HasMaxLength(20)
                .HasColumnName("freeNumber");
            entity.Property(e => e.Freightcat)
                .HasMaxLength(10)
                .HasDefaultValueSql("('YES')")
                .HasColumnName("freightcat");
            entity.Property(e => e.Googleid)
                .HasMaxLength(20)
                .HasColumnName("googleid");
            entity.Property(e => e.InvCatalogueId)
                .HasComment("If catalogue shares inventory of another cataogue as base stock, then refer to this u.. used by Personalisation REPORTING SP")
                .HasColumnName("invCatalogueID");
            entity.Property(e => e.IsAutoApproved).HasColumnName("isAutoApproved");
            entity.Property(e => e.IsEvent).HasColumnName("isEvent");
            entity.Property(e => e.Lastmodified)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("lastmodified");
            entity.Property(e => e.LivehelpId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("livehelpID");
            entity.Property(e => e.Login)
                .HasMaxLength(50)
                .HasDefaultValueSql("('NO')")
                .HasColumnName("login");
            entity.Property(e => e.Magentokey)
                .HasMaxLength(20)
                .HasColumnName("magentokey");
            entity.Property(e => e.OrderingSystem)
                .HasDefaultValueSql("((7000))")
                .HasColumnName("orderingSystem");
            entity.Property(e => e.PartofReportingSystem)
                .HasDefaultValueSql("((0))")
                .HasColumnName("partofReportingSystem");
            entity.Property(e => e.Payoptions)
                .HasMaxLength(50)
                .HasDefaultValueSql("('creditcard')")
                .HasColumnName("payoptions");
            entity.Property(e => e.ReorderNo).HasColumnName("reorderNo");
            entity.Property(e => e.Sellcurrency)
                .HasMaxLength(50)
                .HasDefaultValueSql("('AUD')")
                .HasColumnName("sellcurrency");
            entity.Property(e => e.SendwithGoods)
                .HasMaxLength(16)
                .HasDefaultValueSql("(N'creditcard')")
                .HasColumnName("sendwithGoods");
            entity.Property(e => e.Staffid).HasColumnName("staffid");
            entity.Property(e => e.Stocknotification)
                .HasMaxLength(50)
                .HasColumnName("stocknotification");
            entity.Property(e => e.ToBeInvoiced)
                .HasMaxLength(16)
                .HasDefaultValueSql("(N'creditcard')")
                .HasColumnName("toBeInvoiced");
            entity.Property(e => e.TpfcontactName)
                .HasMaxLength(50)
                .HasColumnName("TPFcontactName");
            entity.Property(e => e.Urladdress)
                .HasMaxLength(200)
                .HasColumnName("urladdress");
            entity.Property(e => e.UsingDotNet)
                .HasDefaultValueSql("((1))")
                .HasColumnName("usingDotNet");
        });

        modelBuilder.Entity<CatalogueLiveHelpSetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Catalogue_LiveHelpSettings");

            entity.Property(e => e.ButtonId).HasColumnName("ButtonID");
            entity.Property(e => e.CatalogueId).HasColumnName("catalogueID");
            entity.Property(e => e.Custom1)
                .HasMaxLength(150)
                .HasColumnName("custom1");
            entity.Property(e => e.Custom2)
                .HasMaxLength(50)
                .HasColumnName("custom2");
            entity.Property(e => e.Custom3)
                .HasMaxLength(50)
                .HasColumnName("custom3");
            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<CataloguePaymentMethod>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("catalogue_payment_methods");

            entity.Property(e => e.Catalogueid).HasColumnName("catalogueid");
            entity.Property(e => e.Country).HasColumnName("country");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .HasColumnName("type");
        });

        modelBuilder.Entity<CatalogueSeo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("catalogue_SEO");

            entity.Property(e => e.Author).HasMaxLength(200);
            entity.Property(e => e.CatalogueId).HasColumnName("CatalogueID");
            entity.Property(e => e.Language).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(500);
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CategoryId).IsClustered(false);

            entity.ToTable("category");

            entity.Property(e => e.CategoryId).HasColumnName("categoryID");
            entity.Property(e => e.CatalogueId).HasColumnName("catalogueID");
            entity.Property(e => e.Categoryname)
                .HasMaxLength(40)
                .HasColumnName("categoryname");
            entity.Property(e => e.Catestatus)
                .HasMaxLength(15)
                .HasColumnName("catestatus");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .HasColumnName("description");
            entity.Property(e => e.Discatpriority).HasColumnName("discatpriority");
            entity.Property(e => e.Imagename)
                .HasMaxLength(150)
                .HasColumnName("imagename");
            entity.Property(e => e.Lastmodified).HasColumnName("lastmodified");
        });

        modelBuilder.Entity<CheckNewPrice>(entity =>
        {
            entity.ToTable("CheckNewPrice");

            entity.Property(e => e.CaPrice).HasColumnName("Ca_Price");
            entity.Property(e => e.CentrePrice).HasColumnName("Centre_Price");
            entity.Property(e => e.Code).HasMaxLength(200);
            entity.Property(e => e.StatePrice).HasColumnName("State_Price");
        });

        modelBuilder.Entity<CheckOrge>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__checkOrg__3214EC07EDC91C42");

            entity.ToTable("checkOrge");

            entity.Property(e => e.LegacyId)
                .HasMaxLength(250)
                .HasColumnName("LegacyID");
            entity.Property(e => e.NewIds)
                .HasMaxLength(200)
                .HasColumnName("NewIDs");
            entity.Property(e => e.OrganisationName).HasMaxLength(250);
        });

        modelBuilder.Entity<CheckPriceCa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CheckPri__3214EC07BEBA4C98");

            entity.ToTable("CheckPriceCa");

            entity.Property(e => e.CaPrice)
                .HasMaxLength(250)
                .HasColumnName("Ca_Price");
            entity.Property(e => e.Category).HasMaxLength(250);
            entity.Property(e => e.CentrePrice)
                .HasMaxLength(250)
                .HasColumnName("Centre_Price");
            entity.Property(e => e.Code).HasMaxLength(250);
            entity.Property(e => e.JuniorPrice)
                .HasMaxLength(250)
                .HasColumnName("Junior_Price");
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.PublicPrice)
                .HasMaxLength(250)
                .HasColumnName("Public_Price");
            entity.Property(e => e.SchoolPrice)
                .HasMaxLength(250)
                .HasColumnName("School_Price");
            entity.Property(e => e.StatePrice)
                .HasMaxLength(50)
                .HasColumnName("State_Price");
        });

        modelBuilder.Entity<CheckProdetailId>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CheckProdetailId");

            entity.Property(e => e.Colours).HasMaxLength(200);
            entity.Property(e => e.Descriptions).HasMaxLength(200);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.ProdetailId).HasMaxLength(200);
            entity.Property(e => e.Size).HasMaxLength(200);
        });

        modelBuilder.Entity<ComSyncLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Com_log");

            entity.ToTable("Com_SyncLog");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createDate");
            entity.Property(e => e.MessErg).IsUnicode(false);
            entity.Property(e => e.Params).IsUnicode(false);
            entity.Property(e => e.Ref)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ref");
        });

        modelBuilder.Entity<CustProfile>(entity =>
        {
            entity.ToTable("cust_profile");

            entity.HasIndex(e => e.Id, "IX_CustProfile_ID").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Catalogueid).HasColumnName("catalogueid");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Currency)
                .HasMaxLength(20)
                .HasColumnName("currency");
            entity.Property(e => e.Isdefault).HasColumnName("isdefault");
            entity.Property(e => e.Lastmodified).HasColumnName("lastmodified");
            entity.Property(e => e.Legacyfield)
                .HasMaxLength(20)
                .HasColumnName("legacyfield");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Notes)
                .HasColumnType("ntext")
                .HasColumnName("notes");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("status");
            entity.Property(e => e.Taxexclusive).HasColumnName("taxexclusive");
        });

        modelBuilder.Entity<CustProfileBakUpProfile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__cust_pro__3213E83FD7F7EE03");

            entity.ToTable("cust_profileBakUpProfile");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Catalogueid).HasColumnName("catalogueid");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Currency)
                .HasMaxLength(20)
                .HasColumnName("currency");
            entity.Property(e => e.Isdefault).HasColumnName("isdefault");
            entity.Property(e => e.Lastmodified).HasColumnName("lastmodified");
            entity.Property(e => e.Legacyfield)
                .HasMaxLength(20)
                .HasColumnName("legacyfield");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Notes)
                .HasColumnType("ntext")
                .HasColumnName("notes");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("status");
            entity.Property(e => e.Taxexclusive).HasColumnName("taxexclusive");
        });

        modelBuilder.Entity<FinanceCurrency>(entity =>
        {
            entity.ToTable("FinanceCurrency");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Currency)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Currency2)
                .HasMaxLength(2)
                .HasDefaultValueSql("('')")
                .HasComment("Client Site Use ONLY")
                .HasColumnName("currency2");
            entity.Property(e => e.CurrencyId).HasColumnName("currencyID");
            entity.Property(e => e.EntityId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("entityID");
            entity.Property(e => e.Exchangerate).HasColumnName("exchangerate");
            entity.Property(e => e.Lastupdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("lastupdate");
            entity.Property(e => e.Remarks)
                .HasMaxLength(80)
                .HasDefaultValueSql("('')")
                .HasColumnName("remarks");
            entity.Property(e => e.Status)
                .HasMaxLength(15)
                .HasDefaultValueSql("('current')")
                .HasColumnName("status");
            entity.Property(e => e.UnicodeSymbol)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasColumnName("unicode_symbol");
            entity.Property(e => e.Updateby)
                .HasDefaultValueSql("((0))")
                .HasColumnName("updateby");
            entity.Property(e => e.WebUpdate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Client Site Use ONLY")
                .HasColumnType("datetime")
                .HasColumnName("webUpdate");
            entity.Property(e => e.Webrate)
                .HasDefaultValueSql("((1))")
                .HasComment("Client Site Use ONLY")
                .HasColumnName("webrate");
        });

        modelBuilder.Entity<GroupTransactionFf>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GroupTransactionFF");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TransId)
                .ValueGeneratedOnAdd()
                .HasColumnName("TransID");
            entity.Property(e => e.TransType).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImportTransaction>(entity =>
        {
            entity.HasKey(e => e.TransId).HasName("PK__Import_T__9E5DDB1CB874B11C");

            entity.ToTable("Import_Transaction");

            entity.Property(e => e.TransId).HasColumnName("TransID");
            entity.Property(e => e.FileName).HasMaxLength(200);
            entity.Property(e => e.ImportDate).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TransType).HasMaxLength(50);
        });

        modelBuilder.Entity<ImportTransactionService>(entity =>
        {
            entity.HasKey(e => e.TransId).HasName("PK__Import_T__9E5DDB1CA4742FCF");

            entity.ToTable("Import_TransactionService");

            entity.Property(e => e.TransId).HasColumnName("TransID");
            entity.Property(e => e.CaTransId).HasColumnName("CaTransID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.ImportDate).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TransIdservices).HasColumnName("TransIDServices");
            entity.Property(e => e.TransType).HasMaxLength(50);
        });

        modelBuilder.Entity<ItemRating>(entity =>
        {
            entity.ToTable("item_ratings");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Catalogueid).HasColumnName("catalogueid");
            entity.Property(e => e.Proid).HasColumnName("proid");
            entity.Property(e => e.TotalRating).HasColumnName("total_rating");
            entity.Property(e => e.Votes).HasColumnName("votes");
        });

        modelBuilder.Entity<LogCancelParticipantOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LogCance__3214EC0737FF2004");

            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.EntityId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("EntityID");
            entity.Property(e => e.KeyTranId)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ParticipantId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ParticipantID");
            entity.Property(e => e.ProgramId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ProgramID");
            entity.Property(e => e.ReturnMessage)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.StatusCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UnitKeyInDb)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UnitKeySubmit)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Matching>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Matching$");

            entity.Property(e => e.BillingName)
                .HasMaxLength(255)
                .HasColumnName("Billing Name");
            entity.Property(e => e.Carrier).HasMaxLength(255);
            entity.Property(e => e.Connote).HasMaxLength(255);
            entity.Property(e => e.DateOrdered)
                .HasColumnType("datetime")
                .HasColumnName("Date Ordered");
            entity.Property(e => e.DeliveryCompanyName)
                .HasMaxLength(255)
                .HasColumnName("Delivery Company Name");
            entity.Property(e => e.DeliveryName)
                .HasMaxLength(255)
                .HasColumnName("Delivery Name");
            entity.Property(e => e.DeliveryPhone)
                .HasMaxLength(255)
                .HasColumnName("Delivery Phone");
            entity.Property(e => e.DeliveryPostcode)
                .HasMaxLength(255)
                .HasColumnName("Delivery Postcode");
            entity.Property(e => e.DeliveryState)
                .HasMaxLength(255)
                .HasColumnName("Delivery State");
            entity.Property(e => e.DeliveryStreet1)
                .HasMaxLength(255)
                .HasColumnName("Delivery Street1");
            entity.Property(e => e.DeliveryStreet2)
                .HasMaxLength(255)
                .HasColumnName("Delivery Street2");
            entity.Property(e => e.DeliverySuburb)
                .HasMaxLength(255)
                .HasColumnName("Delivery Suburb");
            entity.Property(e => e.DispatchDate)
                .HasColumnType("datetime")
                .HasColumnName("Dispatch Date");
            entity.Property(e => e.FulfilmentId)
                .HasMaxLength(255)
                .HasColumnName("FulfilmentID");
            entity.Property(e => e.Key1).HasMaxLength(255);
            entity.Property(e => e.Key2).HasMaxLength(255);
            entity.Property(e => e.Order).HasColumnName("Order#");
            entity.Property(e => e.OrderStatus)
                .HasMaxLength(255)
                .HasColumnName("Order Status");
            entity.Property(e => e.PaymentReference)
                .HasMaxLength(255)
                .HasColumnName("Payment Reference");
            entity.Property(e => e.PaymentType).HasMaxLength(255);
            entity.Property(e => e.ReasonCodes)
                .HasMaxLength(255)
                .HasColumnName("Reason Codes");
            entity.Property(e => e.TpfOrderId).HasColumnName("TPF OrderID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserType).HasMaxLength(255);
            entity.Property(e => e.Username).HasMaxLength(255);
        });

        modelBuilder.Entity<NewOrgIdnotUsingUserEntitlementRaw>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NewOrgID__3214EC078ECB457E");

            entity.ToTable("NewOrgIDNotUsingUserEntitlementRAW");

            entity.Property(e => e.OgrId).HasMaxLength(200);
        });

        modelBuilder.Entity<ParticipantOrderCompare>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ParticipantOrderCompare");

            entity.Property(e => e.DispatchedDate)
                .HasColumnType("datetime")
                .HasColumnName("Dispatched date");
            entity.Property(e => e.FileName)
                .HasMaxLength(255)
                .HasColumnName("File name");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.UniqueId)
                .HasMaxLength(255)
                .HasColumnName("UniqueID");
            entity.Property(e => e.UploadId).HasColumnName("UploadID");
            entity.Property(e => e.Uploaddate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ParticipantReportOrderSeason>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Particip__3214EC07CFB9DAF9");

            entity.ToTable("ParticipantReportOrderSeason");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Personalisation>(entity =>
        {
            entity.ToTable("personalisation");

            entity.Property(e => e.PersonalisationId).HasColumnName("personalisationID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createDate");
            entity.Property(e => e.Notes)
                .HasDefaultValueSql("('')")
                .HasColumnType("ntext")
                .HasColumnName("notes");
            entity.Property(e => e.OrderDetailId).HasColumnName("orderDetailID");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('current')")
                .HasColumnName("status");
            entity.Property(e => e.String0)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("string0");
            entity.Property(e => e.String1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("string1");
            entity.Property(e => e.String2)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("string2");
            entity.Property(e => e.String3)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("string3");
            entity.Property(e => e.String4)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("string4");
            entity.Property(e => e.String5)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("string5");
            entity.Property(e => e.Style)
                .HasMaxLength(255)
                .HasDefaultValueSql("('')")
                .HasColumnName("style");
            entity.Property(e => e.Type)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("type");
            entity.Property(e => e.Uploaddataid)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("uploaddataid");
        });

        modelBuilder.Entity<PlayHqproductRef>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PlayHQProductRef");

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.OrganisationId)
                .HasMaxLength(255)
                .HasColumnName("organisation_id");
            entity.Property(e => e.ParentProductId)
                .HasMaxLength(255)
                .HasColumnName("parent_product_id");
            entity.Property(e => e.ProductId)
                .HasMaxLength(255)
                .HasColumnName("product_id");
        });

        modelBuilder.Entity<ProPack>(entity =>
        {
            entity.HasKey(e => e.PkId);

            entity.ToTable("proPack");

            entity.Property(e => e.PkId).HasColumnName("pkID");
            entity.Property(e => e.Groupid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("groupid");
            entity.Property(e => e.IsDisplay).HasComment("1: display on Cart\r\n0: not display on Cart");
            entity.Property(e => e.IsFix).HasComment("0 : conset (allow edit qty)\r\n1: Kit item normal");
            entity.Property(e => e.IsSecond)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isSecond");
            entity.Property(e => e.PkProId).HasColumnName("pkProID");
            entity.Property(e => e.PkProdetailId).HasColumnName("pkProdetailID");
            entity.Property(e => e.Pkqty)
                .HasDefaultValueSql("((1))")
                .HasColumnName("pkqty");
            entity.Property(e => e.Pkstatus)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("('y')")
                .HasColumnName("pkstatus");
        });

        modelBuilder.Entity<ProPackDynamic>(entity =>
        {
            entity.ToTable("ProPackDynamic");

            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.ProId).HasColumnName("ProID");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProId);

            entity.ToTable("product");

            entity.Property(e => e.ProId).HasColumnName("proID");
            entity.Property(e => e.Buffer)
                .HasDefaultValueSql("((0))")
                .HasColumnName("buffer");
            entity.Property(e => e.Buy)
                .HasMaxLength(3)
                .HasDefaultValueSql("(N'yes')")
                .HasColumnName("buy");
            entity.Property(e => e.CategoryId).HasColumnName("categoryID");
            entity.Property(e => e.Code1)
                .HasMaxLength(5)
                .HasDefaultValueSql("('')")
                .HasColumnName("code1");
            entity.Property(e => e.Code2)
                .HasMaxLength(5)
                .HasDefaultValueSql("('')")
                .HasColumnName("code2");
            entity.Property(e => e.Createby).HasColumnName("createby");
            entity.Property(e => e.Createdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.CustomDeclarationValue)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("custom_declaration_value");
            entity.Property(e => e.DeclarationName)
                .HasMaxLength(250)
                .HasDefaultValueSql("(N'Stationery')")
                .HasColumnName("declaration_name");
            entity.Property(e => e.DimHeight)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("dim_height");
            entity.Property(e => e.DimLength)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("dim_length");
            entity.Property(e => e.DimVolume)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 10)")
                .HasColumnName("dim_volume");
            entity.Property(e => e.DimWidth)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("dim_width");
            entity.Property(e => e.Discount)
                .HasMaxLength(4)
                .HasDefaultValueSql("(N'NO')")
                .HasColumnName("discount");
            entity.Property(e => e.Dispriority)
                .HasDefaultValueSql("((5))")
                .HasColumnName("dispriority");
            entity.Property(e => e.DsmsetRevision).HasColumnName("DSMSetRevision");
            entity.Property(e => e.Duedate)
                .HasMaxLength(15)
                .HasDefaultValueSql("(N'NONE')")
                .HasColumnName("duedate");
            entity.Property(e => e.FinanceNote)
                .HasMaxLength(1200)
                .HasColumnName("financeNote");
            entity.Property(e => e.Financenotes)
                .HasMaxLength(2000)
                .HasColumnName("financenotes");
            entity.Property(e => e.Financestatus)
                .HasMaxLength(10)
                .HasDefaultValueSql("('pending')")
                .HasColumnName("financestatus");
            entity.Property(e => e.GenerateVoucherCode).HasColumnName("generateVoucherCode");
            entity.Property(e => e.Hasgst)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'yes')")
                .HasColumnName("hasgst");
            entity.Property(e => e.HiResImg)
                .HasMaxLength(4)
                .HasDefaultValueSql("(N'no')")
                .HasColumnName("hiResImg");
            entity.Property(e => e.Imagename)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'NONE')")
                .HasColumnName("imagename");
            entity.Property(e => e.IsAutoweight).HasColumnName("isAutoweight");
            entity.Property(e => e.IsClockQty).HasColumnName("isClockQty");
            entity.Property(e => e.IsMultiproId).HasColumnName("isMultiproId");
            entity.Property(e => e.IsOpenJob).HasColumnName("isOpenJob");
            entity.Property(e => e.IsPack)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isPack");
            entity.Property(e => e.IsPersonalised).HasColumnName("isPersonalised");
            entity.Property(e => e.IsPrepack).HasColumnName("isPrepack");
            entity.Property(e => e.IsSendPack)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isSendPack");
            entity.Property(e => e.IsStockable)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("isStockable");
            entity.Property(e => e.KeysPrid).HasMaxLength(50);
            entity.Property(e => e.LandedcostRef)
                .HasMaxLength(12)
                .HasColumnName("landedcost_ref");
            entity.Property(e => e.Lastmodified)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("lastmodified");
            entity.Property(e => e.Lastupdate)
                .HasMaxLength(1200)
                .HasColumnName("lastupdate");
            entity.Property(e => e.Lastupdatedate)
                .HasColumnType("datetime")
                .HasColumnName("lastupdatedate");
            entity.Property(e => e.Licencee).HasMaxLength(50);
            entity.Property(e => e.Moq)
                .HasDefaultValueSql("((1))")
                .HasColumnName("MOQ");
            entity.Property(e => e.Newlandedcost)
                .HasDefaultValueSql("((0))")
                .HasColumnName("newlandedcost");
            entity.Property(e => e.Nismessage)
                .HasMaxLength(500)
                .HasDefaultValueSql("(N'NONE')")
                .HasColumnName("nismessage");
            entity.Property(e => e.NonDim)
                .HasMaxLength(4)
                .HasDefaultValueSql("(N'n')")
                .HasColumnName("nonDim");
            entity.Property(e => e.Nzdprice)
                .HasMaxLength(10)
                .HasColumnName("nzdprice");
            entity.Property(e => e.OrderNumber)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasColumnName("orderNumber");
            entity.Property(e => e.Ownedby)
                .HasMaxLength(80)
                .HasDefaultValueSql("(N'TPF')")
                .HasColumnName("ownedby");
            entity.Property(e => e.PBostatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('y')")
                .IsFixedLength()
                .HasColumnName("p_bostatus");
            entity.Property(e => e.PInventorystatus)
                .HasMaxLength(20)
                .HasDefaultValueSql("((1))")
                .HasColumnName("p_inventorystatus");
            entity.Property(e => e.PLandedcost)
                .HasDefaultValueSql("((0))")
                .HasColumnName("p_landedcost");
            entity.Property(e => e.PMinguarantee)
                .HasDefaultValueSql("((0))")
                .HasColumnName("p_minguarantee");
            entity.Property(e => e.PProweight)
                .HasDefaultValueSql("((0.000))")
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("p_proweight");
            entity.Property(e => e.PRebatepercent).HasColumnName("p_rebatepercent");
            entity.Property(e => e.PReportgroup).HasColumnName("p_reportgroup");
            entity.Property(e => e.PReportstatus)
                .HasMaxLength(5)
                .HasDefaultValueSql("(N'yes')")
                .HasColumnName("p_reportstatus");
            entity.Property(e => e.PRoypercent).HasColumnName("p_roypercent");
            entity.Property(e => e.PackedItem)
                .HasDefaultValueSql("((0))")
                .HasColumnName("packed_item");
            entity.Property(e => e.Pgid)
                .HasDefaultValueSql("((17))")
                .HasColumnName("pgid");
            entity.Property(e => e.Pricedesc)
                .HasMaxLength(25)
                .HasColumnName("pricedesc");
            entity.Property(e => e.Pricef)
                .HasMaxLength(8)
                .HasColumnName("pricef");
            entity.Property(e => e.Priceft)
                .HasMaxLength(8)
                .HasColumnName("priceft");
            entity.Property(e => e.Pricepub)
                .HasMaxLength(8)
                .HasColumnName("pricepub");
            entity.Property(e => e.ProIdOgr).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ProIdTpf).HasColumnName("ProIdTPF");
            entity.Property(e => e.Prodescription)
                .HasDefaultValueSql("(N'NONE')")
                .HasColumnName("prodescription");
            entity.Property(e => e.Prodiscprice)
                .HasMaxLength(8)
                .HasDefaultValueSql("((0))")
                .HasColumnName("prodiscprice");
            entity.Property(e => e.ProductionProductColour)
                .HasMaxLength(500)
                .HasColumnName("production_productColour");
            entity.Property(e => e.ProductionProductNotes)
                .HasMaxLength(500)
                .HasColumnName("production_productNotes");
            entity.Property(e => e.ProductionexportId).HasColumnName("productionexportID");
            entity.Property(e => e.Proname)
                .HasMaxLength(80)
                .HasColumnName("proname");
            entity.Property(e => e.Pronew)
                .HasMaxLength(8)
                .HasDefaultValueSql("(N'NO')")
                .HasColumnName("pronew");
            entity.Property(e => e.Proprice)
                .HasDefaultValueSql("((0))")
                .HasColumnName("proprice");
            entity.Property(e => e.Propriceexc).HasColumnName("propriceexc");
            entity.Property(e => e.Prospecial)
                .HasMaxLength(4)
                .HasDefaultValueSql("(N'NO')")
                .HasColumnName("prospecial");
            entity.Property(e => e.Royaltykey)
                .HasMaxLength(50)
                .HasColumnName("royaltykey");
            entity.Property(e => e.Status)
                .HasMaxLength(15)
                .HasDefaultValueSql("(N'YES')")
                .HasColumnName("status");
            entity.Property(e => e.Subcatdesc)
                .HasMaxLength(500)
                .HasColumnName("subcatdesc");
            entity.Property(e => e.Subcategory)
                .HasMaxLength(120)
                .HasDefaultValueSql("('')")
                .HasColumnName("subcategory");
            entity.Property(e => e.Updateby).HasColumnName("updateby");
            entity.Property(e => e.VariationId).HasColumnName("variationID");
            entity.Property(e => e.VirtualName).HasMaxLength(80);
            entity.Property(e => e.Websafename)
                .HasMaxLength(80)
                .HasColumnName("websafename");
            entity.Property(e => e.WhId).HasColumnName("wh_id");
        });

        modelBuilder.Entity<ProductKit>(entity =>
        {
            entity.ToTable("ProductKit");

            entity.Property(e => e.ProductCode).HasMaxLength(250);
            entity.Property(e => e.ProductType).HasMaxLength(30);
            entity.Property(e => e.SubItemList).HasColumnType("ntext");
        });

        modelBuilder.Entity<ProductPrice>(entity =>
        {
            entity.ToTable("product_prices");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Currency)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'AUD')")
                .HasColumnName("currency");
            entity.Property(e => e.Currentprice).HasColumnName("currentprice");
            entity.Property(e => e.Lastmodified)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("lastmodified");
            entity.Property(e => e.Legacyfield)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'proprice')")
                .HasColumnName("legacyfield");
            entity.Property(e => e.Profileid).HasColumnName("profileid");
            entity.Property(e => e.Proid).HasColumnName("proid");
            entity.Property(e => e.RebatePercentage)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("rebate_percentage");
            entity.Property(e => e.Taxrate)
                .HasDefaultValueSql("((10))")
                .HasColumnName("taxrate");
            entity.Property(e => e.Wasprice).HasColumnName("wasprice");
        });

        modelBuilder.Entity<ProductPricesBak>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("product_pricesBak");

            entity.Property(e => e.Currency)
                .HasMaxLength(10)
                .HasColumnName("currency");
            entity.Property(e => e.Currentprice).HasColumnName("currentprice");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Lastmodified).HasColumnName("lastmodified");
            entity.Property(e => e.Legacyfield)
                .HasMaxLength(20)
                .HasColumnName("legacyfield");
            entity.Property(e => e.Profileid).HasColumnName("profileid");
            entity.Property(e => e.Proid).HasColumnName("proid");
            entity.Property(e => e.RebatePercentage)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("rebate_percentage");
            entity.Property(e => e.Taxrate).HasColumnName("taxrate");
            entity.Property(e => e.Wasprice).HasColumnName("wasprice");
        });

        modelBuilder.Entity<ProductPricesgroupca>(entity =>
        {
            entity.ToTable("product_pricesgroupca");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Currency)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'AUD')")
                .HasColumnName("currency");
            entity.Property(e => e.Currentprice).HasColumnName("currentprice");
            entity.Property(e => e.Lastmodified)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("lastmodified");
            entity.Property(e => e.Legacyfield)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'proprice')")
                .HasColumnName("legacyfield");
            entity.Property(e => e.Profileid).HasColumnName("profileid");
            entity.Property(e => e.Proid).HasColumnName("proid");
            entity.Property(e => e.RebatePercentage)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("rebate_percentage");
            entity.Property(e => e.Taxrate)
                .HasDefaultValueSql("((10))")
                .HasColumnName("taxrate");
            entity.Property(e => e.Wasprice).HasColumnName("wasprice");
        });

        modelBuilder.Entity<ProductProfile>(entity =>
        {
            entity.HasKey(e => e.ProfileId).IsClustered(false);

            entity.ToTable("productProfile");

            entity.Property(e => e.ProfileId).HasColumnName("profileID");
            entity.Property(e => e.AddNotes)
                .HasMaxLength(2000)
                .HasColumnName("addNotes");
            entity.Property(e => e.Cancelledby)
                .HasDefaultValueSql("((0))")
                .HasColumnName("cancelledby");
            entity.Property(e => e.Cancelledon)
                .HasColumnType("datetime")
                .HasColumnName("cancelledon");
            entity.Property(e => e.CartonMark)
                .HasMaxLength(2000)
                .HasColumnName("cartonMark");
            entity.Property(e => e.CatalogueId).HasColumnName("catalogueID");
            entity.Property(e => e.DefaultProfile)
                .HasMaxLength(10)
                .HasDefaultValueSql("('NO')")
                .HasColumnName("defaultProfile");
            entity.Property(e => e.EventProfileId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("eventProfileID");
            entity.Property(e => e.InnerQty)
                .HasMaxLength(250)
                .HasColumnName("innerQty");
            entity.Property(e => e.ItemColour)
                .HasMaxLength(500)
                .HasColumnName("itemColour");
            entity.Property(e => e.ItemDesc)
                .HasMaxLength(250)
                .HasColumnName("itemDesc");
            entity.Property(e => e.ItemNotes)
                .HasMaxLength(1500)
                .HasColumnName("itemNotes");
            entity.Property(e => e.ItemSizeType)
                .HasMaxLength(30)
                .HasColumnName("itemSizeType");
            entity.Property(e => e.Jobbagid)
                .HasMaxLength(15)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("jobbagid");
            entity.Property(e => e.LastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdate");
            entity.Property(e => e.MainStockProfileid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("mainStockProfileid");
            entity.Property(e => e.OuterQty)
                .HasMaxLength(250)
                .HasColumnName("outerQty");
            entity.Property(e => e.PackQty)
                .HasDefaultValueSql("((1))")
                .HasColumnName("packQty");
            entity.Property(e => e.PackType)
                .HasMaxLength(250)
                .HasColumnName("packType");
            entity.Property(e => e.Plocation)
                .HasMaxLength(15)
                .HasDefaultValueSql("('Australia')")
                .HasColumnName("plocation");
            entity.Property(e => e.ProfileName)
                .HasMaxLength(250)
                .HasColumnName("profileName");
            entity.Property(e => e.ProfileNotes)
                .HasMaxLength(500)
                .HasDefaultValueSql("('NO')")
                .HasColumnName("profileNotes");
            entity.Property(e => e.Proid).HasColumnName("proid");
            entity.Property(e => e.Pstatus)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'current')")
                .HasColumnName("pstatus");
            entity.Property(e => e.Qareport)
                .HasMaxLength(2000)
                .HasColumnName("QAReport");
            entity.Property(e => e.SpLocation)
                .HasMaxLength(35)
                .HasColumnName("spLocation");
            entity.Property(e => e.TickPackRequired)
                .HasMaxLength(25)
                .HasColumnName("tick_packRequired");
            entity.Property(e => e.Updateby)
                .HasDefaultValueSql("((0))")
                .HasColumnName("updateby");
        });

        modelBuilder.Entity<ProductQty>(entity =>
        {
            entity.ToTable("product_qty");

            entity.HasIndex(e => e.Prodetailid, "prodetailid");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Available).HasColumnName("available");
            entity.Property(e => e.Createdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.LastLocationStockId).HasColumnName("last_location_stock_id");
            entity.Property(e => e.Lastupdate)
                .HasColumnType("datetime")
                .HasColumnName("lastupdate");
            entity.Property(e => e.Onbackorder).HasColumnName("onbackorder");
            entity.Property(e => e.Oncustorder).HasColumnName("oncustorder");
            entity.Property(e => e.Onhand).HasColumnName("onhand");
            entity.Property(e => e.Onorder).HasColumnName("onorder");
            entity.Property(e => e.Onreorder).HasColumnName("onreorder");
            entity.Property(e => e.Onreturns).HasColumnName("onreturns");
            entity.Property(e => e.Prodetailid).HasColumnName("prodetailid");
            entity.Property(e => e.Whid).HasColumnName("whid");
        });

        modelBuilder.Entity<ProductSeo>(entity =>
        {
            entity.HasKey(e => e.ProId);

            entity.ToTable("product_SEO");

            entity.Property(e => e.ProId)
                .ValueGeneratedNever()
                .HasColumnName("ProID");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.ImgAlt).HasMaxLength(200);
            entity.Property(e => e.ImgTitle).HasMaxLength(200);
            entity.Property(e => e.Keywords).HasMaxLength(200);
            entity.Property(e => e.Title).HasMaxLength(200);
        });

        modelBuilder.Entity<ProductTemplate>(entity =>
        {
            entity.ToTable("Product_Templates");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CatalogueId).HasColumnName("CatalogueID");
            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.Imagename)
                .HasMaxLength(50)
                .HasColumnName("imagename");
            entity.Property(e => e.Lastmodified).HasColumnName("lastmodified");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Simpletag)
                .HasMaxLength(255)
                .HasColumnName("simpletag");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("status");
        });

        modelBuilder.Entity<ProductTemplateField>(entity =>
        {
            entity.ToTable("Product_TemplateFields");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Capitalisation)
                .HasMaxLength(20)
                .HasColumnName("capitalisation");
            entity.Property(e => e.Caption)
                .HasMaxLength(50)
                .HasColumnName("caption");
            entity.Property(e => e.Defaultvalue)
                .HasMaxLength(100)
                .HasColumnName("defaultvalue");
            entity.Property(e => e.Htmltype)
                .HasMaxLength(20)
                .HasColumnName("htmltype");
            entity.Property(e => e.Label)
                .HasMaxLength(50)
                .HasColumnName("label");
            entity.Property(e => e.Lastmodified).HasColumnName("lastmodified");
            entity.Property(e => e.Mandatory).HasColumnName("mandatory");
            entity.Property(e => e.Maxlength).HasColumnName("maxlength");
            entity.Property(e => e.Placeholder)
                .HasMaxLength(100)
                .HasColumnName("placeholder");
            entity.Property(e => e.TemplateId).HasColumnName("TemplateID");
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .HasColumnName("type");
        });

        modelBuilder.Entity<ProductTemplateFieldOption>(entity =>
        {
            entity.ToTable("Product_TemplateField_Options");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Lastmodified).HasColumnName("lastmodified");
            entity.Property(e => e.Position).HasColumnName("position");
            entity.Property(e => e.TemplatefieldId).HasColumnName("templatefieldID");
            entity.Property(e => e.Value)
                .HasMaxLength(150)
                .HasColumnName("value");
        });

        modelBuilder.Entity<ProductTemplateMap>(entity =>
        {
            entity.HasKey(e => new { e.TemplateId, e.ProductId });

            entity.ToTable("Product_Template_Map");

            entity.Property(e => e.TemplateId).HasColumnName("templateID");
            entity.Property(e => e.ProductId).HasColumnName("productID");
            entity.Property(e => e.Lastmodified)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("lastmodified");
        });

        modelBuilder.Entity<Productdetail>(entity =>
        {
            entity.HasKey(e => e.ProdetailId);

            entity.ToTable("productdetail");

            entity.Property(e => e.ProdetailId).HasColumnName("prodetailID");
            entity.Property(e => e.ApprovalStatus)
                .HasDefaultValueSql("((1))")
                .HasColumnName("approvalStatus");
            entity.Property(e => e.ApprovedBy)
                .HasDefaultValueSql("((0))")
                .HasColumnName("approvedBy");
            entity.Property(e => e.ApprovedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("approvedDate");
            entity.Property(e => e.Backorderqty)
                .HasDefaultValueSql("((0))")
                .HasColumnName("backorderqty");
            entity.Property(e => e.Barcode)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasColumnName("barcode");
            entity.Property(e => e.BoStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('y')")
                .IsFixedLength()
                .HasColumnName("bo_status");
            entity.Property(e => e.CartonQty)
                .HasDefaultValueSql("((0))")
                .HasColumnName("cartonQty");
            entity.Property(e => e.CreateBy).HasColumnName("createBy");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Custorder)
                .HasDefaultValueSql("((0))")
                .HasColumnName("custorder");
            entity.Property(e => e.Custorder1)
                .HasDefaultValueSql("((0))")
                .HasColumnName("custorder1");
            entity.Property(e => e.Custorder10)
                .HasDefaultValueSql("((0))")
                .HasColumnName("custorder10");
            entity.Property(e => e.Custorder2)
                .HasDefaultValueSql("((0))")
                .HasColumnName("custorder2");
            entity.Property(e => e.Custorder3)
                .HasDefaultValueSql("((0))")
                .HasColumnName("custorder3");
            entity.Property(e => e.Custorder4)
                .HasDefaultValueSql("((0))")
                .HasColumnName("custorder4");
            entity.Property(e => e.Custorder5)
                .HasDefaultValueSql("((0))")
                .HasColumnName("custorder5");
            entity.Property(e => e.Custorder6)
                .HasDefaultValueSql("((0))")
                .HasColumnName("custorder6");
            entity.Property(e => e.Custorder7)
                .HasDefaultValueSql("((0))")
                .HasColumnName("custorder7");
            entity.Property(e => e.Custorder8)
                .HasDefaultValueSql("((0))")
                .HasColumnName("custorder8");
            entity.Property(e => e.Custorder9)
                .HasDefaultValueSql("((0))")
                .HasColumnName("custorder9");
            entity.Property(e => e.Disporder)
                .HasDefaultValueSql("((5))")
                .HasColumnName("disporder");
            entity.Property(e => e.DtPriority)
                .HasDefaultValueSql("((0))")
                .HasColumnName("dt_priority");
            entity.Property(e => e.Financeref)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("financeref");
            entity.Property(e => e.GroupNumber)
                .HasDefaultValueSql("((0))")
                .HasColumnName("groupNumber");
            entity.Property(e => e.Internalcode)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasColumnName("internalcode");
            entity.Property(e => e.Inventorystatus)
                .HasMaxLength(20)
                .HasDefaultValueSql("((1))")
                .HasColumnName("inventorystatus");
            entity.Property(e => e.IsAvailableStock)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isAvailableStock");
            entity.Property(e => e.IsPackStock)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isPackStock");
            entity.Property(e => e.IsSecond)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isSecond");
            entity.Property(e => e.IsShippingFee)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isShippingFee");
            entity.Property(e => e.KeysPrPd).HasMaxLength(50);
            entity.Property(e => e.KitOptionsName).HasMaxLength(200);
            entity.Property(e => e.KitSize).HasDefaultValueSql("((0))");
            entity.Property(e => e.Landedcost)
                .HasDefaultValueSql("((0))")
                .HasColumnName("landedcost");
            entity.Property(e => e.Lastmodified)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("lastmodified");
            entity.Property(e => e.Lastturnontosync)
                .HasColumnType("datetime")
                .HasColumnName("lastturnontosync");
            entity.Property(e => e.Lastupdate)
                .HasColumnType("datetime")
                .HasColumnName("lastupdate");
            entity.Property(e => e.LeadTime)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("leadTime");
            entity.Property(e => e.LevelNumber)
                .HasDefaultValueSql("((0))")
                .HasColumnName("levelNumber");
            entity.Property(e => e.MinGuarantee)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("minGuarantee");
            entity.Property(e => e.MinReorderQty)
                .HasDefaultValueSql("((1))")
                .HasColumnName("minReorderQty");
            entity.Property(e => e.Opt0)
                .HasDefaultValueSql("((0))")
                .HasColumnName("opt0");
            entity.Property(e => e.Opt1)
                .HasDefaultValueSql("((0))")
                .HasColumnName("opt1");
            entity.Property(e => e.Opt2)
                .HasDefaultValueSql("((0))")
                .HasColumnName("opt2");
            entity.Property(e => e.Opt3)
                .HasDefaultValueSql("((0))")
                .HasColumnName("opt3");
            entity.Property(e => e.Opt4)
                .HasDefaultValueSql("((0))")
                .HasColumnName("opt4");
            entity.Property(e => e.Opt5)
                .HasDefaultValueSql("((0))")
                .HasColumnName("opt5");
            entity.Property(e => e.Opt6)
                .HasDefaultValueSql("((0))")
                .HasColumnName("opt6");
            entity.Property(e => e.Opt7)
                .HasDefaultValueSql("((0))")
                .HasColumnName("opt7");
            entity.Property(e => e.Opt8)
                .HasDefaultValueSql("((0))")
                .HasColumnName("opt8");
            entity.Property(e => e.Opt9)
                .HasDefaultValueSql("((0))")
                .HasColumnName("opt9");
            entity.Property(e => e.Othersize)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("othersize");
            entity.Property(e => e.PalletQty)
                .HasDefaultValueSql("((0.01))")
                .HasColumnName("palletQty");
            entity.Property(e => e.ProId).HasColumnName("proID");
            entity.Property(e => e.Prodetailcode)
                .HasMaxLength(30)
                .HasColumnName("prodetailcode");
            entity.Property(e => e.Prodetailsize)
                .HasMaxLength(15)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("prodetailsize");
            entity.Property(e => e.Prodetailstatus)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'YES')")
                .HasColumnName("prodetailstatus");
            entity.Property(e => e.Prodetailstock)
                .HasDefaultValueSql("((0))")
                .HasColumnName("prodetailstock");
            entity.Property(e => e.Prodetailweight)
                .HasDefaultValueSql("((0.2))")
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("prodetailweight");
            entity.Property(e => e.Qtyonreorder)
                .HasDefaultValueSql("((0))")
                .HasColumnName("qtyonreorder");
            entity.Property(e => e.Qtysold6month).HasColumnName("qtysold6month");
            entity.Property(e => e.Qtysoldmonth0)
                .HasDefaultValueSql("((0))")
                .HasColumnName("qtysoldmonth0");
            entity.Property(e => e.Qtysoldmonth1)
                .HasDefaultValueSql("((0))")
                .HasColumnName("qtysoldmonth1");
            entity.Property(e => e.Qtysoldmonth2)
                .HasDefaultValueSql("((0))")
                .HasColumnName("qtysoldmonth2");
            entity.Property(e => e.Qtysoldmonth3)
                .HasDefaultValueSql("((0))")
                .HasColumnName("qtysoldmonth3");
            entity.Property(e => e.Qtysoldmonth4)
                .HasDefaultValueSql("((0))")
                .HasColumnName("qtysoldmonth4");
            entity.Property(e => e.Qtysoldmonth5)
                .HasDefaultValueSql("((0))")
                .HasColumnName("qtysoldmonth5");
            entity.Property(e => e.Rebatepercent)
                .HasDefaultValueSql("((0))")
                .HasColumnName("rebatepercent");
            entity.Property(e => e.Reorderlevel)
                .HasDefaultValueSql("((0))")
                .HasColumnName("reorderlevel");
            entity.Property(e => e.Reorderqty)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))")
                .HasColumnName("reorderqty");
            entity.Property(e => e.ReportGroup).HasColumnName("reportGroup");
            entity.Property(e => e.ReportStatus)
                .HasMaxLength(5)
                .HasDefaultValueSql("(N'yes')")
                .HasColumnName("reportStatus");
            entity.Property(e => e.ReserveQty).HasColumnName("reserveQty");
            entity.Property(e => e.RoyalPercent)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))")
                .HasColumnName("royalPercent");
            entity.Property(e => e.Sku)
                .HasMaxLength(50)
                .HasColumnName("SKU");
            entity.Property(e => e.Skucode)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("Real stock code from TPF Inventory System - For reporting use")
                .HasColumnName("SKUCODE");
            entity.Property(e => e.Skuid).HasColumnName("SKUID");
            entity.Property(e => e.Substitute).HasColumnName("substitute");
            entity.Property(e => e.ToSync)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("toSync");
            entity.Property(e => e.Tpfname)
                .HasMaxLength(50)
                .HasColumnName("tpfname");
            entity.Property(e => e.Unspc)
                .HasMaxLength(20)
                .HasColumnName("unspc");
            entity.Property(e => e.VirtualRefId).HasColumnName("virtualRefID");
            entity.Property(e => e.Wh1)
                .HasDefaultValueSql("((0))")
                .HasColumnName("wh1");
            entity.Property(e => e.Wh2)
                .HasDefaultValueSql("((0))")
                .HasColumnName("wh2");
            entity.Property(e => e.Wh3)
                .HasDefaultValueSql("((0))")
                .HasColumnName("wh3");
            entity.Property(e => e.Wh4)
                .HasDefaultValueSql("((0))")
                .HasColumnName("wh4");
            entity.Property(e => e.Wh5)
                .HasDefaultValueSql("((0))")
                .HasColumnName("wh5");
            entity.Property(e => e.Wh6)
                .HasDefaultValueSql("((0))")
                .HasColumnName("wh6");
            entity.Property(e => e.Wh7)
                .HasDefaultValueSql("((0))")
                .HasColumnName("wh7");
            entity.Property(e => e.Wh8)
                .HasDefaultValueSql("((0))")
                .HasColumnName("wh8");
            entity.Property(e => e.Wh9)
                .HasDefaultValueSql("((0))")
                .HasColumnName("wh9");
            entity.Property(e => e.Whid)
                .HasDefaultValueSql("((1))")
                .HasColumnName("whid");
        });

        modelBuilder.Entity<ProductdetailReference>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Productd__3214EC079C7EBE11");

            entity.ToTable("ProductdetailReference");

            entity.Property(e => e.ProdetailCode)
                .HasMaxLength(200)
                .HasColumnName("prodetailCode");
            entity.Property(e => e.ProdetailName).HasMaxLength(200);
            entity.Property(e => e.ProdetailiD).HasColumnName("prodetailiD");
        });

        modelBuilder.Entity<Sheet1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Sheet1$");

            entity.Property(e => e.CaAdmin)
                .HasColumnType("money")
                .HasColumnName("CA Admin");
            entity.Property(e => e.CaHelpdesk)
                .HasColumnType("money")
                .HasColumnName("CA Helpdesk");
            entity.Property(e => e.Centre).HasColumnType("money");
            entity.Property(e => e.InShop).HasMaxLength(255);
            entity.Property(e => e.InvCode).HasMaxLength(255);
            entity.Property(e => e.Junior).HasMaxLength(255);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.Public).HasMaxLength(255);
            entity.Property(e => e.School).HasColumnType("money");
            entity.Property(e => e.ShopDescription)
                .HasMaxLength(255)
                .HasColumnName("Shop Description");
            entity.Property(e => e.ShopName)
                .HasMaxLength(255)
                .HasColumnName("Shop Name");
            entity.Property(e => e.State).HasColumnType("money");
        });

        modelBuilder.Entity<StockCa>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("stock_ca");

            entity.Property(e => e.CaCode)
                .HasMaxLength(50)
                .HasColumnName("caCode");
            entity.Property(e => e.CaCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("caCreateDate");
            entity.Property(e => e.CaDescriptions).HasColumnName("caDescriptions");
            entity.Property(e => e.CaId).HasColumnName("caId");
            entity.Property(e => e.CaImage)
                .HasMaxLength(100)
                .HasColumnName("caImage");
            entity.Property(e => e.CaLastUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("caLastUpdateDate");
            entity.Property(e => e.CaName)
                .HasMaxLength(250)
                .HasColumnName("caName");
            entity.Property(e => e.CaPrice).HasColumnName("caPrice");
            entity.Property(e => e.CaProCode).HasColumnName("caProCode");
            entity.Property(e => e.CaProDetailCode).HasColumnName("caProDetailCode");
            entity.Property(e => e.CaProductType)
                .HasMaxLength(50)
                .HasColumnName("caProductType");
            entity.Property(e => e.CaSize)
                .HasMaxLength(10)
                .HasColumnName("caSize");
            entity.Property(e => e.CaStatus)
                .HasMaxLength(50)
                .HasColumnName("caStatus");
            entity.Property(e => e.CaStatusProduct)
                .HasMaxLength(50)
                .HasColumnName("caStatusProduct");
            entity.Property(e => e.CaVirtualCode)
                .HasMaxLength(50)
                .HasColumnName("caVirtualCode");
            entity.Property(e => e.CaWeight).HasColumnName("caWeight");
            entity.Property(e => e.CatalogueId).HasColumnName("catalogueID");
            entity.Property(e => e.Currency)
                .HasMaxLength(10)
                .HasColumnName("currency");
            entity.Property(e => e.Currentprice).HasColumnName("currentprice");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Legacyfield)
                .HasMaxLength(20)
                .HasColumnName("legacyfield");
            entity.Property(e => e.ProfileId).HasColumnName("profileID");
            entity.Property(e => e.ProfileName)
                .HasMaxLength(250)
                .HasColumnName("profileName");
            entity.Property(e => e.Proid).HasColumnName("proid");
            entity.Property(e => e.Propriceprofileid).HasColumnName("propriceprofileid");
            entity.Property(e => e.Propriceproid).HasColumnName("propriceproid");
            entity.Property(e => e.Wasprice).HasColumnName("wasprice");
        });

        modelBuilder.Entity<StockCheck>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("stock_check");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.Onhand).HasColumnName("onhand");
            entity.Property(e => e.OnlineAvailable).HasColumnName("onlineAvailable");
            entity.Property(e => e.ProdetailId).HasColumnName("prodetailID");
            entity.Property(e => e.UnsyncedQty).HasColumnName("unsyncedQty");
            entity.Property(e => e.Whid).HasColumnName("whid");
        });

        modelBuilder.Entity<StockCheckpl>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("stock_checkpl");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.Onhand).HasColumnName("onhand");
            entity.Property(e => e.OnlineAvailable).HasColumnName("onlineAvailable");
            entity.Property(e => e.ProdetailId).HasColumnName("prodetailID");
            entity.Property(e => e.UnsyncedQty).HasColumnName("unsyncedQty");
            entity.Property(e => e.Whid).HasColumnName("whid");
        });

        modelBuilder.Entity<StockView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("stock_view");

            entity.Property(e => e.Available).HasColumnName("available");
            entity.Property(e => e.AvgRating).HasColumnName("avg_rating");
            entity.Property(e => e.Backorderqty).HasColumnName("backorderqty");
            entity.Property(e => e.Barcode)
                .HasMaxLength(20)
                .HasColumnName("barcode");
            entity.Property(e => e.BoStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("bo_status");
            entity.Property(e => e.Cartonqty).HasColumnName("cartonqty");
            entity.Property(e => e.CatalogueId).HasColumnName("catalogueID");
            entity.Property(e => e.Cataloguegroup)
                .HasMaxLength(50)
                .HasColumnName("cataloguegroup");
            entity.Property(e => e.Cataloguename)
                .HasMaxLength(80)
                .HasColumnName("cataloguename");
            entity.Property(e => e.Categoryid).HasColumnName("categoryid");
            entity.Property(e => e.Categoryname)
                .HasMaxLength(40)
                .HasColumnName("categoryname");
            entity.Property(e => e.Catstatus)
                .HasMaxLength(15)
                .HasColumnName("catstatus");
            entity.Property(e => e.Currency)
                .HasMaxLength(10)
                .HasColumnName("currency");
            entity.Property(e => e.Currentprice).HasColumnName("currentprice");
            entity.Property(e => e.Custorder).HasColumnName("custorder");
            entity.Property(e => e.DefaultCurrentprice).HasColumnName("default_currentprice");
            entity.Property(e => e.DefaultWasprice).HasColumnName("default_wasprice");
            entity.Property(e => e.Defaultprofile).HasColumnName("defaultprofile");
            entity.Property(e => e.Discatpriority).HasColumnName("discatpriority");
            entity.Property(e => e.Discount)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("discount");
            entity.Property(e => e.Disporder).HasColumnName("disporder");
            entity.Property(e => e.Dispriority).HasColumnName("dispriority");
            entity.Property(e => e.DsmsetName)
                .HasMaxLength(82)
                .HasColumnName("DSMSetName");
            entity.Property(e => e.DsmsetRevision).HasColumnName("DSMSetRevision");
            entity.Property(e => e.GenerateVoucherCode).HasColumnName("generateVoucherCode");
            entity.Property(e => e.Gstrate).HasColumnName("gstrate");
            entity.Property(e => e.Hasgst)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("hasgst");
            entity.Property(e => e.Imagename)
                .HasMaxLength(50)
                .HasColumnName("imagename");
            entity.Property(e => e.Internalcode)
                .HasMaxLength(50)
                .HasColumnName("internalcode");
            entity.Property(e => e.Inventorystatus)
                .HasMaxLength(20)
                .HasColumnName("inventorystatus");
            entity.Property(e => e.Inventorystatustext)
                .HasMaxLength(100)
                .HasColumnName("inventorystatustext");
            entity.Property(e => e.IsAutoweight).HasColumnName("isAutoweight");
            entity.Property(e => e.IsEvent).HasColumnName("isEvent");
            entity.Property(e => e.IsPersonalised).HasColumnName("isPersonalised");
            entity.Property(e => e.IsPrepack).HasColumnName("isPrepack");
            entity.Property(e => e.IsSendPack).HasColumnName("isSendPack");
            entity.Property(e => e.Iskit).HasColumnName("iskit");
            entity.Property(e => e.Ispack).HasColumnName("ispack");
            entity.Property(e => e.KitOptionsName).HasMaxLength(200);
            entity.Property(e => e.Leadtime).HasColumnName("leadtime");
            entity.Property(e => e.Legacyfield)
                .HasMaxLength(20)
                .HasColumnName("legacyfield");
            entity.Property(e => e.Moq).HasColumnName("moq");
            entity.Property(e => e.Name)
                .HasMaxLength(90)
                .HasColumnName("name");
            entity.Property(e => e.Nismessage)
                .HasMaxLength(500)
                .HasColumnName("nismessage");
            entity.Property(e => e.Nondim)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("nondim");
            entity.Property(e => e.Nzdprice)
                .HasMaxLength(10)
                .HasColumnName("nzdprice");
            entity.Property(e => e.Online)
                .HasMaxLength(20)
                .HasColumnName("online");
            entity.Property(e => e.Ownedby)
                .HasMaxLength(80)
                .HasColumnName("ownedby");
            entity.Property(e => e.PLandedcost).HasColumnName("p_landedcost");
            entity.Property(e => e.PRebatepercent).HasColumnName("p_rebatepercent");
            entity.Property(e => e.PReportgroup).HasColumnName("p_reportgroup");
            entity.Property(e => e.PReportstatus)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("p_reportstatus");
            entity.Property(e => e.PackedItem)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("packed_item");
            entity.Property(e => e.Palletqty).HasColumnName("palletqty");
            entity.Property(e => e.PdWhid).HasColumnName("pd_whid");
            entity.Property(e => e.Pricef)
                .HasMaxLength(8)
                .HasColumnName("pricef");
            entity.Property(e => e.Priceft)
                .HasMaxLength(8)
                .HasColumnName("priceft");
            entity.Property(e => e.Pricepub)
                .HasMaxLength(8)
                .HasColumnName("pricepub");
            entity.Property(e => e.Prodescription).HasColumnName("prodescription");
            entity.Property(e => e.Prodetailcode)
                .HasMaxLength(30)
                .HasColumnName("prodetailcode");
            entity.Property(e => e.Prodetailid).HasColumnName("prodetailid");
            entity.Property(e => e.Prodetailsize)
                .HasMaxLength(15)
                .HasColumnName("prodetailsize");
            entity.Property(e => e.Prodetailstatus)
                .HasMaxLength(20)
                .HasColumnName("prodetailstatus");
            entity.Property(e => e.Prodetailstock).HasColumnName("prodetailstock");
            entity.Property(e => e.Prodetailweight)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("prodetailweight");
            entity.Property(e => e.Prodiscprice)
                .HasMaxLength(8)
                .HasColumnName("prodiscprice");
            entity.Property(e => e.ProductionexportId).HasColumnName("productionexportID");
            entity.Property(e => e.Profileid).HasColumnName("profileid");
            entity.Property(e => e.Profilename)
                .HasMaxLength(50)
                .HasColumnName("profilename");
            entity.Property(e => e.Proid).HasColumnName("proid");
            entity.Property(e => e.Proname)
                .HasMaxLength(80)
                .HasColumnName("proname");
            entity.Property(e => e.Pronew)
                .HasMaxLength(8)
                .HasColumnName("pronew");
            entity.Property(e => e.Proprice).HasColumnName("proprice");
            entity.Property(e => e.Propriceexc).HasColumnName("propriceexc");
            entity.Property(e => e.Prospecial)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("prospecial");
            entity.Property(e => e.Qtyonreorder).HasColumnName("qtyonreorder");
            entity.Property(e => e.RebatePercentage)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("rebate_percentage");
            entity.Property(e => e.Reorderlevel).HasColumnName("reorderlevel");
            entity.Property(e => e.Reorderqty)
                .HasMaxLength(10)
                .HasColumnName("reorderqty");
            entity.Property(e => e.SeoDescription)
                .HasMaxLength(200)
                .HasColumnName("seo_description");
            entity.Property(e => e.SeoImgalt)
                .HasMaxLength(200)
                .HasColumnName("seo_imgalt");
            entity.Property(e => e.SeoImgtitle)
                .HasMaxLength(200)
                .HasColumnName("seo_imgtitle");
            entity.Property(e => e.SeoKeywords)
                .HasMaxLength(200)
                .HasColumnName("seo_keywords");
            entity.Property(e => e.SeoTitle)
                .HasMaxLength(200)
                .HasColumnName("seo_title");
            entity.Property(e => e.Status)
                .HasMaxLength(15)
                .HasColumnName("status");
            entity.Property(e => e.Subcatdesc)
                .HasMaxLength(500)
                .HasColumnName("subcatdesc");
            entity.Property(e => e.Subcategory)
                .HasMaxLength(120)
                .HasColumnName("subcategory");
            entity.Property(e => e.Taxexclusive).HasColumnName("taxexclusive");
            entity.Property(e => e.TotalRating).HasColumnName("total_rating");
            entity.Property(e => e.Tpfcode)
                .HasMaxLength(11)
                .HasColumnName("tpfcode");
            entity.Property(e => e.Type)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("type");
            entity.Property(e => e.Unspsc)
                .HasMaxLength(20)
                .HasColumnName("unspsc");
            entity.Property(e => e.Urladdress)
                .HasMaxLength(200)
                .HasColumnName("urladdress");
            entity.Property(e => e.VirtualName).HasMaxLength(90);
            entity.Property(e => e.Virtualrefid).HasColumnName("virtualrefid");
            entity.Property(e => e.Votes).HasColumnName("votes");
            entity.Property(e => e.Wasprice).HasColumnName("wasprice");
            entity.Property(e => e.Websafename)
                .HasMaxLength(80)
                .HasColumnName("websafename");
            entity.Property(e => e.Weight)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("weight");
        });

        modelBuilder.Entity<StockViewtest>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("stock_viewtest");

            entity.Property(e => e.Available).HasColumnName("available");
            entity.Property(e => e.AvgRating).HasColumnName("avg_rating");
            entity.Property(e => e.Backorderqty).HasColumnName("backorderqty");
            entity.Property(e => e.Barcode)
                .HasMaxLength(20)
                .HasColumnName("barcode");
            entity.Property(e => e.BoStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("bo_status");
            entity.Property(e => e.Cartonqty).HasColumnName("cartonqty");
            entity.Property(e => e.CatalogueId).HasColumnName("catalogueID");
            entity.Property(e => e.Cataloguegroup)
                .HasMaxLength(50)
                .HasColumnName("cataloguegroup");
            entity.Property(e => e.Cataloguename)
                .HasMaxLength(80)
                .HasColumnName("cataloguename");
            entity.Property(e => e.Categoryid).HasColumnName("categoryid");
            entity.Property(e => e.Categoryname)
                .HasMaxLength(40)
                .HasColumnName("categoryname");
            entity.Property(e => e.Catstatus)
                .HasMaxLength(15)
                .HasColumnName("catstatus");
            entity.Property(e => e.Currency)
                .HasMaxLength(10)
                .HasColumnName("currency");
            entity.Property(e => e.Currentprice).HasColumnName("currentprice");
            entity.Property(e => e.Custorder).HasColumnName("custorder");
            entity.Property(e => e.DefaultCurrentprice).HasColumnName("default_currentprice");
            entity.Property(e => e.DefaultWasprice).HasColumnName("default_wasprice");
            entity.Property(e => e.Defaultprofile).HasColumnName("defaultprofile");
            entity.Property(e => e.Discatpriority).HasColumnName("discatpriority");
            entity.Property(e => e.Discount)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("discount");
            entity.Property(e => e.Disporder).HasColumnName("disporder");
            entity.Property(e => e.Dispriority).HasColumnName("dispriority");
            entity.Property(e => e.DsmsetName)
                .HasMaxLength(82)
                .HasColumnName("DSMSetName");
            entity.Property(e => e.DsmsetRevision).HasColumnName("DSMSetRevision");
            entity.Property(e => e.GenerateVoucherCode).HasColumnName("generateVoucherCode");
            entity.Property(e => e.Gstrate).HasColumnName("gstrate");
            entity.Property(e => e.Hasgst)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("hasgst");
            entity.Property(e => e.Imagename)
                .HasMaxLength(50)
                .HasColumnName("imagename");
            entity.Property(e => e.Internalcode)
                .HasMaxLength(50)
                .HasColumnName("internalcode");
            entity.Property(e => e.Inventorystatus)
                .HasMaxLength(20)
                .HasColumnName("inventorystatus");
            entity.Property(e => e.Inventorystatustext)
                .HasMaxLength(100)
                .HasColumnName("inventorystatustext");
            entity.Property(e => e.IsAutoweight).HasColumnName("isAutoweight");
            entity.Property(e => e.IsEvent).HasColumnName("isEvent");
            entity.Property(e => e.IsPersonalised).HasColumnName("isPersonalised");
            entity.Property(e => e.IsPrepack).HasColumnName("isPrepack");
            entity.Property(e => e.Iskit).HasColumnName("iskit");
            entity.Property(e => e.Ispack).HasColumnName("ispack");
            entity.Property(e => e.Leadtime).HasColumnName("leadtime");
            entity.Property(e => e.Legacyfield)
                .HasMaxLength(20)
                .HasColumnName("legacyfield");
            entity.Property(e => e.Moq).HasColumnName("moq");
            entity.Property(e => e.Name)
                .HasMaxLength(90)
                .HasColumnName("name");
            entity.Property(e => e.Nismessage)
                .HasMaxLength(500)
                .HasColumnName("nismessage");
            entity.Property(e => e.Nondim)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("nondim");
            entity.Property(e => e.Nzdprice)
                .HasMaxLength(10)
                .HasColumnName("nzdprice");
            entity.Property(e => e.Online)
                .HasMaxLength(20)
                .HasColumnName("online");
            entity.Property(e => e.Ownedby)
                .HasMaxLength(80)
                .HasColumnName("ownedby");
            entity.Property(e => e.PLandedcost).HasColumnName("p_landedcost");
            entity.Property(e => e.PRebatepercent).HasColumnName("p_rebatepercent");
            entity.Property(e => e.PReportgroup).HasColumnName("p_reportgroup");
            entity.Property(e => e.PReportstatus)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("p_reportstatus");
            entity.Property(e => e.PackedItem)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("packed_item");
            entity.Property(e => e.Palletqty).HasColumnName("palletqty");
            entity.Property(e => e.PdWhid).HasColumnName("pd_whid");
            entity.Property(e => e.Pricef)
                .HasMaxLength(8)
                .HasColumnName("pricef");
            entity.Property(e => e.Priceft)
                .HasMaxLength(8)
                .HasColumnName("priceft");
            entity.Property(e => e.Pricepub)
                .HasMaxLength(8)
                .HasColumnName("pricepub");
            entity.Property(e => e.Prodescription).HasColumnName("prodescription");
            entity.Property(e => e.Prodetailcode)
                .HasMaxLength(30)
                .HasColumnName("prodetailcode");
            entity.Property(e => e.Prodetailid).HasColumnName("prodetailid");
            entity.Property(e => e.Prodetailsize)
                .HasMaxLength(15)
                .HasColumnName("prodetailsize");
            entity.Property(e => e.Prodetailstatus)
                .HasMaxLength(20)
                .HasColumnName("prodetailstatus");
            entity.Property(e => e.Prodetailstock).HasColumnName("prodetailstock");
            entity.Property(e => e.Prodetailweight)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("prodetailweight");
            entity.Property(e => e.Prodiscprice)
                .HasMaxLength(8)
                .HasColumnName("prodiscprice");
            entity.Property(e => e.ProductionexportId).HasColumnName("productionexportID");
            entity.Property(e => e.Profileid).HasColumnName("profileid");
            entity.Property(e => e.Profilename)
                .HasMaxLength(50)
                .HasColumnName("profilename");
            entity.Property(e => e.Proid).HasColumnName("proid");
            entity.Property(e => e.Proname)
                .HasMaxLength(80)
                .HasColumnName("proname");
            entity.Property(e => e.Pronew)
                .HasMaxLength(8)
                .HasColumnName("pronew");
            entity.Property(e => e.Proprice).HasColumnName("proprice");
            entity.Property(e => e.Propriceexc).HasColumnName("propriceexc");
            entity.Property(e => e.Prospecial)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("prospecial");
            entity.Property(e => e.Qtyonreorder).HasColumnName("qtyonreorder");
            entity.Property(e => e.RebatePercentage)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("rebate_percentage");
            entity.Property(e => e.Reorderlevel).HasColumnName("reorderlevel");
            entity.Property(e => e.Reorderqty)
                .HasMaxLength(10)
                .HasColumnName("reorderqty");
            entity.Property(e => e.SeoDescription)
                .HasMaxLength(200)
                .HasColumnName("seo_description");
            entity.Property(e => e.SeoImgalt)
                .HasMaxLength(200)
                .HasColumnName("seo_imgalt");
            entity.Property(e => e.SeoImgtitle)
                .HasMaxLength(200)
                .HasColumnName("seo_imgtitle");
            entity.Property(e => e.SeoKeywords)
                .HasMaxLength(200)
                .HasColumnName("seo_keywords");
            entity.Property(e => e.SeoTitle)
                .HasMaxLength(200)
                .HasColumnName("seo_title");
            entity.Property(e => e.Status)
                .HasMaxLength(15)
                .HasColumnName("status");
            entity.Property(e => e.Subcatdesc)
                .HasMaxLength(500)
                .HasColumnName("subcatdesc");
            entity.Property(e => e.Subcategory)
                .HasMaxLength(120)
                .HasColumnName("subcategory");
            entity.Property(e => e.Taxexclusive).HasColumnName("taxexclusive");
            entity.Property(e => e.TotalRating).HasColumnName("total_rating");
            entity.Property(e => e.Tpfcode)
                .HasMaxLength(11)
                .HasColumnName("tpfcode");
            entity.Property(e => e.Type)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("type");
            entity.Property(e => e.Unspsc)
                .HasMaxLength(20)
                .HasColumnName("unspsc");
            entity.Property(e => e.Urladdress)
                .HasMaxLength(200)
                .HasColumnName("urladdress");
            entity.Property(e => e.Virtualrefid).HasColumnName("virtualrefid");
            entity.Property(e => e.Votes).HasColumnName("votes");
            entity.Property(e => e.Wasprice).HasColumnName("wasprice");
            entity.Property(e => e.Websafename)
                .HasMaxLength(80)
                .HasColumnName("websafename");
            entity.Property(e => e.Weight)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("weight");
        });

        modelBuilder.Entity<Tag>(entity =>
        {
            entity.ToTable("tags");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Accesslevel).HasColumnName("accesslevel");
            entity.Property(e => e.Autogenerated).HasColumnName("autogenerated");
            entity.Property(e => e.Catalogueid).HasColumnName("catalogueid");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Description)
                .HasColumnType("ntext")
                .HasColumnName("description");
            entity.Property(e => e.Imagename)
                .HasMaxLength(50)
                .HasColumnName("imagename");
            entity.Property(e => e.Lastmodified)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("lastmodified");
            entity.Property(e => e.Name)
                .HasMaxLength(70)
                .HasColumnName("name");
            entity.Property(e => e.Priority)
                .HasDefaultValueSql("((9999))")
                .HasColumnName("priority");
            entity.Property(e => e.Type)
                .HasMaxLength(15)
                .HasDefaultValueSql("(N'public')")
                .HasColumnName("type");
            entity.Property(e => e.Webname)
                .HasMaxLength(50)
                .HasColumnName("webname");
        });

        modelBuilder.Entity<Tagmap>(entity =>
        {
            entity.ToTable("tagmap");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Lastmodified)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("lastmodified");
            entity.Property(e => e.Priority)
                .HasDefaultValueSql("((10))")
                .HasColumnName("priority");
            entity.Property(e => e.Proid).HasColumnName("proid");
            entity.Property(e => e.Tagid).HasColumnName("tagid");
        });

        modelBuilder.Entity<Tagmapbak>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tagmapbak");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Lastmodified).HasColumnName("lastmodified");
            entity.Property(e => e.Priority).HasColumnName("priority");
            entity.Property(e => e.Proid).HasColumnName("proid");
            entity.Property(e => e.Tagid).HasColumnName("tagid");
        });

        modelBuilder.Entity<Tagsbak>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tagsbak");

            entity.Property(e => e.Accesslevel).HasColumnName("accesslevel");
            entity.Property(e => e.Autogenerated).HasColumnName("autogenerated");
            entity.Property(e => e.Catalogueid).HasColumnName("catalogueid");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Description)
                .HasColumnType("ntext")
                .HasColumnName("description");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Imagename)
                .HasMaxLength(50)
                .HasColumnName("imagename");
            entity.Property(e => e.Lastmodified).HasColumnName("lastmodified");
            entity.Property(e => e.Name)
                .HasMaxLength(70)
                .HasColumnName("name");
            entity.Property(e => e.Priority).HasColumnName("priority");
            entity.Property(e => e.Type)
                .HasMaxLength(15)
                .HasColumnName("type");
            entity.Property(e => e.Webname)
                .HasMaxLength(50)
                .HasColumnName("webname");
        });

        modelBuilder.Entity<TemplateOcdetailsItem>(entity =>
        {
            entity.HasKey(e => e.OcdIdTemplate);

            entity.Property(e => e.OcdIdTemplate).HasColumnName("ocdIdTemplate");
            entity.Property(e => e.AflType)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasColumnName("AFL_Type");
            entity.Property(e => e.AflTypeId)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("AFL_TypeID");
            entity.Property(e => e.Bsitem)
                .HasDefaultValueSql("((0))")
                .HasColumnName("bsitem");
            entity.Property(e => e.CancelNotes)
                .HasMaxLength(200)
                .HasColumnName("cancelNotes");
            entity.Property(e => e.Cpcprodetailcode)
                .HasDefaultValueSql("((0))")
                .HasColumnName("cpcprodetailcode");
            entity.Property(e => e.DelWipLastChecked)
                .HasColumnType("datetime")
                .HasColumnName("del_wipLastChecked");
            entity.Property(e => e.DelWipStatus)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasColumnName("del_wipStatus");
            entity.Property(e => e.DelWipUpdateby)
                .HasDefaultValueSql("((0))")
                .HasColumnName("del_wipUpdateby");
            entity.Property(e => e.Detailstatus)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'current')")
                .HasColumnName("detailstatus");
            entity.Property(e => e.Fromlocationid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("fromlocationid");
            entity.Property(e => e.IPriceExc).HasColumnName("iPriceExc");
            entity.Property(e => e.IPriceTax).HasColumnName("iPriceTax");
            entity.Property(e => e.Imagepath)
                .HasMaxLength(512)
                .HasColumnName("imagepath");
            entity.Property(e => e.IsCustom)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isCustom");
            entity.Property(e => e.IsSubItem).HasColumnName("isSubItem");
            entity.Property(e => e.ItemCatalogueId)
                .HasDefaultValueSql("((213))")
                .HasColumnName("itemCatalogueID");
            entity.Property(e => e.Itemgroup)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))")
                .HasColumnName("itemgroup");
            entity.Property(e => e.Itemid).HasColumnName("itemid");
            entity.Property(e => e.Itemtype)
                .HasMaxLength(10)
                .HasDefaultValueSql("('adhoc')")
                .HasColumnName("itemtype");
            entity.Property(e => e.JcItemId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("jcItemID");
            entity.Property(e => e.Linenumber).HasColumnName("linenumber");
            entity.Property(e => e.Listposition)
                .HasDefaultValueSql("((0))")
                .HasColumnName("listposition");
            entity.Property(e => e.Occomments)
                .HasColumnType("ntext")
                .HasColumnName("occomments");
            entity.Property(e => e.Ocdetailcode)
                .HasMaxLength(100)
                .HasColumnName("ocdetailcode");
            entity.Property(e => e.Ocdetailgst).HasColumnName("ocdetailgst");
            entity.Property(e => e.Ocdetailid).HasColumnName("ocdetailid");
            entity.Property(e => e.Ocdetailimage)
                .HasMaxLength(50)
                .HasColumnName("ocdetailimage");
            entity.Property(e => e.Ocdetailname)
                .HasMaxLength(120)
                .HasColumnName("ocdetailname");
            entity.Property(e => e.Ocdetailprice).HasColumnName("ocdetailprice");
            entity.Property(e => e.Ocdetailqty).HasColumnName("ocdetailqty");
            entity.Property(e => e.Ocid).HasColumnName("ocid");
            entity.Property(e => e.PackItem)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'n')")
                .HasColumnName("packItem");
            entity.Property(e => e.Pricebreakid)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("pricebreakid");
            entity.Property(e => e.QtyAvailable)
                .HasDefaultValueSql("((0))")
                .HasColumnName("qtyAvailable");
            entity.Property(e => e.QtyBackOrder)
                .HasDefaultValueSql("((0))")
                .HasColumnName("qtyBackOrder");
            entity.Property(e => e.Qtydifference).HasColumnName("qtydifference");
            entity.Property(e => e.Qtynotmet).HasColumnName("qtynotmet");
            entity.Property(e => e.Qtyreceived).HasColumnName("qtyreceived");
            entity.Property(e => e.Qtyreserved)
                .HasDefaultValueSql("((0))")
                .HasColumnName("qtyreserved");
            entity.Property(e => e.Qtysent)
                .HasDefaultValueSql("((0))")
                .HasColumnName("qtysent");
            entity.Property(e => e.RawId)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("RawID");
            entity.Property(e => e.Ref1)
                .HasMaxLength(50)
                .HasColumnName("ref1");
            entity.Property(e => e.Ref2)
                .HasMaxLength(50)
                .HasColumnName("ref2");
            entity.Property(e => e.Ref3).HasColumnName("ref3");
            entity.Property(e => e.Refocdetailid).HasColumnName("refocdetailid");
            entity.Property(e => e.Returnreceive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("returnreceive");
            entity.Property(e => e.Returnrequest).HasColumnName("returnrequest");
            entity.Property(e => e.RoyaltyRef)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("royalty_ref");
            entity.Property(e => e.SalesCheckedDate)
                .HasColumnType("datetime")
                .HasColumnName("salesCheckedDate");
            entity.Property(e => e.SalesWipNote)
                .HasMaxLength(4000)
                .HasColumnName("salesWipNote");
            entity.Property(e => e.SalesWipStatus)
                .HasMaxLength(20)
                .HasDefaultValueSql("('current')")
                .HasColumnName("salesWipStatus");
            entity.Property(e => e.ShippingClass).HasDefaultValueSql("((1))");
            entity.Property(e => e.Suffix)
                .HasMaxLength(10)
                .HasColumnName("suffix");
            entity.Property(e => e.TaxRate)
                .HasDefaultValueSql("((0))")
                .HasColumnName("taxRate");
            entity.Property(e => e.Totalrequest)
                .HasDefaultValueSql("((0))")
                .HasColumnName("totalrequest");
            entity.Property(e => e.TpfCode)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasColumnName("tpfCode");
            entity.Property(e => e.Voucherid).HasColumnName("voucherid");
            entity.Property(e => e.Whid)
                .HasDefaultValueSql("((1))")
                .HasColumnName("whid");
            entity.Property(e => e.WipArtApproved)
                .HasMaxLength(15)
                .HasDefaultValueSql("('')")
                .HasColumnName("wip_artApproved");
            entity.Property(e => e.WipArtApprovedDate)
                .HasColumnType("datetime")
                .HasColumnName("wip_artApprovedDate");
        });

        modelBuilder.Entity<Test>(entity =>
        {
            entity.ToTable("Test");

            entity.Property(e => e.ContactId).HasMaxLength(200);
            entity.Property(e => e.GyId).HasMaxLength(200);
        });

        modelBuilder.Entity<UserSchoolCheck>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserScho__3214EC07FCF16BEC");

            entity.ToTable("UserSchoolCheck");

            entity.Property(e => e.Email).HasMaxLength(250);
            entity.Property(e => e.GigyaId)
                .HasMaxLength(250)
                .HasColumnName("GIgyaID");
            entity.Property(e => e.LegacyId).HasMaxLength(250);
            entity.Property(e => e.NewIds).HasMaxLength(250);
        });

        modelBuilder.Entity<VCaDetailsPack>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_CaDetailsPack");

            entity.Property(e => e.Backorderqty).HasColumnName("backorderqty");
            entity.Property(e => e.BblclubCode)
                .HasMaxLength(50)
                .HasColumnName("BBLClubCode");
            entity.Property(e => e.BblclunName)
                .HasMaxLength(50)
                .HasColumnName("BBLClunName");
            entity.Property(e => e.Bblname)
                .HasMaxLength(200)
                .HasColumnName("BBLNAME");
            entity.Property(e => e.BoStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("bo_status");
            entity.Property(e => e.CaBblclub).HasColumnName("CaBBLClub");
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Custorder).HasColumnName("custorder");
            entity.Property(e => e.Expr3).HasMaxLength(30);
            entity.Property(e => e.IdBblclub).HasColumnName("IdBBLClub");
            entity.Property(e => e.Image).HasMaxLength(100);
            entity.Property(e => e.Internalcode)
                .HasMaxLength(50)
                .HasColumnName("internalcode");
            entity.Property(e => e.Inventorystatus)
                .HasMaxLength(20)
                .HasColumnName("inventorystatus");
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Lastturnontosync)
                .HasColumnType("datetime")
                .HasColumnName("lastturnontosync");
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.PPriority).HasColumnName("p_priority");
            entity.Property(e => e.PackType).HasMaxLength(20);
            entity.Property(e => e.ProId).HasColumnName("proID");
            entity.Property(e => e.ProdetailId).HasColumnName("prodetailID");
            entity.Property(e => e.Prodetailsize)
                .HasMaxLength(15)
                .HasColumnName("prodetailsize");
            entity.Property(e => e.Prodetailstatus)
                .HasMaxLength(20)
                .HasColumnName("prodetailstatus");
            entity.Property(e => e.Prodetailstock).HasColumnName("prodetailstock");
            entity.Property(e => e.Prodetailweight)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("prodetailweight");
            entity.Property(e => e.ProductType).HasMaxLength(50);
            entity.Property(e => e.Qtyonreorder).HasColumnName("qtyonreorder");
            entity.Property(e => e.Reorderqty)
                .HasMaxLength(10)
                .HasColumnName("reorderqty");
            entity.Property(e => e.ReserveQty).HasColumnName("reserveQty");
            entity.Property(e => e.Size).HasMaxLength(10);
            entity.Property(e => e.Sku)
                .HasMaxLength(50)
                .HasColumnName("SKU");
            entity.Property(e => e.Skuid).HasColumnName("SKUID");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StatusProduct).HasMaxLength(50);
            entity.Property(e => e.Tpfname)
                .HasMaxLength(50)
                .HasColumnName("tpfname");
            entity.Property(e => e.VirtualCode).HasMaxLength(50);
        });

        modelBuilder.Entity<VCaDetailsPackPublic>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_CaDetailsPack_public");

            entity.Property(e => e.Backorderqty).HasColumnName("backorderqty");
            entity.Property(e => e.BblclubCode)
                .HasMaxLength(50)
                .HasColumnName("BBLClubCode");
            entity.Property(e => e.BblclunName)
                .HasMaxLength(50)
                .HasColumnName("BBLClunName");
            entity.Property(e => e.Bblname)
                .HasMaxLength(200)
                .HasColumnName("BBLNAME");
            entity.Property(e => e.BoStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("bo_status");
            entity.Property(e => e.CaBblclub).HasColumnName("CaBBLClub");
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Custorder).HasColumnName("custorder");
            entity.Property(e => e.Expr3).HasMaxLength(30);
            entity.Property(e => e.IdBblclub).HasColumnName("IdBBLClub");
            entity.Property(e => e.Image).HasMaxLength(100);
            entity.Property(e => e.Internalcode)
                .HasMaxLength(50)
                .HasColumnName("internalcode");
            entity.Property(e => e.Inventorystatus)
                .HasMaxLength(20)
                .HasColumnName("inventorystatus");
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Lastturnontosync)
                .HasColumnType("datetime")
                .HasColumnName("lastturnontosync");
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.PPriority).HasColumnName("p_priority");
            entity.Property(e => e.PackType).HasMaxLength(20);
            entity.Property(e => e.ProId).HasColumnName("proID");
            entity.Property(e => e.ProdetailId).HasColumnName("prodetailID");
            entity.Property(e => e.Prodetailsize)
                .HasMaxLength(15)
                .HasColumnName("prodetailsize");
            entity.Property(e => e.Prodetailstatus)
                .HasMaxLength(20)
                .HasColumnName("prodetailstatus");
            entity.Property(e => e.Prodetailstock).HasColumnName("prodetailstock");
            entity.Property(e => e.Prodetailweight)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("prodetailweight");
            entity.Property(e => e.ProductType).HasMaxLength(50);
            entity.Property(e => e.Qtyonreorder).HasColumnName("qtyonreorder");
            entity.Property(e => e.Reorderqty)
                .HasMaxLength(10)
                .HasColumnName("reorderqty");
            entity.Property(e => e.ReserveQty).HasColumnName("reserveQty");
            entity.Property(e => e.Size).HasMaxLength(10);
            entity.Property(e => e.Sku)
                .HasMaxLength(50)
                .HasColumnName("SKU");
            entity.Property(e => e.Skuid).HasColumnName("SKUID");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StatusProduct).HasMaxLength(50);
            entity.Property(e => e.Tpfname)
                .HasMaxLength(50)
                .HasColumnName("tpfname");
            entity.Property(e => e.VirtualCode).HasMaxLength(50);
        });

        modelBuilder.Entity<VCaDetailsPacknNoneQty>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_CaDetailsPacknNoneQty");

            entity.Property(e => e.Backorderqty).HasColumnName("backorderqty");
            entity.Property(e => e.BblclubCode)
                .HasMaxLength(50)
                .HasColumnName("BBLClubCode");
            entity.Property(e => e.BblclunName)
                .HasMaxLength(50)
                .HasColumnName("BBLClunName");
            entity.Property(e => e.Bblname)
                .HasMaxLength(200)
                .HasColumnName("BBLNAME");
            entity.Property(e => e.BoStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("bo_status");
            entity.Property(e => e.CaBblclub).HasColumnName("CaBBLClub");
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Custorder).HasColumnName("custorder");
            entity.Property(e => e.Expr3).HasMaxLength(30);
            entity.Property(e => e.IdBblclub).HasColumnName("IdBBLClub");
            entity.Property(e => e.Image).HasMaxLength(100);
            entity.Property(e => e.Internalcode)
                .HasMaxLength(50)
                .HasColumnName("internalcode");
            entity.Property(e => e.Inventorystatus)
                .HasMaxLength(20)
                .HasColumnName("inventorystatus");
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Lastturnontosync)
                .HasColumnType("datetime")
                .HasColumnName("lastturnontosync");
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.PPriority).HasColumnName("p_priority");
            entity.Property(e => e.PackType).HasMaxLength(20);
            entity.Property(e => e.ProId).HasColumnName("proID");
            entity.Property(e => e.ProdetailId).HasColumnName("prodetailID");
            entity.Property(e => e.Prodetailsize)
                .HasMaxLength(15)
                .HasColumnName("prodetailsize");
            entity.Property(e => e.Prodetailstatus)
                .HasMaxLength(20)
                .HasColumnName("prodetailstatus");
            entity.Property(e => e.Prodetailstock).HasColumnName("prodetailstock");
            entity.Property(e => e.Prodetailweight)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("prodetailweight");
            entity.Property(e => e.ProductType).HasMaxLength(50);
            entity.Property(e => e.Qtyonreorder).HasColumnName("qtyonreorder");
            entity.Property(e => e.Reorderqty)
                .HasMaxLength(10)
                .HasColumnName("reorderqty");
            entity.Property(e => e.ReserveQty).HasColumnName("reserveQty");
            entity.Property(e => e.Size).HasMaxLength(10);
            entity.Property(e => e.Sku)
                .HasMaxLength(50)
                .HasColumnName("SKU");
            entity.Property(e => e.Skuid).HasColumnName("SKUID");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StatusProduct).HasMaxLength(50);
            entity.Property(e => e.Tpfname)
                .HasMaxLength(50)
                .HasColumnName("tpfname");
            entity.Property(e => e.VirtualCode).HasMaxLength(50);
        });

        modelBuilder.Entity<VCaDetailsPackpl>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_CaDetailsPackpl");

            entity.Property(e => e.Backorderqty).HasColumnName("backorderqty");
            entity.Property(e => e.BblclubCode)
                .HasMaxLength(50)
                .HasColumnName("BBLClubCode");
            entity.Property(e => e.BblclunName)
                .HasMaxLength(50)
                .HasColumnName("BBLClunName");
            entity.Property(e => e.Bblname)
                .HasMaxLength(200)
                .HasColumnName("BBLNAME");
            entity.Property(e => e.BoStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("bo_status");
            entity.Property(e => e.CaBblclub).HasColumnName("CaBBLClub");
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Custorder).HasColumnName("custorder");
            entity.Property(e => e.Expr3).HasMaxLength(30);
            entity.Property(e => e.IdBblclub).HasColumnName("IdBBLClub");
            entity.Property(e => e.Image).HasMaxLength(100);
            entity.Property(e => e.Internalcode)
                .HasMaxLength(50)
                .HasColumnName("internalcode");
            entity.Property(e => e.Inventorystatus)
                .HasMaxLength(20)
                .HasColumnName("inventorystatus");
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Lastturnontosync)
                .HasColumnType("datetime")
                .HasColumnName("lastturnontosync");
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.PPriority).HasColumnName("p_priority");
            entity.Property(e => e.PackType).HasMaxLength(20);
            entity.Property(e => e.ProId).HasColumnName("proID");
            entity.Property(e => e.ProdetailId).HasColumnName("prodetailID");
            entity.Property(e => e.Prodetailsize)
                .HasMaxLength(15)
                .HasColumnName("prodetailsize");
            entity.Property(e => e.Prodetailstatus)
                .HasMaxLength(20)
                .HasColumnName("prodetailstatus");
            entity.Property(e => e.Prodetailstock).HasColumnName("prodetailstock");
            entity.Property(e => e.Prodetailweight)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("prodetailweight");
            entity.Property(e => e.ProductType).HasMaxLength(50);
            entity.Property(e => e.Qtyonreorder).HasColumnName("qtyonreorder");
            entity.Property(e => e.Reorderqty)
                .HasMaxLength(10)
                .HasColumnName("reorderqty");
            entity.Property(e => e.ReserveQty).HasColumnName("reserveQty");
            entity.Property(e => e.Size).HasMaxLength(10);
            entity.Property(e => e.Sku)
                .HasMaxLength(50)
                .HasColumnName("SKU");
            entity.Property(e => e.Skuid).HasColumnName("SKUID");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StatusProduct).HasMaxLength(50);
            entity.Property(e => e.Tpfname)
                .HasMaxLength(50)
                .HasColumnName("tpfname");
            entity.Property(e => e.VirtualCode).HasMaxLength(50);
        });

        modelBuilder.Entity<VCaFindCaEntity>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_ca_find_caEntity");

            entity.Property(e => e.ClientId).HasColumnName("clientID");
            entity.Property(e => e.DelCompanyname)
                .HasMaxLength(250)
                .HasColumnName("del_companyname");
            entity.Property(e => e.EntityId)
                .HasMaxLength(50)
                .HasColumnName("entityID");
            entity.Property(e => e.EntityName)
                .HasMaxLength(200)
                .HasColumnName("entityName");
            entity.Property(e => e.RoleName).HasMaxLength(150);
            entity.Property(e => e.WebAccId).HasColumnName("webAccID");
        });

        modelBuilder.Entity<VCaGetbbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_ca_getbbl");

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<VCaOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_CA_orders");

            entity.Property(e => e.Abn)
                .HasMaxLength(30)
                .HasColumnName("abn");
            entity.Property(e => e.ActionCheckedBy).HasColumnName("actionCheckedBy");
            entity.Property(e => e.ActionCheckedDate)
                .HasColumnType("datetime")
                .HasColumnName("actionCheckedDate");
            entity.Property(e => e.ActionStatus)
                .HasMaxLength(12)
                .HasColumnName("actionStatus");
            entity.Property(e => e.Addr1)
                .HasMaxLength(150)
                .HasColumnName("addr1");
            entity.Property(e => e.Addr2)
                .HasMaxLength(80)
                .HasColumnName("addr2");
            entity.Property(e => e.Addr3)
                .HasMaxLength(80)
                .HasColumnName("addr3");
            entity.Property(e => e.AlreadyNotified).HasColumnName("already_notified");
            entity.Property(e => e.Ariba)
                .HasMaxLength(5)
                .HasColumnName("ariba");
            entity.Property(e => e.Assignedto).HasColumnName("assignedto");
            entity.Property(e => e.AudtoHkdrate).HasColumnName("AUDtoHKDRate");
            entity.Property(e => e.BAbn)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("b_abn");
            entity.Property(e => e.BAddr1)
                .HasMaxLength(500)
                .HasColumnName("b_addr1");
            entity.Property(e => e.BAddr2)
                .HasMaxLength(500)
                .HasColumnName("b_addr2");
            entity.Property(e => e.BAddr3)
                .HasMaxLength(500)
                .HasColumnName("b_addr3");
            entity.Property(e => e.BAddrid).HasColumnName("b_addrid");
            entity.Property(e => e.BAttention)
                .HasMaxLength(100)
                .HasColumnName("b_attention");
            entity.Property(e => e.BCompanyname)
                .HasMaxLength(500)
                .HasColumnName("b_companyname");
            entity.Property(e => e.BCountry)
                .HasMaxLength(100)
                .HasColumnName("b_country");
            entity.Property(e => e.BEmail)
                .HasMaxLength(100)
                .HasColumnName("b_email");
            entity.Property(e => e.BFax)
                .HasMaxLength(20)
                .HasColumnName("b_fax");
            entity.Property(e => e.BFname)
                .HasMaxLength(100)
                .HasColumnName("b_fname");
            entity.Property(e => e.BLname)
                .HasMaxLength(50)
                .HasColumnName("b_lname");
            entity.Property(e => e.BMobile)
                .HasMaxLength(20)
                .HasColumnName("b_mobile");
            entity.Property(e => e.BPhone)
                .HasMaxLength(50)
                .HasColumnName("b_phone");
            entity.Property(e => e.BPostcode)
                .HasMaxLength(10)
                .HasColumnName("b_postcode");
            entity.Property(e => e.CTotal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("cTotal");
            entity.Property(e => e.CTotalExc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("cTotalExc");
            entity.Property(e => e.CancelledBy).HasColumnName("cancelledBy");
            entity.Property(e => e.CancelledDate)
                .HasColumnType("datetime")
                .HasColumnName("cancelledDate");
            entity.Property(e => e.Catalogueid).HasColumnName("catalogueid");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.ClientId).HasColumnName("clientID");
            entity.Property(e => e.ClientReference)
                .HasMaxLength(120)
                .HasColumnName("clientReference");
            entity.Property(e => e.ClosedDate)
                .HasColumnType("datetime")
                .HasColumnName("closedDate");
            entity.Property(e => e.Closedby).HasColumnName("closedby");
            entity.Property(e => e.ClubId).HasColumnName("clubID");
            entity.Property(e => e.Companyname)
                .HasMaxLength(250)
                .HasColumnName("companyname");
            entity.Property(e => e.Completionstatus)
                .HasMaxLength(3)
                .HasColumnName("completionstatus");
            entity.Property(e => e.Costcentre)
                .HasMaxLength(100)
                .HasColumnName("costcentre");
            entity.Property(e => e.CostingNotes)
                .HasColumnType("text")
                .HasColumnName("costingNotes");
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .HasColumnName("country");
            entity.Property(e => e.Credittotalexcgst).HasColumnName("credittotalexcgst");
            entity.Property(e => e.Currency)
                .HasMaxLength(10)
                .HasColumnName("currency");
            entity.Property(e => e.DAddr1)
                .HasMaxLength(500)
                .HasColumnName("d_addr1");
            entity.Property(e => e.DAddr2)
                .HasMaxLength(500)
                .HasColumnName("d_addr2");
            entity.Property(e => e.DAddr3)
                .HasMaxLength(500)
                .HasColumnName("d_addr3");
            entity.Property(e => e.DAddrid).HasColumnName("d_addrid");
            entity.Property(e => e.DAttention)
                .HasMaxLength(100)
                .HasColumnName("d_attention");
            entity.Property(e => e.DCompanyname)
                .HasMaxLength(500)
                .HasColumnName("d_companyname");
            entity.Property(e => e.DCountry)
                .HasMaxLength(500)
                .HasColumnName("d_country");
            entity.Property(e => e.DEmail)
                .HasMaxLength(500)
                .HasColumnName("d_email");
            entity.Property(e => e.DFax)
                .HasMaxLength(500)
                .HasColumnName("d_fax");
            entity.Property(e => e.DFname)
                .HasMaxLength(500)
                .HasColumnName("d_fname");
            entity.Property(e => e.DLname)
                .HasMaxLength(500)
                .HasColumnName("d_lname");
            entity.Property(e => e.DMobile)
                .HasMaxLength(500)
                .HasColumnName("d_mobile");
            entity.Property(e => e.DNotes)
                .HasColumnType("text")
                .HasColumnName("d_notes");
            entity.Property(e => e.DPhone)
                .HasMaxLength(500)
                .HasColumnName("d_phone");
            entity.Property(e => e.DPostcode)
                .HasMaxLength(500)
                .HasColumnName("d_postcode");
            entity.Property(e => e.DStatus)
                .HasMaxLength(50)
                .HasColumnName("d_status");
            entity.Property(e => e.DWhid).HasColumnName("d_whid");
            entity.Property(e => e.DelStatus)
                .HasMaxLength(20)
                .HasColumnName("del_status");
            entity.Property(e => e.DelStatusClosedBy).HasColumnName("del_status_closedBy");
            entity.Property(e => e.DelStatusClosedDate)
                .HasColumnType("datetime")
                .HasColumnName("del_status_closedDate");
            entity.Property(e => e.Deldetails)
                .HasColumnType("ntext")
                .HasColumnName("deldetails");
            entity.Property(e => e.DeliveryDate)
                .HasColumnType("datetime")
                .HasColumnName("deliveryDate");
            entity.Property(e => e.Disclaimer)
                .HasColumnType("text")
                .HasColumnName("disclaimer");
            entity.Property(e => e.Email)
                .HasMaxLength(80)
                .HasColumnName("email");
            entity.Property(e => e.Enteredby)
                .HasMaxLength(50)
                .HasColumnName("enteredby");
            entity.Property(e => e.EntityId)
                .HasMaxLength(50)
                .HasColumnName("entityID");
            entity.Property(e => e.EntityName)
                .HasMaxLength(200)
                .HasColumnName("entityName");
            entity.Property(e => e.EntityType)
                .HasMaxLength(50)
                .HasColumnName("entityType");
            entity.Property(e => e.ErrorCount).HasColumnName("errorCount");
            entity.Property(e => e.Exchangerate).HasColumnName("exchangerate");
            entity.Property(e => e.Fax)
                .HasMaxLength(25)
                .HasColumnName("fax");
            entity.Property(e => e.FinanceJobComment)
                .HasMaxLength(2000)
                .HasColumnName("financeJobComment");
            entity.Property(e => e.FinanceMargin).HasColumnName("finance_margin");
            entity.Property(e => e.Fname)
                .HasMaxLength(50)
                .HasColumnName("fname");
            entity.Property(e => e.Fob)
                .HasMaxLength(10)
                .HasColumnName("FOB");
            entity.Property(e => e.FrcstMargin)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("frcstMargin");
            entity.Property(e => e.GlCategory)
                .HasMaxLength(5)
                .HasColumnName("gl_category");
            entity.Property(e => e.GlId).HasColumnName("glID");
            entity.Property(e => e.GlOption)
                .HasMaxLength(10)
                .HasColumnName("gl_option");
            entity.Property(e => e.GlOrderIndex).HasColumnName("gl_orderIndex");
            entity.Property(e => e.GlSubgroup)
                .HasMaxLength(30)
                .HasColumnName("gl_subgroup");
            entity.Property(e => e.Gstrate)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("gstrate");
            entity.Property(e => e.Handledby).HasColumnName("handledby");
            entity.Property(e => e.HkJobClosedBy).HasColumnName("hkJobClosedBy");
            entity.Property(e => e.HkJobClosingDate)
                .HasColumnType("datetime")
                .HasColumnName("hkJobClosingDate");
            entity.Property(e => e.Hkjobstatus)
                .HasMaxLength(20)
                .HasColumnName("hkjobstatus");
            entity.Property(e => e.Hkorderstatus)
                .HasMaxLength(20)
                .HasColumnName("HKorderstatus");
            entity.Property(e => e.HoldOrder)
                .HasMaxLength(50)
                .HasColumnName("holdOrder");
            entity.Property(e => e.IOrderTotal).HasColumnName("iOrderTotal");
            entity.Property(e => e.IOrderTotalExc).HasColumnName("iOrderTotalExc");
            entity.Property(e => e.ITotal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("iTotal");
            entity.Property(e => e.ITotalExc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("iTotalExc");
            entity.Property(e => e.Importref)
                .HasMaxLength(50)
                .HasColumnName("importref");
            entity.Property(e => e.Invoicetotal).HasColumnName("invoicetotal");
            entity.Property(e => e.Invoicetotalexcgst).HasColumnName("invoicetotalexcgst");
            entity.Property(e => e.IsDuplicate)
                .HasMaxLength(50)
                .HasColumnName("isDuplicate");
            entity.Property(e => e.IsMagento).HasColumnName("isMagento");
            entity.Property(e => e.IsSynced).HasColumnName("isSynced");
            entity.Property(e => e.Joblastchanged)
                .HasColumnType("datetime")
                .HasColumnName("joblastchanged");
            entity.Property(e => e.Jobstatus)
                .HasMaxLength(20)
                .HasColumnName("jobstatus");
            entity.Property(e => e.Lastchangenote)
                .HasMaxLength(300)
                .HasColumnName("lastchangenote");
            entity.Property(e => e.Lastdeliverydate)
                .HasColumnType("datetime")
                .HasColumnName("lastdeliverydate");
            entity.Property(e => e.Lastupdate)
                .HasColumnType("datetime")
                .HasColumnName("lastupdate");
            entity.Property(e => e.Lname)
                .HasMaxLength(50)
                .HasColumnName("lname");
            entity.Property(e => e.MembershipNumber).HasMaxLength(50);
            entity.Property(e => e.Mobile)
                .HasMaxLength(25)
                .HasColumnName("mobile");
            entity.Property(e => e.Notes)
                .HasColumnType("ntext")
                .HasColumnName("notes");
            entity.Property(e => e.Ocid).HasColumnName("ocid");
            entity.Property(e => e.Oclastupdated)
                .HasColumnType("datetime")
                .HasColumnName("oclastupdated");
            entity.Property(e => e.Ocupdatedby).HasColumnName("ocupdatedby");
            entity.Property(e => e.Onhold).HasColumnName("onhold");
            entity.Property(e => e.OnlineOrder)
                .HasMaxLength(50)
                .HasColumnName("onlineOrder");
            entity.Property(e => e.OpenedBy).HasColumnName("openedBy");
            entity.Property(e => e.OpenedDate)
                .HasColumnType("datetime")
                .HasColumnName("openedDate");
            entity.Property(e => e.OrderCategoryId).HasColumnName("order_category_id");
            entity.Property(e => e.OrderGroup)
                .HasMaxLength(100)
                .HasColumnName("order_group");
            entity.Property(e => e.Ordertotal).HasColumnName("ordertotal");
            entity.Property(e => e.Ordertotalexc).HasColumnName("ordertotalexc");
            entity.Property(e => e.OrgOrderTotal).HasColumnName("orgOrderTotal");
            entity.Property(e => e.OsNoteCheck).HasColumnName("osNoteCheck");
            entity.Property(e => e.Payoption)
                .HasMaxLength(50)
                .HasColumnName("payoption");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .HasColumnName("phone");
            entity.Property(e => e.PlGroup).HasColumnName("plGroup");
            entity.Property(e => e.PoNumber)
                .HasMaxLength(100)
                .HasColumnName("poNumber");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .HasColumnName("position");
            entity.Property(e => e.Postcode)
                .HasMaxLength(12)
                .HasColumnName("postcode");
            entity.Property(e => e.ProMarketId).HasColumnName("proMarketID");
            entity.Property(e => e.ProcessDate)
                .HasColumnType("datetime")
                .HasColumnName("processDate");
            entity.Property(e => e.Processedby)
                .HasMaxLength(60)
                .HasColumnName("processedby");
            entity.Property(e => e.Productionstaff)
                .HasMaxLength(50)
                .HasColumnName("productionstaff");
            entity.Property(e => e.ProfileId).HasColumnName("profileID");
            entity.Property(e => e.ProgramId).HasColumnName("programID");
            entity.Property(e => e.Projectid)
                .HasMaxLength(50)
                .HasColumnName("projectid");
            entity.Property(e => e.PromotionName)
                .HasMaxLength(120)
                .HasColumnName("promotionName");
            entity.Property(e => e.RateEntityToAud).HasColumnName("RateEntityToAUD");
            entity.Property(e => e.RawId).HasColumnName("rawID");
            entity.Property(e => e.ReportDisplay)
                .HasMaxLength(10)
                .HasColumnName("reportDisplay");
            entity.Property(e => e.Reportdate)
                .HasColumnType("datetime")
                .HasColumnName("reportdate");
            entity.Property(e => e.RoyaltyContract).HasColumnName("royaltyContract");
            entity.Property(e => e.SaleType).HasColumnName("saleType");
            entity.Property(e => e.SalesCheckedDate)
                .HasColumnType("datetime")
                .HasColumnName("salesCheckedDate");
            entity.Property(e => e.SalesWipStatus)
                .HasMaxLength(20)
                .HasColumnName("salesWipStatus");
            entity.Property(e => e.Sendwithgoods)
                .HasMaxLength(50)
                .HasColumnName("sendwithgoods");
            entity.Property(e => e.Showsubtotal)
                .HasMaxLength(10)
                .HasColumnName("showsubtotal");
            entity.Property(e => e.Singleinvoice).HasColumnName("singleinvoice");
            entity.Property(e => e.Source)
                .HasMaxLength(50)
                .HasColumnName("source");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasColumnName("status");
            entity.Property(e => e.SubmitDate)
                .HasColumnType("datetime")
                .HasColumnName("submitDate");
            entity.Property(e => e.SystemEntityId).HasColumnName("system_entityID");
            entity.Property(e => e.Tobeinvoiced)
                .HasMaxLength(10)
                .HasColumnName("tobeinvoiced");
            entity.Property(e => e.Totalcost)
                .HasMaxLength(15)
                .HasColumnName("totalcost");
            entity.Property(e => e.TpforderId).HasColumnName("TPFOrderID");
            entity.Property(e => e.Trackingcode)
                .HasMaxLength(50)
                .HasColumnName("trackingcode");
            entity.Property(e => e.Tradeterms)
                .HasMaxLength(50)
                .HasColumnName("tradeterms");
            entity.Property(e => e.Tradingname)
                .HasMaxLength(250)
                .HasColumnName("tradingname");
            entity.Property(e => e.TxnRef)
                .HasMaxLength(50)
                .HasColumnName("txnRef");
            entity.Property(e => e.UsdtoHkdrate).HasColumnName("USDtoHKDRate");
            entity.Property(e => e.Vendorno)
                .HasMaxLength(50)
                .HasColumnName("vendorno");
            entity.Property(e => e.Visible)
                .HasMaxLength(10)
                .HasColumnName("visible");
            entity.Property(e => e.Webstoreno)
                .HasMaxLength(50)
                .HasColumnName("webstoreno");
            entity.Property(e => e.Whid).HasColumnName("whid");
            entity.Property(e => e.WipComment)
                .HasMaxLength(4000)
                .HasColumnName("wipComment");
            entity.Property(e => e.WipFlag).HasColumnName("wipFlag");
            entity.Property(e => e.WipNote)
                .HasMaxLength(500)
                .HasColumnName("wipNote");
        });

        modelBuilder.Entity<VCaProductProfileProductPrice>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_CA_ProductProfile_ProductPrice");

            entity.Property(e => e.AddNotes)
                .HasMaxLength(2000)
                .HasColumnName("addNotes");
            entity.Property(e => e.Cancelledby).HasColumnName("cancelledby");
            entity.Property(e => e.Cancelledon)
                .HasColumnType("datetime")
                .HasColumnName("cancelledon");
            entity.Property(e => e.CartonMark)
                .HasMaxLength(2000)
                .HasColumnName("cartonMark");
            entity.Property(e => e.CatalogueId).HasColumnName("catalogueID");
            entity.Property(e => e.DefaultProfile)
                .HasMaxLength(10)
                .HasColumnName("defaultProfile");
            entity.Property(e => e.EventProfileId).HasColumnName("eventProfileID");
            entity.Property(e => e.Expr6).HasMaxLength(20);
            entity.Property(e => e.Expr7).HasMaxLength(10);
            entity.Property(e => e.Expr9).HasColumnType("decimal(16, 2)");
            entity.Property(e => e.InnerQty)
                .HasMaxLength(250)
                .HasColumnName("innerQty");
            entity.Property(e => e.ItemColour)
                .HasMaxLength(500)
                .HasColumnName("itemColour");
            entity.Property(e => e.ItemDesc)
                .HasMaxLength(250)
                .HasColumnName("itemDesc");
            entity.Property(e => e.ItemNotes)
                .HasMaxLength(1500)
                .HasColumnName("itemNotes");
            entity.Property(e => e.ItemSizeType)
                .HasMaxLength(30)
                .HasColumnName("itemSizeType");
            entity.Property(e => e.Jobbagid)
                .HasMaxLength(15)
                .HasColumnName("jobbagid");
            entity.Property(e => e.LastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdate");
            entity.Property(e => e.MainStockProfileid).HasColumnName("mainStockProfileid");
            entity.Property(e => e.OuterQty)
                .HasMaxLength(250)
                .HasColumnName("outerQty");
            entity.Property(e => e.PackQty).HasColumnName("packQty");
            entity.Property(e => e.PackType)
                .HasMaxLength(250)
                .HasColumnName("packType");
            entity.Property(e => e.Plocation)
                .HasMaxLength(15)
                .HasColumnName("plocation");
            entity.Property(e => e.ProfileName)
                .HasMaxLength(250)
                .HasColumnName("profileName");
            entity.Property(e => e.ProfileNotes)
                .HasMaxLength(500)
                .HasColumnName("profileNotes");
            entity.Property(e => e.Proid).HasColumnName("proid");
            entity.Property(e => e.Pstatus)
                .HasMaxLength(20)
                .HasColumnName("pstatus");
            entity.Property(e => e.Qareport)
                .HasMaxLength(2000)
                .HasColumnName("QAReport");
            entity.Property(e => e.SpLocation)
                .HasMaxLength(35)
                .HasColumnName("spLocation");
            entity.Property(e => e.TickPackRequired)
                .HasMaxLength(25)
                .HasColumnName("tick_packRequired");
            entity.Property(e => e.Updateby).HasColumnName("updateby");
        });

        modelBuilder.Entity<VCaProductProfileProductPricegroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_CA_ProductProfile_ProductPricegroup");

            entity.Property(e => e.AddNotes)
                .HasMaxLength(2000)
                .HasColumnName("addNotes");
            entity.Property(e => e.Cancelledby).HasColumnName("cancelledby");
            entity.Property(e => e.Cancelledon)
                .HasColumnType("datetime")
                .HasColumnName("cancelledon");
            entity.Property(e => e.CartonMark)
                .HasMaxLength(2000)
                .HasColumnName("cartonMark");
            entity.Property(e => e.CatalogueId).HasColumnName("catalogueID");
            entity.Property(e => e.DefaultProfile)
                .HasMaxLength(10)
                .HasColumnName("defaultProfile");
            entity.Property(e => e.EventProfileId).HasColumnName("eventProfileID");
            entity.Property(e => e.Expr6).HasMaxLength(20);
            entity.Property(e => e.Expr7).HasMaxLength(10);
            entity.Property(e => e.Expr9).HasColumnType("decimal(16, 2)");
            entity.Property(e => e.InnerQty)
                .HasMaxLength(250)
                .HasColumnName("innerQty");
            entity.Property(e => e.ItemColour)
                .HasMaxLength(500)
                .HasColumnName("itemColour");
            entity.Property(e => e.ItemDesc)
                .HasMaxLength(250)
                .HasColumnName("itemDesc");
            entity.Property(e => e.ItemNotes)
                .HasMaxLength(1500)
                .HasColumnName("itemNotes");
            entity.Property(e => e.ItemSizeType)
                .HasMaxLength(30)
                .HasColumnName("itemSizeType");
            entity.Property(e => e.Jobbagid)
                .HasMaxLength(15)
                .HasColumnName("jobbagid");
            entity.Property(e => e.LastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdate");
            entity.Property(e => e.MainStockProfileid).HasColumnName("mainStockProfileid");
            entity.Property(e => e.OuterQty)
                .HasMaxLength(250)
                .HasColumnName("outerQty");
            entity.Property(e => e.PackQty).HasColumnName("packQty");
            entity.Property(e => e.PackType)
                .HasMaxLength(250)
                .HasColumnName("packType");
            entity.Property(e => e.Plocation)
                .HasMaxLength(15)
                .HasColumnName("plocation");
            entity.Property(e => e.ProfileName)
                .HasMaxLength(250)
                .HasColumnName("profileName");
            entity.Property(e => e.ProfileNotes)
                .HasMaxLength(500)
                .HasColumnName("profileNotes");
            entity.Property(e => e.Proid).HasColumnName("proid");
            entity.Property(e => e.Pstatus)
                .HasMaxLength(20)
                .HasColumnName("pstatus");
            entity.Property(e => e.Qareport)
                .HasMaxLength(2000)
                .HasColumnName("QAReport");
            entity.Property(e => e.SpLocation)
                .HasMaxLength(35)
                .HasColumnName("spLocation");
            entity.Property(e => e.TickPackRequired)
                .HasMaxLength(25)
                .HasColumnName("tick_packRequired");
            entity.Property(e => e.Updateby).HasColumnName("updateby");
        });

        modelBuilder.Entity<VCaUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_caUser");

            entity.Property(e => e.AccessStatus)
                .HasMaxLength(10)
                .HasColumnName("accessStatus");
            entity.Property(e => e.Accesslevel).HasColumnName("accesslevel");
            entity.Property(e => e.Accesstagid).HasColumnName("accesstagid");
            entity.Property(e => e.Caninvoice).HasColumnName("caninvoice");
            entity.Property(e => e.CapAdultVolavalable).HasColumnName("CapAdultVOLAvalable");
            entity.Property(e => e.CapAdultVolcode)
                .HasMaxLength(50)
                .HasColumnName("CapAdultVOLCode");
            entity.Property(e => e.CapAdultVolredempted).HasColumnName("CapAdultVOLRedempted");
            entity.Property(e => e.Catalogueid).HasColumnName("catalogueid");
            entity.Property(e => e.CblteardropBannerAvalable).HasColumnName("CBLTeardropBannerAvalable");
            entity.Property(e => e.CblteardropBannerCode)
                .HasMaxLength(50)
                .HasColumnName("CBLTeardropBannerCode");
            entity.Property(e => e.CblteardropBannerRedempted).HasColumnName("CBLTeardropBannerRedempted");
            entity.Property(e => e.CentreTypeDescription)
                .HasMaxLength(50)
                .HasColumnName("centreTypeDescription");
            entity.Property(e => e.CertificateBlastCode).HasMaxLength(50);
            entity.Property(e => e.ClientId).HasColumnName("clientID");
            entity.Property(e => e.Con1Code).HasMaxLength(50);
            entity.Property(e => e.Con3Code).HasMaxLength(50);
            entity.Property(e => e.Con4Code).HasMaxLength(50);
            entity.Property(e => e.Cone2).HasColumnName("cone2");
            entity.Property(e => e.Cone2Code).HasMaxLength(50);
            entity.Property(e => e.Cone3).HasColumnName("cone3");
            entity.Property(e => e.Cone4).HasColumnName("cone4");
            entity.Property(e => e.CoorPackTeam)
                .HasMaxLength(10)
                .HasColumnName("coorPackTeam");
            entity.Property(e => e.CoordPackAvailable).HasColumnName("coordPackAvailable");
            entity.Property(e => e.CoordPackCode)
                .HasMaxLength(50)
                .HasColumnName("coordPackCode");
            entity.Property(e => e.CoordPackRedempted).HasColumnName("coordPackRedempted");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .HasColumnName("createby");
            entity.Property(e => e.Encryptedpw)
                .HasMaxLength(40)
                .HasColumnName("encryptedpw");
            entity.Property(e => e.EntityId)
                .HasMaxLength(50)
                .HasColumnName("entityID");
            entity.Property(e => e.EntityName)
                .HasMaxLength(200)
                .HasColumnName("entityName");
            entity.Property(e => e.EntityPostcode)
                .HasMaxLength(10)
                .HasColumnName("entityPostcode");
            entity.Property(e => e.EntityState).HasMaxLength(50);
            entity.Property(e => e.EntityType)
                .HasMaxLength(50)
                .HasColumnName("entityType");
            entity.Property(e => e.Expr3).HasMaxLength(150);
            entity.Property(e => e.Expr4).HasColumnType("datetime");
            entity.Property(e => e.Expr5).HasMaxLength(10);
            entity.Property(e => e.Extrainfo).HasColumnName("extrainfo");
            entity.Property(e => e.Field1)
                .HasMaxLength(100)
                .HasColumnName("field1");
            entity.Property(e => e.Field2)
                .HasMaxLength(100)
                .HasColumnName("field2");
            entity.Property(e => e.Field3)
                .HasMaxLength(100)
                .HasColumnName("field3");
            entity.Property(e => e.Field4)
                .HasMaxLength(100)
                .HasColumnName("field4");
            entity.Property(e => e.Hashfunction)
                .HasMaxLength(10)
                .HasColumnName("hashfunction");
            entity.Property(e => e.Jcredit).HasColumnName("JCredit");
            entity.Property(e => e.JuniorBcoordinatorEmail)
                .HasMaxLength(100)
                .HasColumnName("juniorBCoordinatorEmail");
            entity.Property(e => e.JuniorBcoordinatorName)
                .HasMaxLength(100)
                .HasColumnName("juniorBCoordinatorName");
            entity.Property(e => e.JuniorBcoordinatorPhone)
                .HasMaxLength(20)
                .HasColumnName("juniorBCoordinatorPhone");
            entity.Property(e => e.JuniorBdeliveryAddress1)
                .HasMaxLength(200)
                .HasColumnName("juniorBDeliveryAddress1");
            entity.Property(e => e.JuniorBdeliveryAddress2)
                .HasMaxLength(200)
                .HasColumnName("juniorBDeliveryAddress2");
            entity.Property(e => e.JuniorBdeliveryPostcode)
                .HasMaxLength(10)
                .HasColumnName("juniorBDeliveryPostcode");
            entity.Property(e => e.JuniorBdeliveryState)
                .HasMaxLength(50)
                .HasColumnName("juniorBDeliveryState");
            entity.Property(e => e.JuniorBdeliverySuburb)
                .HasMaxLength(100)
                .HasColumnName("juniorBDeliverySuburb");
            entity.Property(e => e.JuniorBprogramOneStartDate)
                .HasMaxLength(50)
                .HasColumnName("juniorBProgramOneStartDate");
            entity.Property(e => e.JuniorBprogramTwoStartDate)
                .HasMaxLength(50)
                .HasColumnName("juniorBProgramTwoStartDate");
            entity.Property(e => e.JuniorMainAvalaible).HasColumnName("juniorMainAvalaible");
            entity.Property(e => e.JuniorMainCode)
                .HasMaxLength(50)
                .HasColumnName("juniorMainCode");
            entity.Property(e => e.JuniorMainRedempted).HasColumnName("juniorMainRedempted");
            entity.Property(e => e.JuniorTopUpAvailable).HasColumnName("juniorTopUpAvailable");
            entity.Property(e => e.JuniorTopUpRedempted).HasColumnName("juniorTopUpRedempted");
            entity.Property(e => e.JuniorTopupCode)
                .HasMaxLength(50)
                .HasColumnName("juniorTopupCode");
            entity.Property(e => e.Lastupdate)
                .HasColumnType("datetime")
                .HasColumnName("lastupdate");
            entity.Property(e => e.Master2Gavailable).HasColumnName("Master2GAvailable");
            entity.Property(e => e.Master2Gcode)
                .HasMaxLength(50)
                .HasColumnName("Master2GCode");
            entity.Property(e => e.Master2Gredempted).HasColumnName("Master2GRedempted");
            entity.Property(e => e.Master4Gavailable).HasColumnName("Master4GAvailable");
            entity.Property(e => e.Master4Gcode)
                .HasMaxLength(50)
                .HasColumnName("Master4GCode");
            entity.Property(e => e.Master4Gredempted).HasColumnName("Master4GRedempted");
            entity.Property(e => e.MasterBcoordinatorEmail)
                .HasMaxLength(100)
                .HasColumnName("masterBCoordinatorEmail");
            entity.Property(e => e.MasterBcoordinatorName)
                .HasMaxLength(200)
                .HasColumnName("masterBCoordinatorName");
            entity.Property(e => e.MasterBcoordinatorPhone)
                .HasMaxLength(20)
                .HasColumnName("masterBCoordinatorPhone");
            entity.Property(e => e.MasterBdeliveryAddress1)
                .HasMaxLength(200)
                .HasColumnName("masterBDeliveryAddress1");
            entity.Property(e => e.MasterBdeliveryAddress2)
                .HasMaxLength(200)
                .HasColumnName("masterBDeliveryAddress2");
            entity.Property(e => e.MasterBdeliveryPostcode)
                .HasMaxLength(10)
                .HasColumnName("masterBDeliveryPostcode");
            entity.Property(e => e.MasterBdeliveryState)
                .HasMaxLength(50)
                .HasColumnName("masterBDeliveryState");
            entity.Property(e => e.MasterBdeliverySuburb)
                .HasMaxLength(100)
                .HasColumnName("masterBDeliverySuburb");
            entity.Property(e => e.MasterBprogramStartDate)
                .HasMaxLength(50)
                .HasColumnName("masterBProgramStartDate");
            entity.Property(e => e.Mcredit).HasColumnName("MCredit");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .HasColumnName("notes");
            entity.Property(e => e.Oktospam)
                .HasMaxLength(4)
                .HasColumnName("oktospam");
            entity.Property(e => e.OldAccId).HasColumnName("oldAccId");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.PriceProfileId).HasColumnName("priceProfileID");
            entity.Property(e => e.Psentence)
                .HasMaxLength(150)
                .HasColumnName("psentence");
            entity.Property(e => e.SchoolIncentiveCode)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.SchoolPackCode).HasMaxLength(50);
            entity.Property(e => e.SchoolSportCode)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Seed)
                .HasMaxLength(2)
                .HasColumnName("seed");
            entity.Property(e => e.State).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.Token).HasColumnName("token");
            entity.Property(e => e.Tokendate)
                .HasColumnType("datetime")
                .HasColumnName("tokendate");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Updateby).HasColumnName("updateby");
            entity.Property(e => e.UseEncryption).HasColumnName("use_encryption");
            entity.Property(e => e.Username)
                .HasMaxLength(150)
                .HasColumnName("username");
            entity.Property(e => e.VolPackAvailable).HasColumnName("volPackAvailable");
            entity.Property(e => e.VolPackRedempted).HasColumnName("volPackRedempted");
            entity.Property(e => e.WebAccId).HasColumnName("webAccID");
            entity.Property(e => e.WebRoleId).HasColumnName("WebRoleID");
        });

        modelBuilder.Entity<VCaWebAccount>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_CA_WebAccount");

            entity.Property(e => e.AccessStatus)
                .HasMaxLength(10)
                .HasColumnName("accessStatus");
            entity.Property(e => e.BillingAddress)
                .HasMaxLength(100)
                .HasColumnName("Billing_Address");
            entity.Property(e => e.BillingAddress2)
                .HasMaxLength(100)
                .HasColumnName("Billing_Address2");
            entity.Property(e => e.BillingCountry)
                .HasMaxLength(50)
                .HasColumnName("Billing_Country");
            entity.Property(e => e.BillingFirstname)
                .HasMaxLength(50)
                .HasColumnName("Billing_Firstname");
            entity.Property(e => e.BillingLastname)
                .HasMaxLength(50)
                .HasColumnName("Billing_Lastname");
            entity.Property(e => e.BillingPostcode)
                .HasMaxLength(12)
                .HasColumnName("Billing_Postcode");
            entity.Property(e => e.BillingState)
                .HasMaxLength(80)
                .HasColumnName("Billing_State");
            entity.Property(e => e.BillingSuburb)
                .HasMaxLength(80)
                .HasColumnName("Billing_Suburb");
            entity.Property(e => e.Catalogueid).HasColumnName("catalogueid");
            entity.Property(e => e.ClientId).HasColumnName("clientID");
            entity.Property(e => e.ContactAddress)
                .HasMaxLength(100)
                .HasColumnName("Contact_Address");
            entity.Property(e => e.ContactAddress2)
                .HasMaxLength(100)
                .HasColumnName("Contact_Address2");
            entity.Property(e => e.ContactCountry)
                .HasMaxLength(50)
                .HasColumnName("Contact_Country");
            entity.Property(e => e.ContactEmail)
                .HasMaxLength(80)
                .HasColumnName("Contact_Email");
            entity.Property(e => e.ContactFirstname)
                .HasMaxLength(50)
                .HasColumnName("Contact_Firstname");
            entity.Property(e => e.ContactLastname)
                .HasMaxLength(50)
                .HasColumnName("Contact_Lastname");
            entity.Property(e => e.ContactPhone)
                .HasMaxLength(50)
                .HasColumnName("Contact_Phone");
            entity.Property(e => e.ContactPostcode)
                .HasMaxLength(12)
                .HasColumnName("Contact_Postcode");
            entity.Property(e => e.ContactState)
                .HasMaxLength(80)
                .HasColumnName("Contact_State");
            entity.Property(e => e.ContactSuburb)
                .HasMaxLength(80)
                .HasColumnName("Contact_Suburb");
            entity.Property(e => e.CreateByName).HasMaxLength(101);
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .HasColumnName("createby");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.DeliveryAddress)
                .HasMaxLength(100)
                .HasColumnName("Delivery_Address");
            entity.Property(e => e.DeliveryAddress2)
                .HasMaxLength(100)
                .HasColumnName("Delivery_Address2");
            entity.Property(e => e.DeliveryCountry)
                .HasMaxLength(50)
                .HasColumnName("Delivery_Country");
            entity.Property(e => e.DeliveryFirstname)
                .HasMaxLength(50)
                .HasColumnName("Delivery_Firstname");
            entity.Property(e => e.DeliveryLastname)
                .HasMaxLength(50)
                .HasColumnName("Delivery_Lastname");
            entity.Property(e => e.DeliveryPostcode)
                .HasMaxLength(12)
                .HasColumnName("Delivery_Postcode");
            entity.Property(e => e.DeliveryState)
                .HasMaxLength(80)
                .HasColumnName("Delivery_State");
            entity.Property(e => e.DeliverySuburb)
                .HasMaxLength(80)
                .HasColumnName("Delivery_Suburb");
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.RoleDescription).HasMaxLength(500);
            entity.Property(e => e.RoleName).HasMaxLength(150);
            entity.Property(e => e.Status).HasMaxLength(10);
            entity.Property(e => e.UpdateByName).HasMaxLength(101);
            entity.Property(e => e.Updateby).HasColumnName("updateby");
            entity.Property(e => e.Username)
                .HasMaxLength(150)
                .HasColumnName("username");
            entity.Property(e => e.WebAccId).HasColumnName("webAccID");
        });

        modelBuilder.Entity<VCablastCentreDayPerStateStateSchool>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_CABlastCentre_DayPerState_StateSchool");

            entity.Property(e => e.Cadayid).HasColumnName("CADAYId");
            entity.Property(e => e.Castateid).HasColumnName("CASTATEID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.EndDay).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.StartDay).HasColumnType("datetime");
            entity.Property(e => e.State).HasMaxLength(50);
            entity.Property(e => e.StateSchoolName).HasMaxLength(100);
            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<VCafindUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_CAFindUser");

            entity.Property(e => e.AccessStatus)
                .HasMaxLength(10)
                .HasColumnName("accessStatus");
            entity.Property(e => e.Accesslevel).HasColumnName("accesslevel");
            entity.Property(e => e.Accesstagid).HasColumnName("accesstagid");
            entity.Property(e => e.Caninvoice).HasColumnName("caninvoice");
            entity.Property(e => e.CapAdultVolavalable).HasColumnName("CapAdultVOLAvalable");
            entity.Property(e => e.CapAdultVolcode)
                .HasMaxLength(50)
                .HasColumnName("CapAdultVOLCode");
            entity.Property(e => e.CapAdultVolredempted).HasColumnName("CapAdultVOLRedempted");
            entity.Property(e => e.Catalogueid).HasColumnName("catalogueid");
            entity.Property(e => e.CblteardropBannerAvalable).HasColumnName("CBLTeardropBannerAvalable");
            entity.Property(e => e.CblteardropBannerCode)
                .HasMaxLength(50)
                .HasColumnName("CBLTeardropBannerCode");
            entity.Property(e => e.CblteardropBannerRedempted).HasColumnName("CBLTeardropBannerRedempted");
            entity.Property(e => e.CentreTypeDescription)
                .HasMaxLength(50)
                .HasColumnName("centreTypeDescription");
            entity.Property(e => e.CertificateBlastCode).HasMaxLength(50);
            entity.Property(e => e.ClientId).HasColumnName("clientID");
            entity.Property(e => e.Con1Code).HasMaxLength(50);
            entity.Property(e => e.Con3Code).HasMaxLength(50);
            entity.Property(e => e.Con4Code).HasMaxLength(50);
            entity.Property(e => e.Cone2).HasColumnName("cone2");
            entity.Property(e => e.Cone2Code).HasMaxLength(50);
            entity.Property(e => e.Cone3).HasColumnName("cone3");
            entity.Property(e => e.Cone4).HasColumnName("cone4");
            entity.Property(e => e.CoorPackTeam)
                .HasMaxLength(10)
                .HasColumnName("coorPackTeam");
            entity.Property(e => e.CoordPackAvailable).HasColumnName("coordPackAvailable");
            entity.Property(e => e.CoordPackCode)
                .HasMaxLength(50)
                .HasColumnName("coordPackCode");
            entity.Property(e => e.CoordPackRedempted).HasColumnName("coordPackRedempted");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .HasColumnName("createby");
            entity.Property(e => e.Encryptedpw)
                .HasMaxLength(40)
                .HasColumnName("encryptedpw");
            entity.Property(e => e.EntityId)
                .HasMaxLength(50)
                .HasColumnName("entityID");
            entity.Property(e => e.EntityName)
                .HasMaxLength(200)
                .HasColumnName("entityName");
            entity.Property(e => e.EntityPostcode)
                .HasMaxLength(10)
                .HasColumnName("entityPostcode");
            entity.Property(e => e.EntityState).HasMaxLength(50);
            entity.Property(e => e.EntityType)
                .HasMaxLength(50)
                .HasColumnName("entityType");
            entity.Property(e => e.Expr1).HasMaxLength(50);
            entity.Property(e => e.Expr3).HasMaxLength(150);
            entity.Property(e => e.Expr4).HasMaxLength(50);
            entity.Property(e => e.Expr5).HasColumnType("datetime");
            entity.Property(e => e.Expr6).HasMaxLength(10);
            entity.Property(e => e.Extrainfo).HasColumnName("extrainfo");
            entity.Property(e => e.Field1)
                .HasMaxLength(100)
                .HasColumnName("field1");
            entity.Property(e => e.Field2)
                .HasMaxLength(100)
                .HasColumnName("field2");
            entity.Property(e => e.Field3)
                .HasMaxLength(100)
                .HasColumnName("field3");
            entity.Property(e => e.Field4)
                .HasMaxLength(100)
                .HasColumnName("field4");
            entity.Property(e => e.Hashfunction)
                .HasMaxLength(10)
                .HasColumnName("hashfunction");
            entity.Property(e => e.Jcredit).HasColumnName("JCredit");
            entity.Property(e => e.JuniorBcoordinatorEmail)
                .HasMaxLength(100)
                .HasColumnName("juniorBCoordinatorEmail");
            entity.Property(e => e.JuniorBcoordinatorName)
                .HasMaxLength(100)
                .HasColumnName("juniorBCoordinatorName");
            entity.Property(e => e.JuniorBcoordinatorPhone)
                .HasMaxLength(20)
                .HasColumnName("juniorBCoordinatorPhone");
            entity.Property(e => e.JuniorBdeliveryAddress1)
                .HasMaxLength(200)
                .HasColumnName("juniorBDeliveryAddress1");
            entity.Property(e => e.JuniorBdeliveryAddress2)
                .HasMaxLength(200)
                .HasColumnName("juniorBDeliveryAddress2");
            entity.Property(e => e.JuniorBdeliveryPostcode)
                .HasMaxLength(10)
                .HasColumnName("juniorBDeliveryPostcode");
            entity.Property(e => e.JuniorBdeliveryState)
                .HasMaxLength(50)
                .HasColumnName("juniorBDeliveryState");
            entity.Property(e => e.JuniorBdeliverySuburb)
                .HasMaxLength(100)
                .HasColumnName("juniorBDeliverySuburb");
            entity.Property(e => e.JuniorBprogramOneStartDate)
                .HasMaxLength(50)
                .HasColumnName("juniorBProgramOneStartDate");
            entity.Property(e => e.JuniorBprogramTwoStartDate)
                .HasMaxLength(50)
                .HasColumnName("juniorBProgramTwoStartDate");
            entity.Property(e => e.JuniorMainAvalaible).HasColumnName("juniorMainAvalaible");
            entity.Property(e => e.JuniorMainCode)
                .HasMaxLength(50)
                .HasColumnName("juniorMainCode");
            entity.Property(e => e.JuniorMainRedempted).HasColumnName("juniorMainRedempted");
            entity.Property(e => e.JuniorTopUpAvailable).HasColumnName("juniorTopUpAvailable");
            entity.Property(e => e.JuniorTopUpRedempted).HasColumnName("juniorTopUpRedempted");
            entity.Property(e => e.JuniorTopupCode)
                .HasMaxLength(50)
                .HasColumnName("juniorTopupCode");
            entity.Property(e => e.Lastupdate)
                .HasColumnType("datetime")
                .HasColumnName("lastupdate");
            entity.Property(e => e.Master2Gavailable).HasColumnName("Master2GAvailable");
            entity.Property(e => e.Master2Gcode)
                .HasMaxLength(50)
                .HasColumnName("Master2GCode");
            entity.Property(e => e.Master2Gredempted).HasColumnName("Master2GRedempted");
            entity.Property(e => e.Master4Gavailable).HasColumnName("Master4GAvailable");
            entity.Property(e => e.Master4Gcode)
                .HasMaxLength(50)
                .HasColumnName("Master4GCode");
            entity.Property(e => e.Master4Gredempted).HasColumnName("Master4GRedempted");
            entity.Property(e => e.MasterBcoordinatorEmail)
                .HasMaxLength(100)
                .HasColumnName("masterBCoordinatorEmail");
            entity.Property(e => e.MasterBcoordinatorName)
                .HasMaxLength(200)
                .HasColumnName("masterBCoordinatorName");
            entity.Property(e => e.MasterBcoordinatorPhone)
                .HasMaxLength(20)
                .HasColumnName("masterBCoordinatorPhone");
            entity.Property(e => e.MasterBdeliveryAddress1)
                .HasMaxLength(200)
                .HasColumnName("masterBDeliveryAddress1");
            entity.Property(e => e.MasterBdeliveryAddress2)
                .HasMaxLength(200)
                .HasColumnName("masterBDeliveryAddress2");
            entity.Property(e => e.MasterBdeliveryPostcode)
                .HasMaxLength(10)
                .HasColumnName("masterBDeliveryPostcode");
            entity.Property(e => e.MasterBdeliveryState)
                .HasMaxLength(50)
                .HasColumnName("masterBDeliveryState");
            entity.Property(e => e.MasterBdeliverySuburb)
                .HasMaxLength(100)
                .HasColumnName("masterBDeliverySuburb");
            entity.Property(e => e.MasterBprogramStartDate)
                .HasMaxLength(50)
                .HasColumnName("masterBProgramStartDate");
            entity.Property(e => e.Mcredit).HasColumnName("MCredit");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .HasColumnName("notes");
            entity.Property(e => e.Oktospam)
                .HasMaxLength(4)
                .HasColumnName("oktospam");
            entity.Property(e => e.OldAccId).HasColumnName("oldAccId");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.PriceProfileId).HasColumnName("priceProfileID");
            entity.Property(e => e.Psentence)
                .HasMaxLength(150)
                .HasColumnName("psentence");
            entity.Property(e => e.SchoolIncentiveCode)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.SchoolPackCode).HasMaxLength(50);
            entity.Property(e => e.SchoolSportCode)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Seed)
                .HasMaxLength(2)
                .HasColumnName("seed");
            entity.Property(e => e.State).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.Token).HasColumnName("token");
            entity.Property(e => e.Tokendate)
                .HasColumnType("datetime")
                .HasColumnName("tokendate");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Updateby).HasColumnName("updateby");
            entity.Property(e => e.UseEncryption).HasColumnName("use_encryption");
            entity.Property(e => e.Username)
                .HasMaxLength(150)
                .HasColumnName("username");
            entity.Property(e => e.VolPackAvailable).HasColumnName("volPackAvailable");
            entity.Property(e => e.VolPackRedempted).HasColumnName("volPackRedempted");
            entity.Property(e => e.WebAccId).HasColumnName("webAccID");
            entity.Property(e => e.WebRoleId).HasColumnName("WebRoleID");
        });

        modelBuilder.Entity<VCagetbblnew>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_cagetbblnew");

            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.PostCode).HasMaxLength(10);
            entity.Property(e => e.State).HasMaxLength(10);
        });

        modelBuilder.Entity<VCagetcredit>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_cagetcredit");

            entity.Property(e => e.TotalCredit)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("totalCredit");
        });

        modelBuilder.Entity<VCagetprofileproduct>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_cagetprofileproduct");

            entity.Property(e => e.Catalogueid).HasColumnName("catalogueid");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Currency)
                .HasMaxLength(10)
                .HasColumnName("currency");
            entity.Property(e => e.Currentprice).HasColumnName("currentprice");
            entity.Property(e => e.Expr2).HasMaxLength(20);
            entity.Property(e => e.Expr3).HasMaxLength(20);
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Isdefault).HasColumnName("isdefault");
            entity.Property(e => e.Lastmodified).HasColumnName("lastmodified");
            entity.Property(e => e.Legacyfield)
                .HasMaxLength(20)
                .HasColumnName("legacyfield");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Notes)
                .HasColumnType("ntext")
                .HasColumnName("notes");
            entity.Property(e => e.Profileid).HasColumnName("profileid");
            entity.Property(e => e.Proid).HasColumnName("proid");
            entity.Property(e => e.RebatePercentage)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("rebate_percentage");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("status");
            entity.Property(e => e.Taxexclusive).HasColumnName("taxexclusive");
            entity.Property(e => e.Taxrate).HasColumnName("taxrate");
            entity.Property(e => e.Wasprice).HasColumnName("wasprice");
        });

        modelBuilder.Entity<VCagetpropackdynamic>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_cagetpropackdynamic");

            entity.Property(e => e.ClubCode).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.IdCaBbl).HasColumnName("IdCaBBL");
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.NameType).HasMaxLength(200);
            entity.Property(e => e.ProId).HasColumnName("ProID");
        });

        modelBuilder.Entity<VCahistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_cahistory");

            entity.Property(e => e.AccessStatus)
                .HasMaxLength(10)
                .HasColumnName("accessStatus");
            entity.Property(e => e.BAddr1)
                .HasMaxLength(500)
                .HasColumnName("b_addr1");
            entity.Property(e => e.BAddr2)
                .HasMaxLength(500)
                .HasColumnName("b_addr2");
            entity.Property(e => e.BAddr3)
                .HasMaxLength(500)
                .HasColumnName("b_addr3");
            entity.Property(e => e.BCountry)
                .HasMaxLength(100)
                .HasColumnName("b_country");
            entity.Property(e => e.BPostcode)
                .HasMaxLength(10)
                .HasColumnName("b_postcode");
            entity.Property(e => e.BillingAddress)
                .HasMaxLength(100)
                .HasColumnName("Billing_Address");
            entity.Property(e => e.BillingAddress2)
                .HasMaxLength(100)
                .HasColumnName("Billing_Address2");
            entity.Property(e => e.BillingCountry)
                .HasMaxLength(50)
                .HasColumnName("Billing_Country");
            entity.Property(e => e.BillingFirstname)
                .HasMaxLength(50)
                .HasColumnName("Billing_Firstname");
            entity.Property(e => e.BillingFullName)
                .HasMaxLength(100)
                .HasColumnName("Billing_FullName");
            entity.Property(e => e.BillingLastname)
                .HasMaxLength(50)
                .HasColumnName("Billing_Lastname");
            entity.Property(e => e.BillingPostcode)
                .HasMaxLength(12)
                .HasColumnName("Billing_Postcode");
            entity.Property(e => e.BillingState)
                .HasMaxLength(80)
                .HasColumnName("Billing_State");
            entity.Property(e => e.BillingSuburb)
                .HasMaxLength(80)
                .HasColumnName("Billing_Suburb");
            entity.Property(e => e.CarrierName)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.CarrierUrl)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Catalogueid).HasColumnName("catalogueid");
            entity.Property(e => e.ClientId).HasColumnName("clientID");
            entity.Property(e => e.ContactAddress)
                .HasMaxLength(100)
                .HasColumnName("Contact_Address");
            entity.Property(e => e.ContactAddress2)
                .HasMaxLength(100)
                .HasColumnName("Contact_Address2");
            entity.Property(e => e.ContactCountry)
                .HasMaxLength(50)
                .HasColumnName("Contact_Country");
            entity.Property(e => e.ContactEmail)
                .HasMaxLength(80)
                .HasColumnName("Contact_Email");
            entity.Property(e => e.ContactFirstname)
                .HasMaxLength(50)
                .HasColumnName("Contact_Firstname");
            entity.Property(e => e.ContactLastname)
                .HasMaxLength(50)
                .HasColumnName("Contact_Lastname");
            entity.Property(e => e.ContactPhone)
                .HasMaxLength(50)
                .HasColumnName("Contact_Phone");
            entity.Property(e => e.ContactPostcode)
                .HasMaxLength(12)
                .HasColumnName("Contact_Postcode");
            entity.Property(e => e.ContactState)
                .HasMaxLength(80)
                .HasColumnName("Contact_State");
            entity.Property(e => e.ContactSuburb)
                .HasMaxLength(80)
                .HasColumnName("Contact_Suburb");
            entity.Property(e => e.CreateByName).HasMaxLength(101);
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .HasColumnName("createby");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.DAddr1)
                .HasMaxLength(500)
                .HasColumnName("d_addr1");
            entity.Property(e => e.DAddr2)
                .HasMaxLength(500)
                .HasColumnName("d_addr2");
            entity.Property(e => e.DAddr3)
                .HasMaxLength(500)
                .HasColumnName("d_addr3");
            entity.Property(e => e.DCountry)
                .HasMaxLength(500)
                .HasColumnName("d_country");
            entity.Property(e => e.DPostcode)
                .HasMaxLength(500)
                .HasColumnName("d_postcode");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DelStatus)
                .HasMaxLength(20)
                .HasColumnName("del_status");
            entity.Property(e => e.DeliveryAddress)
                .HasMaxLength(100)
                .HasColumnName("Delivery_Address");
            entity.Property(e => e.DeliveryAddress2)
                .HasMaxLength(100)
                .HasColumnName("Delivery_Address2");
            entity.Property(e => e.DeliveryCountry)
                .HasMaxLength(50)
                .HasColumnName("Delivery_Country");
            entity.Property(e => e.DeliveryFirstname)
                .HasMaxLength(50)
                .HasColumnName("Delivery_Firstname");
            entity.Property(e => e.DeliveryFullName)
                .HasMaxLength(100)
                .HasColumnName("Delivery_FullName");
            entity.Property(e => e.DeliveryLastname)
                .HasMaxLength(50)
                .HasColumnName("Delivery_Lastname");
            entity.Property(e => e.DeliveryPostcode)
                .HasMaxLength(12)
                .HasColumnName("Delivery_Postcode");
            entity.Property(e => e.DeliveryState)
                .HasMaxLength(80)
                .HasColumnName("Delivery_State");
            entity.Property(e => e.DeliverySuburb)
                .HasMaxLength(80)
                .HasColumnName("Delivery_Suburb");
            entity.Property(e => e.Email)
                .HasMaxLength(80)
                .HasColumnName("email");
            entity.Property(e => e.Expr3).HasMaxLength(150);
            entity.Property(e => e.Expr5).HasMaxLength(20);
            entity.Property(e => e.Expr6).HasMaxLength(80);
            entity.Property(e => e.Fname)
                .HasMaxLength(50)
                .HasColumnName("fname");
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Lastmodified)
                .HasColumnType("datetime")
                .HasColumnName("lastmodified");
            entity.Property(e => e.Lname)
                .HasMaxLength(50)
                .HasColumnName("lname");
            entity.Property(e => e.Ordernumber).HasColumnName("ordernumber");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.PaymentMethod).HasMaxLength(50);
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .HasColumnName("phone");
            entity.Property(e => e.RoleDescription).HasMaxLength(500);
            entity.Property(e => e.RoleName).HasMaxLength(150);
            entity.Property(e => e.Status).HasMaxLength(10);
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.TpforderId).HasColumnName("TPFOrderID");
            entity.Property(e => e.TrackingNo)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UpdateByName).HasMaxLength(101);
            entity.Property(e => e.Updateby).HasColumnName("updateby");
            entity.Property(e => e.Username)
                .HasMaxLength(150)
                .HasColumnName("username");
            entity.Property(e => e.WebAccId).HasColumnName("webAccID");
        });

        modelBuilder.Entity<VCaproductsize>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_caproductsize");

            entity.Property(e => e.Expr1).HasMaxLength(15);
            entity.Property(e => e.Internalcode)
                .HasMaxLength(50)
                .HasColumnName("internalcode");
            entity.Property(e => e.ProId).HasColumnName("proID");
            entity.Property(e => e.ProdetailId).HasColumnName("prodetailID");
            entity.Property(e => e.Prodetailcode)
                .HasMaxLength(30)
                .HasColumnName("prodetailcode");
            entity.Property(e => e.Prodetailsize)
                .HasMaxLength(15)
                .HasColumnName("prodetailsize");
        });

        modelBuilder.Entity<VCashowbbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_cashowbbl");

            entity.Property(e => e.ClubCode).HasMaxLength(50);
            entity.Property(e => e.IdBbLclub).HasColumnName("IdBbLClub");
            entity.Property(e => e.IdPack).HasColumnName("idPack");
            entity.Property(e => e.IsDisplay).HasColumnName("isDisplay");
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<VGetcavredit>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_getcavredit");

            entity.Property(e => e.TotalCredit)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("totalCredit");
        });

        modelBuilder.Entity<VGetclubDynamic>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_getclubDynamic");

            entity.Property(e => e.ClubCode).HasMaxLength(50);
            entity.Property(e => e.IdCaBbl).HasColumnName("IdCaBBL");
            entity.Property(e => e.Idbblclub).HasColumnName("idbblclub");
            entity.Property(e => e.IdproductType).HasColumnName("idproductType");
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.NameType).HasMaxLength(200);
        });

        modelBuilder.Entity<VSwiWebAccount>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_SWI_WebAccount");

            entity.Property(e => e.AccessStatus)
                .HasMaxLength(10)
                .HasColumnName("accessStatus");
            entity.Property(e => e.BillingAddress)
                .HasMaxLength(100)
                .HasColumnName("Billing_Address");
            entity.Property(e => e.BillingAddress2)
                .HasMaxLength(100)
                .HasColumnName("Billing_Address2");
            entity.Property(e => e.BillingCountry)
                .HasMaxLength(50)
                .HasColumnName("Billing_Country");
            entity.Property(e => e.BillingFirstname)
                .HasMaxLength(50)
                .HasColumnName("Billing_Firstname");
            entity.Property(e => e.BillingLastname)
                .HasMaxLength(50)
                .HasColumnName("Billing_Lastname");
            entity.Property(e => e.BillingPostcode)
                .HasMaxLength(12)
                .HasColumnName("Billing_Postcode");
            entity.Property(e => e.BillingState)
                .HasMaxLength(80)
                .HasColumnName("Billing_State");
            entity.Property(e => e.BillingSuburb)
                .HasMaxLength(80)
                .HasColumnName("Billing_Suburb");
            entity.Property(e => e.Catalogueid).HasColumnName("catalogueid");
            entity.Property(e => e.ClientId).HasColumnName("clientID");
            entity.Property(e => e.ContactAddress)
                .HasMaxLength(100)
                .HasColumnName("Contact_Address");
            entity.Property(e => e.ContactAddress2)
                .HasMaxLength(100)
                .HasColumnName("Contact_Address2");
            entity.Property(e => e.ContactCountry)
                .HasMaxLength(50)
                .HasColumnName("Contact_Country");
            entity.Property(e => e.ContactEmail)
                .HasMaxLength(80)
                .HasColumnName("Contact_Email");
            entity.Property(e => e.ContactFirstname)
                .HasMaxLength(50)
                .HasColumnName("Contact_Firstname");
            entity.Property(e => e.ContactLastname)
                .HasMaxLength(50)
                .HasColumnName("Contact_Lastname");
            entity.Property(e => e.ContactPhone)
                .HasMaxLength(50)
                .HasColumnName("Contact_Phone");
            entity.Property(e => e.ContactPostcode)
                .HasMaxLength(12)
                .HasColumnName("Contact_Postcode");
            entity.Property(e => e.ContactState)
                .HasMaxLength(80)
                .HasColumnName("Contact_State");
            entity.Property(e => e.ContactSuburb)
                .HasMaxLength(80)
                .HasColumnName("Contact_Suburb");
            entity.Property(e => e.CreateByName).HasMaxLength(101);
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .HasColumnName("createby");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.DeliveryAddress)
                .HasMaxLength(100)
                .HasColumnName("Delivery_Address");
            entity.Property(e => e.DeliveryAddress2)
                .HasMaxLength(100)
                .HasColumnName("Delivery_Address2");
            entity.Property(e => e.DeliveryCountry)
                .HasMaxLength(50)
                .HasColumnName("Delivery_Country");
            entity.Property(e => e.DeliveryFirstname)
                .HasMaxLength(50)
                .HasColumnName("Delivery_Firstname");
            entity.Property(e => e.DeliveryLastname)
                .HasMaxLength(50)
                .HasColumnName("Delivery_Lastname");
            entity.Property(e => e.DeliveryPostcode)
                .HasMaxLength(12)
                .HasColumnName("Delivery_Postcode");
            entity.Property(e => e.DeliveryState)
                .HasMaxLength(80)
                .HasColumnName("Delivery_State");
            entity.Property(e => e.DeliverySuburb)
                .HasMaxLength(80)
                .HasColumnName("Delivery_Suburb");
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.RoleDescription).HasMaxLength(500);
            entity.Property(e => e.RoleName).HasMaxLength(150);
            entity.Property(e => e.Status).HasMaxLength(10);
            entity.Property(e => e.UpdateByName).HasMaxLength(101);
            entity.Property(e => e.Updateby).HasColumnName("updateby");
            entity.Property(e => e.Username)
                .HasMaxLength(150)
                .HasColumnName("username");
            entity.Property(e => e.WebAccId).HasColumnName("webAccID");
        });

        modelBuilder.Entity<Voucher>(entity =>
        {
            entity.ToTable("vouchers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CatalogueId).HasColumnName("catalogueID");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasColumnName("code");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Creditvalue).HasColumnName("creditvalue");
            entity.Property(e => e.Currency)
                .HasMaxLength(10)
                .HasDefaultValueSql("('AUD')")
                .HasColumnName("currency");
            entity.Property(e => e.Deactivate).HasColumnName("deactivate");
            entity.Property(e => e.Expiry)
                .HasDefaultValueSql("(getdate()+(365))")
                .HasColumnType("datetime")
                .HasColumnName("expiry");
            entity.Property(e => e.MinimumSpend)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("minimumSpend");
            entity.Property(e => e.Notes)
                .HasMaxLength(250)
                .HasColumnName("notes");
            entity.Property(e => e.Orderno)
                .HasMaxLength(50)
                .HasColumnName("orderno");
            entity.Property(e => e.Originalvalue).HasColumnName("originalvalue");
            entity.Property(e => e.Prodetailid)
                .HasDefaultValueSql("((33537))")
                .HasColumnName("prodetailid");
            entity.Property(e => e.RequiresActivation)
                .HasDefaultValueSql("((1))")
                .HasColumnName("requiresActivation");
            entity.Property(e => e.Sequence)
                .HasMaxLength(80)
                .HasColumnName("sequence");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'active')")
                .HasColumnName("status");
        });

        modelBuilder.Entity<VoucherHistory>(entity =>
        {
            entity.ToTable("VoucherHistory", tb => tb.HasTrigger("tg_recalculate_credit_for_entity"));

            entity.HasIndex(e => e.VoucherId, "voucherID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("active");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .HasColumnName("notes");
            entity.Property(e => e.ReferenceId)
                .HasComment("An order/credit/etc. number ID")
                .HasColumnName("referenceID");
            entity.Property(e => e.Referencetype)
                .HasMaxLength(50)
                .HasComment("What the referenceID refers to (order, credit, invoice etc.)")
                .HasColumnName("referencetype");
            entity.Property(e => e.Transactiondate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("transactiondate");
            entity.Property(e => e.Transactiontype)
                .HasMaxLength(20)
                .HasColumnName("transactiontype");
            entity.Property(e => e.VoucherId).HasColumnName("voucherID");
            entity.Property(e => e.Who2blame).HasColumnName("who2blame");
        });

        modelBuilder.Entity<VoucherHistory20200428>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VoucherHistory2020-04-28");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .HasColumnName("notes");
            entity.Property(e => e.ReferenceId).HasColumnName("referenceID");
            entity.Property(e => e.Referencetype)
                .HasMaxLength(50)
                .HasColumnName("referencetype");
            entity.Property(e => e.Transactiondate)
                .HasColumnType("datetime")
                .HasColumnName("transactiondate");
            entity.Property(e => e.Transactiontype)
                .HasMaxLength(20)
                .HasColumnName("transactiontype");
            entity.Property(e => e.VoucherId).HasColumnName("voucherID");
            entity.Property(e => e.Who2blame).HasColumnName("who2blame");
        });

        modelBuilder.Entity<VoucherHistoryBackAddCredit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VoucherH__3214EC27501CA8A6");

            entity.ToTable("VoucherHistoryBackAddCredit");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .HasColumnName("notes");
            entity.Property(e => e.ReferenceId).HasColumnName("referenceID");
            entity.Property(e => e.Referencetype)
                .HasMaxLength(50)
                .HasColumnName("referencetype");
            entity.Property(e => e.Transactiondate)
                .HasColumnType("datetime")
                .HasColumnName("transactiondate");
            entity.Property(e => e.Transactiontype)
                .HasMaxLength(20)
                .HasColumnName("transactiontype");
            entity.Property(e => e.VoucherId).HasColumnName("voucherID");
            entity.Property(e => e.Who2blame).HasColumnName("who2blame");
        });

        modelBuilder.Entity<VoucherHistoryTuanBak>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VoucherHistoryTuanBak");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .HasColumnName("notes");
            entity.Property(e => e.ReferenceId).HasColumnName("referenceID");
            entity.Property(e => e.Referencetype)
                .HasMaxLength(50)
                .HasColumnName("referencetype");
            entity.Property(e => e.Transactiondate)
                .HasColumnType("datetime")
                .HasColumnName("transactiondate");
            entity.Property(e => e.Transactiontype)
                .HasMaxLength(20)
                .HasColumnName("transactiontype");
            entity.Property(e => e.VoucherId).HasColumnName("voucherID");
            entity.Property(e => e.Who2blame).HasColumnName("who2blame");
        });

        modelBuilder.Entity<VouchersBackAddCredit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vouchers__3213E83F36F83756");

            entity.ToTable("vouchersBackAddCredit");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CatalogueId).HasColumnName("catalogueID");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasColumnName("code");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Creditvalue).HasColumnName("creditvalue");
            entity.Property(e => e.Currency)
                .HasMaxLength(10)
                .HasColumnName("currency");
            entity.Property(e => e.Deactivate).HasColumnName("deactivate");
            entity.Property(e => e.Expiry)
                .HasColumnType("datetime")
                .HasColumnName("expiry");
            entity.Property(e => e.MinimumSpend)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("minimumSpend");
            entity.Property(e => e.Notes)
                .HasMaxLength(250)
                .HasColumnName("notes");
            entity.Property(e => e.Orderno)
                .HasMaxLength(50)
                .HasColumnName("orderno");
            entity.Property(e => e.Originalvalue).HasColumnName("originalvalue");
            entity.Property(e => e.Prodetailid).HasColumnName("prodetailid");
            entity.Property(e => e.RequiresActivation).HasColumnName("requiresActivation");
            entity.Property(e => e.Sequence)
                .HasMaxLength(80)
                .HasColumnName("sequence");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("status");
        });

        modelBuilder.Entity<VouchersTuanBak>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("vouchersTuanBak");

            entity.Property(e => e.CatalogueId).HasColumnName("catalogueID");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasColumnName("code");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Creditvalue).HasColumnName("creditvalue");
            entity.Property(e => e.Currency)
                .HasMaxLength(10)
                .HasColumnName("currency");
            entity.Property(e => e.Deactivate).HasColumnName("deactivate");
            entity.Property(e => e.Expiry)
                .HasColumnType("datetime")
                .HasColumnName("expiry");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.MinimumSpend)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("minimumSpend");
            entity.Property(e => e.Notes)
                .HasMaxLength(250)
                .HasColumnName("notes");
            entity.Property(e => e.Orderno)
                .HasMaxLength(50)
                .HasColumnName("orderno");
            entity.Property(e => e.Originalvalue).HasColumnName("originalvalue");
            entity.Property(e => e.Prodetailid).HasColumnName("prodetailid");
            entity.Property(e => e.RequiresActivation).HasColumnName("requiresActivation");
            entity.Property(e => e.Sequence)
                .HasMaxLength(80)
                .HasColumnName("sequence");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("status");
        });

        modelBuilder.Entity<Vouchersbak20200428>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vouchers__3213E83F4AA6A9E4");

            entity.ToTable("vouchersbak2020-04-28");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CatalogueId).HasColumnName("catalogueID");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasColumnName("code");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Creditvalue).HasColumnName("creditvalue");
            entity.Property(e => e.Currency)
                .HasMaxLength(10)
                .HasColumnName("currency");
            entity.Property(e => e.Deactivate).HasColumnName("deactivate");
            entity.Property(e => e.Expiry)
                .HasColumnType("datetime")
                .HasColumnName("expiry");
            entity.Property(e => e.MinimumSpend)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("minimumSpend");
            entity.Property(e => e.Notes)
                .HasMaxLength(250)
                .HasColumnName("notes");
            entity.Property(e => e.Orderno)
                .HasMaxLength(50)
                .HasColumnName("orderno");
            entity.Property(e => e.Originalvalue).HasColumnName("originalvalue");
            entity.Property(e => e.Prodetailid).HasColumnName("prodetailid");
            entity.Property(e => e.RequiresActivation).HasColumnName("requiresActivation");
            entity.Property(e => e.Sequence)
                .HasMaxLength(80)
                .HasColumnName("sequence");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("status");
        });

        modelBuilder.Entity<Warehouse>(entity =>
        {
            entity.ToTable("Warehouse");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<XmlDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__XmlData__3214EC0703A6C400");

            entity.Property(e => e.Entityid).HasMaxLength(200);
            entity.Property(e => e.PlayerId).HasMaxLength(200);
            entity.Property(e => e.ProgrameRefId).HasMaxLength(200);
        });

        modelBuilder.Entity<ZTbCheckDataEveryday>(entity =>
        {
            entity.HasKey(e => e.Ixd);

            entity.ToTable("Z_TB_CHECK_DATA_EVERYDAY");

            entity.Property(e => e.Ixd).HasColumnName("IXD");
            entity.Property(e => e.CheckDate).HasColumnType("datetime");
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.EntityId).HasColumnName("EntityID");
            entity.Property(e => e.GigyaId)
                .HasMaxLength(200)
                .HasColumnName("GigyaID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.OrgansationId)
                .HasMaxLength(50)
                .HasColumnName("OrgansationID");
            entity.Property(e => e.SchType)
                .HasMaxLength(50)
                .HasColumnName("SCH_Type");
            entity.Property(e => e.SchlAssigned).HasColumnName("schl_Assigned");
            entity.Property(e => e.SchlRedeemed).HasColumnName("schl_Redeemed");
            entity.Property(e => e.TransId).HasColumnName("TransID");
        });

        modelBuilder.Entity<ZUpdatePlayHq220624>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Z_updatePlayHQ_220624");

            entity.Property(e => e.Id).HasColumnName("ID ");
            entity.Property(e => e.MyCricketId).HasColumnName("MyCricketID");
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.PlayHqId)
                .HasMaxLength(255)
                .HasColumnName("PlayHQ ID");
            entity.Property(e => e.PlayHqOrganisationName)
                .HasMaxLength(255)
                .HasColumnName("PlayHQ Organisation Name");
            entity.Property(e => e.Username).HasMaxLength(255);
        });

        modelBuilder.Entity<ZUpdatePlayHqid>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zUpdatePlayHQID");

            entity.Property(e => e.MyCricketId).HasColumnName("MyCricketID");
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.PlayHqId)
                .HasMaxLength(255)
                .HasColumnName("PlayHQ ID");
            entity.Property(e => e.PlayHqOrganisationName)
                .HasMaxLength(255)
                .HasColumnName("PlayHQ Organisation Name");
            entity.Property(e => e.Username).HasMaxLength(255);
        });

        modelBuilder.Entity<ZUpdateReset>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Z_UpdateReset");

            entity.Property(e => e.ApprovedDate)
                .HasMaxLength(255)
                .HasColumnName("approvedDate");
            entity.Property(e => e.BatSize)
                .HasMaxLength(255)
                .HasColumnName("batSize");
            entity.Property(e => e.Carrier)
                .HasMaxLength(255)
                .HasColumnName("carrier");
            entity.Property(e => e.Colours).HasMaxLength(255);
            entity.Property(e => e.Connote)
                .HasMaxLength(255)
                .HasColumnName("connote");
            entity.Property(e => e.DeliveryPostcode)
                .HasMaxLength(255)
                .HasColumnName("deliveryPostcode");
            entity.Property(e => e.DispatchDate)
                .HasMaxLength(255)
                .HasColumnName("dispatchDate");
            entity.Property(e => e.EntityId)
                .HasMaxLength(255)
                .HasColumnName("entityID");
            entity.Property(e => e.EntityName)
                .HasMaxLength(255)
                .HasColumnName("entityName");
            entity.Property(e => e.FirstTime)
                .HasMaxLength(255)
                .HasColumnName("firstTime");
            entity.Property(e => e.InTransitDate)
                .HasMaxLength(255)
                .HasColumnName("inTransitDate");
            entity.Property(e => e.Input).HasMaxLength(255);
            entity.Property(e => e.IsExpressDelivery)
                .HasMaxLength(255)
                .HasColumnName("isExpressDelivery");
            entity.Property(e => e.ManualReg)
                .HasMaxLength(255)
                .HasColumnName("manualReg");
            entity.Property(e => e.Packchoice)
                .HasMaxLength(255)
                .HasColumnName("packchoice");
            entity.Property(e => e.PlayerCategory)
                .HasMaxLength(255)
                .HasColumnName("playerCategory");
            entity.Property(e => e.PlayerFirstName)
                .HasMaxLength(255)
                .HasColumnName("playerFirstName");
            entity.Property(e => e.PlayerId)
                .HasMaxLength(255)
                .HasColumnName("playerID");
            entity.Property(e => e.PlayerLastName)
                .HasMaxLength(255)
                .HasColumnName("playerLastName");
            entity.Property(e => e.ProcessedDate)
                .HasMaxLength(255)
                .HasColumnName("processedDate");
            entity.Property(e => e.ProgramRefId).HasColumnName("programRefId");
            entity.Property(e => e.RegistrationDate)
                .HasMaxLength(255)
                .HasColumnName("registrationDate");
            entity.Property(e => e.RejectionNote)
                .HasMaxLength(255)
                .HasColumnName("rejectionNote");
            entity.Property(e => e.ShirtName)
                .HasMaxLength(255)
                .HasColumnName("shirtName");
            entity.Property(e => e.ShirtSize)
                .HasMaxLength(255)
                .HasColumnName("shirtSize");
            entity.Property(e => e.Size).HasMaxLength(255);
            entity.Property(e => e.Stt).HasColumnName("STT");
            entity.Property(e => e.SubmitDate)
                .HasMaxLength(255)
                .HasColumnName("submitDate");
            entity.Property(e => e.TpfUniqueId)
                .HasMaxLength(255)
                .HasColumnName("TPF_UniqueId");
            entity.Property(e => e.TpfprodId)
                .HasMaxLength(255)
                .HasColumnName("TPFProdID");
            entity.Property(e => e.TpfreceivedDate)
                .HasMaxLength(255)
                .HasColumnName("TPFReceivedDate");
        });

        modelBuilder.Entity<Zexcel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ZExcel");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Environment).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.RegType).HasMaxLength(255);
            entity.Property(e => e.ReqBatSize).HasColumnName("Req_batSize");
            entity.Property(e => e.ReqColour).HasColumnName("Req_Colour");
            entity.Property(e => e.ReqFirstTime).HasColumnName("Req_FirstTime");
            entity.Property(e => e.ReqInput).HasColumnName("Req_Input");
            entity.Property(e => e.ReqPackChoice).HasColumnName("Req_packChoice");
            entity.Property(e => e.ReqShirtSize).HasColumnName("Req_shirtSize");
            entity.Property(e => e.ReqSize).HasColumnName("Req_Size");
            entity.Property(e => e.Source).HasMaxLength(255);
            entity.Property(e => e.TpfprodId)
                .HasMaxLength(255)
                .HasColumnName("TPFProdID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Zplayerid>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Zplayerid");

            entity.Property(e => e.F5).HasMaxLength(255);
            entity.Property(e => e.F6).HasMaxLength(255);
            entity.Property(e => e.Id).HasColumnName("id ");
            entity.Property(e => e.PlayerId)
                .HasMaxLength(255)
                .HasColumnName("playerID");
            entity.Property(e => e.RegistrationDate)
                .HasColumnType("datetime")
                .HasColumnName("registrationDate");
            entity.Property(e => e.TpfreceivedDate)
                .HasColumnType("datetime")
                .HasColumnName("TPFReceivedDate");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
