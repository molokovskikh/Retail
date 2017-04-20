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
        
        protected override IDbConnection getDbConnection()
        {
            return this._dbConnection;
        }
   
        public override Store Find(int id)
        {
            return
                DbORM.GetEntities<Store>(this.getDbConnection()).FirstOrDefault();
        }
         
    }
}
