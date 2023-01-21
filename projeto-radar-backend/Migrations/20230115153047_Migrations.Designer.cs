﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using projeto_radar_backend.Database;

#nullable disable

namespace projeto_radar_backend.Migrations
{
    [DbContext(typeof(DbRadarContext))]
    [Migration("20230115153047_Migrations")]
    partial class Migrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("projeto_radar_backend.Models.Campanha", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime")
                        .HasColumnName("data");

                    b.Property<string>("Descricao")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("descricao");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("nome");

                    b.Property<string>("UrlFotoPrateleira")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("url_foto_prateleira");

                    b.HasKey("Id");

                    b.ToTable("Campanhas");
                });

            modelBuilder.Entity("projeto_radar_backend.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("bairro");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("cep");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("cidade");

                    b.Property<string>("Complemento")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("complemento");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("cpf");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("email");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)")
                        .HasColumnName("estado");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("logradouro");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("nome");

                    b.Property<int>("Numero")
                        .HasColumnType("int")
                        .HasColumnName("numero");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("telefone");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Cpf" }, "cpf_UNIQUE")
                        .IsUnique();

                    b.HasIndex(new[] { "Email" }, "email_UNIQUE")
                        .IsUnique();

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("projeto_radar_backend.Models.Loja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("bairro");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("cep");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("cidade");

                    b.Property<string>("Complemento")
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("complemento");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)")
                        .HasColumnName("estado");

                    b.Property<string>("Latitude")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("latitude");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("logradouro");

                    b.Property<string>("Longitude")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("longitude");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("nome");

                    b.Property<int>("Numero")
                        .HasColumnType("int")
                        .HasColumnName("numero");

                    b.Property<string>("Observacao")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("observacao");

                    b.HasKey("Id");

                    b.ToTable("Lojas");
                });

            modelBuilder.Entity("projeto_radar_backend.Models.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int")
                        .HasColumnName("cliente_id");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime")
                        .HasColumnName("data");

                    b.Property<int>("ValorTotal")
                        .HasColumnType("int")
                        .HasColumnName("valor_total");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "ClienteId" }, "fk_Pedido_Cliente_idx");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("projeto_radar_backend.Models.PedidosProduto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("PedidoId")
                        .HasColumnType("int")
                        .HasColumnName("pedido_id");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int")
                        .HasColumnName("produto_id");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int")
                        .HasColumnName("quantidade");

                    b.Property<int>("Valor")
                        .HasColumnType("int")
                        .HasColumnName("valor");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "PedidoId" }, "fk_Pedido_has_Produto_Pedido1_idx");

                    b.HasIndex(new[] { "ProdutoId" }, "fk_Pedido_has_Produto_Produto1_idx");

                    b.ToTable("PedidosProdutos");
                });

            modelBuilder.Entity("projeto_radar_backend.Models.PosicoesProduto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("CampanhaId")
                        .HasColumnType("int")
                        .HasColumnName("campanha_id");

                    b.Property<string>("PosicaoX")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("posicao_x");

                    b.Property<string>("PosicaoY")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("posicao_y");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "CampanhaId" }, "fk_PosicoesProdutos_Campanhas1_idx");

                    b.ToTable("PosicoesProdutos");
                });

            modelBuilder.Entity("projeto_radar_backend.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("descricao");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("nome");

                    b.Property<int>("QtdEstoque")
                        .HasColumnType("int")
                        .HasColumnName("qtd_estoque");

                    b.Property<int>("Valor")
                        .HasColumnType("int")
                        .HasColumnName("valor");

                    b.HasKey("Id");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("projeto_radar_backend.Models.Pedido", b =>
                {
                    b.HasOne("projeto_radar_backend.Models.Cliente", "Cliente")
                        .WithMany("Pedidos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("projeto_radar_backend.Models.PedidosProduto", b =>
                {
                    b.HasOne("projeto_radar_backend.Models.Pedido", "Pedido")
                        .WithMany("PedidosProdutos")
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("projeto_radar_backend.Models.Produto", "Produto")
                        .WithMany("PedidosProdutos")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("projeto_radar_backend.Models.PosicoesProduto", b =>
                {
                    b.HasOne("projeto_radar_backend.Models.Campanha", "Campanha")
                        .WithMany("PosicoesProdutos")
                        .HasForeignKey("CampanhaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Campanha");
                });

            modelBuilder.Entity("projeto_radar_backend.Models.Campanha", b =>
                {
                    b.Navigation("PosicoesProdutos");
                });

            modelBuilder.Entity("projeto_radar_backend.Models.Cliente", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("projeto_radar_backend.Models.Pedido", b =>
                {
                    b.Navigation("PedidosProdutos");
                });

            modelBuilder.Entity("projeto_radar_backend.Models.Produto", b =>
                {
                    b.Navigation("PedidosProdutos");
                });
#pragma warning restore 612, 618
        }
    }
}