using Retail.Models;
using Retail.UI.Actions;

namespace Retail.UI.Actions
{
    /// <summary>
    /// Новый документ продажи
    /// </summary>
    public interface INewDocumentAction: IAction
    {
        /// <summary>
        /// Вернуть текущий документ продажи        
        /// </summary>        
        Document GetDocument();       
    }
}
