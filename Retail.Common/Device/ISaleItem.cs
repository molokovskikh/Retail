namespace Retail.Device
{
    /// <summary>
    /// Позиция продажи
    /// </summary>
    public interface ISaleItem
    {
        /// <summary>
        /// Наименование
        /// </summary>
        string Name { get; set; }        

        /// <summary>
        /// Цена
        /// </summary>
        decimal Price { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        decimal Amount { get; set; }
    }
}
