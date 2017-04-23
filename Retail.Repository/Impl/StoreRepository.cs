using System.Collections.Generic;
using System.Data;
using System.Linq;
using Retail.Models;
using Retail.MicroORM;


namespace Retail.Repository.Impl
{
    class StoreRepository: AbstractRepository<Store>, IStoreRepository
    {
        private IDbConnection _dbConnection;         
 
        public StoreRepository(IDbConnection dbConnection)
        {
            this._dbConnection = dbConnection;          
        }
        
        protected override IDbConnection GetDbConnection()
        {
            return this._dbConnection;
        }
   
        public override Store Find(int id)
        {
            return
                DbORM.GetEntities<Store>(this.GetDbConnection()).FirstOrDefault();
        }


        public decimal GetAmountOnStore(Product product)
        {
            return
                DbORM.GetEntities<Product>(
                this.GetDbConnection(),
                string.Format(@"select sum(amount) Price from productonstore where product_id = {0}",product.Id)
                )
                .Select<Product,decimal>(p=>p.Price).FirstOrDefault();
        }

        public new System.Collections.IEnumerator GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}
