global using Microsoft.EntityFrameworkCore;
//using DevExpress.Data.Browsing;
//using SuperHeroApi.Models;

namespace SuperHeroApi.Data
{
    public class DataContext : DbContext
    {
        // 使用ctor建立構造函式
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=superherodb;Trusted_Connection=true;TrustServerCertificate=true;");
        }

        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
