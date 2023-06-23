﻿// <auto-generated />
using System;
using GestaoPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GestaoPI.Migrations
{
    [DbContext(typeof(GestaopiContext))]
    partial class GestaopiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                        .HasColumnType("varchar(10)")
                        .HasColumnName("cod_despacho");

                    b.Property<string>("CodigoRevista")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("cod_revista");

                    b.Property<string>("Processo")
                        .IsRequired()
                        .HasColumnType("varchar(19)")
                        .HasColumnName("cod_patente");

                    b.HasKey("Id");

                    b.HasIndex("CodigoDespacho");

                    b.HasIndex("CodigoRevista");

                    b.HasIndex("Processo");

                    b.ToTable("despacho_patente");
                });

            modelBuilder.Entity("GestaoPI.Models.CodigoDespachoPatente", b =>
                {
                    b.Property<string>("Codigo")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("cod_despacho");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext")
                        .HasColumnName("descricao");

                    b.Property<int?>("Prazo")
                        .HasColumnType("int")
                        .HasColumnName("prazo");

                    b.Property<string>("Titulo")
                        .HasColumnType("longtext")
                        .HasColumnName("titulo");

                    b.HasKey("Codigo");

                    b.ToTable("codigo_despacho_patente");
                });

            modelBuilder.Entity("GestaoPI.Models.CodigoServicoPatente", b =>
                {
                    b.Property<string>("Codigo")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("cod_servico");

                    b.Property<string>("Servico")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("servico");

                    b.Property<decimal?>("ValorComDesconto")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("valor_com_desconto");

                    b.Property<decimal?>("ValorSemDesconto")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("valor_sem_desconto");

                    b.HasKey("Codigo");

                    b.ToTable("codigo_servico_patente");
                });

            modelBuilder.Entity("GestaoPI.Models.DesenhoIndustrial", b =>
                {
                    b.Property<string>("Codigo")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("cod_desenho_industrial");

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

                    b.ToTable("desenho_industrial");
                });

            modelBuilder.Entity("GestaoPI.Models.Inventor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("nm_inventor");

                    b.HasKey("Id");

                    b.ToTable("inventor");
                });

            modelBuilder.Entity("GestaoPI.Models.Marca", b =>
                {
                    b.Property<string>("Codigo")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("cod_marca");

                    b.Property<DateTime?>("Concessao")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("concessao");

                    b.Property<DateTime>("Deposito")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("deposito");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("marca");

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

                    b.Property<int>("Situacao")
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
                        .HasColumnName("cod_programa_de_computador");

                    b.Property<DateTime?>("Concessao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Deposito")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("deposito");

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
                        .HasColumnName("cod_revista");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("dt_revista");

                    b.HasKey("Codigo");

                    b.ToTable("revista");
                });

            modelBuilder.Entity("GestaoPI.Models.ServicoPatente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("CodigoPatente")
                        .IsRequired()
                        .HasMaxLength(19)
                        .HasColumnType("varchar(19)")
                        .HasColumnName("cod_patente");

                    b.Property<string>("CodigoServico")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasColumnName("cod_servico_patente");

                    b.Property<DateTime?>("Data")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("dt_servico");

                    b.Property<string>("Protocolo")
                        .HasColumnType("longtext")
                        .HasColumnName("protocolo");

                    b.Property<decimal?>("Valor")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("valor");

                    b.HasKey("Id");

                    b.HasIndex("CodigoPatente");

                    b.HasIndex("CodigoServico");

                    b.ToTable("servico_patente");
                });

            modelBuilder.Entity("InventorPatente", b =>
                {
                    b.Property<int>("InventoresId")
                        .HasColumnType("int");

                    b.Property<string>("PatentesCodigo")
                        .HasColumnType("varchar(19)");

                    b.HasKey("InventoresId", "PatentesCodigo");

                    b.HasIndex("PatentesCodigo");

                    b.ToTable("InventorPatente");
                });

            modelBuilder.Entity("DespachoPatente", b =>
                {
                    b.HasOne("GestaoPI.Models.CodigoDespachoPatente", "CodigoDespachoPatente")
                        .WithMany("DespachoPatentes")
                        .HasForeignKey("CodigoDespacho")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GestaoPI.Models.Revista", "Revista")
                        .WithMany("DespachoPatentes")
                        .HasForeignKey("CodigoRevista")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GestaoPI.Models.Patente", "Patente")
                        .WithMany("DespachoPatentes")
                        .HasForeignKey("Processo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CodigoDespachoPatente");

                    b.Navigation("Patente");

                    b.Navigation("Revista");
                });

            modelBuilder.Entity("GestaoPI.Models.ServicoPatente", b =>
                {
                    b.HasOne("GestaoPI.Models.Patente", "Patente")
                        .WithMany()
                        .HasForeignKey("CodigoPatente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GestaoPI.Models.CodigoServicoPatente", "CodigoServicoPatente")
                        .WithMany("ServicosPatente")
                        .HasForeignKey("CodigoServico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CodigoServicoPatente");

                    b.Navigation("Patente");
                });

            modelBuilder.Entity("InventorPatente", b =>
                {
                    b.HasOne("GestaoPI.Models.Inventor", null)
                        .WithMany()
                        .HasForeignKey("InventoresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GestaoPI.Models.Patente", null)
                        .WithMany()
                        .HasForeignKey("PatentesCodigo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GestaoPI.Models.CodigoDespachoPatente", b =>
                {
                    b.Navigation("DespachoPatentes");
                });

            modelBuilder.Entity("GestaoPI.Models.CodigoServicoPatente", b =>
                {
                    b.Navigation("ServicosPatente");
                });

            modelBuilder.Entity("GestaoPI.Models.Patente", b =>
                {
                    b.Navigation("DespachoPatentes");
                });

            modelBuilder.Entity("GestaoPI.Models.Revista", b =>
                {
                    b.Navigation("DespachoPatentes");
                });
#pragma warning restore 612, 618
        }
    }
}
