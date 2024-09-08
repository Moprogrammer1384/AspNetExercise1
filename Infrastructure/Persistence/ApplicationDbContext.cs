using AspNetExercise1.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetExercise1.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }

    public DbSet<RequestInfo> RequestInfos { get; set; }    
}
