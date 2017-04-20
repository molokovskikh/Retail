using System.Collections.Generic;

namespace Retail.UI.Theme
{
    /// <summary>
    /// Тема оформления
    /// </summary>
    public interface ITheme
    {        
        /// <summary>
        /// Набор внешнего вида для компонентов интерфейса
        /// </summary>
        IDictionary<ControlType, IAppearance> Sets{ get; set; }
    }
}
