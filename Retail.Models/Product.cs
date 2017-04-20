namespace Retail.Models
{
    /// <summary>
    /// Товары
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Идентификатор товара
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Ссылка на номенклатуру
        /// </summary>
        public Classifier Classifier { get; set; }

        /// <summary>
        /// Цена товара
        /// </summary>
        public decimal Price { get; set; }
    }
}
