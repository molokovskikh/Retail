using Retail.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retail.Main
{
    public class ApplicationContext: IApplication
    {
        Form form;
        public void SetMainForm(Form form)
        {
            this.form = form;
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

        public void New()
        {
            //TODO Реализовать открытие чека
            //Если чек набран, то спросить нужно ли аннулировать текущий чек
        }

        public void Check()
        {
            //TODO Отбить чек, предварительно спросив ответ на действие
            //После инициализируется новый чек
        }

        public void Print()
        {
            //TODO Печатать на принтере копию чека
        }

        public void Search()
        {
            //TODO Открыть окно поиска и подбора товаров для чека
        }
    }
}
