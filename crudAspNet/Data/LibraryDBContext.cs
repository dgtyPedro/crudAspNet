using crudAspNet.Data.Map;
using crudAspNet.Models;
using Microsoft.EntityFrameworkCore;

namespace crudAspNet.Data;

public class LibraryDBContext : DbContext
{
    public LibraryDBContext(DbContextOptions<LibraryDBContext> options) :base(options)
    {
    }
    
    public DbSet<BookModel> Books { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new BookMap());
        base.OnModelCreating(modelBuilder);
    }
}