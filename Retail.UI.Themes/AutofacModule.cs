using Autofac;
using Retail.UI.Theme;


namespace Retail.UI.Themes
{
    /// <summary>
    /// Класс регистрации в IoC контейнере
    /// </summary>
    public class AutofacModule : Module
    {
        /// <summary>
        /// Регистрация тем в IoC контейнере
        /// </summary>
        /// <param name="builder"></param>        
        protected override void Load(ContainerBuilder builder)
        {
            //Используем тему по умолчанию
            builder.Register<ITheme>(c => new Default.ThemeDefault());
        }
    }
}
