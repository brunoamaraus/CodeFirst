﻿// <auto-generated />
using System;
using DataAccessPostgreSqlProvider;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace N1CoreProject.Migrations
{
    [DbContext(typeof(DomainModelPostgreSqlContext))]
    [Migration("20190716183544_Primeiro")]
    partial class Primeiro
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("public")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("DomainModel.Pessoa", b =>
                {
                    b.Property<int>("Pessoa_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("pessoa_id");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnName("data_cadastro");

                    b.Property<string>("Nome")
                        .HasColumnName("nome");

                    b.HasKey("Pessoa_id")
                        .HasName("pk_pessoa");

                    b.ToTable("pessoa");
                });
#pragma warning restore 612, 618
        }
    }
}