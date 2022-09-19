using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Openlet.Models;

public class OpenletContext : IdentityDbContext
{
    public OpenletContext()
    {
        
    }
    
    public OpenletContext(DbContextOptions<OpenletContext> options) : base(options)
    {
        
    }
    
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<StudySet> StudySets { get; set; } = null!;
    public DbSet<Card> Cards { get; set; } = null!;
    public DbSet<LearnCard> LearnCards { get; set; } = null!;
    public DbSet<Learn> Learns { get; set; } = null!;
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite("DataSource=openletDb.sqlite3");
        }
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<LearnCard>()
            .Property(x => x.Pool)
            .HasConversion(
                x => x.ToString(),
                x => (Pool) Enum.Parse(typeof(Pool), x));
        
        base.OnModelCreating(modelBuilder);
    }   
}