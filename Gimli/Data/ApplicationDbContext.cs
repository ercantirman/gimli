using Gimli.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Gimli.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Cloth> Clothes { get; set; }
    }
}
