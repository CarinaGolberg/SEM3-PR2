using DataAccessLayer;
using SEM3_PR1_MODEL;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace PR1_SEM3_LOGIC
{
    public class PPLibraryLogic
    {
        private readonly IRepository<PoisonousPlant> _repo;

        public PPLibraryLogic()
        {
            string repoType = ConfigurationManager.AppSettings["RepositoryType"];

            if (repoType == "Dapper")
                _repo = new DapperRepository<PoisonousPlant>();
            else
                _repo = new EntityRepository<PoisonousPlant>();
        }

        /// <summary>
        /// Возвращает все записи.
        /// </summary>
        /// <returns></returns>
        public List<PoisonousPlant> GetAllPlants() => _repo.GetAll().ToList();

        /// <summary>
        /// CREATE => Создание нового объекта.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="latinName"></param>
        /// <param name="nativeRegion"></param>
        /// <param name="toxin"></param>
        /// <param name="dangerLevel"></param>
        /// <param name="symptoms"></param>
        public void AddPlant(int id, string name, string latinName, string nativeRegion, string toxin, string dangerLevel, string symptoms)
        {
            var plant = new PoisonousPlant
            {
                Id = id,
                Name = name,
                LatinName = latinName,
                NativeRegion = nativeRegion,
                Toxin = toxin,
                DangerLevel = dangerLevel,
                Symptoms = symptoms
            };

            _repo.Add(plant);
        }

        /// <summary>
        /// Проверка Id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="excludeId"></param>
        /// <returns></returns>
        public bool ExistsId(int id, int? excludeId = null)
            => _repo.GetAll().Any(p => p.Id == id && p.Id != excludeId);

        /// <summary>
        /// Поиск растения по Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public PoisonousPlant GetPlantById(int id) => _repo.GetById(id);

        /// <summary>
        /// Обновляет данные растения
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="latinName"></param>
        /// <param name="nativeRegion"></param>
        /// <param name="toxin"></param>
        /// <param name="dangerLevel"></param>
        /// <param name="symptoms"></param>
        /// <returns></returns>
        public bool UpdatePlant(int id, string name, string latinName, string nativeRegion, string toxin, string dangerLevel, string symptoms)
        {
            var plant = _repo.GetById(id);
            if (plant == null) return false;

            plant.Name = name;
            plant.LatinName = latinName;
            plant.NativeRegion = nativeRegion;
            plant.Toxin = toxin;
            plant.DangerLevel = dangerLevel;
            plant.Symptoms = symptoms;

            _repo.Update(plant);
            return true;
        }

        /// <summary>
        /// Удалает объект
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeletePlant(int id)
        {
            _repo.Delete(id);
            return true;
        }

        /// <summary>
        /// Группировка по уровню опасности
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, List<PoisonousPlant>> GroupByDangerLevel()
        {
            return _repo.GetAll()
                        .GroupBy(p => p.DangerLevel)
                        .ToDictionary(g => g.Key, g => g.ToList());
        }

        /// <summary>
        /// Поиск растения по токсину.
        /// </summary>
        /// <param name="toxin"></param>
        /// <returns></returns>
        public List<PoisonousPlant> FindByToxin(string toxin)
        {
            return _repo.GetAll()
                        .Where(p => p.Toxin.ToLower().Contains(toxin.ToLower()))
                        .ToList();
        }
    }
}
