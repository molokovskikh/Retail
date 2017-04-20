using Retail.UI.Theme;
namespace Retail.UI
{
    /// <summary>
    /// Компонент интерфейса
    /// </summary>
    public interface IDefaultControl
    {
        /// <summary>
        /// Установить новое оформление
        /// </summary>
        /// <param name="appearance">Внешний вид</param>
        void SetAppearance(IAppearance appearance);      
    }
}
