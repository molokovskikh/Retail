using System;
namespace Retail.Device
{
    /// <summary>
    /// Сканер штрих-кодов
    /// </summary>
    public interface IBarScanner : IDevice
    {
        /// <summary>
        /// Регистрация обработчика результата сканирования штрих-кода
        /// </summary>
        /// <param name="handlerScan"></param>
        void On(Action<string> handlerScan);

        /// <summary>
        /// Снятия с регистрации обработчика результата сканирования штрих-кода
        /// </summary>
        /// <param name="handlerScan"></param>
        void Off(Action<string> handlerScan);
    }
}
