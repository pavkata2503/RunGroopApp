using Microsoft.EntityFrameworkCore;
using RunGroopWebApp.Models;

namespace RunGroopWebApp.Data
{
    public class ApplicationDbContext:DbContext
    {
        //Add-Migration InitialCreate
        //To undo this action, use Remove-Migration.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Race> Races { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
