namespace Retail.Models
{
    /// <summary>
    /// Штрих-код товара
    /// </summary>
    public class BarCode
    {
        /// <summary>
        /// Ссылка на номнеклатуру товара
        /// </summary>
        public Classifier Classifier { get; set; }

        /// <summary>
        /// Значение штрих-кода
        /// </summary>
        public string Code { get; set; }
    }
}
