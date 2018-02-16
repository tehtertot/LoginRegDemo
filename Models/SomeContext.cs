using Microsoft.EntityFrameworkCore;

namespace LoginRegDemo.Models
{
    public class SomeContext : DbContext
    {
        public SomeContext(DbContextOptions<SomeContext> options) : base(options) { }
    }
}