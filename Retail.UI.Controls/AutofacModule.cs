using System.Linq;
using Autofac;


namespace Retail.UI.Controls
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
            builder.RegisterAssemblyTypes(typeof(AutofacModule).Assembly)
                   .Where(t =>
                        {
                            return t.GetInterfaces()
                                .FirstOrDefault(i => i.Equals(typeof(IDefaultControl))) != null;
                        })
                        .InstancePerDependency()
                        .PropertiesAutowired();
        }
    }
}
