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

    public virtual DbSet<Codigodespachospatente> Codigodespachospatentes { get; set; }

    public virtual DbSet<Codigoservicopatente> Codigoservicopatentes { get; set; }

    public virtual DbSet<Despachopatente> Despachopatentes { get; set; }

    public virtual DbSet<Patente> Patentes { get; set; }

    public virtual DbSet<Revista> Revistas { get; set; }

    public virtual DbSet<Inventor> Inventores {get; set;}

    public virtual DbSet<Servicopatente> Servicopatentes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySql("server=localhost;port=3306;database=gestaopi;user=root;password=admin", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.32-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        OnModelCreatingPartial(modelBuilder);
    }

    internal Task<Patente?> FindAsync(string patenteCodigo)
    {
        throw new NotImplementedException();
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
