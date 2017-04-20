
namespace Retail.Models
{
    /// <summary>
    /// Дефектура по номенклатуре товаров
    /// </summary>
    public class Defectura
    {
        /// <summary>
        /// Ссылка на номенклатуру
        /// </summary>
        public Classifier Classifier { get; set; }

        /// <summary>
        /// Минимальное контрольное количество на складе
        /// </summary>
        public decimal Value { get; set; }
    }
}
