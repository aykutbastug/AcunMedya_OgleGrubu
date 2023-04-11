using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _10_CodeFirstYaklasimi.Migrations
{
    /// <inheritdoc />
    public partial class KateorilerTablosundanImageUrlKolonuKaldirildi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Categories");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
