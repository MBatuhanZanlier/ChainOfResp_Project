using Microsoft.EntityFrameworkCore;

namespace ChainOfResp_Project.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-J7PG414\\SQLEXPRESS; initial Catalog=DbCqrs; integrated security=true");
        }
        public DbSet<CustomerProcess> customerProcesses { get; set; }
    }
}
