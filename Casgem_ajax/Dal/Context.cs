using Microsoft.EntityFrameworkCore;

namespace Casgem_ajax.Dal
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-PBKE4PO\\SQLEXPRESS; initial catalog=CasgemAjaxDb; integrated Security=true");
        }
        public DbSet<Customer> Customers { get; set; }  
    }
}
