using System.Collections.Generic;

namespace Retail.Repository
{
    /// <summary>
    /// Сущность &lt;&gt; БД (шаблон)
    /// </summary>
    /// <typeparam name="T">Модель сущности</typeparam>
    public interface IRepository<T> : IEnumerable<T>
    {

        /// <summary>
        /// Поиск сущности по ключу
        /// </summary>
        /// <param name="id">Ключ для поиска</param>
        /// <returns></returns>
        T Find(int id);

        /// <summary>
        /// Добавить сущность
        /// </summary>
        /// <param name="entity"></param>
        T Add(T entity);

        /// <summary>
        /// Изменить сущность
        /// </summary>
        /// <param name="entity"></param>
        void Edit(T entity);

        /// <summary>
        /// Удалить сущность
        /// </summary>
        /// <param name="entity"></param>
        void Remove(T entity);

    }
}
