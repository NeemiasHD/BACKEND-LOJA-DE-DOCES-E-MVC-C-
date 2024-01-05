﻿// <auto-generated />
using CadastroDeProdutoApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CadastroDeProdutoApi.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CadastroDeProdutoApi.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Categoria");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Descricao");

                    b.Property<string>("NomeProduto")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("NomeProduto");

                    b.Property<string>("imagem")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("imagem");

                    b.Property<string>("preco")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("preco");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
