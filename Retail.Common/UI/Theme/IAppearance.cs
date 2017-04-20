using System;
using System.Drawing;

namespace Retail.UI.Theme
{
    /// <summary>
    /// Внешний вид компонента
    /// </summary>
    public interface IAppearance
    {
        /// <summary>
        /// Видимость компонента
        /// </summary>
        bool Visibled { get; }

        /// <summary>
        /// Доступность компонента
        /// </summary>
        bool Disabled { get; }

        /// <summary>
        /// Цвет фона компонента
        /// </summary>
        string BackgroundColor { get; }

        /// <summary>
        /// Цвет шрифта компонента
        /// </summary>
        string FontColor { get; }

        /// <summary>
        /// Цвет 
        /// </summary>
        string BorderColor { get; }

        /// <summary>
        /// Шрифт компонента
        /// </summary>
        string Font { get; }

        /// <summary>
        /// Толщина рамки компонента
        /// </summary>
        int? BorderWidth { get; }

        /// <summary>
        /// Радиус рамки компонента
        /// </summary>
        int? BorderRedius { get; }

    }
}
