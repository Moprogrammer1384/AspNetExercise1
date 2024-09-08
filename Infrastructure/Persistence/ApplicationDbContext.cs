using AspNetExercise1.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetExercise1.Infrastructure.Persistence;

public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }

    public DbSet<RequestInfo> RequestInfos { get; set; }    
}
