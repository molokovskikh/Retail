using Retail.MicroORM.DataAnnotations;
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
        [DisplayColumn("id")]
        public int Id { get; set; }

        /// <summary>
        /// Тип документа (Продажа)
        /// </summary>
        [DisplayColumn("typedoc")]
        public string Type { get; set; }

        /// <summary>
        /// Статус документа (Открыт, Исполнен, Анулирован, Возврат)
        /// </summary>
        [DisplayColumn("statusdoc")]
        public string Status { get; set; }
    }
}
