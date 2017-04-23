using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Retail.UI.Theme;
using Retail.Models;

namespace Retail.UI.Controls
{
    public partial class TotalControl : BaseControl, ITotalControl
    {

       

        public TotalControl()
        {
            InitializeComponent();
            if (!DesignMode)
                ClearData();
        }

        private void ClearData()
        {            
            this.labelSumValue.Text = "0.00";
            this.labelNumberPositionValue.Text = "0";
            this.labelDocValue.Text = string.Empty;
            this.labelDocNumValue.Text = string.Empty;
            this.labelCashInValue.Text = string.Empty;
            this.labelOddMoneyValue.Text = string.Empty;
        }

        decimal holdTotal;
        decimal holdCashIn;

        /// <summary>
        /// Сдача с внесенных наличных
        /// </summary>
        private decimal OddMoney
        {
            get
            {
                return this.holdCashIn - this.holdTotal;
            }
        }
        

        #region Реализация интерфейсов взаимодействия

        public new void SetAppearance(IAppearance appearance)
        {
            base.SetAppearance(appearance);
        }


        public decimal GetTotal()
        {
            return this.holdTotal;
        }

        public decimal GetCashIn()
        {
            return this.holdCashIn;
        }


        public void Show(int numberPosition, decimal total)
        {
            this.holdTotal = total;
            this.labelSumValue.Text = string.Format("{0:n2}", total);
            this.labelNumberPositionValue.Text = string.Format("{0}", numberPosition);
            
            if(this.holdCashIn > 0)
                this.labelOddMoneyValue.Text = string.Format("{0:n2}", this.OddMoney);
        }
 

        public void ShowOddMoney(decimal cashIn)
        {
            this.holdCashIn = cashIn;
            this.labelCashInValue.Text = string.Format("{0:n2}", cashIn);
            this.labelOddMoneyValue.Text = string.Format("{0:n2}", this.OddMoney);
        }

        public void SetDocument(Document document)
        {
            this.labelDocValue.Text = document.Type;
            this.labelDocNumValue.Text = string.Format("{0:d10}", document.Id);
        }

        public void ClearDefault()
        {
            this.ClearData();
        }

        #endregion

    }
}
