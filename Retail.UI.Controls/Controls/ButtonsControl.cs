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
using System.Diagnostics;

namespace Retail.UI.Controls
{
    public partial class ButtonsControl : BaseControl, IButtonsControl, IShortcutKeyManager
    {

        #region Autowiring
               
        #endregion

        public ButtonsControl()
        {
            InitializeComponent();
        }

        public new void SetAppearance(IAppearance appearance)
        {
            base.SetAppearance(appearance);
        }

        private void butHelp_Click(object sender, EventArgs e)
        {
            application.Help();
        }

        private void butNew_Click(object sender, EventArgs e)
        {
            application.New();
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            application.Search();
        }

        private void butCheckout_Click(object sender, EventArgs e)
        {
            application.CheckOut();
        }

        private void butCopy_Click(object sender, EventArgs e)
        {
            application.Print();
        }

        private void butOpenBox_Click(object sender, EventArgs e)
        {
            application.OpenBox();
        }

        private void butXReport_Click(object sender, EventArgs e)
        {
            application.XReport();
        }

        private void butZReport_Click(object sender, EventArgs e)
        {
            application.ZReport();
        }


        string ReplaceForParse(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            
            switch (s.ToLower())
            {
                case "ctrl":
                    s = "Control";
                    break;
                case "alt":
                    s = "Alt";
                    break;
            }         
            return s;
        }

        /// <summary>
        /// Проверка что клавиша относится модификаторам / к группе CTRL ALT SHIFT
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private bool IsModifierKey(Keys key)
        {
            return key == Keys.Control ||
                   key == Keys.Alt ||
                   key == Keys.Shift;
        }

        /// <summary>
        /// Обработка нажатия клавиш
        /// </summary>
        /// <param name="keyCode"></param>
        /// <param name="modifiers"></param>
        public new void Handle(Keys keyCode, Keys modifiers)
        {
            if (keyCode == Keys.ControlKey)
                return;

            foreach(Control mayBeButton in this.Controls)
            {
                if (mayBeButton is Button)
                {
                    Button but = mayBeButton as Button;
                    string presentKey = but.Tag as string;
                    
                    if (presentKey != null)
                    {
                        //Могут быть комбинации Ctrl+F12 и подобные, разберем их в массим и проверим каждый key в переданном keyData
                        string [] combineKeys = presentKey.Split(new char[] { '+' }, StringSplitOptions.RemoveEmptyEntries);

                        if (combineKeys.Length == 0)
                            continue;

                        int cntMatch = 0;
                        foreach (string strKey in combineKeys)
                        {
                            Keys keyForButton;
                            if (Enum.TryParse<Keys>(ReplaceForParse(strKey), out keyForButton))
                            {                           
                                if(
                                    !IsModifierKey(keyForButton) && !modifiers.HasFlag(keyForButton) &&
                                     keyCode != keyForButton
                                   )                                                                    
                                    //Если комбинация не найдена, то вся цепочка не сопала
                                    break;
                                
                                cntMatch++;
                            }
                        }

                        if (cntMatch != combineKeys.Length)
                            continue;

                        //Если все нажатое совпало с установленым на кнопке
                        //То нажмем кнопку                                                
                        but.PerformClick();
                        return; //Остальные кнопки не будем обрабатывать, так как нашли соответствующую и нажали
                    }
                }
            }           
        }

        

      
    }
}
