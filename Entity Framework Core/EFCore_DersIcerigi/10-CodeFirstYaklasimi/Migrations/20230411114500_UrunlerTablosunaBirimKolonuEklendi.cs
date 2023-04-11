using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _10_CodeFirstYaklasimi.Migrations
{
    /// <inheritdoc />
    public partial class UrunlerTablosunaBirimKolonuEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.Sql("update dbo.Products set Unit='Adet'");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Unit",
                table: "Products");
        }
    }
}
