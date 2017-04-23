
using Retail.Models;
using Retail.Repository;
using Retail.UI;
using Retail.UI.Actions;
namespace Retail.Main
{
    class NewDocumentAction: INewDocumentAction
    {

        #region Autowiring
        public ITotalControl totalControl { get; set; }
        public IApplication application { get; set; }
        public IDocumentRepository documentRepository { get; set; }
        public ISaleRepository saleRepository { get; set; }
        #endregion

        Document CurrentDocument;

        public Document GetDocument()
        {       
            return this.CurrentDocument;
        }

        public void Execute()
        {
            if (this.CurrentDocument == null || !"Открыт".Equals(this.CurrentDocument.Status))
            {
                this.CurrentDocument = documentRepository.Add(new Document { Type = "Продажа", Status = "Открыт" });                              
            }

            if(this.CurrentDocument!=null)
                this.totalControl.SetDocument(this.CurrentDocument);
        }
    }
}
