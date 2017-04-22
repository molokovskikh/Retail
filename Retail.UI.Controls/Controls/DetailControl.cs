using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Retail.UI.Theme;
using Retail.Models;
using log4net.Core;
using log4net;
using System.Threading;

namespace Retail.UI.Controls
{
    public partial class DetailControl : BaseControl, IDetailControl
    {

        ILog log = LogManager.GetLogger(typeof(DetailControl));

        public DetailControl()
        {
            InitializeComponent();        
            this.HandleCreated += DetailControl_HandleCreated;
            this.GotFocus += DetailControl_GotFocus;
            this.Invalidated += DetailControl_Invalidated;
            this.Paint += DetailControl_Paint;
            this.ValidateChildren(ValidationConstraints.Enabled);
            
        }

        void DetailControl_Paint(object sender, PaintEventArgs e)
        {
            log.InfoFormat("Paint. IsHandleCreated = {0}, InvokeRequired {1},  Thread Id = {2}", this.IsHandleCreated, this.InvokeRequired, Thread.CurrentThread.ManagedThreadId);
        }

        void DetailControl_Invalidated(object sender, InvalidateEventArgs e)
        {
            log.InfoFormat("Обновил контрол. IsHandleCreated = {0} , Thread Id = {1}", this.IsHandleCreated, Thread.CurrentThread.ManagedThreadId);
        }

        void DetailControl_GotFocus(object sender, EventArgs e)
        {
            log.InfoFormat("Получил фокус. IsHandleCreated = {0} , Thread Id = {1}", this.IsHandleCreated, Thread.CurrentThread.ManagedThreadId);
        }

        void DetailControl_HandleCreated(object sender, EventArgs e)
        {
            log.InfoFormat("Указатель на окно создан. IsHandleCreated = {0}, Thread Id = {1}", this.IsHandleCreated, Thread.CurrentThread.ManagedThreadId);
        }

      
        #region Autowiring

        #endregion


        #region Реализация интерфейсов взаимодействия

        public new void SetAppearance(IAppearance appearance)
        {
            base.SetAppearance(appearance);
        }

     

        public void SetProduct(Product product, decimal amount, decimal sum)
        {

            log.InfoFormat("SetProduct. {0} IsHandleCreated = {1} , Thread Id = {2}", product.Classifier.Name, this.IsHandleCreated, Thread.CurrentThread.ManagedThreadId);
            
            
           // if (!this.IsHandleCreated) return;
          //  this.BeginInvoke((Action)(() =>
          //      {
                    //TODO Обработать установку текущего товара
                    this.labelCodeValue.Text = string.Format("{0:d10}", product.Classifier.Id);
                    this.labelFullName.Text = product.Classifier.Name;
                    this.labelPriceValue.Text = string.Format("{0:n2}", product.Price);
                    this.labelAmountValue.Text = string.Format("{0:n2}", amount);
                    this.labelSumValue.Text = string.Format("{0:n2}", sum);
//                    this.Invalidate(true);
                    this.Update();
            //    }));
        }
        #endregion
       
    }
}
