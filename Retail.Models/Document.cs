namespace Retail.Models
{
    /// <summary>
    /// Документ
    /// </summary>
    public class Document
    {
        /// <summary>
        /// Номер документа
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Тип документа (Продажа)
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Статус документа (Открыт, Исполнен, Анулирован, Возврат)
        /// </summary>
        public string Status { get; set; }
    }
}
