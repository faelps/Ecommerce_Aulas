﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RafaelRoupasECalcados.Adm.Models.Contexto;

namespace RafaelRoupasECalcados.Adm.Migrations
{
    [DbContext(typeof(LojaContexto))]
    [Migration("20210120011602_MigracaoInical")]
    partial class MigracaoInical
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("CategoriaProduto", b =>
                {
                    b.Property<int>("CategoriasId")
                        .HasColumnType("int");

                    b.Property<int>("ProdutosId")
                        .HasColumnType("int");

                    b.HasKey("CategoriasId", "ProdutosId");

                    b.HasIndex("ProdutosId");

                    b.ToTable("CategoriaProduto");
                });

            modelBuilder.Entity("RafaelRoupasECalcados.Adm.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Imagem")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("RafaelRoupasECalcados.Adm.Models.DadosDoProduto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Cor")
                        .HasColumnType("varchar(200)");

                    b.Property<bool>("Disponivel")
                        .HasColumnType("bit");

                    b.Property<string>("Imagem")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Paleta")
                        .HasColumnType("varchar(200)");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<string>("Tamanho")
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.ToTable("DadosDoProduto");
                });

            modelBuilder.Entity("RafaelRoupasECalcados.Adm.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CodDeReferencia")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(200)");

                    b.Property<bool>("Destaque")
                        .HasColumnType("bit");

                    b.Property<string>("ImagemDestaque")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(200)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("CategoriaProduto", b =>
                {
                    b.HasOne("RafaelRoupasECalcados.Adm.Models.Categoria", null)
                        .WithMany()
                        .HasForeignKey("CategoriasId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RafaelRoupasECalcados.Adm.Models.Produto", null)
                        .WithMany()
                        .HasForeignKey("ProdutosId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("RafaelRoupasECalcados.Adm.Models.DadosDoProduto", b =>
                {
                    b.HasOne("RafaelRoupasECalcados.Adm.Models.Produto", "Produto")
                        .WithMany("DadosDoProduto")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("RafaelRoupasECalcados.Adm.Models.Produto", b =>
                {
                    b.Navigation("DadosDoProduto");
                });
#pragma warning restore 612, 618
        }
    }
}
