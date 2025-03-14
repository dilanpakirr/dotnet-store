
namespace dotnet_store.Models;
using Microsoft.EntityFrameworkCore;

public class DataContext : DbContext
{
    //constructor method
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    public DbSet<Slide> Slides { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, CategoryName = "Category 1", Url = "category-1" },
            new Category { Id = 2, CategoryName = "Category 2", Url = "category-2" },
            new Category { Id = 3, CategoryName = "Category 3", Url = "category-3" },
            new Category { Id = 4, CategoryName = "Category 4", Url = "category-4" },
            new Category { Id = 5, CategoryName = "Category 5", Url = "category-5" }
        );
        modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, ProductName = "Product 1", Price = 10.00, IsActive = true, Image = "1.jpeg", Description = "Product 1 Description", IsHome = true, CategoryId = 1 },
            new Product { Id = 2, ProductName = "Product 2", Price = 20.00, IsActive = true, Image = "2.jpeg", Description = "Product 2 Description", IsHome = true, CategoryId = 2 },
            new Product { Id = 3, ProductName = "Product 3", Price = 30.00, IsActive = true, Image = "3.jpeg", Description = "Product 3 Description", IsHome = true, CategoryId = 3 },
            new Product { Id = 4, ProductName = "Product 4", Price = 40.00, IsActive = true, Image = "4.jpeg", Description = "Product 4 Description", IsHome = true, CategoryId = 4 },
            new Product { Id = 5, ProductName = "Product 5", Price = 50.00, IsActive = true, Image = "5.jpeg", Description = "Product 5 Description", IsHome = true, CategoryId = 5 },
            new Product { Id = 6, ProductName = "Product 6", Price = 60.00, IsActive = true, Image = "6.jpeg", Description = "Product 6 Description", IsHome = true, CategoryId = 1 },
            new Product { Id = 7, ProductName = "Product 7", Price = 70.00, IsActive = true, Image = "7.jpeg", Description = "Product 7 Description", IsHome = true, CategoryId = 2 },
            new Product { Id = 8, ProductName = "Product 8", Price = 80.00, IsActive = true, Image = "8.jpeg", Description = "Product 8 Description", IsHome = true, CategoryId = 3 }
        );
        modelBuilder.Entity<Slide>().HasData(
            new Slide { Id = 1, Image = "slider-1.jpeg", Title = "Slide 1", Url = "slide-1" },
            new Slide { Id = 2, Image = "slider-2.jpeg", Title = "Slide 2", Url = "slide-2" },
            new Slide { Id = 3, Image = "slider-3.jpeg", Title = "Slide 3", Url = "slide-3" }
        );
    }
}


// DataContext _context= new DataContext();
