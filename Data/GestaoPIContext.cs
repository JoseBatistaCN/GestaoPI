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

    public virtual DbSet<CodigoDespachoPatente> CodigoDespachoPatentes { get; set; }
    public virtual DbSet<DespachoPatente> DespachoPatentes { get; set; }
    public virtual DbSet<CodigoServicoPatente> CodigoServicoPatentes { get; set; }
    public virtual DbSet<ServicoPatente> ServicoPatentes { get; set; }

    public virtual DbSet<Patente> Patentes { get; set; }
    public virtual DbSet<ProgramaDeComputador> ProgramaDeComputadores { get; set; }
    public virtual DbSet<DesenhoIndustrial> DesenhoIndustriais { get; set; }
    public virtual DbSet<Marca> Marcas { get; set; }

    public virtual DbSet<Inventor> Inventores { get; set; }
    public virtual DbSet<Revista> Revistas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySql("server=localhost;port=3306;database=gestaopi;user=root;password=admin", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.32-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
