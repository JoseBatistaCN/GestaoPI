﻿// <auto-generated />
using System;
using GestaoPI.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GestaoPI.Migrations
{
    [DbContext(typeof(PatenteContext))]
    [Migration("20230412142201_formatdate")]
    partial class formatdate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("utf8mb4_0900_ai_ci")
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.HasCharSet(modelBuilder, "utf8mb4");

            modelBuilder.Entity("GestaoPI.Models.CodigoDespachosPatente", b =>
                {
                    b.Property<string>("CodigoId")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("codigo_id");

                    b.Property<int?>("Cumprimento")
                        .HasColumnType("int")
                        .HasColumnName("cumprimento");

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("descricao");

                    b.HasKey("CodigoId")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "Descricao" }, "descricao_UNIQUE")
                        .IsUnique();

                    b.ToTable("codigo_despachos_patente");
                });

            modelBuilder.Entity("GestaoPI.Models.Efmigrationshistory", b =>
                {
                    b.Property<string>("MigrationId")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("ProductVersion")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.HasKey("MigrationId");

                    b.ToTable("__efmigrationshistory");
                });

            modelBuilder.Entity("GestaoPI.Models.Patente", b =>
                {
                    b.Property<string>("Codigo")
                        .HasMaxLength(20)
                        .HasColumnType("char(20)")
                        .HasColumnName("codigo")
                        .IsFixedLength();

                    b.Property<string>("Anotacao")
                        .HasColumnType("text")
                        .HasColumnName("anotacao");

                    b.Property<DateOnly?>("Concessao")
                        .HasColumnType("date")
                        .HasColumnName("concessao");

                    b.Property<DateOnly?>("Deposito")
                        .HasColumnType("date")
                        .HasColumnName("deposito");

                    b.Property<DateOnly?>("DominioPublico")
                        .HasColumnType("date")
                        .HasColumnName("dominio_publico");

                    b.Property<DateOnly?>("Exame")
                        .HasColumnType("date")
                        .HasColumnName("exame");

                    b.Property<string>("Resumo")
                        .HasColumnType("longtext")
                        .HasColumnName("resumo");

                    b.Property<string>("Situacao")
                        .HasColumnType("enum('Em Processo','Concedido')")
                        .HasColumnName("situacao");

                    b.Property<string>("Status")
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("status");

                    b.Property<string>("Titulo")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("titulo");

                    b.HasKey("Codigo")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "Codigo" }, "codigo_UNIQUE")
                        .IsUnique();

                    b.ToTable("patente");
                });

            modelBuilder.Entity("GestaoPI.Models.Revista", b =>
                {
                    b.Property<int>("Codigo")
                        .HasColumnType("int")
                        .HasColumnName("codigo");

                    b.Property<DateOnly>("Data")
                        .HasColumnType("date")
                        .HasColumnName("data");

                    b.HasKey("Codigo")
                        .HasName("PRIMARY");

                    b.ToTable("revista");
                });
#pragma warning restore 612, 618
        }
    }
}