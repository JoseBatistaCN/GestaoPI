using System;
using System.Collections.Generic;
using GestaoPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GestaoPI.Data;

public partial class GestaopiContext : DbContext
{

    public GestaopiContext(DbContextOptions<GestaopiContext> options)
        : base(options)
    {

    }

    public virtual DbSet<CodigoDespachoPatente> CodigoDespachoPatentes { get; set; } = null!;
    public virtual DbSet<DespachoPatente> DespachoPatentes { get; set; } = null!;
    public virtual DbSet<CodigoServicoPatente> CodigoServicoPatentes { get; set; } = null!;
    public virtual DbSet<ServicoPatente> ServicoPatentes { get; set; } = null!;
    public virtual DbSet<Patente> Patentes { get; set; } = null!;
    public virtual DbSet<ProgramaDeComputador> ProgramaDeComputadores { get; set; } = null!;
    public virtual DbSet<DesenhoIndustrial> DesenhoIndustriais { get; set; } = null!;
    public virtual DbSet<Marca> Marcas { get; set; } = null!;
    public virtual DbSet<Inventor> Inventores { get; set; } = null!;
    public virtual DbSet<Revista> Revistas { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySql("server=localhost;port=3306;database=gestaopi;user=root;password=admin", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.32-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
