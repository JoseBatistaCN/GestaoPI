﻿// <auto-generated />
using System;
using GestaoPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GestaoPI.Migrations
{
    [DbContext(typeof(GestaopiContext))]
    [Migration("20230619131730_addInterfaces")]
    partial class addInterfaces
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DespachoPatente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("CodigoDespacho")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("codigo_despacho");

                    b.Property<string>("CodigoRevista")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("revista");

                    b.Property<string>("Processo")
                        .IsRequired()
                        .HasColumnType("varchar(19)")
                        .HasColumnName("patente_codigo");

                    b.HasKey("Id");

                    b.HasIndex("CodigoRevista");

                    b.HasIndex("Processo");

                    b.ToTable("DespachoPatentes");
                });

            modelBuilder.Entity("GestaoPI.Models.CodigoServicoPatente", b =>
                {
                    b.Property<string>("Servico")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("servico");

                    b.Property<decimal?>("ValorComDesconto")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("valor_com_desconto");

                    b.Property<decimal?>("ValorSemDesconto")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("valor_sem_desconto");

                    b.HasKey("Servico");

                    b.ToTable("codigo_servico_patente");
                });

            modelBuilder.Entity("GestaoPI.Models.DesenhoIndustrial", b =>
                {
                    b.Property<string>("Codigo")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime?>("Concessao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Deposito")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Titulo")
                        .HasColumnType("longtext");

                    b.HasKey("Codigo");

                    b.ToTable("desenho_industrial");
                });

            modelBuilder.Entity("GestaoPI.Models.Inventor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PatenteCodigo")
                        .HasColumnType("varchar(19)");

                    b.HasKey("Id");

                    b.HasIndex("PatenteCodigo");

                    b.ToTable("Inventores");
                });

            modelBuilder.Entity("GestaoPI.Models.Marca", b =>
                {
                    b.Property<string>("Codigo")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("codigo");

                    b.Property<DateTime?>("Concessao")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("concessao");

                    b.Property<DateTime>("Deposito")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("deposito");

                    b.Property<string>("Titulo")
                        .HasColumnType("longtext")
                        .HasColumnName("titulo");

                    b.HasKey("Codigo");

                    b.ToTable("marca");
                });

            modelBuilder.Entity("GestaoPI.Models.Patente", b =>
                {
                    b.Property<string>("Codigo")
                        .HasMaxLength(19)
                        .HasColumnType("varchar(19)")
                        .HasColumnName("codigo");

                    b.Property<string>("Anotacao")
                        .HasColumnType("text")
                        .HasColumnName("anotacao");

                    b.Property<DateTime?>("Concessao")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("concessao");

                    b.Property<DateTime>("Deposito")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("deposito");

                    b.Property<DateTime?>("Exame")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("exame");

                    b.Property<DateTime?>("Publicacao")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("publicacao");

                    b.Property<string>("Resumo")
                        .HasColumnType("mediumtext")
                        .HasColumnName("resumo");

                    b.Property<int?>("Situacao")
                        .HasColumnType("int")
                        .HasColumnName("situacao");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("status");

                    b.Property<string>("Titulo")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("titulo");

                    b.HasKey("Codigo");

                    b.HasIndex(new[] { "Codigo" }, "codigo_UNIQUE")
                        .IsUnique();

                    b.ToTable("patente");
                });

            modelBuilder.Entity("GestaoPI.Models.ProgramaDeComputador", b =>
                {
                    b.Property<string>("Codigo")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("codigo");

                    b.Property<DateTime?>("Concessao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Deposito")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Titulo")
                        .HasColumnType("longtext")
                        .HasColumnName("titulo");

                    b.HasKey("Codigo");

                    b.ToTable("programa_de_computador");
                });

            modelBuilder.Entity("GestaoPI.Models.Revista", b =>
                {
                    b.Property<string>("Codigo")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("codigo");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("data");

                    b.HasKey("Codigo");

                    b.ToTable("revista");
                });

            modelBuilder.Entity("GestaoPI.Models.ServicoPatente", b =>
                {
                    b.Property<int>("ServicoPatenteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_servico_patente");

                    b.Property<DateTime?>("Data")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("data");

                    b.Property<string>("PatenteCodigo")
                        .IsRequired()
                        .HasMaxLength(19)
                        .HasColumnType("varchar(19)")
                        .HasColumnName("patente_codigo");

                    b.Property<string>("Protocolo")
                        .HasColumnType("longtext")
                        .HasColumnName("protocolo");

                    b.Property<string>("ServicoCodigo")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("codigo_servico_patente");

                    b.Property<decimal?>("Valor")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("valor");

                    b.HasKey("ServicoPatenteId");

                    b.HasIndex("PatenteCodigo");

                    b.HasIndex("ServicoCodigo");

                    b.ToTable("servico_patente");
                });

            modelBuilder.Entity("DespachoPatente", b =>
                {
                    b.HasOne("GestaoPI.Models.Revista", "Revista")
                        .WithMany("DespachoPatentes")
                        .HasForeignKey("CodigoRevista")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GestaoPI.Models.Patente", "Patente")
                        .WithMany()
                        .HasForeignKey("Processo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patente");

                    b.Navigation("Revista");
                });

            modelBuilder.Entity("GestaoPI.Models.Inventor", b =>
                {
                    b.HasOne("GestaoPI.Models.Patente", null)
                        .WithMany("Inventores")
                        .HasForeignKey("PatenteCodigo");
                });

            modelBuilder.Entity("GestaoPI.Models.ServicoPatente", b =>
                {
                    b.HasOne("GestaoPI.Models.Patente", "Patente")
                        .WithMany("ServicosPatente")
                        .HasForeignKey("PatenteCodigo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GestaoPI.Models.CodigoServicoPatente", "CodigoServicoPatente")
                        .WithMany("ServicosPatente")
                        .HasForeignKey("ServicoCodigo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CodigoServicoPatente");

                    b.Navigation("Patente");
                });

            modelBuilder.Entity("GestaoPI.Models.CodigoServicoPatente", b =>
                {
                    b.Navigation("ServicosPatente");
                });

            modelBuilder.Entity("GestaoPI.Models.Patente", b =>
                {
                    b.Navigation("Inventores");

                    b.Navigation("ServicosPatente");
                });

            modelBuilder.Entity("GestaoPI.Models.Revista", b =>
                {
                    b.Navigation("DespachoPatentes");
                });
#pragma warning restore 612, 618
        }
    }
}
