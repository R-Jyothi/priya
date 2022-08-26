using Microsoft.EntityFrameworkCore;

namespace Core6.Models
{
    public class HRContext :DbContext
    {
        public HRContext(DbContextOptions<HRContext> option): base(option)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
