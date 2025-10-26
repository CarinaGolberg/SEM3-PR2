using System.Data.Entity;
using SEM3_PR1_MODEL;

namespace DataAccessLayer
{
    public class PoisonousPlantContext : DbContext
    {
        public PoisonousPlantContext()
            : base("name=PoisonousPlantsDB")
        {
            // Создаёт базу один раз, если ее нет.
            Database.SetInitializer(new CreateDatabaseIfNotExists<PoisonousPlantContext>());
        }

        public DbSet<PoisonousPlant> PoisonousPlants { get; set; }
    }
}
