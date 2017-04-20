using System.ComponentModel;
using System.Windows.Controls;
using Retail.UI.Theme;

namespace Retail.UI.Controls.Wpf
{
    public class BaseControl : UserControl, IDefaultControl
    {
        public BaseControl()
        {
            if (DesignerProperties.GetIsInDesignMode(this))
                return;

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
