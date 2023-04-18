using System;
using System.Collections.Generic;
using GestaoPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GestaoPI.Data;

public partial class PatenteContext : DbContext
{
    public PatenteContext()
    {
    }

    public PatenteContext(DbContextOptions<PatenteContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Patente> Patentes { get; set; } = null!;
    public virtual DbSet<Revista> Revistas { get; set; } = null!;
      partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
