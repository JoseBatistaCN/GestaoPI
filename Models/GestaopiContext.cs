using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

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

    public virtual DbSet<Processo> Processos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;port=3306;database=gestaopi;user=root;password=admin", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.32-mysql"));

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
            entity.Property(e => e.Tipo)
                .HasColumnType("enum('PI - Patente de Invenção','MU - Modelo de Utilidade','DI - Desenho Industrial')")
                .HasColumnName("tipo");
            entity.Property(e => e.Titulo)
                .HasMaxLength(255)
                .HasColumnName("titulo");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
