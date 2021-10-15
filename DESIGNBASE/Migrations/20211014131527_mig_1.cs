using Microsoft.EntityFrameworkCore.Migrations;

namespace DESIGNBASE.Migrations
{
    public partial class mig_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjeGenel",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TASARIM_BELGESI_NO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TRAFO_TANIM_KODU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PROJE_ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FREKANS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SOGUTMA_SEKLI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SOGUTMA_SEKLI1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SOGUTMA_SEKLI2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SOGUTMA_SEKLI3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SARGI_SAYISI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BAGLANTI_GRUBU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IMALAT_NORMU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DENGELEME_SARGISI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TETA_MUH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SARGI_SIC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YAG_SIC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CALISMA_YERI_SIC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CALISMA_YERI_YUK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MAX_KD_SURESI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SARIM_GERILIMI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TOPLAM_BAKIR_AGIRLIGI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SARGI_OLCULERI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ACIKALAMALAR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PROJE_NO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SIPARIS_NO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TASARIM_NO = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjeGenel", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjeGenel");
        }
    }
}
