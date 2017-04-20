using System.Data;
using Autofac;


namespace Retail.UI.Controls.Wpf
{
    /// <summary>
    /// Класс регистрации в IoC контейнере
    /// </summary>
    public class AutofacModule : Module
    {
        /// <summary>
        /// Регистрация контролов в IoC контейнере
        /// </summary>
        /// <param name="builder"></param>        
        protected override void Load(ContainerBuilder builder)
        {
        }
    }
}