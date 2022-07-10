using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class IssueDbContext:DbContext

    {
        public IssueDbContext(DbContextOptions<IssueDbContext> options): base(options)

        {

        }

        public DbSet<Issue> Issues { get; set; }
    }
}
