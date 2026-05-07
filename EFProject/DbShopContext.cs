using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFProject;

public partial class DbShopContext : DbContext
{
    public DbShopContext()
    {
        Database.EnsureCreated();
    }

    public DbShopContext(DbContextOptions<DbShopContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Sdelka> Sdelkas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=dbShop.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.IdClient);

            entity.ToTable("Client");

            entity.Property(e => e.IdClient).ValueGeneratedOnAdd();
            entity.Property(e => e.Email).HasColumnName("email");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.IdProduct);

            entity.ToTable("Product");

            entity.Property(e => e.IdProduct).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Sdelka>(entity =>
        {
            entity.HasKey(e => e.IdSdelka);

            entity.ToTable("Sdelka");

            entity.Property(e => e.IdSdelka)
                .ValueGeneratedOnAdd()
                .HasColumnName("idSdelka");

            entity.HasOne(d => d.IdClientNavigation).WithMany(p => p.Sdelkas)
                .HasForeignKey(d => d.IdClient)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.IdProductNavigation).WithMany(p => p.Sdelkas)
                .HasForeignKey(d => d.IdProduct)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
