using Microsoft.EntityFrameworkCore;
using RepositoryServicePattern.Data.Entities;

namespace RepositoryServicePattern.Data.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options) { }

        public DbSet<FoodItem> Foods { get; set; }
    }
}
