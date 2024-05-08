using Entities.Concrete;
using Microsoft.EntityFrameworkCore;


namespace DataAccess.Concrete.EntityFramework.Contexts;

public class FurkanContext : DbContext
{
    public FurkanContext()
    {
        
    }
    public FurkanContext(DbContextOptions<FurkanContext> options) : base(options)
    {
        
    }

    public DbSet<Artist> Artists { get; set; }
    public DbSet<Album> Albums { get; set; }
    public DbSet<Music> Musics { get; set; }

     protected override void OnModelCreating(ModelBuilder modelBuilder)
     {
     }
}