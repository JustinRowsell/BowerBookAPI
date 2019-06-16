using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Configuration;

namespace BowerBookAPI.Data
{
    public partial class CoreContext : DbContext
    {
        public CoreContext()
        {
        }

        public CoreContext(DbContextOptions<CoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Interest> Interest { get; set; }
        public virtual DbSet<Progress> Progress { get; set; }
        public virtual DbSet<Resource> Resource { get; set; }
        public virtual DbSet<Tag> Tag { get; set; }

        // Unable to generate entity type for table 'public.InterestResourceRel'. Please see the warning messages.
        // Unable to generate entity type for table 'public.InterestTagRel'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(ConfigurationManager.ConnectionStrings["CoreDatabase"].ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity<Interest>(entity =>
            {
                entity.Property(e => e.InterestId).ValueGeneratedNever();

                entity.Property(e => e.Category).HasMaxLength(55);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.InterestName).HasMaxLength(55);
            });

            modelBuilder.Entity<Progress>(entity =>
            {
                entity.Property(e => e.ProgressId).ValueGeneratedNever();

                entity.Property(e => e.Color).HasColumnType("character(55)");

                entity.Property(e => e.ProgressName).HasColumnType("character(55)");
            });

            modelBuilder.Entity<Resource>(entity =>
            {
                entity.Property(e => e.ResourceId).ValueGeneratedNever();

                entity.Property(e => e.Link).HasColumnType("character(255)");

                entity.Property(e => e.ResourceName).HasColumnType("character(55)");

                entity.HasOne(d => d.Progress)
                    .WithMany(p => p.Resource)
                    .HasForeignKey(d => d.ProgressId)
                    .HasConstraintName("Resource_Progress_FK");
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.Property(e => e.TagId).ValueGeneratedNever();

                entity.Property(e => e.TagName)
                    .IsRequired()
                    .HasColumnType("character(55)");
            });
        }
    }
}
