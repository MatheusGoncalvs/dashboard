using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace dashboard.Models
{
    public partial class SOFCONContext : DbContext
    {
        public SOFCONContext()
        {
        }

        public SOFCONContext(DbContextOptions<SOFCONContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MovimGim> MovimGim { get; set; }

        public virtual DbSet<VendedorGim> VendedorGim { get; set; }

        public virtual DbSet<Pedido> pedidos { get; set; }

        // Unable to generate entity type for table 'dbo.ZLog_Pedidos_Gim'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //Se não estivesse configurado o acesso ao banco (APAGUEI)
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");


            modelBuilder.Entity<MovimGim>(entity =>
            {
                entity.HasKey(e => new { e.SqlMcodbus, e.SqlMdatmov, e.SqlMrotcal, e.SqlMsequen })
                    .HasName("PK__MOVIM_GI__F721DA235EBF139D");

                entity.ToTable("MOVIM_GIM");

                entity.HasIndex(e => e.SqlMdatultalt)
                    .HasName("SQL_CHMOVIM_UA");

                entity.HasIndex(e => new { e.SqlMclient, e.SqlMdatmov })
                    .HasName("SQL_CHMOVIM_CD");

                entity.HasIndex(e => new { e.SqlMcodven, e.SqlMdatmov })
                    .HasName("SQL_CHMOVIM_VD");

                entity.HasIndex(e => new { e.SqlManomes, e.SqlMcodbus, e.SqlMdatmov, e.SqlMrotcal, e.SqlMsequen })
                    .HasName("SQL_CHMOVIM_AM");

                entity.Property(e => e.SqlMcodbus)
                    .HasColumnName("SQL_MCODBUS")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SqlMdatmov)
                    .HasColumnName("SQL_MDATMOV")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.SqlMrotcal)
                    .HasColumnName("SQL_MROTCAL")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.SqlMsequen)
                    .HasColumnName("SQL_MSEQUEN")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.SqlManomes)
                    .HasColumnName("SQL_MANOMES")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.SqlMcdbgra)
                    .IsRequired()
                    .HasColumnName("SQL_MCDBGRA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SqlMchagra)
                    .HasColumnName("SQL_MCHAGRA")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.SqlMchalot)
                    .HasColumnName("SQL_MCHALOT")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.SqlMcharep)
                    .HasColumnName("SQL_MCHAREP")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.SqlMclient)
                    .HasColumnName("SQL_MCLIENT")
                    .HasColumnType("decimal(7, 0)");

                entity.Property(e => e.SqlMcodccu)
                    .HasColumnName("SQL_MCODCCU")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.SqlMcodusu)
                    .HasColumnName("SQL_MCODUSU")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.SqlMcodven)
                    .HasColumnName("SQL_MCODVEN")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.SqlMcomven)
                    .IsRequired()
                    .HasColumnName("SQL_MCOMVEN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SqlMcontro)
                    .HasColumnName("SQL_MCONTRO")
                    .HasColumnType("decimal(1, 0)");

                entity.Property(e => e.SqlMcusven)
                    .HasColumnName("SQL_MCUSVEN")
                    .HasColumnType("decimal(15, 4)");

                entity.Property(e => e.SqlMdatultalt)
                    .HasColumnName("SQL_MDATULTALT")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.SqlMdatval)
                    .HasColumnName("SQL_MDATVAL")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.SqlMdescor)
                    .IsRequired()
                    .HasColumnName("SQL_MDESCOR")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SqlMdigver)
                    .IsRequired()
                    .HasColumnName("SQL_MDIGVER")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SqlMdocume)
                    .IsRequired()
                    .HasColumnName("SQL_MDOCUME")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.SqlMfiller)
                    .IsRequired()
                    .HasColumnName("SQL_MFILLER")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.SqlMfornec)
                    .HasColumnName("SQL_MFORNEC")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.SqlMindfab)
                    .IsRequired()
                    .HasColumnName("SQL_MINDFAB")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SqlMindgra)
                    .IsRequired()
                    .HasColumnName("SQL_MINDGRA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SqlMindlot)
                    .IsRequired()
                    .HasColumnName("SQL_MINDLOT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SqlMlote)
                    .HasColumnName("SQL_MLOTE")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.SqlMmovrep)
                    .IsRequired()
                    .HasColumnName("SQL_MMOVREP")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SqlMnumlot)
                    .IsRequired()
                    .HasColumnName("SQL_MNUMLOT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SqlMordser)
                    .HasColumnName("SQL_MORDSER")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.SqlMprzven)
                    .HasColumnName("SQL_MPRZVEN")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.SqlMqtdmov)
                    .HasColumnName("SQL_MQTDMOV")
                    .HasColumnType("decimal(11, 3)");

                entity.Property(e => e.SqlMrespen)
                    .IsRequired()
                    .HasColumnName("SQL_MRESPEN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SqlMseqdig)
                    .HasColumnName("SQL_MSEQDIG")
                    .HasColumnType("decimal(7, 0)");

                entity.Property(e => e.SqlMseqkil)
                    .HasColumnName("SQL_MSEQKIL")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.SqlMsubultcom)
                    .HasColumnName("SQL_MSUBULTCOM")
                    .HasColumnType("decimal(9, 2)");

                entity.Property(e => e.SqlMtamanh)
                    .IsRequired()
                    .HasColumnName("SQL_MTAMANH")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SqlMtippag)
                    .IsRequired()
                    .HasColumnName("SQL_MTIPPAG")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SqlMunidad)
                    .IsRequired()
                    .HasColumnName("SQL_MUNIDAD")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SqlMvalagrtot)
                    .HasColumnName("SQL_MVALAGRTOT")
                    .HasColumnType("decimal(9, 2)");

                entity.Property(e => e.SqlMvalmov)
                    .HasColumnName("SQL_MVALMOV")
                    .HasColumnType("decimal(15, 4)");
            });

            modelBuilder.Entity<VendedorGim>(entity =>
            {
                entity.HasKey(e => e.SqlVcodven)
                    .HasName("PK__VENDEDOR__67C348E0367C1819");

                entity.ToTable("VENDEDOR_GIM");

                entity.HasIndex(e => e.SqlVnompt1)
                    .HasName("SQL_VNOMPT1");

                entity.Property(e => e.SqlVcodven)
                    .HasColumnName("SQL_VCODVEN")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.SqlVbancon)
                    .IsRequired()
                    .HasColumnName("SQL_VBANCON")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SqlVcepven)
                    .HasColumnName("SQL_VCEPVEN")
                    .HasColumnType("decimal(9, 0)");

                entity.Property(e => e.SqlVcgccpf)
                    .HasColumnName("SQL_VCGCCPF")
                    .HasColumnType("decimal(14, 0)");

                entity.Property(e => e.SqlVcidven)
                    .IsRequired()
                    .HasColumnName("SQL_VCIDVEN")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SqlVcodaut)
                    .IsRequired()
                    .HasColumnName("SQL_VCODAUT")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SqlVcodreg)
                    .IsRequired()
                    .HasColumnName("SQL_VCODREG")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SqlVcodsup)
                    .HasColumnName("SQL_VCODSUP")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.SqlVcomissGru)
                    .IsRequired()
                    .HasColumnName("SQL_VCOMISS_GRU")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SqlVcomissvel)
                    .HasColumnName("SQL_VCOMISSVEL")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.SqlVcotasGru)
                    .IsRequired()
                    .HasColumnName("SQL_VCOTAS_GRU")
                    .HasMaxLength(180)
                    .IsUnicode(false);

                entity.Property(e => e.SqlVcushor)
                    .HasColumnName("SQL_VCUSHOR")
                    .HasColumnType("decimal(9, 2)");

                entity.Property(e => e.SqlVdatcad)
                    .HasColumnName("SQL_VDATCAD")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.SqlVemaven)
                    .IsRequired()
                    .HasColumnName("SQL_VEMAVEN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SqlVendven)
                    .IsRequired()
                    .HasColumnName("SQL_VENDVEN")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SqlVestven)
                    .IsRequired()
                    .HasColumnName("SQL_VESTVEN")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SqlVfaxven)
                    .IsRequired()
                    .HasColumnName("SQL_VFAXVEN")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SqlVfiller)
                    .IsRequired()
                    .HasColumnName("SQL_VFILLER")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.SqlVidenti)
                    .HasColumnName("SQL_VIDENTI")
                    .HasColumnType("decimal(13, 0)");

                entity.Property(e => e.SqlVindfve)
                    .IsRequired()
                    .HasColumnName("SQL_VINDFVE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SqlVinsest)
                    .IsRequired()
                    .HasColumnName("SQL_VINSEST")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SqlVlispre)
                    .IsRequired()
                    .HasColumnName("SQL_VLISPRE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SqlVnompt1)
                    .IsRequired()
                    .HasColumnName("SQL_VNOMPT1")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SqlVnompt2)
                    .IsRequired()
                    .HasColumnName("SQL_VNOMPT2")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SqlVobserv)
                    .IsRequired()
                    .HasColumnName("SQL_VOBSERV")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SqlVpescon)
                    .IsRequired()
                    .HasColumnName("SQL_VPESCON")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SqlVprarec)
                    .IsRequired()
                    .HasColumnName("SQL_VPRAREC")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SqlVtelven)
                    .IsRequired()
                    .HasColumnName("SQL_VTELVEN")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SqlVtipo)
                    .HasColumnName("SQL_VTIPO")
                    .HasColumnType("decimal(2, 0)");
            });
        }
    }
}
