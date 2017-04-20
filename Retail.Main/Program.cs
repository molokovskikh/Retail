using Autofac;
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
            log4net.Config.XmlConfigurator.Configure();
            var container = IoC.Container.Init(typeof(CashForm));                                  
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CashForm cashForm = container.Resolve<CashForm>();            
            Application.Run(cashForm);
        }
    }
}
