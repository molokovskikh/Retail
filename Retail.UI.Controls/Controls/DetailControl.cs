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
using log4net.Core;
using log4net;
using System.Threading;
using Retail.Repository;

namespace Retail.UI.Controls
{
    public partial class DetailControl : BaseControl, IDetailControl
    {     
        public DetailControl()
        {
            InitializeComponent();
            if (!DesignMode)
                ClearData();
        }

        private void ClearData()
        {
            this.labelSumValue.Text = "0.00";
            this.labelCodeValue.Text = string.Empty;
            this.labelPriceValue.Text = string.Empty;
            this.labelAmountValue.Text = string.Empty;            
            this.labelFullName.Text = string.Empty;
        }
     
        #region Autowiring        
        public IStoreRepository  storeRepository  { get; set; }
        #endregion


        #region Реализация интерфейсов взаимодействия

        public new void SetAppearance(IAppearance appearance)
        {
            base.SetAppearance(appearance);
        }

        public void SetProduct(Product product, decimal amount, decimal sum)
        {        
            this.labelCodeValue.Text = string.Format("{0:d5}", product.Classifier.Id);
            this.labelFullName.Text = product.Classifier.Name;
            this.labelPriceValue.Text = string.Format("{0:n2}", product.Price);
            this.labelAmountValue.Text = string.Format("{0:n2}", amount);
            this.labelSumValue.Text = string.Format("{0:n2}", sum);
            
            decimal onStore =storeRepository.GetAmountOnStore(product);
            this.toolTip1.SetToolTip(this.labelAmountValue,string.Format("Остаток товара на складе: {0:n2}",onStore));
        }

        public void ClearDefault()
        {
            this.ClearData();
        }
        #endregion


        
    }
}
