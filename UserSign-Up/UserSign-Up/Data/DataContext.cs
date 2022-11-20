using Microsoft.EntityFrameworkCore;
using UserSign_Up.Models;

namespace UserSign_Up.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<User> Users => Set<User>();
    }
}
