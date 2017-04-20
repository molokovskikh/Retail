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
        /// Расчитать итог по чеку
        /// </summary>
        void Calculate(IList<Product> products);
    }
}
