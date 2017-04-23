namespace Retail.Device
{
    /// <summary>
    /// Позиция продажи
    /// </summary>
    public interface ISaleItem
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        int Id { get; } 

        /// <summary>
        /// Наименование
        /// </summary>
        string Name { get; }        

        /// <summary>
        /// Цена
        /// </summary>
        decimal Price { get; }

        /// <summary>
        /// Количество
        /// </summary>
        decimal Amount { get; }
    }
}
