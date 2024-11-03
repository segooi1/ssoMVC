using Microsoft.EntityFrameworkCore;
using sso.Models;

namespace sso.Controllers
{
    public class ApplicationDBcontext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=sso;Integrated Security=True;");
        }

        public DbSet<sessionInfo> sessionInfos { get; set; }
        public DbSet<userData> userDatas { get; set; }
        public DbSet<userCred> userCreds { get; set; }

    }
}
