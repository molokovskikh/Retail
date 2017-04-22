using System.Collections.Generic;
using Retail.UI.Theme;

namespace Retail.UI.Themes.Default
{
    /// <summary>
    /// Тема по умолчанию
    /// </summary>
    public class ThemeDefault: ITheme
    {
        /// <summary>
        /// Набор настроек отображения контролов интерфейса
        /// </summary>
        public IDictionary<ControlType, IAppearance> Sets
        {
            //TODO Реализовать набор стилей для компонентов
            get;
            set;
        }
    }
}
