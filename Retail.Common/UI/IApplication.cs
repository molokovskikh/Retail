using Retail.Models;
using System.Windows.Forms;
namespace Retail.UI
{
    /// <summary>
    /// Основной интерфейс взаимодействия прикладной логики с интерфейсом
    /// </summary>
    public interface IApplication
    {
        /// <summary>
        /// Получить основную форму приложения
        /// </summary>
        /// <returns></returns>
        Form GetMainForm();

        /// <summary>
        /// Показать справку
        /// </summary>
        void Help();

        /// <summary>
        /// Открыть новый чек
        /// </summary>
        /// <param name="silent">Не спрашивать об очистке чека</param>
        void New(bool silent=false);

        /// <summary>
        /// Открыть окно поиска товаров
        /// </summary>
        void Search();

        /// <summary>
        /// Внести наличные в кассу
        /// </summary>
        void CashIn();

        /// <summary>
        /// Закрыть чек
        /// </summary>
        void CheckOut();

        /// <summary>
        /// Печатать копию чека
        /// </summary>
        void Print();

        /// <summary>
        /// Закрыть приложение
        /// </summary>
        /// <param name="AnswerEnsure">Спрашивать об фверенности действия</param>
        void Close(bool AnswerEnsure = false);

        void OpenBox();

        void XReport();

        void ZReport();


        /// <summary>
        /// Получить текущего пользователя
        /// </summary>
        /// <returns></returns>
        User GetCurrentUser();

       
    }
}
