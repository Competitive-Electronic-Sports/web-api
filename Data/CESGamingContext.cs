using Microsoft.EntityFrameworkCore;
using web_api.Models;

namespace web_api.Data;

public class CESGamingContext : DbContext
{
    public CESGamingContext(DbContextOptions<CESGamingContext> options)
        : base(options)
    {
    }
    
    public DbSet<Event> Events { get; set; }
    public DbSet<Game> Games { get; set; }
    public DbSet<Map> Maps { get; set; }
    public DbSet<Match> Matches { get; set; }
    public DbSet<Organisation> Organisations { get; set; }
    public DbSet<Rating> Ratings { get; set; }
    public DbSet<Round> Rounds { get; set; }
    public DbSet<Team> Teams { get; set; }
    public DbSet<User> Users { get; set; }
    
    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.Entity<Event>().ToTable("Event");
    //     modelBuilder.Entity<Game>().ToTable("Game");
    //     modelBuilder.Entity<Map>().ToTable("Map");
    //     modelBuilder.Entity<Match>().ToTable("Match");
    //     modelBuilder.Entity<Organisation>().ToTable("Organisation");
    //     modelBuilder.Entity<Rating>().ToTable("Rating");
    //     modelBuilder.Entity<Round>().ToTable("Round");
    //     modelBuilder.Entity<Team>().ToTable("Team");
    //     modelBuilder.Entity<User>().ToTable("User");
    // }
}