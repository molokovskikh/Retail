using Retail.Models;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Windows.Forms.Integration;

namespace Retail.UI.Controls
{
    [Designer("System.Windows.Forms.Design.ControlDesigner, System.Design")]
    [DesignerSerializer("System.ComponentModel.Design.Serialization.TypeCodeDomSerializer , System.Design", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design")]        
    public class DetailControl : ElementHost, IDetailControl
    {
        public DetailControl()
        {          
            base.Child = new Wpf.DetailControl();
        }

        public void SetAppearance(Theme.IAppearance appearance)
        {
            throw new System.NotImplementedException();
        }

        public void SetProduct(Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}
