using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UsuarioVideoAPI.Migrations
{
    public partial class Adicionandorolenobanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 1, "f883b18b-7c73-445a-8513-782fd8f20d48", "cadastrado", "CADASTRADO" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
