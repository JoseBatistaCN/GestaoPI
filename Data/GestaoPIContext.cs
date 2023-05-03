using System;
using System.Collections.Generic;
using GestaoPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GestaoPI.Data;

public partial class GestaopiContext : DbContext
{
    public GestaopiContext()
    {
    }

    public GestaopiContext(DbContextOptions<GestaopiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Codigodespachospatente> Codigodespachospatentes { get; set; }

    public virtual DbSet<Codigoservicopatente> Codigoservicopatentes { get; set; }

    public virtual DbSet<Despachopatente> Despachopatentes { get; set; }

    public virtual DbSet<Patente> Patentes { get; set; }

    public virtual DbSet<Revista> Revista { get; set; }

    public virtual DbSet<Servicopatente> Servicopatentes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySql("server=localhost;port=3306;database=gestaopi;user=root;password=admin", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.32-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");


        modelBuilder.Entity<Codigodespachospatente>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PRIMARY");
        });

        modelBuilder.Entity<Codigoservicopatente>(entity =>
        {
            entity.HasKey(e => e.Servico).HasName("PRIMARY");
        });

        modelBuilder.Entity<Despachopatente>(entity =>
        {
            entity.HasKey(e => new { e.PatenteCodigo, e.RevistaCodigo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.PatenteCodigo).IsFixedLength();

            entity.HasOne(d => d.CodigoDespachosPatenteCodigoNavigation).WithMany(p => p.Despachopatentes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_DespachoPatente_CodigoDespachosPatente");

            entity.HasOne(d => d.PatenteCodigoNavigation).WithMany(p => p.Despachopatentes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_DespachoPatente_patente");

            entity.HasOne(d => d.RevistaCodigoNavigation).WithMany(p => p.Despachopatentes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_DespachoPatente_revista");
        });


        modelBuilder.Entity<Patente>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PRIMARY");

            entity.Property(e => e.Codigo).IsFixedLength();
        });

        modelBuilder.Entity<Revista>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PRIMARY");

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.DespachoPatentePatenteCodigo).IsFixedLength();
        });

        modelBuilder.Entity<Servicopatente>(entity =>
        {
            entity.HasKey(e => e.ServicoPatenteId).HasName("PRIMARY");

            entity.Property(e => e.PatenteCodigo).IsFixedLength();

            entity.HasOne(d => d.PatenteCodigoNavigation).WithMany(p => p.Servicopatentes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ServicoPatente_patente");
        });


        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
