using System.Windows.Forms;
using System;
using System.Windows;

using Retail.UI;
using Retail.UI.Theme;
using System.ComponentModel;

namespace Retail.UI.Controls
{
    /// <summary>
    /// Базовый компонент
    /// </summary>
    public partial class BaseControl : UserControl, IDefaultControl
    {

        #region Autowiring


        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IApplication application { get; set; }

        #endregion

             
        public BaseControl()
        {                   
            InitializeComponent();

            if (this.DesignMode)
                return;

            //Подпишемся на изменение темы
            RegisterOnChangeTheme();
        }

        private void RegisterOnChangeTheme()
        {
            //Если это базовый компонент то выполним регистрацию на событие изменения темы оформления
            if (this is IDefaultControl)
                ThemeChangeCoordinator.RegisterOnChangeTheme(OnThemeChange);
        }       
             
        /// <summary>
        /// Обработка изменения темы
        /// </summary>
        /// <param name="theme"></param>
        void OnThemeChange(ITheme Theme)
        {
            IDefaultControl control = this as IDefaultControl;
            IAppearance appearance = control.FindAppearance(Theme);
            if (appearance != null)
                this.SetAppearance(appearance);
        }
       
        public void SetAppearance(IAppearance appearance)
        {
            //TODO Добавить обработку установки внешнего вида
        }

      
    }
}
