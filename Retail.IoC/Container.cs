using Autofac;
using Moq;
using Retail.Device;
using Retail.UI;
using System;
using System.Configuration;
using System.Linq;

namespace Retail.IoC
{
    /// <summary>
    /// Инициализация IoC контейнера
    /// </summary>
    public static class Container
    {

        private static IContainer _Container;

        //Экземпляр для доступа к IoC контейнеру
        public static IContainer Instance
        {
            get
            {
                return _Container;
            }
        }

       

        /// <summary>
        /// Выполнить регистрацию компонентов в контейнере
        /// </summary>
        /// <param name="typeMainForm"></param>
        /// <returns></returns>
        public static IContainer Init(Type typeMainForm)
        {
            ContainerBuilder builder = new ContainerBuilder();
           
            //У главной формы в конструкторе есть внедряемый параметр
            builder.RegisterType(typeMainForm).SingleInstance().PropertiesAutowired();            

            builder.RegisterAssemblyTypes(typeMainForm.Assembly)
           .Where(t =>t.GetInterfaces().FirstOrDefault(i => i.Equals(typeof(IApplication))) != null)
           .SingleInstance()
           .As<IApplication>()
           .PropertiesAutowired();      
            
            //Зачитка строки подключения к БД из файла конфигурации
            builder.Properties.Add("connectionString", ConfigurationManager.ConnectionStrings["mySql"].ConnectionString);
            //Регистрация модуля работы с БД
            builder.RegisterModule<Retail.Repository.AutofacModule>();

            //Оборудование рабочего места кассира
            fakeDevice(builder);

            //Регистрация тем оформления
            builder.RegisterModule<Retail.UI.Themes.AutofacModule>();

            //Регистрация контролов
            builder.RegisterModule<Retail.UI.Controls.AutofacModule>();

            
            //Сборка контейнера
            IContainer container = builder.Build();
            _Container = container;
            return container;
        }

        private static void fakeDevice(ContainerBuilder builder)
        {
            MockFactory moqfactory = new MockFactory(MockBehavior.Loose);

            builder.Register<ICash>(c => moqfactory.Create<ICash>().Object).PropertiesAutowired();
            builder.Register<IBarScanner>(c => moqfactory.Create<IBarScanner>().Object).PropertiesAutowired();
            builder.Register<IDisplayCustomer>(c => moqfactory.Create<IDisplayCustomer>().Object).PropertiesAutowired();
            
        }

       
    }
}
