using System.Collections.Generic;
using System.Data;
using System.Linq;
using Retail.Models;
using Retail.MicroORM;


namespace Retail.Repository.Impl
{
    class SaleRepository: AbstractRepository<Sale>, ISaleRepository
    {
        private IDbConnection _dbConnection;         
 
        public SaleRepository(IDbConnection dbConnection)
        {
            this._dbConnection = dbConnection;          
        }
        
        protected override IDbConnection getDbConnection()
        {
            return this._dbConnection;
        }
   
        public override Sale Find(int id)
        {
            return
                DbORM.GetEntities<Sale>(this.getDbConnection()).FirstOrDefault();
        }
         
    }
}
