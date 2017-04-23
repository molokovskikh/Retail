using System.Collections.Generic;
using System.Data;
using System.Linq;
using Retail.Models;
using Retail.MicroORM;
using Retail.Device;
using Retail.MicroORM.DataAnnotations;


namespace Retail.Repository.Impl
{
    class SaleRepository: AbstractRepository<Sale>, ISaleRepository
    {
        private IDbConnection _dbConnection;         
 
        public SaleRepository(IDbConnection dbConnection)
        {
            this._dbConnection = dbConnection;          
        }
        
        protected override IDbConnection GetDbConnection()
        {
            return this._dbConnection;
        }
   
        public override Sale Find(int id)
        {
            return
                DbORM.GetEntities<Sale>(this.GetDbConnection()).FirstOrDefault();
        }

        [TableName("saleofproduct")]
        internal class SaleDb {

            [Key]
            public int Id { get; set; }

            [DisplayColumn("product_id")]
            public int ProductId { get; set; }
            
            [DisplayColumn("amount")]
            public long Amount { get; set; }
            
            [DisplayColumn("document_id")]
            public int DocumentId { get; set; }            
        }

        public void SaveSale(IEnumerable<ISaleItem> saleItems, Document document)
        {
          //TODO Сделать запись чека в БД            
            DbORM.PutEntities<SaleDb>(
                 saleItems.Aggregate(new List<SaleDb>(), (p, c) =>
                {
                    p.Add(new SaleDb()
                    {
                        ProductId = c.Id,
                        Amount = (long)c.Amount*10000,
                        DocumentId = document.Id
                    });
                    return p;
                }), this.GetDbConnection(),
                 "insert saleofproduct (product_id,amount,document_id) values ({product_id}, {amount}, {document_id})",                   
                 (typeDst,src) => 
                     typeDst.Equals(typeof(decimal)) && (src is long||src is int) 
                   ? ((long)src) / 10000m 
                   : src                    
                );
            
        }

       

        public new System.Collections.IEnumerator GetEnumerator()
        {
            return base.GetEnumerator();
        }
    }
}
