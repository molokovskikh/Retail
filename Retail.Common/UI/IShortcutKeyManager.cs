using System.Windows.Forms;

namespace Retail.UI
{
    /// <summary>
    /// Менеджер горячих клавиш
    /// </summary>
    public interface IShortcutKeyManager
    {
        /// <summary>
        /// Обработать нажатие горячей клавиши
        /// </summary>
        /// <param name="keyData"></param>
        void Handle(Keys keyData, Keys modifiers);        
    }
}
