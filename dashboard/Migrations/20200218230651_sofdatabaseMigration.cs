using Microsoft.EntityFrameworkCore.Migrations;

namespace dashboard.Migrations
{
    public partial class sofdatabaseMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MOVIM_GIM",
                columns: table => new
                {
                    SQL_MCODBUS = table.Column<string>(unicode: false, maxLength: 15, nullable: false),
                    SQL_MDATMOV = table.Column<decimal>(type: "decimal(8, 0)", nullable: false),
                    SQL_MROTCAL = table.Column<decimal>(type: "decimal(2, 0)", nullable: false),
                    SQL_MSEQUEN = table.Column<decimal>(type: "decimal(5, 0)", nullable: false),
                    SQL_MCONTRO = table.Column<decimal>(type: "decimal(1, 0)", nullable: false),
                    SQL_MANOMES = table.Column<decimal>(type: "decimal(6, 0)", nullable: false),
                    SQL_MSEQDIG = table.Column<decimal>(type: "decimal(7, 0)", nullable: false),
                    SQL_MDIGVER = table.Column<string>(unicode: false, maxLength: 1, nullable: false),
                    SQL_MLOTE = table.Column<decimal>(type: "decimal(2, 0)", nullable: false),
                    SQL_MDOCUME = table.Column<string>(unicode: false, maxLength: 16, nullable: false),
                    SQL_MORDSER = table.Column<decimal>(type: "decimal(10, 0)", nullable: false),
                    SQL_MFORNEC = table.Column<decimal>(type: "decimal(6, 0)", nullable: false),
                    SQL_MCLIENT = table.Column<decimal>(type: "decimal(7, 0)", nullable: false),
                    SQL_MCODVEN = table.Column<decimal>(type: "decimal(3, 0)", nullable: false),
                    SQL_MCOMVEN = table.Column<string>(unicode: false, maxLength: 1, nullable: false),
                    SQL_MCODCCU = table.Column<decimal>(type: "decimal(5, 0)", nullable: false),
                    SQL_MUNIDAD = table.Column<string>(unicode: false, maxLength: 2, nullable: false),
                    SQL_MQTDMOV = table.Column<decimal>(type: "decimal(11, 3)", nullable: false),
                    SQL_MVALMOV = table.Column<decimal>(type: "decimal(15, 4)", nullable: false),
                    SQL_MCUSVEN = table.Column<decimal>(type: "decimal(15, 4)", nullable: false),
                    SQL_MTIPPAG = table.Column<string>(unicode: false, maxLength: 3, nullable: false),
                    SQL_MPRZVEN = table.Column<decimal>(type: "decimal(5, 2)", nullable: false),
                    SQL_MSEQKIL = table.Column<decimal>(type: "decimal(2, 0)", nullable: false),
                    SQL_MSUBULTCOM = table.Column<decimal>(type: "decimal(9, 2)", nullable: false),
                    SQL_MVALAGRTOT = table.Column<decimal>(type: "decimal(9, 2)", nullable: false),
                    SQL_MINDFAB = table.Column<string>(unicode: false, maxLength: 1, nullable: false),
                    SQL_MINDLOT = table.Column<string>(unicode: false, maxLength: 1, nullable: false),
                    SQL_MNUMLOT = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    SQL_MDATVAL = table.Column<decimal>(type: "decimal(8, 0)", nullable: false),
                    SQL_MCHALOT = table.Column<decimal>(type: "decimal(5, 0)", nullable: false),
                    SQL_MINDGRA = table.Column<string>(unicode: false, maxLength: 1, nullable: false),
                    SQL_MDESCOR = table.Column<string>(unicode: false, maxLength: 15, nullable: false),
                    SQL_MTAMANH = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    SQL_MCDBGRA = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    SQL_MCHAGRA = table.Column<decimal>(type: "decimal(5, 0)", nullable: false),
                    SQL_MRESPEN = table.Column<string>(unicode: false, maxLength: 1, nullable: false),
                    SQL_MMOVREP = table.Column<string>(unicode: false, maxLength: 1, nullable: false),
                    SQL_MCHAREP = table.Column<decimal>(type: "decimal(5, 0)", nullable: false),
                    SQL_MCODUSU = table.Column<decimal>(type: "decimal(3, 0)", nullable: false),
                    SQL_MDATULTALT = table.Column<decimal>(type: "decimal(6, 0)", nullable: false),
                    SQL_MFILLER = table.Column<string>(unicode: false, maxLength: 24, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__MOVIM_GI__F721DA235EBF139D", x => new { x.SQL_MCODBUS, x.SQL_MDATMOV, x.SQL_MROTCAL, x.SQL_MSEQUEN });
                });

            migrationBuilder.CreateTable(
                name: "VENDEDOR_GIM",
                columns: table => new
                {
                    SQL_VCODVEN = table.Column<decimal>(type: "decimal(3, 0)", nullable: false),
                    SQL_VNOMPT1 = table.Column<string>(unicode: false, maxLength: 15, nullable: false),
                    SQL_VNOMPT2 = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    SQL_VENDVEN = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    SQL_VCIDVEN = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    SQL_VESTVEN = table.Column<string>(unicode: false, maxLength: 2, nullable: false),
                    SQL_VCEPVEN = table.Column<decimal>(type: "decimal(9, 0)", nullable: false),
                    SQL_VTELVEN = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    SQL_VFAXVEN = table.Column<string>(unicode: false, maxLength: 15, nullable: false),
                    SQL_VPESCON = table.Column<string>(unicode: false, maxLength: 15, nullable: false),
                    SQL_VINSEST = table.Column<string>(unicode: false, maxLength: 15, nullable: false),
                    SQL_VPRAREC = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    SQL_VIDENTI = table.Column<decimal>(type: "decimal(13, 0)", nullable: false),
                    SQL_VDATCAD = table.Column<decimal>(type: "decimal(8, 0)", nullable: false),
                    SQL_VOBSERV = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    SQL_VLISPRE = table.Column<string>(unicode: false, maxLength: 3, nullable: false),
                    SQL_VTIPO = table.Column<decimal>(type: "decimal(2, 0)", nullable: false),
                    SQL_VCGCCPF = table.Column<decimal>(type: "decimal(14, 0)", nullable: false),
                    SQL_VCOMISSVEL = table.Column<decimal>(type: "decimal(4, 2)", nullable: false),
                    SQL_VBANCON = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    SQL_VCOMISS_GRU = table.Column<string>(unicode: false, maxLength: 32, nullable: false),
                    SQL_VCOTAS_GRU = table.Column<string>(unicode: false, maxLength: 180, nullable: false),
                    SQL_VCUSHOR = table.Column<decimal>(type: "decimal(9, 2)", nullable: false),
                    SQL_VCODAUT = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    SQL_VCODREG = table.Column<string>(unicode: false, maxLength: 3, nullable: false),
                    SQL_VINDFVE = table.Column<string>(unicode: false, maxLength: 1, nullable: false),
                    SQL_VCODSUP = table.Column<decimal>(type: "decimal(3, 0)", nullable: false),
                    SQL_VEMAVEN = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    SQL_VFILLER = table.Column<string>(unicode: false, maxLength: 36, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__VENDEDOR__67C348E0367C1819", x => x.SQL_VCODVEN);
                });

            migrationBuilder.CreateIndex(
                name: "SQL_CHMOVIM_UA",
                table: "MOVIM_GIM",
                column: "SQL_MDATULTALT");

            migrationBuilder.CreateIndex(
                name: "SQL_CHMOVIM_CD",
                table: "MOVIM_GIM",
                columns: new[] { "SQL_MCLIENT", "SQL_MDATMOV" });

            migrationBuilder.CreateIndex(
                name: "SQL_CHMOVIM_VD",
                table: "MOVIM_GIM",
                columns: new[] { "SQL_MCODVEN", "SQL_MDATMOV" });

            migrationBuilder.CreateIndex(
                name: "SQL_CHMOVIM_AM",
                table: "MOVIM_GIM",
                columns: new[] { "SQL_MANOMES", "SQL_MCODBUS", "SQL_MDATMOV", "SQL_MROTCAL", "SQL_MSEQUEN" });

            migrationBuilder.CreateIndex(
                name: "SQL_VNOMPT1",
                table: "VENDEDOR_GIM",
                column: "SQL_VNOMPT1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MOVIM_GIM");

            migrationBuilder.DropTable(
                name: "VENDEDOR_GIM");
        }
    }
}
