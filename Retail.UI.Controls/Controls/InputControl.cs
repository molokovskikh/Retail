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
using Retail.Repository;
using Retail.Device;
using Retail.Models;
using Retail.UI.Actions;

namespace Retail.UI.Controls
{
    public partial class InputControl : BaseControl, IInputControl, IInitDevices
    {
        #region Autowiring
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IProductRepository productRepository { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IDocumentRepository documentRepository { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IBarScanner barScanner { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IAddAmountAction addAmountAction { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ITableControl tableControl { get; set; }


        #endregion
        

        public InputControl()
        {
            InitializeComponent();
        }

        public new void SetAppearance(IAppearance appearance)
        {
            base.SetAppearance(appearance);
        }

        /// <summary>
        /// Регистрация обработчика сканера штрих-кода
        /// </summary>
        public void AfterInitDevices()
        {
            barScanner.On(OnScanBarcode);
        }

        /// <summary>
        /// Обработка отсканированного штрих-кода
        /// </summary>
        /// <param name="obj"></param>
        private void OnScanBarcode(string obj)
        {
           //TODO Реализовать поиск в базе товара по штрих-коду
        }


      

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBoxSearch.Text))
                return;

            if (this.textBoxSearch.Text.Length < 3)
                return;

            this.contextMenuSearch.Items.Clear();

            IList<Product> resultSearch = this.productRepository.SearchByText(textBoxSearch.Text);
            foreach (Product product in resultSearch.Take<Product>(10))            
                AddProductToMenu(product);
            
            //Покажем результат поиска рядом со строкой поиска
            this.contextMenuSearch.Show(textBoxSearch.PointToScreen(new Point(2, 2+textBoxSearch.Height)));
        }

        private void AddProductToMenu(Product product)
        {
             ToolStripItem item = new ToolStripMenuItem();
             item.Text = product.Classifier.Name;
             item.Tag = product;
             this.contextMenuSearch.Items.Add(item);
        }

        private void contextMenuSearch_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Product product = e.ClickedItem.Tag as Product;
            
            this.application.New(true);

            tableControl.AddProduct(product, 1);

            addAmountAction.Execute();
            this.textBoxSearch.Clear();
        }

        private void contextMenuSearch_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if (!string.IsNullOrEmpty(this.textBoxSearch.Text))
                    this.textBoxSearch.Text = this.textBoxSearch.Text.Substring(0, this.textBoxSearch.Text.Length - 1);
                
                if(string.IsNullOrEmpty(this.textBoxSearch.Text))
                    this.contextMenuSearch.Close();
            }
        }

        #region Реализация интерфейсов взаимодействия


        public void AddChar(char ch)
        {
            if (string.IsNullOrEmpty(this.textBoxSearch.Text)) this.textBoxSearch.Text = string.Empty;
            if (!this.ContainsFocus)
            {
                this.textBoxSearch.Text += new string(new char[] { ch });
                this.textBoxSearch.Focus();
                this.textBoxSearch.SelectionStart = this.textBoxSearch.Text.Length;
            }

        }

        public void ClearDefault()
        {
            this.textBoxSearch.Clear();
        }

        #endregion
    }
}
