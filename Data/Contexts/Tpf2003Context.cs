using Data.Databases.Tpf2003;

namespace Data.Contexts;

public partial class Tpf2003Context : DbContext
{
    public Tpf2003Context()
    {
    }

    public Tpf2003Context(DbContextOptions<Tpf2003Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Binbase> Binbases { get; set; }

    public virtual DbSet<Elecpayment> Elecpayments { get; set; }

    public virtual DbSet<PayTransLog> PayTransLogs { get; set; }

    public virtual DbSet<Paypalclient> Paypalclients { get; set; }

    public virtual DbSet<Paypaltran> Paypaltrans { get; set; }

    public virtual DbSet<Staff> Staff { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Binbase>(entity =>
        {
            entity.HasKey(e => e.Bin);

            entity.ToTable("binbase");

            entity.Property(e => e.Bin)
                .HasMaxLength(6)
                .IsFixedLength()
                .HasColumnName("bin");
            entity.Property(e => e.Cardbrand)
                .HasMaxLength(150)
                .HasColumnName("cardbrand");
            entity.Property(e => e.Cardcategory)
                .HasMaxLength(150)
                .HasColumnName("cardcategory");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Isocodea2)
                .HasMaxLength(50)
                .HasColumnName("isocodea2");
            entity.Property(e => e.Isocodea3)
                .HasMaxLength(50)
                .HasColumnName("isocodea3");
            entity.Property(e => e.Isocountryname)
                .HasMaxLength(200)
                .HasColumnName("isocountryname");
            entity.Property(e => e.Isocountrynumber).HasColumnName("isocountrynumber");
            entity.Property(e => e.Issuingbank)
                .HasMaxLength(150)
                .HasColumnName("issuingbank");
            entity.Property(e => e.Opt1)
                .HasMaxLength(200)
                .HasColumnName("opt1");
            entity.Property(e => e.Opt2)
                .HasMaxLength(200)
                .HasColumnName("opt2");
            entity.Property(e => e.Typeofcard)
                .HasMaxLength(150)
                .HasColumnName("typeofcard");
        });

        modelBuilder.Entity<Elecpayment>(entity =>
        {
            entity.HasKey(e => e.PayId).IsClustered(false);

            entity.ToTable("elecpayment");

            entity.Property(e => e.PayId).HasColumnName("payId");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.Bank)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'anz')")
                .HasColumnName("bank");
            entity.Property(e => e.Cardno)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("last 4 digits of card number")
                .HasColumnName("cardno");
            entity.Property(e => e.Cardtype)
                .HasMaxLength(20)
                .HasColumnName("cardtype");
            entity.Property(e => e.Company)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'tpf')")
                .HasComment("event or tpf")
                .HasColumnName("company");
            entity.Property(e => e.Currency)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'AUD')")
                .HasColumnName("currency");
            entity.Property(e => e.Custemail)
                .HasMaxLength(100)
                .HasColumnName("custemail");
            entity.Property(e => e.Custname)
                .HasMaxLength(80)
                .HasColumnName("custname");
            entity.Property(e => e.Custno)
                .HasMaxLength(80)
                .HasColumnName("custno");
            entity.Property(e => e.Mmexp)
                .HasMaxLength(2)
                .HasColumnName("mmexp");
            entity.Property(e => e.OccNo)
                .HasDefaultValueSql("((0))")
                .HasColumnName("occNo");
            entity.Property(e => e.Paydate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("paydate");
            entity.Property(e => e.Payfrom)
                .HasMaxLength(50)
                .HasColumnName("payfrom");
            entity.Property(e => e.Processedby)
                .HasMaxLength(80)
                .HasColumnName("processedby");
            entity.Property(e => e.Responsecode)
                .HasMaxLength(10)
                .HasColumnName("responsecode");
            entity.Property(e => e.Responsetext)
                .HasMaxLength(400)
                .HasColumnName("responsetext");
            entity.Property(e => e.Source)
                .HasMaxLength(100)
                .HasColumnName("source");
            entity.Property(e => e.Status)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'outstanding')")
                .HasColumnName("status");
            entity.Property(e => e.Trantype)
                .HasMaxLength(60)
                .HasColumnName("trantype");
            entity.Property(e => e.TxnReference).HasMaxLength(40);
            entity.Property(e => e.Yyexp)
                .HasMaxLength(2)
                .HasColumnName("yyexp");
        });

        modelBuilder.Entity<PayTransLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PayTrans__3214EC079BA0E491");

            entity.Property(e => e.IsReturn).HasColumnName("isReturn");
            entity.Property(e => e.ReturnContent).HasMaxLength(2000);
            entity.Property(e => e.ReturnDate).HasColumnType("datetime");
            entity.Property(e => e.SearchText)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SubmitContent).HasMaxLength(2000);
            entity.Property(e => e.SubmitDate).HasColumnType("datetime");
            entity.Property(e => e.TypeCards).HasMaxLength(50);
        });

        modelBuilder.Entity<Paypalclient>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.ToTable("paypalclients");

            entity.HasIndex(e => e.Id, "id")
                .IsUnique()
                .IsClustered();

            entity.HasIndex(e => e.Payerid, "payerid");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .HasColumnName("address");
            entity.Property(e => e.Addressstatus)
                .HasMaxLength(20)
                .HasColumnName("addressstatus");
            entity.Property(e => e.Attention)
                .HasMaxLength(100)
                .HasColumnName("attention");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .HasColumnName("city");
            entity.Property(e => e.Companyname)
                .HasMaxLength(100)
                .HasColumnName("companyname");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .HasColumnName("country");
            entity.Property(e => e.Countrycode)
                .HasMaxLength(50)
                .HasColumnName("countrycode");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.Fname)
                .HasMaxLength(50)
                .HasColumnName("fname");
            entity.Property(e => e.Lastupdated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("lastupdated");
            entity.Property(e => e.Lname)
                .HasMaxLength(50)
                .HasColumnName("lname");
            entity.Property(e => e.Payerid)
                .HasMaxLength(50)
                .HasColumnName("payerid");
            entity.Property(e => e.Payerstatus)
                .HasMaxLength(20)
                .HasColumnName("payerstatus");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .HasColumnName("phone");
            entity.Property(e => e.Postcode)
                .HasMaxLength(50)
                .HasColumnName("postcode");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .HasColumnName("state");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'current')")
                .HasColumnName("status");
        });

        modelBuilder.Entity<Paypaltran>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.ToTable("paypaltrans");

            entity.HasIndex(e => e.Ocid, "IX_paypaltrans")
                .IsClustered()
                .HasFillFactor(90);

            entity.HasIndex(e => e.Payerid, "payerid").HasFillFactor(90);

            entity.HasIndex(e => e.Transactionid, "transactionid").HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amountrecv).HasColumnName("amountrecv");
            entity.Property(e => e.Amt).HasColumnName("amt");
            entity.Property(e => e.Copy2order)
                .HasMaxLength(3)
                .HasDefaultValueSql("(N'no')")
                .HasColumnName("copy2order");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Exchangerate).HasColumnName("exchangerate");
            entity.Property(e => e.Fee).HasColumnName("fee");
            entity.Property(e => e.Ocid).HasColumnName("ocid");
            entity.Property(e => e.Payerid)
                .HasMaxLength(30)
                .HasColumnName("payerid");
            entity.Property(e => e.Paymentstatus)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'unpaid')")
                .HasColumnName("paymentstatus");
            entity.Property(e => e.Paymenttype)
                .HasMaxLength(20)
                .HasColumnName("paymenttype");
            entity.Property(e => e.Pendingreason)
                .HasMaxLength(50)
                .HasColumnName("pendingreason");
            entity.Property(e => e.Reasoncode)
                .HasMaxLength(50)
                .HasColumnName("reasoncode");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'current')")
                .HasColumnName("status");
            entity.Property(e => e.Timestamp)
                .HasMaxLength(20)
                .HasColumnName("timestamp");
            entity.Property(e => e.Token)
                .HasMaxLength(50)
                .HasColumnName("token");
            entity.Property(e => e.Transactionid)
                .HasMaxLength(30)
                .HasColumnName("transactionid");
            entity.Property(e => e.Txnprocessed)
                .HasMaxLength(10)
                .HasDefaultValueSql("('no')")
                .HasColumnName("txnprocessed");
            entity.Property(e => e.Verifysign)
                .HasMaxLength(50)
                .HasColumnName("verifysign");
        });

        modelBuilder.Entity<Staff>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("staff");

            entity.Property(e => e.Address)
                .HasMaxLength(150)
                .HasColumnName("address");
            entity.Property(e => e.Admin).HasColumnName("admin");
            entity.Property(e => e.Alaccrued)
                .HasMaxLength(8)
                .HasColumnName("alaccrued");
            entity.Property(e => e.Alapproval).HasColumnName("alapproval");
            entity.Property(e => e.Almngr)
                .HasMaxLength(50)
                .HasColumnName("almngr");
            entity.Property(e => e.Bdcno)
                .HasMaxLength(15)
                .HasColumnName("BDCNo");
            entity.Property(e => e.Companyid).HasColumnName("companyid");
            entity.Property(e => e.Companyphone).HasColumnName("companyphone");
            entity.Property(e => e.Contactperson)
                .HasMaxLength(20)
                .HasColumnName("contactperson");
            entity.Property(e => e.Contactphone)
                .HasMaxLength(20)
                .HasColumnName("contactphone");
            entity.Property(e => e.Country)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("country");
            entity.Property(e => e.DepartId).HasColumnName("departID");
            entity.Property(e => e.DirectNo)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("directNo");
            entity.Property(e => e.Dob)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DOB");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.Enddate)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("enddate");
            entity.Property(e => e.ExtensionNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("extensionNo");
            entity.Property(e => e.FaxNo)
                .HasMaxLength(25)
                .HasColumnName("faxNo");
            entity.Property(e => e.Fname)
                .HasMaxLength(30)
                .HasColumnName("fname");
            entity.Property(e => e.Groupnumber).HasColumnName("groupnumber");
            entity.Property(e => e.HkNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("hkNo");
            entity.Property(e => e.Interest)
                .HasMaxLength(200)
                .HasColumnName("interest");
            entity.Property(e => e.Jobdescription)
                .HasMaxLength(200)
                .HasColumnName("jobdescription");
            entity.Property(e => e.Jobtype)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("jobtype");
            entity.Property(e => e.Kitchenduty)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("kitchenduty");
            entity.Property(e => e.Lname)
                .HasMaxLength(30)
                .HasColumnName("lname");
            entity.Property(e => e.Location)
                .HasMaxLength(30)
                .HasColumnName("location");
            entity.Property(e => e.Manager)
                .HasMaxLength(50)
                .HasColumnName("manager");
            entity.Property(e => e.MobNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("mobNo");
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .HasColumnName("password");
            entity.Property(e => e.Payrate).HasColumnName("payrate");
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("phoneNo");
            entity.Property(e => e.Photo)
                .HasMaxLength(20)
                .HasColumnName("photo");
            entity.Property(e => e.PlGroupId).HasColumnName("plGroupID");
            entity.Property(e => e.Postcode)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("postcode");
            entity.Property(e => e.Psallocate)
                .HasMaxLength(20)
                .HasColumnName("psallocate");
            entity.Property(e => e.Psentence)
                .HasMaxLength(50)
                .HasColumnName("psentence");
            entity.Property(e => e.Quotpermission)
                .HasMaxLength(60)
                .HasColumnName("quotpermission");
            entity.Property(e => e.Roll)
                .HasMaxLength(150)
                .HasColumnName("roll");
            entity.Property(e => e.SalesNo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("salesNo");
            entity.Property(e => e.Signon)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("signon");
            entity.Property(e => e.Skype)
                .HasMaxLength(50)
                .HasColumnName("skype");
            entity.Property(e => e.Sortcode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("sortcode");
            entity.Property(e => e.StaffId).HasColumnName("staffID");
            entity.Property(e => e.Stafflisting)
                .HasMaxLength(8)
                .HasColumnName("stafflisting");
            entity.Property(e => e.Staffposition)
                .HasMaxLength(150)
                .HasColumnName("staffposition");
            entity.Property(e => e.StartDateLsl)
                .HasColumnType("datetime")
                .HasColumnName("StartDateLSL");
            entity.Property(e => e.Startdate)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("startdate");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .HasColumnName("state");
            entity.Property(e => e.Status)
                .HasMaxLength(15)
                .HasColumnName("status");
            entity.Property(e => e.Suburb)
                .HasMaxLength(75)
                .HasColumnName("suburb");
            entity.Property(e => e.Username)
                .HasMaxLength(20)
                .HasColumnName("username");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
