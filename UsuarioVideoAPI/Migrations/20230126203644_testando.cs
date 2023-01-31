using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UsuarioVideoAPI.Migrations
{
    public partial class testando : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "1795d02a-c85d-4f11-904e-2c8a0f6439f2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "f883b18b-7c73-445a-8513-782fd8f20d48");
        }
    }
}
