using Autofac;
using Retail.UI.Theme;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retail.Main
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {   
            //Логер для служебных сообщений
            log4net.Config.XmlConfigurator.Configure();

            //Инициализируем IoC контейнер
            var container = IoC.Container.Init(typeof(MainForm));                                  
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Получим основное окно программы
            MainForm cashForm = container.Resolve<MainForm>();

            //Установим тему по умолчанию
            ITheme defaultTheme = container.Resolve<ITheme>();
            ThemeChangeCoordinator.ChangeTheme(defaultTheme);

            Application.Run(cashForm);
        }
    }
}
