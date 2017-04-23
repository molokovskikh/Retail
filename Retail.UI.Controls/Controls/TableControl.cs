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
using Retail.Device;

namespace Retail.UI.Controls
{
    public partial class TableControl : BaseControl, ITableControl
    {
    
        public TableControl()
        {
            InitializeComponent();

            if (this.DesignMode) return;
       
          
            BindData();

            FocusWholeRow();
            
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
        internal class DataItem : ISaleItem
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

           decimal ISaleItem.Amount
            {
                get
                {
                    return this.Amount;
                }
            }

           string ISaleItem.Name
            {
                get
                {
                    return this.Product.Classifier.Name;
                }                
            }

            decimal ISaleItem.Price
            {
                get
                {
                    return this.Product.Price;
                }                
            }

            int ISaleItem.Id
            {
                get 
                {
                    return this.Product.Id;
                }
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


        private DataItem CurrentData
        {
            get
            {
                if (this.dataGridViewProducts.CurrentRow == null) 
                    return null;

                var row = this.dataGridViewProducts.Rows
                    .OfType<DataGridViewRow>()
                    .Where(gr => gr.Selected)
                    .FirstOrDefault();
                
                
                 return row!=null ? row.DataBoundItem as DataItem : null; 
            }
        }

        /// <summary>
        /// При отрисовке фокус рисовать на всю строку, а не как он по умолчанию только на ячейку
        /// </summary>
        private void FocusWholeRow()
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

        /// <summary>
        /// Выбор позиции в чеке
        /// </summary>      
        private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (!this.IsHandleCreated) return;
            if (this.DesignMode) return;
            if (this.CurrentData == null) return;

            this.detailControl.SetProduct(this.CurrentData.Product, this.CurrentData.Amount, this.CurrentData.Sum);

            this.totalControl.Show(
                this.productsOfCheck.Count,
                Math.Round(this.productsOfCheck.Select<DataItem, decimal>(di => di.Sum).Aggregate(0m, (p, c) => p + c),2)
                );
        }

        /// <summary>
        /// Получить пердыдущую строку по DataItem
        /// </summary>
        /// <param name="dataItem"></param>
        /// <returns></returns>
        private DataGridViewRow GetPrevRowByDataItem(DataItem dataItem)
        {
            DataGridViewRow prevRow = null;
            foreach (DataGridViewRow row in this.dataGridViewProducts.Rows)
            {
                if (row.DataBoundItem.Equals(dataItem))
                    return prevRow;

                prevRow = row;
            }
            return null; ;
        }


        /// <summary>
        /// Перейти к последней строке
        /// </summary>
        private void GoToLastRow()
        {
            if (this.dataGridViewProducts.RowCount == 0)
                return;  
            
            var dataGridViewRow = this.dataGridViewProducts.Rows.OfType<DataGridViewRow>().Last();
            
            if(dataGridViewRow!=null)
                //this.dataGridViewProducts.CurrentCell = dataGridViewRow.Cells[0];
                dataGridViewRow.Selected = true;

        }

        /// <summary>
        /// Перейти к строке
        /// </summary>
        private void GoToRow(DataGridViewRow row)
        {
            if (this.dataGridViewProducts.RowCount == 0)
                return;

            var dataGridViewRow =
            this.dataGridViewProducts.Rows
                .OfType<DataGridViewRow>()
                .Where(r=>r.Equals(row))
                .First();

            if (dataGridViewRow != null)
          //      this.dataGridViewProducts.CurrentCell = dataGridViewRow.Cells[0];
                dataGridViewRow.Selected = true;
        }

        /// <summary>
        /// Перейти к строке
        /// </summary>
        private void GoToRow(DataItem dataItem)
        {
            if (this.dataGridViewProducts.RowCount == 0)
                return;

            var dataGridViewRow = this.dataGridViewProducts.Rows
                .OfType<DataGridViewRow>()
                .Where(r => r.DataBoundItem.Equals(dataItem))
                .First();

            if (dataGridViewRow != null)
                //  this.dataGridViewProducts.CurrentCell = dataGridViewRow.Cells[0];
                dataGridViewRow.Selected = true;
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
                 {
                     var rowToGo = this.GetPrevRowByDataItem(exists);
                     this.productsOfCheck.Remove(exists);
                     if (rowToGo != null) rowToGo.Selected = true;
                     else this.GoToLastRow();
                 }
                 else this.GoToRow(exists);                 
             }
             else
             {
                 this.application.New(true);
                 this.productsOfCheck.Add(new DataItem() { Product = product, Amount = amount });
                 this.GoToLastRow();
             }
             
             this.dataGridViewProducts.Refresh();             
         }

      
         public void DelProduct(Product product)
         {
             product = product ?? (this.CurrentData!=null ? this.CurrentData.Product: null);
             if (product == null)
                 return;

             this.dataGridViewProducts.ClearSelection();

             var toDelete = this.productsOfCheck.Where<DataItem>(di => di.Product.Id == product.Id).First();
             if (toDelete == null) 
                 return;

             var rowToGo = this.GetPrevRowByDataItem(toDelete);             
             this.productsOfCheck.Remove(toDelete);
             
             if (rowToGo != null) 
                 rowToGo.Selected = true;
             else 
                 this.GoToLastRow();

             this.dataGridViewProducts.Refresh();
         }


         public decimal GetAmountOfSelectedProduct()
         {
             return this.CurrentData != null ? this.CurrentData.Amount : 0;
         }

         public void SetAmountOfSelectedProduct(decimal amount)
         {
             if (this.CurrentData != null)
             {
                 this.CurrentData.Amount = amount;
                 this.dataGridViewProducts.Refresh();
                 this.dataGridViewProducts_SelectionChanged(this.dataGridViewProducts, null);
             }
         }

         public IEnumerable<ISaleItem> GetSaleItems()
         {
             return this.productsOfCheck;
         }

         public Product GetSelectedProduct()
         {
             return this.CurrentData != null ? this.CurrentData.Product: null;
         }

         public void ClearDefault()
         {
             this.productsOfCheck.Clear();
         }


        #endregion

    }
}
