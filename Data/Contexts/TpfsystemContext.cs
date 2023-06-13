using Data.Databases.Tpfsystem;

namespace Data.Contexts;

public partial class TpfsystemContext : DbContext
{
    public TpfsystemContext()
    {
    }

    public TpfsystemContext(DbContextOptions<TpfsystemContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CaLog> CaLogs { get; set; }

    public virtual DbSet<CaParticipantOrderDetail> CaParticipantOrderDetails { get; set; }

    public virtual DbSet<CaParticipantOrderDetailBackup20201113> CaParticipantOrderDetailBackup20201113s { get; set; }

    public virtual DbSet<CaParticipantOrderInfo> CaParticipantOrderInfos { get; set; }

    public virtual DbSet<CaParticipantOrderInfoBackup20201113> CaParticipantOrderInfoBackup20201113s { get; set; }

    public virtual DbSet<CaTempReportParticipant> CaTempReportParticipants { get; set; }

    public virtual DbSet<CaTrackingDetail> CaTrackingDetails { get; set; }

    public virtual DbSet<CaTrackingInfo> CaTrackingInfos { get; set; }

    public virtual DbSet<ClientBilling> ClientBillings { get; set; }

    public virtual DbSet<ClientDatum> ClientData { get; set; }

    public virtual DbSet<ClientDelDatum> ClientDelData { get; set; }

    public virtual DbSet<ClientWebAccount> ClientWebAccounts { get; set; }

    public virtual DbSet<ClientWebAccountBakUpdateProfile> ClientWebAccountBakUpdateProfiles { get; set; }

    public virtual DbSet<Invoice> Invoices { get; set; }

    public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }

    public virtual DbSet<OcDeliveryDetail> OcDeliveryDetails { get; set; }

    public virtual DbSet<OcDeliveryOrder> OcDeliveryOrders { get; set; }

    public virtual DbSet<OcDetailsExtraInfo> OcDetailsExtraInfos { get; set; }

    public virtual DbSet<Ocdetail> Ocdetails { get; set; }

    public virtual DbSet<OnlineAccountsList> OnlineAccountsLists { get; set; }

    public virtual DbSet<OrderSummaryReport> OrderSummaryReports { get; set; }

    public virtual DbSet<Orderconf> Orderconfs { get; set; }

    public virtual DbSet<OrderconfExtrainfo> OrderconfExtrainfos { get; set; }

    public virtual DbSet<OrdersLog> OrdersLogs { get; set; }

    public virtual DbSet<ParticipantProduct> ParticipantProducts { get; set; }

    public virtual DbSet<PartnerAccount> PartnerAccounts { get; set; }

    public virtual DbSet<PartnerAddress> PartnerAddresses { get; set; }

    public virtual DbSet<PartnerTradingName> PartnerTradingNames { get; set; }

    public virtual DbSet<PostAddress> PostAddresses { get; set; }

    public virtual DbSet<PostAddressBack> PostAddressBacks { get; set; }

    public virtual DbSet<PostAddressBack20211020> PostAddressBack20211020s { get; set; }

    public virtual DbSet<SyncOrderHistory> SyncOrderHistories { get; set; }

    public virtual DbSet<SyncStockHistory> SyncStockHistories { get; set; }

    public virtual DbSet<SyncTransaction> SyncTransactions { get; set; }

    public virtual DbSet<VCaImportDataReportParticipantCaTempReport> VCaImportDataReportParticipantCaTempReports { get; set; }

    public virtual DbSet<VCaReminderEmail> VCaReminderEmails { get; set; }

    public virtual DbSet<VCaReportOrderAddressIssue> VCaReportOrderAddressIssues { get; set; }

    public virtual DbSet<VCaReportOrderNoBatSize> VCaReportOrderNoBatSizes { get; set; }

    public virtual DbSet<VCaReportOrderSummary> VCaReportOrderSummaries { get; set; }

    public virtual DbSet<VCaReportOrderSummaryDetail> VCaReportOrderSummaryDetails { get; set; }

    public virtual DbSet<VCaReportOrderSummaryDetailstest> VCaReportOrderSummaryDetailstests { get; set; }

    public virtual DbSet<VCaReportParticipant> VCaReportParticipants { get; set; }

    public virtual DbSet<VCaReportParticipantCentre> VCaReportParticipantCentres { get; set; }

    public virtual DbSet<VCaReportParticipantItemDetail> VCaReportParticipantItemDetails { get; set; }

    public virtual DbSet<VCaReportParticipantItemDetailBakPhase42> VCaReportParticipantItemDetailBakPhase42s { get; set; }

    public virtual DbSet<VCaReportParticipantItemDetailV2> VCaReportParticipantItemDetailV2s { get; set; }

    public virtual DbSet<VCaReportParticipantRawDataBakPhase4> VCaReportParticipantRawDataBakPhase4s { get; set; }

    public virtual DbSet<VCaReportParticipantRawDataV2> VCaReportParticipantRawDataV2s { get; set; }

    public virtual DbSet<VCaReportParticipantRawDatum> VCaReportParticipantRawData { get; set; }

    public virtual DbSet<VCaReportParticipantSentPlayer> VCaReportParticipantSentPlayers { get; set; }

    public virtual DbSet<VCaReportRedemptionCentre> VCaReportRedemptionCentres { get; set; }

    public virtual DbSet<VCaReportRedemptionJunior> VCaReportRedemptionJuniors { get; set; }

    public virtual DbSet<VCaReportRedemptionShool> VCaReportRedemptionShools { get; set; }

    public virtual DbSet<VCaReportRejectionOrder> VCaReportRejectionOrders { get; set; }

    public virtual DbSet<VCaReportRejectionPlayer> VCaReportRejectionPlayers { get; set; }

    public virtual DbSet<VCaReportRejectionPlayerTest> VCaReportRejectionPlayerTests { get; set; }

    public virtual DbSet<VCaReportSaleProduct> VCaReportSaleProducts { get; set; }

    public virtual DbSet<VCaReportValidationPlayerProduct> VCaReportValidationPlayerProducts { get; set; }

    public virtual DbSet<VEcomOrder> VEcomOrders { get; set; }

    public virtual DbSet<VOrdersSummary> VOrdersSummaries { get; set; }

    public virtual DbSet<VSyncHistory> VSyncHistories { get; set; }

    public virtual DbSet<VSyncStockHistory> VSyncStockHistories { get; set; }

    public virtual DbSet<VmUsersOrderHistory> VmUsersOrderHistories { get; set; }

    public virtual DbSet<WebGroup> WebGroups { get; set; }

    public virtual DbSet<WebGroupCategory> WebGroupCategories { get; set; }

    public virtual DbSet<WebPermission> WebPermissions { get; set; }

    public virtual DbSet<WebRole> WebRoles { get; set; }

    public virtual DbSet<WebaccountGroup> WebaccountGroups { get; set; }

    public virtual DbSet<WebaccountRole> WebaccountRoles { get; set; }

    public virtual DbSet<Who2blame> Who2blames { get; set; }

    public virtual DbSet<ZRosaCaPlayer> ZRosaCaPlayers { get; set; }

    public virtual DbSet<ZRosaUdtFforderInfo> ZRosaUdtFforderInfos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CaLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CA_Logs__3213E83F2AA4AE8A");

            entity.ToTable("CA_Logs");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Createdate).HasColumnType("datetime");
            entity.Property(e => e.RefId)
                .HasMaxLength(50)
                .HasColumnName("refID");
            entity.Property(e => e.Source).HasMaxLength(500);
        });

        modelBuilder.Entity<CaParticipantOrderDetail>(entity =>
        {
            entity.ToTable("CA_ParticipantOrderDetail");

            entity.HasIndex(e => e.ParticipantOrderId, "OrderID");

            entity.HasIndex(e => e.ProductCode, "ProductCode");

            entity.HasIndex(e => e.IsRemovedFromApi, "f_IsRemovedFromAPI").HasFilter("([IsRemovedFromAPI]=(1))");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.IsRemovedFromApi).HasColumnName("IsRemovedFromAPI");
            entity.Property(e => e.Notes).HasMaxLength(100);
            entity.Property(e => e.ParticipantOrderId).HasColumnName("ParticipantOrderID");
            entity.Property(e => e.ProductCode).HasMaxLength(100);
            entity.Property(e => e.ProductName).HasMaxLength(150);
            entity.Property(e => e.TpfprodId)
                .HasMaxLength(250)
                .HasColumnName("TPFProdId");
            entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");
        });

        modelBuilder.Entity<CaParticipantOrderDetailBackup20201113>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CA_ParticipantOrderDetail_Backup20201113");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ParticipantOrderId).HasColumnName("ParticipantOrderID");
            entity.Property(e => e.ProductCode).HasMaxLength(100);
            entity.Property(e => e.ProductName).HasMaxLength(150);
            entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");
        });

        modelBuilder.Entity<CaParticipantOrderInfo>(entity =>
        {
            entity.ToTable("CA_ParticipantOrderInfo", tb =>
                {
                    tb.HasTrigger("TG_INSERT_TABLE_CA_ParticipantOrderInfo");
                    tb.HasTrigger("TG_UPDATE_TABLE_CA_ParticipantOrderInfo");
                });

            entity.HasIndex(e => new { e.FfestArrivalDate, e.ParticipantKey }, "FFEstArrivalDate");

            entity.HasIndex(e => e.ParticipantKey, "ParticipantKey");

            entity.HasIndex(e => e.PlayerId, "PlayerID");

            entity.HasIndex(e => e.TransId, "TransID");

            entity.HasIndex(e => e.OrderStatus, "f_OrderStatus").HasFilter("([OrderStatus]='pending')");

            entity.HasIndex(e => e.RecordStatusNotes, "f_RecordStatusNotes").HasFilter("([RecordStatusNotes]<>'')");

            entity.Property(e => e.CancelNote).HasMaxLength(200);
            entity.Property(e => e.CarrierName).HasMaxLength(300);
            entity.Property(e => e.CarrierUrl).HasMaxLength(300);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FfestArrivalDate)
                .HasComment("Get from FF API")
                .HasColumnName("FFEstArrivalDate");
            entity.Property(e => e.OrderEtadate)
                .HasComment("ETA date from online shop")
                .HasColumnName("OrderETADate");
            entity.Property(e => e.OrderStatus).HasMaxLength(100);
            entity.Property(e => e.OrderStatusNote).HasMaxLength(500);
            entity.Property(e => e.ParticipantKey).HasMaxLength(500);
            entity.Property(e => e.ParticipantOrderId).HasColumnName("ParticipantOrderID");
            entity.Property(e => e.PlayerId)
                .HasMaxLength(250)
                .HasColumnName("PlayerID");
            entity.Property(e => e.ProgramRefId).HasMaxLength(250);
            entity.Property(e => e.RecordStatus).HasMaxLength(100);
            entity.Property(e => e.RecordStatusNotes).HasMaxLength(500);
            entity.Property(e => e.RefNo).HasMaxLength(100);
            entity.Property(e => e.TrackingNo).HasMaxLength(500);
            entity.Property(e => e.TransId).HasColumnName("TransID");
        });

        modelBuilder.Entity<CaParticipantOrderInfoBackup20201113>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CA_ParticipantOrderInfo_Backup20201113");

            entity.Property(e => e.CarrierName).HasMaxLength(300);
            entity.Property(e => e.CarrierUrl).HasMaxLength(300);
            entity.Property(e => e.FfestArrivalDate).HasColumnName("FFEstArrivalDate");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.OrderEtadate).HasColumnName("OrderETADate");
            entity.Property(e => e.OrderStatus).HasMaxLength(100);
            entity.Property(e => e.OrderStatusNote).HasMaxLength(500);
            entity.Property(e => e.ParticipantKey).HasMaxLength(500);
            entity.Property(e => e.ParticipantOrderId).HasColumnName("ParticipantOrderID");
            entity.Property(e => e.PlayerId)
                .HasMaxLength(250)
                .HasColumnName("PlayerID");
            entity.Property(e => e.ProgramRefId).HasMaxLength(250);
            entity.Property(e => e.RecordStatus).HasMaxLength(100);
            entity.Property(e => e.RecordStatusNotes).HasMaxLength(500);
            entity.Property(e => e.RefNo).HasMaxLength(100);
            entity.Property(e => e.TrackingNo).HasMaxLength(500);
            entity.Property(e => e.TransId).HasColumnName("TransID");
        });

        modelBuilder.Entity<CaTempReportParticipant>(entity =>
        {
            entity.ToTable("CA_TempReportParticipant");

            entity.Property(e => e.BatSize).HasMaxLength(250);
            entity.Property(e => e.Bblteam)
                .HasMaxLength(250)
                .HasColumnName("BBLTeam");
            entity.Property(e => e.CarrierName).HasMaxLength(300);
            entity.Property(e => e.Colours).HasMaxLength(250);
            entity.Property(e => e.DeliveryPostcode).HasMaxLength(250);
            entity.Property(e => e.EntityId)
                .HasMaxLength(250)
                .HasColumnName("EntityID");
            entity.Property(e => e.EntityName).HasMaxLength(250);
            entity.Property(e => e.FirstTime).HasMaxLength(250);
            entity.Property(e => e.Input).HasMaxLength(250);
            entity.Property(e => e.IsExpressDelivery).HasMaxLength(250);
            entity.Property(e => e.ManualReg).HasMaxLength(250);
            entity.Property(e => e.PackChoice).HasMaxLength(250);
            entity.Property(e => e.PackType).HasMaxLength(250);
            entity.Property(e => e.PlayerCategory).HasMaxLength(250);
            entity.Property(e => e.PlayerFirstName).HasMaxLength(250);
            entity.Property(e => e.PlayerId)
                .HasMaxLength(250)
                .HasColumnName("PlayerID");
            entity.Property(e => e.PlayerLastName).HasMaxLength(250);
            entity.Property(e => e.ProgramId)
                .HasMaxLength(250)
                .HasColumnName("ProgramID");
            entity.Property(e => e.RegistrationDate).HasMaxLength(250);
            entity.Property(e => e.RejectionNote).HasMaxLength(500);
            entity.Property(e => e.ShirtName).HasMaxLength(250);
            entity.Property(e => e.ShirtSize).HasMaxLength(250);
            entity.Property(e => e.Size).HasMaxLength(250);
            entity.Property(e => e.TpfprodDesc)
                .HasMaxLength(500)
                .HasColumnName("TPFProdDesc");
            entity.Property(e => e.TpfprodId)
                .HasMaxLength(250)
                .HasColumnName("TPFProdID");
            entity.Property(e => e.TpfreceivedDate).HasColumnName("TPFReceivedDate");
            entity.Property(e => e.TpfuniqueId)
                .HasMaxLength(500)
                .HasColumnName("TPFUniqueID");
            entity.Property(e => e.TrackingNo).HasMaxLength(500);
            entity.Property(e => e.TransId).HasColumnName("TransID");
        });

        modelBuilder.Entity<CaTrackingDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CA_Track__3214EC07A9D9553B");

            entity.ToTable("CA_TrackingDetail");

            entity.Property(e => e.InvCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProdetailId).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TrackingNo)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CaTrackingInfo>(entity =>
        {
            entity.ToTable("CA_TrackingInfo");

            entity.HasIndex(e => e.Ocid, "index_TrackingInfo_Ocid").IsDescending();

            entity.Property(e => e.CarrierName)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.CarrierUrl)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ProcessDate)
                .HasComment("")
                .HasColumnType("datetime");
            entity.Property(e => e.RefNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("deltranId from Internal System (4000xxx)");
            entity.Property(e => e.SentDate).HasColumnType("datetime");
            entity.Property(e => e.TrackingNo)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Oc).WithMany(p => p.CaTrackingInfos)
                .HasForeignKey(d => d.Ocid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CA_TrackingInfo_orderconf");
        });

        modelBuilder.Entity<ClientBilling>(entity =>
        {
            entity.ToTable("clientBilling");

            entity.HasIndex(e => new { e.ClientId, e.Status }, "IX_ClientBilling_ClientID_Status");

            entity.HasIndex(e => new { e.Id, e.Status }, "IX_clientBilling_DefaultID_Status");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Abn)
                .HasMaxLength(30)
                .HasColumnName("abn");
            entity.Property(e => e.AccId)
                .HasComment("AccountID of Client")
                .HasColumnName("accID");
            entity.Property(e => e.Addr1)
                .HasMaxLength(100)
                .HasComment("Address to send the bill")
                .HasColumnName("addr1");
            entity.Property(e => e.Addr2)
                .HasMaxLength(80)
                .HasComment("City to send the bill")
                .HasColumnName("addr2");
            entity.Property(e => e.Addr3)
                .HasMaxLength(80)
                .HasDefaultValueSql("(N'')")
                .HasComment("State to send the bill")
                .HasColumnName("addr3");
            entity.Property(e => e.Attention)
                .HasMaxLength(50)
                .HasComment("Client Name to send bill")
                .HasColumnName("attention");
            entity.Property(e => e.ClientId).HasColumnName("clientID");
            entity.Property(e => e.Companyname)
                .HasMaxLength(250)
                .HasComment("Client Company Name")
                .HasColumnName("companyname");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .HasComment("Country to send the bill")
                .HasColumnName("country");
            entity.Property(e => e.Currency)
                .HasMaxLength(10)
                .HasColumnName("currency");
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .HasColumnName("department");
            entity.Property(e => e.Email)
                .HasMaxLength(80)
                .HasComment("Email")
                .HasColumnName("email");
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .HasColumnName("fax");
            entity.Property(e => e.Fname)
                .HasMaxLength(50)
                .HasComment("Client Contact First Name")
                .HasColumnName("fname");
            entity.Property(e => e.HkaccId)
                .HasComment("Account ID of HK Client")
                .HasColumnName("HKaccID");
            entity.Property(e => e.Lastupdate)
                .HasColumnType("datetime")
                .HasColumnName("lastupdate");
            entity.Property(e => e.Lname)
                .HasMaxLength(50)
                .HasComment("Client Contact Last Name")
                .HasColumnName("lname");
            entity.Property(e => e.Mobile)
                .HasMaxLength(50)
                .HasComment("Mobile phone to contact ")
                .HasColumnName("mobile");
            entity.Property(e => e.Notes)
                .HasMaxLength(2000)
                .HasColumnName("notes");
            entity.Property(e => e.OldAccId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("old_AccID");
            entity.Property(e => e.OptAddress1)
                .HasMaxLength(100)
                .HasColumnName("opt_address1");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .HasComment("Phone")
                .HasColumnName("phone");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .HasColumnName("position");
            entity.Property(e => e.Postcode)
                .HasMaxLength(12)
                .HasDefaultValueSql("(N'')")
                .HasComment("Postcode to send the bill")
                .HasColumnName("postcode");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasDefaultValueSql("('current')")
                .HasComment("Client Status: current, cancelled, inactive, ")
                .HasColumnName("status");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("updateby");
            entity.Property(e => e.VendorNumber)
                .HasMaxLength(50)
                .HasColumnName("vendorNumber");

            entity.HasOne(d => d.Acc).WithMany(p => p.ClientBillings)
                .HasForeignKey(d => d.AccId)
                .HasConstraintName("FK_clientBilling_partnerAccount");
        });

        modelBuilder.Entity<ClientDatum>(entity =>
        {
            entity.HasKey(e => e.ClientId).IsClustered(false);

            entity.HasIndex(e => e.ClientId, "IX_ClientData").IsUnique();

            entity.HasIndex(e => e.ClientId, "IX_ClientDataID").IsClustered();

            entity.HasIndex(e => e.Status, "IX_ClientData_Status");

            entity.Property(e => e.ClientId).HasColumnName("clientID");
            entity.Property(e => e.Abn)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')")
                .HasColumnName("ABN");
            entity.Property(e => e.AccId).HasColumnName("accID");
            entity.Property(e => e.AccLastTransferred)
                .HasColumnType("datetime")
                .HasColumnName("accLastTransferred");
            entity.Property(e => e.AccTransferredBy).HasColumnName("accTransferredBy");
            entity.Property(e => e.Accounttype)
                .HasMaxLength(50)
                .HasColumnName("accounttype");
            entity.Property(e => e.Addr1)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("addr1");
            entity.Property(e => e.Addr2)
                .HasMaxLength(80)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("addr2");
            entity.Property(e => e.Addr3)
                .HasMaxLength(80)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("addr3");
            entity.Property(e => e.Approval)
                .HasMaxLength(80)
                .HasColumnName("approval");
            entity.Property(e => e.AuthorisedAddressId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("authorisedAddressID");
            entity.Property(e => e.BillingAddrId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("billing_addrID");
            entity.Property(e => e.BillingAttention)
                .HasMaxLength(150)
                .HasColumnName("billing_attention");
            entity.Property(e => e.BillingCompanyname)
                .HasMaxLength(250)
                .HasColumnName("billing_companyname");
            entity.Property(e => e.BillingEmail)
                .HasMaxLength(150)
                .HasColumnName("billing_email");
            entity.Property(e => e.BillingFax)
                .HasMaxLength(50)
                .HasColumnName("billing_fax");
            entity.Property(e => e.BillingMobile)
                .HasMaxLength(50)
                .HasColumnName("billing_mobile");
            entity.Property(e => e.BillingPhone)
                .HasMaxLength(50)
                .HasColumnName("billing_phone");
            entity.Property(e => e.CatalogueClient)
                .HasMaxLength(5)
                .HasDefaultValueSql("('NO')")
                .HasColumnName("catalogueClient");
            entity.Property(e => e.ClientNumber)
                .HasMaxLength(50)
                .HasColumnName("clientNumber");
            entity.Property(e => e.ClientRefId)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasColumnName("clientRefID");
            entity.Property(e => e.Companyname)
                .HasMaxLength(250)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("companyname");
            entity.Property(e => e.ContactAddrId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("contact_addrID");
            entity.Property(e => e.Costcentre)
                .HasMaxLength(75)
                .HasColumnName("costcentre");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .HasColumnName("country");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("createDate");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("createby");
            entity.Property(e => e.Currency)
                .HasMaxLength(10)
                .HasDefaultValueSql("('AUD')")
                .HasColumnName("currency");
            entity.Property(e => e.Custid)
                .HasDefaultValueSql("((0))")
                .HasComment("userid from custdata")
                .HasColumnName("custid");
            entity.Property(e => e.Dealercode)
                .HasMaxLength(40)
                .HasColumnName("dealercode");
            entity.Property(e => e.Dealername)
                .HasMaxLength(80)
                .HasColumnName("dealername");
            entity.Property(e => e.DefaultBillingId).HasColumnName("default_billingID");
            entity.Property(e => e.DefaultDelId).HasColumnName("default_delID");
            entity.Property(e => e.DelAddrId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("del_addrID");
            entity.Property(e => e.DelAttention)
                .HasMaxLength(120)
                .HasColumnName("del_attention");
            entity.Property(e => e.DelCompanyname)
                .HasMaxLength(250)
                .HasColumnName("del_companyname");
            entity.Property(e => e.DelEmail)
                .HasMaxLength(150)
                .HasColumnName("del_email");
            entity.Property(e => e.DelFax)
                .HasMaxLength(50)
                .HasColumnName("del_fax");
            entity.Property(e => e.DelMobile)
                .HasMaxLength(50)
                .HasColumnName("del_mobile");
            entity.Property(e => e.DelPhone)
                .HasMaxLength(50)
                .HasColumnName("del_phone");
            entity.Property(e => e.DelSpecialinstructions)
                .HasMaxLength(250)
                .HasColumnName("del_specialinstructions");
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .HasColumnName("department");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("dob");
            entity.Property(e => e.Done)
                .HasMaxLength(10)
                .HasColumnName("done");
            entity.Property(e => e.Email)
                .HasMaxLength(80)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("email");
            entity.Property(e => e.Emarketing).HasColumnName("emarketing");
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("fax");
            entity.Property(e => e.Fname)
                .HasMaxLength(50)
                .HasColumnName("fname");
            entity.Property(e => e.HkaccId).HasColumnName("HKaccID");
            entity.Property(e => e.Lastchange)
                .HasMaxLength(50)
                .HasColumnName("lastchange");
            entity.Property(e => e.Lname)
                .HasMaxLength(50)
                .HasColumnName("lname");
            entity.Property(e => e.Mobile)
                .HasMaxLength(50)
                .HasColumnName("mobile");
            entity.Property(e => e.ModDate)
                .HasColumnType("datetime")
                .HasColumnName("modDate");
            entity.Property(e => e.Notes)
                .HasMaxLength(2500)
                .HasColumnName("notes");
            entity.Property(e => e.OktoSpam)
                .HasMaxLength(10)
                .HasColumnName("OKtoSpam");
            entity.Property(e => e.OldAccId).HasColumnName("oldAccID");
            entity.Property(e => e.OptAddress1)
                .HasMaxLength(100)
                .HasColumnName("opt_address1");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("phone");
            entity.Property(e => e.Position)
                .HasMaxLength(120)
                .HasColumnName("position");
            entity.Property(e => e.Postcode)
                .HasMaxLength(12)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("postcode");
            entity.Property(e => e.Sortcode)
                .HasMaxLength(50)
                .HasColumnName("sortcode");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'current')")
                .HasColumnName("status");
            entity.Property(e => e.StatusUpdateBy)
                .HasDefaultValueSql("((0))")
                .HasColumnName("statusUpdateBy");
            entity.Property(e => e.StatusUpdateOn)
                .HasColumnType("datetime")
                .HasColumnName("statusUpdateOn");
            entity.Property(e => e.TempAbn)
                .HasMaxLength(30)
                .HasColumnName("tempABN");
            entity.Property(e => e.TnId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("tnID");
        });

        modelBuilder.Entity<ClientDelDatum>(entity =>
        {
            entity.ToTable("clientDelData");

            entity.HasIndex(e => new { e.ClientId, e.Status }, "IX_ClientDelData_ClientID_Status");

            entity.HasIndex(e => e.ClientId, "clientID");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Abn)
                .HasMaxLength(30)
                .HasComment("client ABN Number")
                .HasColumnName("abn");
            entity.Property(e => e.AccId)
                .HasComment("Account ID")
                .HasColumnName("accID");
            entity.Property(e => e.Addr1)
                .HasMaxLength(100)
                .HasComment("Client Delivery Address")
                .HasColumnName("addr1");
            entity.Property(e => e.Addr2)
                .HasMaxLength(80)
                .HasComment("Delivery Suburb")
                .HasColumnName("addr2");
            entity.Property(e => e.Addr3)
                .HasMaxLength(80)
                .HasDefaultValueSql("(N'')")
                .HasComment("Delivery State")
                .HasColumnName("addr3");
            entity.Property(e => e.Attention)
                .HasMaxLength(50)
                .HasComment("Attention name for delivery")
                .HasColumnName("attention");
            entity.Property(e => e.ClientId)
                .HasComment("link to client id to display client information details")
                .HasColumnName("clientID");
            entity.Property(e => e.Companyname)
                .HasMaxLength(250)
                .HasComment("client company name")
                .HasColumnName("companyname");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .HasComment("Delivery Country")
                .HasColumnName("country");
            entity.Property(e => e.Currency)
                .HasMaxLength(10)
                .HasColumnName("currency");
            entity.Property(e => e.Email)
                .HasMaxLength(80)
                .HasDefaultValueSql("(N'')")
                .HasComment("email to contact for delivery")
                .HasColumnName("email");
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .HasComment("fax to contact for delivery")
                .HasColumnName("fax");
            entity.Property(e => e.Fname)
                .HasMaxLength(50)
                .HasComment("First Name")
                .HasColumnName("fname");
            entity.Property(e => e.HkaccId)
                .HasComment("Hong Kong Account ID")
                .HasColumnName("HKaccID");
            entity.Property(e => e.Lname)
                .HasMaxLength(50)
                .HasComment("Last Name")
                .HasColumnName("lname");
            entity.Property(e => e.Mobile)
                .HasMaxLength(50)
                .HasComment("mobile phone to contact for delivery")
                .HasColumnName("mobile");
            entity.Property(e => e.ModDate)
                .HasComment("modify Date")
                .HasColumnType("datetime")
                .HasColumnName("modDate");
            entity.Property(e => e.Modby)
                .HasMaxLength(50)
                .HasComment("modify by staffID")
                .HasColumnName("modby");
            entity.Property(e => e.OptAddress1)
                .HasMaxLength(100)
                .HasColumnName("opt_address1");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')")
                .HasComment("phone to contact for delivery")
                .HasColumnName("phone");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .HasColumnName("position");
            entity.Property(e => e.Postcode)
                .HasMaxLength(12)
                .HasDefaultValueSql("(N'')")
                .HasComment("Delivery Post Code")
                .HasColumnName("postcode");
            entity.Property(e => e.Specialinstructions)
                .HasMaxLength(1000)
                .HasComment("Special Instructions")
                .HasColumnName("specialinstructions");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasDefaultValueSql("('current')")
                .HasComment("Client Delivery Status: current, inactive, removed,  cancelled, yes")
                .HasColumnName("status");

            entity.HasOne(d => d.Acc).WithMany(p => p.ClientDelData)
                .HasForeignKey(d => d.AccId)
                .HasConstraintName("FK_clientDelData_partnerAccount");
        });

        modelBuilder.Entity<ClientWebAccount>(entity =>
        {
            entity.HasKey(e => e.WebAccId);

            entity.ToTable("clientWebAccount");

            entity.HasIndex(e => e.Updateby, "IX_ClientWebAccount_UpdateBy");

            entity.HasIndex(e => e.ClientId, "IX_WebAccount_ClientID");

            entity.HasIndex(e => e.WebAccId, "IX_clientWebAccount");

            entity.HasIndex(e => e.Catalogueid, "IX_clientWebAccount_CatalogueID");

            entity.HasIndex(e => e.PriceProfileId, "IX_clientWebAccount_priceProfileID");

            entity.Property(e => e.WebAccId).HasColumnName("webAccID");
            entity.Property(e => e.AccessStatus)
                .HasMaxLength(10)
                .HasDefaultValueSql("('active')")
                .HasColumnName("accessStatus");
            entity.Property(e => e.Accesslevel).HasColumnName("accesslevel");
            entity.Property(e => e.Accesstagid).HasColumnName("accesstagid");
            entity.Property(e => e.Caninvoice).HasColumnName("caninvoice");
            entity.Property(e => e.Catalogueid).HasColumnName("catalogueid");
            entity.Property(e => e.ClientId).HasColumnName("clientID");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .HasColumnName("createby");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.Encryptedpw)
                .HasMaxLength(40)
                .HasColumnName("encryptedpw");
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
            entity.Property(e => e.IsLogin)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isLogin");
            entity.Property(e => e.Lastlogin)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Lastupdate)
                .HasColumnType("datetime")
                .HasColumnName("lastupdate");
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
            entity.Property(e => e.Seed)
                .HasMaxLength(2)
                .HasColumnName("seed");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasDefaultValueSql("('current')")
                .HasColumnName("status");
            entity.Property(e => e.Token).HasColumnName("token");
            entity.Property(e => e.Tokendate)
                .HasColumnType("datetime")
                .HasColumnName("tokendate");
            entity.Property(e => e.Updateby).HasColumnName("updateby");
            entity.Property(e => e.UseEncryption).HasColumnName("use_encryption");
            entity.Property(e => e.Username)
                .HasMaxLength(150)
                .HasColumnName("username");
        });

        modelBuilder.Entity<ClientWebAccountBakUpdateProfile>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("clientWebAccountBakUpdateProfile");

            entity.Property(e => e.AccessStatus)
                .HasMaxLength(10)
                .HasColumnName("accessStatus");
            entity.Property(e => e.Accesslevel).HasColumnName("accesslevel");
            entity.Property(e => e.Accesstagid).HasColumnName("accesstagid");
            entity.Property(e => e.Caninvoice).HasColumnName("caninvoice");
            entity.Property(e => e.Catalogueid).HasColumnName("catalogueid");
            entity.Property(e => e.ClientId).HasColumnName("clientID");
            entity.Property(e => e.Createby).HasColumnName("createby");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.Encryptedpw)
                .HasMaxLength(40)
                .HasColumnName("encryptedpw");
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
            entity.Property(e => e.IsLogin).HasColumnName("isLogin");
            entity.Property(e => e.Lastlogin).HasColumnType("datetime");
            entity.Property(e => e.Lastupdate)
                .HasColumnType("datetime")
                .HasColumnName("lastupdate");
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
            entity.Property(e => e.Seed)
                .HasMaxLength(2)
                .HasColumnName("seed");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("status");
            entity.Property(e => e.Token).HasColumnName("token");
            entity.Property(e => e.Tokendate)
                .HasColumnType("datetime")
                .HasColumnName("tokendate");
            entity.Property(e => e.Updateby).HasColumnName("updateby");
            entity.Property(e => e.UseEncryption).HasColumnName("use_encryption");
            entity.Property(e => e.Username)
                .HasMaxLength(150)
                .HasColumnName("username");
            entity.Property(e => e.WebAccId).HasColumnName("webAccID");
        });

        modelBuilder.Entity<Invoice>(entity =>
        {
            entity.HasKey(e => e.Invoicenumber);

            entity.ToTable("Invoice");

            entity.HasIndex(e => e.Invoicedate, "IX_Invoice")
                .IsDescending()
                .HasFillFactor(90);

            entity.HasIndex(e => e.Cid, "cid");

            entity.HasIndex(e => e.ClientId, "clientID");

            entity.HasIndex(e => new { e.InvGroup, e.Type, e.InvStatus, e.ClientId, e.Ordernumber }, "inv_group")
                .IsDescending(false, true, false, false, false)
                .HasFillFactor(90);

            entity.HasIndex(e => e.InvStatus, "inv_status");

            entity.HasIndex(e => e.Invoicenumber, "invoicenumber");

            entity.HasIndex(e => e.Ordernumber, "ordernumber").IsDescending();

            entity.HasIndex(e => e.Type, "type").IsDescending();

            entity.Property(e => e.Invoicenumber).HasColumnName("invoicenumber");
            entity.Property(e => e.Abn)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasColumnName("abn");
            entity.Property(e => e.Aribasendlog)
                .HasMaxLength(20)
                .HasColumnName("aribasendlog");
            entity.Property(e => e.Basecurrency)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("basecurrency");
            entity.Property(e => e.Catalogueid).HasColumnName("catalogueid");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.ClientEmail)
                .HasMaxLength(100)
                .HasComment("email invoice")
                .HasColumnName("client_email");
            entity.Property(e => e.ClientId).HasColumnName("clientID");
            entity.Property(e => e.Companyname)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasComment("for corperate address")
                .HasColumnName("companyname");
            entity.Property(e => e.DelAbn)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasColumnName("del_abn");
            entity.Property(e => e.DelAddr1)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasComment("Delivery Address")
                .HasColumnName("del_addr1");
            entity.Property(e => e.DelAddr2)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("Delivery Suburb")
                .HasColumnName("del_addr2");
            entity.Property(e => e.DelAddr3)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("Delivery State")
                .HasColumnName("del_addr3");
            entity.Property(e => e.DelClientId)
                .HasComment("Delivery Client ID")
                .HasColumnName("del_clientID");
            entity.Property(e => e.DelCompanyname)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasComment("Delivery Company Name")
                .HasColumnName("del_companyname");
            entity.Property(e => e.DelCountry)
                .HasMaxLength(120)
                .HasDefaultValueSql("('')")
                .HasColumnName("del_country");
            entity.Property(e => e.DelFname)
                .HasMaxLength(80)
                .HasDefaultValueSql("('')")
                .HasComment("Delivery First Name")
                .HasColumnName("del_fname");
            entity.Property(e => e.DelLname)
                .HasMaxLength(80)
                .HasDefaultValueSql("('')")
                .HasComment("Delivery Last Name")
                .HasColumnName("del_lname");
            entity.Property(e => e.DelPostcode)
                .HasMaxLength(50)
                .HasComment("Delivery Post Code")
                .HasColumnName("del_postcode");
            entity.Property(e => e.Emailinvoicelastsent)
                .HasComment("date that invoice last sent by email")
                .HasColumnType("datetime")
                .HasColumnName("emailinvoicelastsent");
            entity.Property(e => e.Emaillastsentby)
                .HasComment("staff who last sent email - staff id")
                .HasColumnName("emaillastsentby");
            entity.Property(e => e.Emailsent)
                .HasDefaultValueSql("((0))")
                .HasComment("number of time email sent by invoice")
                .HasColumnName("emailsent");
            entity.Property(e => e.Exchangerate)
                .HasDefaultValueSql("((1))")
                .HasColumnName("exchangerate");
            entity.Property(e => e.FinanceNotes)
                .HasComment("Finance Notes")
                .HasColumnName("financeNotes");
            entity.Property(e => e.Freight)
                .HasDefaultValueSql("((0))")
                .HasColumnName("freight");
            entity.Property(e => e.Generalnotes)
                .HasMaxLength(1000)
                .HasComment("General Notes")
                .HasColumnName("generalnotes");
            entity.Property(e => e.GstTotal).HasColumnName("gstTotal");
            entity.Property(e => e.HistoryChange)
                .HasColumnType("text")
                .HasColumnName("historyChange");
            entity.Property(e => e.IInvoiceTotal).HasColumnName("iInvoiceTotal");
            entity.Property(e => e.IInvoiceTotalExc).HasColumnName("iInvoiceTotalExc");
            entity.Property(e => e.InvCurrency)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'AUD')")
                .HasComment("Invoice Currency")
                .HasColumnName("inv_currency");
            entity.Property(e => e.InvGroup)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'external')")
                .HasComment("internal/external")
                .HasColumnName("inv_group");
            entity.Property(e => e.InvStatus)
                .HasDefaultValueSql("((0))")
                .HasComment("0 outstanding / 1 paid / 3 is for cancel invoice")
                .HasColumnName("inv_status");
            entity.Property(e => e.InvTradeterms)
                .HasMaxLength(10)
                .HasComment("Invoice Trade Terms: PREPAYMENT/ Cash/ COD/ 7 days/ 14 days/ 30 days/ 45 days/ 60 days")
                .HasColumnName("inv_tradeterms");
            entity.Property(e => e.InvTransferredDate)
                .HasColumnType("datetime")
                .HasColumnName("invTransferredDate");
            entity.Property(e => e.Invoicedate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("invoicedate");
            entity.Property(e => e.Invoicesent)
                .HasComment("invoice sent date")
                .HasColumnType("datetime")
                .HasColumnName("invoicesent");
            entity.Property(e => e.Invoicesentby)
                .HasDefaultValueSql("((0))")
                .HasComment("invoice sent by - staff id")
                .HasColumnName("invoicesentby");
            entity.Property(e => e.Invoicetotal)
                .HasDefaultValueSql("((0))")
                .HasComment("total -> inc freight")
                .HasColumnName("invoicetotal");
            entity.Property(e => e.Invoicetotalexc)
                .HasDefaultValueSql("((0))")
                .HasComment("Invoice Total not including GST")
                .HasColumnName("invoicetotalexc");
            entity.Property(e => e.Invoicetype)
                .HasMaxLength(20)
                .HasColumnName("invoicetype");
            entity.Property(e => e.Isource)
                .HasMaxLength(100)
                .HasColumnName("isource");
            entity.Property(e => e.Lastreminderemail)
                .HasColumnType("datetime")
                .HasColumnName("lastreminderemail");
            entity.Property(e => e.OldCustId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("OldCustID");
            entity.Property(e => e.Ordernumber).HasColumnName("ordernumber");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValueSql("((0))")
                .HasComment("AUD - Amount paid by client")
                .HasColumnName("paidAmount");
            entity.Property(e => e.Paymethod)
                .HasMaxLength(15)
                .HasDefaultValueSql("('')")
                .HasColumnName("paymethod");
            entity.Property(e => e.Ponumber)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasColumnName("ponumber");
            entity.Property(e => e.Processedby)
                .HasMaxLength(50)
                .HasComment("staff who processed the invoice")
                .HasColumnName("processedby");
            entity.Property(e => e.Raisedby)
                .HasMaxLength(50)
                .HasColumnName("raisedby");
            entity.Property(e => e.RateEntityToAud).HasColumnName("RateEntityToAUD");
            entity.Property(e => e.ReminderEmail)
                .HasMaxLength(120)
                .HasDefaultValueSql("('')")
                .HasColumnName("reminderEmail");
            entity.Property(e => e.RoyaltyContract)
                .HasMaxLength(50)
                .HasColumnName("royaltyContract");
            entity.Property(e => e.SendEmailStatus)
                .HasDefaultValueSql("((1))")
                .HasComment("Send email invoice status - 0=sent, 1=unsent")
                .HasColumnName("sendEmailStatus");
            entity.Property(e => e.SendInvStatus)
                .HasDefaultValueSql("((1))")
                .HasComment("0-sent / 1- unsent")
                .HasColumnName("sendInvStatus");
            entity.Property(e => e.SendRemStatus)
                .HasDefaultValueSql("((1))")
                .HasComment("0 - sent / 1 - unsent")
                .HasColumnName("sendRemStatus");
            entity.Property(e => e.SendTofname)
                .HasMaxLength(80)
                .HasDefaultValueSql("('')")
                .HasComment("First Name to send the invoice")
                .HasColumnName("sendTofname");
            entity.Property(e => e.SendTolname)
                .HasMaxLength(80)
                .HasDefaultValueSql("('')")
                .HasComment("Last Name to send the invoice")
                .HasColumnName("sendTolname");
            entity.Property(e => e.Sendstate)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasColumnName("sendstate");
            entity.Property(e => e.Sendtoaddress)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasComment("the address to send invoice")
                .HasColumnName("sendtoaddress");
            entity.Property(e => e.Sendtocity)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("city to send the invoice")
                .HasColumnName("sendtocity");
            entity.Property(e => e.Sendtocountry)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasColumnName("sendtocountry");
            entity.Property(e => e.Sendtopostcode)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasColumnName("sendtopostcode");
            entity.Property(e => e.StaffId)
                .HasComment("")
                .HasColumnName("staffID");
            entity.Property(e => e.StaffPhone)
                .HasMaxLength(20)
                .HasColumnName("staffPhone");
            entity.Property(e => e.Tpfcontactname)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("TPF Contact Name ")
                .HasColumnName("tpfcontactname");
            entity.Property(e => e.Tracking).HasColumnName("tracking");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .HasComment("CPC for catalogue")
                .HasColumnName("type");
            entity.Property(e => e.Vendorno)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasColumnName("vendorno");
        });

        modelBuilder.Entity<InvoiceDetail>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => e.Invoicenumber, "invoicenumber")
                .IsDescending()
                .IsClustered()
                .HasFillFactor(90);

            entity.HasIndex(e => new { e.Ordernumber, e.Invoicenumber }, "ordernumber")
                .IsDescending()
                .HasFillFactor(90);

            entity.HasIndex(e => e.Prodetailid, "prodetailid").HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Bsitem)
                .HasDefaultValueSql("((0))")
                .HasColumnName("bsitem");
            entity.Property(e => e.Deldetails)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("deldetails");
            entity.Property(e => e.Gstratio)
                .HasDefaultValueSql("((10))")
                .HasComment("Default GST 10%")
                .HasColumnName("GSTRatio");
            entity.Property(e => e.IPriceExc).HasColumnName("iPriceExc");
            entity.Property(e => e.IPriceTax).HasColumnName("iPriceTax");
            entity.Property(e => e.Invcode)
                .HasMaxLength(25)
                .HasColumnName("invcode");
            entity.Property(e => e.Invoicenumber)
                .HasComment("Invoice Number")
                .HasColumnName("invoicenumber");
            entity.Property(e => e.Itemname)
                .HasMaxLength(250)
                .HasComment("Item Name")
                .HasColumnName("itemname");
            entity.Property(e => e.Ocdetailid)
                .HasComment("Order Details Id")
                .HasColumnName("ocdetailid");
            entity.Property(e => e.Ordernumber)
                .HasComment("Order Number")
                .HasColumnName("ordernumber");
            entity.Property(e => e.Price)
                .HasComment("Price: including GST")
                .HasColumnName("price");
            entity.Property(e => e.Priceexc)
                .HasComment("Price exc GST ")
                .HasColumnName("priceexc");
            entity.Property(e => e.Pricegst)
                .HasComment("Price gst")
                .HasColumnName("pricegst");
            entity.Property(e => e.Prodetailid)
                .HasMaxLength(20)
                .HasComment("Product Detail ID")
                .HasColumnName("prodetailid");
            entity.Property(e => e.Qty).HasColumnName("qty");
            entity.Property(e => e.RoyaltyContract)
                .HasDefaultValueSql("((0))")
                .HasColumnName("royaltyContract");
            entity.Property(e => e.Tpfcode)
                .HasMaxLength(50)
                .HasColumnName("tpfcode");
        });

        modelBuilder.Entity<OcDeliveryDetail>(entity =>
        {
            entity.HasKey(e => e.DelDetailId).IsClustered(false);

            entity.ToTable("ocDeliveryDetails");

            entity.HasIndex(e => e.DelorderId, "IX_ocDeliveryDetails_1")
                .IsClustered()
                .HasFillFactor(90);

            entity.HasIndex(e => e.Ocdetailid, "ocdetailid")
                .IsDescending()
                .HasFillFactor(90);

            entity.HasIndex(e => e.Ocid, "ocid")
                .IsDescending()
                .HasFillFactor(90);

            entity.HasIndex(e => e.Prodetailid, "prodetailid");

            entity.Property(e => e.DelDetailId).HasColumnName("delDetailID");
            entity.Property(e => e.DelorderId).HasColumnName("delorderID");
            entity.Property(e => e.Delproname)
                .HasMaxLength(120)
                .HasColumnName("delproname");
            entity.Property(e => e.Delqty).HasColumnName("delqty");
            entity.Property(e => e.Invcode)
                .HasMaxLength(50)
                .HasColumnName("invcode");
            entity.Property(e => e.ItemWeight).HasColumnName("itemWeight");
            entity.Property(e => e.Itemcatalogueid)
                .HasDefaultValueSql("((213))")
                .HasColumnName("itemcatalogueid");
            entity.Property(e => e.Itemtype)
                .HasMaxLength(50)
                .HasDefaultValueSql("('adhoc')")
                .HasColumnName("itemtype");
            entity.Property(e => e.Modtrack)
                .HasMaxLength(5)
                .HasDefaultValueSql("('no')")
                .HasColumnName("modtrack");
            entity.Property(e => e.Note)
                .HasMaxLength(800)
                .HasColumnName("note");
            entity.Property(e => e.Ocdetailid).HasColumnName("ocdetailid");
            entity.Property(e => e.Ocid).HasColumnName("ocid");
            entity.Property(e => e.OrgDelqty)
                .HasDefaultValueSql("((0))")
                .HasComment("for partly-packed to fully-packed")
                .HasColumnName("org_delqty");
            entity.Property(e => e.Prodetailid).HasColumnName("prodetailid");
            entity.Property(e => e.Qtysent)
                .HasDefaultValueSql("((0))")
                .HasComment("sum up ocdeltrandetails.delqty")
                .HasColumnName("qtysent");
            entity.Property(e => e.SizeId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("sizeID");
            entity.Property(e => e.Spid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("spid");
            entity.Property(e => e.StockReservingId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("stockReservingID");
            entity.Property(e => e.Tpfcode)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasColumnName("tpfcode");
            entity.Property(e => e.Unitgst).HasColumnName("unitgst");
            entity.Property(e => e.Unitprice).HasColumnName("unitprice");

            entity.HasOne(d => d.Delorder).WithMany(p => p.OcDeliveryDetails)
                .HasForeignKey(d => d.DelorderId)
                .HasConstraintName("FK_ocDeliveryDetails_ocDeliveryOrders");
        });

        modelBuilder.Entity<OcDeliveryOrder>(entity =>
        {
            entity.HasKey(e => e.DelorderId).IsClustered(false);

            entity.ToTable("ocDeliveryOrders", tb => tb.HasTrigger("tr_change_status"));

            entity.HasIndex(e => e.Catalogueid, "catalogueid").HasFillFactor(90);

            entity.HasIndex(e => e.DelorderId, "delorderID");

            entity.HasIndex(e => new { e.Ocid, e.Status, e.Catalogueid, e.Whid, e.Orderdate }, "ocid")
                .IsDescending(true, false, false, false, false)
                .HasFillFactor(90);

            entity.HasIndex(e => new { e.Status, e.DelorderId }, "status")
                .IsDescending()
                .HasFillFactor(90);

            entity.HasIndex(e => new { e.Whid, e.DelorderId }, "whid")
                .IsDescending(false, true)
                .HasFillFactor(90);

            entity.Property(e => e.DelorderId).HasColumnName("delorderID");
            entity.Property(e => e.Addr1)
                .HasMaxLength(500)
                .HasColumnName("addr1");
            entity.Property(e => e.Addr2)
                .HasMaxLength(500)
                .HasColumnName("addr2");
            entity.Property(e => e.Addr3)
                .HasMaxLength(500)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("addr3");
            entity.Property(e => e.CancelledBy).HasColumnName("cancelledBy");
            entity.Property(e => e.Catalogueid)
                .HasDefaultValueSql("((133))")
                .HasColumnName("catalogueid");
            entity.Property(e => e.ClientId).HasColumnName("clientID");
            entity.Property(e => e.ClubId).HasColumnName("ClubID");
            entity.Property(e => e.Companyname)
                .HasMaxLength(500)
                .HasColumnName("companyname");
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .HasColumnName("country");
            entity.Property(e => e.DefaultCourierId)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("default_courierID");
            entity.Property(e => e.Email)
                .HasMaxLength(500)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("email");
            entity.Property(e => e.Fax)
                .HasMaxLength(500)
                .HasColumnName("fax");
            entity.Property(e => e.Fname)
                .HasMaxLength(500)
                .HasColumnName("fname");
            entity.Property(e => e.IsTransfer).HasColumnName("isTransfer");
            entity.Property(e => e.Lname)
                .HasMaxLength(500)
                .HasColumnName("lname");
            entity.Property(e => e.Mobile)
                .HasMaxLength(500)
                .HasColumnName("mobile");
            entity.Property(e => e.Notes)
                .HasMaxLength(450)
                .HasDefaultValueSql("('')")
                .HasColumnName("notes");
            entity.Property(e => e.NotestoVisaNz)
                .HasMaxLength(500)
                .HasColumnName("notestoVisaNZ");
            entity.Property(e => e.Ocid).HasColumnName("ocid");
            entity.Property(e => e.OrderType)
                .HasDefaultValueSql("((1))")
                .HasColumnName("orderType");
            entity.Property(e => e.Orderdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("orderdate");
            entity.Property(e => e.Pack)
                .HasDefaultValueSql("((0))")
                .HasColumnName("pack");
            entity.Property(e => e.Phone)
                .HasMaxLength(500)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("phone");
            entity.Property(e => e.Postcode)
                .HasMaxLength(500)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("postcode");
            entity.Property(e => e.Processedby).HasColumnName("processedby");
            entity.Property(e => e.PromotionName)
                .HasMaxLength(500)
                .HasColumnName("promotionName");
            entity.Property(e => e.Reqdeldate)
                .HasColumnType("datetime")
                .HasColumnName("reqdeldate");
            entity.Property(e => e.SentCount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("sentCount");
            entity.Property(e => e.Source)
                .HasMaxLength(50)
                .HasColumnName("source");
            entity.Property(e => e.Specialinstructions)
                .HasMaxLength(1000)
                .HasColumnName("specialinstructions");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValueSql("('new')")
                .HasColumnName("status");
            entity.Property(e => e.Totalprice)
                .HasMaxLength(50)
                .HasColumnName("totalprice");
            entity.Property(e => e.Tpfemail)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')")
                .HasColumnName("tpfemail");
            entity.Property(e => e.UploadRef).HasColumnName("uploadRef");
            entity.Property(e => e.WhOrderNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("whOrderNo");
            entity.Property(e => e.Whid)
                .HasDefaultValueSql("((1))")
                .HasColumnName("whid");
        });

        modelBuilder.Entity<OcDetailsExtraInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ocDetailsExtraInfo");

            entity.Property(e => e.Acquisition)
                .HasMaxLength(50)
                .HasColumnName("acquisition");
            entity.Property(e => e.AcquisitionDescription)
                .HasMaxLength(50)
                .HasColumnName("acquisitionDescription");
            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .HasColumnName("address");
            entity.Property(e => e.Allergies)
                .HasMaxLength(50)
                .HasColumnName("allergies");
            entity.Property(e => e.BrandAwareness)
                .HasMaxLength(50)
                .HasColumnName("brandAwareness");
            entity.Property(e => e.Catalogue).HasColumnName("catalogue");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .HasColumnName("city");
            entity.Property(e => e.Companyname)
                .HasMaxLength(100)
                .HasColumnName("companyname");
            entity.Property(e => e.DietaryReq)
                .HasMaxLength(50)
                .HasColumnName("dietaryReq");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("dob");
            entity.Property(e => e.DownloadCount).HasColumnName("downloadCount");
            entity.Property(e => e.DownloadedBy).HasColumnName("downloadedBy");
            entity.Property(e => e.DownloadedDate)
                .HasColumnType("datetime")
                .HasColumnName("downloadedDate");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Emergencycontact)
                .HasMaxLength(50)
                .HasColumnName("emergencycontact");
            entity.Property(e => e.Emergencycontact2)
                .HasMaxLength(50)
                .HasColumnName("emergencycontact2");
            entity.Property(e => e.Emergencyphone)
                .HasMaxLength(50)
                .HasColumnName("emergencyphone");
            entity.Property(e => e.Event)
                .HasMaxLength(50)
                .HasColumnName("event");
            entity.Property(e => e.Fname)
                .HasMaxLength(50)
                .HasColumnName("fname");
            entity.Property(e => e.Gender)
                .HasMaxLength(20)
                .HasColumnName("gender");
            entity.Property(e => e.Growth).HasColumnName("growth");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IncreaseRangingFrom)
                .HasMaxLength(50)
                .HasColumnName("increaseRangingFrom");
            entity.Property(e => e.IncreaseRangingTo)
                .HasMaxLength(50)
                .HasColumnName("increaseRangingTo");
            entity.Property(e => e.Itemcode)
                .HasMaxLength(50)
                .HasColumnName("itemcode");
            entity.Property(e => e.Lname)
                .HasMaxLength(50)
                .HasColumnName("lname");
            entity.Property(e => e.Mobile)
                .HasMaxLength(20)
                .HasColumnName("mobile");
            entity.Property(e => e.OcdetailId).HasColumnName("ocdetailID");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .HasColumnName("phone");
            entity.Property(e => e.Physicalcon)
                .HasMaxLength(50)
                .HasColumnName("physicalcon");
            entity.Property(e => e.Postcode)
                .HasMaxLength(20)
                .HasColumnName("postcode");
            entity.Property(e => e.PriorPeriod)
                .HasMaxLength(50)
                .HasColumnName("priorPeriod");
            entity.Property(e => e.PromotionEnd)
                .HasColumnType("datetime")
                .HasColumnName("promotionEnd");
            entity.Property(e => e.PromotionStart)
                .HasColumnType("datetime")
                .HasColumnName("promotionStart");
            entity.Property(e => e.ReportToClub).HasColumnName("reportToClub");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .HasColumnName("state");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.StoreNumberOrCustomerNumber)
                .HasMaxLength(50)
                .HasColumnName("storeNumberOrCustomerNumber");
            entity.Property(e => e.Title)
                .HasMaxLength(20)
                .HasColumnName("title");
            entity.Property(e => e.Travelmode)
                .HasMaxLength(50)
                .HasColumnName("travelmode");
        });

        modelBuilder.Entity<Ocdetail>(entity =>
        {
            entity.HasKey(e => e.Ocdetailid).IsClustered(false);

            entity.ToTable("ocdetails");

            entity.HasIndex(e => e.Cpcprodetailcode, "cpcprodetailcode");

            entity.HasIndex(e => new { e.Ocid, e.Detailstatus, e.Ocdetailid }, "ocid")
                .IsDescending(true, true, false)
                .IsClustered()
                .HasFillFactor(90);

            entity.HasIndex(e => e.Whid, "whid").HasFillFactor(90);

            entity.Property(e => e.Ocdetailid).HasColumnName("ocdetailid");
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
                .HasComment("prodetailid in productdetail")
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
            entity.Property(e => e.IsSentToFf)
                .HasDefaultValueSql("((0))")
                .HasColumnName("IsSentToFF");
            entity.Property(e => e.IsSubItem).HasColumnName("isSubItem");
            entity.Property(e => e.ItemCatalogueId)
                .HasDefaultValueSql("((213))")
                .HasColumnName("itemCatalogueID");
            entity.Property(e => e.Itemgroup)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))")
                .HasComment("CPC or Adhoc item")
                .HasColumnName("itemgroup");
            entity.Property(e => e.Itemid)
                .HasComment("itemid corresponds to itemid in Csversion1.dbo.myItems")
                .HasColumnName("itemid");
            entity.Property(e => e.Itemtype)
                .HasMaxLength(10)
                .HasDefaultValueSql("('adhoc')")
                .HasColumnName("itemtype");
            entity.Property(e => e.JcItemId)
                .HasDefaultValueSql("((0))")
                .HasComment("reference for Job Card ID")
                .HasColumnName("jcItemID");
            entity.Property(e => e.Linenumber).HasColumnName("linenumber");
            entity.Property(e => e.Listposition)
                .HasDefaultValueSql("((0))")
                .HasComment("Quotes/orders can have the position of their items reordered. The first item has listposition 0, the second 1, etc.")
                .HasColumnName("listposition");
            entity.Property(e => e.Occomments)
                .HasColumnType("ntext")
                .HasColumnName("occomments");
            entity.Property(e => e.Ocdetailcode)
                .HasMaxLength(100)
                .HasColumnName("ocdetailcode");
            entity.Property(e => e.Ocdetailgst).HasColumnName("ocdetailgst");
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
                .HasComment("stores the id of the pricebreak from csversion1.dbo.myPricebreaks that was used to create this ocdetail")
                .HasColumnName("pricebreakid");
            entity.Property(e => e.QtyAvailable)
                .HasDefaultValueSql("((0))")
                .HasColumnName("qtyAvailable");
            entity.Property(e => e.QtyBackOrder)
                .HasDefaultValueSql("((0))")
                .HasColumnName("qtyBackOrder");
            entity.Property(e => e.Qtydifference)
                .HasComment("In the event that an order could not be met at the desired quantity, qtydifferent will tell you how much this particular item fell short (if at all). If qtynotmet = 0 then it means this item could be back ordered, and this field records how many were moved onto back order. If the item cannot be backordered, this should be the difference between ocdetailqty and stockavailable.")
                .HasColumnName("qtydifference");
            entity.Property(e => e.Qtynotmet)
                .HasComment("0/1 determines if the order could not be fulfilled as requested. Either some items had to be moved to back ordered or the item qty fell short.")
                .HasColumnName("qtynotmet");
            entity.Property(e => e.Qtyreceived)
                .HasDefaultValueSql("((0))")
                .HasColumnName("qtyreceived");
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
            entity.Property(e => e.Returnrequest)
                .HasDefaultValueSql("((0))")
                .HasColumnName("returnrequest");
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
            entity.Property(e => e.ShippingClass)
                .HasDefaultValueSql("((1))")
                .HasComment("Refer to ShippingClass (id matches this int) . AFL_CourierMethods table will contain this ID against the shipping method");
            entity.Property(e => e.Suffix)
                .HasMaxLength(10)
                .HasComment("The suffix of the quantity and fields relating to prices of myDecoration records. Has 5 possible values: nothing/blank, 2 or 3 or 4 or 5")
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

        modelBuilder.Entity<OnlineAccountsList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("online_accounts_list");

            entity.Property(e => e.AccId).HasColumnName("accID");
            entity.Property(e => e.Acccode)
                .HasMaxLength(30)
                .HasColumnName("acccode");
            entity.Property(e => e.AccessStatus)
                .HasMaxLength(10)
                .HasColumnName("accessStatus");
            entity.Property(e => e.Accesslevel).HasColumnName("accesslevel");
            entity.Property(e => e.Activestatus)
                .HasMaxLength(12)
                .HasColumnName("activestatus");
            entity.Property(e => e.BillingAddress)
                .HasMaxLength(100)
                .HasColumnName("billing_address");
            entity.Property(e => e.BillingAttention)
                .HasMaxLength(50)
                .HasColumnName("billing_attention");
            entity.Property(e => e.BillingCountry)
                .HasMaxLength(50)
                .HasColumnName("billing_country");
            entity.Property(e => e.BillingEmail)
                .HasMaxLength(80)
                .HasColumnName("billing_email");
            entity.Property(e => e.BillingId).HasColumnName("billing_id");
            entity.Property(e => e.BillingPhone)
                .HasMaxLength(50)
                .HasColumnName("billing_phone");
            entity.Property(e => e.BillingPostcode)
                .HasMaxLength(12)
                .HasColumnName("billing_postcode");
            entity.Property(e => e.BillingState)
                .HasMaxLength(80)
                .HasColumnName("billing_state");
            entity.Property(e => e.BillingSuburb)
                .HasMaxLength(80)
                .HasColumnName("billing_suburb");
            entity.Property(e => e.Caninvoice).HasColumnName("caninvoice");
            entity.Property(e => e.Catalogueid).HasColumnName("catalogueid");
            entity.Property(e => e.ClientId).HasColumnName("clientID");
            entity.Property(e => e.Companyname)
                .HasMaxLength(250)
                .HasColumnName("companyname");
            entity.Property(e => e.ContactAddress)
                .HasMaxLength(100)
                .HasColumnName("contact_address");
            entity.Property(e => e.ContactCompany)
                .HasMaxLength(250)
                .HasColumnName("contact_company");
            entity.Property(e => e.ContactCountry)
                .HasMaxLength(50)
                .HasColumnName("contact_country");
            entity.Property(e => e.ContactEmail)
                .HasMaxLength(80)
                .HasColumnName("contact_email");
            entity.Property(e => e.ContactFax)
                .HasMaxLength(50)
                .HasColumnName("contact_fax");
            entity.Property(e => e.ContactFname)
                .HasMaxLength(50)
                .HasColumnName("contact_fname");
            entity.Property(e => e.ContactLname)
                .HasMaxLength(50)
                .HasColumnName("contact_lname");
            entity.Property(e => e.ContactOptAddress1)
                .HasMaxLength(100)
                .HasColumnName("contact_opt_address1");
            entity.Property(e => e.ContactPhone)
                .HasMaxLength(50)
                .HasColumnName("contact_phone");
            entity.Property(e => e.ContactPostcode)
                .HasMaxLength(12)
                .HasColumnName("contact_postcode");
            entity.Property(e => e.ContactState)
                .HasMaxLength(80)
                .HasColumnName("contact_state");
            entity.Property(e => e.ContactSuburb)
                .HasMaxLength(80)
                .HasColumnName("contact_suburb");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .HasColumnName("createby");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.Credithold)
                .HasMaxLength(15)
                .HasColumnName("credithold");
            entity.Property(e => e.Currency)
                .HasMaxLength(12)
                .HasColumnName("currency");
            entity.Property(e => e.DeliveryAddress)
                .HasMaxLength(100)
                .HasColumnName("delivery_address");
            entity.Property(e => e.DeliveryAttention)
                .HasMaxLength(50)
                .HasColumnName("delivery_attention");
            entity.Property(e => e.DeliveryCompany)
                .HasMaxLength(250)
                .HasColumnName("delivery_company");
            entity.Property(e => e.DeliveryCountry)
                .HasMaxLength(50)
                .HasColumnName("delivery_country");
            entity.Property(e => e.DeliveryEmail)
                .HasMaxLength(80)
                .HasColumnName("delivery_email");
            entity.Property(e => e.DeliveryId).HasColumnName("delivery_id");
            entity.Property(e => e.DeliveryPhone)
                .HasMaxLength(50)
                .HasColumnName("delivery_phone");
            entity.Property(e => e.DeliveryPostcode)
                .HasMaxLength(12)
                .HasColumnName("delivery_postcode");
            entity.Property(e => e.DeliveryState)
                .HasMaxLength(80)
                .HasColumnName("delivery_state");
            entity.Property(e => e.DeliverySuburb)
                .HasMaxLength(80)
                .HasColumnName("delivery_suburb");
            entity.Property(e => e.Encryptedpw)
                .HasMaxLength(40)
                .HasColumnName("encryptedpw");
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
            entity.Property(e => e.Oktospam)
                .HasMaxLength(4)
                .HasColumnName("oktospam");
            entity.Property(e => e.PartnerStatus)
                .HasMaxLength(12)
                .HasColumnName("partner_status");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.Position)
                .HasMaxLength(120)
                .HasColumnName("position");
            entity.Property(e => e.PriceProfileId).HasColumnName("priceProfileID");
            entity.Property(e => e.Priceprofile)
                .HasMaxLength(50)
                .HasColumnName("priceprofile");
            entity.Property(e => e.TradingTerms)
                .HasMaxLength(20)
                .HasColumnName("tradingTerms");
            entity.Property(e => e.Tradingname)
                .HasMaxLength(250)
                .HasColumnName("tradingname");
            entity.Property(e => e.UseEncryption).HasColumnName("use_encryption");
            entity.Property(e => e.Username)
                .HasMaxLength(150)
                .HasColumnName("username");
            entity.Property(e => e.WebAccId).HasColumnName("webAccID");
        });

        modelBuilder.Entity<OrderSummaryReport>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.ToTable("orderSummaryReport");

            entity.HasIndex(e => e.JobId, "Order Number")
                .IsUnique()
                .IsClustered()
                .HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CompletedStudioCost)
                .HasDefaultValueSql("((0))")
                .HasComment("AUD")
                .HasColumnName("completedStudioCost");
            entity.Property(e => e.Credittotal)
                .HasDefaultValueSql("((0))")
                .HasComment("AUD")
                .HasColumnName("credittotal");
            entity.Property(e => e.Credittotalexc)
                .HasDefaultValueSql("((0))")
                .HasComment("AUD")
                .HasColumnName("credittotalexc");
            entity.Property(e => e.Freightcost)
                .HasDefaultValueSql("((0))")
                .HasComment("AUD")
                .HasColumnName("freightcost");
            entity.Property(e => e.Freightcostexc)
                .HasDefaultValueSql("((0))")
                .HasComment("AUD")
                .HasColumnName("freightcostexc");
            entity.Property(e => e.InvoiceAdjexc)
                .HasDefaultValueSql("((0))")
                .HasComment("AUD")
                .HasColumnName("invoiceAdjexc");
            entity.Property(e => e.Invoicetotal)
                .HasDefaultValueSql("((0))")
                .HasComment("AUD")
                .HasColumnName("invoicetotal");
            entity.Property(e => e.Invoicetotalexc)
                .HasDefaultValueSql("((0))")
                .HasComment("AUD")
                .HasColumnName("invoicetotalexc");
            entity.Property(e => e.JobId).HasColumnName("jobID");
            entity.Property(e => e.OrderAdjexc)
                .HasDefaultValueSql("((0))")
                .HasComment("AUD")
                .HasColumnName("orderAdjexc");
            entity.Property(e => e.Ordertotal)
                .HasDefaultValueSql("((0))")
                .HasComment("AUD")
                .HasColumnName("ordertotal");
            entity.Property(e => e.Ordertotalexc)
                .HasDefaultValueSql("((0))")
                .HasComment("AUD")
                .HasColumnName("ordertotalexc");
            entity.Property(e => e.PoAdjexc)
                .HasDefaultValueSql("((0))")
                .HasComment("AUD")
                .HasColumnName("poAdjexc");
            entity.Property(e => e.Pototal)
                .HasDefaultValueSql("((0))")
                .HasComment("AUD")
                .HasColumnName("pototal");
            entity.Property(e => e.Pototalexc)
                .HasDefaultValueSql("((0))")
                .HasComment("AUD")
                .HasColumnName("pototalexc");
            entity.Property(e => e.ReceiptTotal)
                .HasDefaultValueSql("((0))")
                .HasComment("AUD - Payment received from client")
                .HasColumnName("receiptTotal");
            entity.Property(e => e.Studiocost)
                .HasDefaultValueSql("((0))")
                .HasComment("AUD")
                .HasColumnName("studiocost");
            entity.Property(e => e.SupCredittotal)
                .HasDefaultValueSql("((0))")
                .HasComment("AUD")
                .HasColumnName("supCredittotal");
            entity.Property(e => e.SupCredittotalexc)
                .HasDefaultValueSql("((0))")
                .HasComment("AUD")
                .HasColumnName("supCredittotalexc");
            entity.Property(e => e.SupInvoiceAdjexc)
                .HasDefaultValueSql("((0))")
                .HasComment("AUD")
                .HasColumnName("supInvoiceAdjexc");
            entity.Property(e => e.SupInvoicetotal)
                .HasDefaultValueSql("((0))")
                .HasComment("AUD")
                .HasColumnName("supInvoicetotal");
            entity.Property(e => e.SupInvoicetotalexc)
                .HasDefaultValueSql("((0))")
                .HasComment("AUD")
                .HasColumnName("supInvoicetotalexc");
            entity.Property(e => e.Systemnote)
                .HasMaxLength(1000)
                .HasColumnName("systemnote");
        });

        modelBuilder.Entity<Orderconf>(entity =>
        {
            entity.HasKey(e => e.Ocid);

            entity.ToTable("orderconf", tb =>
                {
                    tb.HasTrigger("closedorder");
                    tb.HasTrigger("invoice_upon_processed");
                    tb.HasTrigger("order_summary_update");
                    tb.HasTrigger("update_order_summary");
                });

            entity.HasIndex(e => new { e.Status, e.Jobstatus, e.SeasonId }, "IX_OrderConf_Status")
                .IsDescending(true, true, false)
                .HasFillFactor(90);

            entity.HasIndex(e => e.Status, "IX_OrderReport");

            entity.HasIndex(e => e.SubmitDate, "IX_orderconf").HasFillFactor(90);

            entity.HasIndex(e => e.Cid, "cid");

            entity.HasIndex(e => e.ClientId, "clientid").HasFillFactor(90);

            entity.HasIndex(e => new { e.DelStatus, e.OrderGroup, e.GlId }, "del_status").HasFillFactor(90);

            entity.HasIndex(e => e.OrderStatus, "f_OrderStatus").HasFilter("([OrderStatus] IN ((4), (5), (6), (7)))");

            entity.HasIndex(e => e.PoNumber, "ponumber");

            entity.Property(e => e.Ocid)
                .HasComment("order confirmation id")
                .HasColumnName("ocid");
            entity.Property(e => e.Abn)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("abn");
            entity.Property(e => e.ActionCheckedBy)
                .HasDefaultValueSql("((0))")
                .HasComment("staff id that action was checked by")
                .HasColumnName("actionCheckedBy");
            entity.Property(e => e.ActionCheckedDate)
                .HasComment("Date that action was checked on")
                .HasColumnType("datetime")
                .HasColumnName("actionCheckedDate");
            entity.Property(e => e.ActionStatus)
                .HasMaxLength(12)
                .HasDefaultValueSql("('current')")
                .HasComment("Sales WIP status - 'current' or 'checked'")
                .HasColumnName("actionStatus");
            entity.Property(e => e.Addr1)
                .HasMaxLength(150)
                .HasDefaultValueSql("('')")
                .HasColumnName("addr1");
            entity.Property(e => e.Addr2)
                .HasMaxLength(80)
                .HasDefaultValueSql("('')")
                .HasColumnName("addr2");
            entity.Property(e => e.Addr3)
                .HasMaxLength(80)
                .HasDefaultValueSql("('')")
                .HasColumnName("addr3");
            entity.Property(e => e.AlreadyNotified)
                .HasDefaultValueSql("((0))")
                .HasComment("idea is we only want to send orderconfirmation once (and send/save sales stats once) so if value changes to 1 after we save it the first time.")
                .HasColumnName("already_notified");
            entity.Property(e => e.Ariba)
                .HasMaxLength(5)
                .HasColumnName("ariba");
            entity.Property(e => e.Assignedto)
                .HasDefaultValueSql("((0))")
                .HasColumnName("assignedto");
            entity.Property(e => e.AudtoHkdrate)
                .HasDefaultValueSql("((5.2))")
                .HasColumnName("AUDtoHKDRate");
            entity.Property(e => e.BAbn)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')")
                .IsFixedLength()
                .HasColumnName("b_abn");
            entity.Property(e => e.BAddr1)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')")
                .HasColumnName("b_addr1");
            entity.Property(e => e.BAddr2)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')")
                .HasColumnName("b_addr2");
            entity.Property(e => e.BAddr3)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')")
                .HasColumnName("b_addr3");
            entity.Property(e => e.BAddrid).HasColumnName("b_addrid");
            entity.Property(e => e.BAttention)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasColumnName("b_attention");
            entity.Property(e => e.BCompanyname)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')")
                .HasColumnName("b_companyname");
            entity.Property(e => e.BCountry)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasColumnName("b_country");
            entity.Property(e => e.BEmail)
                .HasMaxLength(100)
                .HasColumnName("b_email");
            entity.Property(e => e.BFax)
                .HasMaxLength(20)
                .HasColumnName("b_fax");
            entity.Property(e => e.BFname)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasColumnName("b_fname");
            entity.Property(e => e.BLname)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasColumnName("b_lname");
            entity.Property(e => e.BMobile)
                .HasMaxLength(20)
                .HasColumnName("b_mobile");
            entity.Property(e => e.BPhone)
                .HasMaxLength(50)
                .HasColumnName("b_phone");
            entity.Property(e => e.BPostcode)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasColumnName("b_postcode");
            entity.Property(e => e.CTotal)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("cTotal");
            entity.Property(e => e.CTotalExc)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("cTotalExc");
            entity.Property(e => e.CancelledBy).HasColumnName("cancelledBy");
            entity.Property(e => e.CancelledDate)
                .HasColumnType("datetime")
                .HasColumnName("cancelledDate");
            entity.Property(e => e.Catalogueid)
                .HasDefaultValueSql("((213))")
                .HasColumnName("catalogueid");
            entity.Property(e => e.Cid)
                .HasDefaultValueSql("((1))")
                .HasComment("Company ID: 1-TPF AUS, 2- TPF UK, 3-TPF New Zealand")
                .HasColumnName("cid");
            entity.Property(e => e.ClientId)
                .HasDefaultValueSql("((0))")
                .HasComment("")
                .HasColumnName("clientID");
            entity.Property(e => e.ClientReference)
                .HasMaxLength(120)
                .HasDefaultValueSql("('')")
                .HasColumnName("clientReference");
            entity.Property(e => e.ClosedDate)
                .HasColumnType("datetime")
                .HasColumnName("closedDate");
            entity.Property(e => e.Closedby).HasColumnName("closedby");
            entity.Property(e => e.ClubId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("clubID");
            entity.Property(e => e.Companyname)
                .HasMaxLength(250)
                .HasDefaultValueSql("('')")
                .HasColumnName("companyname");
            entity.Property(e => e.Completionstatus)
                .HasMaxLength(3)
                .HasDefaultValueSql("('no')")
                .HasColumnName("completionstatus");
            entity.Property(e => e.Costcentre)
                .HasMaxLength(100)
                .HasColumnName("costcentre");
            entity.Property(e => e.CostingNotes)
                .HasDefaultValueSql("('')")
                .HasColumnType("text")
                .HasColumnName("costingNotes");
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .HasDefaultValueSql("('Australia')")
                .HasColumnName("country");
            entity.Property(e => e.Credittotalexcgst)
                .HasDefaultValueSql("((0))")
                .HasComment("created on 05082008")
                .HasColumnName("credittotalexcgst");
            entity.Property(e => e.Currency)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'AUD')")
                .HasColumnName("currency");
            entity.Property(e => e.DAddr1)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')")
                .HasColumnName("d_addr1");
            entity.Property(e => e.DAddr2)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')")
                .HasColumnName("d_addr2");
            entity.Property(e => e.DAddr3)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')")
                .HasColumnName("d_addr3");
            entity.Property(e => e.DAddrid).HasColumnName("d_addrid");
            entity.Property(e => e.DAttention)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasColumnName("d_attention");
            entity.Property(e => e.DCompanyname)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')")
                .HasColumnName("d_companyname");
            entity.Property(e => e.DCountry)
                .HasMaxLength(500)
                .HasDefaultValueSql("('Australia')")
                .HasColumnName("d_country");
            entity.Property(e => e.DEmail)
                .HasMaxLength(500)
                .HasColumnName("d_email");
            entity.Property(e => e.DFax)
                .HasMaxLength(500)
                .HasColumnName("d_fax");
            entity.Property(e => e.DFname)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')")
                .HasColumnName("d_fname");
            entity.Property(e => e.DLname)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')")
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
                .HasDefaultValueSql("('')")
                .HasColumnName("d_postcode");
            entity.Property(e => e.DStatus)
                .HasMaxLength(50)
                .HasDefaultValueSql("('new')")
                .HasColumnName("d_status");
            entity.Property(e => e.DWhid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("d_whid");
            entity.Property(e => e.DelStatus)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'new')")
                .HasComment("Delivery Status: Fully Delivered, Partly Delivered, New")
                .HasColumnName("del_status");
            entity.Property(e => e.DelStatusClosedBy).HasColumnName("del_status_closedBy");
            entity.Property(e => e.DelStatusClosedDate)
                .HasColumnType("datetime")
                .HasColumnName("del_status_closedDate");
            entity.Property(e => e.Deldetails)
                .HasDefaultValueSql("(N'')")
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
            entity.Property(e => e.ErrorCount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("errorCount");
            entity.Property(e => e.Exchangerate)
                .HasDefaultValueSql("((1))")
                .HasColumnName("exchangerate");
            entity.Property(e => e.Fax)
                .HasMaxLength(25)
                .HasColumnName("fax");
            entity.Property(e => e.FinanceJobComment)
                .HasMaxLength(2000)
                .HasColumnName("financeJobComment");
            entity.Property(e => e.FinanceMargin)
                .HasDefaultValueSql("((0))")
                .HasColumnName("finance_margin");
            entity.Property(e => e.Fname)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasColumnName("fname");
            entity.Property(e => e.Fob)
                .HasMaxLength(10)
                .HasDefaultValueSql("('no')")
                .HasColumnName("FOB");
            entity.Property(e => e.FrcstMargin)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("frcstMargin");
            entity.Property(e => e.FulfilmentId)
                .HasMaxLength(200)
                .HasColumnName("FulfilmentID");
            entity.Property(e => e.GlCategory)
                .HasMaxLength(5)
                .HasDefaultValueSql("('')")
                .HasColumnName("gl_category");
            entity.Property(e => e.GlId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("glID");
            entity.Property(e => e.GlOption)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasColumnName("gl_option");
            entity.Property(e => e.GlOrderIndex)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("gl_orderIndex");
            entity.Property(e => e.GlSubgroup)
                .HasMaxLength(30)
                .HasColumnName("gl_subgroup");
            entity.Property(e => e.Gstrate)
                .HasDefaultValueSql("((10.00))")
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("gstrate");
            entity.Property(e => e.Handledby)
                .HasComment("")
                .HasColumnName("handledby");
            entity.Property(e => e.HkJobClosedBy).HasColumnName("hkJobClosedBy");
            entity.Property(e => e.HkJobClosingDate)
                .HasColumnType("datetime")
                .HasColumnName("hkJobClosingDate");
            entity.Property(e => e.Hkjobstatus)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'opened')")
                .HasColumnName("hkjobstatus");
            entity.Property(e => e.Hkorderstatus)
                .HasMaxLength(20)
                .HasDefaultValueSql("('processed')")
                .HasComment("Hong Kong Order Status: Processed, pending, full-invoiced, part-invoiced, cancelled")
                .HasColumnName("HKorderstatus");
            entity.Property(e => e.HoldOrder)
                .HasMaxLength(50)
                .HasColumnName("holdOrder");
            entity.Property(e => e.IOrderTotal).HasColumnName("iOrderTotal");
            entity.Property(e => e.IOrderTotalExc).HasColumnName("iOrderTotalExc");
            entity.Property(e => e.ITotal)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("iTotal");
            entity.Property(e => e.ITotalExc)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("iTotalExc");
            entity.Property(e => e.Importref)
                .HasMaxLength(50)
                .HasColumnName("importref");
            entity.Property(e => e.Invoicetotal)
                .HasDefaultValueSql("((0))")
                .HasColumnName("invoicetotal");
            entity.Property(e => e.Invoicetotalexcgst)
                .HasDefaultValueSql("((0))")
                .HasComment("created on 05082008")
                .HasColumnName("invoicetotalexcgst");
            entity.Property(e => e.IsDuplicate)
                .HasMaxLength(50)
                .HasColumnName("isDuplicate");
            entity.Property(e => e.IsMagento)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isMagento");
            entity.Property(e => e.IsSynced)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isSynced");
            entity.Property(e => e.Joblastchanged)
                .HasColumnType("datetime")
                .HasColumnName("joblastchanged");
            entity.Property(e => e.Jobstatus)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'closed')")
                .HasComment("Job status : opened, closed.")
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
                .HasDefaultValueSql("('')")
                .HasColumnName("lname");
            entity.Property(e => e.MembershipNumber).HasMaxLength(50);
            entity.Property(e => e.Mobile)
                .HasMaxLength(25)
                .HasDefaultValueSql("('')")
                .HasColumnName("mobile");
            entity.Property(e => e.Notes)
                .HasColumnType("ntext")
                .HasColumnName("notes");
            entity.Property(e => e.Oclastupdated)
                .HasColumnType("datetime")
                .HasColumnName("oclastupdated");
            entity.Property(e => e.Ocupdatedby)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ocupdatedby");
            entity.Property(e => e.Onhold)
                .HasDefaultValueSql("((0))")
                .HasComment("onhold =1 normal=0")
                .HasColumnName("onhold");
            entity.Property(e => e.OnlineOrder)
                .HasMaxLength(50)
                .HasDefaultValueSql("('no')")
                .HasColumnName("onlineOrder");
            entity.Property(e => e.OpenedBy)
                .HasDefaultValueSql("((0))")
                .HasColumnName("openedBy");
            entity.Property(e => e.OpenedDate)
                .HasColumnType("datetime")
                .HasColumnName("openedDate");
            entity.Property(e => e.OrderCategoryId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("order_category_id");
            entity.Property(e => e.OrderGroup)
                .HasMaxLength(100)
                .HasDefaultValueSql("('External')")
                .HasComment("For general ledger - Internal or External")
                .HasColumnName("order_group");
            entity.Property(e => e.OrderStatus)
                .HasDefaultValueSql("((1))")
                .HasComment("1 : Normal,2 : Part Returned , 3 : Full Returned,  4 : Error Delivery Addess ");
            entity.Property(e => e.OrderStatusNote).HasMaxLength(255);
            entity.Property(e => e.OrderdRole).HasMaxLength(50);
            entity.Property(e => e.Ordertotal)
                .HasDefaultValueSql("((0))")
                .HasComment("Order Total including GST")
                .HasColumnName("ordertotal");
            entity.Property(e => e.Ordertotalexc)
                .HasDefaultValueSql("((0))")
                .HasComment("Order Total Exc GST")
                .HasColumnName("ordertotalexc");
            entity.Property(e => e.OrgOrderTotal)
                .HasDefaultValueSql("((0))")
                .HasColumnName("orgOrderTotal");
            entity.Property(e => e.OsNoteCheck)
                .HasDefaultValueSql("((0))")
                .HasComment("OS WIP note check - 1 new note, 0 no note")
                .HasColumnName("osNoteCheck");
            entity.Property(e => e.Payoption)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasColumnName("payoption");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasColumnName("phone");
            entity.Property(e => e.PlGroup)
                .HasDefaultValueSql("((0))")
                .HasColumnName("plGroup");
            entity.Property(e => e.PoCostCentre).HasMaxLength(250);
            entity.Property(e => e.PoNumber)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("poNumber");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .HasColumnName("position");
            entity.Property(e => e.Postcode)
                .HasMaxLength(12)
                .HasDefaultValueSql("('')")
                .HasColumnName("postcode");
            entity.Property(e => e.ProMarketId).HasColumnName("proMarketID");
            entity.Property(e => e.ProcessDate)
                .HasColumnType("datetime")
                .HasColumnName("processDate");
            entity.Property(e => e.Processedby)
                .HasMaxLength(60)
                .HasComment("Processed by staffID")
                .HasColumnName("processedby");
            entity.Property(e => e.Productionstaff)
                .HasMaxLength(50)
                .HasColumnName("productionstaff");
            entity.Property(e => e.ProfileId).HasColumnName("profileID");
            entity.Property(e => e.ProgramId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("programID");
            entity.Property(e => e.Projectid)
                .HasMaxLength(50)
                .HasComment("The myProjectid from myProject")
                .HasColumnName("projectid");
            entity.Property(e => e.PromotionName)
                .HasMaxLength(120)
                .HasDefaultValueSql("('')")
                .HasComment("Promotion Name")
                .HasColumnName("promotionName");
            entity.Property(e => e.RateEntityToAud).HasColumnName("RateEntityToAUD");
            entity.Property(e => e.RawId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("rawID");
            entity.Property(e => e.ReasonCode).HasMaxLength(250);
            entity.Property(e => e.ReportDisplay)
                .HasMaxLength(10)
                .HasDefaultValueSql("('yes')")
                .HasColumnName("reportDisplay");
            entity.Property(e => e.Reportdate)
                .HasColumnType("datetime")
                .HasColumnName("reportdate");
            entity.Property(e => e.RoyaltyContract).HasColumnName("royaltyContract");
            entity.Property(e => e.SaleType)
                .HasDefaultValueSql("((0))")
                .HasComment("0: null\r\n1: Sponsors\r\n2: Dealers\r\n3:  Partners\r\n4: Holden HQ")
                .HasColumnName("saleType");
            entity.Property(e => e.SalesCheckedDate)
                .HasColumnType("datetime")
                .HasColumnName("salesCheckedDate");
            entity.Property(e => e.SalesWipStatus)
                .HasMaxLength(20)
                .HasDefaultValueSql("('current')")
                .HasColumnName("salesWipStatus");
            entity.Property(e => e.Sendwithgoods)
                .HasMaxLength(50)
                .HasColumnName("sendwithgoods");
            entity.Property(e => e.Showsubtotal)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'yes')")
                .HasColumnName("showsubtotal");
            entity.Property(e => e.Singleinvoice).HasColumnName("singleinvoice");
            entity.Property(e => e.Source)
                .HasMaxLength(50)
                .HasColumnName("source");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'pending')")
                .HasComment("Invoice Status: full-invoiced, part-invoiced, processed, pending,  Awaiting Payment, cancelled, closed")
                .HasColumnName("status");
            entity.Property(e => e.SubmitDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("submitDate");
            entity.Property(e => e.SyncDate)
                .HasColumnType("datetime")
                .HasColumnName("syncDate");
            entity.Property(e => e.Tobeinvoiced)
                .HasMaxLength(10)
                .HasDefaultValueSql("('yes')")
                .HasColumnName("tobeinvoiced");
            entity.Property(e => e.Totalcost)
                .HasMaxLength(15)
                .HasColumnName("totalcost");
            entity.Property(e => e.TpforderId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("TPFOrderID");
            entity.Property(e => e.Trackingcode)
                .HasMaxLength(50)
                .HasColumnName("trackingcode");
            entity.Property(e => e.Tradeterms)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'7 Days')")
                .HasColumnName("tradeterms");
            entity.Property(e => e.Tradingname)
                .HasMaxLength(250)
                .HasDefaultValueSql("('')")
                .HasComment("Trading Name")
                .HasColumnName("tradingname");
            entity.Property(e => e.TxnRef)
                .HasMaxLength(50)
                .HasColumnName("txnRef");
            entity.Property(e => e.UsdtoHkdrate)
                .HasDefaultValueSql("((0.12820512000000001))")
                .HasColumnName("USDtoHKDRate");
            entity.Property(e => e.Vendorno)
                .HasMaxLength(50)
                .HasColumnName("vendorno");
            entity.Property(e => e.Visible)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'checked')")
                .HasColumnName("visible");
            entity.Property(e => e.Webstoreno)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasColumnName("webstoreno");
            entity.Property(e => e.Whid)
                .HasDefaultValueSql("((1))")
                .HasColumnName("whid");
            entity.Property(e => e.WipComment)
                .HasMaxLength(4000)
                .HasComment("sales WIP comments")
                .HasColumnName("wipComment");
            entity.Property(e => e.WipFlag)
                .HasDefaultValueSql("((10))")
                .HasColumnName("wipFlag");
            entity.Property(e => e.WipNote)
                .HasMaxLength(500)
                .HasColumnName("wipNote");
        });

        modelBuilder.Entity<OrderconfExtrainfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("orderconf_extrainfo");

            entity.HasIndex(e => e.Ordernumber, "IX_orderconf_extrainfo");

            entity.Property(e => e.Field)
                .HasMaxLength(50)
                .HasColumnName("field");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ordernumber).HasColumnName("ordernumber");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<OrdersLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_onhold_log");

            entity.ToTable("orders_log");

            entity.HasIndex(e => e.Ocid, "ocid").HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Ocid).HasColumnName("ocid");
            entity.Property(e => e.Reason)
                .HasColumnType("ntext")
                .HasColumnName("reason");
            entity.Property(e => e.Who2blame).HasColumnName("who2blame");
        });

        modelBuilder.Entity<ParticipantProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Particip__3214EC0759BFDA6D");

            entity.ToTable("ParticipantProduct");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.ProductId).HasMaxLength(200);
            entity.Property(e => e.ProductName).HasMaxLength(100);
            entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PartnerAccount>(entity =>
        {
            entity.HasKey(e => e.AccId);

            entity.ToTable("partnerAccount");

            entity.Property(e => e.AccId).HasColumnName("accID");
            entity.Property(e => e.Abn)
                .HasMaxLength(15)
                .HasComment("Partner Account ABN Number")
                .HasColumnName("abn");
            entity.Property(e => e.AccLocation)
                .HasMaxLength(18)
                .HasDefaultValueSql("('domestic')")
                .HasComment("Account Location: domestic/overseas")
                .HasColumnName("accLocation");
            entity.Property(e => e.Acccode)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')")
                .HasComment("Account Code of Client")
                .HasColumnName("acccode");
            entity.Property(e => e.Accnote)
                .HasComment("Account Note")
                .HasColumnType("text")
                .HasColumnName("accnote");
            entity.Property(e => e.ActiveStatusUpdateBy)
                .HasDefaultValueSql("((0))")
                .HasColumnName("activeStatusUpdateBy");
            entity.Property(e => e.ActiveStatusUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("activeStatusUpdateDate");
            entity.Property(e => e.Activestatus)
                .HasMaxLength(12)
                .HasDefaultValueSql("('pending')")
                .HasComment("Active Status: approved/declined/pending")
                .HasColumnName("activestatus");
            entity.Property(e => e.ApprovalComment)
                .HasMaxLength(800)
                .HasColumnName("approvalComment");
            entity.Property(e => e.Companycode)
                .HasDefaultValueSql("((1))")
                .HasColumnName("companycode");
            entity.Property(e => e.Companyname)
                .HasMaxLength(250)
                .HasColumnName("companyname");
            entity.Property(e => e.Contactperson)
                .HasDefaultValueSql("((0))")
                .HasComment("company sales person - id")
                .HasColumnName("contactperson");
            entity.Property(e => e.Createby)
                .HasDefaultValueSql("((0))")
                .HasColumnName("createby");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.CreditLimits)
                .HasDefaultValueSql("((0))")
                .HasColumnName("creditLimits");
            entity.Property(e => e.CreditLimitsBypass)
                .HasMaxLength(12)
                .HasDefaultValueSql("('no')")
                .HasColumnName("creditLimitsBypass");
            entity.Property(e => e.Credithold)
                .HasMaxLength(15)
                .HasDefaultValueSql("('')")
                .HasColumnName("credithold");
            entity.Property(e => e.CreditholdUpdateBy).HasColumnName("creditholdUpdateBy");
            entity.Property(e => e.CreditholdUpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("creditholdUpdateDate");
            entity.Property(e => e.Currency)
                .HasMaxLength(12)
                .HasColumnName("currency");
            entity.Property(e => e.Customertype)
                .HasMaxLength(35)
                .HasComment("Type of Customer: END USER/RESELLER")
                .HasColumnName("customertype");
            entity.Property(e => e.InvEmail)
                .HasMaxLength(150)
                .HasDefaultValueSql("('')")
                .HasComment("Email where invoices to be sent")
                .HasColumnName("inv_email");
            entity.Property(e => e.Lastsentstatement)
                .HasMaxLength(120)
                .HasColumnName("lastsentstatement");
            entity.Property(e => e.Lastupdate)
                .HasComment("date for last update in the partner account")
                .HasColumnType("datetime")
                .HasColumnName("lastupdate");
            entity.Property(e => e.Lastupdateby)
                .HasDefaultValueSql("((0))")
                .HasColumnName("lastupdateby");
            entity.Property(e => e.Password)
                .HasMaxLength(35)
                .HasColumnName("password");
            entity.Property(e => e.PoRequired)
                .HasMaxLength(12)
                .HasDefaultValueSql("('no')")
                .HasComment("PO Required: Yes/No")
                .HasColumnName("poRequired");
            entity.Property(e => e.RemEmail)
                .HasMaxLength(150)
                .HasColumnName("rem_email");
            entity.Property(e => e.Remarks)
                .HasMaxLength(800)
                .HasColumnName("remarks");
            entity.Property(e => e.SendInvToPurchaser)
                .HasDefaultValueSql("((0))")
                .HasColumnName("send_inv_to_purchaser");
            entity.Property(e => e.SendInvoiceReminder)
                .HasMaxLength(5)
                .HasDefaultValueSql("('yes')")
                .HasColumnName("sendInvoiceReminder");
            entity.Property(e => e.SendRemToPurchaser).HasColumnName("send_rem_to_purchaser");
            entity.Property(e => e.SendStatement)
                .HasMaxLength(8)
                .HasDefaultValueSql("('no')")
                .HasComment("Send Statement: Yes/No")
                .HasColumnName("sendStatement");
            entity.Property(e => e.Shippingtype)
                .HasMaxLength(35)
                .HasColumnName("shippingtype");
            entity.Property(e => e.StCountry)
                .HasMaxLength(50)
                .HasColumnName("st_country");
            entity.Property(e => e.StEmail)
                .HasMaxLength(120)
                .HasColumnName("st_email");
            entity.Property(e => e.StPostcode)
                .HasMaxLength(12)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("st_postcode");
            entity.Property(e => e.StState)
                .HasMaxLength(80)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("st_state");
            entity.Property(e => e.StStreet)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("st_street");
            entity.Property(e => e.StSuburb)
                .HasMaxLength(80)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("st_suburb");
            entity.Property(e => e.StatementEmail)
                .HasMaxLength(120)
                .HasColumnName("statement_email");
            entity.Property(e => e.StatementsentBy).HasColumnName("statementsent_by");
            entity.Property(e => e.Status)
                .HasMaxLength(12)
                .HasDefaultValueSql("(N'current')")
                .HasComment("Status: current/cancelled/removed")
                .HasColumnName("status");
            entity.Property(e => e.TagName)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')")
                .HasComment("client's tag name")
                .HasColumnName("tagName");
            entity.Property(e => e.TradingTerms)
                .HasMaxLength(20)
                .HasDefaultValueSql("('30days')")
                .HasComment("Trading Tems: PREPAYMENT/7 days/14 days/30 days/60 days/lc/TT")
                .HasColumnName("tradingTerms");
            entity.Property(e => e.Tradingname)
                .HasMaxLength(250)
                .HasColumnName("tradingname");
            entity.Property(e => e.Vendorno)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasColumnName("vendorno");
            entity.Property(e => e.Website)
                .HasMaxLength(80)
                .HasColumnName("website");
        });

        modelBuilder.Entity<PartnerAddress>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("partnerAddresses");

            entity.Property(e => e.AccId).HasColumnName("accID");
            entity.Property(e => e.AddrId).HasColumnName("addrID");
            entity.Property(e => e.Country)
                .HasMaxLength(120)
                .HasColumnName("country");
            entity.Property(e => e.Createby).HasColumnName("createby");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.Postcode)
                .HasMaxLength(20)
                .HasColumnName("postcode");
            entity.Property(e => e.State)
                .HasMaxLength(80)
                .HasColumnName("state");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasColumnName("status");
            entity.Property(e => e.Street)
                .HasMaxLength(250)
                .HasColumnName("street");
            entity.Property(e => e.Suburb)
                .HasMaxLength(100)
                .HasColumnName("suburb");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .HasColumnName("type");
        });

        modelBuilder.Entity<PartnerTradingName>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("partnerTradingNames");

            entity.Property(e => e.AccId).HasColumnName("accID");
            entity.Property(e => e.Createby).HasColumnName("createby");
            entity.Property(e => e.Createddate)
                .HasColumnType("datetime")
                .HasColumnName("createddate");
            entity.Property(e => e.Status)
                .HasMaxLength(12)
                .HasColumnName("status");
            entity.Property(e => e.TnId).HasColumnName("tnID");
            entity.Property(e => e.Tradingname)
                .HasMaxLength(250)
                .HasColumnName("tradingname");
            entity.Property(e => e.Updateby).HasColumnName("updateby");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("updatedate");
        });

        modelBuilder.Entity<PostAddress>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("post_Address");

            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .HasColumnName("category");
            entity.Property(e => e.Comments)
                .HasMaxLength(120)
                .HasColumnName("comments");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .HasColumnName("country");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.FullSuburb)
                .HasMaxLength(100)
                .HasColumnName("fullSuburb");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsMfwzone).HasColumnName("isMFWZone");
            entity.Property(e => e.Postcode)
                .HasMaxLength(20)
                .HasColumnName("postcode");
            entity.Property(e => e.Region).HasMaxLength(50);
            entity.Property(e => e.RegionCode).HasMaxLength(20);
            entity.Property(e => e.State)
                .HasMaxLength(10)
                .HasColumnName("state");
            entity.Property(e => e.Suburb)
                .HasMaxLength(100)
                .HasColumnName("suburb");
        });

        modelBuilder.Entity<PostAddressBack>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_post_Address");

            entity.ToTable("post_Address_back");

            entity.HasIndex(e => new { e.Postcode, e.State, e.Suburb }, "PostCode");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .HasColumnName("category");
            entity.Property(e => e.Comments)
                .HasMaxLength(120)
                .HasColumnName("comments");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .HasColumnName("country");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.FullSuburb)
                .HasMaxLength(100)
                .HasColumnName("fullSuburb");
            entity.Property(e => e.Postcode)
                .HasMaxLength(20)
                .HasColumnName("postcode");
            entity.Property(e => e.State)
                .HasMaxLength(10)
                .HasColumnName("state");
            entity.Property(e => e.Suburb)
                .HasMaxLength(100)
                .HasColumnName("suburb");
        });

        modelBuilder.Entity<PostAddressBack20211020>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_postAddress_20210209");

            entity.ToTable("post_Address_back_20211020");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .HasColumnName("category");
            entity.Property(e => e.Comments)
                .HasMaxLength(50)
                .HasColumnName("comments");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .HasColumnName("country");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.FullSuburb)
                .HasMaxLength(50)
                .HasColumnName("fullSuburb");
            entity.Property(e => e.Postcode).HasColumnName("postcode");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .HasColumnName("state");
            entity.Property(e => e.Suburb)
                .HasMaxLength(50)
                .HasColumnName("suburb");
        });

        modelBuilder.Entity<SyncOrderHistory>(entity =>
        {
            entity.ToTable("SyncOrderHistory");

            entity.Property(e => e.OrderId).HasComment("Order Number or ocid");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'Pending')");
            entity.Property(e => e.TpforderId).HasColumnName("TPFOrderId");
        });

        modelBuilder.Entity<SyncStockHistory>(entity =>
        {
            entity.ToTable("SyncStockHistory");

            entity.HasIndex(e => new { e.SyncTransactionId, e.InternalCode, e.ProdetailId }, "ix_SyncStockHistory");

            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.InternalCode).HasMaxLength(20);
            entity.Property(e => e.RawData).HasComment("Raw data from tpf inventory service");
            entity.Property(e => e.Reason).HasMaxLength(500);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'Pending')");
            entity.Property(e => e.Whid).HasColumnName("WHId");
        });

        modelBuilder.Entity<SyncTransaction>(entity =>
        {
            entity.ToTable("SyncTransaction");

            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'Pending')");
            entity.Property(e => e.SyncType).HasMaxLength(50);
        });

        modelBuilder.Entity<VCaImportDataReportParticipantCaTempReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_CA_ImportDataReportParticipantCA_TempReport");

            entity.Property(e => e.BatSize).HasMaxLength(500);
            entity.Property(e => e.Bblteam)
                .HasMaxLength(500)
                .HasColumnName("BBLTeam");
            entity.Property(e => e.CarrierName).HasMaxLength(300);
            entity.Property(e => e.Colours).HasMaxLength(500);
            entity.Property(e => e.DeliveryPostcode).HasMaxLength(500);
            entity.Property(e => e.EntityId)
                .HasMaxLength(50)
                .HasColumnName("EntityID");
            entity.Property(e => e.EntityName).HasMaxLength(500);
            entity.Property(e => e.FirstTime).HasMaxLength(500);
            entity.Property(e => e.Input).HasMaxLength(500);
            entity.Property(e => e.IsExpressDelivery).HasMaxLength(500);
            entity.Property(e => e.ManualReg).HasMaxLength(500);
            entity.Property(e => e.OrderStatus).HasMaxLength(100);
            entity.Property(e => e.PackChoice).HasMaxLength(250);
            entity.Property(e => e.PackType).HasMaxLength(500);
            entity.Property(e => e.PlayerCategory).HasMaxLength(500);
            entity.Property(e => e.PlayerFirstName).HasMaxLength(500);
            entity.Property(e => e.PlayerId)
                .HasMaxLength(250)
                .HasColumnName("PlayerID");
            entity.Property(e => e.PlayerLastName).HasMaxLength(500);
            entity.Property(e => e.ProgramId)
                .HasMaxLength(250)
                .HasColumnName("ProgramID");
            entity.Property(e => e.RegistrationDate)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.RejectionNote).HasMaxLength(750);
            entity.Property(e => e.ShirtName).HasMaxLength(500);
            entity.Property(e => e.ShirtSize).HasMaxLength(500);
            entity.Property(e => e.Size).HasMaxLength(500);
            entity.Property(e => e.SubmitDate).HasColumnType("datetime");
            entity.Property(e => e.TextToSearch).HasMaxLength(2580);
            entity.Property(e => e.TpfprodDesc)
                .HasMaxLength(500)
                .HasColumnName("TPFProdDesc");
            entity.Property(e => e.TpfprodId)
                .HasMaxLength(250)
                .HasColumnName("TPFProdID");
            entity.Property(e => e.TpfreceivedDate)
                .HasColumnType("datetime")
                .HasColumnName("TPFReceivedDate");
            entity.Property(e => e.TpfuniqueId)
                .HasMaxLength(524)
                .HasColumnName("TPFUniqueID");
            entity.Property(e => e.TrackingNo).HasMaxLength(500);
            entity.Property(e => e.TransId).HasColumnName("TransID");
        });

        modelBuilder.Entity<VCaReminderEmail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_CA_ReminderEmail");

            entity.Property(e => e.ClubName).HasMaxLength(200);
            entity.Property(e => e.Email).HasMaxLength(100);
        });

        modelBuilder.Entity<VCaReportOrderAddressIssue>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_CA_ReportOrderAddressIssues");

            entity.Property(e => e.DAddr)
                .HasMaxLength(500)
                .HasColumnName("D_Addr");
            entity.Property(e => e.DAddr1)
                .HasMaxLength(500)
                .HasColumnName("D_Addr1");
            entity.Property(e => e.DAddr2)
                .HasMaxLength(500)
                .HasColumnName("D_Addr2");
            entity.Property(e => e.DAttention)
                .HasMaxLength(100)
                .HasColumnName("d_attention");
            entity.Property(e => e.DCountry)
                .HasMaxLength(500)
                .HasColumnName("D_Country");
            entity.Property(e => e.DEmail)
                .HasMaxLength(80)
                .HasColumnName("D_Email");
            entity.Property(e => e.DFname)
                .HasMaxLength(50)
                .HasColumnName("D_Fname");
            entity.Property(e => e.DLname)
                .HasMaxLength(50)
                .HasColumnName("D_Lname");
            entity.Property(e => e.DPostcode)
                .HasMaxLength(500)
                .HasColumnName("D_Postcode");
            entity.Property(e => e.EntityId)
                .HasMaxLength(50)
                .HasColumnName("EntityID");
            entity.Property(e => e.EntityName).HasMaxLength(200);
            entity.Property(e => e.EntityState).HasMaxLength(50);
            entity.Property(e => e.EntityType).HasMaxLength(150);
            entity.Property(e => e.OrderGroup).HasMaxLength(100);
            entity.Property(e => e.OrderStatus).HasMaxLength(20);
            entity.Property(e => e.PlayerId)
                .HasMaxLength(250)
                .HasColumnName("PlayerID");
            entity.Property(e => e.PlayerName).HasMaxLength(501);
            entity.Property(e => e.TpforderId).HasColumnName("TPFOrderID");
        });

        modelBuilder.Entity<VCaReportOrderNoBatSize>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_CA_ReportOrderNoBatSize");

            entity.Property(e => e.BatSize)
                .HasMaxLength(250)
                .HasColumnName("batSize");
            entity.Property(e => e.EntityId)
                .HasMaxLength(50)
                .HasColumnName("entityID");
            entity.Property(e => e.EntityName)
                .HasMaxLength(200)
                .HasColumnName("entityName");
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
            entity.Property(e => e.ProgramRefId).HasMaxLength(250);
            entity.Property(e => e.TpforderId).HasColumnName("TPFOrderID");
        });

        modelBuilder.Entity<VCaReportOrderSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_CA_ReportOrderSummary");

            entity.Property(e => e.BillingName).HasMaxLength(100);
            entity.Property(e => e.CarrierName)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.CarrierUrl)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("CarrierURL");
            entity.Property(e => e.ClientId).HasColumnName("clientID");
            entity.Property(e => e.ClubEntityId)
                .HasMaxLength(50)
                .HasColumnName("ClubEntityID");
            entity.Property(e => e.ClubEntityName).HasMaxLength(200);
            entity.Property(e => e.DeliveryAddress).HasMaxLength(4000);
            entity.Property(e => e.DeliveryCompanyName).HasMaxLength(500);
            entity.Property(e => e.DeliveryName).HasMaxLength(100);
            entity.Property(e => e.DeliveryPhone).HasMaxLength(500);
            entity.Property(e => e.DeliveryPostcode).HasMaxLength(500);
            entity.Property(e => e.DeliveryState).HasMaxLength(500);
            entity.Property(e => e.DeliveryStreet1).HasMaxLength(500);
            entity.Property(e => e.DeliveryStreet2)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.DeliverySuburb).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(80);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.GrandTotalInc)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("Grand_Total_INC");
            entity.Property(e => e.GrandTotalOrderInc)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("Grand_Total_ORDER_INC");
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(101);
            entity.Property(e => e.OrderDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.OrderStatus)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PaymentStatus)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PaymentType)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PoCostCentre).HasMaxLength(250);
            entity.Property(e => e.ProcessDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ReasonCode).HasMaxLength(250);
            entity.Property(e => e.TextToSearch).HasMaxLength(1384);
            entity.Property(e => e.TpforderId).HasColumnName("TPFOrderID");
            entity.Property(e => e.TrackingNo)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UserName).HasMaxLength(4000);
            entity.Property(e => e.UserNameOrId).HasMaxLength(253);
            entity.Property(e => e.UserType).HasMaxLength(150);
        });

        modelBuilder.Entity<VCaReportOrderSummaryDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_CA_ReportOrderSummaryDetails");

            entity.Property(e => e.BillingName).HasMaxLength(100);
            entity.Property(e => e.CarrierName)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.CarrierUrl)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("CarrierURL");
            entity.Property(e => e.ClientId).HasColumnName("clientID");
            entity.Property(e => e.ClubEntityId)
                .HasMaxLength(50)
                .HasColumnName("ClubEntityID");
            entity.Property(e => e.ClubEntityName).HasMaxLength(200);
            entity.Property(e => e.DeliveryAddress).HasMaxLength(4000);
            entity.Property(e => e.DeliveryCompanyName).HasMaxLength(500);
            entity.Property(e => e.DeliveryName).HasMaxLength(100);
            entity.Property(e => e.DeliveryPhone).HasMaxLength(500);
            entity.Property(e => e.DeliveryPostcode).HasMaxLength(500);
            entity.Property(e => e.DeliveryState).HasMaxLength(500);
            entity.Property(e => e.DeliveryStreet1).HasMaxLength(500);
            entity.Property(e => e.DeliveryStreet2)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.DeliverySuburb).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(80);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.GrandTotalInc)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("Grand_Total_INC");
            entity.Property(e => e.Grouptest)
                .HasMaxLength(100)
                .HasColumnName("grouptest");
            entity.Property(e => e.Gst)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("GST");
            entity.Property(e => e.ItemCode).HasMaxLength(100);
            entity.Property(e => e.ItemName).HasMaxLength(120);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(101);
            entity.Property(e => e.Ocdetailid).HasColumnName("ocdetailid");
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.OrderStatus)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PaymentStatus)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PaymentType)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PoCostCentre).HasMaxLength(250);
            entity.Property(e => e.ProcessDate).HasColumnType("date");
            entity.Property(e => e.ProductTotal).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Qty)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("QTY");
            entity.Property(e => e.ReasonCode).HasMaxLength(250);
            entity.Property(e => e.SoldPrice).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.TextToSearch).HasMaxLength(1384);
            entity.Property(e => e.ToTal).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.TpforderId).HasColumnName("TPFOrderID");
            entity.Property(e => e.TrackingNo)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UnitPriceEx)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("UnitPrice_EX");
            entity.Property(e => e.UserName).HasMaxLength(253);
            entity.Property(e => e.UserNameOrId).HasMaxLength(253);
            entity.Property(e => e.UserType).HasMaxLength(150);
        });

        modelBuilder.Entity<VCaReportOrderSummaryDetailstest>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_CA_ReportOrderSummaryDetailstest");

            entity.Property(e => e.BillingName).HasMaxLength(100);
            entity.Property(e => e.CarrierName)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.CarrierUrl)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("CarrierURL");
            entity.Property(e => e.ClientId).HasColumnName("clientID");
            entity.Property(e => e.ClubEntityId)
                .HasMaxLength(50)
                .HasColumnName("ClubEntityID");
            entity.Property(e => e.ClubEntityName).HasMaxLength(200);
            entity.Property(e => e.DeliveryAddress).HasMaxLength(4000);
            entity.Property(e => e.DeliveryCompanyName).HasMaxLength(500);
            entity.Property(e => e.DeliveryName).HasMaxLength(100);
            entity.Property(e => e.DeliveryPhone).HasMaxLength(500);
            entity.Property(e => e.DeliveryPostcode).HasMaxLength(500);
            entity.Property(e => e.DeliveryState).HasMaxLength(500);
            entity.Property(e => e.DeliveryStreet1).HasMaxLength(500);
            entity.Property(e => e.DeliveryStreet2)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.DeliverySuburb).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(80);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.GrandTotalInc)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("Grand_Total_INC");
            entity.Property(e => e.Grouptest)
                .HasMaxLength(100)
                .HasColumnName("grouptest");
            entity.Property(e => e.Gst)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("GST");
            entity.Property(e => e.ItemCode).HasMaxLength(100);
            entity.Property(e => e.ItemName).HasMaxLength(120);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(101);
            entity.Property(e => e.Ocdetailid).HasColumnName("ocdetailid");
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.OrderStatus)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PaymentStatus)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PaymentType)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PoCostCentre).HasMaxLength(250);
            entity.Property(e => e.ProcessDate).HasColumnType("date");
            entity.Property(e => e.ProductTotal).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Qty)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("QTY");
            entity.Property(e => e.ReasonCode).HasMaxLength(250);
            entity.Property(e => e.SoldPrice).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.TextToSearch).HasMaxLength(1384);
            entity.Property(e => e.ToTal).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.TpforderId).HasColumnName("TPFOrderID");
            entity.Property(e => e.TrackingNo)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UnitPriceEx)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("UnitPrice_EX");
            entity.Property(e => e.UserName).HasMaxLength(253);
            entity.Property(e => e.UserNameOrId).HasMaxLength(253);
            entity.Property(e => e.UserType).HasMaxLength(150);
        });

        modelBuilder.Entity<VCaReportParticipant>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_CA_ReportParticipant");

            entity.Property(e => e.BatSize).HasMaxLength(250);
            entity.Property(e => e.Bblclub)
                .HasMaxLength(250)
                .HasColumnName("BBLClub");
            entity.Property(e => e.CarrierName).HasMaxLength(300);
            entity.Property(e => e.CarrierUrl).HasMaxLength(300);
            entity.Property(e => e.EntityId)
                .HasMaxLength(50)
                .HasColumnName("EntityID");
            entity.Property(e => e.EntityName).HasMaxLength(200);
            entity.Property(e => e.EntityState).HasMaxLength(50);
            entity.Property(e => e.FirstTime).HasMaxLength(250);
            entity.Property(e => e.ManualReg)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.OrderEtadate).HasColumnName("OrderETADate");
            entity.Property(e => e.OrderNumber)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.OrderStatus)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PackChoice).HasMaxLength(250);
            entity.Property(e => e.ParticipantKey).HasMaxLength(522);
            entity.Property(e => e.PlayerCategory).HasMaxLength(250);
            entity.Property(e => e.PlayerFirstName).HasMaxLength(250);
            entity.Property(e => e.PlayerId)
                .HasMaxLength(250)
                .HasColumnName("PlayerID");
            entity.Property(e => e.PlayerLastName).HasMaxLength(250);
            entity.Property(e => e.ProgramId)
                .HasMaxLength(255)
                .HasColumnName("ProgramID");
            entity.Property(e => e.ProgramStartDate).HasMaxLength(250);
            entity.Property(e => e.ReceivedDate).HasColumnType("datetime");
            entity.Property(e => e.RegistrationDate).HasColumnType("datetime");
            entity.Property(e => e.RejectionNote).HasMaxLength(750);
            entity.Property(e => e.ShirtName).HasMaxLength(250);
            entity.Property(e => e.ShirtSize).HasMaxLength(250);
            entity.Property(e => e.TextToSearch).HasMaxLength(1310);
            entity.Property(e => e.TpforderId).HasColumnName("TPFOrderID");
            entity.Property(e => e.TrackingNo).HasMaxLength(500);
            entity.Property(e => e.TransId).HasColumnName("TransID");
        });

        modelBuilder.Entity<VCaReportParticipantCentre>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_CA_ReportParticipantCentre");

            entity.Property(e => e.BatsSent).HasColumnName("Bats_Sent");
            entity.Property(e => e.BatsToSend).HasColumnName("Bats_ToSend");
            entity.Property(e => e.Date1Order)
                .HasMaxLength(30)
                .HasColumnName("Date1_Order");
            entity.Property(e => e.Date1OrderChecking).HasColumnName("Date1Order_Checking");
            entity.Property(e => e.Date1Tracking)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Date1_Tracking");
            entity.Property(e => e.Date2Order).HasColumnName("Date2_Order");
            entity.Property(e => e.DeliveryDate1).HasColumnType("date");
            entity.Property(e => e.DeliveryDate2).HasColumnType("date");
            entity.Property(e => e.EntityId)
                .HasMaxLength(50)
                .HasColumnName("entityID");
            entity.Property(e => e.EntityName)
                .HasMaxLength(200)
                .HasColumnName("entityName");
            entity.Property(e => e.EntityState).HasMaxLength(50);
            entity.Property(e => e.NextSend)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.ProgramId)
                .HasMaxLength(50)
                .HasColumnName("ProgramID");
            entity.Property(e => e.ProgramStartDate).HasColumnType("date");
            entity.Property(e => e.TrackingNo)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VCaReportParticipantItemDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_CA_ReportParticipantItemDetail");

            entity.Property(e => e.BatSize)
                .HasMaxLength(500)
                .HasColumnName("batSize");
            entity.Property(e => e.BblTeam)
                .HasMaxLength(500)
                .HasColumnName("bblTeam");
            entity.Property(e => e.CarrierName).HasMaxLength(300);
            entity.Property(e => e.DeliveryPostcode).HasMaxLength(500);
            entity.Property(e => e.DispatchDate).HasMaxLength(4000);
            entity.Property(e => e.EntityId)
                .HasMaxLength(50)
                .HasColumnName("EntityID");
            entity.Property(e => e.FirstTime).HasMaxLength(500);
            entity.Property(e => e.ParticipantOrderId).HasColumnName("ParticipantOrderID");
            entity.Property(e => e.PlayerCategory).HasMaxLength(500);
            entity.Property(e => e.PlayerFirstName).HasMaxLength(500);
            entity.Property(e => e.PlayerId)
                .HasMaxLength(250)
                .HasColumnName("PlayerID");
            entity.Property(e => e.ProductCode).HasMaxLength(100);
            entity.Property(e => e.ProductName).HasMaxLength(150);
            entity.Property(e => e.ProgramId)
                .HasMaxLength(250)
                .HasColumnName("ProgramID");
            entity.Property(e => e.ShirtSize)
                .HasMaxLength(500)
                .HasColumnName("shirtSize");
            entity.Property(e => e.TpfuniqueId)
                .HasMaxLength(500)
                .HasColumnName("TPFUniqueID");
            entity.Property(e => e.TrackingNo).HasMaxLength(500);
            entity.Property(e => e.TransId).HasColumnName("TransID");
        });

        modelBuilder.Entity<VCaReportParticipantItemDetailBakPhase42>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_CA_ReportParticipantItemDetail_BAK_Phase4_2");

            entity.Property(e => e.CarrierName).HasMaxLength(300);
            entity.Property(e => e.EntityId).HasColumnName("EntityID");
            entity.Property(e => e.ParticipantOrderId).HasColumnName("ParticipantOrderID");
            entity.Property(e => e.PlayerId)
                .HasMaxLength(250)
                .HasColumnName("PlayerID");
            entity.Property(e => e.ProductCode).HasMaxLength(100);
            entity.Property(e => e.ProductName).HasMaxLength(150);
            entity.Property(e => e.ProgramId)
                .HasMaxLength(250)
                .HasColumnName("ProgramID");
            entity.Property(e => e.TpfuniqueId)
                .HasMaxLength(524)
                .HasColumnName("TPFUniqueID");
            entity.Property(e => e.TrackingNo).HasMaxLength(500);
            entity.Property(e => e.TransId).HasColumnName("TransID");
        });

        modelBuilder.Entity<VCaReportParticipantItemDetailV2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_CA_ReportParticipantItemDetail_V2");

            entity.Property(e => e.CarrierName).HasMaxLength(300);
            entity.Property(e => e.DeliveryPostcode).HasMaxLength(500);
            entity.Property(e => e.EntityId)
                .HasMaxLength(50)
                .HasColumnName("EntityID");
            entity.Property(e => e.ParticipantOrderId).HasColumnName("ParticipantOrderID");
            entity.Property(e => e.PlayerFirstName).HasMaxLength(500);
            entity.Property(e => e.PlayerId)
                .HasMaxLength(250)
                .HasColumnName("PlayerID");
            entity.Property(e => e.ProductCode).HasMaxLength(100);
            entity.Property(e => e.ProductName).HasMaxLength(150);
            entity.Property(e => e.ProgramId)
                .HasMaxLength(250)
                .HasColumnName("ProgramID");
            entity.Property(e => e.TpfuniqueId)
                .HasMaxLength(500)
                .HasColumnName("TPFUniqueID");
            entity.Property(e => e.TrackingNo).HasMaxLength(500);
            entity.Property(e => e.TransId).HasColumnName("TransID");
        });

        modelBuilder.Entity<VCaReportParticipantRawDataBakPhase4>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_CA_ReportParticipant_RawData_BAK_Phase4");

            entity.Property(e => e.Bblteam).HasColumnName("BBLTeam");
            entity.Property(e => e.CarrierName).HasMaxLength(300);
            entity.Property(e => e.EntityId).HasColumnName("EntityID");
            entity.Property(e => e.PackType)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.PlayerId)
                .HasMaxLength(250)
                .HasColumnName("PlayerID");
            entity.Property(e => e.ProgramId)
                .HasMaxLength(250)
                .HasColumnName("ProgramID");
            entity.Property(e => e.RegistrationDate)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.RejectionNote).HasMaxLength(750);
            entity.Property(e => e.SubmitDate).HasColumnType("datetime");
            entity.Property(e => e.TpfprodDesc)
                .HasMaxLength(500)
                .HasColumnName("TPFProdDesc");
            entity.Property(e => e.TpfprodId)
                .HasMaxLength(250)
                .HasColumnName("TPFProdID");
            entity.Property(e => e.TpfreceivedDate)
                .HasColumnType("datetime")
                .HasColumnName("TPFReceivedDate");
            entity.Property(e => e.TpfuniqueId)
                .HasMaxLength(522)
                .HasColumnName("TPFUniqueID");
            entity.Property(e => e.TrackingNo).HasMaxLength(500);
            entity.Property(e => e.TransId).HasColumnName("TransID");
        });

        modelBuilder.Entity<VCaReportParticipantRawDataV2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_CA_ReportParticipant_RawData_V2");

            entity.Property(e => e.BatSize).HasMaxLength(500);
            entity.Property(e => e.Bblteam)
                .HasMaxLength(500)
                .HasColumnName("BBLTeam");
            entity.Property(e => e.CarrierName).HasMaxLength(300);
            entity.Property(e => e.Colours).HasMaxLength(500);
            entity.Property(e => e.DeliveryPostcode).HasMaxLength(500);
            entity.Property(e => e.EntityId)
                .HasMaxLength(50)
                .HasColumnName("EntityID");
            entity.Property(e => e.EntityName).HasMaxLength(500);
            entity.Property(e => e.FirstTime).HasMaxLength(500);
            entity.Property(e => e.Input).HasMaxLength(500);
            entity.Property(e => e.IsExpressDelivery).HasMaxLength(500);
            entity.Property(e => e.ManualReg).HasMaxLength(500);
            entity.Property(e => e.PackType)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.PlayerCategory).HasMaxLength(500);
            entity.Property(e => e.PlayerFirstName).HasMaxLength(500);
            entity.Property(e => e.PlayerId)
                .HasMaxLength(250)
                .HasColumnName("PlayerID");
            entity.Property(e => e.PlayerLastName).HasMaxLength(500);
            entity.Property(e => e.ProgramId)
                .HasMaxLength(250)
                .HasColumnName("ProgramID");
            entity.Property(e => e.RegistrationDate)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.RejectionNote).HasMaxLength(750);
            entity.Property(e => e.ShirtName).HasMaxLength(500);
            entity.Property(e => e.ShirtSize).HasMaxLength(500);
            entity.Property(e => e.Size).HasMaxLength(500);
            entity.Property(e => e.SubmitDate).HasColumnType("datetime");
            entity.Property(e => e.TextToSearch).HasMaxLength(2577);
            entity.Property(e => e.TpfprodDesc)
                .HasMaxLength(500)
                .HasColumnName("TPFProdDesc");
            entity.Property(e => e.TpfprodId)
                .HasMaxLength(250)
                .HasColumnName("TPFProdID");
            entity.Property(e => e.TpfreceivedDate)
                .HasColumnType("datetime")
                .HasColumnName("TPFReceivedDate");
            entity.Property(e => e.TpfuniqueId)
                .HasMaxLength(522)
                .HasColumnName("TPFUniqueID");
            entity.Property(e => e.TrackingNo).HasMaxLength(500);
            entity.Property(e => e.TransId).HasColumnName("TransID");
        });

        modelBuilder.Entity<VCaReportParticipantRawDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_CA_ReportParticipant_RawData");

            entity.Property(e => e.ApprovedDate).HasMaxLength(4000);
            entity.Property(e => e.BatSize).HasMaxLength(500);
            entity.Property(e => e.Bblteam)
                .HasMaxLength(500)
                .HasColumnName("BBLTeam");
            entity.Property(e => e.CarrierName).HasMaxLength(300);
            entity.Property(e => e.Colours).HasMaxLength(500);
            entity.Property(e => e.DeliveryPostcode).HasMaxLength(500);
            entity.Property(e => e.DispatchDate).HasMaxLength(4000);
            entity.Property(e => e.EntityId)
                .HasMaxLength(50)
                .HasColumnName("EntityID");
            entity.Property(e => e.EntityName).HasMaxLength(500);
            entity.Property(e => e.FirstTime).HasMaxLength(500);
            entity.Property(e => e.InTransitDate).HasMaxLength(4000);
            entity.Property(e => e.Input).HasMaxLength(500);
            entity.Property(e => e.IsExpressDelivery).HasMaxLength(500);
            entity.Property(e => e.ManualReg).HasMaxLength(500);
            entity.Property(e => e.OrderStatus).HasMaxLength(100);
            entity.Property(e => e.PackChoice).HasMaxLength(250);
            entity.Property(e => e.PackType).HasMaxLength(500);
            entity.Property(e => e.PlayerCategory).HasMaxLength(500);
            entity.Property(e => e.PlayerFirstName).HasMaxLength(500);
            entity.Property(e => e.PlayerId)
                .HasMaxLength(250)
                .HasColumnName("PlayerID");
            entity.Property(e => e.PlayerLastName).HasMaxLength(500);
            entity.Property(e => e.ProcessedDate).HasMaxLength(4000);
            entity.Property(e => e.ProgramId)
                .HasMaxLength(250)
                .HasColumnName("ProgramID");
            entity.Property(e => e.RegistrationDate)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.RejectionNote).HasMaxLength(750);
            entity.Property(e => e.ShirtName).HasMaxLength(500);
            entity.Property(e => e.ShirtSize).HasMaxLength(500);
            entity.Property(e => e.Size).HasMaxLength(500);
            entity.Property(e => e.SubmitDate).HasMaxLength(4000);
            entity.Property(e => e.TextToSearch).HasMaxLength(2580);
            entity.Property(e => e.TpfprodDesc)
                .HasMaxLength(500)
                .HasColumnName("TPFProdDesc");
            entity.Property(e => e.TpfprodId)
                .HasMaxLength(250)
                .HasColumnName("TPFProdID");
            entity.Property(e => e.TpfreceivedDate)
                .HasMaxLength(4000)
                .HasColumnName("TPFReceivedDate");
            entity.Property(e => e.TpfuniqueId)
                .HasMaxLength(524)
                .HasColumnName("TPFUniqueID");
            entity.Property(e => e.TrackingNo).HasMaxLength(500);
            entity.Property(e => e.TransId).HasColumnName("TransID");
        });

        modelBuilder.Entity<VCaReportParticipantSentPlayer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_CA_ReportParticipantSentPlayer");

            entity.Property(e => e.BatSize).HasMaxLength(250);
            entity.Property(e => e.Bblclub)
                .HasMaxLength(250)
                .HasColumnName("BBLClub");
            entity.Property(e => e.CarrierName).HasMaxLength(300);
            entity.Property(e => e.CarrierUrl).HasMaxLength(300);
            entity.Property(e => e.EntityId)
                .HasMaxLength(50)
                .HasColumnName("EntityID");
            entity.Property(e => e.EntityName).HasMaxLength(200);
            entity.Property(e => e.EntityState).HasMaxLength(50);
            entity.Property(e => e.FirstTime).HasMaxLength(250);
            entity.Property(e => e.OrderEtadate)
                .HasColumnType("datetime")
                .HasColumnName("OrderETADate");
            entity.Property(e => e.OrderNumber)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.OrderStatus)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.PackChoice).HasMaxLength(250);
            entity.Property(e => e.ParticipantKey).HasMaxLength(522);
            entity.Property(e => e.PlayerCategory).HasMaxLength(250);
            entity.Property(e => e.PlayerFirstName).HasMaxLength(250);
            entity.Property(e => e.PlayerId)
                .HasMaxLength(250)
                .HasColumnName("PlayerID");
            entity.Property(e => e.PlayerLastName).HasMaxLength(250);
            entity.Property(e => e.ProgramId)
                .HasMaxLength(255)
                .HasColumnName("ProgramID");
            entity.Property(e => e.ProgramStartDate).HasMaxLength(250);
            entity.Property(e => e.ShirtName).HasMaxLength(250);
            entity.Property(e => e.ShirtSize).HasMaxLength(250);
            entity.Property(e => e.TextToSearch).HasMaxLength(1049);
            entity.Property(e => e.TpforderId).HasColumnName("TPFOrderID");
            entity.Property(e => e.TrackingNo).HasMaxLength(500);
        });

        modelBuilder.Entity<VCaReportRedemptionCentre>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_CA_ReportRedemptionCentre");

            entity.Property(e => e.AdjCredit)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("adjCredit");
            entity.Property(e => e.AvailCredit)
                .HasColumnType("decimal(20, 2)")
                .HasColumnName("availCredit");
            entity.Property(e => e.Certificate)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CoordPack)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CoordPackAssigned).HasColumnName("coordPackAssigned");
            entity.Property(e => e.CoordPackRedeemed).HasColumnName("coordPackRedeemed");
            entity.Property(e => e.EntityId)
                .HasMaxLength(50)
                .HasColumnName("EntityID");
            entity.Property(e => e.EntityName).HasMaxLength(200);
            entity.Property(e => e.EntityState).HasMaxLength(50);
            entity.Property(e => e.JnrCertAssigned).HasColumnName("jnrCertAssigned");
            entity.Property(e => e.JnrCertRedeemed).HasColumnName("jnrCertRedeemed");
            entity.Property(e => e.JnrCredit).HasColumnName("jnrCredit");
            entity.Property(e => e.JnrMainAssigned).HasColumnName("jnrMainAssigned");
            entity.Property(e => e.JnrMainRedeemed).HasColumnName("jnrMainRedeemed");
            entity.Property(e => e.JnrNew).HasColumnName("jnrNEW");
            entity.Property(e => e.JnrOld).HasColumnName("jnrOLD");
            entity.Property(e => e.JnrTopUpAssigned).HasColumnName("jnrTopUpAssigned");
            entity.Property(e => e.JnrTopUpRedeemed).HasColumnName("jnrTopUpRedeemed");
            entity.Property(e => e.Main)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.MstrCredit).HasColumnName("mstrCredit");
            entity.Property(e => e.MstrNew).HasColumnName("mstrNEW");
            entity.Property(e => e.RedemStatus).HasMaxLength(10);
            entity.Property(e => e.Tdbanner)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TDBanner");
            entity.Property(e => e.TearDropFlagAssigned).HasColumnName("tearDropFlagAssigned");
            entity.Property(e => e.TearDropFlagRedeemed).HasColumnName("tearDropFlagRedeemed");
            entity.Property(e => e.TextToSearch).HasMaxLength(210);
            entity.Property(e => e.TopUp)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.TotalCredit)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("totalCredit");
            entity.Property(e => e.UsedCredit)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("usedCredit");
            entity.Property(e => e.UserName).HasMaxLength(150);
            entity.Property(e => e.VolCap)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.VolPackAssigned).HasColumnName("volPackAssigned");
            entity.Property(e => e.VolPackRedeemed).HasColumnName("volPackRedeemed");
        });

        modelBuilder.Entity<VCaReportRedemptionJunior>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_CA_ReportRedemptionJunior");

            entity.Property(e => e.EntityId)
                .HasMaxLength(50)
                .HasColumnName("EntityID");
            entity.Property(e => e.EntityName).HasMaxLength(200);
            entity.Property(e => e.EntityState).HasMaxLength(50);
            entity.Property(e => e.EntityType).HasMaxLength(50);
            entity.Property(e => e.JnrcricketStumpsAssigned).HasColumnName("jnrcricket_stumpsAssigned");
            entity.Property(e => e.JnrcricketStumpsRedeemed).HasColumnName("jnrcricket_stumpsRedeemed");
            entity.Property(e => e.JnrcricketTapemesAssigned).HasColumnName("jnrcricket_tapemesAssigned");
            entity.Property(e => e.JnrcricketTapemesRedeemed).HasColumnName("jnrcricket_tapemesRedeemed");
            entity.Property(e => e.RedemStatus).HasMaxLength(10);
            entity.Property(e => e.Stumps)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.TapeMasure)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.TextToSearch).HasMaxLength(210);
            entity.Property(e => e.UserName).HasMaxLength(150);
        });

        modelBuilder.Entity<VCaReportRedemptionShool>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_CA_ReportRedemptionShool");

            entity.Property(e => e.Bblclub)
                .HasMaxLength(100)
                .HasColumnName("BBLClub");
            entity.Property(e => e.EntityId)
                .HasMaxLength(50)
                .HasColumnName("EntityID");
            entity.Property(e => e.EntityName).HasMaxLength(200);
            entity.Property(e => e.EntityState).HasMaxLength(50);
            entity.Property(e => e.EntityType).HasMaxLength(50);
            entity.Property(e => e.GigyaId)
                .HasMaxLength(200)
                .HasColumnName("GigyaID");
            entity.Property(e => e.HealthPe)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("HealthPE");
            entity.Property(e => e.RedemStatus).HasMaxLength(10);
            entity.Property(e => e.RoleStatus).HasMaxLength(50);
            entity.Property(e => e.SchlCupAssigned).HasColumnName("schl_cupAssigned");
            entity.Property(e => e.SchlCupRedeemed).HasColumnName("schl_cupRedeemed");
            entity.Property(e => e.SchlHpeAssigned).HasColumnName("schl_hpeAssigned");
            entity.Property(e => e.SchlHpeRedeemed).HasColumnName("schl_hpeRedeemed");
            entity.Property(e => e.SchoolCup)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.TextToSearch).HasMaxLength(463);
            entity.Property(e => e.UserName).HasMaxLength(150);
        });

        modelBuilder.Entity<VCaReportRejectionOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_CA_ReportRejectionOrder");

            entity.Property(e => e.ErrorReason).HasMaxLength(582);
            entity.Property(e => e.LastModified).HasColumnType("datetime");
            entity.Property(e => e.NumberId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.RejectionStatus)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.RejectionType)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.TextToSearch).HasMaxLength(639);
        });

        modelBuilder.Entity<VCaReportRejectionPlayer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_CA_ReportRejectionPlayer");

            entity.Property(e => e.ErrorReason).HasMaxLength(750);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.LastModified).HasColumnType("datetime");
            entity.Property(e => e.NumberId).HasMaxLength(501);
            entity.Property(e => e.RejectionStatus).HasMaxLength(50);
            entity.Property(e => e.RejectionType)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.TextToSearch).HasMaxLength(1317);
        });

        modelBuilder.Entity<VCaReportRejectionPlayerTest>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_CA_ReportRejectionPlayerTest");

            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .HasColumnName("category");
            entity.Property(e => e.Comments)
                .HasMaxLength(50)
                .HasColumnName("comments");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .HasColumnName("country");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.FullSuburb)
                .HasMaxLength(50)
                .HasColumnName("fullSuburb");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Postcode).HasColumnName("postcode");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .HasColumnName("state");
            entity.Property(e => e.Suburb)
                .HasMaxLength(50)
                .HasColumnName("suburb");
        });

        modelBuilder.Entity<VCaReportSaleProduct>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_CA_ReportSaleProduct");

            entity.Property(e => e.InventoryCode).HasMaxLength(100);
            entity.Property(e => e.OrderType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.ProductName).HasMaxLength(120);
        });

        modelBuilder.Entity<VCaReportValidationPlayerProduct>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_CA_ReportValidationPlayerProduct");

            entity.Property(e => e.CaEntityId).HasMaxLength(255);
            entity.Property(e => e.ErrorReason)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.PlayerId).HasMaxLength(255);
            entity.Property(e => e.ProgramRefId).HasMaxLength(255);
        });

        modelBuilder.Entity<VEcomOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_ECOM_Orders");

            entity.Property(e => e.CompanyName).HasMaxLength(250);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(80);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.HoldOrder)
                .HasMaxLength(50)
                .HasColumnName("holdOrder");
            entity.Property(e => e.IOrderTotal).HasColumnName("iOrderTotal");
            entity.Property(e => e.IOrderTotalExc).HasColumnName("iOrderTotalExc");
            entity.Property(e => e.IsOnlineOrder)
                .HasMaxLength(50)
                .HasColumnName("isOnlineOrder");
            entity.Property(e => e.IsSynced).HasColumnName("isSynced");
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.Onhold).HasColumnName("onhold");
            entity.Property(e => e.OrderGroup).HasMaxLength(100);
            entity.Property(e => e.OrderNumber).ValueGeneratedOnAdd();
            entity.Property(e => e.PayOption).HasMaxLength(50);
            entity.Property(e => e.Ponumber)
                .HasMaxLength(100)
                .HasColumnName("PONumber");
            entity.Property(e => e.PromotionName).HasMaxLength(120);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.TxnRef)
                .HasMaxLength(50)
                .HasColumnName("txnRef");
            entity.Property(e => e.Whid).HasColumnName("WHID");
        });

        modelBuilder.Entity<VOrdersSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_OrdersSummary");

            entity.Property(e => e.BillingAddress)
                .HasMaxLength(500)
                .HasColumnName("Billing_Address");
            entity.Property(e => e.BillingCountry)
                .HasMaxLength(100)
                .HasColumnName("Billing_Country");
            entity.Property(e => e.BillingFullName)
                .HasMaxLength(100)
                .HasColumnName("Billing_FullName");
            entity.Property(e => e.BillingPostcode)
                .HasMaxLength(10)
                .HasColumnName("Billing_Postcode");
            entity.Property(e => e.BillingState)
                .HasMaxLength(500)
                .HasColumnName("Billing_State");
            entity.Property(e => e.BillingSuburb)
                .HasMaxLength(500)
                .HasColumnName("Billing_Suburb");
            entity.Property(e => e.CarrierName)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.CarrierUrl)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Catalogueid).HasColumnName("catalogueid");
            entity.Property(e => e.ClientId).HasColumnName("ClientID");
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
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DelStatus).HasMaxLength(20);
            entity.Property(e => e.DeliveryAddress)
                .HasMaxLength(500)
                .HasColumnName("Delivery_Address");
            entity.Property(e => e.DeliveryCountry)
                .HasMaxLength(500)
                .HasColumnName("Delivery_Country");
            entity.Property(e => e.DeliveryFullName)
                .HasMaxLength(100)
                .HasColumnName("Delivery_FullName");
            entity.Property(e => e.DeliveryPostcode)
                .HasMaxLength(500)
                .HasColumnName("Delivery_Postcode");
            entity.Property(e => e.DeliveryState)
                .HasMaxLength(500)
                .HasColumnName("Delivery_State");
            entity.Property(e => e.DeliverySuburb)
                .HasMaxLength(500)
                .HasColumnName("Delivery_Suburb");
            entity.Property(e => e.Email).HasMaxLength(80);
            entity.Property(e => e.EntityId)
                .HasMaxLength(50)
                .HasColumnName("EntityID");
            entity.Property(e => e.EntityName).HasMaxLength(200);
            entity.Property(e => e.LastModified).HasColumnType("datetime");
            entity.Property(e => e.OrderStatus)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PaymentMethod).HasMaxLength(50);
            entity.Property(e => e.PaymentStatus).HasMaxLength(20);
            entity.Property(e => e.TpforderId).HasColumnName("TPFOrderID");
            entity.Property(e => e.TrackingNo)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UserType).HasMaxLength(500);
            entity.Property(e => e.Username).HasMaxLength(150);
            entity.Property(e => e.WebAccId).HasColumnName("WebAccID");
        });

        modelBuilder.Entity<VSyncHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_SyncHistory");

            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.SyncType).HasMaxLength(50);
            entity.Property(e => e.TransactionId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<VSyncStockHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_SyncStockHistory");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.InternalCode).HasMaxLength(20);
            entity.Property(e => e.Reason).HasMaxLength(500);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.Whid).HasColumnName("WHId");
        });

        modelBuilder.Entity<VmUsersOrderHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vm_users_order_history");

            entity.Property(e => e.BillingAddress)
                .HasMaxLength(500)
                .HasColumnName("Billing_Address");
            entity.Property(e => e.BillingCountry)
                .HasMaxLength(100)
                .HasColumnName("Billing_Country");
            entity.Property(e => e.BillingFullName)
                .HasMaxLength(100)
                .HasColumnName("Billing_FullName");
            entity.Property(e => e.BillingPostcode)
                .HasMaxLength(10)
                .HasColumnName("Billing_Postcode");
            entity.Property(e => e.BillingState)
                .HasMaxLength(500)
                .HasColumnName("Billing_State");
            entity.Property(e => e.BillingSuburb)
                .HasMaxLength(500)
                .HasColumnName("Billing_Suburb");
            entity.Property(e => e.CarrierName)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.CarrierUrl)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Catalogueid).HasColumnName("catalogueid");
            entity.Property(e => e.ClientId).HasColumnName("clientID");
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
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DelStatus)
                .HasMaxLength(20)
                .HasColumnName("del_status");
            entity.Property(e => e.DeliveryAddress)
                .HasMaxLength(500)
                .HasColumnName("Delivery_Address");
            entity.Property(e => e.DeliveryCountry)
                .HasMaxLength(500)
                .HasColumnName("Delivery_Country");
            entity.Property(e => e.DeliveryFullName)
                .HasMaxLength(100)
                .HasColumnName("Delivery_FullName");
            entity.Property(e => e.DeliveryPostcode)
                .HasMaxLength(500)
                .HasColumnName("Delivery_Postcode");
            entity.Property(e => e.DeliveryState)
                .HasMaxLength(500)
                .HasColumnName("Delivery_State");
            entity.Property(e => e.DeliverySuburb)
                .HasMaxLength(500)
                .HasColumnName("Delivery_Suburb");
            entity.Property(e => e.Email)
                .HasMaxLength(80)
                .HasColumnName("email");
            entity.Property(e => e.Lastmodified)
                .HasColumnType("datetime")
                .HasColumnName("lastmodified");
            entity.Property(e => e.Ordernumber).HasColumnName("ordernumber");
            entity.Property(e => e.PaymentMethod).HasMaxLength(50);
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasColumnName("status");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.TpforderId).HasColumnName("TPFOrderID");
            entity.Property(e => e.TrackingNo)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(150)
                .HasColumnName("username");
            entity.Property(e => e.WebAccId).HasColumnName("webAccID");
        });

        modelBuilder.Entity<WebGroup>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CatalogueId).HasColumnName("CatalogueID");
            entity.Property(e => e.DefaultPriceId).HasColumnName("DefaultPriceID");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.RrppriceId).HasColumnName("RRPPriceID");
            entity.Property(e => e.Sign).HasMaxLength(10);
        });

        modelBuilder.Entity<WebGroupCategory>(entity =>
        {
            entity.ToTable("WebGroup_Category");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.DefaultPriceId).HasColumnName("DefaultPriceID");
            entity.Property(e => e.Description).HasMaxLength(300);
            entity.Property(e => e.ExcludeWebAccId)
                .HasMaxLength(500)
                .HasColumnName("ExcludeWebAccID");
            entity.Property(e => e.RrppriceId).HasColumnName("RRPPriceID");
            entity.Property(e => e.Sign)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.WebGroupId).HasColumnName("WebGroupID");
        });

        modelBuilder.Entity<WebPermission>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WebPermission");

            entity.Property(e => e.AccId).HasColumnName("AccID");
            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
        });

        modelBuilder.Entity<WebRole>(entity =>
        {
            entity.HasIndex(e => new { e.Id, e.CatalogueId }, "IX_WebRoles").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CatalogueId).HasColumnName("CatalogueID");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Name).HasMaxLength(150);
        });

        modelBuilder.Entity<WebaccountGroup>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.WebAccId).HasColumnName("WebAccID");
            entity.Property(e => e.WebGroupId).HasColumnName("WebGroupID");
        });

        modelBuilder.Entity<WebaccountRole>(entity =>
        {
            entity.HasKey(e => new { e.WebAccId, e.WebRoleId });

            entity.Property(e => e.WebAccId).HasColumnName("WebAccID");
            entity.Property(e => e.WebRoleId).HasColumnName("WebRoleID");
        });

        modelBuilder.Entity<Who2blame>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("who2blame");

            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Details)
                .HasColumnType("ntext")
                .HasColumnName("details");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Staffid).HasColumnName("staffid");
            entity.Property(e => e.What)
                .HasMaxLength(100)
                .HasColumnName("what");
        });

        modelBuilder.Entity<ZRosaCaPlayer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Z_ROSA_CA_Player");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.EntityId).HasColumnName("entityID");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.PlayerId)
                .HasMaxLength(250)
                .HasColumnName("playerID");
            entity.Property(e => e.ProgramRefId).HasMaxLength(250);
            entity.Property(e => e.ProgramStartDate).HasMaxLength(250);
            entity.Property(e => e.RecordStatusNotes).HasMaxLength(500);
            entity.Property(e => e.RejectionNote)
                .HasMaxLength(750)
                .HasColumnName("rejectionNote");
            entity.Property(e => e.RejectionStatus).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(250);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateStatus).HasMaxLength(50);
        });

        modelBuilder.Entity<ZRosaUdtFforderInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Z_ROSA_UDT_FFOrderInfo");

            entity.Property(e => e.CarrierName).HasMaxLength(300);
            entity.Property(e => e.CarrierUrl).HasMaxLength(300);
            entity.Property(e => e.Idx)
                .ValueGeneratedOnAdd()
                .HasColumnName("idx");
            entity.Property(e => e.OrderStatus).HasMaxLength(100);
            entity.Property(e => e.OrderStatusNote).HasMaxLength(500);
            entity.Property(e => e.ParticipantKey).HasMaxLength(500);
            entity.Property(e => e.ParticipantOrderId).HasColumnName("ParticipantOrderID");
            entity.Property(e => e.PlayerId)
                .HasMaxLength(250)
                .HasColumnName("PlayerID");
            entity.Property(e => e.ProgramRefId).HasMaxLength(250);
            entity.Property(e => e.RecordStatus).HasMaxLength(100);
            entity.Property(e => e.RecordStatusNotes).HasMaxLength(500);
            entity.Property(e => e.RefNo).HasMaxLength(100);
            entity.Property(e => e.TrackingNo).HasMaxLength(500);
            entity.Property(e => e.TransId).HasColumnName("TransID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
