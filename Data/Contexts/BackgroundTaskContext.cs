using Data.Databases.BackgroundTask;

namespace Data.Contexts;

public partial class BackgroundTaskContext : DbContext
{
    public BackgroundTaskContext()
    {
    }

    public BackgroundTaskContext(DbContextOptions<BackgroundTaskContext> options)
        : base(options)
    {
    }

    public virtual DbSet<PushQueue> PushQueues { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {			
		}
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PushQueue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PushQueu__3214EC07B9E6D16F");

            entity.ToTable("PushQueue");

            entity.Property(e => e.Action)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Queue).HasColumnType("text");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
