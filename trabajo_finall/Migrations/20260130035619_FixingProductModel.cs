using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace trabajo_finall.Migrations
{
    /// <inheritdoc />
    public partial class FixingProductModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ventas",
                table: "ventas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_productos",
                table: "productos");

            migrationBuilder.RenameTable(
                name: "ventas",
                newName: "Ventas");

            migrationBuilder.RenameTable(
                name: "productos",
                newName: "Productos");

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Productos",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldMaxLength: 100);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ventas",
                table: "Ventas",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Productos",
                table: "Productos",
                column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Ventas",
                table: "Ventas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Productos",
                table: "Productos");

            migrationBuilder.RenameTable(
                name: "Ventas",
                newName: "ventas");

            migrationBuilder.RenameTable(
                name: "Productos",
                newName: "productos");

            migrationBuilder.AlterColumn<int>(
                name: "nombre",
                table: "productos",
                type: "integer",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ventas",
                table: "ventas",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_productos",
                table: "productos",
                column: "id");
        }
    }
}
