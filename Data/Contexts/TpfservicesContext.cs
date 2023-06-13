using Data.Databases.TPFServices;

namespace Data.Contexts;

public partial class TpfservicesContext : DbContext
{
    public TpfservicesContext()
    {
    }

    public TpfservicesContext(DbContextOptions<TpfservicesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AppClient> AppClients { get; set; }

    public virtual DbSet<AppClientShop> AppClientShops { get; set; }

    public virtual DbSet<FfApiclient> FfApiclients { get; set; }

    public virtual DbSet<FfImportTransaction> FfImportTransactions { get; set; }

    public virtual DbSet<ImportDataDictionary> ImportDataDictionaries { get; set; }

    public virtual DbSet<ImportEntity> ImportEntities { get; set; }

    public virtual DbSet<ImportOrganisation> ImportOrganisations { get; set; }

    public virtual DbSet<ImportParticipant> ImportParticipants { get; set; }

    public virtual DbSet<ImportProduct> ImportProducts { get; set; }

    public virtual DbSet<ImportProgram> ImportPrograms { get; set; }

    public virtual DbSet<ImportTransaction> ImportTransactions { get; set; }

    public virtual DbSet<ImportUser> ImportUsers { get; set; }

    public virtual DbSet<LogErrorsImport> LogErrorsImports { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<ScheduleCallOnShop> ScheduleCallOnShops { get; set; }

    public virtual DbSet<Season> Seasons { get; set; }

    public virtual DbSet<TestTable> TestTables { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AppClient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AppClien__3214EC074AB81AF0");

            entity.ToTable("AppClient");

            entity.Property(e => e.ClientName).HasMaxLength(500);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsValiPrograme).HasColumnName("isValiPrograme");
            entity.Property(e => e.ShopId).HasColumnName("ShopID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AppClientShop>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AppClien__3214EC071CD670C4");

            entity.ToTable("AppClientShop");

            entity.Property(e => e.ClientName).HasMaxLength(500);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.ShopId).HasColumnName("ShopID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<FfApiclient>(entity =>
        {
            entity.HasKey(e => e.ClientId).HasName("PK__FF_APICl__81A2CB811BD145F3");

            entity.ToTable("FF_APIClient");

            entity.Property(e => e.ClientId).HasColumnName("clientID");
            entity.Property(e => e.ClientName)
                .HasMaxLength(500)
                .HasColumnName("clientName");
            entity.Property(e => e.CreateBy).HasColumnName("createBy");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("createDate");
            entity.Property(e => e.Email)
                .HasMaxLength(200)
                .HasColumnName("email");
            entity.Property(e => e.FormatId).HasColumnName("formatID");
        });

        modelBuilder.Entity<FfImportTransaction>(entity =>
        {
            entity.ToTable("FF_ImportTransaction");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ClientId).HasColumnName("clientID");
            entity.Property(e => e.Filename)
                .HasMaxLength(250)
                .HasColumnName("filename");
            entity.Property(e => e.FormatId).HasColumnName("formatID");
            entity.Property(e => e.InsertBy).HasColumnName("insertBy");
            entity.Property(e => e.InsertDate)
                .HasColumnType("datetime")
                .HasColumnName("insertDate");
            entity.Property(e => e.Recordtype)
                .HasMaxLength(20)
                .HasColumnName("recordtype");
            entity.Property(e => e.Season).HasColumnName("season");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasColumnName("status");
            entity.Property(e => e.TotalRecords).HasColumnName("totalRecords");
            entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("updatedDate");
        });

        modelBuilder.Entity<ImportDataDictionary>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Import_D__3214EC071B846159");

            entity.ToTable("Import_DataDictionary");

            entity.HasIndex(e => new { e.Value, e.Type }, "Value_Type");

            entity.Property(e => e.ClientId).HasColumnName("ClientID");
            entity.Property(e => e.InsertDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .HasColumnName("notes");
            entity.Property(e => e.Type).HasMaxLength(30);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.Value).HasMaxLength(100);
        });

        modelBuilder.Entity<ImportEntity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Import_E__3214EC0707C12930");

            entity.ToTable("Import_Entities");

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
            entity.Property(e => e.EntityEmail).HasMaxLength(50);
            entity.Property(e => e.EntityId)
                .HasMaxLength(50)
                .HasColumnName("EntityID");
            entity.Property(e => e.EntityName).HasMaxLength(100);
            entity.Property(e => e.EntitySince).HasMaxLength(50);
            entity.Property(e => e.EntityTenure).HasMaxLength(50);
            entity.Property(e => e.EntityType).HasMaxLength(100);
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.OrgId)
                .HasMaxLength(50)
                .HasColumnName("OrgID");
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
            entity.Property(e => e.TransId).HasColumnName("TransID");
            entity.Property(e => e.VenueAddressLine1).HasMaxLength(80);
            entity.Property(e => e.VenueAddressLine2).HasMaxLength(80);
            entity.Property(e => e.VenueAddressLine3).HasMaxLength(80);
            entity.Property(e => e.VenueCountry).HasMaxLength(60);
            entity.Property(e => e.VenuePostcode).HasMaxLength(20);
            entity.Property(e => e.VenueState).HasMaxLength(50);
            entity.Property(e => e.VenueSuburb).HasMaxLength(85);
        });

        modelBuilder.Entity<ImportOrganisation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Import_O__3214EC0703F0984C");

            entity.ToTable("Import_Organisations");

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
            entity.Property(e => e.TransId).HasColumnName("TransID");
        });

        modelBuilder.Entity<ImportParticipant>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Import_P__3214EC070F624AF8");

            entity.ToTable("Import_Participants");

            entity.Property(e => e.AccountId)
                .HasMaxLength(50)
                .HasColumnName("AccountID");
            entity.Property(e => e.AccountType).HasMaxLength(50);
            entity.Property(e => e.BarcodeAdditional)
                .HasMaxLength(250)
                .HasColumnName("barcode_additional");
            entity.Property(e => e.BarcodeAdditional2)
                .HasMaxLength(250)
                .HasColumnName("barcode_additional2");
            entity.Property(e => e.BarcodePrintCount)
                .HasMaxLength(250)
                .HasColumnName("barcode_print_count");
            entity.Property(e => e.BarcodePrintDate)
                .HasMaxLength(250)
                .HasColumnName("barcode_print_date");
            entity.Property(e => e.BarcodeValue)
                .HasMaxLength(250)
                .HasColumnName("barcode_value");
            entity.Property(e => e.BirthDate).HasColumnType("datetime");
            entity.Property(e => e.Category).HasMaxLength(200);
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
            entity.Property(e => e.ExternalLinkId)
                .HasMaxLength(50)
                .HasColumnName("External_linkID");
            entity.Property(e => e.ExternalLinkType)
                .HasMaxLength(50)
                .HasColumnName("External_linkType");
            entity.Property(e => e.FirstName).HasMaxLength(35);
            entity.Property(e => e.Gender).HasMaxLength(30);
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LastName).HasMaxLength(35);
            entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.MemberId)
                .HasMaxLength(50)
                .HasColumnName("member_ID");
            entity.Property(e => e.MemberSinceConsecutive)
                .HasMaxLength(50)
                .HasColumnName("member_since_consecutive");
            entity.Property(e => e.MemberSinceFirst)
                .HasMaxLength(50)
                .HasColumnName("member_since_first");
            entity.Property(e => e.MemberYearsConsecutive)
                .HasMaxLength(50)
                .HasColumnName("member_years_consecutive");
            entity.Property(e => e.MemberYearsTotal)
                .HasMaxLength(50)
                .HasColumnName("member_years_total");
            entity.Property(e => e.MemberYearsUpdated)
                .HasMaxLength(50)
                .HasColumnName("member_years_updated");
            entity.Property(e => e.Notes).HasMaxLength(500);
            entity.Property(e => e.OrderComplimentary)
                .HasMaxLength(250)
                .HasColumnName("order_complimentary");
            entity.Property(e => e.OrderDate)
                .HasMaxLength(250)
                .HasColumnName("order_date");
            entity.Property(e => e.OrderDeliveryHistory)
                .HasMaxLength(250)
                .HasColumnName("order_delivery_history");
            entity.Property(e => e.OrderDeliveryNote)
                .HasMaxLength(250)
                .HasColumnName("order_delivery_note");
            entity.Property(e => e.OrderDiscount)
                .HasMaxLength(250)
                .HasColumnName("order_discount");
            entity.Property(e => e.OrderId)
                .HasMaxLength(50)
                .HasColumnName("OrderID");
            entity.Property(e => e.OrderLineItem)
                .HasMaxLength(80)
                .HasColumnName("order_LineItem");
            entity.Property(e => e.OrderLineItemQty).HasColumnName("order_LineItem_QTY");
            entity.Property(e => e.OrderOnplan)
                .HasMaxLength(250)
                .HasColumnName("order_onplan");
            entity.Property(e => e.OrderPlantype)
                .HasMaxLength(250)
                .HasColumnName("order_plantype");
            entity.Property(e => e.OtherInfo1)
                .HasMaxLength(500)
                .HasColumnName("other_info1");
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
            entity.Property(e => e.ParentFirstName).HasMaxLength(35);
            entity.Property(e => e.ParentLastName).HasMaxLength(35);
            entity.Property(e => e.ParticipantId)
                .HasMaxLength(50)
                .HasColumnName("ParticipantID");
            entity.Property(e => e.ParticipantType).HasMaxLength(100);
            entity.Property(e => e.ProductCategory)
                .HasMaxLength(250)
                .HasColumnName("product_category");
            entity.Property(e => e.ProductChoice1)
                .HasMaxLength(250)
                .HasColumnName("product_choice1");
            entity.Property(e => e.ProductChoice2)
                .HasMaxLength(250)
                .HasColumnName("product_choice2");
            entity.Property(e => e.ProductDescription)
                .HasMaxLength(250)
                .HasColumnName("product_description");
            entity.Property(e => e.ProductId)
                .HasMaxLength(250)
                .HasColumnName("product_ID");
            entity.Property(e => e.ProductName)
                .HasMaxLength(250)
                .HasColumnName("product_name");
            entity.Property(e => e.ProductPackage)
                .HasMaxLength(250)
                .HasColumnName("product_package");
            entity.Property(e => e.ProductPricetype)
                .HasMaxLength(250)
                .HasColumnName("product_pricetype");
            entity.Property(e => e.ProductPrintvalue)
                .HasMaxLength(250)
                .HasColumnName("product_printvalue");
            entity.Property(e => e.ProductSpecialtext)
                .HasMaxLength(250)
                .HasColumnName("product_specialtext");
            entity.Property(e => e.ProductTickettype)
                .HasMaxLength(250)
                .HasColumnName("product_tickettype");
            entity.Property(e => e.ProgramId)
                .HasMaxLength(50)
                .HasColumnName("ProgramID");
            entity.Property(e => e.RtsAddressline1)
                .HasMaxLength(80)
                .HasColumnName("rts_addressline1");
            entity.Property(e => e.RtsAddressline2)
                .HasMaxLength(80)
                .HasColumnName("rts_addressline2");
            entity.Property(e => e.RtsCompanyname)
                .HasMaxLength(50)
                .HasColumnName("rts_companyname");
            entity.Property(e => e.RtsCountry)
                .HasMaxLength(60)
                .HasColumnName("rts_country");
            entity.Property(e => e.RtsFullname)
                .HasMaxLength(35)
                .HasColumnName("rts_fullname");
            entity.Property(e => e.RtsPostcode)
                .HasMaxLength(20)
                .HasColumnName("rts_postcode");
            entity.Property(e => e.RtsState)
                .HasMaxLength(50)
                .HasColumnName("rts_state");
            entity.Property(e => e.RtsSuburb)
                .HasMaxLength(85)
                .HasColumnName("rts_suburb");
            entity.Property(e => e.Title).HasMaxLength(30);
            entity.Property(e => e.TransId).HasColumnName("TransID");
            entity.Property(e => e.Venue1Aisle)
                .HasMaxLength(250)
                .HasColumnName("venue1_aisle");
            entity.Property(e => e.Venue1Fulldetail)
                .HasMaxLength(250)
                .HasColumnName("venue1_fulldetail");
            entity.Property(e => e.Venue1Gate)
                .HasMaxLength(250)
                .HasColumnName("venue1_gate");
            entity.Property(e => e.Venue1Name)
                .HasMaxLength(250)
                .HasColumnName("venue1_name");
            entity.Property(e => e.Venue1Row)
                .HasMaxLength(250)
                .HasColumnName("venue1_row");
            entity.Property(e => e.Venue1Seat)
                .HasMaxLength(250)
                .HasColumnName("venue1_seat");
            entity.Property(e => e.Venue1Section)
                .HasMaxLength(250)
                .HasColumnName("venue1_section");
            entity.Property(e => e.Venue1Stand)
                .HasMaxLength(250)
                .HasColumnName("venue1_stand");
            entity.Property(e => e.Venue2Aisle)
                .HasMaxLength(250)
                .HasColumnName("venue2_aisle");
            entity.Property(e => e.Venue2Fulldetail)
                .HasMaxLength(250)
                .HasColumnName("venue2_fulldetail");
            entity.Property(e => e.Venue2Gate)
                .HasMaxLength(250)
                .HasColumnName("venue2_gate");
            entity.Property(e => e.Venue2Name)
                .HasMaxLength(250)
                .HasColumnName("venue2_name");
            entity.Property(e => e.Venue2Row)
                .HasMaxLength(250)
                .HasColumnName("venue2_row");
            entity.Property(e => e.Venue2Seat)
                .HasMaxLength(250)
                .HasColumnName("venue2_seat");
            entity.Property(e => e.Venue2Section)
                .HasMaxLength(250)
                .HasColumnName("venue2_section");
            entity.Property(e => e.Venue2Stand)
                .HasMaxLength(250)
                .HasColumnName("venue2_stand");
            entity.Property(e => e.Venue3Aisle)
                .HasMaxLength(250)
                .HasColumnName("venue3_aisle");
            entity.Property(e => e.Venue3Fulldetail)
                .HasMaxLength(250)
                .HasColumnName("venue3_fulldetail");
            entity.Property(e => e.Venue3Gate)
                .HasMaxLength(250)
                .HasColumnName("venue3_gate");
            entity.Property(e => e.Venue3Name)
                .HasMaxLength(250)
                .HasColumnName("venue3_name");
            entity.Property(e => e.Venue3Row)
                .HasMaxLength(250)
                .HasColumnName("venue3_row");
            entity.Property(e => e.Venue3Seat)
                .HasMaxLength(250)
                .HasColumnName("venue3_seat");
            entity.Property(e => e.Venue3Section)
                .HasMaxLength(250)
                .HasColumnName("venue3_section");
            entity.Property(e => e.Venue3Stand)
                .HasMaxLength(250)
                .HasColumnName("venue3_stand");
            entity.Property(e => e.Venue4Aisle)
                .HasMaxLength(250)
                .HasColumnName("venue4_aisle");
            entity.Property(e => e.Venue4Fulldetail)
                .HasMaxLength(250)
                .HasColumnName("venue4_fulldetail");
            entity.Property(e => e.Venue4Gate)
                .HasMaxLength(250)
                .HasColumnName("venue4_gate");
            entity.Property(e => e.Venue4Name)
                .HasMaxLength(250)
                .HasColumnName("venue4_name");
            entity.Property(e => e.Venue4Row)
                .HasMaxLength(250)
                .HasColumnName("venue4_row");
            entity.Property(e => e.Venue4Seat)
                .HasMaxLength(250)
                .HasColumnName("venue4_seat");
            entity.Property(e => e.Venue4Section)
                .HasMaxLength(250)
                .HasColumnName("venue4_section");
            entity.Property(e => e.Venue4Stand)
                .HasMaxLength(250)
                .HasColumnName("venue4_stand");
        });

        modelBuilder.Entity<ImportProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Import_P__3214EC077D268E05");

            entity.ToTable("Import_Products");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.ProductId).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(100);
            entity.Property(e => e.TransId).HasColumnName("TransID");
        });

        modelBuilder.Entity<ImportProgram>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Import_P__3214EC070B91BA14");

            entity.ToTable("Import_Programs");

            entity.Property(e => e.CoordinatorFirstName).HasMaxLength(50);
            entity.Property(e => e.CoordinatorId)
                .HasMaxLength(50)
                .HasColumnName("CoordinatorID");
            entity.Property(e => e.CoordinatorLastName).HasMaxLength(50);
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
            entity.Property(e => e.EntityId)
                .HasMaxLength(50)
                .HasColumnName("EntityID");
            entity.Property(e => e.FinishDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
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
                .HasMaxLength(50)
                .HasColumnName("ProgramID");
            entity.Property(e => e.ProgramName).HasMaxLength(100);
            entity.Property(e => e.ProgramTerm).HasMaxLength(30);
            entity.Property(e => e.ProgramType).HasMaxLength(100);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.TransId).HasColumnName("TransID");
            entity.Property(e => e.VenueAddressLine1).HasMaxLength(80);
            entity.Property(e => e.VenueAddressLine2).HasMaxLength(80);
            entity.Property(e => e.VenueAddressLine3).HasMaxLength(80);
            entity.Property(e => e.VenueCountry).HasMaxLength(60);
            entity.Property(e => e.VenuePostcode).HasMaxLength(20);
            entity.Property(e => e.VenueState).HasMaxLength(50);
            entity.Property(e => e.VenueSuburb).HasMaxLength(85);
        });

        modelBuilder.Entity<ImportTransaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Import_T__3214EC071F98B2C1");

            entity.ToTable("Import_Transactions");

            entity.Property(e => e.ClientId).HasColumnName("ClientID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FileName).HasMaxLength(200);
            entity.Property(e => e.ImportType).HasMaxLength(500);
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasDefaultValueSql("('pending')");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImportUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Import_U__3214EC0700200768");

            entity.ToTable("Import_Users");

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
            entity.Property(e => e.Password).HasMaxLength(100);
            entity.Property(e => e.TransId).HasColumnName("TransID");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");
            entity.Property(e => e.UserName).HasMaxLength(100);
            entity.Property(e => e.UserType).HasMaxLength(50);
        });

        modelBuilder.Entity<LogErrorsImport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LogError__3214EC0791E9A5A2");

            entity.ToTable("LogErrorsImport");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.TransationId).HasColumnName("TransationID");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Roles__3214EC073F466844");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<ScheduleCallOnShop>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Schedule__3214EC078332D157");

            entity.ToTable("ScheduleCallOnShop");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.IsCall).HasColumnName("isCall");
            entity.Property(e => e.LinkSubmit).HasMaxLength(500);
            entity.Property(e => e.StatusData)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TimeCall).HasColumnType("datetime");
            entity.Property(e => e.TypeData)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Season>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Season__3214EC074316F928");

            entity.ToTable("Season");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TestTable>(entity =>
        {
            entity.HasKey(e => new { e.Username, e.Usertype });

            entity.ToTable("TEST_TABLE");

            entity.Property(e => e.Username)
                .HasMaxLength(30)
                .HasColumnName("username");
            entity.Property(e => e.Usertype)
                .HasMaxLength(30)
                .HasColumnName("usertype");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserRole__3214EC073B75D760");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
