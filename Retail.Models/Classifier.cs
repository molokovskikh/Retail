namespace Retail.Models
{
    /// <summary>
    /// Номенклатура товаров
    /// </summary>
    public class Classifier
    {
        /// <summary>
        /// Идентификатор номенклатуры
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Наименование номенклатуры
        /// </summary>
        public string Name { get; set; }
    }
}
