using Retail.Models;

namespace Retail.Repository
{
    public interface IStoreRepository : IRepository<Store>
    {
        /// <summary>
        /// Вернуть остаток товара на складе
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        decimal GetAmountOnStore(Product product);
    }
}
