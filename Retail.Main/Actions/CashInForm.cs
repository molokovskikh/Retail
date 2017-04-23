using Retail.UI;
using Retail.UI.Actions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retail.Main
{
    public partial class CashInForm : Form, ICashInAction
    {
        const string EMPTY_ODDMONEY="_";                

        public CashInForm()
        {
            InitializeComponent();
            
            labelOddMoneyValue.Text = EMPTY_ODDMONEY;
            //Если внесеная наличка меньше суммы к оплате то из формы не выходим
            this.FormClosing += (s, e) => e.Cancel = this.DialogResult == DialogResult.OK && this.cashIn < this.total;           
        }


        #region Autowiring       
        /// <summary>
        /// Доступ к контролу итога чека
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ITotalControl totalControl { get; set; }

        /// <summary>
        /// Доступ действию печати чека
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ICheckoutAction checkoutAction { get; set; }

        #endregion

        #region Реализация интерфейсов взаимодействия
        bool status;

        public void Execute()
        {
            this.total = this.totalControl.GetTotal();
            this.labelToPayValue.Text = string.Format("{0:n2}", this.total);
            this.status = false;
            if (this.ShowDialog(owner) == DialogResult.OK)
            {
                this.status = true;                
                totalControl.ShowOddMoney(cashIn);                
            }
        }

        public bool Status()
        {
            return this.status;
        }

        #endregion


        decimal total;
        IWin32Window owner;
        

        decimal cashIn
        {
            get
            {
                decimal ci;
                string txt = this.textBoxCashIn.Text,
                       separator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;                
                txt = txt.Replace(".", separator);
                txt = txt.Replace(",", separator);
                return string.IsNullOrEmpty(txt) ||
                       !decimal.TryParse(txt, out ci)
                    ? 0m 
                    : ci;
            }
        }
    

        public void SetOwnerForm(Form owner)
        {
            this.owner = owner;
        }

        private void CashInForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.DialogResult = DialogResult.None;
                this.Close();
            }

            if (e.KeyData == Keys.Enter)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void textBoxCashIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            string txt = this.textBoxCashIn.Text;
            e.Handled = !(
                e.KeyChar == 8 ||
                (CheckLengthPartRight() && IsFirstNotZero(e.KeyChar) && char.IsDigit(e.KeyChar)) ||
                (
                !string.IsNullOrEmpty(txt) && 
                !txt.Contains('.') && 
                !txt.Contains(',') && 
                (e.KeyChar == '.' || e.KeyChar == ','))
                );
        }

        private bool IsFirstNotZero(char key)
        {
            return !string.IsNullOrEmpty(this.textBoxCashIn.Text) || key != '0';            
        }

        private bool CheckLengthPartRight()
        {
            string txt = this.textBoxCashIn.Text;
            if(string.IsNullOrEmpty(txt)) return true;

            int i = txt.IndexOf('.');
            if (i >= 0)
                return txt.Substring(i).Length < 3;

            i = txt.IndexOf(',');
            if (i >= 0)
                return txt.Substring(i).Length < 3;

            return true;
        }

        private void textBoxCashIn_TextChanged(object sender, EventArgs e)
        {
            labelOddMoneyValue.Text = cashIn >= total ?  string.Format("{0:n2}", cashIn - total) : EMPTY_ODDMONEY;            
        }



     
    }
}
