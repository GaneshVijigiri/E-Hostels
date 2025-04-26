using System;
using System.Collections.Generic;
using EHostels.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EHostels.Data.Context;

public partial class EHostelsDbContext : DbContext
{
    public EHostelsDbContext()
    {
    }

    public EHostelsDbContext(DbContextOptions<EHostelsDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Database=E-Hostels;Username=postgres;Password=Demo@123");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.EntityId).HasName("Users_pkey");

            entity.Property(e => e.EntityId).UseIdentityAlwaysColumn();
            entity.Property(e => e.IsActive).HasDefaultValue(true);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
