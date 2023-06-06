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

            modelBuilder.Entity("GestaoPI.Models.CodigoDespachoPatente", b =>
                {
                    b.Property<string>("CodigoDespacho")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("codigo_despacho");

                    b.Property<string>("Descricao")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("descricao");

                    b.HasKey("CodigoDespacho");

                    b.ToTable("codigo_despacho_patente");
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

            modelBuilder.Entity("GestaoPI.Models.DespachoPatente", b =>
                {
                    b.Property<string>("PatenteCodigo")
                        .HasMaxLength(19)
                        .HasColumnType("varchar(19)")
                        .HasColumnName("patente_codigo");

                    b.Property<int>("RevistaCodigo")
                        .HasColumnType("int")
                        .HasColumnName("revista_codigo");

                    b.Property<string>("CodigoDespacho")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("codigo_despacho");

                    b.Property<bool?>("Cumprido")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("cumprido");

                    b.Property<string>("Descricao")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime?>("Validade")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("validade");

                    b.HasKey("PatenteCodigo", "RevistaCodigo");

                    b.HasIndex("CodigoDespacho");

                    b.HasIndex("RevistaCodigo");

                    b.ToTable("despacho_patente");
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

                    b.Property<string>("Situacao")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("situacao");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("status");

                    b.Property<string>("Titulo")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("titulo");

                    b.HasKey("Codigo");

                    b.HasIndex("Situacao");

                    b.HasIndex(new[] { "Codigo" }, "codigo_UNIQUE")
                        .IsUnique();

                    b.ToTable("patente");
                });

            modelBuilder.Entity("GestaoPI.Models.Revista", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
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

            modelBuilder.Entity("GestaoPI.Models.SituacaoPatente", b =>
                {
                    b.Property<string>("Situacao")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("situacao");

                    b.HasKey("Situacao");

                    b.ToTable("situacao_patente");
                });

            modelBuilder.Entity("GestaoPI.Models.DespachoPatente", b =>
                {
                    b.HasOne("GestaoPI.Models.CodigoDespachoPatente", "CodigoDespachoPatente")
                        .WithMany("DespachosPatente")
                        .HasForeignKey("CodigoDespacho")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GestaoPI.Models.Patente", "Patente")
                        .WithMany("DespachosPatente")
                        .HasForeignKey("PatenteCodigo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GestaoPI.Models.Revista", "Revista")
                        .WithMany("DespachoPatentes")
                        .HasForeignKey("RevistaCodigo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CodigoDespachoPatente");

                    b.Navigation("Patente");

                    b.Navigation("Revista");
                });

            modelBuilder.Entity("GestaoPI.Models.Patente", b =>
                {
                    b.HasOne("GestaoPI.Models.SituacaoPatente", "SituacaoPatente")
                        .WithMany("Patentes")
                        .HasForeignKey("Situacao");

                    b.Navigation("SituacaoPatente");
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

            modelBuilder.Entity("GestaoPI.Models.CodigoDespachoPatente", b =>
                {
                    b.Navigation("DespachosPatente");
                });

            modelBuilder.Entity("GestaoPI.Models.CodigoServicoPatente", b =>
                {
                    b.Navigation("ServicosPatente");
                });

            modelBuilder.Entity("GestaoPI.Models.Patente", b =>
                {
                    b.Navigation("DespachosPatente");

                    b.Navigation("ServicosPatente");
                });

            modelBuilder.Entity("GestaoPI.Models.Revista", b =>
                {
                    b.Navigation("DespachoPatentes");
                });

            modelBuilder.Entity("GestaoPI.Models.SituacaoPatente", b =>
                {
                    b.Navigation("Patentes");
                });
#pragma warning restore 612, 618
        }
    }
}
