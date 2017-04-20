using Retail.Models;
namespace Retail.UI
{
    /// <summary>
    /// Таблица чека / позиций для продажи
    /// </summary>
    public interface ITableControl : IDefaultControl
    {
        
        /// <summary>
        /// Добавить товар в чек
        /// </summary>
        /// <param name="product">Товар для добавления</param>
        /// <param name="amount">Количество добавляемого товара (Может быть и отрицательное значение, ноль не обрабатывается)</param>
        void AddProduct(Product product, int amount=1);

        /// <summary>
        /// Удалить из чека товар
        /// </summary>
        /// <param name="product">Товар для удаления</param>
        void DelProduct(Product product);
    }
}
