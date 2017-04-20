using System;

namespace Retail.UI.Theme
{
    /// <summary>
    /// Утилитарный класс.
    /// Координатор динамической смены темы оформления
    /// </summary>
    public static class ThemeChangeCoordinator
    {
        /// <summary>
        /// Подписчик на событие измененния Темы оформления
        /// </summary>
        static event Action<ITheme> ObserverThemeChanging;

        /// <summary>
        /// Регистрация обработчика события "Смена темы оформления"
        /// </summary>
        /// <param name="handler">Обработчик срабатывающий при смене темы оформления</param>
        public static void RegisterOnChangeTheme(Action<ITheme> handler)
        {
            ThemeChangeCoordinator.ObserverThemeChanging += handler;
        }

        /// <summary>
        /// Изменить тему оформления
        /// </summary>
        /// <param name="theme">Новая тема оформления</param>
        public static void ChangeTheme(ITheme theme){
            ObserverThemeChanging(theme);
        }

    }
}
