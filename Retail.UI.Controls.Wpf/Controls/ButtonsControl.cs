using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Windows.Forms.Integration;

namespace Retail.UI.Controls
{
    [Designer("System.Windows.Forms.Design.ControlDesigner, System.Design")]
    [DesignerSerializer("System.ComponentModel.Design.Serialization.TypeCodeDomSerializer , System.Design", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design")]        
    public class ButtonsControl : BaseControl, IButtonsControl
    {
      //  public ButtonsControl()
      //  {           
     //       base.Child = new Wpf.ButtonsControl();
      //  }

       
        protected override System.Windows.UIElement getWPFControl()
        {
            return new Wpf.ButtonsControl();
        }

        public new void SetAppearance(Theme.IAppearance appearance)
        {

        }
    }
}
