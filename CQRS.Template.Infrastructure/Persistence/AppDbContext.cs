using CQRS.Template.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRS.Template.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users => Set<User>();
}
