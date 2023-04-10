using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _10_CodeFirstYaklasimi.Migrations
{
    /// <inheritdoc />
    public partial class AlterColumnproductsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UnitePrice",
                table: "Products",
                newName: "Price");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Products",
                newName: "UnitePrice");
        }
    }
}
