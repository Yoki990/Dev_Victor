using Ex03.Class.Model;
using Microsoft.EntityFrameworkCore;

namespace Ex03.Class.DbManager
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Recette> Recettes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<RecetteIngredient> RecetteIngredients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;database=ado;uid=root;pwd=",
                ServerVersion.AutoDetect("server=localhost;database=ado;uid=root;pwd=")

                );
        }
    }
}
