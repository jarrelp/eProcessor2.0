using Microsoft.EntityFrameworkCore;
using Ecmanage.eProcessor.Services.Fetch.Fetch.Application.Data;
using Ecmanage.eProcessor.Services.Fetch.Fetch.Domain.Models;
using System.Reflection;

namespace Ecmanage.eProcessor.Services.Fetch.Fetch.Infrastructure.Data;
public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<Product> Products => Set<Product>();
    public DbSet<Order> Orders => Set<Order>();
    public DbSet<OrderItem> OrderItems => Set<OrderItem>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(builder);
    }
}
