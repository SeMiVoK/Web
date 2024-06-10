using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class YourDbContext : DbContext
{
    public DbSet<Item> Items { get; set; }

    public YourDbContext(DbContextOptions<YourDbContext> options) : base(options)
    {
    }
}
