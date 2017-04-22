namespace Retail.UI
{
    public interface IApplication
    {       
        /// <summary>
        /// Показать справку
        /// </summary>
        void Help();

        /// <summary>
        /// Открыть новый чек
        /// </summary>
        void New();

        /// <summary>
        /// Закрыть чек
        /// </summary>
        void CheckOut();

        /// <summary>
        /// Печатать копию чека
        /// </summary>
        void Print();

        /// <summary>
        /// Поиск товара по наименованию
        /// Открывает окно поиска товара
        /// </summary>
        void Search();

        /// <summary>
        /// Закрыть приложение
        /// </summary>
        /// <param name="AnswerEnsure">Спрашивать об фверенности действия</param>
        void Close(bool AnswerEnsure = false);

        void OpenBox();

        void XReport();

        void ZReport();
        
    }
}
