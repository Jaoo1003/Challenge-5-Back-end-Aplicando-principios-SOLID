using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Challenge_5_.NET.Migrations
{
    public partial class RelacionandovideocomumaCategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Videos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Videos_CategoriaId",
                table: "Videos",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Videos_Categorias_CategoriaId",
                table: "Videos",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Videos_Categorias_CategoriaId",
                table: "Videos");

            migrationBuilder.DropIndex(
                name: "IX_Videos_CategoriaId",
                table: "Videos");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Videos");
        }
    }
}
