using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APBD_T7_s33596.Infrastructure.DB.Migrations
{
    /// <inheritdoc />
    public partial class FixNaming : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Attribute",
                table: "ComponentManufacturers",
                newName: "Abbreviation");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Abbreviation",
                table: "ComponentManufacturers",
                newName: "Attribute");
        }
    }
}
