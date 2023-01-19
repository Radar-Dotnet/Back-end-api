using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projeto_radar_backend.Migrations
{
    public partial class NovaMigrationCodeFirst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Cliente_cliente_id",
                table: "Pedido");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidosProdutos_Pedido_pedido_id",
                table: "PedidosProdutos");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidosProdutos_Produto_produto_id",
                table: "PedidosProdutos");

            migrationBuilder.DropForeignKey(
                name: "FK_PosicoesProdutos_Campanhas_campanha_id",
                table: "PosicoesProdutos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Produto",
                table: "Produto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pedido",
                table: "Pedido");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

            migrationBuilder.RenameTable(
                name: "Produto",
                newName: "Produtos");

            migrationBuilder.RenameTable(
                name: "Pedido",
                newName: "Pedidos");

            migrationBuilder.RenameTable(
                name: "Cliente",
                newName: "Clientes");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "PosicoesProdutos",
                newName: "Id");

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
                name: "fk_PosicoesProdutos_Campanhas1_idx",
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
                name: "id",
                table: "PedidosProdutos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "produto_id",
                table: "PedidosProdutos",
                newName: "ProdutoId");

            migrationBuilder.RenameColumn(
                name: "pedido_id",
                table: "PedidosProdutos",
                newName: "PedidoId");

            migrationBuilder.RenameIndex(
                name: "fk_Pedido_has_Produto_Produto1_idx",
                table: "PedidosProdutos",
                newName: "IX_PedidosProdutos_ProdutoId");

            migrationBuilder.RenameIndex(
                name: "fk_Pedido_has_Produto_Pedido1_idx",
                table: "PedidosProdutos",
                newName: "IX_PedidosProdutos_PedidoId");

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
                name: "longitude",
                table: "Lojas",
                newName: "Longitude");

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
                name: "id",
                table: "Lojas",
                newName: "Id");

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
                name: "id",
                table: "Campanhas",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "url_foto_prateleira",
                table: "Campanhas",
                newName: "UrlFotoPrateleira");

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
                name: "id",
                table: "Produtos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "qtd_estoque",
                table: "Produtos",
                newName: "QtdEstoque");

            migrationBuilder.RenameColumn(
                name: "data",
                table: "Pedidos",
                newName: "Data");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Pedidos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "valor_total",
                table: "Pedidos",
                newName: "ValorTotal");

            migrationBuilder.RenameColumn(
                name: "cliente_id",
                table: "Pedidos",
                newName: "ClienteId");

            migrationBuilder.RenameIndex(
                name: "fk_Pedido_Cliente_idx",
                table: "Pedidos",
                newName: "IX_Pedidos_ClienteId");

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
                name: "id",
                table: "Clientes",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "PosicaoY",
                table: "PosicoesProdutos",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(45)",
                oldMaxLength: 45)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "PosicaoX",
                table: "PosicoesProdutos",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(45)",
                oldMaxLength: 45)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Observacao",
                table: "Lojas",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Lojas",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Longitude",
                table: "Lojas",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(25)",
                oldMaxLength: 25)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Logradouro",
                table: "Lojas",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Latitude",
                table: "Lojas",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(25)",
                oldMaxLength: 25)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "Lojas",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(2)",
                oldMaxLength: 2)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Complemento",
                table: "Lojas",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(45)",
                oldMaxLength: 45,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "Lojas",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(45)",
                oldMaxLength: 45)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Cep",
                table: "Lojas",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldMaxLength: 15)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Bairro",
                table: "Lojas",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Campanhas",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(45)",
                oldMaxLength: 45)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Campanhas",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Data",
                table: "Campanhas",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<string>(
                name: "UrlFotoPrateleira",
                table: "Campanhas",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Produtos",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Produtos",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Data",
                table: "Pedidos",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Clientes",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldMaxLength: 15)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Clientes",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Logradouro",
                table: "Clientes",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(45)",
                oldMaxLength: 45)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "Clientes",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(2)",
                oldMaxLength: 2)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Clientes",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(150)",
                oldMaxLength: 150)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Clientes",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldMaxLength: 15)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Complemento",
                table: "Clientes",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "Clientes",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(45)",
                oldMaxLength: 45)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Cep",
                table: "Clientes",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldMaxLength: 15)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Bairro",
                table: "Clientes",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(45)",
                oldMaxLength: 45)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produtos",
                table: "Produtos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pedidos",
                table: "Pedidos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "PK_Pedidos",
                table: "Pedidos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.RenameTable(
                name: "Produtos",
                newName: "Produto");

            migrationBuilder.RenameTable(
                name: "Pedidos",
                newName: "Pedido");

            migrationBuilder.RenameTable(
                name: "Clientes",
                newName: "Cliente");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PosicoesProdutos",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "PosicaoY",
                table: "PosicoesProdutos",
                newName: "posicao_y");

            migrationBuilder.RenameColumn(
                name: "PosicaoX",
                table: "PosicoesProdutos",
                newName: "posicao_x");

            migrationBuilder.RenameColumn(
                name: "CampanhaId",
                table: "PosicoesProdutos",
                newName: "campanha_id");

            migrationBuilder.RenameIndex(
                name: "IX_PosicoesProdutos_CampanhaId",
                table: "PosicoesProdutos",
                newName: "fk_PosicoesProdutos_Campanhas1_idx");

            migrationBuilder.RenameColumn(
                name: "Valor",
                table: "PedidosProdutos",
                newName: "valor");

            migrationBuilder.RenameColumn(
                name: "Quantidade",
                table: "PedidosProdutos",
                newName: "quantidade");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PedidosProdutos",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "ProdutoId",
                table: "PedidosProdutos",
                newName: "produto_id");

            migrationBuilder.RenameColumn(
                name: "PedidoId",
                table: "PedidosProdutos",
                newName: "pedido_id");

            migrationBuilder.RenameIndex(
                name: "IX_PedidosProdutos_ProdutoId",
                table: "PedidosProdutos",
                newName: "fk_Pedido_has_Produto_Produto1_idx");

            migrationBuilder.RenameIndex(
                name: "IX_PedidosProdutos_PedidoId",
                table: "PedidosProdutos",
                newName: "fk_Pedido_has_Produto_Pedido1_idx");

            migrationBuilder.RenameColumn(
                name: "Observacao",
                table: "Lojas",
                newName: "observacao");

            migrationBuilder.RenameColumn(
                name: "Numero",
                table: "Lojas",
                newName: "numero");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Lojas",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Longitude",
                table: "Lojas",
                newName: "longitude");

            migrationBuilder.RenameColumn(
                name: "Logradouro",
                table: "Lojas",
                newName: "logradouro");

            migrationBuilder.RenameColumn(
                name: "Latitude",
                table: "Lojas",
                newName: "latitude");

            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "Lojas",
                newName: "estado");

            migrationBuilder.RenameColumn(
                name: "Complemento",
                table: "Lojas",
                newName: "complemento");

            migrationBuilder.RenameColumn(
                name: "Cidade",
                table: "Lojas",
                newName: "cidade");

            migrationBuilder.RenameColumn(
                name: "Cep",
                table: "Lojas",
                newName: "cep");

            migrationBuilder.RenameColumn(
                name: "Bairro",
                table: "Lojas",
                newName: "bairro");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Lojas",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Campanhas",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Campanhas",
                newName: "descricao");

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "Campanhas",
                newName: "data");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Campanhas",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UrlFotoPrateleira",
                table: "Campanhas",
                newName: "url_foto_prateleira");

            migrationBuilder.RenameColumn(
                name: "Valor",
                table: "Produto",
                newName: "valor");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Produto",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Produto",
                newName: "descricao");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Produto",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "QtdEstoque",
                table: "Produto",
                newName: "qtd_estoque");

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "Pedido",
                newName: "data");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Pedido",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "ValorTotal",
                table: "Pedido",
                newName: "valor_total");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Pedido",
                newName: "cliente_id");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_ClienteId",
                table: "Pedido",
                newName: "fk_Pedido_Cliente_idx");

            migrationBuilder.RenameColumn(
                name: "Telefone",
                table: "Cliente",
                newName: "telefone");

            migrationBuilder.RenameColumn(
                name: "Numero",
                table: "Cliente",
                newName: "numero");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Cliente",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Logradouro",
                table: "Cliente",
                newName: "logradouro");

            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "Cliente",
                newName: "estado");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Cliente",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Cpf",
                table: "Cliente",
                newName: "cpf");

            migrationBuilder.RenameColumn(
                name: "Complemento",
                table: "Cliente",
                newName: "complemento");

            migrationBuilder.RenameColumn(
                name: "Cidade",
                table: "Cliente",
                newName: "cidade");

            migrationBuilder.RenameColumn(
                name: "Cep",
                table: "Cliente",
                newName: "cep");

            migrationBuilder.RenameColumn(
                name: "Bairro",
                table: "Cliente",
                newName: "bairro");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cliente",
                newName: "id");

            migrationBuilder.AlterColumn<string>(
                name: "posicao_y",
                table: "PosicoesProdutos",
                type: "varchar(45)",
                maxLength: 45,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "posicao_x",
                table: "PosicoesProdutos",
                type: "varchar(45)",
                maxLength: 45,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "observacao",
                table: "Lojas",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "Lojas",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "longitude",
                table: "Lojas",
                type: "varchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "logradouro",
                table: "Lojas",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "latitude",
                table: "Lojas",
                type: "varchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "estado",
                table: "Lojas",
                type: "varchar(2)",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "complemento",
                table: "Lojas",
                type: "varchar(45)",
                maxLength: 45,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "cidade",
                table: "Lojas",
                type: "varchar(45)",
                maxLength: 45,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "cep",
                table: "Lojas",
                type: "varchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "bairro",
                table: "Lojas",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "Campanhas",
                type: "varchar(45)",
                maxLength: 45,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "descricao",
                table: "Campanhas",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "data",
                table: "Campanhas",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<string>(
                name: "url_foto_prateleira",
                table: "Campanhas",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "Produto",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "descricao",
                table: "Produto",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "data",
                table: "Pedido",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<string>(
                name: "telefone",
                table: "Cliente",
                type: "varchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "Cliente",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "logradouro",
                table: "Cliente",
                type: "varchar(45)",
                maxLength: 45,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "estado",
                table: "Cliente",
                type: "varchar(2)",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "Cliente",
                type: "varchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "cpf",
                table: "Cliente",
                type: "varchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "complemento",
                table: "Cliente",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "cidade",
                table: "Cliente",
                type: "varchar(45)",
                maxLength: 45,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "cep",
                table: "Cliente",
                type: "varchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "bairro",
                table: "Cliente",
                type: "varchar(45)",
                maxLength: 45,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produto",
                table: "Produto",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pedido",
                table: "Pedido",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Cliente_cliente_id",
                table: "Pedido",
                column: "cliente_id",
                principalTable: "Cliente",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidosProdutos_Pedido_pedido_id",
                table: "PedidosProdutos",
                column: "pedido_id",
                principalTable: "Pedido",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidosProdutos_Produto_produto_id",
                table: "PedidosProdutos",
                column: "produto_id",
                principalTable: "Produto",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PosicoesProdutos_Campanhas_campanha_id",
                table: "PosicoesProdutos",
                column: "campanha_id",
                principalTable: "Campanhas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
