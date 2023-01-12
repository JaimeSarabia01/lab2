using Microsoft.EntityFrameworkCore;
using Software.Design.Models;

namespace Software.Design.DataModels;

public class TVShowContext : DbContext
{
    public TVShowContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<TVShow> TVShows => Set<TVShow>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TVShow>()
            .HasKey(b => b.tvshowid);

        modelBuilder.Entity<TVShow>().ToTable("tvshow", schema: "public");
    }
}