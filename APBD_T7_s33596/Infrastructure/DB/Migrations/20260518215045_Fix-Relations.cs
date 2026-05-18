using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APBD_T7_s33596.Infrastructure.DB.Migrations
{
    /// <inheritdoc />
    public partial class FixRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Components_ComponentManufacturers_ComponentManufacturerId",
                table: "Components");

            migrationBuilder.DropColumn(
                name: "ComponentManufacturersId",
                table: "Components");

            migrationBuilder.AlterColumn<int>(
                name: "ComponentManufacturerId",
                table: "Components",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Code",
                keyValue: "I9-14900K",
                column: "ComponentManufacturerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Code",
                keyValue: "R9-7950X",
                column: "ComponentManufacturerId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Code",
                keyValue: "RTX4090",
                column: "ComponentManufacturerId",
                value: 3);

            migrationBuilder.AddForeignKey(
                name: "FK_Components_ComponentManufacturers_ComponentManufacturerId",
                table: "Components",
                column: "ComponentManufacturerId",
                principalTable: "ComponentManufacturers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Components_ComponentManufacturers_ComponentManufacturerId",
                table: "Components");

            migrationBuilder.AlterColumn<int>(
                name: "ComponentManufacturerId",
                table: "Components",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ComponentManufacturersId",
                table: "Components",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Code",
                keyValue: "I9-14900K",
                columns: new[] { "ComponentManufacturerId", "ComponentManufacturersId" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Code",
                keyValue: "R9-7950X",
                columns: new[] { "ComponentManufacturerId", "ComponentManufacturersId" },
                values: new object[] { null, 2 });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Code",
                keyValue: "RTX4090",
                columns: new[] { "ComponentManufacturerId", "ComponentManufacturersId" },
                values: new object[] { null, 3 });

            migrationBuilder.AddForeignKey(
                name: "FK_Components_ComponentManufacturers_ComponentManufacturerId",
                table: "Components",
                column: "ComponentManufacturerId",
                principalTable: "ComponentManufacturers",
                principalColumn: "Id");
        }
    }
}
