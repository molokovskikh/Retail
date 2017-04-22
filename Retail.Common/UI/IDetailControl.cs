using Retail.Models;
namespace Retail.UI
{
    /// <summary>
    ///  Детализация позиции продажи
    /// </summary>
    public interface IDetailControl : IDefaultControl
    {
        /// <summary>
        /// Передать контролу информацию о текущей позиции в чеке
        /// </summary>        
        void SetProduct(Product product,decimal amount, decimal sum);        
    }
}
