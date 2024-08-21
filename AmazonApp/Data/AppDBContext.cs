using AmazonApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AmazonApp.Data
{
    public class AppDBContext :DbContext
    {
        public AppDBContext(DbContextOptions options) : base(options) { 
        }

        public DbSet<Products> products { get; set; }
        public DbSet<Users> users { get; set; }


    }
}
