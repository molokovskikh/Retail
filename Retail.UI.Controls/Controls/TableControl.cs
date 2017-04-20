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

        public DataTable dataTable = new DataTable();

        public TableControl()
        {
            InitializeComponent();

            this.dataTable.Columns.Add("Product");
            this.dataTable.Columns.Add("Amount");
            this.dataTable.Columns.Add("Sum");

            this.dataTable.Rows.Add(new object[] { "Вкусная булочка",2.34,254.23});
            this.dataTable.Rows.Add(new object[] { "Замечательный пирожок", 12.34, 534.323 });

            this.dataGridView1.DataSource = this.dataTable;
        }

         public new void SetAppearance(IAppearance appearance)
        {
            base.SetAppearance(appearance);
        }

         public void AddProduct(Product product, int amount = 1)
         {
            //TODO Выполнить добавление товара в чек
         }

         public void DelProduct(Product product)
         {
             //TODO Выполнитьудаление товара из чека
         }
    }
}
