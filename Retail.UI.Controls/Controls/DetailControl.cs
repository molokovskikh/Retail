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

namespace Retail.UI.Controls
{
    public partial class DetailControl : BaseControl, IDetailControl
    {
        public DetailControl()
        {
            InitializeComponent();
        }

        public new void SetAppearance(IAppearance appearance)
        {
            base.SetAppearance(appearance);
        }

        public void SetProduct(Models.Product product)
        {
           //TODO Обработать установку текущего товара
        }
    }
}
