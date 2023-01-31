using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UsuarioVideoAPI.Migrations
{
    public partial class teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "33d535d6-7cb8-443a-9499-fc576fad9be4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "1795d02a-c85d-4f11-904e-2c8a0f6439f2");
        }
    }
}
