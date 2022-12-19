using Microsoft.EntityFrameworkCore;
using MySql.Data;
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
    // public DbSet<Map> Maps { get; set; }
    // public DbSet<Match> Matches { get; set; }
    // public DbSet<Organisation> Organisations { get; set; }
    // public DbSet<Rating> Ratings { get; set; }
    // public DbSet<Round> Rounds { get; set; }
    // public DbSet<Team> Teams { get; set; }
    // public DbSet<User> Users { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Rating>()
            .HasKey(r => new { r.GameId, r.UserId });

        modelBuilder.Entity<TeamMember>()
            .HasKey(t => new { t.TeamId, t.PlayerId });

        modelBuilder.Entity<Event>().ToTable("event");
        modelBuilder.Entity<Event>().HasOne(e => e.Game)
            .WithMany(g => g.Events)
            .HasForeignKey(e => e.GameId);

        modelBuilder.Entity<Game>().ToTable("game");
        modelBuilder.Entity<Game>().Property(g => g.Id).HasColumnName("id");
    }
}