using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DevExtremeAsp.Models
{
    public partial class DevExtremeAspDBContext : DbContext
    {
        public DevExtremeAspDBContext()
        {
        }

        public DevExtremeAspDBContext(DbContextOptions<DevExtremeAspDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TMaterial> TMaterials { get; set; }
        public virtual DbSet<TPerson> TPersons { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=MyErpDB;user=SA;password=Debian19+");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");


            modelBuilder.Entity<TMaterial>(entity =>
            
            {
                entity.HasKey(e => e.MatId)
                    .HasName("PK__T_Materi__294E795529ACFE54");

                entity.ToTable("T_Material");

                entity.Property(e => e.MatClass).HasMaxLength(25);

                entity.Property(e => e.MatDescr).HasMaxLength(225);

                entity.Property(e => e.MatRefer).HasMaxLength(125);

                entity.Property(e => e.MatStDate).HasColumnType("datetime");

                entity.Property(e => e.MatStatus).HasMaxLength(125);

                entity.Property(e => e.MatType).HasMaxLength(25);

                entity.Property(e => e.MatUnMed).HasMaxLength(25);
            });
            modelBuilder.Entity<TPerson>(entity =>
            {
                entity.HasKey(e => e.PerId)
                    .HasName("PK__T_Person__496D3DD0FE8E8B1D");

                entity.ToTable("T_Person");

                entity.Property(e => e.PerAddCtry).HasMaxLength(4);

                entity.Property(e => e.PerAddr).HasMaxLength(255);

                entity.Property(e => e.PerAddr1).HasMaxLength(255);

                entity.Property(e => e.PerBiCity).HasMaxLength(100);

                entity.Property(e => e.PerBiCtry).HasMaxLength(4);

                entity.Property(e => e.PerBird).HasColumnType("datetime");

                entity.Property(e => e.PerContDate).HasColumnType("datetime");

                entity.Property(e => e.PerDni)
                    .HasMaxLength(10)
                    .HasColumnName("PerDNI");

                entity.Property(e => e.PerEntDate).HasColumnType("datetime");

                entity.Property(e => e.PerExiDate).HasColumnType("datetime");

                entity.Property(e => e.PerName).HasMaxLength(100);

                entity.Property(e => e.PerName1).HasMaxLength(100);
            });


            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
