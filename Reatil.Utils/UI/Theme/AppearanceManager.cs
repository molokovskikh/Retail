using Retail.UI;
using System.Drawing;

namespace Retail.UI.Theme
{
    /// <summary>
    /// Хелпер для работы с форомлением для контрола
    /// </summary>
    public static class AppearanceManager
    {
        /// <summary>
        /// Найти соответствующее типу контрола оформление в теме
        /// </summary>
        /// <param name="Control">Контрол для которого ищется оформление</param>
        /// <param name="Theme">Тема в которой</param>
        /// <returns></returns>
        public static IAppearance FindAppearance(this IDefaultControl Control, ITheme Theme)
        {
            if(Theme.Sets==null) return null;

            //Проходим весь набор форомлений для компонентов
            //Если находим подходящий для текущего элемента, то применяем его
            foreach (ControlType controlType in Theme.Sets.Keys)
            {
                IAppearance appearance = Theme.Sets[controlType];

                if (controlType == ControlType.Caption && Control is ICaptionControl)
                    return appearance;
              

                if (controlType == ControlType.Buttons && Control is IButtonsControl)
                    return appearance;

                if (controlType == ControlType.Table && Control is ITableControl)
                    return appearance;

                if (controlType == ControlType.Detail && Control is IDetailControl)
                    return appearance;

                if (controlType == ControlType.Total && Control is ITotalControl)
                    return appearance;

                if (controlType == ControlType.Input && Control is IInputControl)
                    return appearance;

                if (controlType == ControlType.Status && Control is IStatusControl)
                    return appearance;

                if (controlType == ControlType.Default)
                    return appearance;               
            }

            return null;
        }

        /// <summary>
        /// Получить цвет
        /// </summary>
        /// <param name="appearence">Оформление для компонента</param>
        /// <param name="value">Строковое представление цвета</param>
        /// <returns></returns>
        public static Color GetColor(this IAppearance appearence, string value)
        {
            //TODO Добавить парсинг параметра value в цвет
            return Color.Transparent;
        }

        /// <summary>
        /// Получить шрифт
        /// </summary>
        /// <param name="appearence">Оформление для компонента</param>
        /// <param name="value">Строковое представление шрифта</param>
        /// <returns></returns>
        public static Font GetFont(this IAppearance appearence, string value)
        {
            //TODO Добавить парсинг параметра value в цвет
            return SystemFonts.DefaultFont;
        }
        
    }
}
