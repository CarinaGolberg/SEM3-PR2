using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SEM3_PR1_MODEL;

namespace DataAccessLayer
{
    /// <summary>
    /// Паттерн Repository реализует интерфейс IRepository<T>, 
    /// абстрагируя логику доступа к данным от остальной части приложения.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class EntityRepository<T> : IRepository<T> where T : class, IDomainObject
    {
        private readonly PoisonousPlantContext dataContext; // Единица работы.
        private readonly DbSet<T> dbSet; // Репозиторий

        public EntityRepository()
        {
            dataContext = new PoisonousPlantContext();
            dbSet = dataContext.Set<T>();
        }

        /// <summary>
        /// Добавляет новую запись в БД.
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            dbSet.Add(item);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Возвращает список объектов БД
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> GetAll() => dbSet.ToList();

        /// <summary>
        /// Ищет объект по Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetById(int id) => dbSet.Find(id);

        /// <summary>
        /// Обновляет существующую запись, помечая её состояние как Modified
        /// </summary>
        /// <param name="item"></param>
        public void Update(T item)
        {
            dataContext.Entry(item).State = EntityState.Modified;
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Ищет запись по Id и удаляет ее.
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            var item = dbSet.Find(id);
            if (item != null)
            {
                dbSet.Remove(item);
               
            }
            dataContext.SaveChanges();
        }
    }
}
