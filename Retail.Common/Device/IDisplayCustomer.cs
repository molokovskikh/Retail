using System.Collections.Generic;
namespace Retail.Device
{
    /// <summary>
    /// Дисплей покупателя
    /// </summary>
    public interface IDisplayCustomer : IDevice
    {
        /// <summary>
        /// Показать на дисплее покупателя информацию о чеке
        /// </summary>
        /// <param name="items"></param>
        void Show(IList<ISaleItem> items);
    }
}
