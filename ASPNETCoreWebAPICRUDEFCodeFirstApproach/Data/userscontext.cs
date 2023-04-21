using ASPNETCoreWebAPICRUDEFCodeFirstApproach.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCoreWebAPICRUDEFCodeFirstApproach.Data
{
    public class userscontext : DbContext
    {
        public userscontext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Users> Users { get; set; }
    }
}
