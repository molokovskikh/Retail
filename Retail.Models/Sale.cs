using Retail.MicroORM.DataAnnotations;
namespace Retail.Models
{
    /// <summary>
    /// Продажи товаров
    /// </summary>
    [TableName("saleofprofuct")]
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
    }
}
