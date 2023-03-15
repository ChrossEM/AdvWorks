using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AdvWorks.Models;

namespace AdvWorks.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<AdvWorks.Models.Customer> Customer { get; set; } = default!;
    public DbSet<AdvWorks.Models.Product> Product { get; set; } = default!;
    public DbSet<AdvWorks.Models.Order> Order { get; set; } = default!;
}