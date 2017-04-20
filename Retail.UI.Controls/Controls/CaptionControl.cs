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


namespace Retail.UI.Controls
{
    public partial class CaptionControl : BaseControl, ICaptionControl
    {                  
        public CaptionControl()
        {
            InitializeComponent();           
        }      

        public new void SetAppearance(IAppearance appearance)
        {
            base.SetAppearance(appearance);
        }

        private void butClose_Click(object sender, EventArgs e)
        {
           Application.Close(true);
        }
       
    }
}
