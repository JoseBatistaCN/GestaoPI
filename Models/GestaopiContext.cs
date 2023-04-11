using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace GestaoPI.Models;

public partial class GestaopiContext : DbContext
{
    public GestaopiContext()
    {
    }

    public GestaopiContext(DbContextOptions<GestaopiContext> options)
        : base(options)
    {
    }

    public DbSet<Processo> Processos { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Processo>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PRIMARY");

            entity.ToTable("processo");

            entity.Property(e => e.Codigo)
                .HasMaxLength(19)
                .IsFixedLength()
                .HasColumnName("codigo");
            entity.Property(e => e.Anotacao)
                .HasColumnType("mediumtext")
                .HasColumnName("anotacao");
            entity.Property(e => e.CodigoNotificacao)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("codigo_notificacao");
            entity.Property(e => e.Deposito).HasColumnName("deposito");
            entity.Property(e => e.DominioPublico).HasColumnName("dominio_publico");
            entity.Property(e => e.Exame).HasColumnName("exame");
            entity.Property(e => e.Resumo)
                .HasColumnType("mediumtext")
                .HasColumnName("resumo");
            entity.Property(e => e.Titulo)
                .HasMaxLength(255)
                .HasColumnName("titulo");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
