using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KuruTemizleme.App.Migrations
{
    /// <inheritdoc />
    public partial class DB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LogKayit",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kullaniciId = table.Column<int>(type: "int", nullable: false),
                    yapilanIslem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tarihSaat = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogKayit", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Randevu",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    musteriAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    makbuz = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kiyafetTip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    musteriNo = table.Column<int>(type: "int", nullable: false),
                    teslim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    adet = table.Column<int>(type: "int", nullable: false),
                    tutar = table.Column<float>(type: "real", nullable: false),
                    durum = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Randevu", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Ucretler",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    islemAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ucret = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ucretler", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cinsiyet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sifre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LogKayit_id",
                table: "LogKayit",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Randevu_id",
                table: "Randevu",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ucretler_id",
                table: "Ucretler",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_id",
                table: "Users",
                column: "id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LogKayit");

            migrationBuilder.DropTable(
                name: "Randevu");

            migrationBuilder.DropTable(
                name: "Ucretler");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
