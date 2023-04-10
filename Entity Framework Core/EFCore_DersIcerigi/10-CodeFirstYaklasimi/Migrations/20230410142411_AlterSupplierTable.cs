using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _10_CodeFirstYaklasimi.Migrations
{
    /// <inheritdoc />
    public partial class AlterSupplierTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Suppliers");
        }
    }
}
