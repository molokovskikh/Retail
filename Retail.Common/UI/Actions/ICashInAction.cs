using System.Windows.Forms;
namespace Retail.UI.Actions
{
    /// <summary>
    /// Внесение наличных в кассу
    /// </summary>
    public interface ICashInAction: IAction, IInFormAction
    {      
        /// <summary>
        /// Результат внесения денежных средств
        /// </summary>
        /// <returns>TRUE если внесены, FALSE был отказ внесения</returns>
        bool Status();
    }
}
