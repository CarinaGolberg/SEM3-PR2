using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEM3_PR1_MODEL
{
    public class PoisonousPlant : IDomainObject
    {
        public int Id { get; set; }              // Уникальный идентификатор
        public string Name { get; set; }         // Название растения
        public string LatinName { get; set; }    // Латинское название
        public string NativeRegion { get; set; } // Семейство
        public string Toxin { get; set; }        // Токсичные части
        public string DangerLevel { get; set; }  // Класс опасности (низкий/средний/высокий)
        public string Symptoms { get; set; }     // Симптомы

        /// <summary>
        /// Возвращает строку.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Id}. {Name} (лат.'{LatinName}'), семейство '{NativeRegion}', уровень токсичности: {DangerLevel}";
        }
    }
}
