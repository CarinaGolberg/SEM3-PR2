using Dapper;
using System.Collections.Generic;
using SEM3_PR1_MODEL;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DataAccessLayer
{
    public class DapperRepository<T> : IRepository<PoisonousPlant>
    {
        /// <summary>
        /// Получает значение настройки приложения из файла конфигурации (App.config)
        /// </summary>
        private readonly string _connectionString =
            System.Configuration.ConfigurationManager.ConnectionStrings["PoisonousPlantsDB"].ConnectionString;

        /// <summary>
        /// SELECT для получения всех растений
        /// </summary>
        /// <returns></returns>
        public IEnumerable<PoisonousPlant> GetAll()
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
                return db.Query<PoisonousPlant>("SELECT * FROM PoisonousPlants").ToList(); //Эквивалент SaveChanges() в Entity Framework, но с явным SQL-запросом.
        }

        /// <summary>
        /// SELECT с параметром для поиска по ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public PoisonousPlant GetById(int id)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
                return db.QueryFirstOrDefault<PoisonousPlant>("SELECT * FROM PoisonousPlants WHERE Id=@Id", new { Id = id }); //Dapper автоматически связывает свойство Id с параметром @Id в SQL
        }

        /// <summary>
        /// INSERT для добавления новой записи
        /// </summary>
        /// <param name="plant"></param>
        public void Add(PoisonousPlant plant)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var sql = @"INSERT INTO PoisonousPlants (Name, LatinName, NativeRegion, Toxin, DangerLevel, Symptoms)
                            VALUES (@Name, @LatinName, @NativeRegion, @Toxin, @DangerLevel, @Symptoms)";
                db.Execute(sql, plant);
            }
        }

        /// <summary>
        /// UPDATE для изменения существующей записи
        /// </summary>
        /// <param name="plant"></param>
        public void Update(PoisonousPlant plant)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var sql = @"UPDATE PoisonousPlants 
                            SET Name=@Name, LatinName=@LatinName, NativeRegion=@NativeRegion, 
                                Toxin=@Toxin, DangerLevel=@DangerLevel, Symptoms=@Symptoms
                            WHERE Id=@Id";
                db.Execute(sql, plant);
            }
        }

        /// <summary>
        /// DELETE для удаления записи
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
                db.Execute("DELETE FROM PoisonousPlants WHERE Id=@Id", new { Id = id }); 
        }
    }
}
