namespace Retail.UI
{
    /// <summary>
    /// Поле ввода информации
    /// </summary>
    public interface IInputControl : IDefaultControl
    {
        /// <summary>
        /// Добавить символ перенаправленный с главной формы
        /// </summary>
        /// <param name="ch"></param>
        void AddChar(char ch);

        /// <summary>
        /// Очистить контрол к состоянию по умолчанию
        /// </summary>
        void ClearDefault();
    }
}
