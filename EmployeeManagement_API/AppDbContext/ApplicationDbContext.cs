using EmployeeManagement_API.Model;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement_API.AppDbContext
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
