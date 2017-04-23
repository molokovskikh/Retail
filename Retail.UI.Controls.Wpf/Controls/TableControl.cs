using Retail.UI.Theme;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Windows;
using System.Windows.Forms.Integration;

namespace Retail.UI.Controls
{
    [Designer("System.Windows.Forms.Design.ControlDesigner, System.Design")]
    [DesignerSerializer("System.ComponentModel.Design.Serialization.TypeCodeDomSerializer , System.Design", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design")]        
    public class TableControl : BaseControl, ITableControl
    {
        protected override UIElement GetWPFControl()
        {
            return new Wpf.TableControl();
        }

        public new void SetAppearance(IAppearance appearance)
        {
            base.SetAppearance(appearance);
        }

        public void AddProduct(Models.Product product, int amount = 1)
        {
            throw new System.NotImplementedException();
        }

        public void DelProduct(Models.Product product)
        {
            throw new System.NotImplementedException();
        }

        public void AddProduct(Models.Product product, decimal amount = 1)
        {
            throw new System.NotImplementedException();
        }


        public System.Collections.Generic.IEnumerable<Device.ISaleItem> GetSaleItems()
        {
            throw new System.NotImplementedException();
        }


        public decimal GetAmountOfSelectedProduct()
        {
            throw new System.NotImplementedException();
        }

        public void SetAmountOfSelectedProduct(decimal amount)
        {
            throw new System.NotImplementedException();
        }


        public Models.Product GetSelectedProduct()
        {
            throw new System.NotImplementedException();
        }

        public void ClearDefault()
        {
            throw new System.NotImplementedException();
        }
    }
}
