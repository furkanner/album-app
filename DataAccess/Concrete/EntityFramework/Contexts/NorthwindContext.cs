using Entities.Concrete;
using Microsoft.EntityFrameworkCore;


namespace DataAccess.Concrete.EntityFramework.Contexts;

public class FurkanContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(
            connectionString:
            @"Server=localhost;Database=postgres;User Id=postgres;Password=1234;Include Error Detail=true;");
    }

    public DbSet<Artist> Artists { get; set; }
    public DbSet<Album> Albums { get; set; }
    public DbSet<Music> Musics { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}