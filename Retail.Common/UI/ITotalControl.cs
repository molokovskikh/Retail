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
        /// Отобразить итог по чеку
        /// </summary>        
        void Show(int numberPosition, decimal total);
    }
}
