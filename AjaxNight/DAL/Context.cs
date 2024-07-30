using Microsoft.EntityFrameworkCore;

namespace AjaxNight.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-COQ9ECD\\SQLEXPRESS;database=AjaxDbNight;integrated security=true");
        }
        public DbSet<Product> Products { get; set; }
    }
}
