﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using estudo.Models;

namespace estudo.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20190123213806_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("estudo.Models.Mecanico", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CNPJ");

                    b.Property<string>("CPF");

                    b.Property<string>("Celular");

                    b.Property<string>("Cidade");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<bool>("Eletrica");

                    b.Property<string>("Endereco");

                    b.Property<string>("Estado");

                    b.Property<string>("Latitude");

                    b.Property<string>("Longitude");

                    b.Property<bool>("Mecanica");

                    b.Property<string>("RazaoSocial");

                    b.Property<string>("Responsavel");

                    b.Property<bool>("Suspensao");

                    b.Property<string>("Telefone");

                    b.HasKey("Id");

                    b.ToTable("Mecanicos");
                });
#pragma warning restore 612, 618
        }
    }
}
