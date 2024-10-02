using instituteManagement.Api.Model;
using Microsoft.EntityFrameworkCore;

namespace instituteManagement.Api.Data
{
    public class InstituteDbContext:DbContext
    {
        public InstituteDbContext(DbContextOptions<InstituteDbContext> dbContextOptions) : base(dbContextOptions)
        {
            
        }
        DbSet<Student> Students { get; set; }
    }
}
