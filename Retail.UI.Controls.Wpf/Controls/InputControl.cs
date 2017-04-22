using Retail.UI.Theme;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Windows;
using System.Windows.Forms.Integration;

namespace Retail.UI.Controls
{
    [Designer("System.Windows.Forms.Design.ControlDesigner, System.Design")]
    [DesignerSerializer("System.ComponentModel.Design.Serialization.TypeCodeDomSerializer , System.Design", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design")]        
    public class InputControl : BaseControl, IInputControl
    {
        public new void SetAppearance(IAppearance appearance)
        {
            throw new System.NotImplementedException();
        }

        protected override UIElement getWPFControl()
        {
            return new Wpf.InputControl();
        }
    }
}
