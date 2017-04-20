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

namespace Retail.UI.Controls
{
    public partial class InputControl : BaseControl, IInputControl, IInitDevices
    {
        public IProductRepository productRepository { get; set; }
        public IDocumentRepository documentRepository { get; set; }
        public IBarScanner barScanner { get; set; }

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
    }
}
