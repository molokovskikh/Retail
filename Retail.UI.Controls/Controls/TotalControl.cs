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
        }

        public new void SetAppearance(IAppearance appearance)
        {
            base.SetAppearance(appearance);
        }



        public void Calculate(IList<Product> products)
        {
            //TODO Сделать итог по чеку с отображением информации в контроле
        }
    }
}
