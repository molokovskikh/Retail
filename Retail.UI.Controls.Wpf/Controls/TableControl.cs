using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Windows.Forms.Integration;

namespace Retail.UI.Controls
{
    [Designer("System.Windows.Forms.Design.ControlDesigner, System.Design")]
    [DesignerSerializer("System.ComponentModel.Design.Serialization.TypeCodeDomSerializer , System.Design", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design")]        
    public class TableControl : ElementHost, ITableControl
    {
        public TableControl()
        {          
            base.Child = new Wpf.TableControl();
        }

        public void SetAppearance(Theme.IAppearance appearance)
        {
            throw new System.NotImplementedException();
        }

        public void AddProduct(Models.Product product, int amount = 1)
        {
            throw new System.NotImplementedException();
        }

        public void DelProduct(Models.Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}
