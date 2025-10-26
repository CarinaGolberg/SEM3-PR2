using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEM3_PR1_MODEL;

namespace DataAccessLayer
{
    /// <summary>
    /// определяет базовые операций CRUD (Create, Read, Update, Delete) - операции с любыми сущностями в системе.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T : class
    {
        void Add(T obj);
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Update(T obj);
        void Delete(int id);
    }
}
