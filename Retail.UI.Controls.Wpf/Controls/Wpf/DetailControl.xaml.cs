using Retail.Models;
using Retail.UI.Theme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Retail.UI.Controls.Wpf
{
    /// <summary>
    /// Interaction logic for DetailControl.xaml
    /// </summary>
    partial class DetailControl :  BaseControl, IDetailControl
    {
        public DetailControl()
        {
            InitializeComponent();
        }

        public new void SetAppearance(IAppearance appearance)
        {
            base.SetAppearance(appearance);
        }      

        public void SetProduct(Product product, decimal amount, decimal sum)
        {
            //TODO Реализовать установку информации по текущему товару
        }

        public void ClearDefault()
        {
            throw new NotImplementedException();
        }
    }
}
