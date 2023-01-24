using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projeto_radar_backend.Migrations
{
    public partial class Correcao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pedidos_clientes_cliente_id",
                table: "pedidos");

            migrationBuilder.DropIndex(
                name: "IX_pedidos_cliente_id",
                table: "pedidos");

            migrationBuilder.AlterColumn<decimal>(
                name: "valor_total",
                table: "pedidos",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "longitude",
                table: "lojas",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "longitude",
                table: "lojas");

            migrationBuilder.AlterColumn<decimal>(
                name: "valor_total",
                table: "pedidos",
                type: "decimal(65,30)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.CreateIndex(
                name: "IX_pedidos_cliente_id",
                table: "pedidos",
                column: "cliente_id");

            migrationBuilder.AddForeignKey(
                name: "FK_pedidos_clientes_cliente_id",
                table: "pedidos",
                column: "cliente_id",
                principalTable: "clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
