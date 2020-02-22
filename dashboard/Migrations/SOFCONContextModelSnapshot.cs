﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dashboard.Models;

namespace dashboard.Migrations
{
    [DbContext(typeof(SOFCONContext))]
    partial class SOFCONContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("dashboard.Models.MovimGim", b =>
                {
                    b.Property<string>("SqlMcodbus")
                        .HasColumnName("SQL_MCODBUS")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.Property<decimal>("SqlMdatmov")
                        .HasColumnName("SQL_MDATMOV")
                        .HasColumnType("decimal(8, 0)");

                    b.Property<decimal>("SqlMrotcal")
                        .HasColumnName("SQL_MROTCAL")
                        .HasColumnType("decimal(2, 0)");

                    b.Property<decimal>("SqlMsequen")
                        .HasColumnName("SQL_MSEQUEN")
                        .HasColumnType("decimal(5, 0)");

                    b.Property<decimal>("SqlManomes")
                        .HasColumnName("SQL_MANOMES")
                        .HasColumnType("decimal(6, 0)");

                    b.Property<string>("SqlMcdbgra")
                        .IsRequired()
                        .HasColumnName("SQL_MCDBGRA")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<decimal>("SqlMchagra")
                        .HasColumnName("SQL_MCHAGRA")
                        .HasColumnType("decimal(5, 0)");

                    b.Property<decimal>("SqlMchalot")
                        .HasColumnName("SQL_MCHALOT")
                        .HasColumnType("decimal(5, 0)");

                    b.Property<decimal>("SqlMcharep")
                        .HasColumnName("SQL_MCHAREP")
                        .HasColumnType("decimal(5, 0)");

                    b.Property<decimal>("SqlMclient")
                        .HasColumnName("SQL_MCLIENT")
                        .HasColumnType("decimal(7, 0)");

                    b.Property<decimal>("SqlMcodccu")
                        .HasColumnName("SQL_MCODCCU")
                        .HasColumnType("decimal(5, 0)");

                    b.Property<decimal>("SqlMcodusu")
                        .HasColumnName("SQL_MCODUSU")
                        .HasColumnType("decimal(3, 0)");

                    b.Property<decimal>("SqlMcodven")
                        .HasColumnName("SQL_MCODVEN")
                        .HasColumnType("decimal(3, 0)");

                    b.Property<string>("SqlMcomven")
                        .IsRequired()
                        .HasColumnName("SQL_MCOMVEN")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<decimal>("SqlMcontro")
                        .HasColumnName("SQL_MCONTRO")
                        .HasColumnType("decimal(1, 0)");

                    b.Property<decimal>("SqlMcusven")
                        .HasColumnName("SQL_MCUSVEN")
                        .HasColumnType("decimal(15, 4)");

                    b.Property<decimal>("SqlMdatultalt")
                        .HasColumnName("SQL_MDATULTALT")
                        .HasColumnType("decimal(6, 0)");

                    b.Property<decimal>("SqlMdatval")
                        .HasColumnName("SQL_MDATVAL")
                        .HasColumnType("decimal(8, 0)");

                    b.Property<string>("SqlMdescor")
                        .IsRequired()
                        .HasColumnName("SQL_MDESCOR")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.Property<string>("SqlMdigver")
                        .IsRequired()
                        .HasColumnName("SQL_MDIGVER")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<string>("SqlMdocume")
                        .IsRequired()
                        .HasColumnName("SQL_MDOCUME")
                        .HasMaxLength(16)
                        .IsUnicode(false);

                    b.Property<string>("SqlMfiller")
                        .IsRequired()
                        .HasColumnName("SQL_MFILLER")
                        .HasMaxLength(24)
                        .IsUnicode(false);

                    b.Property<decimal>("SqlMfornec")
                        .HasColumnName("SQL_MFORNEC")
                        .HasColumnType("decimal(6, 0)");

                    b.Property<string>("SqlMindfab")
                        .IsRequired()
                        .HasColumnName("SQL_MINDFAB")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<string>("SqlMindgra")
                        .IsRequired()
                        .HasColumnName("SQL_MINDGRA")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<string>("SqlMindlot")
                        .IsRequired()
                        .HasColumnName("SQL_MINDLOT")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<decimal>("SqlMlote")
                        .HasColumnName("SQL_MLOTE")
                        .HasColumnType("decimal(2, 0)");

                    b.Property<string>("SqlMmovrep")
                        .IsRequired()
                        .HasColumnName("SQL_MMOVREP")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<string>("SqlMnumlot")
                        .IsRequired()
                        .HasColumnName("SQL_MNUMLOT")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<decimal>("SqlMordser")
                        .HasColumnName("SQL_MORDSER")
                        .HasColumnType("decimal(10, 0)");

                    b.Property<decimal>("SqlMprzven")
                        .HasColumnName("SQL_MPRZVEN")
                        .HasColumnType("decimal(5, 2)");

                    b.Property<decimal>("SqlMqtdmov")
                        .HasColumnName("SQL_MQTDMOV")
                        .HasColumnType("decimal(11, 3)");

                    b.Property<string>("SqlMrespen")
                        .IsRequired()
                        .HasColumnName("SQL_MRESPEN")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<decimal>("SqlMseqdig")
                        .HasColumnName("SQL_MSEQDIG")
                        .HasColumnType("decimal(7, 0)");

                    b.Property<decimal>("SqlMseqkil")
                        .HasColumnName("SQL_MSEQKIL")
                        .HasColumnType("decimal(2, 0)");

                    b.Property<decimal>("SqlMsubultcom")
                        .HasColumnName("SQL_MSUBULTCOM")
                        .HasColumnType("decimal(9, 2)");

                    b.Property<string>("SqlMtamanh")
                        .IsRequired()
                        .HasColumnName("SQL_MTAMANH")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("SqlMtippag")
                        .IsRequired()
                        .HasColumnName("SQL_MTIPPAG")
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    b.Property<string>("SqlMunidad")
                        .IsRequired()
                        .HasColumnName("SQL_MUNIDAD")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    b.Property<decimal>("SqlMvalagrtot")
                        .HasColumnName("SQL_MVALAGRTOT")
                        .HasColumnType("decimal(9, 2)");

                    b.Property<decimal>("SqlMvalmov")
                        .HasColumnName("SQL_MVALMOV")
                        .HasColumnType("decimal(15, 4)");

                    b.HasKey("SqlMcodbus", "SqlMdatmov", "SqlMrotcal", "SqlMsequen")
                        .HasName("PK__MOVIM_GI__F721DA235EBF139D");

                    b.HasIndex("SqlMdatultalt")
                        .HasName("SQL_CHMOVIM_UA");

                    b.HasIndex("SqlMclient", "SqlMdatmov")
                        .HasName("SQL_CHMOVIM_CD");

                    b.HasIndex("SqlMcodven", "SqlMdatmov")
                        .HasName("SQL_CHMOVIM_VD");

                    b.HasIndex("SqlManomes", "SqlMcodbus", "SqlMdatmov", "SqlMrotcal", "SqlMsequen")
                        .HasName("SQL_CHMOVIM_AM");

                    b.ToTable("MOVIM_GIM");
                });

            modelBuilder.Entity("dashboard.Models.Pedido", b =>
                {
                    b.Property<int>("IdPedido")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataEmissao");

                    b.Property<DateTime>("DataFaturamento");

                    b.Property<int>("IdCliente");

                    b.Property<int>("IdItem");

                    b.Property<int>("IdNfe");

                    b.Property<double>("QtdItem");

                    b.HasKey("IdPedido");

                    b.ToTable("pedidos");
                });

            modelBuilder.Entity("dashboard.Models.VendedorGim", b =>
                {
                    b.Property<decimal>("SqlVcodven")
                        .HasColumnName("SQL_VCODVEN")
                        .HasColumnType("decimal(3, 0)");

                    b.Property<string>("SqlVbancon")
                        .IsRequired()
                        .HasColumnName("SQL_VBANCON")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<decimal>("SqlVcepven")
                        .HasColumnName("SQL_VCEPVEN")
                        .HasColumnType("decimal(9, 0)");

                    b.Property<decimal>("SqlVcgccpf")
                        .HasColumnName("SQL_VCGCCPF")
                        .HasColumnType("decimal(14, 0)");

                    b.Property<string>("SqlVcidven")
                        .IsRequired()
                        .HasColumnName("SQL_VCIDVEN")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("SqlVcodaut")
                        .IsRequired()
                        .HasColumnName("SQL_VCODAUT")
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    b.Property<string>("SqlVcodreg")
                        .IsRequired()
                        .HasColumnName("SQL_VCODREG")
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    b.Property<decimal>("SqlVcodsup")
                        .HasColumnName("SQL_VCODSUP")
                        .HasColumnType("decimal(3, 0)");

                    b.Property<string>("SqlVcomissGru")
                        .IsRequired()
                        .HasColumnName("SQL_VCOMISS_GRU")
                        .HasMaxLength(32)
                        .IsUnicode(false);

                    b.Property<decimal>("SqlVcomissvel")
                        .HasColumnName("SQL_VCOMISSVEL")
                        .HasColumnType("decimal(4, 2)");

                    b.Property<string>("SqlVcotasGru")
                        .IsRequired()
                        .HasColumnName("SQL_VCOTAS_GRU")
                        .HasMaxLength(180)
                        .IsUnicode(false);

                    b.Property<decimal>("SqlVcushor")
                        .HasColumnName("SQL_VCUSHOR")
                        .HasColumnType("decimal(9, 2)");

                    b.Property<decimal>("SqlVdatcad")
                        .HasColumnName("SQL_VDATCAD")
                        .HasColumnType("decimal(8, 0)");

                    b.Property<string>("SqlVemaven")
                        .IsRequired()
                        .HasColumnName("SQL_VEMAVEN")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("SqlVendven")
                        .IsRequired()
                        .HasColumnName("SQL_VENDVEN")
                        .HasMaxLength(40)
                        .IsUnicode(false);

                    b.Property<string>("SqlVestven")
                        .IsRequired()
                        .HasColumnName("SQL_VESTVEN")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    b.Property<string>("SqlVfaxven")
                        .IsRequired()
                        .HasColumnName("SQL_VFAXVEN")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.Property<string>("SqlVfiller")
                        .IsRequired()
                        .HasColumnName("SQL_VFILLER")
                        .HasMaxLength(36)
                        .IsUnicode(false);

                    b.Property<decimal>("SqlVidenti")
                        .HasColumnName("SQL_VIDENTI")
                        .HasColumnType("decimal(13, 0)");

                    b.Property<string>("SqlVindfve")
                        .IsRequired()
                        .HasColumnName("SQL_VINDFVE")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<string>("SqlVinsest")
                        .IsRequired()
                        .HasColumnName("SQL_VINSEST")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.Property<string>("SqlVlispre")
                        .IsRequired()
                        .HasColumnName("SQL_VLISPRE")
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    b.Property<string>("SqlVnompt1")
                        .IsRequired()
                        .HasColumnName("SQL_VNOMPT1")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.Property<string>("SqlVnompt2")
                        .IsRequired()
                        .HasColumnName("SQL_VNOMPT2")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("SqlVobserv")
                        .IsRequired()
                        .HasColumnName("SQL_VOBSERV")
                        .HasMaxLength(40)
                        .IsUnicode(false);

                    b.Property<string>("SqlVpescon")
                        .IsRequired()
                        .HasColumnName("SQL_VPESCON")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.Property<string>("SqlVprarec")
                        .IsRequired()
                        .HasColumnName("SQL_VPRAREC")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("SqlVtelven")
                        .IsRequired()
                        .HasColumnName("SQL_VTELVEN")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<decimal>("SqlVtipo")
                        .HasColumnName("SQL_VTIPO")
                        .HasColumnType("decimal(2, 0)");

                    b.HasKey("SqlVcodven")
                        .HasName("PK__VENDEDOR__67C348E0367C1819");

                    b.HasIndex("SqlVnompt1")
                        .HasName("SQL_VNOMPT1");

                    b.ToTable("VENDEDOR_GIM");
                });
#pragma warning restore 612, 618
        }
    }
}
