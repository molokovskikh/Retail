using System.Windows.Forms;

namespace Retail.UI.Actions
{
    /// <summary>
    /// Используется при имплементации действий в формах
    /// </summary>
    public interface IInFormAction
    {
        /// <summary>
        /// Установить родительскую форму
        /// </summary>
        /// <param name="onwer"></param>
        void SetOwnerForm(Form owner);
    }
}
