using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GestaoPI.Data;

public partial class GestaoPIContext : DbContext
{
    public GestaoPIContext()
    {
    }

    public GestaoPIContext(DbContextOptions<GestaoPIContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Efmigrationshistory> Efmigrationshistories { get; set; }

    public virtual DbSet<Patente> Patentes { get; set; }

    public virtual DbSet<Revistum> Revista { get; set; }

    public virtual DbSet<Servicospatente> Servicospatentes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;port=3306;database=gestaopi;user=root;password=admin", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.32-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Efmigrationshistory>(entity =>
        {
            entity.HasKey(e => e.MigrationId).HasName("PRIMARY");

            entity.ToTable("__efmigrationshistory");

            entity.Property(e => e.MigrationId).HasMaxLength(150);
            entity.Property(e => e.ProductVersion).HasMaxLength(32);
        });

        modelBuilder.Entity<Patente>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PRIMARY");

            entity.ToTable("patente");

            entity.HasIndex(e => e.Codigo, "codigo_UNIQUE").IsUnique();

            entity.HasIndex(e => e.SituacaoPatenteSituacao, "fk_patente_SituacaoPatente1_idx");

            entity.Property(e => e.Codigo)
                .HasMaxLength(19)
                .IsFixedLength()
                .HasColumnName("codigo");
            entity.Property(e => e.Anotacao)
                .HasColumnType("text")
                .HasColumnName("anotacao");
            entity.Property(e => e.Concessao).HasColumnName("concessao");
            entity.Property(e => e.Deposito).HasColumnName("deposito");
            entity.Property(e => e.Exame).HasColumnName("exame");
            entity.Property(e => e.Publicacao).HasColumnName("publicacao");
            entity.Property(e => e.Resumo)
                .HasColumnType("mediumtext")
                .HasColumnName("resumo");
            entity.Property(e => e.SituacaoPatenteSituacao)
                .HasMaxLength(50)
                .HasColumnName("SituacaoPatente_situacao");
            entity.Property(e => e.Status)
                .HasMaxLength(45)
                .HasColumnName("status");
            entity.Property(e => e.Titulo)
                .HasMaxLength(255)
                .HasColumnName("titulo");
        });

        modelBuilder.Entity<Revistum>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PRIMARY");

            entity.ToTable("revista");

            entity.Property(e => e.Codigo)
                .ValueGeneratedNever()
                .HasColumnName("codigo");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.DespachoPatentePatenteCodigo)
                .HasMaxLength(19)
                .IsFixedLength()
                .HasColumnName("DespachoPatente_patente_codigo");
        });

        modelBuilder.Entity<Servicospatente>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PRIMARY");

            entity.ToTable("servicospatente");

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.Servico).HasMaxLength(255);
            entity.Property(e => e.ValorComDesconto).HasPrecision(10, 2);
            entity.Property(e => e.ValorSemDesconto).HasPrecision(10, 2);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
