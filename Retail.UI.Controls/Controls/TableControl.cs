using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Retail.UI;
using Retail.UI.Theme;
using Retail.Models;

namespace Retail.UI.Controls
{
    public partial class TableControl : BaseControl, ITableControl
    {
    
        public TableControl()
        {
            InitializeComponent();

            if (this.DesignMode) return;
       
          
            BindData();

            focusWholeRow();
            
        }

        /// <summary>
        /// При отрисовке фокус рисовать на всю строку, а не как он по умолчанию только на ячейку
        /// </summary>
        private void focusWholeRow()
        {
            this.dataGridViewProducts.RowPrePaint += (s, e) =>
            {
                e.PaintParts &= ~DataGridViewPaintParts.Focus;
            };

            this.dataGridViewProducts.RowPostPaint += (s, e) =>
            {
                if (e.State.HasFlag(DataGridViewElementStates.Selected))
                    e.DrawFocus(e.RowBounds, true);
            };
        }

        #region Autowiring
        /// <summary>
        /// Доступ к контролу детализации по позиции чека
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IDetailControl detailControl { get; set; }

        /// <summary>
        /// Доступ к контролу итога чека
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ITotalControl totalControl { get; set; }

        #endregion

        /// <summary>
        /// Позиция чека для UI
        /// </summary>
        internal class DataItem
        {
            public Product Product { get; set; }

            public string ProductName { get { return Product.Classifier.Name; } }
       
            public decimal Amount { get; set; }
            public decimal Sum
            {
                get { return this.claculateSum(); }
            }

            private decimal claculateSum()
            {
                return this.Product.Price * this.Amount;
            }
        }

        //Список товаров в чеке
        IList<DataItem> productsOfCheck = new BindingList<DataItem>();       
      

        /// <summary>
        /// Привязка данных к gridView
        /// </summary>
        private void BindData()
        {           
            this.Product.DataPropertyName = "ProductName";
            this.Amount.DataPropertyName = "Amount";
            this.Sum.DataPropertyName = "Sum";
           
            this.dataGridViewProducts.AutoGenerateColumns = false;
            this.dataGridViewProducts.DataSource = this.productsOfCheck;          
        }

      

        /// <summary>
        /// Выбор позиции в чеке
        /// </summary>      
        private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (!this.IsHandleCreated) return;
            if (this.DesignMode) return;
            if (this.dataGridViewProducts.CurrentRow == null) return;

            DataItem currentData = this.dataGridViewProducts.CurrentRow.DataBoundItem as DataItem;
            this.detailControl.SetProduct(currentData.Product, currentData.Amount, currentData.Sum);

            this.totalControl.Show(
                this.productsOfCheck.Count,
                this.productsOfCheck.Select<DataItem, decimal>(di => di.Sum).Aggregate(0m, (p, c) => p + c)
                );
        }


        #region Реализация интерфейсов взаимодействия

         public new void SetAppearance(IAppearance appearance)
         {
            base.SetAppearance(appearance);
         }

         public void AddProduct(Product product, decimal amount = 1)
         {
            //TODO Выполнить добавление товара в чек с учетом параметра amount
             //Реализовать логику по которой бы происходила "свертка" позиции если она уже присутсвует в чеке

             if (amount == 0)
                 return; //Нулевой смысла нет отпускать

             var toCollapse = this.productsOfCheck.Where<DataItem>(di => di.Product.Id == product.Id);
             decimal AmountAll = toCollapse.Select<DataItem,decimal>(di => di.Amount).Aggregate(0m,(p,c)=>p+c);

             if (amount < 0 && AmountAll < -amount)
             {
                 //Нельзя удалить большее количество чем есть в чеке
                 return;
             }

             var exists =  toCollapse.FirstOrDefault();
             if (exists != null)             
             {
                 exists.Amount += amount;
                 if (exists.Amount == 0)
                     this.productsOfCheck.Remove(exists);
             }
             else             
                 this.productsOfCheck.Add(new DataItem() { Product = product, Amount = amount });
         }

         public void DelProduct(Product product)
         {             
             var toDelete = this.productsOfCheck.Where<DataItem>(di => di.Product.Id == product.Id);
             foreach(var removedItem in toDelete)             
                 this.productsOfCheck.Remove(removedItem);             
         }
        #endregion

        
    }
}
