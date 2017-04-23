using Retail.Models;
using Retail.UI.Theme;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Windows;
using System.Windows.Forms.Integration;

namespace Retail.UI.Controls
{
    [Designer("System.Windows.Forms.Design.ControlDesigner, System.Design")]
    [DesignerSerializer("System.ComponentModel.Design.Serialization.TypeCodeDomSerializer , System.Design", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design")]        
    public class DetailControl : BaseControl, IDetailControl
    {
      
        public new void SetAppearance(IAppearance appearance)
        {
            base.SetAppearance(appearance);
        }       

        public void SetProduct(Product product, decimal amount, decimal sum)
        {
            
        }

        protected override UIElement GetWPFControl()
        {
            return new Wpf.DetailControl();
        }

        public void ClearDefault()
        {
            throw new System.NotImplementedException();
        }
    }
}
