using Retail.Models;
using System.Collections.Generic;
namespace Retail.UI
{
    /// <summary>
    /// Итог по чеку
    /// </summary>
    public interface ITotalControl : IDefaultControl
    {
        /// <summary>
        /// Очистить контрол к состоянию по умолчанию
        /// </summary>
        void ClearDefault();

        /// <summary>
        /// Установка документа продажи
        /// </summary>
        void SetDocument(Document document);

        /// <summary>
        /// Отобразить итог по чеку
        /// </summary>        
        void Show(int numberPosition, decimal total);
        
        /// <summary>
        /// Получить рассчитанный итог по чеку
        /// </summary>
        /// <returns></returns>
        decimal GetTotal();

        /// <summary>
        /// Получить сумму внесенной наличности
        /// </summary>
        /// <returns></returns>
        decimal GetCashIn();

        /// <summary>
        /// Показать внесеные наличные и сдачу
        /// </summary>
        /// <param name="cashIn">Внесенные наличные</param>
        void ShowOddMoney(decimal cashIn);       
    }
}
