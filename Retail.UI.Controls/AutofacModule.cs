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
            //TODO Удалить после стабилизации этот код 
            //builder.RegisterType<DetailControl>().AsImplementedInterfaces().SingleInstance().PropertiesAutowired();
            //builder.RegisterType<CaptionControl>().AsImplementedInterfaces().SingleInstance().PropertiesAutowired();
            //builder.RegisterType<TableControl>().AsImplementedInterfaces().SingleInstance().PropertiesAutowired();
            //builder.RegisterType<TotalControl>().AsImplementedInterfaces().SingleInstance().PropertiesAutowired();
            //builder.RegisterType<InputControl>().AsImplementedInterfaces().SingleInstance().PropertiesAutowired();
            //builder.RegisterType<ButtonsControl>().AsImplementedInterfaces().SingleInstance().PropertiesAutowired();
            //builder.RegisterType<StatusControl>().AsImplementedInterfaces().SingleInstance().PropertiesAutowired();
            builder.RegisterAssemblyTypes(typeof(AutofacModule).Assembly)
                  .Where(t =>
                  {
                      return t.GetInterfaces()
                          .FirstOrDefault(i => i.Equals(typeof(IDefaultControl))) != null;
                  })                      
                 .AsImplementedInterfaces()
                 .SingleInstance()
                 .PropertiesAutowired();
        }
    }
}
