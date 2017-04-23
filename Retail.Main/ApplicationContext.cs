using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;
using Retail.UI;
using Retail.UI.Actions;
using Retail.Device;
using Retail.Models;
using Retail.Repository;

namespace Retail.Main
{
    public class ApplicationContext: IApplication
    {
        Form form;
        public void SetMainForm(Form form)
        {
            this.form = form;
        }

        public Form GetMainForm()
        {
            return this.form;
        }

        /// <summary>
        /// Получить экземпляр объекта из IoC контейнера
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private T GetInstance<T>()
        {
            return IoC.Container.Instance.Resolve<T>();
        }

        public void Close(bool AnswerEnsure = false)
        {
            if (!AnswerEnsure || 
                MessageBox.Show(this.form, "Вы уверены что хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes )
                this.form.Close();
        }

        public void Help()
        {
           //TODO Реализовать окно справки
        }
     
        public void New(bool silent=false)
        {
            if (!silent)
            {
                ITableControl tableControl = GetInstance<ITableControl>();
                if (tableControl.GetSelectedProduct() != null)
                {
                    if (MessageBox.Show(this.form, "Чек не пустой!\nХотите его очистить?", "Очистка чека!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        ITotalControl totalControl = GetInstance<ITotalControl>();
                        IDetailControl detailControl = GetInstance<IDetailControl>();
                        totalControl.ClearDefault();
                        detailControl.ClearDefault();
                        tableControl.ClearDefault();
                    }
                }
            }

            INewDocumentAction newDocumentAction = GetInstance<INewDocumentAction>();
            newDocumentAction.Execute();
        }       

        public void CashIn()
        {
           ICashInAction cashInAction = GetInstance<ICashInAction>();
           cashInAction.SetOwnerForm(form);
           cashInAction.Execute();
        }

        

        public void CheckOut()
        {
            ICashInAction cashInAction = GetInstance<ICashInAction>();
            if (!cashInAction.Status())
            {
                MessageBox.Show(this.form, "No money - no honey!", "No money?");
                return;
            }

           INewDocumentAction newDocumentAction = GetInstance<INewDocumentAction>();
           if (newDocumentAction.GetDocument() == null)
           {
               MessageBox.Show(this.form, "Money for air!? it is iniquity.", "Wtf?");
               return;
           }

            ICheckoutAction checkOutAction = GetInstance<ICheckoutAction>();
            checkOutAction.Execute();                     
        }

        public void Print()
        {
            //TODO Печатать на принтере копию чека
        }

    
        public void OpenBox()
        {
            //TODO Открыть ящик на кассе
        }

        public void XReport()
        {
           //TODO Печать X-Отчета
        }

        public void ZReport()
        {
            //TODO Печать Z-Отчета
        }

        public User GetCurrentUser()
        {
            return null;
        }


        public void Search()
        {
           
        }
    }
}
