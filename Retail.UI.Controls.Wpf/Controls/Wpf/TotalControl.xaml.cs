﻿using Retail.UI.Theme;
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
    /// Interaction logic for TotalControl.xaml
    /// </summary>
    partial class TotalControl : BaseControl, ITotalControl
    {
        public TotalControl()
        {
            InitializeComponent();
        }

        public new void SetAppearance(IAppearance appearance)
        {
            base.SetAppearance(appearance);
        }



        public void Show(int numberPosition, decimal total)
        {
            throw new NotImplementedException();
        }


        public decimal GetTotal()
        {
            throw new NotImplementedException();
        }

        public void ShowOddMoney(decimal cashIn)
        {
            throw new NotImplementedException();
        }

        public void SetDocument(Models.Document document)
        {
            throw new NotImplementedException();
        }

        public void ClearDefault()
        {
            throw new NotImplementedException();
        }


        public decimal GetCashIn()
        {
            throw new NotImplementedException();
        }
    }
}
