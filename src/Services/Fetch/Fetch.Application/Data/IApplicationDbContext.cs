using Microsoft.EntityFrameworkCore;
using Ecmanage.eProcessor.Services.Fetch.Fetch.Domain.Models;

namespace Ecmanage.eProcessor.Services.Fetch.Fetch.Application.Data;
public interface IApplicationDbContext
{
    DbSet<Customer> Customers { get; }
    DbSet<Product> Products { get; }
    DbSet<Order> Orders { get; }
    DbSet<OrderItem> OrderItems { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
