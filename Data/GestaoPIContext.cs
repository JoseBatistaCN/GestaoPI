using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using GestaoPI.Models;

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

    public virtual DbSet<Efmigrationshistory> Efmigrationshistories { get; set; } = null!;

    public virtual DbSet<Patente> Patentes => Set<Patente>();

    public virtual DbSet<ServicoPatente> ServicosPatente => Set<ServicoPatente>();

    public virtual DbSet<Revista> Revista => Set<Revista>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
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
            entity.Property(e => e.Status)
                .HasMaxLength(45)
                .HasColumnName("status");
            entity.Property(e => e.Titulo)
                .HasMaxLength(255)
                .HasColumnName("titulo");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
