using System;
using System.Collections.Generic;
using GestaoPI.Models;
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

    public virtual DbSet<Patente> Patentes => Set<Patente>();
    public virtual DbSet<Revista> Revistas => Set<Revista>();
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
