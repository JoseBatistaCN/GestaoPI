using System;
using System.Collections.Generic;
using GestaoPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GestaoPI.Context;

public partial class PatenteContext : DbContext
{
    public PatenteContext()
    {
    }

    public PatenteContext(DbContextOptions<PatenteContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CodigoDespachosPatente> CodigoDespachosPatentes { get; set; } = null!;

    public virtual DbSet<Patente> Patentes { get; set; } = null!;

    public virtual DbSet<Revista> Revista { get; set; } = null!;
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<CodigoDespachosPatente>(entity =>
        {
            entity.HasKey(e => e.CodigoId).HasName("PRIMARY");
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
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
