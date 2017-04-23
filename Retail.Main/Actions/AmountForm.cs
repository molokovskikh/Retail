using Retail.Models;
using Retail.Repository;
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
    public partial class AmountForm : Form, IAddAmountAction
    {
      
        public AmountForm()
        {
            InitializeComponent();
                        
            //Если остаток на складе позволяет отпустить такое количество товара то сделаем это
            this.FormClosing += (s, e) =>
                {
                    decimal AmountOnStore;
                    this.textBoxAmount.ForeColor = SystemColors.WindowText;
                    e.Cancel = this.DialogResult == DialogResult.OK &&
                        (this.Amount <= 0 ||
                            (this.Amount > (AmountOnStore=this.OnStore) && 
                                (
                                    showHint(string.Format("На складе всего {0}, нельзя продать больше чем есть!", AmountOnStore)) && 
                                    (textBoxAmount.ForeColor = Color.DarkRed) == Color.DarkRed
                                )
                            )
                        );
                };
        }


        /// <summary>
        /// Показать подсказку с ошибкой
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        private bool showHint(string msg)
        {
            if (msg == null)
                this.toolTip1.Hide(this.textBoxAmount);
            else
                this.toolTip1.Show(msg, this.textBoxAmount);
            return true;
        }


        #region Autowiring       
        public ITableControl tableControl { get; set; }
        public IStoreRepository storeRepository { get; set; }
        #endregion

        #region Реализация интерфейсов взаимодействия
       
      
        public void Execute()
        {
            if (this.tableControl.GetSelectedProduct() == null)
                return;

            decimal prevAmount = this.tableControl.GetAmountOfSelectedProduct();
            this.textBoxAmount.Text = prevAmount.ToString().Replace(" ", string.Empty);

            if (this.ShowDialog(owner) == DialogResult.OK)
                this.tableControl.SetAmountOfSelectedProduct(this.Amount);
            else
                this.tableControl.DelProduct(null);
        }

        #endregion
       
              


        /// <summary>
        /// Количество для продажи
        /// </summary>
        private decimal Amount
        {
            get
            {
                decimal ci;
                string txt = this.textBoxAmount.Text,
                       separator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;                
                txt = txt.Replace(".", separator);
                txt = txt.Replace(",", separator);
                return string.IsNullOrEmpty(txt) ||
                       !decimal.TryParse(txt, out ci)
                    ? 0m 
                    : ci;
            }
        }


        /// <summary>
        /// Остаток на складе
        /// </summary>
        private decimal OnStore
        {
            get
            {
                return this.storeRepository.GetAmountOnStore(this.tableControl.GetSelectedProduct());
            }
        }

        IWin32Window owner;

        public void SetOwnerForm(Form owner)
        {
            this.owner = owner;
        }

        private void AmountForm_KeyDown(object sender, KeyEventArgs e)
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

        private void textBoxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            string txt = this.textBoxAmount.Text;
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

        /// <summary>
        /// Первый введенный символ это "0"?
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private bool IsFirstNotZero(char key)
        {
            return !string.IsNullOrEmpty(this.textBoxAmount.Text) || key != '0';            
        }

        /// <summary>
        /// Дробная часть числа после запятой не превышает 4 знаков
        /// </summary>
        /// <returns></returns>
        private bool CheckLengthPartRight()
        {
            string txt = this.textBoxAmount.Text;
            if(string.IsNullOrEmpty(txt)) return true;

            int i = txt.IndexOf('.');
            if (i >= 0)
                return txt.Substring(i).Length < 3;

            i = txt.IndexOf(',');
            if (i >= 0)
                return txt.Substring(i).Length < 3;

            return true;
        }



    }
}
