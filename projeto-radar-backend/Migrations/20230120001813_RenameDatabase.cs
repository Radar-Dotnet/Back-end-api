using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projeto_radar_backend.Migrations
{
    public partial class RenameDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Clientes_ClienteId",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidosProdutos_Pedidos_PedidoId",
                table: "PedidosProdutos");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidosProdutos_Produtos_ProdutoId",
                table: "PedidosProdutos");

            migrationBuilder.DropForeignKey(
                name: "FK_PosicoesProdutos_Campanhas_CampanhaId",
                table: "PosicoesProdutos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Produtos",
                table: "Produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PosicoesProdutos",
                table: "PosicoesProdutos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PedidosProdutos",
                table: "PedidosProdutos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pedidos",
                table: "Pedidos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lojas",
                table: "Lojas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Campanhas",
                table: "Campanhas");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Lojas");

            migrationBuilder.RenameTable(
                name: "Produtos",
                newName: "produtos");

            migrationBuilder.RenameTable(
                name: "PosicoesProdutos",
                newName: "posicoesprodutos");

            migrationBuilder.RenameTable(
                name: "PedidosProdutos",
                newName: "pedidosprodutos");

            migrationBuilder.RenameTable(
                name: "Pedidos",
                newName: "pedidos");

            migrationBuilder.RenameTable(
                name: "Lojas",
                newName: "lojas");

            migrationBuilder.RenameTable(
                name: "Clientes",
                newName: "clientes");

            migrationBuilder.RenameTable(
                name: "Campanhas",
                newName: "campanhas");

            migrationBuilder.RenameColumn(
                name: "Valor",
                table: "produtos",
                newName: "valor");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "produtos",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "produtos",
                newName: "descricao");

            migrationBuilder.RenameColumn(
                name: "QtdEstoque",
                table: "produtos",
                newName: "qtd_estoque");

            migrationBuilder.RenameColumn(
                name: "PosicaoY",
                table: "posicoesprodutos",
                newName: "posicao_y");

            migrationBuilder.RenameColumn(
                name: "PosicaoX",
                table: "posicoesprodutos",
                newName: "posicao_x");

            migrationBuilder.RenameColumn(
                name: "CampanhaId",
                table: "posicoesprodutos",
                newName: "campanha_id");

            migrationBuilder.RenameIndex(
                name: "IX_PosicoesProdutos_CampanhaId",
                table: "posicoesprodutos",
                newName: "IX_posicoesprodutos_campanha_id");

            migrationBuilder.RenameColumn(
                name: "Valor",
                table: "pedidosprodutos",
                newName: "valor");

            migrationBuilder.RenameColumn(
                name: "Quantidade",
                table: "pedidosprodutos",
                newName: "quantidade");

            migrationBuilder.RenameColumn(
                name: "ProdutoId",
                table: "pedidosprodutos",
                newName: "produto_id");

            migrationBuilder.RenameColumn(
                name: "PedidoId",
                table: "pedidosprodutos",
                newName: "pedido_id");

            migrationBuilder.RenameIndex(
                name: "IX_PedidosProdutos_ProdutoId",
                table: "pedidosprodutos",
                newName: "IX_pedidosprodutos_produto_id");

            migrationBuilder.RenameIndex(
                name: "IX_PedidosProdutos_PedidoId",
                table: "pedidosprodutos",
                newName: "IX_pedidosprodutos_pedido_id");

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "pedidos",
                newName: "data");

            migrationBuilder.RenameColumn(
                name: "ValorTotal",
                table: "pedidos",
                newName: "valor_total");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "pedidos",
                newName: "cliente_id");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_ClienteId",
                table: "pedidos",
                newName: "IX_pedidos_cliente_id");

            migrationBuilder.RenameColumn(
                name: "Observacao",
                table: "lojas",
                newName: "observacao");

            migrationBuilder.RenameColumn(
                name: "Numero",
                table: "lojas",
                newName: "numero");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "lojas",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Logradouro",
                table: "lojas",
                newName: "logradouro");

            migrationBuilder.RenameColumn(
                name: "Latitude",
                table: "lojas",
                newName: "latitude");

            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "lojas",
                newName: "estado");

            migrationBuilder.RenameColumn(
                name: "Complemento",
                table: "lojas",
                newName: "complemento");

            migrationBuilder.RenameColumn(
                name: "Cidade",
                table: "lojas",
                newName: "cidade");

            migrationBuilder.RenameColumn(
                name: "Cep",
                table: "lojas",
                newName: "cep");

            migrationBuilder.RenameColumn(
                name: "Bairro",
                table: "lojas",
                newName: "bairro");

            migrationBuilder.RenameColumn(
                name: "Telefone",
                table: "clientes",
                newName: "telefone");

            migrationBuilder.RenameColumn(
                name: "Numero",
                table: "clientes",
                newName: "numero");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "clientes",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Logradouro",
                table: "clientes",
                newName: "logradouro");

            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "clientes",
                newName: "estado");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "clientes",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Cpf",
                table: "clientes",
                newName: "cpf");

            migrationBuilder.RenameColumn(
                name: "Complemento",
                table: "clientes",
                newName: "complemento");

            migrationBuilder.RenameColumn(
                name: "Cidade",
                table: "clientes",
                newName: "cidade");

            migrationBuilder.RenameColumn(
                name: "Cep",
                table: "clientes",
                newName: "cep");

            migrationBuilder.RenameColumn(
                name: "Bairro",
                table: "clientes",
                newName: "bairro");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "campanhas",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "campanhas",
                newName: "descricao");

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "campanhas",
                newName: "data");

            migrationBuilder.RenameColumn(
                name: "UrlFotoPrateleira",
                table: "campanhas",
                newName: "url_imagem");

            migrationBuilder.AlterColumn<decimal>(
                name: "valor",
                table: "produtos",
                type: "decimal(65,30)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "produtos",
                type: "varchar(150)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "descricao",
                table: "produtos",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "posicao_y",
                table: "posicoesprodutos",
                type: "varchar(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "posicao_x",
                table: "posicoesprodutos",
                type: "varchar(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<decimal>(
                name: "valor",
                table: "pedidosprodutos",
                type: "decimal(65,30)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "quantidade",
                table: "pedidosprodutos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "data",
                table: "pedidos",
                type: "DateTime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "valor_total",
                table: "pedidos",
                type: "decimal(65,30)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "observacao",
                table: "lojas",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "numero",
                table: "lojas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "lojas",
                type: "varchar(150)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "logradouro",
                table: "lojas",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "latitude",
                table: "lojas",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "estado",
                table: "lojas",
                type: "varchar(2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "complemento",
                table: "lojas",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "cidade",
                table: "lojas",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "cep",
                table: "lojas",
                type: "varchar(15)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "bairro",
                table: "lojas",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "telefone",
                table: "clientes",
                type: "varchar(15)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "numero",
                table: "clientes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "clientes",
                type: "varchar(150)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "logradouro",
                table: "clientes",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "estado",
                table: "clientes",
                type: "varchar(2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "clientes",
                type: "varchar(150)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "cpf",
                table: "clientes",
                type: "varchar(15)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "complemento",
                table: "clientes",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "cidade",
                table: "clientes",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "cep",
                table: "clientes",
                type: "varchar(15)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "bairro",
                table: "clientes",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "campanhas",
                type: "varchar(150)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "descricao",
                table: "campanhas",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "data",
                table: "campanhas",
                type: "DateTime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<string>(
                name: "url_imagem",
                table: "campanhas",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_produtos",
                table: "produtos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_posicoesprodutos",
                table: "posicoesprodutos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_pedidosprodutos",
                table: "pedidosprodutos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_pedidos",
                table: "pedidos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_lojas",
                table: "lojas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_clientes",
                table: "clientes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_campanhas",
                table: "campanhas",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "varchar(150)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    senha = table.Column<string>(type: "varchar(20)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nivel = table.Column<string>(type: "varchar(20)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_pedidos_clientes_cliente_id",
                table: "pedidos",
                column: "cliente_id",
                principalTable: "clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_pedidosprodutos_pedidos_pedido_id",
                table: "pedidosprodutos",
                column: "pedido_id",
                principalTable: "pedidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_pedidosprodutos_produtos_produto_id",
                table: "pedidosprodutos",
                column: "produto_id",
                principalTable: "produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_posicoesprodutos_campanhas_campanha_id",
                table: "posicoesprodutos",
                column: "campanha_id",
                principalTable: "campanhas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pedidos_clientes_cliente_id",
                table: "pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_pedidosprodutos_pedidos_pedido_id",
                table: "pedidosprodutos");

            migrationBuilder.DropForeignKey(
                name: "FK_pedidosprodutos_produtos_produto_id",
                table: "pedidosprodutos");

            migrationBuilder.DropForeignKey(
                name: "FK_posicoesprodutos_campanhas_campanha_id",
                table: "posicoesprodutos");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_produtos",
                table: "produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_posicoesprodutos",
                table: "posicoesprodutos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_pedidosprodutos",
                table: "pedidosprodutos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_pedidos",
                table: "pedidos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_lojas",
                table: "lojas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_clientes",
                table: "clientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_campanhas",
                table: "campanhas");

            migrationBuilder.RenameTable(
                name: "produtos",
                newName: "Produtos");

            migrationBuilder.RenameTable(
                name: "posicoesprodutos",
                newName: "PosicoesProdutos");

            migrationBuilder.RenameTable(
                name: "pedidosprodutos",
                newName: "PedidosProdutos");

            migrationBuilder.RenameTable(
                name: "pedidos",
                newName: "Pedidos");

            migrationBuilder.RenameTable(
                name: "lojas",
                newName: "Lojas");

            migrationBuilder.RenameTable(
                name: "clientes",
                newName: "Clientes");

            migrationBuilder.RenameTable(
                name: "campanhas",
                newName: "Campanhas");

            migrationBuilder.RenameColumn(
                name: "valor",
                table: "Produtos",
                newName: "Valor");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Produtos",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "descricao",
                table: "Produtos",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "qtd_estoque",
                table: "Produtos",
                newName: "QtdEstoque");

            migrationBuilder.RenameColumn(
                name: "posicao_y",
                table: "PosicoesProdutos",
                newName: "PosicaoY");

            migrationBuilder.RenameColumn(
                name: "posicao_x",
                table: "PosicoesProdutos",
                newName: "PosicaoX");

            migrationBuilder.RenameColumn(
                name: "campanha_id",
                table: "PosicoesProdutos",
                newName: "CampanhaId");

            migrationBuilder.RenameIndex(
                name: "IX_posicoesprodutos_campanha_id",
                table: "PosicoesProdutos",
                newName: "IX_PosicoesProdutos_CampanhaId");

            migrationBuilder.RenameColumn(
                name: "valor",
                table: "PedidosProdutos",
                newName: "Valor");

            migrationBuilder.RenameColumn(
                name: "quantidade",
                table: "PedidosProdutos",
                newName: "Quantidade");

            migrationBuilder.RenameColumn(
                name: "produto_id",
                table: "PedidosProdutos",
                newName: "ProdutoId");

            migrationBuilder.RenameColumn(
                name: "pedido_id",
                table: "PedidosProdutos",
                newName: "PedidoId");

            migrationBuilder.RenameIndex(
                name: "IX_pedidosprodutos_produto_id",
                table: "PedidosProdutos",
                newName: "IX_PedidosProdutos_ProdutoId");

            migrationBuilder.RenameIndex(
                name: "IX_pedidosprodutos_pedido_id",
                table: "PedidosProdutos",
                newName: "IX_PedidosProdutos_PedidoId");

            migrationBuilder.RenameColumn(
                name: "data",
                table: "Pedidos",
                newName: "Data");

            migrationBuilder.RenameColumn(
                name: "valor_total",
                table: "Pedidos",
                newName: "ValorTotal");

            migrationBuilder.RenameColumn(
                name: "cliente_id",
                table: "Pedidos",
                newName: "ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_pedidos_cliente_id",
                table: "Pedidos",
                newName: "IX_Pedidos_ClienteId");

            migrationBuilder.RenameColumn(
                name: "observacao",
                table: "Lojas",
                newName: "Observacao");

            migrationBuilder.RenameColumn(
                name: "numero",
                table: "Lojas",
                newName: "Numero");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Lojas",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "logradouro",
                table: "Lojas",
                newName: "Logradouro");

            migrationBuilder.RenameColumn(
                name: "latitude",
                table: "Lojas",
                newName: "Latitude");

            migrationBuilder.RenameColumn(
                name: "estado",
                table: "Lojas",
                newName: "Estado");

            migrationBuilder.RenameColumn(
                name: "complemento",
                table: "Lojas",
                newName: "Complemento");

            migrationBuilder.RenameColumn(
                name: "cidade",
                table: "Lojas",
                newName: "Cidade");

            migrationBuilder.RenameColumn(
                name: "cep",
                table: "Lojas",
                newName: "Cep");

            migrationBuilder.RenameColumn(
                name: "bairro",
                table: "Lojas",
                newName: "Bairro");

            migrationBuilder.RenameColumn(
                name: "telefone",
                table: "Clientes",
                newName: "Telefone");

            migrationBuilder.RenameColumn(
                name: "numero",
                table: "Clientes",
                newName: "Numero");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Clientes",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "logradouro",
                table: "Clientes",
                newName: "Logradouro");

            migrationBuilder.RenameColumn(
                name: "estado",
                table: "Clientes",
                newName: "Estado");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Clientes",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "cpf",
                table: "Clientes",
                newName: "Cpf");

            migrationBuilder.RenameColumn(
                name: "complemento",
                table: "Clientes",
                newName: "Complemento");

            migrationBuilder.RenameColumn(
                name: "cidade",
                table: "Clientes",
                newName: "Cidade");

            migrationBuilder.RenameColumn(
                name: "cep",
                table: "Clientes",
                newName: "Cep");

            migrationBuilder.RenameColumn(
                name: "bairro",
                table: "Clientes",
                newName: "Bairro");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Campanhas",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "descricao",
                table: "Campanhas",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "data",
                table: "Campanhas",
                newName: "Data");

            migrationBuilder.RenameColumn(
                name: "url_imagem",
                table: "Campanhas",
                newName: "UrlFotoPrateleira");

            migrationBuilder.AlterColumn<int>(
                name: "Valor",
                table: "Produtos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Produtos",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(150)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Produtos",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "PosicaoY",
                table: "PosicoesProdutos",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "PosicaoX",
                table: "PosicoesProdutos",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "Valor",
                table: "PedidosProdutos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Quantidade",
                table: "PedidosProdutos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Data",
                table: "Pedidos",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime");

            migrationBuilder.AlterColumn<int>(
                name: "ValorTotal",
                table: "Pedidos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Observacao",
                table: "Lojas",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "Numero",
                table: "Lojas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Lojas",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(150)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Logradouro",
                table: "Lojas",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Latitude",
                table: "Lojas",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "Lojas",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(2)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Complemento",
                table: "Lojas",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "Lojas",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Cep",
                table: "Lojas",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(15)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Bairro",
                table: "Lojas",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Longitude",
                table: "Lojas",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Clientes",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(15)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "Numero",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Clientes",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(150)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Logradouro",
                table: "Clientes",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "Clientes",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(2)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Clientes",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(150)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Clientes",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(15)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Complemento",
                table: "Clientes",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "Clientes",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Cep",
                table: "Clientes",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(15)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Bairro",
                table: "Clientes",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Campanhas",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(150)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Campanhas",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Data",
                table: "Campanhas",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Campanhas",
                keyColumn: "UrlFotoPrateleira",
                keyValue: null,
                column: "UrlFotoPrateleira",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "UrlFotoPrateleira",
                table: "Campanhas",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produtos",
                table: "Produtos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PosicoesProdutos",
                table: "PosicoesProdutos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PedidosProdutos",
                table: "PedidosProdutos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pedidos",
                table: "Pedidos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lojas",
                table: "Lojas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Campanhas",
                table: "Campanhas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Clientes_ClienteId",
                table: "Pedidos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidosProdutos_Pedidos_PedidoId",
                table: "PedidosProdutos",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidosProdutos_Produtos_ProdutoId",
                table: "PedidosProdutos",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PosicoesProdutos_Campanhas_CampanhaId",
                table: "PosicoesProdutos",
                column: "CampanhaId",
                principalTable: "Campanhas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
