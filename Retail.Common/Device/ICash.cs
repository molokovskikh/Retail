using System;
using System.Collections.Generic;

namespace Retail.Device
{
    /// <summary>
    /// Касса
    /// </summary>
    public interface ICash: IDevice
    {
        /// <summary>
        /// Открыть денежный ящик
        /// </summary>
        void OpenBox();

        /// <summary>
        /// Продажа списка товаров
        /// </summary>
        /// <param name="items">Список товаров</param>
        EventHandler Sell(IEnumerable<ISaleItem> items, decimal cashIn, decimal oddMoney);

        /// <summary>
        /// Снятие X-Отчета
        /// </summary>
        void XReport();

        /// <summary>
        /// Снятие Z-Отчета
        /// </summary>
        void ZReport();
    }
}
