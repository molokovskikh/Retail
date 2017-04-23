using Retail.Device;
using Retail.Models;
using Retail.Repository;
using Retail.UI;
using Retail.UI.Actions;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Retail.Main
{
    class CheckoutAction: ICheckoutAction
    {
        #region Autowiring
        public ICash cash { get; set; }
        public ITableControl tableControl { get; set; }
        public ITotalControl totalControl { get; set; }
        public IDetailControl detailControl { get; set; }
        
        public IApplication application { get; set; }

        public INewDocumentAction newDocumentAction { get; set; }       
 
        public IDocumentRepository documentRepository { get; set; }
        public ISaleRepository saleRepository { get; set; }
               
        #endregion
    

        public void Execute()
        {
            decimal total = this.totalControl.GetTotal();
            decimal cashIn = this.totalControl.GetCashIn();
            decimal oddMoney = cashIn - total;
            
            //Если денег внесли меньше чем  итоговая сумма по чеку
            //То выходим
            if (total>0 && oddMoney < 0)
                return;
                
            //Выбить чек на ККМ
            IEnumerable<ISaleItem> saleItems = tableControl.GetSaleItems();
            cash.Sell(saleItems, cashIn, oddMoney);
            
            //Получим текущий документ продажи
            Document document = newDocumentAction.GetDocument();

            //Запишем регистры по продаже в БД
            this.saleRepository.SaveSale(saleItems, document);
            
            //Закроем документ         
            document.Status = "Исполнен";
            this.documentRepository.Edit(document);

            //Очистим компоненты
            this.totalControl.ClearDefault();
            this.detailControl.ClearDefault();
            this.tableControl.ClearDefault();

            //Создадим новый документ
            application.New();
        }
       

        
    }
}
