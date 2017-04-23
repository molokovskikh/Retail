using Retail.Models;
using System.Collections.Generic;

namespace Retail.Repository
{
    public interface IProductRepository : IRepository<Product>
    {
        /// <summary>
        /// Поиск товара(ов) по тексту/штрихкоду
        /// </summary>
        /// <param name="text">Текст с частью наименования или штрих-кодом товара</param>
        IList<Product> SearchByText(string text);
    }
}
