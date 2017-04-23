using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Windows;
using System.Windows.Forms.Integration;

namespace Retail.UI.Controls
{
    [Designer("System.Windows.Forms.Design.ControlDesigner, System.Design")]
    [DesignerSerializer("System.ComponentModel.Design.Serialization.TypeCodeDomSerializer , System.Design", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design")]        
    public class TotalControl : BaseControl, ITotalControl
    {
        protected override UIElement GetWPFControl()
        {
            return new Wpf.TotalControl();
        }

        public new void SetAppearance(Theme.IAppearance appearance)
        {
            throw new System.NotImplementedException();
        }       

        public void Show(int numberPosition, decimal total)
        {
            (GetWPFControl() as ITotalControl).Show(numberPosition,total);
        }


        public decimal GetTotal()
        {
            throw new System.NotImplementedException();
        }

        public void ShowOddMoney(decimal cashIn)
        {
            throw new System.NotImplementedException();
        }

        public void SetDocument(Models.Document document)
        {
            throw new System.NotImplementedException();
        }

        public void ClearDefault()
        {
            throw new System.NotImplementedException();
        }


        public decimal GetCashIn()
        {
            throw new System.NotImplementedException();
        }
    }
}
