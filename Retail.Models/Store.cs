namespace Retail.Models
{
    /// <summary>
    /// Склад (Отражение складских запасов)
    /// </summary>
    public class Store
    {
        /// <summary>
        /// Идентификатор склада
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Ссылка на товар
        /// </summary>
        public Product Product { get; set; }

        /// <summary>
        /// Количество товара на складе
        /// Приход со знаком + (расход со знаком -)
        /// </summary>
        public decimal Amount { get; set; }
    }
}
