using System.Data.Entity;

namespace Mithuvai.Models
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}
