using Microsoft.EntityFrameworkCore;
using TokenAPI.Models;

namespace TokenAPI.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
  

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder
                .UseSqlServer("Data Source=ArpitAtoZ\\SQLEXPRESS;Initial Catalog=FirstDB;Integrated Security=True;TrustServerCertificate=Yes;");
        }

        public DbSet<User> Users => Set<User>();
    }
}
