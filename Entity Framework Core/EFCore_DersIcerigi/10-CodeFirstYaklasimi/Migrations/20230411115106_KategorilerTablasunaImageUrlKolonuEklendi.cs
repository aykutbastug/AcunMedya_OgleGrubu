using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _10_CodeFirstYaklasimi.Migrations
{
    /// <inheritdoc />
    public partial class KategorilerTablasunaImageUrlKolonuEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.Sql("update dbo.Categories set ImageUrl='#'");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Categories");
        }
    }
}
