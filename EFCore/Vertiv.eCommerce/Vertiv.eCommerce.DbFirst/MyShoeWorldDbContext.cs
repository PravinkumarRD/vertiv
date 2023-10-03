using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Vertiv.eCommerce.DbFirst;

public partial class MyShoeWorldDbContext : DbContext
{
    public MyShoeWorldDbContext()
    {
    }

    public MyShoeWorldDbContext(DbContextOptions<MyShoeWorldDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cart> Carts { get; set; }

    public virtual DbSet<CartDetail> CartDetails { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<CategoryWiseProduct> CategoryWiseProducts { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Invoice> Invoices { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=MyShoeWorldDb;Trusted_Connection=true;TrustServerCertificate=True;").LogTo(Console.WriteLine);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CategoryWiseProduct>(entity =>
        {
            entity.ToView("CategoryWiseProducts");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
