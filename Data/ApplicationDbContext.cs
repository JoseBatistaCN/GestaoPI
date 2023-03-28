using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace GestaoPI.Data {
    public class ApplicationDbContext : DbContext {
        
        public ApplicationDbContext() { }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {       
        optionsBuilder.UseMySql("DefaultConnection", ServerVersion.AutoDetect("DefaultConnection"));
        }
    }
}