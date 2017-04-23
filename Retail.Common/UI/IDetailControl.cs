using Retail.Models;
namespace Retail.UI
{
    /// <summary>
    ///  Детализация позиции продажи
    /// </summary>
    public interface IDetailControl : IDefaultControl
    {
        /// <summary>
        /// Очистить контрол к состоянию по умолчанию
        /// </summary>
        void ClearDefault();

        /// <summary>
        /// Передать контролу информацию о текущей позиции в чеке
        /// </summary>        
        void SetProduct(Product product,decimal amount, decimal sum);        
    }
}
