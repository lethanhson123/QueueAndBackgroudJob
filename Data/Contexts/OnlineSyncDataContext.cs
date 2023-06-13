using Data.Databases.OnlineSyncData;

namespace Data.Contexts;

public partial class OnlineSyncDataContext : DbContext
{
    public OnlineSyncDataContext()
    {
    }

    public OnlineSyncDataContext(DbContextOptions<OnlineSyncDataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<AccountClaim> AccountClaims { get; set; }

    public virtual DbSet<AccountLogin> AccountLogins { get; set; }

    public virtual DbSet<AccountRegistrationToken> AccountRegistrationTokens { get; set; }

    public virtual DbSet<AccountRole> AccountRoles { get; set; }

    public virtual DbSet<ClientChecking> ClientCheckings { get; set; }

    public virtual DbSet<InventorySync> InventorySyncs { get; set; }

    public virtual DbSet<OrderDelTracking> OrderDelTrackings { get; set; }

    public virtual DbSet<OrderSyncLog> OrderSyncLogs { get; set; }

    public virtual DbSet<OrderSyncTracking> OrderSyncTrackings { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<ShopifyMembershipInfoTmp> ShopifyMembershipInfoTmps { get; set; }

    public virtual DbSet<StockComparison> StockComparisons { get; set; }

    public virtual DbSet<StockSyncLog> StockSyncLogs { get; set; }

    public virtual DbSet<StoreWebsite> StoreWebsites { get; set; }

    public virtual DbSet<SyncLog> SyncLogs { get; set; }

    public virtual DbSet<VAccount> VAccounts { get; set; }

    public virtual DbSet<VOrderSyncKey> VOrderSyncKeys { get; set; }

    public virtual DbSet<VOrderSyncTracking> VOrderSyncTrackings { get; set; }

    public virtual DbSet<VOrderSyncTrackingDev> VOrderSyncTrackingDevs { get; set; }

    public virtual DbSet<VOrderTracking> VOrderTrackings { get; set; }

    public virtual DbSet<VOrderTrackingV2> VOrderTrackingV2s { get; set; }

    public virtual DbSet<VSiteStoreInfo> VSiteStoreInfos { get; set; }

    public virtual DbSet<VStockSyncLog> VStockSyncLogs { get; set; }

    public virtual DbSet<VStockToSync> VStockToSyncs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.ToTable("Account");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActivationToken).HasMaxLength(200);
            entity.Property(e => e.ApprovalDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastLoginDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(250);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.StoreId).HasColumnName("StoreID");
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<AccountClaim>(entity =>
        {
            entity.ToTable("AccountClaim");
        });

        modelBuilder.Entity<AccountLogin>(entity =>
        {
            entity.HasKey(e => new { e.AccountId, e.LoginProvider, e.ProviderKey });

            entity.ToTable("AccountLogin");

            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.ProviderKey).HasMaxLength(128);

            entity.HasOne(d => d.Account).WithMany(p => p.AccountLogins)
                .HasForeignKey(d => d.AccountId)
                .HasConstraintName("FK_AccountLogin_Account");
        });

        modelBuilder.Entity<AccountRegistrationToken>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SecurityToken");

            entity.ToTable("AccountRegistrationToken");

            entity.HasIndex(e => e.Token, "UX_AccountRegistrationToken_Token").IsUnique();

            entity.Property(e => e.Token)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<AccountRole>(entity =>
        {
            entity.HasKey(e => new { e.AccountId, e.RoleId });

            entity.ToTable("AccountRole");

            entity.HasOne(d => d.Account).WithMany(p => p.AccountRoles)
                .HasForeignKey(d => d.AccountId)
                .HasConstraintName("FK_AccountRole_Account");
        });

        modelBuilder.Entity<ClientChecking>(entity =>
        {
            entity.ToTable("ClientChecking");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AccountId)
                .HasMaxLength(50)
                .HasColumnName("AccountID");
            entity.Property(e => e.Client).HasMaxLength(150);
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.Fullname).HasMaxLength(100);
        });

        modelBuilder.Entity<InventorySync>(entity =>
        {
            entity.ToTable("InventorySync", tb => tb.HasTrigger("trg_LogRequestStockSync"));

            entity.HasIndex(e => e.StoreId, "IX_StoreID");

            entity.HasIndex(e => e.InternalCode, "InternalCode");

            entity.HasIndex(e => e.ProdetailId, "ProdetailID");

            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ExternalCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InternalCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastSyncDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ProdetailId).HasColumnName("ProdetailID");
            entity.Property(e => e.StoreId).HasColumnName("StoreID");
            entity.Property(e => e.SyncStatus).HasComment("0 - Pending\r\n1 - Synced \r\n2 - Warning\r\n3 - Error\r\n4 - Apply\r\n5 - NA\r\n6 - Testing\r\n7 - Processing\r\n8 - Sent");
        });

        modelBuilder.Entity<OrderDelTracking>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OrderDelTracking");

            entity.HasIndex(e => e.Id, "Id").IsClustered();

            entity.HasIndex(e => e.Ocid, "Ocid");

            entity.HasIndex(e => e.PoNumber, "PoNumber");

            entity.HasIndex(e => e.RefNo, "RefNo");

            entity.Property(e => e.CarrierName)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.CarrierUrl)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.PoNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ProcessedDate).HasColumnType("datetime");
            entity.Property(e => e.SentDate).HasColumnType("datetime");
            entity.Property(e => e.TrackingNo)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OrderSyncLog>(entity =>
        {
            entity.ToTable("OrderSyncLog");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LogContent).HasMaxLength(500);
            entity.Property(e => e.LogType)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'success')");
            entity.Property(e => e.PoNumber).HasMaxLength(50);
            entity.Property(e => e.StoreId).HasColumnName("StoreID");
        });

        modelBuilder.Entity<OrderSyncTracking>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OrderSyncTracking", tb => tb.HasTrigger("trg_LogRequestOrderSync"));

            entity.HasIndex(e => e.Id, "AK_OrderSyncTracking_ID")
                .IsUnique()
                .IsDescending()
                .IsClustered();

            entity.HasIndex(e => new { e.SyncStatus, e.Status }, "IX_SyncStatus_Status");

            entity.HasIndex(e => new { e.TpfOrderId, e.StoreId, e.PoNumber, e.OrderStatus, e.SyncStatus, e.SyncDelStatus, e.Rguid }, "OrderTracking").IsDescending(true, false, false, false, false, false, false);

            entity.HasIndex(e => e.PoNumber, "PoNumber").IsDescending();

            entity.HasIndex(e => e.Rguid, "RGuid");

            entity.HasIndex(e => e.TpfOrderId, "TpfOrderId");

            entity.Property(e => e.ClosedOrderDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DelStatus)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'New')");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.LastSyncDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.OrderStatus).HasMaxLength(20);
            entity.Property(e => e.PoNumber).HasMaxLength(20);
            entity.Property(e => e.RejectNote).HasMaxLength(500);
            entity.Property(e => e.Rguid).HasColumnName("RGuid");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'active')");
            entity.Property(e => e.SyncStatus).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.ToTable("Role");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<ShopifyMembershipInfoTmp>(entity =>
        {
            entity.ToTable("ShopifyMembershipInfoTmp");

            entity.HasIndex(e => e.DiscountCode, "IX_DiscountCode");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Address).HasMaxLength(500);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.DiscountCode).HasMaxLength(20);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.Note).HasMaxLength(250);
            entity.Property(e => e.PhoneNumber).HasMaxLength(100);
            entity.Property(e => e.PoNumber)
                .HasMaxLength(20)
                .HasColumnName("poNumber");
            entity.Property(e => e.Qty).HasColumnName("qty");
            entity.Property(e => e.RefNote).HasMaxLength(50);
            entity.Property(e => e.Sku)
                .HasMaxLength(20)
                .HasColumnName("SKU");
        });

        modelBuilder.Entity<StockComparison>(entity =>
        {
            entity.ToTable("StockComparison");

            entity.Property(e => e.ChoosePrimaryWh).HasColumnName("ChoosePrimaryWH");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ExternalCode).HasMaxLength(50);
            entity.Property(e => e.InternalCode).HasMaxLength(50);
            entity.Property(e => e.IsBackOrder).HasComment("Item could be in backorder");
            entity.Property(e => e.IsChecked)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.StockStatus)
                .HasMaxLength(50)
                .HasComment("Stock Status or Status in the Inventory System");
            entity.Property(e => e.StoreId).HasMaxLength(50);
        });

        modelBuilder.Entity<StockSyncLog>(entity =>
        {
            entity.ToTable("StockSyncLog");

            entity.HasIndex(e => e.StockId, "IX_StockSyncLog_StockId");

            entity.HasIndex(e => e.InternalCode, "ix_InternalCode");

            entity.HasIndex(e => new { e.StockId, e.StoreId, e.InternalCode }, "ix_StockSyncLog_Key");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.InternalCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LogContent).HasMaxLength(500);
            entity.Property(e => e.LogType)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'success')");
            entity.Property(e => e.StoreId).HasColumnName("StoreID");
        });

        modelBuilder.Entity<StoreWebsite>(entity =>
        {
            entity.ToTable("StoreWebsite");

            entity.HasIndex(e => e.ApiId, "IX_ApiID");

            entity.HasIndex(e => e.CatalogueId, "IX_CatalogueID");

            entity.HasIndex(e => new { e.Id, e.CatalogueId }, "ix_StoreWebSync_Key");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ApiId)
                .HasMaxLength(100)
                .HasColumnName("ApiID");
            entity.Property(e => e.ApiKey).HasMaxLength(500);
            entity.Property(e => e.CatalogueId).HasColumnName("CatalogueID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Ftplink)
                .HasMaxLength(500)
                .HasColumnName("FTPLink");
            entity.Property(e => e.Ftppassword)
                .HasMaxLength(50)
                .HasColumnName("FTPPassword");
            entity.Property(e => e.Ftpuser)
                .HasMaxLength(50)
                .HasColumnName("FTPUser");
            entity.Property(e => e.IsPrimaryWarehouse).HasComment("use Primary Warehouse to be default");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Roles)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasComment("NA = 0,\r\nInventorySync = 1,\r\nOrderSync = 2,\r\nClientSync = 3,\r\nTurnOffStockSync = 4,\r\nOrderPaid = 5,\r\nTurnOffOrderSync = 6,\r\nRequestSyncStock = 7,\r\nDeliveryAddressSync = 8,");
            entity.Property(e => e.StoreApiurl)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("StoreAPIUrl");
            entity.Property(e => e.StoreName).HasMaxLength(500);
            entity.Property(e => e.StoreStatus).HasMaxLength(50);
            entity.Property(e => e.Type).HasComment("NA=>0\r\nMagento=>1\r\nMagento2=>2\r\nCA=>3\r\nNetSetGo=>4");
            entity.Property(e => e.Url)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("URL");
        });

        modelBuilder.Entity<SyncLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Log");

            entity.ToTable("SyncLog");

            entity.HasIndex(e => new { e.Level, e.RefKey }, "IX_Refkey_Error");

            entity.HasIndex(e => e.RefKey, "RefKey");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Callsite).HasMaxLength(500);
            entity.Property(e => e.GroupLog)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'NA')");
            entity.Property(e => e.Level)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Logged).HasColumnType("datetime");
            entity.Property(e => e.Logger).HasMaxLength(300);
            entity.Property(e => e.MachineName).HasMaxLength(500);
            entity.Property(e => e.RefKey).HasMaxLength(250);
            entity.Property(e => e.StoreId).HasColumnName("StoreID");
        });

        modelBuilder.Entity<VAccount>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Account");

            entity.Property(e => e.ActivationToken).HasMaxLength(200);
            entity.Property(e => e.ApprovalDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastLoginDate).HasColumnType("datetime");
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.ModeifiedBy)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.ModeifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.TextToSearch).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<VOrderSyncKey>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_OrderSyncKey");

            entity.Property(e => e.Ponumber)
                .HasMaxLength(20)
                .HasColumnName("PONumber");
            entity.Property(e => e.Rguid).HasColumnName("RGuid");
        });

        modelBuilder.Entity<VOrderSyncTracking>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_OrderSyncTracking");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DelStatus).HasMaxLength(20);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.LastSyncDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.OrderStatus).HasMaxLength(20);
            entity.Property(e => e.PoNumber).HasMaxLength(20);
            entity.Property(e => e.Status).HasMaxLength(20);
        });

        modelBuilder.Entity<VOrderSyncTrackingDev>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_OrderSyncTracking_dev");

            entity.Property(e => e.DeliveryStatus).HasMaxLength(20);
            entity.Property(e => e.OrderStatus)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.PoNumber)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Rguid).HasColumnName("RGuid");
            entity.Property(e => e.Status).HasMaxLength(20);
        });

        modelBuilder.Entity<VOrderTracking>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_OrderTracking");

            entity.Property(e => e.ApiId)
                .HasMaxLength(100)
                .HasColumnName("ApiID");
            entity.Property(e => e.CarrierName)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.CarrierUrl)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.CatalogueName)
                .HasMaxLength(80)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DelStatus)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.LastSyncDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.OrderStatus)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.PoNumber)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.ProcessedDate).HasColumnType("datetime");
            entity.Property(e => e.Rguid).HasColumnName("RGuid");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.TrackingNo)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VOrderTrackingV2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_OrderTrackingV2");

            entity.Property(e => e.ApiId)
                .HasMaxLength(100)
                .HasColumnName("ApiID");
            entity.Property(e => e.CarrierName)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.CarrierUrl)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.CatalogueName)
                .HasMaxLength(80)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DelStatus)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.LastSyncDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.OrderStatus)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.PoNumber).HasMaxLength(20);
            entity.Property(e => e.ProcessedDate).HasColumnType("datetime");
            entity.Property(e => e.Rguid).HasColumnName("RGuid");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.TrackingNo)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VSiteStoreInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_SiteStoreInfo");

            entity.Property(e => e.ApiId)
                .HasMaxLength(100)
                .HasColumnName("ApiID");
            entity.Property(e => e.ApiKey).HasMaxLength(500);
            entity.Property(e => e.CatalogueName)
                .HasMaxLength(80)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Currency)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Ftplink)
                .HasMaxLength(500)
                .HasColumnName("FTPLink");
            entity.Property(e => e.Ftppassword)
                .HasMaxLength(50)
                .HasColumnName("FTPPassword");
            entity.Property(e => e.Ftpuser)
                .HasMaxLength(50)
                .HasColumnName("FTPUser");
            entity.Property(e => e.MagentoKey)
                .HasMaxLength(4000)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Roles)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.StoreApiurl)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("StoreAPIUrl");
            entity.Property(e => e.StoreName).HasMaxLength(500);
            entity.Property(e => e.StoreStatus).HasMaxLength(50);
            entity.Property(e => e.Url)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("URL");
            entity.Property(e => e.UsedPrimaryWh).HasColumnName("UsedPrimaryWH");
        });

        modelBuilder.Entity<VStockSyncLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_StockSyncLog");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InternalCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LogType).HasMaxLength(20);
        });

        modelBuilder.Entity<VStockToSync>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_StockToSync");

            entity.Property(e => e.ExternalCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InternalCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastSyncDate).HasColumnType("datetime");
            entity.Property(e => e.ProdetailId).HasColumnName("ProdetailID");
            entity.Property(e => e.StoreId).HasColumnName("StoreID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
