using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Windows;
using System.Windows.Forms.Integration;
using Retail.UI.Theme;

namespace Retail.UI.Controls
{
    [Designer("System.Windows.Forms.Design.ControlDesigner, System.Design")]
    [DesignerSerializer("System.ComponentModel.Design.Serialization.TypeCodeDomSerializer , System.Design", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design")]        
    public abstract class BaseControl : ElementHost, IDefaultControl
    {
        private IDefaultControl WPFControl;
        
        public BaseControl()
        {          
            base.Child = this.getWPFControl();
            this.WPFControl = base.Child as IDefaultControl;
        }

        protected abstract UIElement getWPFControl();
        
        public void SetAppearance(IAppearance appearance)
        {
            this.WPFControl.SetAppearance(appearance);
        }


        public void OnInitDevices()
        {
        }
    }
}
