namespace Retail.Models
{
    /// <summary>
    /// Продажи товаров
    /// </summary>
    public class Sale
    {
        /// <summary>
        /// Документ продажи
        /// </summary>
        public Document Document { get; set; }

        /// <summary>
        /// Товар который продали
        /// </summary>
        public Product Product { get; set; }

        /// <summary>
        /// Количество проданного товара
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Оператор продавший товар
        /// </summary>
        public User User { get; set; }
    }
}
