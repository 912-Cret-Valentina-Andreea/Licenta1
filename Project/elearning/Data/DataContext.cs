using elearning.Entities;
using Microsoft.EntityFrameworkCore;

namespace elearning.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Classes> Classes { get; set; }

    }
}
